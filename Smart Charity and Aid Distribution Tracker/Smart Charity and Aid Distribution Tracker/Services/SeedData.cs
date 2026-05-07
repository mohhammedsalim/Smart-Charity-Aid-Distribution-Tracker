using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using System;
using System.Collections.Generic;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Services
{
    public static class SeedData
    {
        public static void Initialize()
        {
            // لا تقم بأي شيء إذا كانت البيانات موجودة بالفعل
            if (DataService.GetUsers().Count > 0 || DataService.GetBeneficiaries().Count > 0)
            {
                return;
            }

            // --- إنشاء المستخدمين ---
            var users = new List<User>
            {
                new User
                {
                    EmployeeID = "E001",
                    FullName = "المدير العام",
                    UserName = "admin",
                    Password = "123", // سيتم تخزينها كنص عادي في هذه المرحلة
                    Role = UserRole.Admin,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                },
                new User
                {
                    EmployeeID = "E002",
                    FullName = "موظف إدخال",
                    UserName = "user",
                    Password = "123",
                    Role = UserRole.User,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                }
            };

            // --- إنشاء المستفيدين ---
            var beneficiaries = new List<Beneficiary>
            {
                new Beneficiary
                {
                    BeneficiaryID = "B001",
                    NationalID = "123456789012",
                    FullName = "أحمد محمد علي",
                    Phone = "0912345678",
                    Address = "طرابلس، شارع الزاوية",
                    FamilySize = 5,
                    SocialStatus = SocialStatus.Married,
                    NeedReason = "دخل محدود",
                    RegistrationDate = new DateTime(2023, 1, 15),
                    IsActive = true,
                    Notes = "يحتاج إلى مساعدة في المواد الغذائية."
                },
                new Beneficiary
                {
                    BeneficiaryID = "B002",
                    NationalID = "234567890123",
                    FullName = "فاطمة عمر حسين",
                    Phone = "0923456789",
                    Address = "بنغازي، منطقة السلماني",
                    FamilySize = 3,
                    SocialStatus = SocialStatus.Widowed,
                    NeedReason = "وفاة العائل",
                    RegistrationDate = new DateTime(2023, 3, 20),
                    IsActive = true,
                    Notes = "لديها طفلان صغيران."
                },
                new Beneficiary
                {
                    BeneficiaryID = "B003",
                    NationalID = "345678901234",
                    FullName = "علي خالد محمود",
                    Phone = "0914567890",
                    Address = "مصراتة، شارع طرابلس",
                    FamilySize = 7,
                    SocialStatus = SocialStatus.Married,
                    NeedReason = "بطالة",
                    RegistrationDate = new DateTime(2023, 5, 10),
                    IsActive = true,
                    Notes = ""
                },
                new Beneficiary
                {
                    BeneficiaryID = "B004",
                    NationalID = "456789012345",
                    FullName = "خديجة سالم إبراهيم",
                    Phone = "0925678901",
                    Address = "سبها، حي الجديد",
                    FamilySize = 4,
                    SocialStatus = SocialStatus.Married,
                    NeedReason = "عدم وجود عائل",
                    RegistrationDate = new DateTime(2023, 6, 1),
                    IsActive = false, // مثال على مستفيد غير نشط
                    Notes = "تم إيقاف المساعدة مؤقتاً."
                }
            };

            // --- إضافة البيانات إلى DataService ---
            DataService.SetInitialData(users, beneficiaries);
        }

        public static List<User> GetUsers()
        {
            return new List<User>
    {
        new User { EmployeeID = "E001", FullName = "Admin User", UserName = "admin", Password = "123", Role = UserRole.Admin, IsActive = true, CreatedDate = DateTime.Now },
        new User { EmployeeID = "E002", FullName = "Admin User", UserName = "1", Password = "1", Role = UserRole.Admin, IsActive = true, CreatedDate = DateTime.Now },
        new User { EmployeeID = "E003", FullName = "Employee User", UserName = "user", Password = "123", Role = UserRole.User, IsActive = true, CreatedDate = DateTime.Now }
    };
        }

        public static List<Beneficiary> GetBeneficiaries()
        {
            return new List<Beneficiary>
    {
        new Beneficiary {
            BeneficiaryID = "B001", NationalID = "1000000001", FullName = "أحمد محمد عبدالله",
            Phone = "0500000001", Address = "الرياض، حي الياسمين",
            FamilySize = 5, SocialStatus = SocialStatus.Married, NeedReason = "دخل محدود",
            RegistrationDate = DateTime.Now.AddMonths(-6), IsActive = true, Notes = "يحتاج إلى دعم غذائي شهري"
        },
        new Beneficiary {
            BeneficiaryID = "B002", NationalID = "1000000002", FullName = "فاطمة علي عبدالرحمن",
            Phone = "0500000002", Address = "جدة، حي الملقا",
            FamilySize = 3, SocialStatus = SocialStatus.Widowed, NeedReason = "أرملة تعول أيتام",
            RegistrationDate = DateTime.Now.AddMonths(-2), IsActive = true, Notes = ""
        }
    };
        }


        public static List<InventoryItem> GetInventoryItems()
        {
            return new List<InventoryItem>
    {
        new InventoryItem {
            ItemID = "I001", ItemName = "أرز بسمتي 10 كيلو", Category = ItemCategory.مواد_غذائية,
            Unit = "كيس", CurrentQuantity = 50, Description = "أرز بسمتي عالي الجودة",
            MinimumQuantity = 10, IsActive = true // الخصائص الجديدة
        },
        new InventoryItem {
            ItemID = "I002", ItemName = "زيت نباتي 1.5 لتر", Category = ItemCategory.مواد_غذائية,
            Unit = "زجاجة", CurrentQuantity = 100, Description = "زيت قلي وطبخ",
            MinimumQuantity = 20, IsActive = true // الخصائص الجديدة
        },
        new InventoryItem {
            ItemID = "I003", ItemName = "بطانية شتوية", Category = ItemCategory.ملابس_ومفروشات,
            Unit = "قطعة", CurrentQuantity = 30, Description = "بطانية مقاس مفرد",
            MinimumQuantity = 5, IsActive = true // الخصائص الجديدة
        }
    };
        }




    }
}
