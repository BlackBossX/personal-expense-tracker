using MySql.Data.MySqlClient;
using PocketLedger.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project
{
    public partial class AddIncome : Form
    {
        Dashboard dashboard;

        public AddIncome(Dashboard dashboardForm)
        {
            InitializeComponent();

            dashboard = dashboardForm;

            comboBox1.Items.Add("USD");
            comboBox1.Items.Add("EUR");
            comboBox1.Items.Add("LKR");

            comboBox2.Items.Add("Salary");
            comboBox2.Items.Add("Business");
            comboBox2.Items.Add("Investment");
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

                cmd.Parameters.AddWithValue("@type", "Income");

                cmd.Parameters.AddWithValue("@amount",
                    Convert.ToDecimal(textBox1.Text));

                cmd.Parameters.AddWithValue("@description",
                    comboBox2.Text);

                cmd.Parameters.AddWithValue("@date",
                    dateTimePicker1.Value);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Income Added Successfully");

                if (dashboard != null)
                {
                    dashboard.RefreshDashboard();
                }

                textBox1.Clear();

                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;

                dateTimePicker1.Value = DateTime.Now;

                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}