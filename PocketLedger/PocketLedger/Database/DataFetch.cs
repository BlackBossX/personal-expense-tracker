using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace PocketLedger.Database
{
    internal class DataFetch
    {
        public string profilePicLoad(string email)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();
            string query =
                "SELECT ProfilePicture FROM users WHERE Email=@email";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                string profilePicPath = cmd.ExecuteScalar()?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(profilePicPath))
                {
                    return profilePicPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }

        public string nameLoading(string email)
        {

            using var conn = DbConnection.GetConnection();
            conn.Open();
            string query =
                "SELECT Username FROM users WHERE Email=@email";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            try
            {
                string userName = cmd.ExecuteScalar()?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(userName))
                {
                    return userName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load user name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "Machan";

        }

    }
}
