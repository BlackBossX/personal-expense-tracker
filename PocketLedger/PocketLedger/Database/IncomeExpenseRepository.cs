using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace PocketLedger.Database
{
    
    
    
    
    
    internal class IncomeExpenseRepository
    {
        
        
        
        public void AddTransaction(string email, string type, decimal amount,
                                   int categoryId, string paymentMethod,
                                   string notes, DateTime date)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            
            string query = @"
                INSERT INTO Transactions
                    (UserID, Type, Amount, CategoryID, PaymentMethod, Description, Notes, Date)
                SELECT u.UserID, @type, @amount, @categoryId, @paymentMethod, @notes, @notes, @date
                FROM Users u
                WHERE u.Email = @email";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email",         email);
            cmd.Parameters.AddWithValue("@type",          type);
            cmd.Parameters.AddWithValue("@amount",        amount);
            cmd.Parameters.AddWithValue("@categoryId",    categoryId);
            cmd.Parameters.AddWithValue("@paymentMethod", paymentMethod);
            cmd.Parameters.AddWithValue("@notes",         notes ?? "");
            cmd.Parameters.AddWithValue("@date",          date.Date);

            cmd.ExecuteNonQuery();
        }

        
        
        
        public void DeleteTransaction(int transactionId)
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = "DELETE FROM Transactions WHERE TransactionID = @id";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", transactionId);
            cmd.ExecuteNonQuery();
        }

        
        
        
        
        public DataTable GetByType(string email, string type,
                                   string category = "All",
                                   DateTime? from = null, DateTime? to = null,
                                   string search = "")
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT
                    t.TransactionID  AS ID,
                    t.Amount,
                    c.CategoryName   AS Category,
                    t.PaymentMethod,
                    t.Notes,
                    t.Date
                FROM Transactions t
                LEFT JOIN Categories c ON t.CategoryID = c.CategoryID
                INNER JOIN Users u     ON t.UserID     = u.UserID
                WHERE u.Email = @email AND t.Type = @type";

            if (category != "All")
                query += " AND c.CategoryName = @category";
            if (from.HasValue)
                query += " AND t.Date >= @from";
            if (to.HasValue)
                query += " AND t.Date <= @to";
            if (!string.IsNullOrWhiteSpace(search) && search != "Search...")
                query += " AND (t.Notes LIKE @search OR t.Description LIKE @search OR c.CategoryName LIKE @search)";

            query += " ORDER BY t.Date DESC, t.TransactionID DESC";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@type",  type);

            if (category != "All")
                cmd.Parameters.AddWithValue("@category", category);
            if (from.HasValue)
                cmd.Parameters.AddWithValue("@from", from.Value.Date);
            if (to.HasValue)
                cmd.Parameters.AddWithValue("@to", to.Value.Date.AddDays(1).AddSeconds(-1));
            if (!string.IsNullOrWhiteSpace(search) && search != "Search...")
                cmd.Parameters.AddWithValue("@search", "%" + search + "%");

            using var adapter = new MySqlDataAdapter(cmd);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        
        
        
        public decimal GetTotal(string email, string type, string monthYear = "")
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT COALESCE(SUM(t.Amount), 0)
                FROM Transactions t
                INNER JOIN Users u ON t.UserID = u.UserID
                WHERE u.Email = @email AND t.Type = @type";

            if (!string.IsNullOrWhiteSpace(monthYear))
                query += " AND DATE_FORMAT(t.Date, '%M') = @monthYear";

            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@type",  type);
            if (!string.IsNullOrWhiteSpace(monthYear))
                cmd.Parameters.AddWithValue("@monthYear", monthYear);

            var result = cmd.ExecuteScalar();
            return (result == DBNull.Value || result == null) ? 0 : Convert.ToDecimal(result);
        }
    }
}
