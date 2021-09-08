using System;
using System.Windows.Forms;
using Npgsql;

namespace Synth
{
    static class User
    {
        public static int User_ID { get; set; }
        public static string Name { get; set; }
        public static string Phone { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static bool Is_Admin { get; set; }

        public static void UpdateProfile()
        {
            try
            {
                using var conn = DB.GetConnection();
                using var cmd = new NpgsqlCommand($"UPDATE Users SET Name='{User.Name}', Phone='{User.Phone}', Password='{User.Password}' " +
                    $"WHERE User_ID={User.User_ID}", conn);
                cmd.ExecuteNonQuery();
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
}
