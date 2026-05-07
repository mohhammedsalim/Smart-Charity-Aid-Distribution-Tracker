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
    public partial class frmInventory : Form
    {
        // متغير لتخزين وضع اللوحة الحالية (عرض، إضافة، تعديل)
        private enum PanelMode { View, Add, Edit }
        private PanelMode _currentMode;

        // متغير لتخزين عنصر المخزون المحدد حالياً
        private InventoryItem _selectedItem;

        public frmInventory()
        {
            InitializeComponent();
        }

        // --- 1. أحداث تحميل وإغلاق الفورم ---

        private void frmInventory_Load(object sender, EventArgs e)
        {
            // إعداد عناصر التحكم عند التحميل لأول مرة
            SetupComboBoxes();
            LoadInventoryItems();
            SetPanelMode(PanelMode.View); // ابدأ بوضع العرض
        }

        private void frmInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            // عند إغلاق هذه الشاشة، أظهر لوحة التحكم مرة أخرى
            var dashboard = Application.OpenForms.OfType<frmDashBoard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.Show();
            }
        }

        // --- 2. التحكم في اللوحة الذكية (Smart Panel) ---

        private void SetPanelMode(PanelMode mode)
        {
            _currentMode = mode;

            // قوائم بعناصر التحكم لسهولة الإدارة
            var inputControls = new List<Control> { txtItemName, cmbCategory, txtUnit, numCurrentQuantity, numMinimumQuantity, txtDescription, chkIsActive };

            // في وضع العرض، كل الحقول للقراءة فقط. في الأوضاع الأخرى، يمكن التعديل عليها
            bool isViewMode = (mode == PanelMode.View);
            foreach (var control in inputControls) control.Enabled = !isViewMode;
            txtItemID.Enabled = false; // رقم الصنف دائماً للقراءة فقط

            // التحكم في الأزرار بناءً على الوضع
            btnAddNew.Visible = isViewMode;
            btnEdit.Visible = isViewMode && _selectedItem != null;
            btnDelete.Visible = isViewMode && _selectedItem != null;
            btnSave.Visible = !isViewMode;
            btnCancel.Visible = !isViewMode;

            // تحديث عنوان اللوحة وتفريغ/ملء الحقول
            switch (mode)
            {
                case PanelMode.View:
                    lblPanelTitle.Text = "تفاصيل الصنف";
                    DisplayItemDetails(_selectedItem);
                    break;

                case PanelMode.Add:
                    lblPanelTitle.Text = "إضافة صنف جديد";
                    ClearInputFields();
                    txtItemName.Focus();
                    break;

                case PanelMode.Edit:
                    lblPanelTitle.Text = "تعديل بيانات الصنف";
                    FillInputFieldsWithSelectedItem();
                    txtItemName.Focus();
                    break;
            }
        }

        // --- 3. وظائف مساعدة للبيانات والواجهة ---

        private void LoadInventoryItems()
        {
            string selectedId = _selectedItem?.ItemID;

            dgvInventoryList.DataSource = null;
            dgvInventoryList.DataSource = DataService.GetAllInventoryItems();

            if (!string.IsNullOrEmpty(selectedId))
            {
                foreach (DataGridViewRow row in dgvInventoryList.Rows)
                {
                    if (row.Cells[nameof(InventoryItem.ItemID)].Value.ToString() == selectedId)
                    {
                        row.Selected = true;
                        dgvInventoryList.CurrentCell = row.Cells[nameof(InventoryItem.ItemName)];
                        break;
                    }
                }
            }
        }

        private void DisplayItemDetails(InventoryItem item)
        {
            if (item != null)
            {
                txtItemID.Text = item.ItemID;
                txtItemName.Text = item.ItemName;
                cmbCategory.SelectedItem = item.Category;
                txtUnit.Text = item.Unit;
                numCurrentQuantity.Value = (decimal)item.CurrentQuantity;
                numMinimumQuantity.Value = (decimal)item.MinimumQuantity;
                txtDescription.Text = item.Description;
                chkIsActive.Checked = item.IsActive;
            }
            else
            {
                ClearInputFields();
            }
        }

        private void ClearInputFields()
        {
            txtItemID.Clear();
            txtItemName.Clear();
            cmbCategory.SelectedIndex = -1;
            txtUnit.Clear();
            numCurrentQuantity.Value = 0;
            numMinimumQuantity.Value = 0;
            txtDescription.Clear();
            chkIsActive.Checked = true;
        }

        private void FillInputFieldsWithSelectedItem()
        {
            if (_selectedItem != null)
            {
                DisplayItemDetails(_selectedItem);
            }
        }

        private void SetupComboBoxes()
        {
            // إعداد قائمة البحث
            cmbSearch.Items.Add("اسم الصنف");
            cmbSearch.Items.Add("الفئة");
            cmbSearch.SelectedIndex = 0;

            // إعداد قائمة الفئات من الـ Enum
            cmbCategory.DataSource = Enum.GetValues(typeof(ItemCategory));
            // والآن سيعثر على هذه الخاصية

        }

        private string GenerateNewItemId()
        {
            var allItems = DataService.GetAllInventoryItems();
            if (!allItems.Any()) return "ITM-001";

            int maxIdNumber = allItems
                .Select(b => int.Parse(b.ItemID.Substring(4))) // "ITM-001" -> 1
                .Max();

            return "ITM-" + (maxIdNumber + 1).ToString("D3");
        }

        // --- 4. أحداث الأزرار والجدول ---

        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvInventoryList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventoryList.Rows.Count == 0 || dgvInventoryList.CurrentRow == null)
            {
                _selectedItem = null;
            }
            else if (dgvInventoryList.CurrentRow.DataBoundItem is InventoryItem selected)
            {
                _selectedItem = selected;
            }
            else
            {
                _selectedItem = null;
            }

            if (_currentMode == PanelMode.View)
            {
                DisplayItemDetails(_selectedItem);
                btnEdit.Visible = (_selectedItem != null);
                btnDelete.Visible = (_selectedItem != null);
            }
        }

        // الكود القديم
        private void dgvInventoryList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgvInventoryList.Columns.Count == 0) return;

            dgvInventoryList.Columns[nameof(InventoryItem.ItemID)].HeaderText = "رقم الصنف";
            // ... بقية تخصيص الأعمدة ...
            dgvInventoryList.Columns[nameof(InventoryItem.ItemName)].Width = 250;
            dgvInventoryList.Columns[nameof(InventoryItem.Category)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        //// الكود الجديد مع تحسين العرض
        //private void dgvInventoryList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{
        //    if (dgvInventoryList.Columns.Count == 0) return;

        //    // --- الجزء الموجود بالفعل ---
        //    dgvInventoryList.Columns[nameof(InventoryItem.ItemID)].HeaderText = "رقم الصنف";
        //    dgvInventoryList.Columns[nameof(InventoryItem.ItemName)].HeaderText = "اسم الصنف";
        //    dgvInventoryList.Columns[nameof(InventoryItem.Category)].HeaderText = "الفئة";
        //    dgvInventoryList.Columns[nameof(InventoryItem.Unit)].HeaderText = "الوحدة";
        //    dgvInventoryList.Columns[nameof(InventoryItem.CurrentQuantity)].HeaderText = "الكمية الحالية";
        //    dgvInventoryList.Columns[nameof(InventoryItem.MinimumQuantity)].HeaderText = "الحد الأدنى";
        //    dgvInventoryList.Columns[nameof(InventoryItem.IsActive)].HeaderText = "نشط";

        //    dgvInventoryList.Columns[nameof(InventoryItem.Description)].Visible = false;

        //    dgvInventoryList.Columns[nameof(InventoryItem.ItemName)].Width = 250;
        //    dgvInventoryList.Columns[nameof(InventoryItem.Category)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        //    // --- !!! الجزء الجديد المضاف هنا !!! ---
        //    // حلقة للمرور على كل صف في الجدول
        //    foreach (DataGridViewRow row in dgvInventoryList.Rows)
        //    {
        //        // احصل على قيمة الخلية في عمود "الفئة"
        //        var categoryValue = row.Cells[nameof(InventoryItem.Category)].Value;
        //        if (categoryValue != null)
        //        {
        //            // حول القيمة إلى نص واستبدل الشرطة السفلية بمسافة
        //            row.Cells[nameof(InventoryItem.Category)].Value = categoryValue.ToString().Replace("_", " ");
        //        }
        //    }
        //}


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _selectedItem = null;
            dgvInventoryList.ClearSelection();
            SetPanelMode(PanelMode.Add);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedItem != null)
            {
                SetPanelMode(PanelMode.Edit);
            }
            else
            {
                new frmAlert("الرجاء تحديد صنف أولاً لتعديل بياناته.").ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvInventoryList.SelectedRows.Count > 0)
            {
                _selectedItem = dgvInventoryList.SelectedRows[0].DataBoundItem as InventoryItem;
            }
            else
            {
                _selectedItem = null;
            }
            SetPanelMode(PanelMode.View);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text))
            {
                new frmAlert("يرجى إدخال اسم الصنف.").ShowDialog();
                txtItemName.Focus();
                return;
            }
            if (cmbCategory.SelectedIndex == -1)
            {
                new frmAlert("يرجى اختيار فئة الصنف.").ShowDialog();
                cmbCategory.Focus();
                return;
            }

            if (_currentMode == PanelMode.Add)
            {
                var newItem = new InventoryItem
                {
                    ItemID = GenerateNewItemId(),
                    ItemName = txtItemName.Text,
                    Category = (ItemCategory)cmbCategory.SelectedItem,
                    Unit = txtUnit.Text,
                    CurrentQuantity = (double)numCurrentQuantity.Value,
                    MinimumQuantity = (double)numMinimumQuantity.Value,
                    Description = txtDescription.Text,
                    IsActive = chkIsActive.Checked
                };

                DataService.AddInventoryItem(newItem);
                _selectedItem = newItem;
                new frmAlert("تمت إضافة الصنف بنجاح!").ShowDialog();
            }
            else if (_currentMode == PanelMode.Edit)
            {
                if (_selectedItem != null)
                {
                    _selectedItem.ItemName = txtItemName.Text;
                    _selectedItem.Category = (ItemCategory)cmbCategory.SelectedItem;
                    _selectedItem.Unit = txtUnit.Text;
                    _selectedItem.CurrentQuantity = (double)numCurrentQuantity.Value;
                    _selectedItem.MinimumQuantity = (double)numMinimumQuantity.Value;
                    _selectedItem.Description = txtDescription.Text;
                    _selectedItem.IsActive = chkIsActive.Checked;

                    DataService.UpdateInventoryItem(_selectedItem);
                    new frmAlert("تم تعديل بيانات الصنف بنجاح!").ShowDialog();
                }
            }

            LoadInventoryItems();
            SetPanelMode(PanelMode.View);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null)
            {
                new frmAlert("يرجى تحديد صنف لحذفه أولاً.").ShowDialog();
                return;
            }

            frmConfirm confirmDialog = new frmConfirm($"هل أنت متأكد من أنك تريد حذف الصنف '{_selectedItem.ItemName}'؟");

            if (confirmDialog.ShowDialog() == DialogResult.Yes)
            {
                DataService.DeleteInventoryItem(_selectedItem.ItemID);
                new frmAlert("تم حذف الصنف بنجاح.").ShowDialog();

                _selectedItem = null;
                LoadInventoryItems();
                SetPanelMode(PanelMode.View);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadInventoryItems();
                return;
            }

            var allItems = DataService.GetAllInventoryItems();
            List<InventoryItem> filteredList = new List<InventoryItem>();

            switch (cmbSearch.SelectedItem.ToString())
            {
                case "اسم الصنف":
                    filteredList = allItems.Where(i => i.ItemName.ToLower().Contains(searchTerm)).ToList();
                    break;
                case "الفئة":
                    filteredList = allItems.Where(i => i.Category.ToString().Replace("_", " ").Contains(searchTerm)).ToList();
                    break;
            }

            dgvInventoryList.DataSource = null;
            dgvInventoryList.DataSource = filteredList;
            if (filteredList.Count == 0)
            {
                new frmAlert("لم يتم العثور على نتائج تطابق بحثك.").ShowDialog();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearch.SelectedIndex = 0;
            LoadInventoryItems();
            txtSearch.Focus();
        }
    }
}
