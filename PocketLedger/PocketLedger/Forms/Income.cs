using PocketLedger.Database;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PocketLedger.Forms
{
    public partial class income : Form
    {
        private readonly IncomeExpenseRepository _repo   = new IncomeExpenseRepository();
        private readonly TransactionRepository   _txRepo = new TransactionRepository();
        private string loggedEmail;
        private Action _onUpdate;

        public income(string email, Action onUpdate = null)
        {
            InitializeComponent();
            loggedEmail = email;
            _onUpdate = onUpdate;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
        }

        private void income_Load(object sender, EventArgs e)
        {
            try
            {
                _txRepo.GetCategories(cmbCategory, "Income");

                dtpFrom.Value = DateTime.Now.AddMonths(-1);
                dtpTo.Value   = DateTime.Now;

                txtSearch.Text      = "Search...";
                txtSearch.ForeColor = Color.Gray;
                txtSearch.GotFocus  += TxtSearch_GotFocus;
                txtSearch.LostFocus += TxtSearch_LostFocus;
                txtSearch.TextChanged += TxtSearch_TextChanged;

                btnFilter.Click += BtnFilter_Click;
                btnClear.Click  += BtnClear_Click;

                LoadIncome();
                LoadSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        
        
        private void LoadIncome(string category = "All",
                                DateTime? from = null, DateTime? to = null,
                                string search = "")
        {
            try
            {
                var dt = _repo.GetByType(loggedEmail, "Income",
                    category: category, from: from, to: to, search: search);

                dgvIncome.DataSource = dt;

                if (dgvIncome.Columns.Contains("ID"))
                    dgvIncome.Columns["ID"].Visible = false;
                if (dgvIncome.Columns.Contains("Amount"))
                {
                    dgvIncome.Columns["Amount"].HeaderText = "Amount (Rs.)";
                    dgvIncome.Columns["Amount"].DefaultCellStyle.Format = "N2";
                }
                if (dgvIncome.Columns.Contains("PaymentMethod"))
                    dgvIncome.Columns["PaymentMethod"].HeaderText = "Payment Method";
                if (dgvIncome.Columns.Contains("Notes"))
                    dgvIncome.Columns["Notes"].HeaderText = "Notes";
                if (dgvIncome.Columns.Contains("Date"))
                {
                    dgvIncome.Columns["Date"].HeaderText = "Date";
                    dgvIncome.Columns["Date"].DefaultCellStyle.Format = "dd MMM yyyy";
                }

                
                foreach (DataGridViewRow row in dgvIncome.Rows)
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(50, 220, 130);

                LoadSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load income: " + ex.Message);
            }
        }

        
        
        
        private void LoadSummary()
        {
            try
            {
                string currentMonth = DateTime.Now.ToString("MMMM");
                decimal total = _repo.GetTotal(loggedEmail, "Income", currentMonth);
                lblCardTotal.Text = "Rs. " + total.ToString("N2");

                var dt = _repo.GetByType(loggedEmail, "Income",
                    from: new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1),
                    to: DateTime.Now);

                if (dt.Rows.Count == 0)
                {
                    lblCardHighest.Text = "Rs. 0.00";
                    lblCardAvg.Text     = "Rs. 0.00";
                    return;
                }

                decimal max = 0, sum = 0;
                foreach (DataRow row in dt.Rows)
                {
                    decimal amt = Convert.ToDecimal(row["Amount"]);
                    if (amt > max) max = amt;
                    sum += amt;
                }

                lblCardHighest.Text = "Rs. " + max.ToString("N2");
                lblCardAvg.Text     = "Rs. " + (sum / dt.Rows.Count).ToString("N2");
            }
            catch {  }
        }

        
        
        
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            string cat    = cmbCategory.SelectedItem?.ToString() ?? "All";
            string search = txtSearch.Text == "Search..." ? "" : txtSearch.Text;
            LoadIncome(cat, dtpFrom.Value.Date, dtpTo.Value.Date, search);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Now.AddMonths(-1);
            dtpTo.Value   = DateTime.Now;
            txtSearch.Text      = "Search...";
            txtSearch.ForeColor = Color.Gray;
            LoadIncome();
        }

        
        
        
        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            ShowAddDialog("Income");
        }

        private void ShowAddDialog(string type)
        {
            var dlg = new Form
            {
                Text            = $"Add {type} — PocketLedger",
                BackColor       = System.Drawing.Color.FromArgb(16, 24, 64),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition   = FormStartPosition.CenterParent,
                Size            = new System.Drawing.Size(520, 440),
                MaximizeBox     = false
            };

            var lblAmt = MakeLabel("Amount (Rs.)", 20, 20);
            var txtAmt = MakeTextBox(20, 48, "e.g. 50000.00");

            var lblCat = MakeLabel("Category", 280, 20);
            var cmbCat = new ComboBox
            {
                Location      = new System.Drawing.Point(280, 48),
                Size          = new System.Drawing.Size(200, 30),
                Font          = new System.Drawing.Font("Poppins", 9F),
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor     = System.Drawing.Color.FromArgb(25, 35, 85),
                ForeColor     = System.Drawing.Color.White,
                FlatStyle     = FlatStyle.Flat
            };
            var catTable = _txRepo.GetCategoriesTable(type);
            cmbCat.DataSource    = catTable;
            cmbCat.DisplayMember = "CategoryName";
            cmbCat.ValueMember   = "CategoryID";
            cmbCat.SelectedIndex = -1;

            var lblPay = MakeLabel("Payment Method", 20, 98);
            var cmbPay = new ComboBox
            {
                Location      = new System.Drawing.Point(20, 126),
                Size          = new System.Drawing.Size(200, 30),
                Font          = new System.Drawing.Font("Poppins", 9F),
                DropDownStyle = ComboBoxStyle.DropDownList,
                BackColor     = System.Drawing.Color.FromArgb(25, 35, 85),
                ForeColor     = System.Drawing.Color.White,
                FlatStyle     = FlatStyle.Flat
            };
            cmbPay.Items.AddRange(new object[] { "Bank Transfer", "Cash", "Cheque", "Online", "Other" });
            cmbPay.SelectedIndex = 0;

            var lblDate = MakeLabel("Date", 280, 98);
            var dtpDate = new DateTimePicker
            {
                Location = new System.Drawing.Point(280, 126),
                Size     = new System.Drawing.Size(200, 30),
                Font     = new System.Drawing.Font("Poppins", 9F),
                Format   = DateTimePickerFormat.Short,
                Value    = DateTime.Now
            };

            var lblNotes = MakeLabel("Notes (optional)", 20, 176);
            var txtNotes = new TextBox
            {
                Location        = new System.Drawing.Point(20, 204),
                Size            = new System.Drawing.Size(460, 70),
                Font            = new System.Drawing.Font("Poppins", 9F),
                BackColor       = System.Drawing.Color.FromArgb(25, 35, 85),
                ForeColor       = System.Drawing.Color.White,
                BorderStyle     = BorderStyle.FixedSingle,
                Multiline       = true,
                PlaceholderText = $"Add a note about this {type.ToLower()}..."
            };

            var btnSave = new Button
            {
                Text      = $"Save {type}",
                Font      = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.FromArgb(50, 180, 100),
                FlatStyle  = FlatStyle.Flat,
                Location   = new System.Drawing.Point(20, 300),
                Size       = new System.Drawing.Size(150, 38),
                Cursor     = Cursors.Hand
            };
            btnSave.FlatAppearance.BorderSize = 0;

            var btnCancel = new Button
            {
                Text      = "Cancel",
                Font      = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.White,
                BackColor = System.Drawing.Color.FromArgb(60, 60, 100),
                FlatStyle  = FlatStyle.Flat,
                Location   = new System.Drawing.Point(182, 300),
                Size       = new System.Drawing.Size(110, 38),
                Cursor     = Cursors.Hand
            };
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Click += (s, ev) => dlg.Close();

            btnSave.Click += (s, ev) =>
            {
                if (!decimal.TryParse(txtAmt.Text, out decimal amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter a valid amount.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (cmbCat.SelectedValue == null)
                {
                    MessageBox.Show("Please select a category.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    _repo.AddTransaction(loggedEmail, type, amount,
                        Convert.ToInt32(cmbCat.SelectedValue),
                        cmbPay.SelectedItem?.ToString() ?? "Bank Transfer",
                        txtNotes.Text.Trim(), dtpDate.Value.Date);

                    MessageBox.Show("✅ Income saved!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _onUpdate?.Invoke();
                    dlg.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Save failed: " + ex.Message);
                }
            };

            dlg.Controls.AddRange(new Control[] {
                lblAmt, txtAmt, lblCat, cmbCat,
                lblPay, cmbPay, lblDate, dtpDate,
                lblNotes, txtNotes,
                btnSave, btnCancel
            });

            dlg.ShowDialog(this);
            LoadIncome();
            LoadSummary();
        }

        
        
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvIncome.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var row = dgvIncome.SelectedRows[0];
            if (row.Cells["ID"]?.Value == null) return;

            int id = Convert.ToInt32(row.Cells["ID"].Value);

            var confirm = MessageBox.Show(
                "Are you sure you want to delete this income record?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _repo.DeleteTransaction(id);
                    LoadIncome();
                    LoadSummary();
                    _onUpdate?.Invoke();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Delete failed: " + ex.Message);
                }
            }
        }

        
        
        
        private Label MakeLabel(string text, int x, int y)
        {
            return new Label
            {
                Text      = text,
                Font      = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(150, 170, 220),
                Location  = new System.Drawing.Point(x, y),
                AutoSize  = true
            };
        }

        private TextBox MakeTextBox(int x, int y, string placeholder)
        {
            return new TextBox
            {
                Location        = new System.Drawing.Point(x, y),
                Size            = new System.Drawing.Size(240, 30),
                Font            = new System.Drawing.Font("Poppins", 10F),
                BackColor       = System.Drawing.Color.FromArgb(25, 35, 85),
                ForeColor       = System.Drawing.Color.White,
                BorderStyle     = BorderStyle.FixedSingle,
                PlaceholderText = placeholder
            };
        }

        
        
        
        private void TxtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text      = "";
                txtSearch.ForeColor = Color.White;
            }
        }

        private void TxtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text      = "Search...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Search...")
            {
                string cat = cmbCategory.SelectedItem?.ToString() ?? "All";
                LoadIncome(cat, search: txtSearch.Text);
            }
        }
    }
}
