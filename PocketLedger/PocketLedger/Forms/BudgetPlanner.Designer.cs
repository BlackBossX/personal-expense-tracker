namespace PocketLedger.Forms
{
    partial class BudgetPlanner
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            lblSubTitle = new Label();
            grpBudget = new GroupBox();
            label1 = new Label();
            cmbMonth = new ComboBox();
            label2 = new Label();
            cmbCategory = new ComboBox();
            label3 = new Label();
            txtBudget = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            panel2 = new Panel();
            dgvBudget = new DataGridView();
            lblTotalBudget = new Label();
            lblTotalBudgetVal = new Label();
            lblTotalSpent = new Label();
            lblTotalSpentVal = new Label();
            lblRemaining = new Label();
            lblRemainingVal = new Label();
            panel4 = new Panel();
            lblStatusLabel = new Label();
            lblStatus = new Label();
            grpBudget.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBudget).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Poppins", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(16, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(315, 53);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📊  Budget Planner";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Poppins", 9.5F);
            lblSubTitle.ForeColor = Color.FromArgb(160, 180, 220);
            lblSubTitle.Location = new Point(28, 58);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(364, 23);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Set monthly budgets and track spending against them";
            // 
            // grpBudget
            // 
            grpBudget.BackColor = Color.FromArgb(3, 7, 42);
            grpBudget.Controls.Add(label1);
            grpBudget.Controls.Add(cmbMonth);
            grpBudget.Controls.Add(label2);
            grpBudget.Controls.Add(cmbCategory);
            grpBudget.Controls.Add(label3);
            grpBudget.Controls.Add(txtBudget);
            grpBudget.Controls.Add(btnAdd);
            grpBudget.Controls.Add(btnDelete);
            grpBudget.Font = new Font("Poppins", 9F, FontStyle.Bold);
            grpBudget.ForeColor = Color.FromArgb(150, 170, 220);
            grpBudget.Location = new Point(187, 112);
            grpBudget.Name = "grpBudget";
            grpBudget.Size = new Size(829, 110);
            grpBudget.TabIndex = 2;
            grpBudget.TabStop = false;
            grpBudget.Text = "Add / Update Budget";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 24);
            label1.Name = "label1";
            label1.Size = new Size(50, 22);
            label1.TabIndex = 0;
            label1.Text = "Month";
            // 
            // cmbMonth
            // 
            cmbMonth.BackColor = Color.FromArgb(25, 35, 85);
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.FlatStyle = FlatStyle.Flat;
            cmbMonth.Font = new Font("Poppins", 9F);
            cmbMonth.ForeColor = Color.White;
            cmbMonth.Location = new Point(14, 48);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(145, 30);
            cmbMonth.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(175, 24);
            label2.Name = "label2";
            label2.Size = new Size(68, 22);
            label2.TabIndex = 2;
            label2.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(25, 35, 85);
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.Font = new Font("Poppins", 9F);
            cmbCategory.ForeColor = Color.White;
            cmbCategory.Location = new Point(175, 48);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(200, 30);
            cmbCategory.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(392, 24);
            label3.Name = "label3";
            label3.Size = new Size(141, 22);
            label3.TabIndex = 4;
            label3.Text = "Budget Amount (Rs.)";
            // 
            // txtBudget
            // 
            txtBudget.BackColor = Color.FromArgb(25, 35, 85);
            txtBudget.BorderStyle = BorderStyle.FixedSingle;
            txtBudget.Font = new Font("Poppins", 9F);
            txtBudget.ForeColor = Color.White;
            txtBudget.Location = new Point(392, 48);
            txtBudget.Name = "txtBudget";
            txtBudget.PlaceholderText = "e.g. 20000.00";
            txtBudget.Size = new Size(160, 25);
            txtBudget.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 119, 230);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Poppins", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(568, 46);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Budget";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(160, 40, 40);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Poppins", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(700, 46);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "🗑 Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 24, 64);
            panel2.Controls.Add(dgvBudget);
            panel2.Location = new Point(187, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(829, 390);
            panel2.TabIndex = 3;
            // 
            // dgvBudget
            // 
            dgvBudget.AllowUserToAddRows = false;
            dgvBudget.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 30, 75);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvBudget.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBudget.BackgroundColor = Color.FromArgb(16, 24, 64);
            dgvBudget.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 35, 80);
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(150, 180, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(25, 35, 80);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBudget.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBudget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(16, 24, 64);
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(50, 80, 160);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBudget.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBudget.Dock = DockStyle.Fill;
            dgvBudget.EnableHeadersVisualStyles = false;
            dgvBudget.Font = new Font("Poppins", 9F);
            dgvBudget.GridColor = Color.FromArgb(40, 55, 100);
            dgvBudget.Location = new Point(0, 0);
            dgvBudget.MultiSelect = false;
            dgvBudget.Name = "dgvBudget";
            dgvBudget.ReadOnly = true;
            dgvBudget.RowHeadersVisible = false;
            dgvBudget.RowTemplate.Height = 34;
            dgvBudget.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBudget.Size = new Size(829, 390);
            dgvBudget.TabIndex = 0;
            dgvBudget.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblTotalBudget
            // 
            lblTotalBudget.Location = new Point(0, 0);
            lblTotalBudget.Name = "lblTotalBudget";
            lblTotalBudget.Size = new Size(100, 23);
            lblTotalBudget.TabIndex = 0;
            // 
            // lblTotalBudgetVal
            // 
            lblTotalBudgetVal.Location = new Point(0, 0);
            lblTotalBudgetVal.Name = "lblTotalBudgetVal";
            lblTotalBudgetVal.Size = new Size(100, 23);
            lblTotalBudgetVal.TabIndex = 0;
            // 
            // lblTotalSpent
            // 
            lblTotalSpent.Location = new Point(0, 0);
            lblTotalSpent.Name = "lblTotalSpent";
            lblTotalSpent.Size = new Size(100, 23);
            lblTotalSpent.TabIndex = 0;
            // 
            // lblTotalSpentVal
            // 
            lblTotalSpentVal.Location = new Point(0, 0);
            lblTotalSpentVal.Name = "lblTotalSpentVal";
            lblTotalSpentVal.Size = new Size(100, 23);
            lblTotalSpentVal.TabIndex = 0;
            // 
            // lblRemaining
            // 
            lblRemaining.Location = new Point(0, 0);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(100, 23);
            lblRemaining.TabIndex = 0;
            // 
            // lblRemainingVal
            // 
            lblRemainingVal.Location = new Point(0, 0);
            lblRemainingVal.Name = "lblRemainingVal";
            lblRemainingVal.Size = new Size(100, 23);
            lblRemainingVal.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(20, 60, 20);
            panel4.Controls.Add(lblStatusLabel);
            panel4.Controls.Add(lblStatus);
            panel4.Location = new Point(187, 636);
            panel4.Name = "panel4";
            panel4.Size = new Size(829, 60);
            panel4.TabIndex = 5;
            // 
            // lblStatusLabel
            // 
            lblStatusLabel.AutoSize = true;
            lblStatusLabel.Font = new Font("Poppins", 11F, FontStyle.Bold);
            lblStatusLabel.ForeColor = Color.FromArgb(180, 200, 255);
            lblStatusLabel.Location = new Point(12, 16);
            lblStatusLabel.Name = "lblStatusLabel";
            lblStatusLabel.Size = new Size(122, 26);
            lblStatusLabel.TabIndex = 0;
            lblStatusLabel.Text = "Overall Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Poppins", 12F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(50, 220, 120);
            lblStatus.Location = new Point(160, 14);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(76, 28);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "✅ Safe";
            // 
            // BudgetPlanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 42);
            ClientSize = new Size(1199, 708);
            Controls.Add(lblTitle);
            Controls.Add(lblSubTitle);
            Controls.Add(grpBudget);
            Controls.Add(panel2);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "BudgetPlanner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Budget Planner — PocketLedger";
            Load += BudgetPlanner_Load;
            grpBudget.ResumeLayout(false);
            grpBudget.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBudget).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        // Helper: summary card
        private void SetupSummaryCard(System.Windows.Forms.Panel panel,
                                      System.Windows.Forms.Label hdr,
                                      System.Windows.Forms.Label val,
                                      string hdrText, string valText,
                                      System.Drawing.Color accent,
                                      System.Drawing.Point location)
        {
            panel.BackColor   = System.Drawing.Color.FromArgb(16, 24, 64);
            panel.Location    = location;
            panel.Size        = new System.Drawing.Size(312, 120);
            panel.Controls.AddRange(new System.Windows.Forms.Control[] { hdr, val });

            hdr.Text      = hdrText;
            hdr.Font      = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold);
            hdr.ForeColor = accent;
            hdr.Location  = new System.Drawing.Point(10, 12);
            hdr.AutoSize  = true;

            val.Text      = valText;
            val.Font      = new System.Drawing.Font("Poppins", 16F, System.Drawing.FontStyle.Bold);
            val.ForeColor = System.Drawing.Color.White;
            val.Location  = new System.Drawing.Point(10, 38);
            val.AutoSize  = true;
        }

        #endregion

        private System.Windows.Forms.Label       lblTitle;
        private System.Windows.Forms.Label       lblSubTitle;
        private System.Windows.Forms.GroupBox    grpBudget;
        private System.Windows.Forms.Label       label1;
        private System.Windows.Forms.Label       label2;
        private System.Windows.Forms.Label       label3;
        private System.Windows.Forms.ComboBox    cmbMonth;
        private System.Windows.Forms.ComboBox    cmbCategory;
        private System.Windows.Forms.TextBox     txtBudget;
        private System.Windows.Forms.Button      btnAdd;
        private System.Windows.Forms.Button      btnDelete;
        private System.Windows.Forms.Panel       panel2;
        private System.Windows.Forms.DataGridView dgvBudget;
        private System.Windows.Forms.Label       lblTotalBudget;
        private System.Windows.Forms.Label       lblTotalBudgetVal;
        private System.Windows.Forms.Label       lblTotalSpent;
        private System.Windows.Forms.Label       lblTotalSpentVal;
        private System.Windows.Forms.Label       lblRemaining;
        private System.Windows.Forms.Label       lblRemainingVal;
        private System.Windows.Forms.Panel       panel4;
        private System.Windows.Forms.Label       lblStatusLabel;
        private System.Windows.Forms.Label       lblStatus;
    }
}