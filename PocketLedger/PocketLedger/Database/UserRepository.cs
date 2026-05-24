using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace PocketLedger.Database
{
    public class UserRepository
    {
        public bool Login(string email, string password)
        {
            using var conn = DbConnection.GetConnection();

            conn.Open();

            string query =
                "SELECT COUNT(*) FROM users WHERE Email=@email AND PasswordHash=@password";

            using var cmd = new MySqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count == 0)
            {
                Console.WriteLine("No login found for email: " + email);
            }

            return count > 0;
        }


        public void Signup(string email, string password,string username,string path)
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
        
        }
    }
}