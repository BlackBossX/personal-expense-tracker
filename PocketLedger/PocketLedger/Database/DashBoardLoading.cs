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

        public void greeting(string email, Forms.Dashboard dashboardForm)
        {

            string greetingText;
            int hour = DateTime.Now.Hour;

            if (hour < 12)
            {
                greetingText = "Good Morning";
            }
            else if (hour < 18)
            {
                greetingText = "Good Afternoon";
            }
            else
            {
                greetingText = "Good Evening";
            }


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
                    // Assuming you have a label named 'nameLabel' on your dashboard form
                    dashboardForm.greeting.Text = $"{greetingText}, {userName}!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load user name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            { }

        }
    }
}
