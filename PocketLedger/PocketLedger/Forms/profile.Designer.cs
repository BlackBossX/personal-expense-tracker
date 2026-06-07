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
            ((System.ComponentModel.ISupportInitialize)profilepic).BeginInit();
            SuspendLayout();
            // 
            // profilepic
            // 
            profilepic.Location = new Point(533, 51);
            profilepic.Name = "profilepic";
            profilepic.Size = new Size(100, 100);
            profilepic.TabIndex = 9;
            profilepic.TabStop = false;
            // 
            // greeting
            // 
            greeting.AutoSize = true;
            greeting.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greeting.ForeColor = Color.White;
            greeting.Location = new Point(83, 192);
            greeting.Name = "greeting";
            greeting.Size = new Size(21, 28);
            greeting.TabIndex = 13;
            greeting.Text = "-";
            // 
            // emailbox
            // 
            emailbox.AutoSize = true;
            emailbox.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailbox.ForeColor = Color.White;
            emailbox.Location = new Point(83, 220);
            emailbox.Name = "emailbox";
            emailbox.Size = new Size(21, 28);
            emailbox.TabIndex = 14;
            emailbox.Text = "-";
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 42);
            ClientSize = new Size(1199, 708);
            Controls.Add(emailbox);
            Controls.Add(greeting);
            Controls.Add(profilepic);
            Name = "profile";
            Text = "Profile";
            Load += profile_Load;
            ((System.ComponentModel.ISupportInitialize)profilepic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox profilepic;
        public Label greeting;
        public Label emailbox;
    }
}