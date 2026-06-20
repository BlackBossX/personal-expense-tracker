namespace PocketLedger.Forms
{
    partial class profile
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
            profilepic = new PictureBox();
            greeting = new Label();
            emailbox = new Label();
            panelCard = new Panel();
            lblEditProfile = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnChangePic = new Button();
            btnSave = new Button();
            openFileDialogPic = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)profilepic).BeginInit();
            panelCard.SuspendLayout();
            SuspendLayout();
            // 
            // profilepic
            // 
            profilepic.Location = new Point(533, 30);
            profilepic.Name = "profilepic";
            profilepic.Size = new Size(135, 135);
            profilepic.SizeMode = PictureBoxSizeMode.Zoom;
            profilepic.TabIndex = 9;
            profilepic.TabStop = false;
            // 
            // greeting
            // 
            greeting.AutoSize = true;
            greeting.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greeting.ForeColor = Color.White;
            greeting.Location = new Point(83, 50);
            greeting.Name = "greeting";
            greeting.Size = new Size(17, 24);
            greeting.TabIndex = 13;
            greeting.Text = "-";
            greeting.Visible = false;
            // 
            // emailbox
            // 
            emailbox.AutoSize = true;
            emailbox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailbox.ForeColor = Color.White;
            emailbox.Location = new Point(83, 80);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(14, 20);
            emailbox.TabIndex = 14;
            emailbox.Text = "-";
            emailbox.Visible = false;
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.FromArgb(10, 15, 60);
            panelCard.Controls.Add(lblEditProfile);
            panelCard.Controls.Add(lblUsername);
            panelCard.Controls.Add(txtUsername);
            panelCard.Controls.Add(lblEmail);
            panelCard.Controls.Add(txtEmail);
            panelCard.Controls.Add(btnChangePic);
            panelCard.Controls.Add(btnSave);
            panelCard.Location = new Point(350, 190);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(500, 380);
            panelCard.TabIndex = 15;
            // 
            // lblEditProfile
            // 
            lblEditProfile.AutoSize = true;
            lblEditProfile.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditProfile.ForeColor = Color.White;
            lblEditProfile.Location = new Point(30, 20);
            lblEditProfile.Name = "lblEditProfile";
            lblEditProfile.Size = new Size(129, 37);
            lblEditProfile.TabIndex = 0;
            lblEditProfile.Text = "Edit Profile";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Poppins", 11.25F);
            lblUsername.ForeColor = Color.LightGray;
            lblUsername.Location = new Point(30, 80);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 26);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(30, 35, 80);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(35, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(430, 26);
            txtUsername.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Poppins", 11.25F);
            lblEmail.ForeColor = Color.LightGray;
            lblEmail.Location = new Point(30, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(118, 26);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email Address";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(30, 35, 80);
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.DarkGray;
            txtEmail.Location = new Point(35, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(430, 26);
            txtEmail.TabIndex = 4;
            // 
            // btnChangePic
            // 
            btnChangePic.BackColor = Color.FromArgb(40, 45, 90);
            btnChangePic.FlatAppearance.BorderSize = 0;
            btnChangePic.FlatStyle = FlatStyle.Flat;
            btnChangePic.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChangePic.ForeColor = Color.White;
            btnChangePic.Location = new Point(35, 250);
            btnChangePic.Name = "btnChangePic";
            btnChangePic.Size = new Size(180, 40);
            btnChangePic.TabIndex = 5;
            btnChangePic.Text = "Change Picture";
            btnChangePic.UseVisualStyleBackColor = false;
            btnChangePic.Click += btnChangePic_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 100);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(35, 310);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(430, 45);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save Changes";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // openFileDialogPic
            // 
            openFileDialogPic.FileName = "openFileDialogPic";
            openFileDialogPic.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 42);
            ClientSize = new Size(1199, 708);
            Controls.Add(panelCard);
            Controls.Add(emailbox);
            Controls.Add(greeting);
            Controls.Add(profilepic);
            Name = "profile";
            Text = "Profile";
            Load += profile_Load;
            ((System.ComponentModel.ISupportInitialize)profilepic).EndInit();
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox profilepic;
        public Label greeting;
        public Label emailbox;
        private Panel panelCard;
        private Label lblEditProfile;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnChangePic;
        private Button btnSave;
        private OpenFileDialog openFileDialogPic;
    }
}