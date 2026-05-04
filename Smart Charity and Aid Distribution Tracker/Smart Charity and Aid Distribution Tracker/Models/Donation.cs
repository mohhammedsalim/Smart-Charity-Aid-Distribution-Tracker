using Smart_Charity_and_Aid_Distribution_Tracker.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class Donation
    {
        public string DonationID { get; set; }
        public string DonorID { get; set; }
        public DonationType DonationType { get; set; }
        public string ItemID { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Amount { get; set; }
        public DateTime DonationDate { get; set; }
        public string ReceivedBy { get; set; } // EmployeeID
        public string Notes { get; set; }
    }
}
