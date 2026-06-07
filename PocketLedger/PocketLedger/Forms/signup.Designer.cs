namespace PocketLedger
{
    partial class signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            passwordbox = new TextBox();
            panel1 = new Panel();
            emailbox = new TextBox();
            pictureBox3 = new PictureBox();
            username = new Label();
            panel3 = new Panel();
            usernamebox = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            uploadedlabel = new Label();
            uploadpath = new Label();
            uploadbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_logo;
            pictureBox1.Location = new Point(329, 40);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(307, 353);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 15;
            label3.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(307, 132);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 14;
            label1.Text = "Email: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(passwordbox);
            panel2.Location = new Point(308, 375);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 44);
            panel2.TabIndex = 13;
            // 
            // passwordbox
            // 
            passwordbox.Location = new Point(4, 10);
            passwordbox.Margin = new Padding(4, 3, 4, 3);
            passwordbox.Name = "passwordbox";
            passwordbox.Size = new Size(419, 23);
            passwordbox.TabIndex = 6;
            passwordbox.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(emailbox);
            panel1.Location = new Point(308, 151);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 44);
            panel1.TabIndex = 12;
            // 
            // emailbox
            // 
            emailbox.Location = new Point(4, 10);
            emailbox.Margin = new Padding(4, 3, 4, 3);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(419, 23);
            emailbox.TabIndex = 6;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.signup1;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(397, 435);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(117, 58);
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.White;
            username.Location = new Point(307, 209);
            username.Margin = new Padding(4, 0, 4, 0);
            username.Name = "username";
            username.Size = new Size(84, 23);
            username.TabIndex = 17;
            username.Text = "User Name:";
            // 
            // panel3
            // 
            panel3.Controls.Add(usernamebox);
            panel3.Location = new Point(308, 228);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 44);
            panel3.TabIndex = 13;
            // 
            // usernamebox
            // 
            usernamebox.Location = new Point(4, 10);
            usernamebox.Margin = new Padding(4, 3, 4, 3);
            usernamebox.Name = "usernamebox";
            usernamebox.Size = new Size(419, 23);
            usernamebox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(307, 285);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 18;
            label4.Text = "Student No:";
            // 
            // panel4
            // 
            panel4.Controls.Add(uploadedlabel);
            panel4.Controls.Add(uploadpath);
            panel4.Controls.Add(uploadbtn);
            panel4.Location = new Point(308, 302);
            panel4.Margin = new Padding(4, 3, 4, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 44);
            panel4.TabIndex = 14;
            panel4.Paint += panel4_Paint;
            // 
            // uploadedlabel
            // 
            uploadedlabel.AutoSize = true;
            uploadedlabel.ForeColor = Color.White;
            uploadedlabel.Location = new Point(89, 13);
            uploadedlabel.Name = "uploadedlabel";
            uploadedlabel.Size = new Size(12, 15);
            uploadedlabel.TabIndex = 2;
            uploadedlabel.Text = "-";
            // 
            // uploadpath
            // 
            uploadpath.AutoSize = true;
            uploadpath.ForeColor = Color.White;
            uploadpath.Location = new Point(84, 13);
            uploadpath.Name = "uploadpath";
            uploadpath.Size = new Size(0, 15);
            uploadpath.TabIndex = 1;
            // 
            // uploadbtn
            // 
            uploadbtn.Location = new Point(3, 9);
            uploadbtn.Name = "uploadbtn";
            uploadbtn.Size = new Size(75, 23);
            uploadbtn.TabIndex = 0;
            uploadbtn.Text = "Upload";
            uploadbtn.UseVisualStyleBackColor = true;
            uploadbtn.Click += button1_Click;
            // 
            // signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 42);
            ClientSize = new Size(933, 531);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(panel3);
            Controls.Add(username);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "signup";
            Text = "Sign Up";
            Load += signup_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox emailbox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private Label uploadpath;
        private Button uploadbtn;
        private Label uploadedlabel;
    }
}