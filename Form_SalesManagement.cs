﻿using Npgsql;
using System;
using System.Linq;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Data;
using System.IO;
using System.Configuration;

namespace Synth
{
    public partial class Form_SalesManagement : Form
    {
        public Form_SalesManagement()
        {
            InitializeComponent();
        }

        private void Form_SalesManagement_Load(object sender, EventArgs e)
        {
            RefreshDataGridView("");
        }

        public void RefreshDataGridView(string search)
        {
            try
            {
                using var conn = DB.GetConnection();
                using var cmd = new NpgsqlCommand($"SELECT * FROM FN_GetSales('{search}')", conn);
                using NpgsqlDataAdapter sda = new(cmd);
                DataTable dt = new();
                sda.Fill(dt);

                DataGridView_Sales.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.Dispose();
                DataGridView_Sales.Columns[0].HeaderText = "Sale ID";
                DataGridView_Sales.Columns[1].HeaderText = "Last Name";
                DataGridView_Sales.Columns[2].HeaderText = "First Name";
                DataGridView_Sales.Columns[3].HeaderText = "Phone";
                DataGridView_Sales.Columns[4].HeaderText = "PNR";
                DataGridView_Sales.Columns[5].HeaderText = "Issue Date";
                DataGridView_Sales.Columns[6].HeaderText = "Agent";
                DataGridView_Sales.Columns[7].HeaderText = "Issue Price";
                DataGridView_Sales.Columns[8].HeaderText = "Sale Price";
                DataGridView_Sales.Columns[9].HeaderText = "Profit";
                DataGridView_Sales.Columns[10].HeaderText = "Status";
                DataGridView_Sales.Columns[11].HeaderText = "Amount Paid";
                DataGridView_Sales.Columns[12].HeaderText = "Installment #1";
                DataGridView_Sales.Columns[13].HeaderText = "Ins. #1 Date";
                DataGridView_Sales.Columns[14].HeaderText = "Installment #2";
                DataGridView_Sales.Columns[15].HeaderText = "Ins. #2 Date";
                DataGridView_Sales.Columns[16].HeaderText = "Due Amount";
                DataGridView_Sales.Columns[17].HeaderText = "PCR issue Price";
                DataGridView_Sales.Columns[18].HeaderText = "PCR Sale Price";
                DataGridView_Sales.Columns[19].HeaderText = "PCR Profit";
            }
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            if (DataGridView_Sales.SelectedRows.Count == 0)
            {
                Label_Incorrect.Text = "Select a record to delete.";
                return;
            }

            int Sale_ID = int.Parse(DataGridView_Sales.Rows[DataGridView_Sales.CurrentRow.Index].Cells[0].Value.ToString());

            var confirmResult = MessageBox.Show("Are you sure to delete this sale?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using var conn = DB.GetConnection();
                    using var cmd = new NpgsqlCommand($"SELECT * FROM FN_DeleteSale({Sale_ID})", conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    DB.Dispose();
                    RefreshDataGridView("");
                }
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            if (!Application.OpenForms.OfType<Form_SalesAddEdit>().Any())
            {
                Form_SalesAddEdit form_SalesAddEdit = new(0, this, null);
                form_SalesAddEdit.Show();
            }
            else
            {
                Application.OpenForms["Form_SalesAddEdit"].BringToFront();
            }
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            if (DataGridView_Sales.SelectedRows.Count == 0)
            {
                Label_Incorrect.Text = "Select a record to edit.";
                return;
            }

            int Sales_ID = int.Parse(DataGridView_Sales.Rows[DataGridView_Sales.CurrentRow.Index].Cells[0].Value.ToString());

            if (!Application.OpenForms.OfType<Form_SalesAddEdit>().Any())
            {
                Form_SalesAddEdit form_SalesAddEdit = new(Sales_ID, this, null);
                form_SalesAddEdit.Show();
            }
            else
            {
                Application.OpenForms["Form_SalesAddEdit"].BringToFront();
            }
        }

        private void Textbox_Search_TextChanged(object sender, EventArgs e)
        {
            string search = Textbox_Search.Text;
            RefreshDataGridView(search);
        }

        private void Form_SalesManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.OfType<Form_SalesAddEdit>().Any())
                Application.OpenForms["Form_SalesAddEdit"].Close();
        }

        private void Button_Export_Click(object sender, EventArgs e)
        {
            if (DataGridView_Sales.SelectedRows.Count == 0)
            {
                Label_Incorrect.Text = "You have no records to export.";
                return;
            }

            try
            {
                DataTable dt = new();
                foreach (DataGridViewColumn column in DataGridView_Sales.Columns)
                {
                    dt.Columns.Add(column.HeaderText);
                }
                foreach (DataGridViewRow row in DataGridView_Sales.Rows)
                {
                    if (DataGridView_Sales.Rows.Count > row.Index)
                    {
                        dt.Rows.Add();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            dt.Rows[^1][cell.ColumnIndex] = cell.Value.ToString();
                        }
                    }
                }

                using XLWorkbook workbook = new();
                workbook.Worksheets.Add(dt, "Sales");
                workbook.Worksheet(1).Columns().AdjustToContents();

                SaveFileDialog.FileName = $"Sales Report - {DateTime.Now.ToShortDateString()}";
                SaveFileDialog.InitialDirectory = ConfigurationManager.AppSettings["Path"];

                DialogResult result = SaveFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    workbook.SaveAs(SaveFileDialog.FileName);
                    MessageBox.Show($"File saved as {SaveFileDialog.FileName}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
            if (DataGridView_Sales.SelectedRows.Count == 0)
            {
                Label_Incorrect.Text = "Select a record to print.";
                return;
            }

            int Sales_ID = int.Parse(DataGridView_Sales.Rows[DataGridView_Sales.CurrentRow.Index].Cells[0].Value.ToString());
            if (!Application.OpenForms.OfType<Form_ViewSale>().Any())
            {
                Form_ViewSale form_ViewSale = new(Sales_ID);
                form_ViewSale.Show();
            }
            else
            {
                Application.OpenForms["Form_ViewSale"].BringToFront();
            }
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView("");
        }
    }
}
