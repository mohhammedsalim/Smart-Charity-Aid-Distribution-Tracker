using Smart_Charity_and_Aid_Distribution_Tracker.Data;
using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Services
{
    public static class UserService
    {

        public static List<User> GetUsers()
        {
            return new List<User>
            {
                new User { EmployeeID = "EMP001", FullName = "المدير العام", UserName = "admin", Password = "123", Role = UserRole.Admin, IsActive = true, CreatedDate = DateTime.Now },
                new User { EmployeeID = "EMP002", FullName = "أحمد موظف", UserName = "user", Password = "123", Role = UserRole.User, IsActive = true, CreatedDate = DateTime.Now }
            };
        }

        public static List<Beneficiary> GetBeneficiaries()
        {
            return new List<Beneficiary>
            {
                new Beneficiary { BeneficiaryID = Guid.NewGuid().ToString(), FullName = "فاطمة محمد الأحمد", NationalID = "11980123456", Phone = "0912345678", Address = "طرابلس - حي الأندلس", FamilySize = 5, SocialStatus = SocialStatus.Married, NeedReason = "وفاة الزوج وعدم وجود معيل", RegistrationDate = new DateTime(2023, 5, 10), IsActive = true, Notes = "لديها ثلاثة أطفال في سن الدراسة." },
                new Beneficiary { BeneficiaryID = Guid.NewGuid().ToString(), FullName = "علي سالم عبدالله", NationalID = "11975654321", Phone = "0923456789", Address = "بنغازي - شارع جمال عبد الناصر", FamilySize = 7, SocialStatus = SocialStatus.Married, NeedReason = "دخل محدود وعائلة كبيرة", RegistrationDate = new DateTime(2022, 11, 22), IsActive = true, Notes = "يحتاج إلى مساعدة في المواد الغذائية بشكل دوري." }
            };
        }

        private static readonly List<User> _users = GetUsers();
        private static User _currentUser = null;

        public static User Login(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.UserName.ToLower() == username.ToLower() && u.Password == password);

            if (user != null && user.IsActive)
            {
                _currentUser = user;
                user.LastLogin = DateTime.Now;
                return user;
            }
            return null;
        }

        public static void Logout()
        {
            _currentUser = null;
        }

        public static User GetCurrentUser()
        {
            return _currentUser;
        }
    }
}
