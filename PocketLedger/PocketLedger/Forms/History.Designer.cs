namespace PocketLedger.Forms
{
    partial class History
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            txtSearch = new TextBox();
            btnFilter = new Button();
            btnClear = new Button();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblTo = new Label();
            lblFrom = new Label();
            dtpTo = new DateTimePicker();
            dtpFrom = new DateTimePicker();
            pictureBox7 = new PictureBox();
            dgvTransactions = new DataGridView();
            label7 = new Label();
            profilepic = new PictureBox();
            profilepanel = new Panel();
            label1 = new Label();
            homepanel = new Panel();
            transactionpanel = new Panel();
            incomepanel = new Panel();
            expensepanel = new Panel();
            historypanel = new Panel();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profilepic).BeginInit();
            profilepanel.SuspendLayout();
            homepanel.SuspendLayout();
            transactionpanel.SuspendLayout();
            incomepanel.SuspendLayout();
            expensepanel.SuspendLayout();
            historypanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1199, 25);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 19);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(47, 19);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 8.25F);
            txtSearch.Location = new Point(24, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(123, 20);
            txtSearch.TabIndex = 10;
            txtSearch.Text = "Search...";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(26, 48, 112);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(23, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(123, 26);
            btnFilter.TabIndex = 9;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(26, 48, 112);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(23, 36);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 26);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblCategory.ForeColor = Color.FromArgb(192, 255, 192);
            lblCategory.Location = new Point(52, 11);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(71, 22);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(23, 35);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(123, 23);
            cmbCategory.TabIndex = 6;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblType.ForeColor = Color.FromArgb(192, 255, 192);
            lblType.Location = new Point(61, 10);
            lblType.Name = "lblType";
            lblType.Size = new Size(43, 22);
            lblType.TabIndex = 5;
            lblType.Text = "Type:";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "All", "Income", "Expense" });
            cmbType.Location = new Point(23, 33);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(123, 23);
            cmbType.TabIndex = 4;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblTo.ForeColor = Color.FromArgb(192, 255, 192);
            lblTo.Location = new Point(70, 10);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(28, 22);
            lblTo.TabIndex = 3;
            lblTo.Text = "To:";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblFrom.ForeColor = Color.FromArgb(192, 255, 192);
            lblFrom.Location = new Point(63, 13);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(46, 22);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "From:";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(24, 34);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(123, 23);
            dtpTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(24, 35);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(123, 23);
            dtpFrom.TabIndex = 0;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.white_logo;
            pictureBox7.Location = new Point(956, 46);
            pictureBox7.Margin = new Padding(6, 5, 6, 5);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(227, 46);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 16;
            pictureBox7.TabStop = false;
            // 
            // dgvTransactions
            // 
            dgvTransactions.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(5, 10, 50);
            dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.BackgroundColor = Color.FromArgb(3, 7, 42);
            dgvTransactions.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(3, 7, 85);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(96, 112, 128);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(3, 7, 42);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(160, 184, 224);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(26, 48, 112);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTransactions.GridColor = Color.FromArgb(20, 30, 80);
            dgvTransactions.Location = new Point(174, 108);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.ReadOnly = true;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.RowHeadersWidth = 51;
            dgvTransactions.RowTemplate.Height = 30;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.ShowCellErrors = false;
            dgvTransactions.ShowRowErrors = false;
            dgvTransactions.Size = new Size(1032, 600);
            dgvTransactions.TabIndex = 17;
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(179, 54);
            label7.Name = "label7";
            label7.Size = new Size(269, 31);
            label7.TabIndex = 18;
            label7.Text = "Transaction History";
            // 
            // profilepic
            // 
            profilepic.Location = new Point(34, 24);
            profilepic.Margin = new Padding(3, 4, 3, 4);
            profilepic.Name = "profilepic";
            profilepic.Size = new Size(105, 105);
            profilepic.TabIndex = 8;
            profilepic.TabStop = false;
            profilepic.Click += profilepic_Click;
            // 
            // profilepanel
            // 
            profilepanel.Controls.Add(label1);
            profilepanel.Controls.Add(txtSearch);
            profilepanel.Location = new Point(1, 157);
            profilepanel.Margin = new Padding(3, 4, 3, 4);
            profilepanel.Name = "profilepanel";
            profilepanel.Size = new Size(163, 84);
            profilepanel.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(192, 255, 192);
            label1.Location = new Point(59, 10);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 3;
            label1.Text = "Search: ";
            label1.Click += label1_Click;
            // 
            // homepanel
            // 
            homepanel.Controls.Add(lblFrom);
            homepanel.Controls.Add(dtpFrom);
            homepanel.Location = new Point(1, 243);
            homepanel.Margin = new Padding(3, 4, 3, 4);
            homepanel.Name = "homepanel";
            homepanel.Size = new Size(163, 84);
            homepanel.TabIndex = 16;
            // 
            // transactionpanel
            // 
            transactionpanel.Controls.Add(lblTo);
            transactionpanel.Controls.Add(dtpTo);
            transactionpanel.Location = new Point(1, 329);
            transactionpanel.Margin = new Padding(3, 4, 3, 4);
            transactionpanel.Name = "transactionpanel";
            transactionpanel.Size = new Size(163, 84);
            transactionpanel.TabIndex = 17;
            // 
            // incomepanel
            // 
            incomepanel.Controls.Add(lblCategory);
            incomepanel.Controls.Add(cmbCategory);
            incomepanel.Location = new Point(2, 416);
            incomepanel.Margin = new Padding(3, 4, 3, 4);
            incomepanel.Name = "incomepanel";
            incomepanel.Size = new Size(163, 84);
            incomepanel.TabIndex = 18;
            // 
            // expensepanel
            // 
            expensepanel.Controls.Add(lblType);
            expensepanel.Controls.Add(cmbType);
            expensepanel.Location = new Point(2, 503);
            expensepanel.Margin = new Padding(3, 4, 3, 4);
            expensepanel.Name = "expensepanel";
            expensepanel.Size = new Size(163, 84);
            expensepanel.TabIndex = 19;
            // 
            // historypanel
            // 
            historypanel.Controls.Add(btnFilter);
            historypanel.Controls.Add(btnClear);
            historypanel.Location = new Point(2, 589);
            historypanel.Margin = new Padding(3, 4, 3, 4);
            historypanel.Name = "historypanel";
            historypanel.Size = new Size(163, 84);
            historypanel.TabIndex = 20;
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
            panel1.Location = new Point(0, 25);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 683);
            panel1.TabIndex = 14;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 42);
            ClientSize = new Size(1199, 708);
            Controls.Add(label7);
            Controls.Add(dgvTransactions);
            Controls.Add(pictureBox7);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "History";
            Text = "History";
            Load += History_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)profilepic).EndInit();
            profilepanel.ResumeLayout(false);
            profilepanel.PerformLayout();
            homepanel.ResumeLayout(false);
            homepanel.PerformLayout();
            transactionpanel.ResumeLayout(false);
            transactionpanel.PerformLayout();
            incomepanel.ResumeLayout(false);
            incomepanel.PerformLayout();
            expensepanel.ResumeLayout(false);
            expensepanel.PerformLayout();
            historypanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private Label lblTo;
        private Label lblFrom;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private Label lblType;
        private ComboBox cmbType;
        private Button btnClear;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private TextBox txtSearch;
        private Button btnFilter;
        private PictureBox pictureBox7;
        private DataGridView dgvTransactions;
        private Label label7;
        public PictureBox profilepic;
        private Panel profilepanel;
        private Panel homepanel;
        private Panel transactionpanel;
        private Panel incomepanel;
        private Panel expensepanel;
        private Panel historypanel;
        private Panel panel1;
        private Label label1;
    }
}