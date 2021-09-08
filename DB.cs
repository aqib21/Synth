using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using Npgsql;

namespace Synth
{
    class DB
    {
        static NpgsqlConnection conn;

        public static NpgsqlConnection GetConnection()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["db_connection"].ConnectionString;
                conn = new NpgsqlConnection(connectionString);
                conn.Open();
                return conn;
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
