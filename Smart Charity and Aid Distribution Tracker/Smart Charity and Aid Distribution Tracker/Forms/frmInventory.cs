using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmInventory : Form
    {
        private enum PanelMode { View, Add, Edit }
        private PanelMode _currentMode;
        private InventoryItem _selectedItem;

        public frmInventory()
        {
            InitializeComponent();
            // ربط حدث Load هنا لضمان تشغيله عند فتح الشاشة
            this.Load += new System.EventHandler(this.frmInventory_Load);
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            // 1. ربط الأحداث يدوياً
            this.btnBackToDashBoard.Click += new System.EventHandler(this.btnBackToDashBoard_Click);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.dgvInventoryList.SelectionChanged += new System.EventHandler(this.dgvInventoryList_SelectionChanged);
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInventory_FormClosed);

            // 2. إعداد القوائم وتحميل البيانات
            SetupComboBoxes();
            LoadInventoryData();
            SetPanelMode(PanelMode.View);
        }

        private void frmInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dashboard = Application.OpenForms.OfType<frmDashBoard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.Show();
            }
        }

        private void SetupComboBoxes()
        {
            // إعداد قائمة البحث
            cmbSearch.Items.Clear();
            cmbSearch.Items.Add("اسم الصنف");
            cmbSearch.Items.Add("الفئة");
            cmbSearch.SelectedIndex = 0;

            // إعداد قائمة الفئات
            cmbCategory.DataSource = Enum.GetValues(typeof(ItemCategory));
        }

        private void SetPanelMode(PanelMode mode)
        {
            _currentMode = mode;

            pnlView.Visible = (mode == PanelMode.View);
            pnlInputs.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);

            btnSave.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);
            btnCancel.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);

            // تطبيق الصلاحيات: المدير وأمين المخزون فقط يمكنهم الإضافة والتعديل والحذف
            var currentUser = SessionManager.GetCurrentUser();
            bool canModify = currentUser != null && (currentUser.Role == UserRole.Admin || currentUser.Role == UserRole.StoreKeeper);

            btnAddNew.Visible = (mode == PanelMode.View && canModify);

            bool hasSelected = (_selectedItem != null);
            btnEdit.Visible = (mode == PanelMode.View && hasSelected && canModify);
            btnDelete.Visible = (mode == PanelMode.View && hasSelected && canModify);

            switch (mode)
            {
                case PanelMode.View:
                    lblPanelTitle.Text = "تفاصيل الصنف";
                    DisplayItemDetails(_selectedItem);
                    break;

                case PanelMode.Add:
                    lblPanelTitle.Text = "إضافة صنف جديد";
                    ClearInputFields();
                    chkIsActive.Checked = true; // افتراضياً الصنف الجديد نشط
                    break;

                case PanelMode.Edit:
                    lblPanelTitle.Text = "تعديل بيانات الصنف";
                    FillInputFieldsWithSelectedItem();
                    break;
            }
        }

        private void LoadInventoryData()
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            string searchType = cmbSearch.SelectedItem?.ToString();

            var query = DataService.GetInventoryItems().AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                if (searchType == "اسم الصنف")
                {
                    query = query.Where(i => i.ItemName.ToLower().Contains(searchTerm));
                }
                else if (searchType == "الفئة")
                {
                    query = query.Where(i => i.Category.ToString().ToLower().Contains(searchTerm));
                }
            }

            var items = query.Select(i => new {
                i.ItemID,
                i.ItemName,
                Category = i.Category.ToString(),
                i.CurrentQuantity,
                i.Unit,
                Status = i.IsActive ? "نشط" : "غير نشط"
            }).ToList();

            // تفريغ مصدر البيانات أولاً لإجبار الجدول على التحديث الفوري
            dgvInventoryList.DataSource = null;
            dgvInventoryList.DataSource = items;
            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            if (dgvInventoryList.Columns.Count > 0)
            {
                dgvInventoryList.Columns["ItemID"].HeaderText = "رقم الصنف";
                dgvInventoryList.Columns["ItemName"].HeaderText = "اسم الصنف";
                dgvInventoryList.Columns["Category"].HeaderText = "الفئة";
                dgvInventoryList.Columns["CurrentQuantity"].HeaderText = "الكمية الحالية";
                dgvInventoryList.Columns["Unit"].HeaderText = "الوحدة";
                dgvInventoryList.Columns["Status"].HeaderText = "الحالة";
                dgvInventoryList.Columns["ItemName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void DisplayItemDetails(InventoryItem item)
        {
            if (item != null)
            {
                lblItemNameText.Text = item.ItemName;
                lblCategoryText.Text = item.Category.ToString();
                lblUnitText.Text = item.Unit;
                lblCurrentQuantityText.Text = item.CurrentQuantity.ToString();
                lblMinQtyText.Text = item.MinimumQuantity.ToString();
                lblDescriptionText.Text = string.IsNullOrWhiteSpace(item.Description) ? "لا يوجد وصف" : item.Description;
                lblIsActiveText.Text = item.IsActive ? "نشط" : "غير نشط";
                lblIsActiveText.ForeColor = item.IsActive ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }
            else
            {
                lblItemNameText.Text = "----";
                lblCategoryText.Text = "----";
                lblUnitText.Text = "----";
                lblCurrentQuantityText.Text = "----";
                lblMinQtyText.Text = "----";
                lblDescriptionText.Text = "----";
                lblIsActiveText.Text = "----";
                lblIsActiveText.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

        private void ClearInputFields()
        {
            txtItemName.Clear();
            txtUnit.Clear();
            txtCurrentQuantity.Clear();
            txtMinimumQuantity.Clear();
            txtDescription.Clear();
            if (cmbCategory.Items.Count > 0) cmbCategory.SelectedIndex = 0;
            chkIsActive.Checked = true;
        }

        private void FillInputFieldsWithSelectedItem()
        {
            if (_selectedItem != null)
            {
                txtItemName.Text = _selectedItem.ItemName;
                cmbCategory.SelectedItem = _selectedItem.Category;
                txtUnit.Text = _selectedItem.Unit;
                txtCurrentQuantity.Text = _selectedItem.CurrentQuantity.ToString();
                txtMinimumQuantity.Text = _selectedItem.MinimumQuantity.ToString();
                txtDescription.Text = _selectedItem.Description;
                chkIsActive.Checked = _selectedItem.IsActive;
            }
        }

        private void dgvInventoryList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventoryList.CurrentRow != null)
            {
                string selectedId = dgvInventoryList.CurrentRow.Cells["ItemID"].Value.ToString();
                _selectedItem = DataService.GetInventoryItems().FirstOrDefault(i => i.ItemID == selectedId);
            }
            else
            {
                _selectedItem = null;
            }

            if (_currentMode == PanelMode.View)
            {
                SetPanelMode(PanelMode.View);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemName.Text) || string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                new frmAlert("يجب إدخال اسم الصنف ووحدة القياس.").ShowDialog();
                return;
            }

            if (!double.TryParse(txtCurrentQuantity.Text, out double currentQty) || currentQty < 0)
            {
                new frmAlert("الرجاء إدخال رقم صحيح وموجب للكمية الحالية.").ShowDialog();
                return;
            }

            if (!double.TryParse(txtMinimumQuantity.Text, out double minQty) || minQty < 0)
            {
                new frmAlert("الرجاء إدخال رقم صحيح وموجب للحد الأدنى.").ShowDialog();
                return;
            }

            // جلب المستخدم الحالي لتسجيل من قام بالحركة
            var currentUser = SessionManager.GetCurrentUser();
            string empId = currentUser != null ? currentUser.EmployeeID : "System";

            if (_currentMode == PanelMode.Add)
            {
                int lastIdNumber = DataService.GetInventoryItems().Any()
                    ? DataService.GetInventoryItems().Select(i => int.Parse(i.ItemID.Substring(1))).Max()
                    : 0;
                string newId = "I" + (lastIdNumber + 1).ToString("D3");

                var newItem = new InventoryItem
                {
                    ItemID = newId,
                    ItemName = txtItemName.Text.Trim(),
                    Category = (ItemCategory)Enum.Parse(typeof(ItemCategory), cmbCategory.SelectedItem.ToString()),
                    Unit = txtUnit.Text.Trim(),
                    CurrentQuantity = 0, // نضعها صفر مبدئياً، حركة المخزون هي من ستضيف الكمية
                    MinimumQuantity = minQty,
                    Description = txtDescription.Text.Trim(),
                    IsActive = chkIsActive.Checked
                };

                DataService.AddInventoryItem(newItem);

                // إذا أدخل المستخدم كمية ابتدائية، نسجلها كحركة "وارد" (رصيد افتتاحي)
                if (currentQty > 0)
                {
                    var movement = new InventoryMovement
                    {
                        MovementID = "M" + Guid.NewGuid().ToString().Substring(0, 8),
                        ItemID = newId,
                        MovementType = MovementType.In, // وارد
                        Quantity = currentQty,
                        MovementDate = DateTime.Now,
                        ReferenceID = "رصيد افتتاحي",
                        PerformedBy = empId,
                        Notes = "رصيد افتتاحي عند إضافة الصنف للنظام"
                    };
                    DataService.RecordMovement(movement); // هذه الدالة ستضيف الكمية للصنف
                }

                new frmAlert("تمت إضافة الصنف بنجاح.").ShowDialog();
            }
            else if (_currentMode == PanelMode.Edit)
            {
                // حساب الفارق بين الكمية القديمة والجديدة
                double oldQty = _selectedItem.CurrentQuantity;
                double difference = currentQty - oldQty;

                _selectedItem.ItemName = txtItemName.Text.Trim();
                _selectedItem.Category = (ItemCategory)Enum.Parse(typeof(ItemCategory), cmbCategory.SelectedItem.ToString());
                _selectedItem.Unit = txtUnit.Text.Trim();
                // ملاحظة: لا نعدل CurrentQuantity هنا يدوياً، سنترك حركة التسوية تقوم بذلك
                _selectedItem.MinimumQuantity = minQty;
                _selectedItem.Description = txtDescription.Text.Trim();
                _selectedItem.IsActive = chkIsActive.Checked;

                DataService.UpdateInventoryItem(_selectedItem);

                // إذا قام المستخدم بتغيير الكمية، نسجل حركة "تسوية"
                if (difference != 0)
                {
                    var movement = new InventoryMovement
                    {
                        MovementID = "M" + Guid.NewGuid().ToString().Substring(0, 8),
                        ItemID = _selectedItem.ItemID,
                        MovementType = MovementType.Adjustment, // تسوية
                        Quantity = difference, // قد تكون موجبة (زيادة) أو سالبة (نقصان)
                        MovementDate = DateTime.Now,
                        ReferenceID = "تسوية يدوية",
                        PerformedBy = empId,
                        Notes = "تسوية رصيد يدوية من شاشة إدارة المخزون"
                    };
                    DataService.RecordMovement(movement); // هذه الدالة ستعدل رصيد الصنف
                }

                new frmAlert("تم تعديل بيانات الصنف بنجاح.").ShowDialog();
            }

            LoadInventoryData();
            SetPanelMode(PanelMode.View);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedItem == null) return;

            frmConfirm confirmDialog = new frmConfirm($"هل أنت متأكد من أنك تريد حذف الصنف '{_selectedItem.ItemName}'؟");
            if (confirmDialog.ShowDialog() == DialogResult.Yes)
            {
                DataService.DeleteInventoryItem(_selectedItem.ItemID);
                new frmAlert("تم حذف الصنف بنجاح.").ShowDialog();
                LoadInventoryData();
                SetPanelMode(PanelMode.View);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) { LoadInventoryData(); }
        private void btnClear_Click(object sender, EventArgs e) { txtSearch.Clear(); LoadInventoryData(); }
        private void btnAddNew_Click(object sender, EventArgs e) { SetPanelMode(PanelMode.Add); }
        private void btnEdit_Click(object sender, EventArgs e) { if (_selectedItem != null) SetPanelMode(PanelMode.Edit); }
        private void btnCancel_Click(object sender, EventArgs e) { SetPanelMode(PanelMode.View); }
        private void btnBackToDashBoard_Click(object sender, EventArgs e) { this.Close(); }
    }
}
