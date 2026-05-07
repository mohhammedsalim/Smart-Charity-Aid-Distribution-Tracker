using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Models; // المسار الصحيح
using Smart_Charity_and_Aid_Distribution_Tracker.Services; // المسار الصحيح
using System;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmDashBoard : Form
    {
        private User _currentUser;
        private bool isLoggingOut = false; // علم لتتبع عملية تسجيل الخروج
        private void LoadStatistics()
        {
            try
            {
                // احصل على عدد المستفيدين من الخدمة
                int beneficiaryCount = DataService.GetBeneficiaries().Count;
                lblNumberBeneficiaries.Text = beneficiaryCount.ToString();

                int inventoryItemCount = DataService.GetAllInventoryItems().Count;
                lblNumberInventory.Text = inventoryItemCount.ToString();

                // TODO: تحديث بقية الإحصائيات (سيتم إضافتها لاحقاً)
                lblNumberDonations.Text = "0"; // قيمة مؤقتة
                lblNumberDisbursement.Text = "0"; // قيمة مؤقتة

                // مرات تنضاف
                //int distributionCount = DataService.GetAllDistributions().Count;
                //lblDistributionsCount.Text = distributionCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل الإحصائيات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // --- 1. المُنشئ (Constructor) ---
        // تم تعديله ليستقبل كائن المستخدم
        public frmDashBoard(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        // --- 2. أحداث الفورم ---

        private void frmDashBoard_Load(object sender, EventArgs e)
        {
            // عرض اسم المستخدم الحالي في الشريط السفلي
            if (_currentUser != null)
            {
                lblUserName.Text = _currentUser.FullName;
            }

            // --- تطبيق الصلاحيات ---
            // احصل على المستخدم الحالي من مدير الجلسة
            var currentUser = SessionManager.GetCurrentUser();

            // تحقق مما إذا كان المستخدم موجوداً وصلاحيته هي "مدير"
            if (currentUser != null && currentUser.Role == UserRole.Admin)
            {
                // إذا كان مديراً، أظهر زر إدارة المستخدمين
                btnUsers.Visible = true;
            }
            else
            {
                // إذا لم يكن مديراً، تأكد من أن الزر مخفي
                btnUsers.Visible = false;
            }

            // يمكنك أيضاً عرض اسم المستخدم الحالي في مكان ما في لوحة التحكم
            // على سبيل المثال، إذا كان لديك Label اسمه lblWelcomeUser
            // lblWelcomeUser.Text = $"مرحباً، {currentUser?.FullName}";

        }


        private void frmDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            // هذا الكود يعمل فقط عند الضغط على زر X الأحمر
            if (!isLoggingOut)
            {
                var result = MessageBox.Show("هل أنت متأكد أنك تريد الخروج من النظام؟", "تأكيد الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // إلغاء عملية الإغلاق
                }
            }
        }

        private void frmDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // هذا الكود يعمل بعد إغلاق الشاشة
            if (isLoggingOut)
            {
                // إذا كنا نسجل الخروج، أظهر شاشة تسجيل الدخول
                var loginForm = Application.OpenForms.OfType<frmLogin>().FirstOrDefault();
                if (loginForm != null)
                {
                    loginForm.Show();
                }
            }
            else
            {
                // إذا أغلقنا من زر X، قم بإنهاء التطبيق بالكامل
                Application.Exit();
            }
        }

        // --- 3. أحداث الأزرار ---

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("هل أنت متأكد أنك تريد تسجيل الخروج؟", "تأكيد تسجيل الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                isLoggingOut = true; // ارفع العلم
                UserService.Logout(); // قم بتسجيل خروج المستخدم من الخدمة
                this.Close(); // أغلق لوحة التحكم
            }
        }

        private void btnBeneficiaries_Click(object sender, EventArgs e)
        {
            // إنشاء نسخة جديدة من شاشة المستفيدين
            frmBeneficiarie beneficiariesForm = new frmBeneficiarie();

            // إظهار شاشة المستفيدين
            beneficiariesForm.Show();

            // إخفاء لوحة التحكم الحالية
            this.Hide();
        }

        private void frmDashBoard_Activated(object sender, EventArgs e)
        {
            // --- تطبيق الصلاحيات ---
            var currentUser = SessionManager.GetCurrentUser();

            // تحقق مما إذا كان المستخدم موجوداً وصلاحيته هي "مدير"
            if (currentUser != null && currentUser.Role == UserRole.Admin)
            {
                // إذا كان مديراً، أظهر زر إدارة المستخدمين
                btnUsers.Visible = true;
            }
            else
            {
                // إذا لم يكن مديراً، تأكد من أن الزر مخفي
                btnUsers.Visible = false;
            }
            // استدعاء وظيفة تحميل الإحصائيات
            LoadStatistics();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory inventoryForm = new frmInventory();
            inventoryForm.Show();
            this.Hide();
        }

        private void btnDisbursement_Click(object sender, EventArgs e)
        {
            // إنشاء نسخة جديدة من شاشة التوزيع
            frmDistribution distributionForm = new frmDistribution();

            // إظهار شاشة التوزيع
            distributionForm.Show();

            // إخفاء لوحة التحكم الحالية
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            // إنشاء نسخة جديدة من شاشة التقارير
            frmDistributionReport reportForm = new frmDistributionReport();

            // إظهار شاشة التقارير
            reportForm.Show();

            // إخفاء لوحة التحكم الحالية
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUsers usersForm = new frmUsers();
            usersForm.Show();
            this.Hide();
    }

        private void btnDonors_Click(object sender, EventArgs e)
        {
            frmDonors donorsForm = new frmDonors();
            donorsForm.Show();
            this.Hide(); // إخفاء لوحة التحكم مؤقتاً
        }

        private void btnDonations_Click(object sender, EventArgs e)
        {
            frmDonations donationsForm = new frmDonations();
            donationsForm.Show();
            this.Hide();
        }

    }
}


