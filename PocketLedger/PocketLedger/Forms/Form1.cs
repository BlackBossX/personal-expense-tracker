using MySql.Data.MySqlClient;
using PocketLedger.Database;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            using var conn = DbConnection.GetConnection();

            conn.Open();

            string incomeQuery =
                "SELECT IFNULL(SUM(Amount),0) FROM Transactions WHERE Type='Income'";

            using var incomeCmd = new MySqlCommand(incomeQuery, conn);

            decimal totalIncome =
                Convert.ToDecimal(incomeCmd.ExecuteScalar());

            string expenseQuery =
                "SELECT IFNULL(SUM(Amount),0) FROM Transactions WHERE Type='Expense'";

            using var expenseCmd = new MySqlCommand(expenseQuery, conn);

            decimal totalExpense =
                Convert.ToDecimal(expenseCmd.ExecuteScalar());

            decimal netBalance = totalIncome - totalExpense;

            label14.Text = totalIncome.ToString("N2");
            label15.Text = totalExpense.ToString("N2");
            label16.Text = netBalance.ToString("N2");
        }

        public void RefreshDashboard()
        {
            LoadDashboardData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddIncome addIncome = new AddIncome(this);

            addIncome.Show();
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddIncome addIncome = new AddIncome(this);

            addIncome.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Addexpense addExpense = new Addexpense(this);

            addExpense.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Addexpense addExpense = new Addexpense(this);

            addExpense.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}