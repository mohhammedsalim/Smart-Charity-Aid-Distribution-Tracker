using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
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
        private List<DistributionDetail> _cartItems = new List<DistributionDetail>();
        private bool _isLoading = false;

        public frmDistribution()
        {
            InitializeComponent();
            FontManager.ApplyFontToControls(this);
        }

        private void frmDistribution_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                ResetForm();
                LoadComboBoxes();
            }));
        }

        // تحميل البيانات في القوائم فقط (بدون مسح)
        private void LoadComboBoxes()
        {
            _isLoading = true;

            cmbBeneficiaries.DataSource = null;
            cmbBeneficiaries.Items.Clear();
            cmbBeneficiaries.DataSource = DataService.GetBeneficiaries();
            cmbBeneficiaries.DisplayMember = "FullName";
            cmbBeneficiaries.ValueMember = "BeneficiaryID";
            cmbBeneficiaries.SelectedIndex = -1;

            var activeItems = DataService.GetAllInventoryItems()
                                         .Where(item => item.IsActive && item.CurrentQuantity > 0)
                                         .ToList();
            cmbInventoryItems.DataSource = null;
            cmbInventoryItems.Items.Clear();
            cmbInventoryItems.DataSource = activeItems;
            cmbInventoryItems.DisplayMember = "ItemName";
            cmbInventoryItems.ValueMember = "ItemID";
            cmbInventoryItems.SelectedIndex = -1;

            _isLoading = false;
        }

        private void ResetForm()
        {
            _isLoading = true;

            // مسح القوائم أولاً
            cmbBeneficiaries.DataSource = null;
            cmbBeneficiaries.Items.Clear();
            cmbInventoryItems.DataSource = null;
            cmbInventoryItems.Items.Clear();

            numQuantity.Value = 1;

            _cartItems.Clear();
            RefreshCartGrid();

            lblPanelTitle.Text = "الخطوة 1: اختر المستفيد";
            pnlAddItem.Enabled = false;
            pnlCart.Enabled = true;  // السلة دائماً مفعلة للعرض
            btnSave.Enabled = false;

            _isLoading = false;
        }

        private void RefreshCartGrid()
        {
            dgvCart.Rows.Clear();

            foreach (var cartItem in _cartItems)
            {
                var inventoryItem = DataService.GetAllInventoryItems()
                                               .FirstOrDefault(i => i.ItemID == cartItem.ItemID);
                if (inventoryItem != null)
                {
                    dgvCart.Rows.Add(inventoryItem.ItemID, inventoryItem.ItemName,
                                     cartItem.Quantity, inventoryItem.Unit);
                }
            }

            btnSave.Enabled = _cartItems.Any();
        }

        private void cmbBeneficiaries_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_isLoading) return;

            bool beneficiarySelected = cmbBeneficiaries.SelectedIndex != -1;
            pnlAddItem.Enabled = beneficiarySelected;
            pnlCart.Enabled = beneficiarySelected;

            if (beneficiarySelected)
                lblPanelTitle.Text = "الخطوة 2: أضف أصنافاً للسلة";
        }

        private void btnAddItemToCart_Click(object sender, EventArgs e)
        {
            if (cmbInventoryItems.SelectedValue == null)
            {
                new frmAlert("يرجى اختيار صنف لإضافته.").ShowDialog();
                return;
            }

            string selectedItemId = cmbInventoryItems.SelectedValue.ToString();
            double quantityToAdd = (double)numQuantity.Value;

            var inventoryItem = DataService.GetAllInventoryItems()
                                           .FirstOrDefault(i => i.ItemID == selectedItemId);
            if (inventoryItem != null && quantityToAdd > inventoryItem.CurrentQuantity)
            {
                new frmAlert($"الكمية المطلوبة ({quantityToAdd}) أكبر من الكمية المتاحة ({inventoryItem.CurrentQuantity}).").ShowDialog();
                return;
            }

            var existingCartItem = _cartItems.FirstOrDefault(item => item.ItemID == selectedItemId);
            if (existingCartItem != null)
            {
                existingCartItem.Quantity += quantityToAdd;
            }
            else
            {
                _cartItems.Add(new DistributionDetail
                {
                    ItemID = selectedItemId,
                    Quantity = quantityToAdd
                });
            }

            RefreshCartGrid();
        }

        private void dgvCart_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.Cells["colItemID"].Value != null)
            {
                string itemIdToRemove = e.Row.Cells["colItemID"].Value.ToString();
                var itemToRemove = _cartItems.FirstOrDefault(item => item.ItemID == itemIdToRemove);
                if (itemToRemove != null)
                    _cartItems.Remove(itemToRemove);
            }
            btnSave.Enabled = _cartItems.Any();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
                BeneficiaryID = selectedBeneficiary.BeneficiaryID,
                DistributionDate = DateTime.Now,
                PerformedBy = currentUser.EmployeeID,
                Status = DistributionStatus.Completed,
                Notes = ""
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
                    Notes = $"صرف مساعدات للمستفيد: {selectedBeneficiary.FullName}"
                };
                DataService.RecordMovement(movement);
            }

            new frmAlert("تم حفظ عملية التوزيع بنجاح وخصم المواد من المخزون.").ShowDialog();

            ResetForm();
            LoadComboBoxes();
        }
    }
}