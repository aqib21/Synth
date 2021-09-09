using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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
                using var cmd = new NpgsqlCommand($"SELECT  FROM Sales " + search, conn);
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
            int Sale_ID = int.Parse(DataGridView_Sales.Rows[DataGridView_Sales.CurrentRow.Index].Cells[0].Value.ToString());

            var confirmResult = MessageBox.Show("Are you sure to delete this sale?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using var conn = DB.GetConnection();
                    using var cmd = new NpgsqlCommand($"DELETE FROM Sales WHERE User_ID={Sale_ID}", conn);
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
                Form_SalesAddEdit form_SalesAddEdit = new(0, this);
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
            int Sales_ID = int.Parse(DataGridView_Sales.Rows[DataGridView_Sales.CurrentRow.Index].Cells[0].Value.ToString());

            if (!Application.OpenForms.OfType<Form_SalesAddEdit>().Any())
            {
                Form_SalesAddEdit form_SalesAddEdit = new(Sales_ID, this);
                form_SalesAddEdit.Show();
            }
            else
            {
                Application.OpenForms["Form_SalesAddEdit"].BringToFront();
            }
        }

        private void Textbox_Search_TextChanged(object sender, EventArgs e)
        {
            string search = $"WHERE Name like '%{Textbox_Search.Text}%' OR Username like '%{Textbox_Search.Text}%'";
            RefreshDataGridView(search);
        }

        private void Form_SalesManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.OfType<Form_SalesAddEdit>().Any())
                Application.OpenForms["Form_SalesAddEdit"].Close();
        }
    }
}
