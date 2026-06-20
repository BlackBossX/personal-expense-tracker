using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using PocketLedger.Database;

namespace PocketLedger.Forms
{
    public partial class BudgetPlanner : Form
    {
        private readonly BudgetRepository _budgetRepo = new BudgetRepository();
        private string loggedEmail;
        private Action _onUpdate;

        public BudgetPlanner(string loggedmail, Action onUpdate = null)
        {
            InitializeComponent();
            loggedEmail = loggedmail;
            _onUpdate = onUpdate;
        }

        
        
        
        private void BudgetPlanner_Load(object sender, EventArgs e)
        {
            
            string[] months = {
                "January","February","March","April","May","June",
                "July","August","September","October","November","December"
            };
            cmbMonth.Items.AddRange(months);
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1; 

            
            var categoriesTable = _budgetRepo.GetCategories();
            cmbCategory.DataSource = categoriesTable;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = -1;

            LoadBudgetData();
        }

        
        
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedItem == null)
            {
                MessageBox.Show("Please select a month.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Please select a category.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtBudget.Text, out decimal budgetAmount) || budgetAmount <= 0)
            {
                MessageBox.Show("Please enter a valid budget amount.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBudget.Focus();
                return;
            }

            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);
            string monthYear = cmbMonth.SelectedItem.ToString();

            try
            {
                _budgetRepo.AddBudget(loggedEmail, categoryId, monthYear, budgetAmount);
                MessageBox.Show("✅ Budget added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                LoadBudgetData();
                _onUpdate?.Invoke();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add budget: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBudget.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a budget row to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvBudget.SelectedRows[0];

            
            if (row.Cells["BudgetID"]?.Value == null)
            {
                MessageBox.Show("Cannot determine budget ID. Please try again.");
                return;
            }

            int budgetId = Convert.ToInt32(row.Cells["BudgetID"].Value);

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this budget entry?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _budgetRepo.DeleteBudget(budgetId);
                    LoadBudgetData();
                    _onUpdate?.Invoke();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed: " + ex.Message);
                }
            }
        }

        
        
        
        private void LoadBudgetData()
        {
            try
            {
                var dt = _budgetRepo.GetBudgetTableData(loggedEmail);
                dgvBudget.DataSource = dt;

                
                if (dgvBudget.Columns.Contains("BudgetID"))
                    dgvBudget.Columns["BudgetID"].Visible = false;

                
                string[] numCols = { "BudgetAmount", "SpentAmount", "RemainingAmount" };
                foreach (var col in numCols)
                    if (dgvBudget.Columns.Contains(col))
                        dgvBudget.Columns[col].DefaultCellStyle.Format = "N2";

                
                if (dgvBudget.Columns.Contains("Category"))
                    dgvBudget.Columns["Category"].HeaderText = "Category";
                if (dgvBudget.Columns.Contains("Month"))
                    dgvBudget.Columns["Month"].HeaderText = "Month";
                if (dgvBudget.Columns.Contains("BudgetAmount"))
                    dgvBudget.Columns["BudgetAmount"].HeaderText = "Budget (Rs.)";
                if (dgvBudget.Columns.Contains("SpentAmount"))
                    dgvBudget.Columns["SpentAmount"].HeaderText = "Spent (Rs.)";
                if (dgvBudget.Columns.Contains("RemainingAmount"))
                    dgvBudget.Columns["RemainingAmount"].HeaderText = "Remaining (Rs.)";

                
                foreach (DataGridViewRow row in dgvBudget.Rows)
                {
                    string status = row.Cells["Status"]?.Value?.ToString() ?? "";
                    switch (status)
                    {
                        case "Over Budget":
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 80, 80);
                            break;
                        case "Warning":
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 180, 50);
                            break;
                        case "Safe":
                            row.DefaultCellStyle.ForeColor = Color.FromArgb(50, 220, 120);
                            break;
                        default:
                            row.DefaultCellStyle.ForeColor = Color.White;
                            break;
                    }
                }

                UpdateSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load budget data: " + ex.Message);
            }
        }

        
        
        
        private void UpdateSummary()
        {
            decimal totalBudget = _budgetRepo.GetTotalBudget(loggedEmail);
            decimal totalSpent = _budgetRepo.GetTotalSpent(loggedEmail);
            decimal remaining = totalBudget - totalSpent;

            lblTotalBudgetVal.Text = "Rs. " + totalBudget.ToString("N2");
            lblTotalSpentVal.Text = "Rs. " + totalSpent.ToString("N2");
            lblRemainingVal.Text = "Rs. " + remaining.ToString("N2");

            
            if (totalBudget == 0)
            {
                lblStatus.Text = "⚪ No Budget Set";
                lblStatus.ForeColor = Color.Gray;
                panel4.BackColor = Color.FromArgb(30, 30, 60);
            }
            else if (totalSpent >= totalBudget)
            {
                lblStatus.Text = "🔴 Over Budget!";
                lblStatus.ForeColor = Color.FromArgb(255, 80, 80);
                panel4.BackColor = Color.FromArgb(60, 15, 15);
            }
            else if (totalSpent >= totalBudget * 0.70m)
            {
                lblStatus.Text = "🟡 Warning — Nearing Limit";
                lblStatus.ForeColor = Color.FromArgb(255, 200, 50);
                panel4.BackColor = Color.FromArgb(55, 45, 10);
            }
            else
            {
                lblStatus.Text = "✅ Safe";
                lblStatus.ForeColor = Color.FromArgb(50, 220, 120);
                panel4.BackColor = Color.FromArgb(10, 40, 20);
            }
        }

        
        
        
        private void ClearFields()
        {
            cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
            cmbCategory.SelectedIndex = -1;
            txtBudget.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}