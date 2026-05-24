using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Text;


namespace PocketLedger.Database
{
    internal class DashBoardLoading
    {
        public void profilePicLoad(string email, Forms.Dashboard dashboardForm)
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
                    dashboardForm.profilepic.Image = Image.FromFile(profilePicPath);

                    dashboardForm.profilepic.SizeMode = PictureBoxSizeMode.Zoom;

                    GraphicsPath path = new GraphicsPath();
                    path.AddEllipse(0, 0, dashboardForm.profilepic.Width, dashboardForm.profilepic.Height);

                    dashboardForm.profilepic.Region = new Region(path);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load profile picture.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
