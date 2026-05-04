using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class InventoryItem
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; } // يمكن تحويله لـ enum
        public string Unit { get; set; }
        public decimal CurrentQuantity { get; set; }
        public decimal MinimumQuantity { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
