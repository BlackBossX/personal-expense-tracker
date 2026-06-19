using Microsoft.Reporting.WinForms;
using PocketLedger.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PocketLedger.Forms
{
    public partial class Report : Form
    {
        private string loggedEmail;
        private readonly ReportRepository _reportRepo = new ReportRepository();

        public Report(string loggedmail)
        {
            InitializeComponent();
            loggedEmail = loggedmail;

            this.Load += Report_Load;
            btnGenerate.Click += btnGenerate_Click;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddMonths(-6);
            dtpTo.Value = DateTime.Today;

            LoadReport();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                var categoryRows = GetCategoryReportRows(dtpFrom.Value, dtpTo.Value);
                var typeRows = GetTypeReportRows(dtpFrom.Value, dtpTo.Value);
                var monthlyRows = GetMonthlyReportRows(dtpFrom.Value, dtpTo.Value);

                reportViewer1.LocalReport.ReportPath =
                    System.IO.Path.Combine(Application.StartupPath, "Forms", "PocketLedgerReport.rdlc");

                reportViewer1.LocalReport.DataSources.Clear();

                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("CategoryData", categoryRows));

                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("TypeReport", typeRows));

                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("MonthlyReport", monthlyRows));

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to generate report: " + ex.Message,
                    "Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<CategoryReportRow> GetCategoryReportRows(DateTime from, DateTime to)
        {
            DataTable dt = _reportRepo.GetCategoryBreakdown(loggedEmail, from, to);
            var list = new List<CategoryReportRow>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new CategoryReportRow
                {
                    Category = row["Category"] != DBNull.Value ? row["Category"].ToString() : "Uncategorized",
                    Total = row["Total"] != DBNull.Value ? Convert.ToDecimal(row["Total"]) : 0
                });
            }

            return list;
        }

        private List<TypeReportRow> GetTypeReportRows(DateTime from, DateTime to)
        {
            DataTable dt = _reportRepo.GetIncomeVsExpense(loggedEmail, from, to);
            var list = new List<TypeReportRow>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new TypeReportRow
                {
                    Type = row["Type"] != DBNull.Value ? row["Type"].ToString() : "",
                    Total = row["Total"] != DBNull.Value ? Convert.ToDecimal(row["Total"]) : 0
                });
            }

            return list;
        }

        private List<MonthlyReportRow> GetMonthlyReportRows(DateTime from, DateTime to)
        {
            DataTable dt = _reportRepo.GetMonthlySummary(loggedEmail, from, to);
            var list = new List<MonthlyReportRow>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new MonthlyReportRow
                {
                    MonthYear = row["MonthYear"] != DBNull.Value ? row["MonthYear"].ToString() : "",
                    Type = row["Type"] != DBNull.Value ? row["Type"].ToString() : "",
                    Total = row["Total"] != DBNull.Value ? Convert.ToDecimal(row["Total"]) : 0
                });
            }

            return list;
        }
    }
}