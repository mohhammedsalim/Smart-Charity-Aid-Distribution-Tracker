using Smart_Charity_and_Aid_Distribution_Tracker.Enums; // لاستخدام UserRole
using System;
namespace Smart_Charity_and_Aid_Distribution_Tracker.Models
{
    public class User
    {
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLogin { get; set; }
    }
}