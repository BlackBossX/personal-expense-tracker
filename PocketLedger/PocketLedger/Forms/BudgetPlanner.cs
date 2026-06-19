using System;
using System.Windows.Forms;
using PocketLedger.Database;

namespace PocketLedger.Forms
{
    public partial class BudgetPlanner : Form
    {
        private readonly BudgetRepository _budgetRepo = new BudgetRepository();
        private string loggedEmail;

        public BudgetPlanner(string loggedmail)
        {
            InitializeComponent();
            loggedEmail = loggedmail;
            this.Load += BudgetPlanner_Load;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbMonth.Text == "" || cmbCategory.SelectedValue == null || txtBudget.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            if (!decimal.TryParse(txtBudget.Text, out decimal budgetAmount))
            {
                MessageBox.Show("Please enter a valid budget amount.");
                return;
            }

            int categoryId = Convert.ToInt32(cmbCategory.SelectedValue);

            _budgetRepo.AddBudget(loggedEmail, categoryId, cmbMonth.Text, budgetAmount);

            MessageBox.Show("Budget Added Successfully!");

            ClearFields();
            LoadBudgetData();
        }

        private void LoadBudgetData()
        {
            dgvBudget.DataSource = _budgetRepo.GetAllBudgets(loggedEmail);
            UpdateSummary();
        }

        private void UpdateSummary()
        {
            decimal totalBudget = _budgetRepo.GetTotalBudget(loggedEmail);
            lblTotalBudget.Text = "Rs. " + totalBudget;

            // TEMP (we will connect expenses later)
            decimal spent = 0;

            lblTotalSpent.Text = "Rs. " + spent;
            lblRemaining.Text = "Rs. " + (totalBudget - spent);

            if (spent == 0)
            {
                lblStatus.Text = "Safe";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
        }

        private void ClearFields()
        {
            cmbMonth.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtBudget.Clear();
        }

        private void BudgetPlanner_Load(object sender, EventArgs e)
        {
            
            cmbMonth.Items.Add("January");
            cmbMonth.Items.Add("February");
            cmbMonth.Items.Add("March");
            cmbMonth.Items.Add("April");

            var categoriesTable = _budgetRepo.GetCategories();
            cmbCategory.DataSource = categoriesTable;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryID";
            cmbCategory.SelectedIndex = -1;

            LoadBudgetData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panelRemaining_Paint(object sender, PaintEventArgs e) { }
    }
}