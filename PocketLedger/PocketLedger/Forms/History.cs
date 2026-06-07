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
        private readonly TransactionRepository _repo = new TransactionRepository();

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            try
            {
                _repo.GetCategories(cmbCategory);
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

        private void LoadTransactions(string category = "All", string type = "All",
                                      DateTime? from = null, DateTime? to = null,
                                      string search = "")
        {
            try
            {
                var dt = _repo.GetTransactions(category, type, from, to, search);
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