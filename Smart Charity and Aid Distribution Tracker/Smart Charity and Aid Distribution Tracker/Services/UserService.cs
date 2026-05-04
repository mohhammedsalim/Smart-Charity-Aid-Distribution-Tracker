using Smart_Charity_and_Aid_Distribution_Tracker.Data;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Services
{
    /// <summary>
    /// توفر هذه الفئة كل العمليات المتعلقة بالمستخدمين.
    /// </summary>
    public static class UserService
    {
        /// <summary>
        /// يتحقق من بيانات المستخدم ويقوم بتسجيل دخوله.
        /// </summary>
        /// <param name="username">اسم المستخدم المدخل.</param>
        /// <param name="password">كلمة المرور المدخلة.</param>
        /// <returns>كائن المستخدم في حال نجاح الدخول، أو null في حال الفشل.</returns>
        public static User Login(string username, string password)
        {
            // 1. تحقق من أن المدخلات ليست فارغة
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            // 2. ابحث عن المستخدم في الـ Dictionary
            // .Values يحول الـ Dictionary إلى قائمة من المستخدمين للبحث فيها
            var user = DataStore.Users.Values.FirstOrDefault(u => u.UserName.Equals(username, StringComparison.OrdinalIgnoreCase));

            // 3. إذا وجدنا المستخدم، تحقق من كلمة المرور والحالة
            if (user != null && user.Password == password && user.IsActive)
            {
                // --- نجاح! ---
                // قم بتحديث تاريخ آخر تسجيل دخول
                user.LastLogin = DateTime.Now;

                // قم بتخزين المستخدم الحالي في جلسة العمل
                DataStore.CurrentUser = user;

                return user;
            }

            // --- فشل! ---
            // إذا لم تنجح أي من الشروط السابقة
            return null;
        }

        /// <summary>
        /// يقوم بتسجيل خروج المستخدم الحالي.
        /// </summary>
        public static void Logout()
        {
            DataStore.CurrentUser = null;
        }

        /// <summary>
        /// يتحقق مما إذا كان هناك مستخدم مسجل دخوله حالياً.
        /// </summary>
        public static bool IsUserLoggedIn()
        {
            return DataStore.CurrentUser != null;
        }

        /// <summary>
        /// يتحقق مما إذا كان المستخدم الحالي هو مدير.
        /// </summary>
        public static bool IsCurrentUserAdmin()
        {
            // تأكد من وجود مستخدم أولاً، ثم تحقق من صلاحيته
            return DataStore.CurrentUser?.Role == UserRole.Admin;
        }
    }
}
