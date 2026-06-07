using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace PocketLedger.Database
{
    internal class TransactionRepository
    {
        public DataTable GetTransactions(string category = "All", string type = "All",
                                         DateTime? from = null, DateTime? to = null,
                                         string search = "")
        {
            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = @"
                SELECT 
                    t.TransactionID  AS ID,
                    t.Type,
                    t.Amount,
                    c.CategoryName   AS Category,
                    t.Description,
                    t.Date
                FROM Transactions t
                LEFT JOIN Categories c ON t.CategoryID = c.CategoryID
                WHERE 1=1";

            if (category != "All")
                query += " AND c.CategoryName = @category";
            if (type != "All")
                query += " AND t.Type = @type";
            if (from.HasValue)
                query += " AND t.Date >= @from";
            if (to.HasValue)
                query += " AND t.Date <= @to";
            if (!string.IsNullOrWhiteSpace(search) && search != "Search...")
                query += " AND (t.Description LIKE @search OR c.CategoryName LIKE @search)";

            query += " ORDER BY t.TransactionID ASC";

            using var cmd = new MySqlCommand(query, conn);

            if (category != "All")
                cmd.Parameters.AddWithValue("@category", category);
            if (type != "All")
                cmd.Parameters.AddWithValue("@type", type);
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

        public void GetCategories(System.Windows.Forms.ComboBox cmbCategory)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");

            using var conn = DbConnection.GetConnection();
            conn.Open();

            string query = "SELECT DISTINCT CategoryName FROM Categories ORDER BY CategoryName";
            using var cmd = new MySqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string cat = reader["CategoryName"]?.ToString() ?? string.Empty;
                if (!string.IsNullOrWhiteSpace(cat))
                    cmbCategory.Items.Add(cat);
            }

            cmbCategory.SelectedIndex = 0;
        }
    }
}