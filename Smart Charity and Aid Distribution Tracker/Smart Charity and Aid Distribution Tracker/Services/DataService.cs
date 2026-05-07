using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Services
{
    public static class DataService
    {
        // هذه هي "قاعدة البيانات" المؤقتة الخاصة بنا
        private static List<User> _users = new List<User>();
        private static List<Beneficiary> _beneficiaries = new List<Beneficiary>();
        private static readonly List<InventoryItem> _inventoryItems;
        private static readonly List<Distribution> _distributions;
        private static List<InventoryMovement> _inventoryMovements = new List<InventoryMovement>();



        static DataService()
        {
            _users = SeedData.GetUsers();
            _beneficiaries = SeedData.GetBeneficiaries();
            _inventoryItems = SeedData.GetInventoryItems();
            _distributions = new List<Distribution>();

        }



        // --- وظائف خاصة بـ SeedData ---
        public static void SetInitialData(List<User> users, List<Beneficiary> beneficiaries)
        {
            _users = users;
            _beneficiaries = beneficiaries;
        }

        // --- وظائف التعامل مع المستخدمين ---
        public static List<User> GetUsers()
        {
            return _users;
        }

        public static User GetUserByUsername(string username)
        {
            return _users.FirstOrDefault(u => u.UserName.ToLower() == username.ToLower());
        }

        // --- وظائف التعامل مع المستفيدين ---
        public static List<Beneficiary> GetBeneficiaries()
        {
            return _beneficiaries;
        }

        public static Beneficiary GetBeneficiaryById(string id)
        {
            return _beneficiaries.FirstOrDefault(b => b.BeneficiaryID == id);
        }

        public static void AddBeneficiary(Beneficiary beneficiary)
        {
            _beneficiaries.Add(beneficiary);
        }

        public static void UpdateBeneficiary(Beneficiary updatedBeneficiary)
        {
            var existingBeneficiary = _beneficiaries.FirstOrDefault(b => b.BeneficiaryID == updatedBeneficiary.BeneficiaryID);
            if (existingBeneficiary != null)
            {
                // تحديث كل الخصائص
                existingBeneficiary.FullName = updatedBeneficiary.FullName;
                existingBeneficiary.NationalID = updatedBeneficiary.NationalID;
                existingBeneficiary.Phone = updatedBeneficiary.Phone;
                existingBeneficiary.Address = updatedBeneficiary.Address;
                existingBeneficiary.FamilySize = updatedBeneficiary.FamilySize;
                existingBeneficiary.SocialStatus = updatedBeneficiary.SocialStatus;
                existingBeneficiary.NeedReason = updatedBeneficiary.NeedReason;
                existingBeneficiary.RegistrationDate = updatedBeneficiary.RegistrationDate;
                existingBeneficiary.IsActive = updatedBeneficiary.IsActive;
                existingBeneficiary.Notes = updatedBeneficiary.Notes;
            }
        }

        public static void DeleteBeneficiary(string id)
        {
            var beneficiaryToRemove = _beneficiaries.FirstOrDefault(b => b.BeneficiaryID == id);
            if (beneficiaryToRemove != null)
            {
                _beneficiaries.Remove(beneficiaryToRemove);
            }
        }

        // تأكد من أن هذه المتغيرات موجودة في الأعلى
        // private static readonly List<InventoryItem> _inventoryItems;
        // وتأكد من تهيئتها في المنشئ الثابت
        // _inventoryItems = SeedData.GetInventoryItems();

        public static List<InventoryItem> GetAllInventoryItems()
        {
            return _inventoryItems;
        }
        public static void AddInventoryItem(InventoryItem item)
        {
            _inventoryItems.Add(item);
        }

        public static void UpdateInventoryItem(InventoryItem item)
        {
            var existingItem = _inventoryItems.FirstOrDefault(i => i.ItemID == item.ItemID);
            if (existingItem != null)
            {
                existingItem.ItemName = item.ItemName;
                existingItem.Category = item.Category;
                existingItem.Unit = item.Unit;
                existingItem.CurrentQuantity = item.CurrentQuantity;
                existingItem.MinimumQuantity = item.MinimumQuantity;
                existingItem.Description = item.Description;
                existingItem.IsActive = item.IsActive;
            }
        }

        public static void DeleteInventoryItem(string id)
        {
            var item = _inventoryItems.FirstOrDefault(i => i.ItemID == id);
            if (item != null)
            {
                _inventoryItems.Remove(item);
            }
        }

       

        // --- دوال عمليات التوزيع (Distributions) ---

        public static List<Distribution> GetAllDistributions()
        {
            return _distributions;
        }

        public static void AddDistribution(Distribution distribution)
        {
            // --- الجزء الأهم: تحديث كميات المخزون ---
            foreach (var detail in distribution.Details)
            {
                var inventoryItem = GetAllInventoryItems().FirstOrDefault(i => i.ItemID == detail.ItemID);
                if (inventoryItem != null)
                {
                    // التأكد من أن الكمية لا تصبح سالبة (يمكن تحسينه لاحقاً)
                    inventoryItem.CurrentQuantity -= detail.Quantity;
                }
            }

            // لا نحتاج لإنشاء ID هنا، لأنه سيتم إنشاؤه في الفورم قبل الإضافة
            _distributions.Add(distribution);
        }

        // يمكننا إضافة دوال أخرى لاحقاً مثل إلغاء عملية توزيع

        public static User Login(string username, string password)
        {
            // ابحث عن مستخدم بنفس اسم المستخدم (مع تجاهل حالة الأحرف)
            // وتحقق من تطابق كلمة المرور (مع مراعاة حالة الأحرف)
            var user = _users.FirstOrDefault(u => u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password);

            if (user != null)
            {
                user.LastLogin = DateTime.Now; // تحديث تاريخ آخر تسجيل دخول
            }
            return user;
        }


        // --- User Management ---

        public static List<User> GetAllUsers()
        {
            return _users;
        }

        public static User GetUserById(string employeeId)
        {
            return _users.FirstOrDefault(u => u.EmployeeID == employeeId);
        }

        public static void AddUser(User user)
        {
            // الخطوة 1: قم بتصفية المستخدمين للحصول فقط على أولئك الذين لديهم EmployeeID صالح
            var validUsers = _users
                .Where(u => u.EmployeeID != null && // تأكد من أن المعرف ليس فارغاً
                            u.EmployeeID.StartsWith("E") && // تأكد من أنه يبدأ بـ 'E'
                            int.TryParse(u.EmployeeID.Substring(1), out _)) // تأكد من أن ما بعد 'E' هو رقم
                .ToList();

            // الخطوة 2: الآن، قم بحساب الرقم الأخير بناءً على القائمة المفلترة والآمنة فقط
            int lastIdNumber = 0;
            if (validUsers.Any())
            {
                lastIdNumber = validUsers.Select(u => int.Parse(u.EmployeeID.Substring(1))).Max();
            }

            // الخطوة 3: قم بإنشاء المعرف الجديد بناءً على الرقم الآمن
            user.EmployeeID = "E" + (lastIdNumber + 1).ToString("D3"); // E001, E002, etc.

            // الخطوة 4: أضف المستخدم الجديد إلى القائمة الرئيسية
            _users.Add(user);
        }

        public static void UpdateUser(User userToUpdate)
        {
            var user = _users.FirstOrDefault(u => u.EmployeeID == userToUpdate.EmployeeID);
            if (user != null)
            {
                user.FullName = userToUpdate.FullName;
                user.UserName = userToUpdate.UserName;
                user.Password = userToUpdate.Password;
                user.Role = userToUpdate.Role;
                user.IsActive = userToUpdate.IsActive;
            }
        }

        public static void DeleteUser(string employeeId)
        {
            var user = _users.FirstOrDefault(u => u.EmployeeID == employeeId);
            if (user != null)
            {
                _users.Remove(user);
            }
        }

        public static List<InventoryItem> GetInventoryItems()
        {
            //return new List<InventoryItem>
            //{
            //    new InventoryItem
            //    {
            //        ItemID = "I001",
            //        ItemName = "أرز بسمتي 10 كيلو",
            //        Category = ItemCategory.مواد_غذائية,
            //        Unit = "كيس",
            //        CurrentQuantity = 50,
            //        Description = "أرز بسمتي عالي الجودة",
            //        MinimumQuantity = 10,
            //        IsActive = true // الخصائص الجديدة
            //    },
            //    new InventoryItem
            //    {
            //        ItemID = "I002",
            //        ItemName = "زيت نباتي 1.5 لتر",
            //        Category = ItemCategory.مواد_غذائية,
            //        Unit = "زجاجة",
            //        CurrentQuantity = 100,
            //        Description = "زيت قلي وطبخ",
            //        MinimumQuantity = 20,
            //        IsActive = true // الخصائص الجديدة
            //    },
            //    new InventoryItem
            //    {
            //        ItemID = "I003",
            //        ItemName = "بطانية شتوية",
            //        Category = ItemCategory.ملابس_ومفروشات,
            //        Unit = "قطعة",
            //        CurrentQuantity = 30,
            //        Description = "بطانية مقاس مفرد",
            //        MinimumQuantity = 5,
            //        IsActive = true // الخصائص الجديدة
            //    }
            //};

            return _inventoryItems;
        }
        // ==========================================
        // --- دوال حركة المخزون (Inventory Movements) ---
        // ==========================================

        // دالة لجلب كل الحركات (سنحتاجها لاحقاً في شاشة التقارير)
        public static List<InventoryMovement> GetInventoryMovements()
        {
            return _inventoryMovements;
        }

        // الدالة الذكية لتسجيل حركة جديدة وتحديث المخزون تلقائياً
        public static void RecordMovement(InventoryMovement movement)
        {
            // 1. البحث عن الصنف المراد تحريكه
            var item = _inventoryItems.FirstOrDefault(i => i.ItemID == movement.ItemID);

            if (item != null)
            {
                // 2. تسجيل الرصيد الحالي (قبل الحركة)
                movement.QuantityBefore = item.CurrentQuantity;

                // 3. تحديث كمية الصنف بناءً على نوع الحركة
                if (movement.MovementType == MovementType.In)
                {
                    item.CurrentQuantity += movement.Quantity; // إضافة للمخزون
                }
                else if (movement.MovementType == MovementType.Out)
                {
                    item.CurrentQuantity -= movement.Quantity; // خصم من المخزون
                }
                else if (movement.MovementType == MovementType.Adjustment)
                {
                    // في حالة التسوية، نعتبر أن Quantity هي الفارق (قد تكون قيمة موجبة أو سالبة)
                    item.CurrentQuantity += movement.Quantity;
                }

                // 4. تسجيل الرصيد الجديد (بعد الحركة)
                movement.QuantityAfter = item.CurrentQuantity;

                // 5. حفظ الحركة في السجل
                _inventoryMovements.Add(movement);
            }
        }

        // ==========================================
        // --- دوال التوزيع (Distributions) ---
        // ==========================================

        private static List<DistributionDetail> _distributionDetails = new List<DistributionDetail>();

        public static void AddDistributionDetail(DistributionDetail detail)
        {
            _distributionDetails.Add(detail);
        }

    }
}
