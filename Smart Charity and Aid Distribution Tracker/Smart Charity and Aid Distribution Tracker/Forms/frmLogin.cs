using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Web.SessionState;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // ربط حدث النقر على زر الدخول يدوياً
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. الحصول على المدخلات من المستخدم
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // 2. التحقق من أن الحقول ليست فارغة
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                new frmAlert("الرجاء إدخال اسم المستخدم وكلمة المرور.").ShowDialog();
                return; // أوقف التنفيذ
            }

            // 3. محاولة تسجيل الدخول عبر DataService
            var loggedInUser = DataService.Login(username, password);

            // 4. التحقق من نتيجة تسجيل الدخول
            if (loggedInUser != null)
            {
                // --- نجح تسجيل الدخول ---

                // أ. تخزين المستخدم الحالي في مكان عام يمكن الوصول إليه
                //    (هذه هي أهم خطوة لتطبيق الصلاحيات لاحقاً)
                SessionManager.SetCurrentUser(loggedInUser);

                // ب. إظهار رسالة ترحيب (اختياري ولكن لطيف)
                new frmAlert($"مرحباً بك، {loggedInUser.FullName}").ShowDialog();

                // ج. إخفاء شاشة تسجيل الدخول الحالية
                this.Hide();

                // د. إنشاء وإظهار لوحة التحكم الرئيسية
                frmDashBoard dashboard = new frmDashBoard(loggedInUser);
                dashboard.Show();
            }
            else
            {
                // --- فشل تسجيل الدخول ---
                new frmAlert("اسم المستخدم أو كلمة المرور غير صحيحة.").ShowDialog();
                txtPassword.Clear(); // مسح حقل كلمة المرور فقط
                txtUsername.Focus(); // إعادة التركيز على حقل اسم المستخدم
            }
        }
    }
}
