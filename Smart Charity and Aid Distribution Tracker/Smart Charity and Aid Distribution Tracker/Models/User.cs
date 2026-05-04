using Smart_Charity_and_Aid_Distribution_Tracker.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class User
    {
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; } // سنستخدم نص عادي في هذه المرحلة
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLogin { get; set; } // علامة الاستفهام تعني أنه يمكن أن يكون null
    }
}
