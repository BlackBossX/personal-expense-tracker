namespace PocketLedger.Forms
{
    partial class BudgetPlanner
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
            panel2 = new Panel();
            dgvBudget = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            lblStatus = new Label();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbMonth = new ComboBox();
            cmbCategory = new ComboBox();
            txtBudget = new TextBox();
            btnAdd = new Button();
            grpBudget = new GroupBox();
            groupBox1 = new GroupBox();
            panelRemaining = new Panel();
            lblRemaining = new Label();
            panelSpent = new Panel();
            lblTotalSpent = new Label();
            panelBudget = new Panel();
            lblTotalBudget = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBudget).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            grpBudget.SuspendLayout();
            groupBox1.SuspendLayout();
            panelRemaining.SuspendLayout();
            panelSpent.SuspendLayout();
            panelBudget.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 24, 64);
            panel2.Controls.Add(dgvBudget);
            panel2.Location = new Point(5, 201);
            panel2.Name = "panel2";
            panel2.Size = new Size(756, 340);
            panel2.TabIndex = 1;
            // 
            // dgvBudget
            // 
            dgvBudget.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBudget.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBudget.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBudget.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvBudget.GridColor = Color.FromArgb(3, 7, 42);
            dgvBudget.Location = new Point(0, 3);
            dgvBudget.Name = "dgvBudget";
            dgvBudget.RowHeadersWidth = 51;
            dgvBudget.Size = new Size(756, 337);
            dgvBudget.TabIndex = 0;
            dgvBudget.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Category";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Budget Amount";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Spent Amount";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Remaining Amount";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(60, 15, 30);
            panel4.Controls.Add(lblStatus);
            panel4.Location = new Point(5, 560);
            panel4.Name = "panel4";
            panel4.Size = new Size(972, 139);
            panel4.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(7, 11);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(86, 31);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.white_logo;
            pictureBox1.Location = new Point(31, 13);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(199, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(172, 28);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "- Budget Planner";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(65, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 0;
            label1.Text = "Month";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(260, 23);
            label2.Name = "label2";
            label2.Size = new Size(98, 28);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(456, 23);
            label3.Name = "label3";
            label3.Size = new Size(80, 28);
            label3.TabIndex = 2;
            label3.Text = "Budget";
            // 
            // cmbMonth
            // 
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(65, 69);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(141, 28);
            cmbMonth.TabIndex = 3;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(260, 69);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(141, 28);
            cmbCategory.TabIndex = 4;
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(456, 69);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(114, 27);
            txtBudget.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 119, 230);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(616, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 43);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // grpBudget
            // 
            grpBudget.AutoSize = true;
            grpBudget.Controls.Add(label1);
            grpBudget.Controls.Add(cmbMonth);
            grpBudget.Controls.Add(cmbCategory);
            grpBudget.Controls.Add(label3);
            grpBudget.Controls.Add(label2);
            grpBudget.Controls.Add(btnAdd);
            grpBudget.Controls.Add(txtBudget);
            grpBudget.ForeColor = Color.White;
            grpBudget.Location = new Point(19, 68);
            grpBudget.Name = "grpBudget";
            grpBudget.Size = new Size(734, 123);
            grpBudget.TabIndex = 6;
            grpBudget.TabStop = false;
            grpBudget.Text = "Add Budget";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panelRemaining);
            groupBox1.Controls.Add(panelSpent);
            groupBox1.Controls.Add(panelBudget);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(768, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(227, 528);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Summary ";
            // 
            // panelRemaining
            // 
            panelRemaining.Controls.Add(lblRemaining);
            panelRemaining.Location = new Point(12, 367);
            panelRemaining.Name = "panelRemaining";
            panelRemaining.Size = new Size(202, 133);
            panelRemaining.TabIndex = 2;
            panelRemaining.Paint += panelRemaining_Paint;
            // 
            // lblRemaining
            // 
            lblRemaining.AutoSize = true;
            lblRemaining.Location = new Point(5, 10);
            lblRemaining.Name = "lblRemaining";
            lblRemaining.Size = new Size(96, 23);
            lblRemaining.TabIndex = 1;
            lblRemaining.Text = "Remaining";
            // 
            // panelSpent
            // 
            panelSpent.Controls.Add(lblTotalSpent);
            panelSpent.Location = new Point(12, 206);
            panelSpent.Name = "panelSpent";
            panelSpent.Size = new Size(202, 139);
            panelSpent.TabIndex = 1;
            // 
            // lblTotalSpent
            // 
            lblTotalSpent.AutoSize = true;
            lblTotalSpent.Location = new Point(5, 10);
            lblTotalSpent.Name = "lblTotalSpent";
            lblTotalSpent.Size = new Size(101, 23);
            lblTotalSpent.TabIndex = 1;
            lblTotalSpent.Text = "Total Spent";
            // 
            // panelBudget
            // 
            panelBudget.Controls.Add(lblTotalBudget);
            panelBudget.Location = new Point(7, 55);
            panelBudget.Name = "panelBudget";
            panelBudget.Size = new Size(202, 135);
            panelBudget.TabIndex = 0;
            // 
            // lblTotalBudget
            // 
            lblTotalBudget.AutoSize = true;
            lblTotalBudget.Location = new Point(5, 0);
            lblTotalBudget.Name = "lblTotalBudget";
            lblTotalBudget.Size = new Size(118, 23);
            lblTotalBudget.TabIndex = 0;
            lblTotalBudget.Text = "Total Budget ";
            // 
            // BudgetPlanner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 42);
            ClientSize = new Size(1000, 699);
            Controls.Add(groupBox1);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(grpBudget);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox1);
            Name = "BudgetPlanner";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BudgetPlanner";
            //Load += BudgetPlanner_Load_1;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBudget).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            grpBudget.ResumeLayout(false);
            grpBudget.PerformLayout();
            groupBox1.ResumeLayout(false);
            panelRemaining.ResumeLayout(false);
            panelRemaining.PerformLayout();
            panelSpent.ResumeLayout(false);
            panelSpent.PerformLayout();
            panelBudget.ResumeLayout(false);
            panelBudget.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel4;
        private DataGridView dgvBudget;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbMonth;
        private ComboBox cmbCategory;
        private TextBox txtBudget;
        private Button btnAdd;
        private GroupBox grpBudget;
        private Label lblStatus;
        private GroupBox groupBox1;
        private Panel panelRemaining;
        private Panel panelSpent;
        private Panel panelBudget;
        private Label lblTotalSpent;
        private Label lblTotalBudget;
        private Label lblRemaining;
    }
}