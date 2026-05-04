using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class Beneficiary
    {
        public string BeneficiaryID { get; set; }
        public string NationalID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int FamilySize { get; set; }
        public string SocialStatus { get; set; } // يمكن تحويله لـ enum لاحقاً
        public string NeedReason { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
        public DateTime? LastAidDate { get; set; }
    }
}
