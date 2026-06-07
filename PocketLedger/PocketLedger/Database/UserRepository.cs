using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using PocketLedger.Forms;

namespace PocketLedger.Database
{
    public class UserRepository
    {
        public void Login(string email, string password, login loginForm)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = 
                "SELECT PasswordHash FROM users WHERE Email=@email";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                bool decryptedIsValid = BCrypt.Net.BCrypt.Verify(password, cmd.ExecuteScalar()?.ToString() ?? string.Empty);
                if (decryptedIsValid)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dashBoardLoad = new Dashboard(email);
                    dashBoardLoad.Show();
                    loginForm.Close();
                }
                else
                {
                    MessageBox.Show("Invalid email or password. Please try again.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid email or password. Please try again.", "Login Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }



        public void Signup(string email, string password,string username,string path,signup signupForm)
        {
            try
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                using var conn = DbConnection.GetConnection();
                conn.Open();
                string query =
                    "INSERT INTO users (Email, PasswordHash,Username,ProfilePicture) VALUES (@email, @password,@username,@path)";
                using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", hashedPassword);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@path", path);
                int rowsAffected = cmd.ExecuteNonQuery();

                MessageBox.Show("Signup successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                login loginPage = new login();
                loginPage.Show();
                signupForm.Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("An error occurred during signup. Please try again.", "Signup Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        public bool UpdateUserProfile(string currentEmail, string newUsername, string newPicPath)
        {
            try
            {
                using var conn = DbConnection.GetConnection();
                conn.Open();
                string query = "UPDATE users SET Username=@username, ProfilePicture=@path WHERE Email=@currentEmail";
                using var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", newUsername);
                cmd.Parameters.AddWithValue("@path", newPicPath);
                cmd.Parameters.AddWithValue("@currentEmail", currentEmail);
                
                int rows = cmd.ExecuteNonQuery();
                return rows > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}