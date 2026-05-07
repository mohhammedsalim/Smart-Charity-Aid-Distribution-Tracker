using System;
using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    // تعريف الفئات كـ Enum لضمان التناسق وتقليل الأخطاء
    

    public class InventoryItem
    {
        public string ItemID { get; set; } // رقم الصنف الفريد (نصي)
        public string ItemName { get; set; } // اسم الصنف
        public ItemCategory Category { get; set; } // الفئة (باستخدام Enum)
        public string Unit { get; set; } // وحدة القياس: كيلو / قطعة / لتر
        public double CurrentQuantity { get; set; } = 0; // الكمية الحالية في المخزون
        public double MinimumQuantity { get; set; } = 0; // الحد الأدنى (لإطلاق التنبيه)
        public string Description { get; set; } // وصف الصنف
        public bool IsActive { get; set; } // هل الصنف لا يزال مستخدماً
    }
}
