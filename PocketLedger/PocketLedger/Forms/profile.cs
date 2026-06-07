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
    public partial class profile : Form
    {
        private string loggedEmail;
        public profile(string mail)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            loggedEmail = mail;
        }

        private void profile_Load(object sender, EventArgs e)
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

            Database.DataFetch dashBoardLoading =new Database.DataFetch();

            string picPath = dashBoardLoading.profilePicLoad(loggedEmail);
            profilepic.Image = Image.FromFile(picPath);

            string name = dashBoardLoading.nameLoading(loggedEmail);
            greeting.Text = $"Hello, {name}!";

            emailbox.Text = loggedEmail;
        }

        private void Profilepic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.White, 2))
            {
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
}
