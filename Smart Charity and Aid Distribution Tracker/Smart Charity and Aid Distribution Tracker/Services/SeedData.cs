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
                    SocialStatus = "متزوج",
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
                    SocialStatus = "أرملة",
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
                    SocialStatus = "متزوج",
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
                    SocialStatus = "مطلقة",
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
                new User { EmployeeID = "EMP001", FullName = "المدير العام", UserName = "admin", Password = "123", Role = UserRole.Admin, IsActive = true, CreatedDate = DateTime.Now },
                new User { EmployeeID = "EMP002", FullName = "أحمد موظف", UserName = "user", Password = "123", Role = UserRole.User, IsActive = true, CreatedDate = DateTime.Now }
            };
        }

        public static List<Beneficiary> GetBeneficiaries()
        {
            return new List<Beneficiary>
            {
                new Beneficiary { BeneficiaryID = Guid.NewGuid().ToString(), FullName = "فاطمة محمد الأحمد", NationalID = "11980123456", Phone = "0912345678", Address = "طرابلس - حي الأندلس", FamilySize = 5, SocialStatus = "أرملة", NeedReason = "وفاة الزوج وعدم وجود معيل", RegistrationDate = new DateTime(2023, 5, 10), IsActive = true, Notes = "لديها ثلاثة أطفال في سن الدراسة." },
                new Beneficiary { BeneficiaryID = Guid.NewGuid().ToString(), FullName = "علي سالم عبدالله", NationalID = "11975654321", Phone = "0923456789", Address = "بنغازي - شارع جمال عبد الناصر", FamilySize = 7, SocialStatus = "أسرة فقيرة", NeedReason = "دخل محدود وعائلة كبيرة", RegistrationDate = new DateTime(2022, 11, 22), IsActive = true, Notes = "يحتاج إلى مساعدة في المواد الغذائية بشكل دوري." }
            };
        }

        public static List<InventoryItem> GetInventoryItems()
        {
            return new List<InventoryItem>
            {
                new InventoryItem { ItemID = "ITM-001", ItemName = "كيس دقيق فاخر", Category = ItemCategory.مواد_غذائية, Unit = "كيس", CurrentQuantity = 150, MinimumQuantity = 20, Description = "دقيق قمح أبيض، وزن 10 كجم", IsActive = true },
                new InventoryItem { ItemID = "ITM-002", ItemName = "زيت طهي", Category = ItemCategory.مواد_غذائية, Unit = "لتر", CurrentQuantity = 200, MinimumQuantity = 50, Description = "زيت دوار الشمس، عبوة 1 لتر", IsActive = true },
                new InventoryItem { ItemID = "ITM-003", ItemName = "بطانية شتوية مزدوجة", Category = ItemCategory.ملابس_ومفروشات, Unit = "قطعة", CurrentQuantity = 80, MinimumQuantity = 10, Description = "صوف صناعي عالي الجودة", IsActive = true },
                new InventoryItem { ItemID = "ITM-004", ItemName = "معجون أسنان", Category = ItemCategory.مواد_نظافة, Unit = "قطعة", CurrentQuantity = 300, MinimumQuantity = 100, Description = "", IsActive = true },
                new InventoryItem { ItemID = "ITM-005", ItemName = "حليب أطفال مجفف (المرحلة 1)", Category = ItemCategory.مستلزمات_أطفال, Unit = "علبة", CurrentQuantity = 50, MinimumQuantity = 15, Description = "للأطفال من 0-6 أشهر", IsActive = true },
                new InventoryItem { ItemID = "ITM-006", ItemName = "سخان كهربائي قديم", Category = ItemCategory.أجهزة_كهربائية, Unit = "قطعة", CurrentQuantity = 5, MinimumQuantity = 1, Description = "تم التبرع به، يحتاج للفحص", IsActive = false }
            };
        }

    }
}
