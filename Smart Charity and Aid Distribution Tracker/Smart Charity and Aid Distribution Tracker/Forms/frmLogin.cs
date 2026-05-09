using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            FontManager.ApplyFontToControls(this);
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
                SessionManager.SetCurrentUser(loggedInUser);

                // ب. إظهار رسالة ترحيب
                new frmAlert($"مرحباً بك، {loggedInUser.FullName}").ShowDialog();

                // ج. إخفاء شاشة تسجيل الدخول الحالية
                this.Hide();

                // د. إنشاء وإظهار النافذة الرئيسية (frmMain) بدلاً من لوحة التحكم
                frmMain mainForm = new frmMain(loggedInUser);
                mainForm.Show();
            }
            else
            {
                // --- فشل تسجيل الدخول ---
                new frmAlert("اسم المستخدم أو كلمة المرور غير صحيحة.").ShowDialog();
                txtPassword.Clear(); // مسح حقل كلمة المرور فقط
                txtUsername.Focus(); // إعادة التركيز على حقل اسم المستخدم
            }
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                // إظهار كلمة المرور
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                // إخفاء كلمة المرور
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '●';
            }
        }
    }
}
