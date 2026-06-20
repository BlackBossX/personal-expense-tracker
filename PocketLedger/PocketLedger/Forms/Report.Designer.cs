namespace PocketLedger.Forms
{
    partial class Report
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
            lblTitle = new Label();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnGenerate = new Button();
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Poppins", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(18, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(246, 48);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Financial Report";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblFrom.ForeColor = Color.FromArgb(192, 255, 192);
            lblFrom.Location = new Point(18, 71);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(46, 22);
            lblFrom.TabIndex = 1;
            lblFrom.Text = "From:";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(66, 70);
            dtpFrom.Margin = new Padding(3, 2, 3, 2);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(108, 23);
            dtpFrom.TabIndex = 2;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Poppins", 9F, FontStyle.Bold);
            lblTo.ForeColor = Color.FromArgb(192, 255, 192);
            lblTo.Location = new Point(192, 71);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(28, 22);
            lblTo.TabIndex = 3;
            lblTo.Text = "To:";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(228, 70);
            dtpTo.Margin = new Padding(3, 2, 3, 2);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(108, 23);
            dtpTo.TabIndex = 4;
            // 
            // btnGenerate
            // 
            btnGenerate.BackColor = Color.FromArgb(26, 48, 112);
            btnGenerate.FlatStyle = FlatStyle.Flat;
            btnGenerate.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerate.ForeColor = Color.White;
            btnGenerate.Location = new Point(359, 60);
            btnGenerate.Margin = new Padding(3, 2, 3, 2);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(152, 33);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Generate Report";
            btnGenerate.UseVisualStyleBackColor = false;
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.Location = new Point(18, 105);
            reportViewer1.Margin = new Padding(3, 2, 3, 2);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(1164, 583);
            reportViewer1.TabIndex = 6;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 42);
            ClientSize = new Size(1199, 708);
            Controls.Add(reportViewer1);
            Controls.Add(btnGenerate);
            Controls.Add(dtpTo);
            Controls.Add(lblTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblFrom);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Report";
            Text = "Report";
            Load += Report_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Button btnGenerate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}