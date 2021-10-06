using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace Synth
{
    public partial class Form_SalesAddEdit : Form
    {
        readonly int sales_id_edit = 0;
        private readonly Form_SalesManagement form_SalesManagement;
        private readonly Form_Main form_Main;
        public Form_SalesAddEdit(int sales_id, Form_SalesManagement form_SalesManagement, Form_Main form_Main)
        {
            InitializeComponent();
            this.sales_id_edit = sales_id;
            this.form_SalesManagement = form_SalesManagement;
            this.form_Main = form_Main;

        }

        private void Form_SalesAddEdit_Load(object sender, EventArgs e)
        {
            static void func(Control.ControlCollection controls)
            {
                foreach (Control control in controls)
                    if (control is NumericUpDown)
                        (control as NumericUpDown).Controls.RemoveAt(0);
                    else
                        func(control.Controls);
            }
            func(Controls);

            RefreshIssueIDCombo();

            if (sales_id_edit != 0)
            {
                try
                {
                    using var conn = DB.GetConnection();
                    using var cmd = new NpgsqlCommand($"SELECT * FROM FN_GetSale({sales_id_edit})", conn);
                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Textbox_LastName.Text = reader[0].ToString();
                        Textbox_FirstName.Text = reader[1].ToString();
                        Textbox_Phone.Text = reader[2].ToString();
                        Textbox_PNR.Text = reader[3].ToString();
                        DateTimePicker_IssueDate.Value = DateTime.Parse(reader[4].ToString());
                        Combobox_IssueID.SelectedItem = reader[5].ToString();
                        Numeric_IssuePrice.Value = decimal.Parse(reader[6].ToString());
                        Numeric_SalesPrice.Value = decimal.Parse(reader[7].ToString());
                        Combobox_Status.SelectedIndex = Combobox_Status.FindStringExact(reader[8].ToString());
                        Numeric_AmountPaid.Value = decimal.Parse(reader[9].ToString());
                        Numeric_Installment1.Value = decimal.Parse(reader[10].ToString());
                        DateTimePicker_Payment1.Value = DateTime.Parse(reader[11].ToString());
                        Numeric_Installment2.Value = decimal.Parse(reader[12].ToString());
                        DateTimePicker_Payment2.Value = DateTime.Parse(reader[13].ToString());
                        Numeric_DueAmount.Value = decimal.Parse(reader[14].ToString());
                        Numeric_PCRIssuePrice.Value = decimal.Parse(reader[15].ToString());
                        Numeric_PCRSalePrice.Value = decimal.Parse(reader[16].ToString());
                    }
                    reader.Close();
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
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton_Yes.Checked)
            {
                GroupBox_PCR.Enabled = true;
            }
            else
            {
                GroupBox_PCR.Enabled = false;
                Numeric_PCRIssuePrice.Value = 0;
                Numeric_PCRSalePrice.Value = 0;
            }
        }
        private void RefreshIssueIDCombo()
        {
            try
            {
                using NpgsqlConnection conn = DB.GetConnection();
                using var cmd = new NpgsqlCommand($"SELECT * FROM FN_GetAgents('')", conn);
                using NpgsqlDataAdapter sda = new(cmd);
                DataTable dt = new();
                sda.Fill(dt);

                DataRow row = dt.NewRow();
                row[0] = 0;
                dt.Rows.InsertAt(row, 0);

                Combobox_IssueID.DataSource = dt;
                Combobox_IssueID.DisplayMember = "name";
                Combobox_IssueID.ValueMember = "agent_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.Dispose();
                Combobox_Status.SelectedIndex = 0;
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            string LastName = Textbox_LastName.Text.Trim();
            string FirstName = Textbox_FirstName.Text.Trim();
            string Phone = Textbox_Phone.Text.Trim();
            string PNR = Textbox_PNR.Text.Trim();
            string IssueDate = DateTimePicker_IssueDate.Value.ToString("yyyy-MM-dd");
            string Issue_ID = "";
            if (Combobox_IssueID.SelectedItem is DataRowView dataRowView) Issue_ID = dataRowView.Row["name"].ToString();
            decimal Issue_Price = Numeric_IssuePrice.Value;
            decimal SalePrice = Numeric_SalesPrice.Value;
            string Status = Combobox_Status.SelectedItem.ToString();
            decimal AmountPaid = Numeric_AmountPaid.Value;
            decimal Installment1 = Numeric_Installment1.Value;
            string Payment1Date = DateTimePicker_Payment1.Value.ToString("yyyy-MM-dd");
            decimal Installment2 = Numeric_Installment2.Value;
            string Payment2Date = DateTimePicker_Payment2.Value.ToString("yyyy-MM-dd");
            decimal DueAmount = Numeric_DueAmount.Value;
            decimal PCRIssuePrice = Numeric_PCRIssuePrice.Value;
            decimal PCRSalePrice = Numeric_PCRSalePrice.Value;

            if (LastName == "" || FirstName == "" || Phone == "" || PNR == "" || Issue_ID == "")
            {
                Label_Incorrect.Text = "Fields cannot be empty.";
                return;
            }

            if (Numeric_DueAmount.Value < 0)
            {
                Label_Incorrect.Text = "Due amount cannot be negative.";
                return;
            }

            try
            {
                using var conn = DB.GetConnection();
                if (sales_id_edit == 0)
                {
                    using var cmd = new NpgsqlCommand($"SELECT * FROM FN_InsertSales(" +
                        $"'{LastName}', " +
                        $"'{FirstName}', " +
                        $"'{Phone}', " +
                        $"'{PNR}', " +
                        $"'{IssueDate}', " +
                        $"'{Issue_ID}', " +
                        $"{Issue_Price}, " +
                        $"{SalePrice}, " +
                        $"'{Status}', " +
                        $"{AmountPaid}, " +
                        $"{Installment1}, " +
                        $"'{Payment1Date}', " +
                        $"{Installment2}, " +
                        $"'{Payment2Date}', " +
                        $"{DueAmount}, " +
                        $"{PCRIssuePrice}, " +
                        $"{PCRSalePrice}, " +
                        $"null," +
                        $"{User.User_ID})", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    using var cmd = new NpgsqlCommand($"SELECT * FROM FN_UpdateSales(" +
                        $"'{LastName}', " +
                        $"'{FirstName}', " +
                        $"'{Phone}', " +
                        $"'{PNR}', " +
                        $"'{IssueDate}', " +
                        $"'{Issue_ID}', " +
                        $"{Issue_Price}, " +
                        $"{SalePrice}, " +
                        $"'{Status}', " +
                        $"{AmountPaid}, " +
                        $"{Installment1}, " +
                        $"'{Payment1Date}', " +
                        $"{Installment2}, " +
                        $"'{Payment2Date}', " +
                        $"{DueAmount}, " +
                        $"{PCRIssuePrice}, " +
                        $"{PCRSalePrice}, " +
                        $"null," +
                        $"{User.User_ID}), " +
                        $"{sales_id_edit}", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Label_Incorrect.Text = ex.Message;
            }
            finally
            {
                DB.Dispose();
                if(form_SalesManagement != null) form_SalesManagement.RefreshDataGridView("");
                if(form_Main != null) form_Main.RefreshPNRCombo();
                this.Close();
            }

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Combobox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Combobox_Status.SelectedItem.ToString() == "Pending")
            {
                Numeric_DueAmount.Value = Numeric_SalesPrice.Value;
                Numeric_AmountPaid.Value = Numeric_Installment1.Value = Numeric_Installment2.Value = 0;
                EnableInstallments(false);
            } else if (Combobox_Status.SelectedItem.ToString() == "Partial Payment")
            {
                Numeric_DueAmount.Value = Numeric_SalesPrice.Value;
                Numeric_AmountPaid.Value = 0;
                EnableInstallments(true);
            }
            else
            {
                Numeric_DueAmount.Value = Numeric_Installment1.Value = Numeric_Installment2.Value = 0;
                Numeric_AmountPaid.Value = Numeric_SalesPrice.Value;
                EnableInstallments(false);
            }
        }

        private void EnableInstallments(bool isEnabled)
        {
            Numeric_Installment1.Enabled = isEnabled;
            DateTimePicker_Payment1.Enabled = isEnabled;
            Numeric_Installment2.Enabled = isEnabled;
            DateTimePicker_Payment2.Enabled = isEnabled;
        }

        private void Numeric_SalesPrice_ValueChanged(object sender, EventArgs e)
        {
            Numeric_DueAmount.Value = Numeric_SalesPrice.Value;
        }

        private void Numeric_Installment_ValueChanged(object sender, EventArgs e)
        {
            Numeric_AmountPaid.Value = Numeric_Installment1.Value + Numeric_Installment2.Value;
            Numeric_DueAmount.Value = Numeric_SalesPrice.Value - Numeric_Installment1.Value - Numeric_Installment2.Value;
        }
    }
}
