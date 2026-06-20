using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PocketLedger.Database;

namespace PocketLedger.Forms
{
    public partial class Dashboard : Form
    {
        private string loggedEmail;
        private readonly DashboardRepository _dashRepo = new DashboardRepository();

        Color normalColor   = Color.FromArgb(0,  0,  40);
        Color hoverColor    = Color.FromArgb(25, 25, 80);
        Color activeColor   = Color.FromArgb(40, 40, 120);
        Color originalColor = Color.FromArgb(3,  7,  55);

        
        private Label lblBalance, lblMonthIncome, lblMonthExpense;
        private Label lblBudgetGoal, lblSavingsRate, lblTxCount;

        public Dashboard(string loggedmail)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox     = false;
            loggedEmail = loggedmail;
        }

        
        
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            string greetingText;
            int hour = DateTime.Now.Hour;
            if (hour < 12)      greetingText = "Good Morning";
            else if (hour < 18) greetingText = "Good Afternoon";
            else                greetingText = "Good Evening";

            
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, profilepic.Width - 1, profilepic.Height - 1);
            profilepic.Region   = new Region(path);
            profilepic.SizeMode = PictureBoxSizeMode.Zoom;
            profilepic.Paint   += Profilepic_Paint;

            try
            {
                var loader = new DataFetch();
                string picPath = loader.profilePicLoad(loggedEmail);
                if (!string.IsNullOrEmpty(picPath))
                    profilepic.Image = Image.FromFile(picPath);

                string name = loader.nameLoading(loggedEmail);
                greeting.Text = $"{greetingText}, {name}!";
            }
            catch
            {
                greeting.Text = $"{greetingText}!";
            }

            
            BuildSummaryPanel();
            RefreshSummary();
        }

        
        
        
        private void BuildSummaryPanel()
        {
            
            var toRemove = new System.Collections.Generic.List<Control>();
            foreach (Control c in this.Controls)
                if (c.Tag?.ToString() == "summary") toRemove.Add(c);
            foreach (var c in toRemove) this.Controls.Remove(c);

            int startX = 185;   
            int startY = 230;   

            
            var lblHeader = new Label
            {
                Text      = "📊  Financial Overview — " + DateTime.Now.ToString("MMMM yyyy"),
                Font      = new Font("Poppins", 11F, FontStyle.Bold),
                ForeColor = Color.White,
                Location  = new Point(startX + 6, startY),
                AutoSize  = true,
                Tag       = "summary"
            };
            this.Controls.Add(lblHeader);

            startY += 38;

            
            var cards = new (string Title, Color Accent, string Tag)[]
            {
                ("Current Balance",    Color.FromArgb(80,  200, 140), "balance"),
                ("This Month Income",  Color.FromArgb(50,  190, 255), "income"),
                ("This Month Expense", Color.FromArgb(255, 90,  80),  "expense"),
                ("Budget Goals",       Color.FromArgb(180, 130, 255), "budget"),
                ("Savings Rate",       Color.FromArgb(255, 195, 50),  "savings"),
                ("Transactions",       Color.FromArgb(120, 180, 255), "txcount"),
            };

            int cardW = 156, cardH = 90, gap = 10;
            int col   = 0;

            foreach (var card in cards)
            {
                int cx = startX + col * (cardW + gap);

                var pnl = new Panel
                {
                    BackColor = Color.FromArgb(16, 24, 64),
                    Location  = new Point(cx, startY),
                    Size      = new Size(cardW, cardH),
                    Tag       = "summary"
                };

                
                var bar = new Panel
                {
                    BackColor = card.Accent,
                    Location  = new Point(0, 0),
                    Size      = new Size(cardW, 4)
                };
                pnl.Controls.Add(bar);

                var hdr = new Label
                {
                    Text      = card.Title,
                    Font      = new Font("Poppins", 7.5F, FontStyle.Bold),
                    ForeColor = card.Accent,
                    Location  = new Point(10, 12),
                    AutoSize  = true
                };
                pnl.Controls.Add(hdr);

                var val = new Label
                {
                    Text      = "—",
                    Font      = new Font("Poppins", 12F, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location  = new Point(10, 40),
                    AutoSize  = true
                };
                pnl.Controls.Add(val);

                
                switch (card.Tag)
                {
                    case "balance":  lblBalance      = val; break;
                    case "income":   lblMonthIncome  = val; break;
                    case "expense":  lblMonthExpense = val; break;
                    case "budget":   lblBudgetGoal   = val; break;
                    case "savings":  lblSavingsRate  = val; break;
                    case "txcount":  lblTxCount      = val; break;
                }

                this.Controls.Add(pnl);
                col++;
            }

            
            startY += cardH + 18;
            var lblRecent = new Label
            {
                Text      = "💡  Quick Tip: Use Budget Planner to set monthly spending goals.",
                Font      = new Font("Poppins", 9F, FontStyle.Italic),
                ForeColor = Color.FromArgb(140, 165, 210),
                Location  = new Point(startX + 6, startY),
                AutoSize  = true,
                Tag       = "summary"
            };
            this.Controls.Add(lblRecent);
        }

        
        
        
        private void RefreshSummary()
        {
            try
            {
                decimal balance  = _dashRepo.GetCurrentBalance(loggedEmail);
                decimal mIncome  = _dashRepo.GetMonthTotal(loggedEmail, "Income");
                decimal mExpense = _dashRepo.GetMonthTotal(loggedEmail, "Expense");
                decimal budget   = _dashRepo.GetTotalBudget(loggedEmail);
                int     budgetCt = _dashRepo.GetBudgetCount(loggedEmail);
                decimal savings  = _dashRepo.GetMonthlySavingsRate(loggedEmail);
                int     txCount  = _dashRepo.GetMonthTransactionCount(loggedEmail);

                if (lblBalance != null)
                {
                    lblBalance.Text      = "Rs. " + balance.ToString("N2");
                    lblBalance.ForeColor = balance >= 0
                        ? Color.FromArgb(80, 220, 140)
                        : Color.FromArgb(255, 90, 80);
                }

                if (lblMonthIncome  != null) lblMonthIncome.Text  = "Rs. " + mIncome.ToString("N2");
                if (lblMonthExpense != null) lblMonthExpense.Text = "Rs. " + mExpense.ToString("N2");

                if (lblBudgetGoal != null)
                    lblBudgetGoal.Text = budgetCt > 0
                        ? $"{budgetCt} goals\nRs. {budget:N2}"
                        : "No budgets set";

                if (lblSavingsRate != null)
                {
                    lblSavingsRate.Text = savings.ToString("N1") + "%";
                    lblSavingsRate.ForeColor = savings >= 20
                        ? Color.FromArgb(80, 220, 140)
                        : savings >= 0
                            ? Color.FromArgb(255, 200, 50)
                            : Color.FromArgb(255, 90, 80);
                }

                if (lblTxCount != null)
                    lblTxCount.Text = txCount + " this month";
            }
            catch {  }
        }

        
        
        
        public void RefreshDashboard()
        {
            Dashboard_Load(this, EventArgs.Empty);
        }

        
        
        
        public void Profilepic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var pen = new Pen(Color.White, 2);
            e.Graphics.DrawEllipse(pen, 2, 2, profilepic.Width - 5, profilepic.Height - 5);
        }

        
        
        
        private void pictureBox1_Click_2(object sender, EventArgs e)
        {
            new profile(loggedEmail).Show();
        }

        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new income(loggedEmail, RefreshDashboard).Show();
        }

        private void pictureBox4_Click_2(object sender, EventArgs e)
        {
            new income(loggedEmail, RefreshDashboard).Show();
        }

        
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new expenses(loggedEmail, RefreshDashboard).Show();
        }

        
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            new BudgetPlanner(loggedEmail, RefreshDashboard).Show();
        }

        
        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            new Report(loggedEmail).Show();
        }

        
        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
            new History(loggedEmail).Show();
        }

        
        
        
        private void Sidebar_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Panel p && p.BackColor != activeColor)
                p.BackColor = hoverColor;
        }

        private void Sidebar_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Panel p && p.BackColor != activeColor)
                p.BackColor = originalColor;
        }

        private void Sidebar_Click(object sender, EventArgs e)
        {
            if (sender is Panel p) p.BackColor = activeColor;
        }

        
        
        
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void pictureBox2_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox6_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void profilepic_Click(object sender, EventArgs e) { }
        private void profilepic_Click_1(object sender, EventArgs e) { }
        private void greeting_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void transactionpanel_Paint(object sender, PaintEventArgs e) { }
        private void pictureBox4_Click_1(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
    }
}
