using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketLedger
{
    public partial class signup : Form
    {
        private string uploadingpath;
        public signup()
        {
            InitializeComponent();
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog open = new OpenFileDialog();

                open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    uploadingpath = open.FileName;
                    uploadedlabel.Text = Path.GetFileName(open.FileName);
                    
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Database.UserRepository signup = new Database.UserRepository();

            string email = emailbox.Text;
            string password = passwordbox.Text;
            string username = usernamebox.Text;
            string uploadedpath = uploadingpath;

            signup.Signup(email, password, username, uploadedpath);
            MessageBox.Show("Signup successful!");

            login loadlogin = new login();
            loadlogin.Show();
        }
    }
}
