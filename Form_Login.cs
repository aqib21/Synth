using System;
using System.Linq;
using System.Windows.Forms;
using Npgsql;
using DeviceId;
using System.Text;

namespace Synth
{
    public partial class Form_Login : Form
    {

        readonly string deviceId = new DeviceIdBuilder()
            .AddMachineName()
            .AddOsVersion()
            .OnWindows(windows => windows
                .AddProcessorId()
                .AddMotherboardSerialNumber()
                .AddSystemDriveSerialNumber())
            .ToString();

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
                    Label_Incorrect.Text = "";
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
                    Label_Incorrect.Text = "Incorrect username or password.";
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
            Label_Version.Text += "1.4.20";
            Button_Login.Enabled = false;
            LinkLabel_RequestLicense.Visible = true;

            NpgsqlConnection conn;
            try
            {
                string encodedString = "SG9zdD1lYzItNTQtNzMtMTUyLTM2LmV1LXdlc3QtMS5jb21wdXRlLmFtYXpvbmF3cy5jb207VXNlcm5hbWU9eWx0d2xsYnNkYW5wZ3g7UGFzc3dvcmQ9MTRjZjgzZDU0ZjgyNGIzZWExNzI2ZDQ3NzdiOWRlMWFhMzdlMGI4OGRhODhhMWU3MTU4Mzk4Mzk0MWFlZTVlZDtEYXRhYmFzZT1kNDI1ODVjdXEzaTFhODtQb3J0PTU0MzI7U1NMIE1vZGU9UmVxdWlyZTtUcnVzdCBTZXJ2ZXIgQ2VydGlmaWNhdGU9dHJ1ZQ==";
                byte[] data = Convert.FromBase64String(encodedString);
                string connectionString = Encoding.UTF8.GetString(data);

                conn = new NpgsqlConnection(connectionString);
                conn.Open();

                using var cmd = new NpgsqlCommand($"SELECT * FROM FN_Licensing('{deviceId}')", conn);
                using var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    bool isLicensed = bool.Parse(reader[0].ToString());
                    string date_requested = reader[1].ToString();

                    if (!isLicensed)
                    {
                        MessageBox.Show("This application is not licensed, please contact your administrator.", "Unlicensed Product", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if(date_requested != "")
                        {
                            RemoveRequestLink(false);
                        }
                    }
                    else
                    {
                        Button_Login.Enabled = true;
                        LinkLabel_RequestLicense.Visible = false;
                    }
                }

                reader.Close();
                conn.Close();
                conn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveRequestLink(bool isVisible)
        {
            LinkLabel_RequestLicense.Visible = isVisible;
            Label_Incorrect.Text = "Please wait for license activation.";
        }

        private void LinkLabel_RequestLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (!Application.OpenForms.OfType<Form_RequestLicense>().Any())
            {
                Form_RequestLicense form_RequestLicense = new(deviceId, this);
                form_RequestLicense.Show();
            }
            else
            {
                Application.OpenForms["Form_RequestLicense"].BringToFront();
            }
        }
    }
}
