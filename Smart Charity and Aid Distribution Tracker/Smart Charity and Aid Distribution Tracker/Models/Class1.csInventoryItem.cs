using Smart_Charity_and_Aid_Distribution_Tracker.Enums;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class InventoryItem
    {
        public string ItemID { get; set; }          // رقم الصنف الفريد
        public string ItemName { get; set; }        // اسم الصنف
        public ItemCategory Category { get; set; }  // الفئة
        public string Unit { get; set; }            // وحدة القياس
        public double CurrentQuantity { get; set; } // الكمية الحالية
        public string Description { get; set; }     // الوصف

        // --- الخصائص الجديدة ---
        public double MinimumQuantity { get; set; } // الحد الأدنى (لإطلاق التنبيه)
        public bool IsActive { get; set; }          // هل الصنف لا يزال مستخدماً
    }
}
