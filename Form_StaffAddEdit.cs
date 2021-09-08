using Npgsql;
using System;
using System.Windows.Forms;

namespace Synth
{
    public partial class Form_StaffAddEdit : Form
    {
        readonly int user_id_edit = 0;
        private readonly Form_StaffManagement form_StaffManagement;
        public Form_StaffAddEdit(int user_id, Form_StaffManagement form_StaffManagement)
        {
            InitializeComponent();
            this.user_id_edit = user_id;
            this.form_StaffManagement = form_StaffManagement;
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_StaffAddEdit_Load(object sender, EventArgs e)
        {
            if (user_id_edit != 0)
            {
                try
                {
                    using var conn = DB.GetConnection();
                    using var cmd = new NpgsqlCommand($"SELECT Name, Phone, Username, Is_Admin, Remarks FROM Users WHERE User_Id = {user_id_edit}", conn);
                    using var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Textbox_Name.Text = reader[0].ToString();
                        Textbox_Phone.Text = reader[1].ToString();
                        Textbox_Username.Text = reader[2].ToString();
                        Checkbox_IsAdmin.Checked = bool.Parse(reader[3].ToString());
                        Textbox_Remarks.Text = reader[4].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DB.Dispose();
                }
            }
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            if (Textbox_Name.Text.Trim() == "" || Textbox_Username.Text.Trim() == "")
            {
                Label_Incorrect.Text = "Name or Username cannot be empty";
                return;
            }

            string name = Textbox_Name.Text;
            string phone = Textbox_Phone.Text;
            string username = Textbox_Username.Text;
            bool is_admin = Checkbox_IsAdmin.Checked;
            string remarks = Textbox_Remarks.Text;

            try
            {
                using var conn = DB.GetConnection();
                if (user_id_edit == 0)
                {
                    using var cmd = new NpgsqlCommand($"INSERT INTO Users (name, phone, username, password, is_admin, remarks) Values (" +
                        $"'{name}', '{phone}', '{username}', '{username}', {is_admin}, '{remarks}')", conn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    using var cmd = new NpgsqlCommand($"UPDATE Users SET name = '{name}', phone = '{phone}', username = '{username}', " +
                        $"password = '{username}', is_admin = {is_admin}, remarks = '{remarks}' WHERE User_ID = {user_id_edit}", conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DB.Dispose();
                form_StaffManagement.RefreshDataGridView("");
                this.Close();
            }
        }
    }
}
