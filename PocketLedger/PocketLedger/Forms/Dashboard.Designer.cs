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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1 = new Panel();
            historypanel = new Panel();
            label6 = new Label();
            expensepanel = new Panel();
            label5 = new Label();
            incomepanel = new Panel();
            label4 = new Label();
            transactionpanel = new Panel();
            label3 = new Label();
            homepanel = new Panel();
            label2 = new Label();
            profilepanel = new Panel();
            label1 = new Label();
            profilepic = new PictureBox();
            pictureBox7 = new PictureBox();
            label8 = new Label();
            greeting = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            historypanel.SuspendLayout();
            expensepanel.SuspendLayout();
            incomepanel.SuspendLayout();
            transactionpanel.SuspendLayout();
            homepanel.SuspendLayout();
            profilepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profilepic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(933, 24);
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
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(52, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 27);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(51, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 27);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(51, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 27);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(50, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(27, 27);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(50, 11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(27, 27);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(51, 9);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(27, 27);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
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
            panel1.Name = "panel1";
            panel1.Size = new Size(130, 507);
            panel1.TabIndex = 8;
            // 
            // historypanel
            // 
            historypanel.Controls.Add(label6);
            historypanel.Controls.Add(pictureBox6);
            historypanel.Location = new Point(2, 442);
            historypanel.Name = "historypanel";
            historypanel.Size = new Size(127, 63);
            historypanel.TabIndex = 20;
            historypanel.Click += Sidebar_Click;
            historypanel.MouseEnter += Sidebar_MouseEnter;
            historypanel.MouseLeave += Sidebar_MouseLeave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 8.25F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(39, 37);
            label6.Name = "label6";
            label6.Size = new Size(47, 19);
            label6.TabIndex = 14;
            label6.Text = "History";
            // 
            // expensepanel
            // 
            expensepanel.Controls.Add(pictureBox5);
            expensepanel.Controls.Add(label5);
            expensepanel.Location = new Point(2, 377);
            expensepanel.Name = "expensepanel";
            expensepanel.Size = new Size(127, 63);
            expensepanel.TabIndex = 19;
            expensepanel.Click += Sidebar_Click;
            expensepanel.MouseEnter += Sidebar_MouseEnter;
            expensepanel.MouseLeave += Sidebar_MouseLeave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 8.25F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(38, 37);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 13;
            label5.Text = "Expense";
            // 
            // incomepanel
            // 
            incomepanel.Controls.Add(label4);
            incomepanel.Controls.Add(pictureBox4);
            incomepanel.Location = new Point(2, 312);
            incomepanel.Name = "incomepanel";
            incomepanel.Size = new Size(127, 63);
            incomepanel.TabIndex = 18;
            incomepanel.Click += Sidebar_Click;
            incomepanel.MouseEnter += Sidebar_MouseEnter;
            incomepanel.MouseLeave += Sidebar_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 8.25F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(39, 38);
            label4.Name = "label4";
            label4.Size = new Size(51, 19);
            label4.TabIndex = 12;
            label4.Text = "Income";
            // 
            // transactionpanel
            // 
            transactionpanel.Controls.Add(label3);
            transactionpanel.Controls.Add(pictureBox3);
            transactionpanel.Location = new Point(1, 247);
            transactionpanel.Name = "transactionpanel";
            transactionpanel.Size = new Size(127, 63);
            transactionpanel.TabIndex = 17;
            transactionpanel.Click += Sidebar_Click;
            transactionpanel.Paint += transactionpanel_Paint;
            transactionpanel.MouseEnter += Sidebar_MouseEnter;
            transactionpanel.MouseLeave += Sidebar_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 8.25F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(26, 39);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 11;
            label3.Text = "Transaction";
            // 
            // homepanel
            // 
            homepanel.Controls.Add(label2);
            homepanel.Controls.Add(pictureBox2);
            homepanel.Location = new Point(1, 182);
            homepanel.Name = "homepanel";
            homepanel.Size = new Size(127, 63);
            homepanel.TabIndex = 16;
            homepanel.Click += Sidebar_Click;
            homepanel.MouseEnter += Sidebar_MouseEnter;
            homepanel.MouseLeave += Sidebar_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 8.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(44, 43);
            label2.Name = "label2";
            label2.Size = new Size(42, 19);
            label2.TabIndex = 10;
            label2.Text = "Home";
            // 
            // profilepanel
            // 
            profilepanel.Controls.Add(pictureBox1);
            profilepanel.Controls.Add(label1);
            profilepanel.Location = new Point(1, 118);
            profilepanel.Name = "profilepanel";
            profilepanel.Size = new Size(127, 63);
            profilepanel.TabIndex = 15;
            profilepanel.Click += Sidebar_Click;
            profilepanel.Paint += panel2_Paint;
            profilepanel.MouseEnter += Sidebar_MouseEnter;
            profilepanel.MouseLeave += Sidebar_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 8.25F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(45, 41);
            label1.Name = "label1";
            label1.Size = new Size(43, 19);
            label1.TabIndex = 9;
            label1.Text = "Profile";
            // 
            // profilepic
            // 
            profilepic.Location = new Point(26, 18);
            profilepic.Name = "profilepic";
            profilepic.Size = new Size(80, 80);
            profilepic.TabIndex = 8;
            profilepic.TabStop = false;
            profilepic.Click += profilepic_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_logo;
            pictureBox7.Location = new Point(342, 39);
            pictureBox7.Margin = new Padding(4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(298, 84);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(171, 197);
            label8.Name = "label8";
            label8.Size = new Size(284, 28);
            label8.TabIndex = 11;
            label8.Text = "Let's manage your finances today.";
            // 
            // greeting
            // 
            greeting.AutoSize = true;
            greeting.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greeting.ForeColor = Color.White;
            greeting.Location = new Point(171, 163);
            greeting.Name = "greeting";
            greeting.Size = new Size(21, 28);
            greeting.TabIndex = 12;
            greeting.Text = "-";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 42);
            ClientSize = new Size(933, 531);
            Controls.Add(greeting);
            Controls.Add(label8);
            Controls.Add(pictureBox7);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            historypanel.ResumeLayout(false);
            historypanel.PerformLayout();
            expensepanel.ResumeLayout(false);
            expensepanel.PerformLayout();
            incomepanel.ResumeLayout(false);
            incomepanel.PerformLayout();
            transactionpanel.ResumeLayout(false);
            transactionpanel.PerformLayout();
            homepanel.ResumeLayout(false);
            homepanel.PerformLayout();
            profilepanel.ResumeLayout(false);
            profilepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)profilepic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Panel panel1;
        private Label label1;
        public PictureBox profilepic;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox7;
        private Label label8;
        public Label greeting;
        private Panel homepanel;
        private Panel transactionpanel;
        private Panel profilepanel;
        private Panel historypanel;
        private Panel expensepanel;
        private Panel incomepanel;
    }
}