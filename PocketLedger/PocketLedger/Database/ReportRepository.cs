using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace PocketLedger.Database
{
    internal class ReportRepository
    {
        public DataTable GetCategoryBreakdown(string email, DateTime? from = null, DateTime? to = null)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT 
                    c.CategoryName AS Category,
                    SUM(t.Amount)  AS Total
                FROM Transactions t
                LEFT JOIN Categories c ON t.CategoryID = c.CategoryID
                INNER JOIN Users u ON t.UserID = u.UserID
                WHERE u.Email = @email
                  AND t.Type = 'Expense'";

            if (from.HasValue)
                query += " AND t.Date >= @from";
            if (to.HasValue)
                query += " AND t.Date <= @to";

            query += " GROUP BY c.CategoryName ORDER BY Total DESC";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            if (from.HasValue)
                cmd.Parameters.AddWithValue("@from", from.Value.Date);
            if (to.HasValue)
                cmd.Parameters.AddWithValue("@to", to.Value.Date.AddDays(1).AddSeconds(-1));

            using var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetIncomeVsExpense(string email, DateTime? from = null, DateTime? to = null)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT 
                    t.Type,
                    SUM(t.Amount) AS Total
                FROM Transactions t
                INNER JOIN Users u ON t.UserID = u.UserID
                WHERE u.Email = @email";

            if (from.HasValue)
                query += " AND t.Date >= @from";
            if (to.HasValue)
                query += " AND t.Date <= @to";

            query += " GROUP BY t.Type";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            if (from.HasValue)
                cmd.Parameters.AddWithValue("@from", from.Value.Date);
            if (to.HasValue)
                cmd.Parameters.AddWithValue("@to", to.Value.Date.AddDays(1).AddSeconds(-1));

            using var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable GetMonthlySummary(string email, DateTime? from = null, DateTime? to = null)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT 
                    DATE_FORMAT(t.Date, '%Y-%m') AS MonthYear,
                    t.Type,
                    SUM(t.Amount) AS Total
                FROM Transactions t
                INNER JOIN Users u ON t.UserID = u.UserID
                WHERE u.Email = @email";

            if (from.HasValue)
                query += " AND t.Date >= @from";
            if (to.HasValue)
                query += " AND t.Date <= @to";

            query += " GROUP BY MonthYear, t.Type ORDER BY MonthYear ASC";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            if (from.HasValue)
                cmd.Parameters.AddWithValue("@from", from.Value.Date);
            if (to.HasValue)
                cmd.Parameters.AddWithValue("@to", to.Value.Date.AddDays(1).AddSeconds(-1));

            using var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}