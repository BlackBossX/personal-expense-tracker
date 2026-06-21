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

            int contentX = 185;
            int contentW = 990;
            int gap      = 14;

            int y = 135;
            AddSummaryLabel(
                "📊  Financial Overview  —  " + DateTime.Now.ToString("MMMM yyyy"),
                new Font("Poppins", 11F, FontStyle.Bold),
                Color.FromArgb(180, 200, 255),
                new Point(contentX + 4, y), autoSize: true);
            y += 36;

            int heroH = 110;
            var heroPanel = MakeCard(
                contentX, y, contentW, heroH,
                "Current Balance",
                Color.FromArgb(80, 220, 140),
                bigTitle: true);
            lblBalance = heroPanel.Controls["val"] as Label;
            this.Controls.Add(heroPanel);
            y += heroH + gap;

            int halfW = (contentW - gap) / 2;
            int midH  = 100;

            var incPanel = MakeCard(contentX, y, halfW, midH,
                "💰  This Month — Income", Color.FromArgb(50, 190, 255));
            lblMonthIncome = incPanel.Controls["val"] as Label;
            this.Controls.Add(incPanel);

            var expPanel = MakeCard(contentX + halfW + gap, y, halfW, midH,
                "💸  This Month — Expense", Color.FromArgb(255, 90, 80));
            lblMonthExpense = expPanel.Controls["val"] as Label;
            this.Controls.Add(expPanel);
            y += midH + gap;

            int thirdW = (contentW - gap * 2) / 3;
            int thirdH = 100;

            var budPanel = MakeCard(contentX, y, thirdW, thirdH,
                "🎯  Budget Goals", Color.FromArgb(180, 130, 255));
            lblBudgetGoal = budPanel.Controls["val"] as Label;
            this.Controls.Add(budPanel);

            var savPanel = MakeCard(contentX + thirdW + gap, y, thirdW, thirdH,
                "📈  Savings Rate", Color.FromArgb(255, 200, 50));
            lblSavingsRate = savPanel.Controls["val"] as Label;
            this.Controls.Add(savPanel);

            var txPanel = MakeCard(contentX + (thirdW + gap) * 2, y, thirdW, thirdH,
                "🔁  Transactions", Color.FromArgb(120, 180, 255));
            lblTxCount = txPanel.Controls["val"] as Label;
            this.Controls.Add(txPanel);
            y += thirdH + gap;

            var tipBar = new Panel
            {
                BackColor = Color.FromArgb(12, 18, 55),
                Location  = new Point(contentX, y),
                Size      = new Size(contentW, 38),
                Tag       = "summary"
            };
            var tipLbl = new Label
            {
                Text      = "💡  Tip: Use the Budget Planner to set monthly spending limits and track your goals in real time.",
                Font      = new Font("Poppins", 8.5F, FontStyle.Italic),
                ForeColor = Color.FromArgb(130, 160, 210),
                Location  = new Point(12, 9),
                AutoSize  = true
            };
            tipBar.Controls.Add(tipLbl);
            this.Controls.Add(tipBar);
        }

        private Panel MakeCard(int x, int y, int w, int h,
                               string title, Color accent, bool bigTitle = false)
        {
            var pnl = new Panel
            {
                BackColor = Color.FromArgb(13, 20, 60),
                Location  = new Point(x, y),
                Size      = new Size(w, h),
                Tag       = "summary"
            };

            pnl.Controls.Add(new Panel
            {
                BackColor = accent,
                Location  = new Point(0, 0),
                Size      = new Size(w, 4)
            });

            pnl.Controls.Add(new Label
            {
                Text      = title,
                Font      = new Font("Poppins", bigTitle ? 9F : 8F, FontStyle.Bold),
                ForeColor = accent,
                Location  = new Point(14, 12),
                AutoSize  = true
            });

            var val = new Label
            {
                Name      = "val",
                Text      = "—",
                Font      = new Font("Poppins", bigTitle ? 22F : 14F, FontStyle.Bold),
                ForeColor = Color.White,
                Location  = new Point(14, bigTitle ? 46 : 42),
                AutoSize  = true
            };
            pnl.Controls.Add(val);

            return pnl;
        }

        private void AddSummaryLabel(string text, Font font, Color fore,
                                     Point loc, bool autoSize = true)
        {
            this.Controls.Add(new Label
            {
                Text      = text,
                Font      = font,
                ForeColor = fore,
                Location  = loc,
                AutoSize  = autoSize,
                Tag       = "summary"
            });
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
