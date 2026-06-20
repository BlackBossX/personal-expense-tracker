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
        private string selectedImagePath;

        public profile(string mail)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
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

            selectedImagePath = dashBoardLoading.profilePicLoad(loggedEmail);
            if (!string.IsNullOrEmpty(selectedImagePath) && System.IO.File.Exists(selectedImagePath))
            {
                profilepic.Image = Image.FromFile(selectedImagePath);
            }

            string name = dashBoardLoading.nameLoading(loggedEmail);
            greeting.Text = $"Hello, {name}!";
            emailbox.Text = loggedEmail;

            
            txtUsername.Text = name;
            txtEmail.Text = loggedEmail;
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

        private void btnChangePic_Click(object sender, EventArgs e)
        {
            if (openFileDialogPic.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialogPic.FileName;
                profilepic.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Username cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Database.UserRepository userRepo = new Database.UserRepository();
            bool success = userRepo.UpdateUserProfile(loggedEmail, txtUsername.Text.Trim(), selectedImagePath);

            if (success)
            {
                MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                greeting.Text = $"Hello, {txtUsername.Text.Trim()}!";
            }
        }
    }
}
