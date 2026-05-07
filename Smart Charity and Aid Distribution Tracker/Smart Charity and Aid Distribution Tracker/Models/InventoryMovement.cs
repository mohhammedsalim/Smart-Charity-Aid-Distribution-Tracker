using System;
using Smart_Charity_and_Aid_Distribution_Tracker.Enums;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class InventoryMovement
    {
        public string MovementID { get; set; }      // رقم الحركة الفريد (إلزامي)
        public string ItemID { get; set; }          // الصنف المتحرك (إلزامي)
        public MovementType MovementType { get; set; } // نوع الحركة: وارد/صادر/تسوية (إلزامي)
        public double Quantity { get; set; }        // الكمية المتحركة (إلزامي)
        public double QuantityBefore { get; set; }  // الرصيد قبل الحركة (إلزامي)
        public double QuantityAfter { get; set; }   // الرصيد بعد الحركة (إلزامي)
        public DateTime MovementDate { get; set; }  // تاريخ الحركة (إلزامي)
        public string ReferenceID { get; set; }     // رقم مرجع التبرع أو التوزيع (اختياري)
        public string PerformedBy { get; set; }     // الموظف المنفذ - EmployeeID (إلزامي)
        public string Notes { get; set; }           // سبب التسوية أو ملاحظة (اختياري)
    }
}
