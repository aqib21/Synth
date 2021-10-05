using Npgsql;
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
                string folderPath = ConfigurationManager.AppSettings["Path"];
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using XLWorkbook wb = new();
                wb.Worksheets.Add(dt, "Sales");
                wb.Worksheet(1).Columns().AdjustToContents();
                string filePath = folderPath + "SalesReport - " + DateTime.Now.ToShortDateString() + ".xlsx";
                wb.SaveAs(filePath);
                MessageBox.Show($"File saved as {filePath}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
