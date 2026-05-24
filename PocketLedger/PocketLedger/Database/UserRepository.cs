using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

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


        public bool Signup(string email, string password)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();
            string query =
                "INSERT INTO users (Email, PasswordHash) VALUES (@email, @password)";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected > 0;
        }
    }
}