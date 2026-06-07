using PocketLedger.Forms;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string email = emailbox.Text;
            string password = passwordbox.Text;

            Database.UserRepository userRepository = new Database.UserRepository();
            userRepository.Login(email, password, this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string username = emailbox.Text;
        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {

            string password = emailbox.Text;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
