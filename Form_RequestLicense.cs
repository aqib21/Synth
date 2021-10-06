using System;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace Synth
{
    public partial class Form_RequestLicense : Form
    {
        readonly string deviceId;
        readonly Form_Login form_Login;
        public Form_RequestLicense(string deviceId, Form_Login form_Login)
        {
            InitializeComponent();
            this.deviceId = deviceId;
            this.form_Login = form_Login;
        }

        private void Button_Request_Click(object sender, EventArgs e)
        {
            Label_Incorrect.Text = "";

            if (Textbox_Username.Text == "" || Textbox_Company.Text == "")
            {
                Label_Incorrect.Text = "Fields cannot be empty";
                return;
            }

            string username = Textbox_Username.Text;
            string company = Textbox_Company.Text;
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            NpgsqlConnection conn;
            try
            {
                string encodedString = "SG9zdD1lYzItNTQtNzMtMTUyLTM2LmV1LXdlc3QtMS5jb21wdXRlLmFtYXpvbmF3cy5jb207VXNlcm5hbWU9eWx0d2xsYnNkYW5wZ3g7UGFzc3dvcmQ9MTRjZjgzZDU0ZjgyNGIzZWExNzI2ZDQ3NzdiOWRlMWFhMzdlMGI4OGRhODhhMWU3MTU4Mzk4Mzk0MWFlZTVlZDtEYXRhYmFzZT1kNDI1ODVjdXEzaTFhODtQb3J0PTU0MzI7U1NMIE1vZGU9UmVxdWlyZTtUcnVzdCBTZXJ2ZXIgQ2VydGlmaWNhdGU9dHJ1ZQ==";
                byte[] data = Convert.FromBase64String(encodedString);
                string connectionString = Encoding.UTF8.GetString(data);

                conn = new NpgsqlConnection(connectionString);
                conn.Open();

                using var cmd = new NpgsqlCommand($"SELECT * FROM FN_UpdateLicensing('{username}', '{company}', '{date}', '{deviceId}')", conn);
                cmd.ExecuteNonQuery();

                conn.Close();
                conn.Dispose();

                MessageBox.Show("Request has been sent.\nYou will be notified once the license has been activated.", "License Activation Request Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form_Login.RemoveRequestLink(false);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
