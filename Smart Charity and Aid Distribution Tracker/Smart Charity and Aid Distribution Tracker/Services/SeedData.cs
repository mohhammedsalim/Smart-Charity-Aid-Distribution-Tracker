using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using System;
using System.Collections.Generic;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Services
{
    public static class SeedData
    {
        private static Random rnd = new Random();

        public static void Initialize()
        {
            // لا تقم بأي شيء إذا كانت البيانات موجودة بالفعل
            if (DataService.GetUsers().Count > 0 || DataService.GetBeneficiaries().Count > 0)
            {
                return;
            }

            // --- إضافة جميع البيانات إلى DataService ---
            DataService.SetInitialData(
                GetUsers(),
                GetBeneficiaries(),
                GetInventoryItems(),
                GetDonors(),
                GetDonations(),
                GetDistributions(),
                GetFinancialTransactions() 
            );


        }


        public static List<User> GetUsers()
        {
            return new List<User>
            {
                new User { EmployeeID = "E001", FullName = "المدير العام", UserName = "مدير", Password = "123", Role = UserRole.مدير, IsActive = true, CreatedDate = DateTime.Now },
                new User { EmployeeID = "E002", FullName = "موظف إدخال", UserName = "1", Password = "1", Role = UserRole.أمين_مخزن, IsActive = true, CreatedDate = DateTime.Now },
                new User { EmployeeID = "E003", FullName = "مستخدم عادي", UserName = "موظف", Password = "123", Role = UserRole.مستخدم_عادي, IsActive = true, CreatedDate = DateTime.Now }
            };
        }

        public static List<Beneficiary> GetBeneficiaries()
        {
            var list = new List<Beneficiary>
            {
                // بياناتك الأصلية
                new Beneficiary { BeneficiaryID = "B001", NationalID = "1000000001", FullName = "أحمد محمد عبدالله", Phone = "0500000001", Address = "الرياض، حي الياسمين", FamilySize = 5, SocialStatus = SocialStatus.متزوج, NeedReason = "دخل محدود", RegistrationDate = DateTime.Now.AddMonths(-6), IsActive = true, Notes = "يحتاج إلى دعم غذائي شهري" },
                new Beneficiary { BeneficiaryID = "B002", NationalID = "1000000002", FullName = "فاطمة علي عبدالرحمن", Phone = "0500000002", Address = "جدة، حي الملقا", FamilySize = 3, SocialStatus = SocialStatus.أرمل, NeedReason = "أرملة تعول أيتام", RegistrationDate = DateTime.Now.AddMonths(-2), IsActive = true, Notes = "" }
            };

            // توليد 50 مستفيد إضافي
            string[] names = { "خالد", "سالم", "عمر", "يوسف", "سارة", "مريم", "نورة", "هند" };
            string[] families = { "الغامدي", "الزهراني", "الدوسري", "العتيبي", "الشهري", "المطيري" };
            string[] cities = { "الدمام", "مكة", "المدينة", "الطائف", "أبها", "تبوك" };

            for (int i = 3; i <= 52; i++)
            {
                list.Add(new Beneficiary
                {
                    BeneficiaryID = "B" + i.ToString("D3"),
                    NationalID = "10" + rnd.Next(10000000, 99999999).ToString(),
                    FullName = names[rnd.Next(names.Length)] + " " + families[rnd.Next(families.Length)],
                    Phone = "05" + rnd.Next(10000000, 99999999).ToString(),
                    Address = cities[rnd.Next(cities.Length)],
                    FamilySize = rnd.Next(1, 10),
                    SocialStatus = (SocialStatus)rnd.Next(0, 4),
                    NeedReason = "احتياج عام",
                    RegistrationDate = DateTime.Now.AddDays(-rnd.Next(1, 365)),
                    IsActive = true,
                    Notes = ""
                });
            }
            return list;
        }

        public static List<InventoryItem> GetInventoryItems()
        {
            var list = new List<InventoryItem>
            {
                // بياناتك الأصلية
                new InventoryItem { ItemID = "I001", ItemName = "أرز بسمتي 10 كيلو", Category = ItemCategory.مواد_غذائية, Unit = "كيس", CurrentQuantity = 500, Description = "أرز بسمتي عالي الجودة", MinimumQuantity = 10, IsActive = true },
                new InventoryItem { ItemID = "I002", ItemName = "زيت نباتي 1.5 لتر", Category = ItemCategory.مواد_غذائية, Unit = "زجاجة", CurrentQuantity = 1000, Description = "زيت قلي وطبخ", MinimumQuantity = 20, IsActive = true },
                new InventoryItem { ItemID = "I003", ItemName = "بطانية شتوية", Category = ItemCategory.ملابس_ومفروشات, Unit = "قطعة", CurrentQuantity = 300, Description = "بطانية مقاس مفرد", MinimumQuantity = 5, IsActive = true }
            };

            // توليد أصناف إضافية
            string[] items = { "دقيق 5 كجم", "حليب مجفف", "مكرونة", "صلصة طماطم", "شاي", "تمر", "دفاية", "حقيبة مدرسية" };
            for (int i = 0; i < items.Length; i++)
            {
                list.Add(new InventoryItem
                {
                    ItemID = "I" + (i + 4).ToString("D3"),
                    ItemName = items[i],
                    // التعديل هنا للأسماء العربية
                    Category = i > 5 ? ItemCategory.ملابس_ومفروشات : ItemCategory.مواد_غذائية,
                    Unit = i > 5 ? "قطعة" : "حبة",
                    CurrentQuantity = rnd.Next(100, 1000),
                    MinimumQuantity = 20,
                    IsActive = true,
                    Description = "صنف متوفر بالمستودع"
                });
            }
            return list;
        }

        public static List<Donor> GetDonors()
        {
            var list = new List<Donor>
            {
                // بياناتك الأصلية
                new Donor { DonorID = "DN001", FullName = "فاعل خير", Phone = "0555555555", DonorType = DonorType.فرد, RegistrationDate = DateTime.Now.AddDays(-30) },
                new Donor { DonorID = "DN002", FullName = "مؤسسة العطاء", Phone = "0111111111", DonorType = DonorType.شركة, RegistrationDate = DateTime.Now.AddDays(-15) },
                new Donor { DonorID = "DN003", FullName = "محمد صالح", Phone = "0501234567", DonorType = DonorType. جهة_حكومية, RegistrationDate = DateTime.Now.AddDays(-5) }
            };

            // توليد 30 متبرع إضافي
            for (int i = 4; i <= 33; i++)
            {
                list.Add(new Donor
                {
                    DonorID = "DN" + i.ToString("D3"),
                    FullName = "متبرع " + i,
                    Phone = "05" + rnd.Next(10000000, 99999999).ToString(),
                    DonorType = rnd.Next(0, 2) == 0 ? DonorType.فرد : DonorType.شركة,
                    RegistrationDate = DateTime.Now.AddDays(-rnd.Next(1, 365))
                });
            }
            return list;
        }

        public static List<Donation> GetDonations()
        {
            var list = new List<Donation>
            {
                // بياناتك الأصلية
                new Donation { DonationID = "DO001", DonorID = "DN001", DonationType = DonationType.نقدي, Amount = 5000, DonationDate = DateTime.Now.AddDays(-10) },
                new Donation { DonationID = "DO002", DonorID = "DN002", DonationType = DonationType.عيني, ItemID = "I001", Quantity = 50, DonationDate = DateTime.Now.AddDays(-5) },
                new Donation { DonationID = "DO003", DonorID = "DN003", DonationType = DonationType.نقدي, Amount = 1500, DonationDate = DateTime.Now.AddDays(-2) },
                new Donation { DonationID = "DO004", DonorID = "DN001", DonationType = DonationType.عيني, ItemID = "I003", Quantity = 20, DonationDate = DateTime.Now.AddDays(-1) }
            };

            // توليد 100 عملية تبرع إضافية
            for (int i = 5; i <= 104; i++)
            {
                bool isCash = rnd.Next(0, 2) == 0;
                list.Add(new Donation
                {
                    DonationID = "DO" + i.ToString("D4"),
                    DonorID = "DN" + rnd.Next(1, 34).ToString("D3"),
                    DonationType = isCash ? DonationType.نقدي : DonationType.عيني,
                    Amount = isCash ? rnd.Next(100, 5000) : 0,
                    ItemID = isCash ? null : "I" + rnd.Next(1, 12).ToString("D3"),
                    Quantity = isCash ? 0 : rnd.Next(10, 100),
                    DonationDate = DateTime.Now.AddDays(-rnd.Next(1, 150))
                });
            }
            return list;
        }

        public static List<Distribution> GetDistributions()
        {
            var list = new List<Distribution>();

            // بياناتك الأصلية
            var dist1 = new Distribution { DistributionID = "D001", BeneficiaryID = "B001", DistributionDate = DateTime.Now.AddDays(-2), Status = DistributionStatus.منفذة, PerformedBy = "E001", Details = new List<DistributionDetail>() };
            dist1.Details.Add(new DistributionDetail { DetailID = "DD001", DistributionID = "D001", ItemID = "I001", Quantity = 2 });
            dist1.Details.Add(new DistributionDetail { DetailID = "DD002", DistributionID = "D001", ItemID = "I002", Quantity = 3 });

            var dist2 = new Distribution { DistributionID = "D002", BeneficiaryID = "B002", DistributionDate = DateTime.Now.AddDays(-1), Status = DistributionStatus.منفذة, PerformedBy = "E001", Details = new List<DistributionDetail>() };
            dist2.Details.Add(new DistributionDetail { DetailID = "DD003", DistributionID = "D002", ItemID = "I001", Quantity = 1 });
            dist2.Details.Add(new DistributionDetail { DetailID = "DD004", DistributionID = "D002", ItemID = "I003", Quantity = 2 });

            list.Add(dist1);
            list.Add(dist2);

            // توليد 100 عملية صرف إضافية
            for (int i = 3; i <= 102; i++)
            {
                var dist = new Distribution
                {
                    DistributionID = "D" + i.ToString("D4"),
                    BeneficiaryID = "B" + rnd.Next(1, 53).ToString("D3"),
                    DistributionDate = DateTime.Now.AddDays(-rnd.Next(1, 150)),
                    Status = DistributionStatus.منفذة,
                    PerformedBy = "E001",
                    Details = new List<DistributionDetail>()
                };

                int detailsCount = rnd.Next(1, 4);
                for (int j = 0; j < detailsCount; j++)
                {
                    dist.Details.Add(new DistributionDetail
                    {
                        DetailID = "DD" + Guid.NewGuid().ToString().Substring(0, 8),
                        DistributionID = dist.DistributionID,
                        ItemID = "I" + rnd.Next(1, 12).ToString("D3"),
                        Quantity = rnd.Next(1, 5)
                    });
                }
                list.Add(dist);
            }
            return list;
        }

        private static List<FinancialTransaction> GetFinancialTransactions()
        {
            return new List<FinancialTransaction>
            {
                new FinancialTransaction
                {
                    TransactionID = "TRX_INIT_001",
                    Type = TransactionType.وارد,
                    Amount = 5000,
                    TransactionDate = DateTime.Now,
                    ReferenceID = "SYS_INIT",
                    PerformedBy = "System",
                    Notes = "رصيد افتتاحي مبدئي"
                }
            };
        }
    }
}
