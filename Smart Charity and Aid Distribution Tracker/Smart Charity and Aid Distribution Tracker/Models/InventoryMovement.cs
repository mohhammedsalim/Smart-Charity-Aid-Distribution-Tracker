using Smart_Charity_and_Aid_Distribution_Tracker.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class InventoryMovement
    {
        public string MovementID { get; set; }
        public string ItemID { get; set; }
        public MovementType MovementType { get; set; }
        public decimal Quantity { get; set; }
        public decimal QuantityBefore { get; set; }
        public decimal QuantityAfter { get; set; }
        public DateTime MovementDate { get; set; }
        public string ReferenceID { get; set; } // ID للتبرع أو التوزيع
        public string PerformedBy { get; set; } // EmployeeID
        public string Notes { get; set; }
    }
}
