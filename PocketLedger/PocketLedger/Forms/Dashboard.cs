using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace PocketLedger.Forms
{
    public partial class Dashboard : Form
    {
        private string loggedEmail;
        Color normalColor = Color.FromArgb(0, 0, 40);
        Color hoverColor = Color.FromArgb(25, 25, 80);
        Color activeColor = Color.FromArgb(40, 40, 120);
        Color originalColor = Color.FromArgb(3, 7, 55);
        public Dashboard(string loggedmail)
        {
            InitializeComponent();

            loggedEmail = loggedmail;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            History historyPage = new History(loggedEmail);
            historyPage.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {


            string greetingText;
            int hour = DateTime.Now.Hour;

            if (hour < 12)
            {
                greetingText = "Good Morning";
            }
            else if (hour < 18)
            {
                greetingText = "Good Afternoon";
            }
            else
            {
                greetingText = "Good Evening";
            }


            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(
                0,
                0,
                profilepic.Width - 1,
                profilepic.Height - 1
            );

            profilepic.Region = new Region(path);

            profilepic.SizeMode = PictureBoxSizeMode.Zoom;

            profilepic.Paint += Profilepic_Paint;

            Database.DataFetch dashBoardLoading = new Database.DataFetch();
            string ProPicPath = dashBoardLoading.profilePicLoad(loggedEmail);
            profilepic.Image = Image.FromFile(ProPicPath);

            profilepic.SizeMode = PictureBoxSizeMode.Zoom;

            string Name = dashBoardLoading.nameLoading(loggedEmail);
            greeting.Text = $"{greetingText}, {Name}!";

        }




        public void Profilepic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using Pen pen = new Pen(Color.White, 2);

            e.Graphics.DrawEllipse(
                pen,
                2,
                2,
                profilepic.Width - 5,
                profilepic.Height - 5
            );
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddTransection transectionForm = new AddTransection();
            transectionForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Sidebar_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            if (panel.BackColor != activeColor)
            {
                panel.BackColor = hoverColor;
            }
        }

        private void Sidebar_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            if (panel.BackColor != activeColor)
            {
                panel.BackColor = originalColor;
            }
        }

        private void Sidebar_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            panel.BackColor = activeColor;

            ResetSidebar();
        }

        private void ResetSidebar()
        {
            homepanel.BackColor = originalColor;
            profilepanel.BackColor = originalColor;
            expensepanel.BackColor = originalColor;
            incomepanel.BackColor = originalColor;
            historypanel.BackColor = originalColor;
            transactionpanel.BackColor = originalColor;
        }




        private void transactionpanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            profile profileLoad = new profile(loggedEmail);
            profileLoad.Show();
        }

        private void profilepic_Click(object sender, EventArgs e)
        {

        }

        private void greeting_Click(object sender, EventArgs e)
        {
        }
    }
}
