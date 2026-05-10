using Smart_Charity_and_Aid_Distribution_Tracker.Enums;
using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmDonations : Form
    {
        private enum PanelMode { View, Add, Edit }
        private PanelMode _currentMode;
        private Donation _selectedDonation;

        public frmDonations()
        {
            InitializeComponent(); FontManager.ApplyFontToControls(this);

            this.Load += new System.EventHandler(this.frmDonations_Load);
        }

        private void frmDonations_Load(object sender, EventArgs e)
        {
            // ربط الأحداث
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.dgvDonationsList.SelectionChanged += new System.EventHandler(this.dgvDonationsList_SelectionChanged);
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDonations_FormClosed);

            // حدث تغيير نوع التبرع لإظهار/إخفاء الحقول
            this.cmbDonationType.SelectedIndexChanged += new System.EventHandler(this.cmbDonationType_SelectedIndexChanged);

            SetupComboBoxes();
            LoadDonationsData();
            SetPanelMode(PanelMode.View);

            var currentUser = SessionManager.GetCurrentUser();
            if (currentUser != null && currentUser.Role == UserRole.مستخدم_عادي)
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
        }
        // --- ميزة التنقل السلس والبحث السريع بزر Enter ---
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                // إذا كان المؤشر في حقل البحث، قم بتنفيذ البحث
                if (this.ActiveControl == txtSearch)
                {
                    btnSearch.PerformClick();
                    return true;
                }

                // استثناء حقل الملاحظات (للسماح بالنزول لسطر جديد)
                if (this.ActiveControl == txtNotes)
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }

                // استثناء الأزرار والجداول
                if (this.ActiveControl is Guna.UI2.WinForms.Guna2Button ||
                    this.ActiveControl is Guna.UI2.WinForms.Guna2DataGridView)
                {
                    return base.ProcessCmdKey(ref msg, keyData);
                }

                // تحويل ضغطة Enter إلى Tab للانتقال للحقل التالي
                SendKeys.Send("{TAB}");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmDonations_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dashboard = Application.OpenForms.OfType<frmDashBoard>().FirstOrDefault();
            if (dashboard != null) dashboard.Show();
        }

        private void SetupComboBoxes()
        {
            cmbSearch.Items.Clear();
            cmbSearch.Items.Add("اسم المتبرع");
            cmbSearch.SelectedIndex = 0;

            // تعبئة قائمة المتبرعين
            cmbDonor.DataSource = DataService.GetDonors();
            cmbDonor.DisplayMember = "FullName";
            cmbDonor.ValueMember = "DonorID";

            // تعبئة قائمة الأصناف
            cmbItem.DataSource = DataService.GetInventoryItems();
            cmbItem.DisplayMember = "ItemName";
            cmbItem.ValueMember = "ItemID";

            // تعبئة نوع التبرع
            cmbDonationType.DataSource = Enum.GetValues(typeof(DonationType));
        }

        private void cmbDonationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDonationType.SelectedItem == null) return;

            DonationType type = (DonationType)cmbDonationType.SelectedItem;

            if (type == DonationType.نقدي)
            {
                // إظهار حقل المبلغ وإخفاء الصنف والكمية
                txtAmount.Visible = true;
                labelAmount.Visible = true;

                cmbItem.Visible = false;
                labelItem.Visible = false;
                txtQuantity.Visible = false;
                labelQuantity.Visible = false;
            }
            else // InKind (عيني)
            {
                // إظهار الصنف والكمية وإخفاء المبلغ
                txtAmount.Visible = false;
                labelAmount.Visible = false;

                cmbItem.Visible = true;
                labelItem.Visible = true;
                txtQuantity.Visible = true;
                labelQuantity.Visible = true;
            }
        }

        private void SetPanelMode(PanelMode mode)
        {
            _currentMode = mode;

            pnlView.Visible = (mode == PanelMode.View);
            pnlInputs.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);

            btnSave.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);
            btnCancel.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);

            var currentUser = SessionManager.GetCurrentUser();
            bool canModify = currentUser != null && (currentUser.Role == UserRole.مدير || currentUser.Role == UserRole.مستخدم_عادي);

            btnAddNew.Visible = (mode == PanelMode.View && canModify);

            bool hasSelected = (_selectedDonation != null);
            btnEdit.Visible = (mode == PanelMode.View && hasSelected && canModify);
            btnDelete.Visible = (mode == PanelMode.View && hasSelected && canModify);

            switch (mode)
            {
                case PanelMode.View:
                    lblPanelTitle.Text = "تفاصيل التبرع";
                    DisplayDonationDetails(_selectedDonation);
                    break;
                case PanelMode.Add:
                    lblPanelTitle.Text = "إضافة تبرع جديد";
                    ClearInputFields();
                    break;
                case PanelMode.Edit:
                    lblPanelTitle.Text = "تعديل بيانات التبرع";
                    FillInputFieldsWithSelectedDonation();
                    break;
            }
            if (currentUser != null && currentUser.Role == UserRole.مستخدم_عادي)
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void LoadDonationsData()
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();

            var query = from d in DataService.GetDonations()
                        join donor in DataService.GetDonors() on d.DonorID equals donor.DonorID
                        select new
                        {
                            d.DonationID,
                            DonorName = donor.FullName,
                            Type = d.DonationType.ToString(),
                            Details = d.DonationType == DonationType.نقدي ? $"{d.Amount} ريال" : $"{d.Quantity} وحدة",
                            d.DonationDate
                        };

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(q => q.DonorName.ToLower().Contains(searchTerm));
            }

            dgvDonationsList.DataSource = null;
            dgvDonationsList.DataSource = query.ToList();
            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            if (dgvDonationsList.Columns.Count > 0)
            {
                dgvDonationsList.Columns["DonationID"].HeaderText = "رقم التبرع";
                dgvDonationsList.Columns["DonorName"].HeaderText = "اسم المتبرع";
                dgvDonationsList.Columns["Type"].HeaderText = "النوع";
                dgvDonationsList.Columns["Details"].HeaderText = "التفاصيل";
                dgvDonationsList.Columns["DonationDate"].HeaderText = "التاريخ";
                dgvDonationsList.Columns["DonorName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void DisplayDonationDetails(Donation donation)
        {
            if (donation != null)
            {
                var donor = DataService.GetDonors().FirstOrDefault(d => d.DonorID == donation.DonorID);
                lblDonorText.Text = donor != null ? donor.FullName : "غير معروف";
                lblDonationTypeText.Text = donation.DonationType.ToString();

                if (donation.DonationType == DonationType.نقدي)
                {
                    lblAmountText.Text = donation.Amount.ToString();
                    lblItemText.Text = "----";
                    lblQuantityText.Text = "----";
                }
                else
                {
                    var item = DataService.GetInventoryItems().FirstOrDefault(i => i.ItemID == donation.ItemID);
                    lblItemText.Text = item != null ? item.ItemName : "غير معروف";
                    lblQuantityText.Text = donation.Quantity.ToString();
                    lblAmountText.Text = "----";
                }

                lblNotesText.Text = string.IsNullOrWhiteSpace(donation.Notes) ? "----" : donation.Notes;
            }
            else
            {
                lblDonorText.Text = "----";
                lblDonationTypeText.Text = "----";
                lblItemText.Text = "----";
                lblQuantityText.Text = "----";
                lblAmountText.Text = "----";
                lblNotesText.Text = "----";
            }
        }

        private void ClearInputFields()
        {
            if (cmbDonor.Items.Count > 0) cmbDonor.SelectedIndex = 0;
            if (cmbDonationType.Items.Count > 0) cmbDonationType.SelectedIndex = 0;
            if (cmbItem.Items.Count > 0) cmbItem.SelectedIndex = 0;
            txtQuantity.Clear();
            txtAmount.Clear();
            txtNotes.Clear();
        }

        private void FillInputFieldsWithSelectedDonation()
        {
            if (_selectedDonation != null)
            {
                cmbDonor.SelectedValue = _selectedDonation.DonorID;
                cmbDonationType.SelectedItem = _selectedDonation.DonationType;

                if (_selectedDonation.DonationType == DonationType.نقدي)
                {
                    txtAmount.Text = _selectedDonation.Amount.ToString();
                }
                else
                {
                    cmbItem.SelectedValue = _selectedDonation.ItemID;
                    txtQuantity.Text = _selectedDonation.Quantity.ToString();
                }

                txtNotes.Text = _selectedDonation.Notes;
            }
        }

        private void dgvDonationsList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDonationsList.CurrentRow != null)
            {
                string selectedId = dgvDonationsList.CurrentRow.Cells["DonationID"].Value.ToString();
                _selectedDonation = DataService.GetDonations().FirstOrDefault(d => d.DonationID == selectedId);
            }
            else
            {
                _selectedDonation = null;
            }

            if (_currentMode == PanelMode.View)
            {
                SetPanelMode(PanelMode.View);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbDonor.SelectedValue == null)
            {
                new frmAlert("الرجاء اختيار المتبرع.").ShowDialog();
                return;
            }

            DonationType type = (DonationType)cmbDonationType.SelectedItem;
            double amount = 0;
            double quantity = 0;

            if (type == DonationType.نقدي)
            {
                if (!double.TryParse(txtAmount.Text, out amount) || amount <= 0)
                {
                    new frmAlert("الرجاء إدخال مبلغ صحيح وموجب.").ShowDialog();
                    return;
                }
            }
            else
            {
                if (cmbItem.SelectedValue == null)
                {
                    new frmAlert("الرجاء اختيار الصنف.").ShowDialog();
                    return;
                }
                if (!double.TryParse(txtQuantity.Text, out quantity) || quantity <= 0)
                {
                    new frmAlert("الرجاء إدخال كمية صحيحة وموجبة.").ShowDialog();
                    return;
                }
            }

            var currentUser = SessionManager.GetCurrentUser();
            string empId = currentUser != null ? currentUser.EmployeeID : "System";

            if (_currentMode == PanelMode.Add)
            {
                string newId = "DO" + DateTime.Now.ToString("yyyyMMddHHmmss");

                var newDonation = new Donation
                {
                    DonationID = newId,
                    DonorID = cmbDonor.SelectedValue.ToString(),
                    DonationType = type,
                    ItemID = type == DonationType.عيني ? cmbItem.SelectedValue.ToString() : null,
                    Quantity = type == DonationType.عيني ? quantity : 0,
                    Amount = type == DonationType.نقدي ? amount : 0,
                    DonationDate = DateTime.Now,
                    ReceivedBy = empId,
                    Notes = txtNotes.Text.Trim()
                };

                DataService.AddDonation(newDonation);

                // تأكد من وجود هذا في بداية الدالة
                string performedBy = currentUser != null ? currentUser.EmployeeID : "System";

                // ... (الكود الخاص بك للتحقق من المدخلات) ...

                // إنشاء كائن التبرع
                var donation = new Donation
                {
                    DonationID = "DON" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                    DonorID = cmbDonor.SelectedValue.ToString(),
                    DonationType = DonationType.نقدي,
                    Amount = amount,
                    DonationDate = DateTime.Now,
                    ReceivedBy = performedBy,
                    Notes = txtNotes.Text.Trim()
                };

                // حفظ التبرع
                DataService.AddDonation(donation);

                // تسجيل الحركة المالية (وارد) لإضافة المبلغ للصندوق
                var finTransaction = new FinancialTransaction
                {
                    TransactionID = "TRX" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                    Type = TransactionType.وارد,
                    Amount = amount,
                    TransactionDate = DateTime.Now,
                    ReferenceID = newDonation.DonationID, // استخدمنا newDonation هنا
                    PerformedBy = performedBy, // استخدمنا performedBy هنا
                    Notes = $"تبرع نقدي من المتبرع: {cmbDonor.Text}"
                };
                DataService.RecordFinancialTransaction(finTransaction);

                new frmAlert("تم حفظ التبرع النقدي وإضافته للصندوق بنجاح!").ShowDialog();


                // --- السحر هنا: تسجيل حركة المخزون (وارد) للتبرع العيني ---
                if (type == DonationType.عيني)
                {
                    var donorName = ((Donor)cmbDonor.SelectedItem).FullName;
                    var movement = new InventoryMovement
                    {
                        MovementID = "M" + Guid.NewGuid().ToString().Substring(0, 8),
                        ItemID = newDonation.ItemID,
                        MovementType = MovementType.وارد, // وارد
                        Quantity = quantity,
                        MovementDate = DateTime.Now,
                        ReferenceID = newId,
                        PerformedBy = empId,
                        Notes = $"تبرع عيني من المتبرع: {donorName}"
                    };
                    DataService.RecordMovement(movement); // هذه الدالة ستزيد رصيد المخزون تلقائياً!
                }

                new frmAlert("تم تسجيل التبرع بنجاح.").ShowDialog();
            }
            else if (_currentMode == PanelMode.Edit)
            {
                // في الأنظمة المحاسبية الحقيقية، لا يُفضل تعديل التبرعات العينية مباشرة لتجنب لخبطة المخزون
                // لكن للتبسيط هنا سنسمح بتعديل البيانات الأساسية
                _selectedDonation.Notes = txtNotes.Text.Trim();
                DataService.UpdateDonation(_selectedDonation);
                new frmAlert("تم تعديل الملاحظات بنجاح. (تعديل الكميات يتطلب تسوية مخزنية)").ShowDialog();
            }

            LoadDonationsData();
            SetPanelMode(PanelMode.View);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDonation == null) return;

            frmConfirm confirmDialog = new frmConfirm("هل أنت متأكد من الحذف؟ (ملاحظة: لن يتم عكس حركة المخزون تلقائياً)");
            if (confirmDialog.ShowDialog() == DialogResult.Yes)
            {
                DataService.DeleteDonation(_selectedDonation.DonationID);
                new frmAlert("تم حذف سجل التبرع بنجاح.").ShowDialog();
                LoadDonationsData();
                SetPanelMode(PanelMode.View);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) { LoadDonationsData(); }
        private void btnClear_Click(object sender, EventArgs e) { txtSearch.Clear(); LoadDonationsData(); }
        private void btnAddNew_Click(object sender, EventArgs e) { SetPanelMode(PanelMode.Add); }
        private void btnEdit_Click(object sender, EventArgs e) { if (_selectedDonation != null) SetPanelMode(PanelMode.Edit); }
        private void btnCancel_Click(object sender, EventArgs e) { SetPanelMode(PanelMode.View); }
        private void btnBackToDashBoard_Click(object sender, EventArgs e) { this.Close(); }
    }
}
