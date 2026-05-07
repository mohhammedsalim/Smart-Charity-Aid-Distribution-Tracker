using System;
using Smart_Charity_and_Aid_Distribution_Tracker.Enums;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class Donor
    {
        public string DonorID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DonorType DonorType { get; set; }
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Notes { get; set; }
    }
}
