using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmDistribution : Form
    {
        public frmDistribution()
        {
            InitializeComponent();
            FontManager.ApplyFontToControls(this);

            // ربط الأحداث
            this.Load += FrmDistribution_Load;
            this.btnAddItemToCart.Click += BtnAddItemToCart_Click;
            this.btnRemoveFromCart.Click += BtnRemoveFromCart_Click;
            this.btnClearCart.Click += BtnClearCart_Click;
            this.btnSave.Click += BtnSave_Click;

            // أحداث تغيير نوع الصرف
            this.rbInKind.CheckedChanged += RbType_CheckedChanged;
            this.rbCash.CheckedChanged += RbType_CheckedChanged;
        }

        private void FrmDistribution_Load(object sender, EventArgs e)
        {
            SetupComboBoxes();
            ResetForm();
        }

        private void SetupComboBoxes()
        {
            // 1. تحميل المستفيدين النشطين فقط
            var activeBeneficiaries = DataService.GetBeneficiaries().Where(b => b.IsActive == true).ToList();
            cmbBeneficiary.DataSource = activeBeneficiaries;
            cmbBeneficiary.DisplayMember = "FullName";
            cmbBeneficiary.ValueMember = "BeneficiaryID";
            cmbBeneficiary.SelectedIndex = -1;

            // --- الترتيب الصحيح لتفعيل البحث ---
            cmbBeneficiary.DropDownStyle = ComboBoxStyle.DropDown;
            cmbBeneficiary.AutoCompleteSource = AutoCompleteSource.ListItems; // 1. تحديد المصدر أولاً
            cmbBeneficiary.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // 2. تفعيل البحث ثانياً
            cmbBeneficiary.MaxDropDownItems = 5;
            cmbBeneficiary.IntegralHeight = false;

            // 2. تحميل الأصناف النشطة فقط
            var activeItems = DataService.GetAllInventoryItems().Where(i => i.IsActive == true).ToList();
            cmbItem.DataSource = activeItems;
            cmbItem.DisplayMember = "ItemName";
            cmbItem.ValueMember = "ItemID";
            cmbItem.SelectedIndex = -1;

            // --- الترتيب الصحيح لتفعيل البحث ---
            cmbItem.DropDownStyle = ComboBoxStyle.DropDown;
            cmbItem.AutoCompleteSource = AutoCompleteSource.ListItems; // 1. تحديد المصدر أولاً
            cmbItem.AutoCompleteMode = AutoCompleteMode.SuggestAppend; // 2. تفعيل البحث ثانياً
            cmbItem.MaxDropDownItems = 5;
            cmbItem.IntegralHeight = false;
        }

        // --- منطق التبديل بين عيني ونقدي ---
        private void RbType_CheckedChanged(object sender, EventArgs e)
        {
            bool isInKind = rbInKind.Checked;

            // إظهار/إخفاء عناصر الصرف العيني
            label3.Visible = isInKind; // كلمة الصنف
            cmbItem.Visible = isInKind;
            label4.Visible = isInKind; // كلمة الكمية
            numQuantity.Visible = isInKind; // استخدام numQuantity بدلاً من txtQuantity
            btnAddItemToCart.Visible = isInKind;
            btnRemoveFromCart.Visible = isInKind;
            btnClearCart.Visible = isInKind;
            pnlView.Visible = isInKind; // جدول السلة

            // إظهار/إخفاء عناصر الصرف النقدي
            lblAmount.Visible = !isInKind;
            txtAmount.Visible = !isInKind;
        }

        // --- منطق السلة (للصرف العيني) ---
        private void BtnAddItemToCart_Click(object sender, EventArgs e)
        {
            if (cmbItem.SelectedItem == null)
            {
                new frmAlert("الرجاء اختيار صنف أولاً.").ShowDialog();
                return;
            }

            double quantity = Convert.ToDouble(numQuantity.Value);

            if (quantity <= 0)
            {
                new frmAlert("الرجاء إدخال كمية أكبر من الصفر.").ShowDialog();
                return;
            }

            var selectedItem = (InventoryItem)cmbItem.SelectedItem;

            // التحقق من توفر الكمية في المخزون
            if (selectedItem.CurrentQuantity < quantity)
            {
                new frmAlert($"الكمية المطلوبة غير متوفرة. المتاح في المخزون: {selectedItem.CurrentQuantity} {selectedItem.Unit}").ShowDialog();
                return;
            }

            // التحقق مما إذا كان الصنف موجوداً مسبقاً في السلة
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["colItemID"].Value.ToString() == selectedItem.ItemID)
                {
                    double currentCartQty = Convert.ToDouble(row.Cells["colQuantity"].Value);
                    double newTotalQty = currentCartQty + quantity;

                    if (selectedItem.CurrentQuantity < newTotalQty)
                    {
                        new frmAlert($"لا يمكنك إضافة المزيد. إجمالي المطلوب يتجاوز المتاح في المخزون.").ShowDialog();
                        return;
                    }

                    row.Cells["colQuantity"].Value = newTotalQty;
                    numQuantity.Value = 1; // تصفير العداد بعد الإضافة
                    return;
                }
            }

            // إضافة صف جديد للسلة
            dgvCart.Rows.Add(selectedItem.ItemID, selectedItem.ItemName, quantity, selectedItem.Unit);
            numQuantity.Value = 1; // تصفير العداد
        }

        private void BtnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow != null)
            {
                dgvCart.Rows.Remove(dgvCart.CurrentRow);
            }
            else
            {
                new frmAlert("الرجاء تحديد صنف من السلة لحذفه.").ShowDialog();
            }
        }

        private void BtnClearCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 0)
            {
                dgvCart.Rows.Clear();
            }
        }

        // --- منطق الحفظ ---
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (cmbBeneficiary.SelectedItem == null)
            {
                new frmAlert("الرجاء اختيار المستفيد.").ShowDialog();
                return;
            }

            var currentUser = SessionManager.GetCurrentUser();
            string performedBy = currentUser != null ? currentUser.EmployeeID : "System";

            // إنشاء كائن التوزيع الأساسي
            var distribution = new Distribution
            {
                DistributionID = "DIST" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                BeneficiaryID = cmbBeneficiary.SelectedValue.ToString(),
                DistributionDate = DateTime.Now,
                PerformedBy = performedBy,
                Status = DistributionStatus.منفذة,
                Notes = txtNotes.Text.Trim()
            };

            if (rbCash.Checked)
            {
                // --- حفظ صرف نقدي ---
                if (!double.TryParse(txtAmount.Text, out double amount) || amount <= 0)
                {
                    new frmAlert("الرجاء إدخال مبلغ نقدي صحيح وأكبر من الصفر.").ShowDialog();
                    return;
                }

                // 1. التحقق من توفر رصيد كافٍ في الصندوق قبل الصرف
                double currentBalance = DataService.GetTreasuryBalance();
                if (currentBalance < amount)
                {
                    new frmAlert($"عفواً، الرصيد الحالي في الصندوق ({currentBalance}) لا يكفي لإتمام عملية الصرف.").ShowDialog();
                    return;
                }

                distribution.Type = DonationType.نقدي;
                distribution.Amount = amount;

                // 2. حفظ عملية التوزيع
                DataService.AddDistribution(distribution);

                // 3. تسجيل الحركة المالية (صادر) لخصم المبلغ من الصندوق
                var finTransaction = new FinancialTransaction
                {
                    TransactionID = "TRX" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                    Type = TransactionType.صادر,
                    Amount = amount,
                    TransactionDate = DateTime.Now,
                    ReferenceID = distribution.DistributionID,
                    PerformedBy = performedBy,
                    Notes = $"صرف مساعدة نقدية للمستفيد: {cmbBeneficiary.Text}"
                };
                DataService.RecordFinancialTransaction(finTransaction);

                new frmAlert("تم حفظ عملية الصرف النقدي وخصم المبلغ من الصندوق بنجاح!").ShowDialog();
            }

            else
            {
                // --- حفظ صرف عيني ---
                if (dgvCart.Rows.Count == 0)
                {
                    new frmAlert("السلة فارغة. الرجاء إضافة أصناف أولاً.").ShowDialog();
                    return;
                }

                distribution.Type = DonationType.عيني;
                distribution.Amount = 0;

                // حفظ التوزيع
                DataService.AddDistribution(distribution);

                // حفظ التفاصيل وخصم المخزون
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    string itemId = row.Cells["colItemID"].Value.ToString();
                    double qty = Convert.ToDouble(row.Cells["colQuantity"].Value);

                    var detail = new DistributionDetail
                    {
                        DetailID = Guid.NewGuid().ToString(),
                        DistributionID = distribution.DistributionID,
                        ItemID = itemId,
                        Quantity = qty
                    };
                    DataService.AddDistributionDetail(detail);

                    var movement = new InventoryMovement
                    {
                        MovementID = "M" + Guid.NewGuid().ToString().Substring(0, 8),
                        ItemID = itemId,
                        MovementType = MovementType.صادر,
                        Quantity = qty,
                        MovementDate = DateTime.Now,
                        ReferenceID = distribution.DistributionID,
                        PerformedBy = performedBy,
                        Notes = $"صرف مساعدات للمستفيد: {cmbBeneficiary.Text}"
                    };

                    // تسجيل حركة المخزون (صادر)
                    DataService.RecordMovement(
                        movement
                    );
                }

                new frmAlert("تم حفظ عملية الصرف العيني وخصم المخزون بنجاح!").ShowDialog();
            }

            ResetForm();
        }

        private void ResetForm()
        {
            cmbBeneficiary.SelectedIndex = -1;
            cmbItem.SelectedIndex = -1;
            numQuantity.Value = 1;
            txtAmount.Clear();
            txtNotes.Clear();
            dgvCart.Rows.Clear();
            rbInKind.Checked = true; // العودة للوضع الافتراضي
        }

    }
}
