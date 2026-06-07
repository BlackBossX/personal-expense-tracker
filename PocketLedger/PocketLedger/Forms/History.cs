using MySql.Data.MySqlClient;
using PocketLedger.Database;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PocketLedger.Forms
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCategories();
                LoadTransactions();

                cmbType.SelectedIndex = 0;

                btnFilter.Click += btnFilter_Click;
                btnClear.Click += btnClear_Click;

                txtSearch.GotFocus += txtSearch_GotFocus;
                txtSearch.LostFocus += txtSearch_LostFocus;
                txtSearch.TextChanged += txtSearch_TextChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }

        private void LoadCategories()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Category load error: " + ex.Message);
            }
        }

        private void LoadTransactions(string category = "All", string type = "All",
                                      DateTime? from = null, DateTime? to = null,
                                      string search = "")
        {
            try
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

                dgvTransactions.DataSource = dt;

                foreach (DataGridViewRow row in dgvTransactions.Rows)
                {
                    string rowType = row.Cells["Type"]?.Value?.ToString() ?? "";
                    if (rowType == "Income")
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(0, 200, 120);
                    else if (rowType == "Expense")
                        row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 80, 80);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction load error: " + ex.Message);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string category = cmbCategory.SelectedItem?.ToString() ?? "All";
            string type = cmbType.SelectedItem?.ToString() ?? "All";
            DateTime? from = dtpFrom.Value.Date;
            DateTime? to = dtpTo.Value.Date;
            string search = txtSearch.Text;

            LoadTransactions(category, type, from, to, search);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = 0;
            cmbType.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Now.AddMonths(-1);
            dtpTo.Value = DateTime.Now;
            txtSearch.Text = "Search...";
            txtSearch.ForeColor = Color.Gray;

            LoadTransactions();
        }

        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
                txtSearch.BackColor = Color.White;
            }
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Search...")
            {
                string category = cmbCategory.SelectedItem?.ToString() ?? "All";
                string type = cmbType.SelectedItem?.ToString() ?? "All";
                LoadTransactions(category, type, search: txtSearch.Text);
            }
        }
    }
}