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

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
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




            Database.DashBoardLoading dashBoardLoading = new Database.DashBoardLoading();
            dashBoardLoading.profilePicLoad(loggedEmail, this);
        }

        private void profilepic_Click(object sender, EventArgs e)
        {

        }


        private void Profilepic_Paint(object sender, PaintEventArgs e)
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




    }
}
