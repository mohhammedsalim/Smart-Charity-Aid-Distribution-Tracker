using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // ربط حدث تغيير حالة زر إظهار كلمة المرور
            chbShowPassword.CheckedChanged += ChbShowPassword_CheckedChanged;
        }

        private void ChbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            // إذا كان الزر مفعل، نعرض كلمة المرور، وإلا نخفيها
            if (chbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // التحقق من أن الحقول ليست فارغة قبل الدخول
            if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("الرجاء إدخال اسم المستخدم وكلمة المرور", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // أخذ اسم المستخدم من مربع النص (بالاسم الصحيح txtUserName)
            string loggedInUser = txtUserName.Text;

            // فتح الشاشة الرئيسية وتمرير اسم المستخدم لها
            frmDashBoard dashboardForm = new frmDashBoard(loggedInUser);
            dashboardForm.Show();

            // إخفاء شاشة تسجيل الدخول
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
