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
        public Form_SalesAddEdit(int sales_id, Form_SalesManagement form_SalesManagement)
        {
            InitializeComponent();
            this.sales_id_edit = sales_id;
            this.form_SalesManagement = form_SalesManagement;

        }

        private void Form_SalesAddEdit_Load(object sender, EventArgs e)
        {
            RefreshIssueIDCombo();
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
            }
        }
        private void RefreshIssueIDCombo()
        {
            try
            {
                using NpgsqlConnection conn = DB.GetConnection();
                using var cmd = new NpgsqlCommand($"SELECT * FROM Agents", conn);
                using NpgsqlDataAdapter sda = new(cmd);
                DataTable dt = new DataTable();
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
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {

        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
