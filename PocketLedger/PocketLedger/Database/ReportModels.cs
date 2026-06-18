namespace PocketLedger.Database
{
    public class CategoryReportRow
    {
        public string Category { get; set; }
        public decimal Total { get; set; }
    }

    public class TypeReportRow
    {
        public string Type { get; set; }
        public decimal Total { get; set; }
    }

    public class MonthlyReportRow
    {
        public string MonthYear { get; set; }
        public string Type { get; set; }
        public decimal Total { get; set; }
    }
}