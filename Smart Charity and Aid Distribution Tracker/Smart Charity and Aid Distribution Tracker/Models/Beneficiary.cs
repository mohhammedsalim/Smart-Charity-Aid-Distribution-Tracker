using System;
using Smart_Charity_and_Aid_Distribution_Tracker.Enums;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class Beneficiary
    {
        public string BeneficiaryID { get; set; } // رقم تعريفي فريد
        public string NationalID { get; set; }    // رقم الهوية الوطنية
        public string FullName { get; set; }      // الاسم الكامل
        public string Phone { get; set; }         // رقم الجوال
        public string Address { get; set; }       // العنوان

        // --- الخصائص الجديدة ---
        public int FamilySize { get; set; }       // عدد أفراد الأسرة
        public SocialStatus SocialStatus { get; set; } // الحالة الاجتماعية
        public string NeedReason { get; set; }    // سبب الاحتياج
        public DateTime RegistrationDate { get; set; } // تاريخ التسجيل
        public bool IsActive { get; set; }        // هل لا يزال مستفيداً
        public string Notes { get; set; }         // ملاحظات خاصة
        public DateTime? LastAidDate { get; set; } // آخر مرة استلم فيها مساعدة (Nullable)
    }
}
