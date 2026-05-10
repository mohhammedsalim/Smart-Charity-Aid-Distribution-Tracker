using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Services
{
    public static class DataService
    {
        // ==========================================
        // --- تعريف جميع القوائم (مرة واحدة فقط) ---
        // ==========================================
        private static List<User> _users = new List<User>();
        private static List<Beneficiary> _beneficiaries = new List<Beneficiary>();
        private static List<InventoryItem> _inventoryItems = new List<InventoryItem>();
        private static List<Distribution> _distributions = new List<Distribution>();
        private static List<InventoryMovement> _inventoryMovements = new List<InventoryMovement>();
        private static List<Donor> _donors = new List<Donor>();
        private static List<Donation> _donations = new List<Donation>();
        private static List<DistributionDetail> _distributionDetails = new List<DistributionDetail>();
        private static List<FinancialTransaction> _financialTransactions = new List<FinancialTransaction>();


        // ==========================================
        // --- المُنشئ الثابت لجلب البيانات ---
        // ==========================================
        static DataService()
        {
            // استدعاء دالة التهيئة من SeedData
            SeedData.Initialize();
        }

        // --- وظائف خاصة بـ SeedData ---
        public static void SetInitialData(
            List<User> users,
            List<Beneficiary> beneficiaries,
            List<InventoryItem> inventoryItems,
            List<Donor> donors,
            List<Donation> donations,
            List<Distribution> distributions,
            List<FinancialTransaction> financialTransactions
            )
        {
            _users = users;
            _beneficiaries = beneficiaries;
            _inventoryItems = inventoryItems;
            _donors = donors;
            _donations = donations;
            _distributions = distributions;
            _financialTransactions = financialTransactions;

        }



        // ==========================================
        // --- وظائف التعامل مع المستخدمين ---
        // ==========================================
        public static User Login(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && u.Password == password);
            if (user != null)
            {
                user.LastLogin = DateTime.Now;
            }
            return user;
        }

        public static List<User> GetUsers()
        {
            return _users;
        }

        public static List<User> GetAllUsers()
        {
            return _users;
        }

        public static User GetUserByUsername(string username)
        {
            return _users.FirstOrDefault(u => u.UserName.ToLower() == username.ToLower());
        }

        public static User GetUserById(string employeeId)
        {
            return _users.FirstOrDefault(u => u.EmployeeID == employeeId);
        }

        public static void AddUser(User user)
        {
            var validUsers = _users
                .Where(u => u.EmployeeID != null &&
                            u.EmployeeID.StartsWith("E") &&
                            int.TryParse(u.EmployeeID.Substring(1), out _))
                .ToList();

            int lastIdNumber = 0;
            if (validUsers.Any())
            {
                lastIdNumber = validUsers.Select(u => int.Parse(u.EmployeeID.Substring(1))).Max();
            }

            user.EmployeeID = "E" + (lastIdNumber + 1).ToString("D3");
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

        // ==========================================
        // --- وظائف التعامل مع المستفيدين ---
        // ==========================================
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

        // ==========================================
        // --- وظائف التعامل مع المخزون ---
        // ==========================================
        public static List<InventoryItem> GetAllInventoryItems()
        {
            return _inventoryItems;
        }

        public static List<InventoryItem> GetInventoryItems()
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

        // ==========================================
        // --- دوال حركة المخزون (Inventory Movements) ---
        // ==========================================
        public static List<InventoryMovement> GetInventoryMovements()
        {
            return _inventoryMovements;
        }

        public static void RecordMovement(InventoryMovement movement)
        {
            var item = _inventoryItems.FirstOrDefault(i => i.ItemID == movement.ItemID);

            if (item != null)
            {
                movement.QuantityBefore = item.CurrentQuantity;

                if (movement.MovementType == MovementType.وارد)
                {
                    item.CurrentQuantity += movement.Quantity;
                }
                else if (movement.MovementType == MovementType.صادر)
                {
                    item.CurrentQuantity -= movement.Quantity;
                }
                else if (movement.MovementType == MovementType.تسوية)
                {
                    item.CurrentQuantity += movement.Quantity;
                }

                movement.QuantityAfter = item.CurrentQuantity;
                _inventoryMovements.Add(movement);
            }
        }

        // ==========================================
        // --- دوال عمليات التوزيع (Distributions) ---
        // ==========================================
        public static List<Distribution> GetAllDistributions()
        {
            return _distributions;
        }

        public static List<Distribution> GetDistributions()
        {
            return _distributions;
        }

        public static void AddDistribution(Distribution distribution)
        {
            _distributions.Add(distribution); // فقط أضف، لا تخصم
        }
        public static void AddDistributionDetail(DistributionDetail detail)
        {
            _distributionDetails.Add(detail);
        }

        // ==========================================
        // --- دوال المتبرعين (Donors) ---
        // ==========================================
        public static List<Donor> GetDonors() => _donors;

        public static void AddDonor(Donor donor) => _donors.Add(donor);

        public static void UpdateDonor(Donor donor)
        {
            var existing = _donors.FirstOrDefault(d => d.DonorID == donor.DonorID);
            if (existing != null)
            {
                existing.FullName = donor.FullName;
                existing.Phone = donor.Phone;
                existing.Email = donor.Email;
                existing.DonorType = donor.DonorType;
                existing.Address = donor.Address;
                existing.Notes = donor.Notes;
            }
        }

        public static void DeleteDonor(string id)
        {
            var donor = _donors.FirstOrDefault(d => d.DonorID == id);
            if (donor != null) _donors.Remove(donor);
        }

        // ==========================================
        // --- دوال التبرعات (Donations) ---
        // ==========================================
        public static List<Donation> GetDonations() => _donations;

        public static void AddDonation(Donation donation) => _donations.Add(donation);

        public static void UpdateDonation(Donation donation)
        {
            var existing = _donations.FirstOrDefault(d => d.DonationID == donation.DonationID);
            if (existing != null)
            {
                existing.DonorID = donation.DonorID;
                existing.DonationType = donation.DonationType;
                existing.ItemID = donation.ItemID;
                existing.Quantity = donation.Quantity;
                existing.Amount = donation.Amount;
                existing.Notes = donation.Notes;
            }
        }

        public static void DeleteDonation(string id)
        {
            var donation = _donations.FirstOrDefault(d => d.DonationID == id);
            if (donation != null) _donations.Remove(donation);
        }

        // دالة لحساب الرصيد الحالي للصندوق
        public static double GetTreasuryBalance()
        {
            double totalIn = _financialTransactions.Where(t => t.Type == TransactionType.وارد).Sum(t => t.Amount);
            double totalOut = _financialTransactions.Where(t => t.Type == TransactionType.صادر).Sum(t => t.Amount);
            return totalIn - totalOut;
        }

        // دالة لتسجيل حركة مالية جديدة
        public static void RecordFinancialTransaction(FinancialTransaction transaction)
        {
            _financialTransactions.Add(transaction);
        }

    }
}
