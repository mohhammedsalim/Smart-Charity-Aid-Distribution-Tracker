using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Models.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Data
{
    public static class DataStore
    {
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static List<User> U { get; set; } = new List<User>();
        public static List<Beneficiary> B{ get; set; } = new List<Beneficiary>();

        public static void SeedData1()
        {
            if (U.Count == 0)
            {
                U.Add(new User { UserName = "admin", Password = "123", FullName = "المدير العام" });
                U.Add(new User { UserName = "user", Password = "123", FullName = "أحمد محمد" });
            }

          
            if (B.Count == 0) 
            {
                B.Add(new Beneficiary
                {
                    BeneficiaryID = "B001",
                    FullName = "علي سالم عبدالله",
                    NationalID = "119801234567",
                    FamilySize = 5,
                    SocialStatus = "أرملة",
                    Address = "طرابلس - حي الأندلس",
                    Phone = "0911234567",
                    RegistrationDate = new DateTime(2023, 5, 10),
                    IsActive = true
                });

                B.Add(new Beneficiary
                {
                    BeneficiaryID = "B002",
                    FullName = "فاطمة عمر خليل",
                    NationalID = "219857654321",
                    FamilySize = 3,
                    SocialStatus = "مطلقة",
                    Address = "بنغازي - الكيش",
                    Phone = "0927654321",
                    RegistrationDate = new DateTime(2024, 1, 20),
                    IsActive = true
                });

                B.Add(new Beneficiary
                {
                    BeneficiaryID = "B003",
                    FullName = "محمد إبراهيم مصطفى",
                    NationalID = "119759876543",
                    FamilySize = 7,
                    SocialStatus = "متزوج",
                    Address = "مصراتة - وسط البلاد",
                    Phone = "0949876543",
                    RegistrationDate = new DateTime(2022, 11, 15),
                    IsActive = false // مثال على مستفيد غير نشط
                });
            }
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        //public static Dictionary<string, User> Users { get; set; } = new Dictionary<string, User>();
        //public static Dictionary<string, Beneficiary> Beneficiaries { get; set; } = new Dictionary<string, Beneficiary>();
        //public static Dictionary<string, Donor> Donors { get; set; } = new Dictionary<string, Donor>();
        //public static Dictionary<string, InventoryItem> InventoryItems { get; set; } = new Dictionary<string, InventoryItem>();

        //public static List<Donation> Donations { get; set; } = new List<Donation>();
        //public static List<Distribution> Distributions { get; set; } = new List<Distribution>();
        //public static List<InventoryMovement> Movements { get; set; } = new List<InventoryMovement>();

        //public static HashSet<string> BeneficiaryNationalIDs { get; set; } = new HashSet<string>();

        //public static User CurrentUser { get; set; }

        //public static void SeedData()
        //{
        //    if (Users.Count > 0) return; 

        //    var admin = new User { EmployeeID = "EMP001", UserName = "admin", Password = "123", Role = UserRole.Admin, FullName = "مدير النظام", IsActive = true };
        //    Users.Add(admin.EmployeeID, admin);

        //    var rice = new InventoryItem { ItemID = "ITM001", ItemName = "أرز", CurrentQuantity = 500, MinimumQuantity = 50, Category = "غذائي", Unit = "كيلو" };
        //    InventoryItems.Add(rice.ItemID, rice);

        //    var ben1 = new Beneficiary { BeneficiaryID = "BEN001", NationalID = "1234567890", FullName = "أسرة محمد عبدالله", FamilySize = 5 };
        //    Beneficiaries.Add(ben1.BeneficiaryID, ben1);
        //    BeneficiaryNationalIDs.Add(ben1.NationalID);
        }
    }
}
