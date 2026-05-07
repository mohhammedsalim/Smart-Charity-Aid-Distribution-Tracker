namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class DistributionDetail
    {
        public string DetailID { get; set; } // رقم السطر الفريد
        public string DistributionID { get; set; } // العملية الأم (FK)
        public string ItemID { get; set; } // الصنف الموزع (FK)
        public double Quantity { get; set; } // الكمية الموزعة
    }
}
