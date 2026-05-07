using Smart_Charity_and_Aid_Distribution_Tracker.Models;
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

        public static void DeleteInventoryItem(string id) // <-- تم التغيير إلى string
        {
            var itemToRemove = _inventoryItems.FirstOrDefault(i => i.ItemID == id);
            if (itemToRemove != null)
            {
                _inventoryItems.Remove(itemToRemove);
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


    }
}
