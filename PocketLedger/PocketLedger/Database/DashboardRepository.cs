using MySql.Data.MySqlClient;
using System;

namespace PocketLedger.Database
{
    
    
    
    
    internal class DashboardRepository
    {
        
        
        
        public decimal GetCurrentBalance(string email)
        {
            decimal income  = GetLifetimeTotal(email, "Income");
            decimal expense = GetLifetimeTotal(email, "Expense");
            return income - expense;
        }

        
        
        
        public decimal GetLifetimeTotal(string email, string type)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT COALESCE(SUM(t.Amount), 0)
                FROM Transactions t
                INNER JOIN Users u ON t.UserID = u.UserID
                WHERE u.Email = @email AND t.Type = @type";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@type",  type);

            var result = cmd.ExecuteScalar();
            return (result == DBNull.Value || result == null) ? 0 : Convert.ToDecimal(result);
        }

        
        
        
        public decimal GetMonthTotal(string email, string type)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT COALESCE(SUM(t.Amount), 0)
                FROM Transactions t
                INNER JOIN Users u ON t.UserID = u.UserID
                WHERE u.Email = @email
                  AND t.Type = @type
                  AND YEAR(t.Date)  = YEAR(CURDATE())
                  AND MONTH(t.Date) = MONTH(CURDATE())";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@type",  type);

            var result = cmd.ExecuteScalar();
            return (result == DBNull.Value || result == null) ? 0 : Convert.ToDecimal(result);
        }

        
        
        
        public decimal GetTotalBudget(string email)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT COALESCE(SUM(b.BudgetAmount), 0)
                FROM Budgets b
                INNER JOIN Users u ON b.UserID = u.UserID
                WHERE u.Email = @email";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            var result = cmd.ExecuteScalar();
            return (result == DBNull.Value || result == null) ? 0 : Convert.ToDecimal(result);
        }

        
        
        
        public int GetBudgetCount(string email)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT COUNT(*)
                FROM Budgets b
                INNER JOIN Users u ON b.UserID = u.UserID
                WHERE u.Email = @email";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            var result = cmd.ExecuteScalar();
            return (result == DBNull.Value || result == null) ? 0 : Convert.ToInt32(result);
        }

        
        
        
        public decimal GetMonthlySavingsRate(string email)
        {
            decimal income  = GetMonthTotal(email, "Income");
            decimal expense = GetMonthTotal(email, "Expense");

            if (income == 0) return 0;
            return Math.Round(((income - expense) / income) * 100, 1);
        }

        
        
        
        public int GetMonthTransactionCount(string email)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT COUNT(*)
                FROM Transactions t
                INNER JOIN Users u ON t.UserID = u.UserID
                WHERE u.Email = @email
                  AND YEAR(t.Date)  = YEAR(CURDATE())
                  AND MONTH(t.Date) = MONTH(CURDATE())";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            var result = cmd.ExecuteScalar();
            return (result == DBNull.Value || result == null) ? 0 : Convert.ToInt32(result);
        }
    }
}
