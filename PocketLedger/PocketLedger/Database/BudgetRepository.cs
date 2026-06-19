using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace PocketLedger.Database
{
    internal class BudgetRepository
    {
        public void AddBudget(string email, int categoryId, string monthYear, decimal budgetAmount)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                INSERT INTO Budgets (UserID, CategoryID, MonthYear, BudgetAmount)
                SELECT u.UserID, @categoryId, @monthYear, @budget
                FROM Users u
                WHERE u.Email = @email";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@categoryId", categoryId);
            cmd.Parameters.AddWithValue("@monthYear", monthYear);
            cmd.Parameters.AddWithValue("@budget", budgetAmount);

            cmd.ExecuteNonQuery();
        }

        public DataTable GetAllBudgets(string email)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT c.CategoryName AS Category, b.BudgetAmount, b.MonthYear
                FROM Budgets b
                INNER JOIN Users u ON b.UserID = u.UserID
                LEFT JOIN Categories c ON b.CategoryID = c.CategoryID
                WHERE u.Email = @email
                ORDER BY b.MonthYear DESC";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            using var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public decimal GetTotalBudget(string email)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT SUM(b.BudgetAmount)
                FROM Budgets b
                INNER JOIN Users u ON b.UserID = u.UserID
                WHERE u.Email = @email";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            object result = cmd.ExecuteScalar();
            return (result == DBNull.Value || result == null) ? 0 : Convert.ToDecimal(result);
        }

        public DataTable GetCategories()
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = "SELECT CategoryID, CategoryName FROM Categories ORDER BY CategoryName";

            using var cmd = new MySqlCommand(query, conn);
            using var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}