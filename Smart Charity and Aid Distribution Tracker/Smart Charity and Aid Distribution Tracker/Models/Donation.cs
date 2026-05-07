using System;
using Smart_Charity_and_Aid_Distribution_Tracker.Enums;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class Donation
    {
        public string DonationID { get; set; }
        public string DonorID { get; set; } // FK -> Donor
        public DonationType DonationType { get; set; }

        // للتبرع العيني
        public string ItemID { get; set; } // FK -> InventoryItem
        public double Quantity { get; set; }

        // للتبرع النقدي
        public double Amount { get; set; }

        public DateTime DonationDate { get; set; }
        public string ReceivedBy { get; set; } // FK -> User (EmployeeID)
        public string Notes { get; set; }
    }
}
