using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PocketLedger.Database;



namespace PocketLedger
{
    public partial class BudgetPlanner : Form
    {
        public BudgetPlanner()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelRemaining_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (cmbMonth.Text == "" || cmbCategory.Text == "" || txtBudget.Text == "")
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = @"
        INSERT INTO Budgets (MonthYear, Category, BudgetAmount)
        VALUES (@month, @category, @budget)";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@month", cmbMonth.Text);
                cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                cmd.Parameters.AddWithValue("@budget", txtBudget.Text);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Budget Added Successfully!");

            ClearFields();
            LoadBudgetData();
        }
        private void LoadBudgetData()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT Category, BudgetAmount FROM Budgets";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBudget.DataSource = dt;
            }

            UpdateSummary();
        }
        private void UpdateSummary()
        {
            using (MySqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT SUM(BudgetAmount) FROM Budgets";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                object result = cmd.ExecuteScalar();

                decimal totalBudget = (result == DBNull.Value) ? 0 : Convert.ToDecimal(result);

                lblTotalBudget.Text = "Rs. " + totalBudget;
            }

            // TEMP (we will connect expenses later)
            decimal spent = 0;

            lblTotalSpent.Text = "Rs. " + spent;
            lblRemaining.Text = "Rs. " + (Convert.ToDecimal(lblTotalBudget.Text.Replace("Rs.", "")) - spent);

            // Status logic
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

            cmbCategory.Items.Add("Food");
            cmbCategory.Items.Add("Transport");
            cmbCategory.Items.Add("Bills");
            cmbCategory.Items.Add("Education");
            cmbCategory.Items.Add("Other");

            LoadBudgetData();
        }

    }
    }

