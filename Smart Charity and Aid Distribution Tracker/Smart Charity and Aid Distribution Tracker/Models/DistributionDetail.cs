using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class DistributionDetail
    {
        public string DetailID { get; set; }
        public string DistributionID { get; set; }
        public string ItemID { get; set; }
        public decimal Quantity { get; set; }
    }
}
