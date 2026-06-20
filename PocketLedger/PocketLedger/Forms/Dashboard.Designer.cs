namespace PocketLedger.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            pictureBox7 = new PictureBox();
            label8 = new Label();
            greeting = new Label();
            panel1 = new Panel();
            historypanel = new Panel();
            label6 = new Label();
            pictureBox6 = new PictureBox();
            expensepanel = new Panel();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            incomepanel = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            transactionpanel = new Panel();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            homepanel = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            profilepanel = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            profilepic = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel1.SuspendLayout();
            historypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            expensepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            incomepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            transactionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            homepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            profilepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profilepic).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1199, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(47, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_logo;
            pictureBox7.Location = new Point(494, 48);
            pictureBox7.Margin = new Padding(4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(277, 80);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(214, 196);
            label8.Name = "label8";
            label8.Size = new Size(284, 28);
            label8.TabIndex = 11;
            label8.Text = "Let's manage your finances today.";
            // 
            // greeting
            // 
            greeting.AutoSize = true;
            greeting.Font = new Font("Poppins", 12F);
            greeting.ForeColor = Color.White;
            greeting.Location = new Point(214, 168);
            greeting.Name = "greeting";
            greeting.Size = new Size(21, 28);
            greeting.TabIndex = 12;
            greeting.Text = "-";
            greeting.Click += greeting_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 7, 55);
            panel1.Controls.Add(historypanel);
            panel1.Controls.Add(expensepanel);
            panel1.Controls.Add(incomepanel);
            panel1.Controls.Add(transactionpanel);
            panel1.Controls.Add(homepanel);
            panel1.Controls.Add(profilepanel);
            panel1.Controls.Add(profilepic);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 24);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 684);
            panel1.TabIndex = 15;
            // 
            // historypanel
            // 
            historypanel.Controls.Add(label6);
            historypanel.Controls.Add(pictureBox6);
            historypanel.Location = new Point(2, 589);
            historypanel.Margin = new Padding(3, 4, 3, 4);
            historypanel.Name = "historypanel";
            historypanel.Size = new Size(163, 84);
            historypanel.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(61, 53);
            label6.Name = "label6";
            label6.Size = new Size(50, 22);
            label6.TabIndex = 14;
            label6.Text = "History";
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(68, 16);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 36);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click_1;
            // 
            // expensepanel
            // 
            expensepanel.Controls.Add(pictureBox3);
            expensepanel.Controls.Add(label3);
            expensepanel.Location = new Point(2, 503);
            expensepanel.Margin = new Padding(3, 4, 3, 4);
            expensepanel.Name = "expensepanel";
            expensepanel.Size = new Size(163, 84);
            expensepanel.TabIndex = 19;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(65, 16);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 36);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(60, 53);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 11;
            label3.Text = "Report";
            label3.Click += label3_Click;
            // 
            // incomepanel
            // 
            incomepanel.Controls.Add(pictureBox2);
            incomepanel.Controls.Add(label2);
            incomepanel.Location = new Point(2, 416);
            incomepanel.Margin = new Padding(3, 4, 3, 4);
            incomepanel.Name = "incomepanel";
            incomepanel.Size = new Size(163, 84);
            incomepanel.TabIndex = 18;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(65, 14);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 36);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 54);
            label2.Name = "label2";
            label2.Size = new Size(52, 22);
            label2.TabIndex = 10;
            label2.Text = "Budget";
            // 
            // transactionpanel
            // 
            transactionpanel.Controls.Add(pictureBox5);
            transactionpanel.Controls.Add(label5);
            transactionpanel.Location = new Point(1, 329);
            transactionpanel.Margin = new Padding(3, 4, 3, 4);
            transactionpanel.Name = "transactionpanel";
            transactionpanel.Size = new Size(163, 84);
            transactionpanel.TabIndex = 17;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(66, 15);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 36);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(57, 49);
            label5.Name = "label5";
            label5.Size = new Size(58, 22);
            label5.TabIndex = 13;
            label5.Text = "Expense";
            // 
            // homepanel
            // 
            homepanel.Controls.Add(label4);
            homepanel.Controls.Add(pictureBox4);
            homepanel.Location = new Point(1, 243);
            homepanel.Margin = new Padding(3, 4, 3, 4);
            homepanel.Name = "homepanel";
            homepanel.Size = new Size(163, 84);
            homepanel.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 50);
            label4.Name = "label4";
            label4.Size = new Size(55, 22);
            label4.TabIndex = 12;
            label4.Text = "Income";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(66, 16);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 36);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click_2;
            // 
            // profilepanel
            // 
            profilepanel.Controls.Add(pictureBox1);
            profilepanel.Controls.Add(label1);
            profilepanel.Location = new Point(1, 157);
            profilepanel.Margin = new Padding(3, 4, 3, 4);
            profilepanel.Name = "profilepanel";
            profilepanel.Size = new Size(163, 84);
            profilepanel.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(67, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 36);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 55);
            label1.Name = "label1";
            label1.Size = new Size(46, 22);
            label1.TabIndex = 9;
            label1.Text = "Profile";
            // 
            // profilepic
            // 
            profilepic.Location = new Point(41, 26);
            profilepic.Margin = new Padding(3, 4, 3, 4);
            profilepic.Name = "profilepic";
            profilepic.Size = new Size(90, 90);
            profilepic.TabIndex = 8;
            profilepic.TabStop = false;
            profilepic.Click += profilepic_Click_1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 42);
            ClientSize = new Size(1199, 708);
            Controls.Add(panel1);
            Controls.Add(greeting);
            Controls.Add(label8);
            Controls.Add(pictureBox7);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel1.ResumeLayout(false);
            historypanel.ResumeLayout(false);
            historypanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            expensepanel.ResumeLayout(false);
            expensepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            incomepanel.ResumeLayout(false);
            incomepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            transactionpanel.ResumeLayout(false);
            transactionpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            homepanel.ResumeLayout(false);
            homepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            profilepanel.ResumeLayout(false);
            profilepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)profilepic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private PictureBox pictureBox7;
        private Label label8;
        public Label greeting;
        private Panel panel1;
        private Panel historypanel;
        private Label label6;
        private PictureBox pictureBox6;
        private Panel expensepanel;
        private PictureBox pictureBox5;
        private Label label5;
        private Panel incomepanel;
        private Label label4;
        private PictureBox pictureBox4;
        private Panel transactionpanel;
        private Label label3;
        private PictureBox pictureBox3;
        private Panel homepanel;
        private Label label2;
        private Panel profilepanel;
        private PictureBox pictureBox1;
        private Label label1;
        public PictureBox profilepic;
        private PictureBox pictureBox2;
    }
}