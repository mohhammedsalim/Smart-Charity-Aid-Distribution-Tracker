using Guna.UI2.WinForms;
using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmMain : Form
    {
        private User _currentUser;
        private bool isLoggingOut = false;

        // الألوان (تم تعديل اللون العادي ليكون شفافاً ليتناسب مع التصميم الجديد)
        private readonly Color ColorActive = Color.FromArgb(39, 174, 96);
        private readonly Color ColorActiveFg = Color.White;
        private readonly Color ColorNormal = Color.Transparent;
        private readonly Color ColorNormalFg = Color.FromArgb(80, 80, 80);

        // --- 1. المُنشئ ---
        public frmMain(User user)
        {
            InitializeComponent();
            _currentUser = user;
            FontManager.ApplyFontToControls(this);
        }

        // --- 2. تلوين الزر النشط وإعادة الباقين للوضع الطبيعي ---
        private void SetActiveButton(Guna2Button activeBtn)
        {
            Guna2Button[] allNavButtons = new Guna2Button[]
            {
                btnHome,
                btnBeneficiaries,
                btnDonations,
                btnInventory,
                btnDisbursement,
                btnDonors,
                btnReports,
                btnUsers
            };

            foreach (var btn in allNavButtons)
            {
                if (btn == null) continue;
                btn.FillColor = ColorNormal;
                btn.ForeColor = ColorNormalFg;
            }

            activeBtn.FillColor = ColorActive;
            activeBtn.ForeColor = ColorActiveFg;
        }

        // --- 3. تحميل نموذج داخل pnlContainer ---
        private void LoadForm(Form form, Guna2Button activeBtn)
        {
            // تلوين الزر النشط
            SetActiveButton(activeBtn);

            // تنظيف المحتوى السابق
            if (pnlContainer.Controls.Count > 0)
            {
                pnlContainer.Controls[0].Dispose();
            }
            pnlContainer.Controls.Clear();

            // تضمين النموذج
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlContainer.Controls.Add(form);
            pnlContainer.Tag = form;
            form.Show();
        }

        // --- 4. تطبيق الصلاحيات ---
        private void ApplyPermissions()
        {
            var currentUser = SessionManager.GetCurrentUser();

            if (currentUser != null && currentUser.Role == UserRole.مدير)
                btnUsers.Visible = true;
            else
                btnUsers.Visible = false;
        }

        // --- 5. أحداث الفورم ---
        private void frmMain_Load(object sender, EventArgs e)
        {
            if (_currentUser != null)
                lblUserName.Text = _currentUser.FullName;

            ApplyPermissions();

            // فتح شاشة الإحصائيات كشاشة افتراضية
            LoadForm(new frmDashBoard(), btnHome);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isLoggingOut)
            {
                var result = MessageBox.Show(
                    "هل أنت متأكد أنك تريد الخروج من النظام؟",
                    "تأكيد الخروج",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLoggingOut)
            {
                var loginForm = Application.OpenForms.OfType<frmLogin>().FirstOrDefault();
                if (loginForm != null)
                    loginForm.Show();
            }
            else
            {
                try
                {
                    Application.Exit();
                }
                catch (System.NullReferenceException ex)
                {
                    MessageBox.Show("حدث خطأ أثناء إغلاق التطبيق: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء إغلاق التطبيق: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- 6. أحداث أزرار التنقل ---
        private void btnHome_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDashBoard(), btnHome);
        }

        private void btnBeneficiaries_Click(object sender, EventArgs e)
        {
            LoadForm(new frmBeneficiarie(), btnBeneficiaries);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            LoadForm(new frmInventory(), btnInventory);
        }

        private void btnDisbursement_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDistribution(), btnDisbursement);
        }

        private void btnDonations_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDonations(), btnDonations);
        }

        private void btnDonors_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDonors(), btnDonors);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            LoadForm(new frmUsers(), btnUsers);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            LoadForm(new frmDistributionReport(), btnReports);
        }

        // --- 7. زر تسجيل الخروج ---
        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "هل أنت متأكد أنك تريد تسجيل الخروج؟",
                "تأكيد تسجيل الخروج",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                isLoggingOut = true;
                UserService.Logout();
                this.Close();
            }
        }
    }
}
