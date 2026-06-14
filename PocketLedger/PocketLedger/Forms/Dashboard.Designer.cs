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
            pictureBox5 = new PictureBox();
            label5 = new Label();
            incomepanel = new Panel();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            transactionpanel = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            homepanel = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            incomepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            transactionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            homepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1370, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(58, 24);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_logo;
            pictureBox7.Location = new Point(565, 64);
            pictureBox7.Margin = new Padding(5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(317, 107);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 9;
            pictureBox7.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(245, 261);
            label8.Name = "label8";
            label8.Size = new Size(308, 25);
            label8.TabIndex = 11;
            label8.Text = "Let's manage your finances today.";
            // 
            // greeting
            // 
            greeting.AutoSize = true;
            greeting.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greeting.ForeColor = Color.White;
            greeting.Location = new Point(245, 224);
            greeting.Name = "greeting";
            greeting.Size = new Size(19, 25);
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
            panel1.Location = new Point(0, 30);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(192, 914);
            panel1.TabIndex = 15;
            // 
            // historypanel
            // 
            historypanel.Controls.Add(label6);
            historypanel.Controls.Add(pictureBox6);
            historypanel.Location = new Point(2, 785);
            historypanel.Margin = new Padding(3, 5, 3, 5);
            historypanel.Name = "historypanel";
            historypanel.Size = new Size(186, 112);
            historypanel.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(66, 65);
            label6.Name = "label6";
            label6.Size = new Size(55, 18);
            label6.TabIndex = 14;
            label6.Text = "History";
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(74, 16);
            pictureBox6.Margin = new Padding(3, 5, 3, 5);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(40, 48);
            pictureBox6.TabIndex = 7;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click_1;
            // 
            // expensepanel
            // 
            expensepanel.Controls.Add(pictureBox5);
            expensepanel.Controls.Add(label5);
            expensepanel.Location = new Point(2, 671);
            expensepanel.Margin = new Padding(3, 5, 3, 5);
            expensepanel.Name = "expensepanel";
            expensepanel.Size = new Size(186, 112);
            expensepanel.TabIndex = 19;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(73, 20);
            pictureBox5.Margin = new Padding(3, 5, 3, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 48);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(63, 65);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 13;
            label5.Text = "Expense";
            // 
            // incomepanel
            // 
            incomepanel.Controls.Add(label4);
            incomepanel.Controls.Add(pictureBox4);
            incomepanel.Location = new Point(2, 555);
            incomepanel.Margin = new Padding(3, 5, 3, 5);
            incomepanel.Name = "incomepanel";
            incomepanel.Size = new Size(186, 112);
            incomepanel.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(65, 68);
            label4.Name = "label4";
            label4.Size = new Size(57, 18);
            label4.TabIndex = 12;
            label4.Text = "Income";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(73, 23);
            pictureBox4.Margin = new Padding(3, 5, 3, 5);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 48);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // transactionpanel
            // 
            transactionpanel.Controls.Add(label3);
            transactionpanel.Controls.Add(pictureBox3);
            transactionpanel.Location = new Point(1, 439);
            transactionpanel.Margin = new Padding(3, 5, 3, 5);
            transactionpanel.Name = "transactionpanel";
            transactionpanel.Size = new Size(186, 112);
            transactionpanel.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(53, 69);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 11;
            label3.Text = "Transaction";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(74, 20);
            pictureBox3.Margin = new Padding(3, 5, 3, 5);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 48);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // homepanel
            // 
            homepanel.Controls.Add(label2);
            homepanel.Controls.Add(pictureBox2);
            homepanel.Location = new Point(1, 324);
            homepanel.Margin = new Padding(3, 5, 3, 5);
            homepanel.Name = "homepanel";
            homepanel.Size = new Size(186, 112);
            homepanel.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(70, 76);
            label2.Name = "label2";
            label2.Size = new Size(49, 18);
            label2.TabIndex = 10;
            label2.Text = "Home";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(74, 23);
            pictureBox2.Margin = new Padding(3, 5, 3, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 48);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // profilepanel
            // 
            profilepanel.Controls.Add(pictureBox1);
            profilepanel.Controls.Add(label1);
            profilepanel.Location = new Point(1, 209);
            profilepanel.Margin = new Padding(3, 5, 3, 5);
            profilepanel.Name = "profilepanel";
            profilepanel.Size = new Size(186, 112);
            profilepanel.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(75, 20);
            pictureBox1.Margin = new Padding(3, 5, 3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 48);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(71, 73);
            label1.Name = "label1";
            label1.Size = new Size(50, 18);
            label1.TabIndex = 9;
            label1.Text = "Profile";
            // 
            // profilepic
            // 
            profilepic.Location = new Point(39, 32);
            profilepic.Margin = new Padding(3, 5, 3, 5);
            profilepic.Name = "profilepic";
            profilepic.Size = new Size(120, 120);
            profilepic.TabIndex = 8;
            profilepic.TabStop = false;
            profilepic.Click += profilepic_Click_1;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 42);
            ClientSize = new Size(1370, 944);
            Controls.Add(panel1);
            Controls.Add(greeting);
            Controls.Add(label8);
            Controls.Add(pictureBox7);
            Controls.Add(menuStrip1);
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            incomepanel.ResumeLayout(false);
            incomepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            transactionpanel.ResumeLayout(false);
            transactionpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            homepanel.ResumeLayout(false);
            homepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private PictureBox pictureBox2;
        private Panel profilepanel;
        private PictureBox pictureBox1;
        private Label label1;
        public PictureBox profilepic;
    }
}