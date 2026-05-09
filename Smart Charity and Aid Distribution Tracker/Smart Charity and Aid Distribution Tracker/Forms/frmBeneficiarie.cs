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
    public partial class frmBeneficiarie : Form
    {
        private enum PanelMode { View, Add, Edit }
        private PanelMode _currentMode;
        private Beneficiary _selectedBeneficiary;

        public frmBeneficiarie()
        {
            InitializeComponent();
            FontManager.ApplyFontToControls(this);

            // أضف هذا السطر لضمان تشغيل دالة Load عند فتح الشاشة
            this.Load += new System.EventHandler(this.frmBeneficiarie_Load);
        }

        private void frmBeneficiarie_Load(object sender, EventArgs e)
        {
            // 1. ربط الأحداث يدوياً لضمان عمل الشاشة (تم إزالة زر العودة للرئيسية)
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.dgvBeneficiariesList.SelectionChanged += new System.EventHandler(this.dgvBeneficiariesList_SelectionChanged);
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 2. إعداد القوائم وتحميل البيانات
            SetupComboBoxes();
            LoadBeneficiariesData();
            SetPanelMode(PanelMode.View);

            // 3. تطبيق الصلاحيات عند فتح الشاشة
            var currentUser = SessionManager.GetCurrentUser();
            if (currentUser != null && currentUser.Role == UserRole.User)
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void SetupComboBoxes()
        {
            // ربط قائمة الحالة الاجتماعية بـ Enum
            cmbSocialStatus.DataSource = Enum.GetValues(typeof(SocialStatus));
        }

        private void SetPanelMode(PanelMode mode)
        {
            _currentMode = mode;

            pnlView.Visible = (mode == PanelMode.View);
            pnlInputs.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);

            btnSave.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);
            btnCancel.Visible = (mode == PanelMode.Add || mode == PanelMode.Edit);

            btnAddNew.Visible = (mode == PanelMode.View);

            // إظهار أزرار التعديل والحذف فقط في وضع العرض وإذا كان هناك مستفيد محدد
            bool hasSelected = (_selectedBeneficiary != null);
            btnEdit.Visible = (mode == PanelMode.View && hasSelected);
            btnDelete.Visible = (mode == PanelMode.View && hasSelected);

            // تطبيق الصلاحيات على الأزرار
            var currentUser = SessionManager.GetCurrentUser();
            if (currentUser != null && currentUser.Role == UserRole.User)
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }

            switch (mode)
            {
                case PanelMode.View:
                    lblPanelTitle.Text = "تفاصيل المستفيد";
                    DisplayBeneficiaryDetails(_selectedBeneficiary);
                    break;

                case PanelMode.Add:
                    lblPanelTitle.Text = "إضافة مستفيد جديد";
                    ClearInputFields();
                    chkIsActive.Checked = true; // افتراضياً المستفيد الجديد نشط
                    break;

                case PanelMode.Edit:
                    lblPanelTitle.Text = "تعديل بيانات المستفيد";
                    FillInputFieldsWithSelectedBeneficiary();
                    break;
            }
        }

        private void LoadBeneficiariesData()
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();

            var beneficiaries = DataService.GetBeneficiaries()
                .Where(b => string.IsNullOrEmpty(searchTerm) ||
                            b.FullName.ToLower().Contains(searchTerm) ||
                            b.NationalID.Contains(searchTerm))
                .Select(b => new {
                    b.BeneficiaryID,
                    b.NationalID,
                    b.FullName,
                    b.Phone,
                    b.FamilySize,
                    Status = b.IsActive ? "نشط" : "غير نشط"
                })
                .ToList();

            dgvBeneficiariesList.DataSource = beneficiaries;
            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            if (dgvBeneficiariesList.Columns.Count > 0)
            {
                dgvBeneficiariesList.Columns["BeneficiaryID"].HeaderText = "رقم الملف";
                dgvBeneficiariesList.Columns["NationalID"].HeaderText = "الرقم الوطني";
                dgvBeneficiariesList.Columns["FullName"].HeaderText = "الاسم الكامل";
                dgvBeneficiariesList.Columns["Phone"].HeaderText = "رقم الجوال";
                dgvBeneficiariesList.Columns["FamilySize"].HeaderText = "أفراد الأسرة";
                dgvBeneficiariesList.Columns["Status"].HeaderText = "الحالة";
                dgvBeneficiariesList.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void DisplayBeneficiaryDetails(Beneficiary b)
        {
            if (b != null)
            {
                lblFullNameText.Text = b.FullName;
                lblNationalIDText.Text = b.NationalID;
                lblPhoneText.Text = b.Phone;
                lblAddressText.Text = b.Address;
                lblFamilySizeText.Text = b.FamilySize.ToString();
                lblSocialStatusText.Text = b.SocialStatus.ToString();
                lblNeedReasonText.Text = b.NeedReason;
                lblNotesText.Text = string.IsNullOrWhiteSpace(b.Notes) ? "لا توجد ملاحظات" : b.Notes;
                lblIsActiveText.Text = b.IsActive ? "نشط" : "غير نشط";
                lblIsActiveText.ForeColor = b.IsActive ? System.Drawing.Color.Green : System.Drawing.Color.Red;
            }
            else
            {
                lblFullNameText.Text = "----";
                lblNationalIDText.Text = "----";
                lblPhoneText.Text = "----";
                lblAddressText.Text = "----";
                lblFamilySizeText.Text = "----";
                lblSocialStatusText.Text = "----";
                lblNeedReasonText.Text = "----";
                lblNotesText.Text = "----";
                lblIsActiveText.Text = "----";
                lblIsActiveText.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            }
        }

        private void ClearInputFields()
        {
            txtFullName.Clear();
            txtNationalID.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtFamilySize.Clear();
            txtNeedReason.Clear();
            txtNotes.Clear();
            if (cmbSocialStatus.Items.Count > 0) cmbSocialStatus.SelectedIndex = 0;
            chkIsActive.Checked = true;
        }

        private void FillInputFieldsWithSelectedBeneficiary()
        {
            if (_selectedBeneficiary != null)
            {
                txtFullName.Text = _selectedBeneficiary.FullName;
                txtNationalID.Text = _selectedBeneficiary.NationalID;
                txtPhone.Text = _selectedBeneficiary.Phone;
                txtAddress.Text = _selectedBeneficiary.Address;
                txtFamilySize.Text = _selectedBeneficiary.FamilySize.ToString();
                txtNeedReason.Text = _selectedBeneficiary.NeedReason;
                txtNotes.Text = _selectedBeneficiary.Notes;
                cmbSocialStatus.SelectedItem = _selectedBeneficiary.SocialStatus;
                chkIsActive.Checked = _selectedBeneficiary.IsActive;
            }
        }

        private void dgvBeneficiariesList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBeneficiariesList.CurrentRow != null)
            {
                string selectedId = dgvBeneficiariesList.CurrentRow.Cells["BeneficiaryID"].Value.ToString();
                _selectedBeneficiary = DataService.GetBeneficiaryById(selectedId);
            }
            else
            {
                _selectedBeneficiary = null;
            }

            if (_currentMode == PanelMode.View)
            {
                DisplayBeneficiaryDetails(_selectedBeneficiary);

                // تطبيق الصلاحيات
                var currentUser = SessionManager.GetCurrentUser();
                if (currentUser != null && currentUser.Role == UserRole.Admin)
                {
                    btnEdit.Visible = (_selectedBeneficiary != null);
                    btnDelete.Visible = (_selectedBeneficiary != null);
                }
                else
                {
                    btnEdit.Visible = false;
                    btnDelete.Visible = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. التحقق من المدخلات الأساسية
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtNationalID.Text))
            {
                new frmAlert("يجب إدخال الاسم الكامل والرقم الوطني.").ShowDialog();
                return;
            }

            // 2. التحقق من أن حجم الأسرة رقم صحيح
            if (!int.TryParse(txtFamilySize.Text, out int familySize))
            {
                new frmAlert("الرجاء إدخال رقم صحيح لعدد أفراد الأسرة.").ShowDialog();
                return;
            }

            if (_currentMode == PanelMode.Add)
            {
                // إنشاء ID جديد
                int lastIdNumber = DataService.GetBeneficiaries().Any()
                    ? DataService.GetBeneficiaries().Select(b => int.Parse(b.BeneficiaryID.Substring(1))).Max()
                    : 0;
                string newId = "B" + (lastIdNumber + 1).ToString("D3");

                var newBeneficiary = new Beneficiary
                {
                    BeneficiaryID = newId,
                    FullName = txtFullName.Text.Trim(),
                    NationalID = txtNationalID.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    FamilySize = familySize,
                    SocialStatus = (SocialStatus)Enum.Parse(typeof(SocialStatus), cmbSocialStatus.SelectedItem.ToString()),
                    NeedReason = txtNeedReason.Text.Trim(),
                    Notes = txtNotes.Text.Trim(),
                    IsActive = chkIsActive.Checked,
                    RegistrationDate = DateTime.Now
                };

                DataService.AddBeneficiary(newBeneficiary);
                new frmAlert("تمت إضافة المستفيد بنجاح.").ShowDialog();
            }
            else if (_currentMode == PanelMode.Edit)
            {
                _selectedBeneficiary.FullName = txtFullName.Text.Trim();
                _selectedBeneficiary.NationalID = txtNationalID.Text.Trim();
                _selectedBeneficiary.Phone = txtPhone.Text.Trim();
                _selectedBeneficiary.Address = txtAddress.Text.Trim();
                _selectedBeneficiary.FamilySize = familySize;
                _selectedBeneficiary.SocialStatus = (SocialStatus)Enum.Parse(typeof(SocialStatus), cmbSocialStatus.SelectedItem.ToString());
                _selectedBeneficiary.NeedReason = txtNeedReason.Text.Trim();
                _selectedBeneficiary.Notes = txtNotes.Text.Trim();
                _selectedBeneficiary.IsActive = chkIsActive.Checked;

                DataService.UpdateBeneficiary(_selectedBeneficiary);
                new frmAlert("تم تعديل بيانات المستفيد بنجاح.").ShowDialog();
            }

            LoadBeneficiariesData();
            SetPanelMode(PanelMode.View);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedBeneficiary == null) return;

            frmConfirm confirmDialog = new frmConfirm($"هل أنت متأكد من أنك تريد حذف المستفيد '{_selectedBeneficiary.FullName}'؟");
            if (confirmDialog.ShowDialog() == DialogResult.Yes)
            {
                DataService.DeleteBeneficiary(_selectedBeneficiary.BeneficiaryID);
                new frmAlert("تم حذف المستفيد بنجاح.").ShowDialog();
                LoadBeneficiariesData();
                SetPanelMode(PanelMode.View);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) { LoadBeneficiariesData(); }
        private void btnClear_Click(object sender, EventArgs e) { txtSearch.Clear(); LoadBeneficiariesData(); }
        private void btnAddNew_Click(object sender, EventArgs e) { SetPanelMode(PanelMode.Add); }
        private void btnEdit_Click(object sender, EventArgs e) { if (_selectedBeneficiary != null) SetPanelMode(PanelMode.Edit); }
        private void btnCancel_Click(object sender, EventArgs e) { SetPanelMode(PanelMode.View); }
    }
}
