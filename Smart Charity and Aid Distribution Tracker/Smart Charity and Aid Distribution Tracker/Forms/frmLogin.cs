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

<<<<<<< HEAD
            this.Load += new System.EventHandler(this.frmLogin_Load);
=======
            // --- السطر الجديد لحل المشكلة ---
            this.AcceptButton = null; // إلغاء الزر الافتراضي لمنع التداخل

            // ربط حدث النقر على زر الدخول يدوياً
>>>>>>> aa3a8eadc166087f9b57da3d20542af4f602b10d
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // ربط أحداث لوحة المفاتيح
            this.txtUsername.KeyDown += new KeyEventHandler(this.txtUsername_KeyDown);
            this.txtPassword.KeyDown += new KeyEventHandler(this.txtPassword_KeyDown);

            // التركيز التلقائي على حقل اسم المستخدم عند فتح الشاشة
            this.Load += (s, e) => { this.ActiveControl = txtUsername; };
        }


        // حدث الضغط على زر في حقل اسم المستخدم
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // لمنع صوت "الرنين" المزعج للويندوز
                txtPassword.Focus();       // الانتقال التلقائي لحقل كلمة المرور
            }
        }

        // حدث الضغط على زر في حقل كلمة المرور
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();   // تنفيذ عملية تسجيل الدخول كأنك ضغطت على الزر
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // جعل المؤشر يقف تلقائياً في حقل اسم المستخدم عند فتح الشاشة
            this.ActiveControl = txtUsername;
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
                txtPassword.Clear();
                txtUsername.Focus();
                txtUsername.SelectAll();
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

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            // لما يكون محدد على اسم المستخدم ويضغط Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // هذي تمنع صوت "الطن" المزعج

                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    new frmAlert("الرجاء إدخال اسم المستخدم أولاً.").ShowDialog();
                    txtUsername.Focus();
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtPassword.Text))
                    {
                        txtPassword.Focus();
                    }
                    else
                    {
                        btnLogin.PerformClick();
                    }
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // لما يكون محدد على كلمة المرور ويضغط Enter
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // تمنع الصوت المزعج

                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    new frmAlert("الرجاء إدخال كلمة المرور أولاً.").ShowDialog();
                }
                else if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    new frmAlert("الرجاء إدخال اسم المستخدم أولاً.").ShowDialog();
                    txtUsername.Focus();
                }
                else
                {
                    btnLogin.PerformClick(); // ينفذ كود زر الدخول كأنه ضغط عليه بالماوس
                }
            }
        }
    }
}