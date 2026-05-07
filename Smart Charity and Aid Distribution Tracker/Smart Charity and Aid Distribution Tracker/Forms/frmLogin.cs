using Smart_Charity_and_Aid_Distribution_Tracker.Forms;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // --- 1. أحداث الأزرار ---

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("الرجاء إدخال اسم المستخدم.", "حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("الرجاء إدخال كلمة المرور.", "حقل فارغ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            var user = UserService.Login(username, password);

            // في ملف frmLogin.cs، داخل btnLogin_Click

            if (user != null)
            {
                // --- نجاح! ---
                MessageBox.Show($"مرحباً بك، {user.FullName}", "تم تسجيل الدخول بنجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // افتح لوحة التحكم الرئيسية ومرر لها المستخدم الحالي
                frmDashBoard dashboardForm = new frmDashBoard(user);
                dashboardForm.Show();

                // قم بإخفاء شاشة تسجيل الدخول الحالية
                this.Hide();
            }
            else
            {
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة.", "فشل تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت متأكد أنك تريد الخروج من النظام؟", "تأكيد الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // --- 2. تحسينات تجربة المستخدم ---

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void tsShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (tsShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }
    }
}
