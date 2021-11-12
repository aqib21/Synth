using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Synth
{
    public partial class Form_StaffManagement : Form
    {
        public Form_StaffManagement()
        {
            InitializeComponent();
        }

        private void Form_StaffManagement_Load(object sender, EventArgs e)
        {
            RefreshDataGridView("");
        }

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            if (DataGridView_Staff.SelectedRows.Count == 0)
            {
                Label_Incorrect.Text = "Select a record to delete.";
                return;
            }

            int User_ID = int.Parse(DataGridView_Staff.Rows[DataGridView_Staff.CurrentRow.Index].Cells[0].Value.ToString());

            if (User_ID == User.User_ID)
            {
                Label_Incorrect.Text = "You cannot delete your own account!";
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this staff?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    using var conn = DB.GetConnection();
                    using var cmd = new NpgsqlCommand($"SELECT * FROM FN_DeleteUser({User_ID})", conn);
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

        public void RefreshDataGridView(string search)
        {
            try
            {
                using var conn = DB.GetConnection();
                using var cmd = new NpgsqlCommand($"SELECT * FROM FN_GetUsers('{search}')", conn);
                using NpgsqlDataAdapter sda = new(cmd);
                DataTable dt = new();
                sda.Fill(dt);

                DataGridView_Staff.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DB.Dispose();
                DataGridView_Staff.Columns[0].HeaderText = "Staff ID";
                DataGridView_Staff.Columns[1].HeaderText = "Name";
                DataGridView_Staff.Columns[0].HeaderText = "Phone";
                DataGridView_Staff.Columns[0].HeaderText = "Username";
                DataGridView_Staff.Columns[0].HeaderText = "Admin";
                DataGridView_Staff.Columns[0].HeaderText = "Remarks";
            }
        }

        private void Button_Edit_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            if (DataGridView_Staff.SelectedRows.Count == 0)
            {
                Label_Incorrect.Text = "Select a record to edit.";
                return;
            }

            int User_ID = int.Parse(DataGridView_Staff.Rows[DataGridView_Staff.CurrentRow.Index].Cells[0].Value.ToString());

            if (User_ID == User.User_ID)
            {
                if (!Application.OpenForms.OfType<Form_Profile>().Any())
                {
                    Form_Profile form_Profile = new();
                    form_Profile.Show();
                }
                else
                {
                    Application.OpenForms["Form_Profile"].BringToFront();
                }
            }
            else
            {
                if (!Application.OpenForms.OfType<Form_StaffAddEdit>().Any())
                {
                    Form_StaffAddEdit form_StaffAddEdit = new(User_ID, this);
                    form_StaffAddEdit.Show();
                }
                else
                {
                    Application.OpenForms["Form_StaffAddEdit"].BringToFront();
                }
            }
        }

        private void Button_Add_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            if (!Application.OpenForms.OfType<Form_StaffAddEdit>().Any())
            {
                Form_StaffAddEdit form_StaffAddEdit = new(0, this);
                form_StaffAddEdit.Show();
            }
            else
            {
                Application.OpenForms["Form_StaffAddEdit"].BringToFront();
            }
        }

        private void Form_StaffManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.OfType<Form_StaffAddEdit>().Any())
                Application.OpenForms["Form_StaffAddEdit"].Close();
        }

        private void Textbox_Search_TextChanged(object sender, EventArgs e)
        {
            string search = Textbox_Search.Text;
            RefreshDataGridView(search);
        }

        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGridView("");
        }
    }
}
