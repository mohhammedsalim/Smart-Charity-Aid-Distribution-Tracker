using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class Donor
    {
        public string DonorID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DonorType { get; set; } // يمكن تحويله لـ enum (فرد، شركة)
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Notes { get; set; }
    }
}
