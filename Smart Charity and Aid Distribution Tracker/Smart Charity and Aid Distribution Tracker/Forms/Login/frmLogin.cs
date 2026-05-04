using Smart_Charity_and_Aid_Distribution_Tracker.Forms.Login;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Smart_Charity_and_Aid_Distribution_Tracker.Forms.Login.frmAlert;

namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    public partial class frmLogin : Form
    {
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //user functions
        private void ShakeForm()
        {
            var original = this.Location;
            var rnd = new Random();
            const int shake_amplitude = 10;
            for (int i = 0; i < 10; i++)
            {
                this.Location = new Point(original.X + rnd.Next(-shake_amplitude, shake_amplitude),
                    original.Y + rnd.Next(-shake_amplitude, shake_amplitude));
                System.Threading.Thread.Sleep(20);
            }
            this.Location = original;
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Text = "";
            txtUserName.Focus();
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

        private void chbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chbShowPassword.Checked ? '\0' : '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                frmAlert.Show("الرجاء إدخال اسم المستخدم.", AlertType.Error);
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                frmAlert.Show("الرجاء إدخال كلمة المرور.", AlertType.Error);
                txtPassword.Focus(); 
                return;
            }

            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            var user = UserService.Login(username, password);


            if (user != null)
            {
                frmAlert.Show($"مرحباً بك، {user.FullName}", AlertType.Success);

                frmDashBoard dashboardForm = new frmDashBoard(user.FullName);
                dashboardForm.Show();
                txtPassword.Clear();
                this.Hide();
            }
            else
            {
                frmAlert.Show("اسم المستخدم أو كلمة المرور غير صحيحة.", AlertType.Error);

                txtPassword.Clear();

                txtUserName.SelectAll();
                txtUserName.Focus();

                ShakeForm();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}