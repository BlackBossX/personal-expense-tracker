using MySql.Data.MySqlClient;
using PocketLedger.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Addexpense : Form
    {
        Dashboard dashboard;

        public Addexpense(Dashboard dashboardForm)
        {
            InitializeComponent();

            dashboard = dashboardForm;

            paymethod.Items.Add("Card");
            paymethod.Items.Add("Cash");
            paymethod.Items.Add("Online");

            category.Items.Add("Food");
            category.Items.Add("Transport");
            category.Items.Add("Bills");
            category.Items.Add("Shopping");
        }

        public Addexpense()
        {
            InitializeComponent();

            paymethod.Items.Add("Card");
            paymethod.Items.Add("Cash");
            paymethod.Items.Add("Online");

            category.Items.Add("Food");
            category.Items.Add("Transport");
            category.Items.Add("Bills");
            category.Items.Add("Shopping");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using var conn = DbConnection.GetConnection();

                conn.Open();

                string query = @"
                INSERT INTO Transactions
                (UserID, Type, Amount, Description, Date)
                VALUES
                (@userId, @type, @amount, @description, @date)";

                using var cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@userId", 1);

                cmd.Parameters.AddWithValue("@type", "Expense");

                cmd.Parameters.AddWithValue("@amount",
                    Convert.ToDecimal(textBox1.Text));

                cmd.Parameters.AddWithValue("@description",
                    category.Text);

                cmd.Parameters.AddWithValue("@date",
                    dateTimePicker1.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Expense Added Successfully");

                if (dashboard != null)
                {
                    dashboard.RefreshDashboard();
                }

                textBox1.Clear();

                paymethod.SelectedIndex = -1;
                category.SelectedIndex = -1;

                dateTimePicker1.Value = DateTime.Now;

                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddIncome addIncome = new AddIncome(dashboard);

            addIncome.Show();
        }
    }
}