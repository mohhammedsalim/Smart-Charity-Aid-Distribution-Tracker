using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmDistribution : Form
    {
        // قائمة مؤقتة لتخزين الأصناف المضافة إلى السلة
        private List<DistributionDetail> _cartItems = new List<DistributionDetail>();

        public frmDistribution()
        {
            InitializeComponent();
        }

        // --- 1. أحداث تحميل وإغلاق الفورم ---

        private void frmDistribution_Load(object sender, EventArgs e)
        {
            // حذف هذا 
            //    // ربط الأحداث يدوياً لضمان عملها
            //    this.btnBackToDashBoard.Click += new System.EventHandler(this.btnBackToDashBoard_Click);
            //    this.btnAddItemToCart.Click += new System.EventHandler(this.btnAddItemToCart_Click);
            //    this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //    this.dgvCart.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvCart_UserDeletingRow);


            SetupComboBoxes();
            ResetForm();
        }

        private void frmDistribution_FormClosed(object sender, FormClosedEventArgs e)
        {
            // عند إغلاق هذه الشاشة، أظهر لوحة التحكم مرة أخرى
            var dashboard = Application.OpenForms.OfType<frmDashBoard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.Show();
            }
        }

        // --- 2. إعداد وتجهيز الفورم ---

        private void SetupComboBoxes()
        {
            // إعداد قائمة المستفيدين
            cmbBeneficiaries.DataSource = DataService.GetBeneficiaries();
            cmbBeneficiaries.DisplayMember = "FullName";
            cmbBeneficiaries.ValueMember = "BeneficiaryID";
            cmbBeneficiaries.SelectedIndex = -1; // ابدأ بدون تحديد

            // إعداد قائمة أصناف المخزون (فقط الأصناف النشطة والتي كميتها أكبر من صفر)
            cmbInventoryItems.DataSource = DataService.GetAllInventoryItems()
                                                      .Where(item => item.IsActive && item.CurrentQuantity > 0)
                                                      .ToList();
            cmbInventoryItems.DisplayMember = "ItemName";
            cmbInventoryItems.ValueMember = "ItemID";
            cmbInventoryItems.SelectedIndex = -1; // ابدأ بدون تحديد
        }

        private void ResetForm()
        {
            // إعادة تعيين القوائم المنسدلة
            cmbBeneficiaries.SelectedIndex = -1;
            cmbInventoryItems.SelectedIndex = -1;
            numQuantity.Value = 1;

            // تفريغ السلة
            _cartItems.Clear();
            RefreshCartGrid();

            // إعادة تعيين العناوين وحالة الأزرار
            lblPanelTitle.Text = "الخطوة 1: اختر المستفيد";
            pnlAddItem.Enabled = false;
            pnlCart.Enabled = false;
            btnSave.Enabled = false;
        }

        // --- 3. إدارة سلة التوزيع ---

        private void RefreshCartGrid()
        {
            // تحديث جدول السلة بالبيانات من القائمة المؤقتة
            dgvCart.Rows.Clear();

            foreach (var cartItem in _cartItems)
            {
                // ابحث عن معلومات الصنف الكاملة من المخزون
                var inventoryItem = DataService.GetAllInventoryItems().FirstOrDefault(i => i.ItemID == cartItem.ItemID);
                if (inventoryItem != null)
                {
                    dgvCart.Rows.Add(inventoryItem.ItemID, inventoryItem.ItemName, cartItem.Quantity, inventoryItem.Unit);
                }
            }

            // تفعيل زر الحفظ فقط إذا كانت السلة تحتوي على أصناف
            btnSave.Enabled = _cartItems.Any();
        }

        // --- 4. أحداث الأزرار وعناصر التحكم ---

        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbBeneficiaries_SelectedIndexChanged(object sender, EventArgs e)
        {
            // تفعيل لوحة إضافة الأصناف فقط بعد اختيار مستفيد
            bool beneficiarySelected = cmbBeneficiaries.SelectedIndex != -1;
            pnlAddItem.Enabled = beneficiarySelected;
            pnlCart.Enabled = beneficiarySelected;

            if (beneficiarySelected)
            {
                lblPanelTitle.Text = "الخطوة 2: أضف أصنافاً للسلة";
            }
        }

        private void btnAddItemToCart_Click(object sender, EventArgs e)
        {
            // التحقق من اختيار صنف
            if (cmbInventoryItems.SelectedValue == null)
            {
                new frmAlert("يرجى اختيار صنف لإضافته.").ShowDialog();
                return;
            }

            string selectedItemId = cmbInventoryItems.SelectedValue.ToString();
            double quantityToAdd = (double)numQuantity.Value;

            // التحقق من أن الكمية المطلوبة لا تتجاوز الكمية المتاحة في المخزون
            var inventoryItem = DataService.GetAllInventoryItems().FirstOrDefault(i => i.ItemID == selectedItemId);
            if (inventoryItem != null && quantityToAdd > inventoryItem.CurrentQuantity)
            {
                new frmAlert($"الكمية المطلوبة ({quantityToAdd}) أكبر من الكمية المتاحة في المخزون ({inventoryItem.CurrentQuantity}).").ShowDialog();
                return;
            }

            // التحقق مما إذا كان الصنف موجوداً بالفعل في السلة
            var existingCartItem = _cartItems.FirstOrDefault(item => item.ItemID == selectedItemId);
            if (existingCartItem != null)
            {
                // إذا كان موجوداً، قم بزيادة الكمية
                existingCartItem.Quantity += quantityToAdd;
            }
            else
            {
                // إذا لم يكن موجوداً، أضف سطراً جديداً للسلة
                _cartItems.Add(new DistributionDetail
                {
                    ItemID = selectedItemId,
                    Quantity = quantityToAdd
                });
            }

            // تحديث عرض السلة
            RefreshCartGrid();
        }

        private void dgvCart_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            // عند حذف صف من الجدول، قم بحذفه من القائمة المؤقتة أيضاً
            if (e.Row.Cells["colItemID"].Value != null)
            {
                string itemIdToRemove = e.Row.Cells["colItemID"].Value.ToString();
                var itemToRemove = _cartItems.FirstOrDefault(item => item.ItemID == itemIdToRemove);
                if (itemToRemove != null)
                {
                    _cartItems.Remove(itemToRemove);
                }
            }
            // تحديث حالة زر الحفظ بعد الحذف
            btnSave.Enabled = _cartItems.Any();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. جلب المستفيد المحدد من القائمة المنسدلة بدلاً من المتغير المفقود
            var selectedBeneficiary = cmbBeneficiaries.SelectedItem as Beneficiary;

            if (selectedBeneficiary == null)
            {
                new frmAlert("الرجاء تحديد المستفيد أولاً.").ShowDialog();
                return;
            }

            if (_cartItems.Count == 0)
            {
                new frmAlert("سلة التوزيع فارغة. الرجاء إضافة أصناف.").ShowDialog();
                return;
            }

            var currentUser = SessionManager.GetCurrentUser();
            if (currentUser == null)
            {
                new frmAlert("حدث خطأ في جلسة المستخدم. الرجاء تسجيل الدخول مجدداً.").ShowDialog();
                return;
            }

            string newDistId = "D" + DateTime.Now.ToString("yyyyMMddHHmmss");

            var distribution = new Distribution
            {
                DistributionID = newDistId,
                BeneficiaryID = selectedBeneficiary.BeneficiaryID, // استخدام المتغير الجديد
                DistributionDate = DateTime.Now,
                PerformedBy = currentUser.EmployeeID,
                Status = DistributionStatus.Completed,
                Notes = "" // تركناها فارغة لأننا لا نملك txtNotes في التصميم
            };

            DataService.AddDistribution(distribution);

            foreach (var cartItem in _cartItems)
            {
                var detail = new DistributionDetail
                {
                    DetailID = "DD" + Guid.NewGuid().ToString().Substring(0, 8),
                    DistributionID = newDistId,
                    ItemID = cartItem.ItemID,
                    Quantity = cartItem.Quantity
                };
                DataService.AddDistributionDetail(detail);

                var movement = new InventoryMovement
                {
                    MovementID = "M" + Guid.NewGuid().ToString().Substring(0, 8),
                    ItemID = cartItem.ItemID,
                    MovementType = MovementType.Out,
                    Quantity = cartItem.Quantity,
                    MovementDate = DateTime.Now,
                    ReferenceID = newDistId,
                    PerformedBy = currentUser.EmployeeID,
                    Notes = $"صرف مساعدات للمستفيد: {selectedBeneficiary.FullName}" // استخدام المتغير الجديد
                };

                DataService.RecordMovement(movement);
            }

            new frmAlert("تم حفظ عملية التوزيع بنجاح وخصم المواد من المخزون.").ShowDialog();
            ResetForm();
        }


    }
}
