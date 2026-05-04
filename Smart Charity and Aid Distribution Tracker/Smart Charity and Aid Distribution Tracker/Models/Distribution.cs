using Smart_Charity_and_Aid_Distribution_Tracker.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class Distribution
    {
        public string DistributionID { get; set; }
        public string BeneficiaryID { get; set; }
        public string PerformedBy { get; set; } // EmployeeID
        public DateTime DistributionDate { get; set; }
        public DistributionStatus Status { get; set; }
        public string Notes { get; set; }

        // خاصية للتنقل، تمثل العلاقة 1-to-Many
        public List<DistributionDetail> Details { get; set; } = new List<DistributionDetail>();
    }
}
