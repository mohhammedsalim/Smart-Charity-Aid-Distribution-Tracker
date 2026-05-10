using System;
using System.Collections.Generic;
using Smart_Charity_and_Aid_Distribution_Tracker.Enums;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{

    public class Distribution
    {
        public string DistributionID { get; set; } // رقم العملية الفريد (نصي)
        public string BeneficiaryID { get; set; } // المستفيد (FK)
        public DateTime DistributionDate { get; set; } // تاريخ التوزيع
        public string PerformedBy { get; set; } // الموظف المنفذ (FK - اسم المستخدم)
        public DistributionStatus Status { get; set; } // حالة العملية
        public string Notes { get; set; } // ملاحظات

        // خاصية للتنقل (Navigation Property) لعرض التفاصيل المرتبطة
        public List<DistributionDetail> Details { get; set; }

        public Distribution()
        {
            Details = new List<DistributionDetail>();
        }

        public DonationType Type { get; set; } // عيني أو نقدي
        public double Amount { get; set; } // المبلغ (يُستخدم فقط إذا كان النوع نقدي)
    }
}
