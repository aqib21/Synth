using System;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace Synth
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            Button_Login.Enabled = false;
            try
            {
                string username = Textbox_Username.Text;
                string password = Textbox_Password.Text;

                using var conn = DB.GetConnection();
                using var cmd = new NpgsqlCommand($"SELECT * FROM FN_GetLoginDetails('{username}', '{password}')", conn);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Label_Incorrect.Visible = false;
                    Button_Login.Enabled = true;

                    User.User_ID = int.Parse(reader[0].ToString());
                    User.Name = reader[1].ToString();
                    User.Username = username;
                    User.Is_Admin = bool.Parse(reader[2].ToString());
                    User.Phone = reader[3].ToString();
                    User.Password = password;

                    this.Hide();
                    if (!Application.OpenForms.OfType<Form_Main>().Any())
                    {
                        Form_Main form_Main = new();
                        form_Main.Show();
                    }
                    else
                    {
                        Application.OpenForms["Form_Main"].BringToFront();
                    }

                }
                else
                {
                    Label_Incorrect.Visible = true;
                    Button_Login.Enabled = true;
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

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Textbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button_Login.PerformClick();
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            Label_Version.Text += "1.3.10";
        }
    }
}
