using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using Npgsql;
using System.Text;

namespace Synth
{
    class DB
    {
        static NpgsqlConnection conn;

        public static NpgsqlConnection GetConnection()
        {
            try
            {
                string encodedString = ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString;
                byte[] data = Convert.FromBase64String(encodedString);
                string connectionString = Encoding.UTF8.GetString(data);

                conn = new NpgsqlConnection(connectionString);
                conn.Open();
                return conn;
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occured!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static void Dispose()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Dispose();
        }
    }
}
