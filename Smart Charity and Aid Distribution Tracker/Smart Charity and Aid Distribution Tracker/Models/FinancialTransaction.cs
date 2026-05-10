using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using System;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class FinancialTransaction
    {
        public string TransactionID { get; set; }
        public TransactionType Type { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string ReferenceID { get; set; } // رقم التبرع أو التوزيع المرتبط
        public string PerformedBy { get; set; }
        public string Notes { get; set; }
    }
}
