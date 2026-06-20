namespace PocketLedger.Forms
{
    partial class income
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
            pnlMain = new Panel();
            lblTitle = new Label();
            lblSubTitle = new Label();
            pnlCardTotal = new Panel();
            pnlCardHighest = new Panel();
            pnlCardAverage = new Panel();
            pnlFilter = new Panel();
            lblCat = new Label();
            cmbCategory = new ComboBox();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            txtSearch = new TextBox();
            btnFilter = new Button();
            btnClear = new Button();
            pnlGrid = new Panel();
            dgvIncome = new DataGridView();
            btnAddIncome = new Button();
            btnDelete = new Button();
            lblCardTotalHdr = new Label();
            lblCardTotal = new Label();
            lblCardHighestHdr = new Label();
            lblCardHighest = new Label();
            lblCardAvgHdr = new Label();
            lblCardAvg = new Label();
            pnlMain.SuspendLayout();
            pnlFilter.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIncome).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(3, 7, 42);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(lblSubTitle);
            pnlMain.Controls.Add(pnlCardTotal);
            pnlMain.Controls.Add(pnlCardHighest);
            pnlMain.Controls.Add(pnlCardAverage);
            pnlMain.Controls.Add(pnlFilter);
            pnlMain.Controls.Add(pnlGrid);
            pnlMain.Controls.Add(btnAddIncome);
            pnlMain.Controls.Add(btnDelete);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1199, 708);
            pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Poppins", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(500, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💰  Income";
            // 
            // lblSubTitle
            // 
            lblSubTitle.Font = new Font("Poppins", 9.5F);
            lblSubTitle.ForeColor = Color.FromArgb(160, 180, 220);
            lblSubTitle.Location = new Point(22, 68);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(500, 22);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Monitor all your income sources in one place";
            // 
            // pnlCardTotal
            // 
            pnlCardTotal.Location = new Point(0, 0);
            pnlCardTotal.Name = "pnlCardTotal";
            pnlCardTotal.Size = new Size(200, 100);
            pnlCardTotal.TabIndex = 2;
            // 
            // pnlCardHighest
            // 
            pnlCardHighest.Location = new Point(0, 0);
            pnlCardHighest.Name = "pnlCardHighest";
            pnlCardHighest.Size = new Size(200, 100);
            pnlCardHighest.TabIndex = 3;
            // 
            // pnlCardAverage
            // 
            pnlCardAverage.Location = new Point(0, 0);
            pnlCardAverage.Name = "pnlCardAverage";
            pnlCardAverage.Size = new Size(200, 100);
            pnlCardAverage.TabIndex = 4;
            // 
            // pnlFilter
            // 
            pnlFilter.BackColor = Color.FromArgb(16, 24, 64);
            pnlFilter.Controls.Add(lblCat);
            pnlFilter.Controls.Add(cmbCategory);
            pnlFilter.Controls.Add(lblFrom);
            pnlFilter.Controls.Add(dtpFrom);
            pnlFilter.Controls.Add(lblTo);
            pnlFilter.Controls.Add(dtpTo);
            pnlFilter.Controls.Add(txtSearch);
            pnlFilter.Controls.Add(btnFilter);
            pnlFilter.Controls.Add(btnClear);
            pnlFilter.Location = new Point(84, 160);
            pnlFilter.Name = "pnlFilter";
            pnlFilter.Size = new Size(990, 64);
            pnlFilter.TabIndex = 5;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblCat.ForeColor = Color.FromArgb(150, 170, 220);
            lblCat.Location = new Point(8, 8);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(61, 19);
            lblCat.TabIndex = 0;
            lblCat.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FlatStyle = FlatStyle.Flat;
            cmbCategory.Font = new Font("Poppins", 9F);
            cmbCategory.Location = new Point(8, 28);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 30);
            cmbCategory.TabIndex = 1;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblFrom.ForeColor = Color.FromArgb(150, 170, 220);
            lblFrom.Location = new Point(170, 8);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(39, 19);
            lblFrom.TabIndex = 2;
            lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Poppins", 9F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(170, 28);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(140, 25);
            dtpFrom.TabIndex = 3;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Poppins", 8F, FontStyle.Bold);
            lblTo.ForeColor = Color.FromArgb(150, 170, 220);
            lblTo.Location = new Point(322, 8);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(23, 19);
            lblTo.TabIndex = 4;
            lblTo.Text = "To";
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Poppins", 9F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(322, 28);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(140, 25);
            dtpTo.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(30, 40, 90);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Poppins", 9F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(476, 28);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(180, 25);
            txtSearch.TabIndex = 6;
            txtSearch.Text = "Search...";
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(50, 200, 120);
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Poppins", 9F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(668, 26);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(80, 30);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(80, 80, 130);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Poppins", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(758, 26);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(80, 30);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.FromArgb(16, 24, 64);
            pnlGrid.Controls.Add(dgvIncome);
            pnlGrid.Location = new Point(84, 246);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(990, 360);
            pnlGrid.TabIndex = 6;
            // 
            // dgvIncome
            // 
            dgvIncome.AllowUserToAddRows = false;
            dgvIncome.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(20, 30, 75);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgvIncome.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvIncome.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIncome.BackgroundColor = Color.FromArgb(16, 24, 64);
            dgvIncome.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(25, 35, 80);
            dataGridViewCellStyle2.Font = new Font("Poppins", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(150, 180, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(25, 35, 80);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvIncome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(16, 24, 64);
            dataGridViewCellStyle3.Font = new Font("Poppins", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(50, 80, 160);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvIncome.DefaultCellStyle = dataGridViewCellStyle3;
            dgvIncome.EnableHeadersVisualStyles = false;
            dgvIncome.Font = new Font("Poppins", 9F);
            dgvIncome.GridColor = Color.FromArgb(40, 55, 100);
            dgvIncome.Location = new Point(0, 0);
            dgvIncome.MultiSelect = false;
            dgvIncome.Name = "dgvIncome";
            dgvIncome.ReadOnly = true;
            dgvIncome.RowHeadersVisible = false;
            dgvIncome.RowTemplate.Height = 32;
            dgvIncome.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIncome.Size = new Size(990, 360);
            dgvIncome.TabIndex = 0;
            // 
            // btnAddIncome
            // 
            btnAddIncome.BackColor = Color.FromArgb(50, 200, 120);
            btnAddIncome.Cursor = Cursors.Hand;
            btnAddIncome.FlatAppearance.BorderSize = 0;
            btnAddIncome.FlatStyle = FlatStyle.Flat;
            btnAddIncome.Font = new Font("Poppins", 10F, FontStyle.Bold);
            btnAddIncome.ForeColor = Color.White;
            btnAddIncome.Location = new Point(84, 633);
            btnAddIncome.Name = "btnAddIncome";
            btnAddIncome.Size = new Size(160, 38);
            btnAddIncome.TabIndex = 7;
            btnAddIncome.Text = "+ Add Income";
            btnAddIncome.UseVisualStyleBackColor = false;
            btnAddIncome.Click += btnAddIncome_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(40, 70, 40);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Poppins", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(256, 633);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(175, 38);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "🗑  Delete Selected";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblCardTotalHdr
            // 
            lblCardTotalHdr.Location = new Point(0, 0);
            lblCardTotalHdr.Name = "lblCardTotalHdr";
            lblCardTotalHdr.Size = new Size(100, 23);
            lblCardTotalHdr.TabIndex = 0;
            // 
            // lblCardTotal
            // 
            lblCardTotal.Location = new Point(0, 0);
            lblCardTotal.Name = "lblCardTotal";
            lblCardTotal.Size = new Size(100, 23);
            lblCardTotal.TabIndex = 0;
            // 
            // lblCardHighestHdr
            // 
            lblCardHighestHdr.Location = new Point(0, 0);
            lblCardHighestHdr.Name = "lblCardHighestHdr";
            lblCardHighestHdr.Size = new Size(100, 23);
            lblCardHighestHdr.TabIndex = 0;
            // 
            // lblCardHighest
            // 
            lblCardHighest.Location = new Point(0, 0);
            lblCardHighest.Name = "lblCardHighest";
            lblCardHighest.Size = new Size(100, 23);
            lblCardHighest.TabIndex = 0;
            // 
            // lblCardAvgHdr
            // 
            lblCardAvgHdr.Location = new Point(0, 0);
            lblCardAvgHdr.Name = "lblCardAvgHdr";
            lblCardAvgHdr.Size = new Size(100, 23);
            lblCardAvgHdr.TabIndex = 0;
            // 
            // lblCardAvg
            // 
            lblCardAvg.Location = new Point(0, 0);
            lblCardAvg.Name = "lblCardAvg";
            lblCardAvg.Size = new Size(100, 23);
            lblCardAvg.TabIndex = 0;
            // 
            // income
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 42);
            ClientSize = new Size(1199, 708);
            Controls.Add(pnlMain);
            Name = "income";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Income — PocketLedger";
            Load += income_Load;
            pnlMain.ResumeLayout(false);
            pnlFilter.ResumeLayout(false);
            pnlFilter.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvIncome).EndInit();
            ResumeLayout(false);
        }

        private void SetupCard(System.Windows.Forms.Panel panel,
                                System.Windows.Forms.Label hdr,
                                System.Windows.Forms.Label val,
                                string headerText, string valText,
                                System.Drawing.Color accent,
                                System.Drawing.Point location)
        {
            panel.BackColor   = System.Drawing.Color.FromArgb(16, 24, 64);
            panel.Location    = location;
            panel.Size        = new System.Drawing.Size(240, 82);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panel.Controls.Add(hdr);
            panel.Controls.Add(val);
            pnlMain.Controls.Add(panel);

            hdr.Text      = headerText;
            hdr.Font      = new System.Drawing.Font("Poppins", 8.5F, System.Drawing.FontStyle.Bold);
            hdr.ForeColor = accent;
            hdr.Location  = new System.Drawing.Point(12, 12);
            hdr.AutoSize  = true;

            val.Text      = valText;
            val.Font      = new System.Drawing.Font("Poppins", 15F, System.Drawing.FontStyle.Bold);
            val.ForeColor = System.Drawing.Color.White;
            val.Location  = new System.Drawing.Point(12, 36);
            val.AutoSize  = true;
        }

        #endregion
        private System.Windows.Forms.Panel        pnlMain;
        private System.Windows.Forms.Label        lblTitle;
        private System.Windows.Forms.Label        lblSubTitle;
        private System.Windows.Forms.Panel        pnlCardTotal;
        private System.Windows.Forms.Label        lblCardTotalHdr;
        private System.Windows.Forms.Label        lblCardTotal;
        private System.Windows.Forms.Panel        pnlCardHighest;
        private System.Windows.Forms.Label        lblCardHighestHdr;
        private System.Windows.Forms.Label        lblCardHighest;
        private System.Windows.Forms.Panel        pnlCardAverage;
        private System.Windows.Forms.Label        lblCardAvgHdr;
        private System.Windows.Forms.Label        lblCardAvg;
        private System.Windows.Forms.Panel        pnlFilter;
        private System.Windows.Forms.Label        lblCat;
        private System.Windows.Forms.ComboBox     cmbCategory;
        private System.Windows.Forms.Label        lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label        lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.TextBox      txtSearch;
        private System.Windows.Forms.Button       btnFilter;
        private System.Windows.Forms.Button       btnClear;
        private System.Windows.Forms.Panel        pnlGrid;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.Button       btnAddIncome;
        private System.Windows.Forms.Button       btnDelete;
    }
}