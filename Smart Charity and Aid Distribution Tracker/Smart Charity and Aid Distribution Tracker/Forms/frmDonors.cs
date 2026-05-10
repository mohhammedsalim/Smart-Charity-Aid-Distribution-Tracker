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
    public partial class frmDonors : Form
    {
        private enum PanelMode { View, Add, Edit }
        private PanelMode _currentMode;
        private Donor _selectedDonor;

        public frmDonors()
        {
            InitializeComponent(); FontManager.ApplyFontToControls(this);

            this.Load += new System.EventHandler(this.frmDonors_Load);
        }

        private void frmDonors_Load(object sender, EventArgs e)
        {
            // ربط الأحداث
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.dgvDonorsList.SelectionChanged += new System.EventHandler(this.dgvDonorsList_SelectionChanged);
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDonors_FormClosed);

            var currentUser = SessionManager.GetCurrentUser();
            if (currentUser != null && currentUser.Role == UserRole.مستخدم_عادي)
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }

            SetupComboBoxes();
            LoadDonorsData();
            SetPanelMode(PanelMode.View);
            
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

                // استثناء الحقول متعددة الأسطر (للسماح بالنزول لسطر جديد)
                if (this.ActiveControl == txtAddress || this.ActiveControl == txtNotes)
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

        private void frmDonors_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dashboard = Application.OpenForms.OfType<frmDashBoard>().FirstOrDefault();
            if (dashboard != null) dashboard.Show();
        }

        private void SetupComboBoxes()
        {
            cmbSearch.Items.Clear();
            cmbSearch.Items.Add("اسم المتبرع");
            cmbSearch.Items.Add("رقم الهاتف");
            cmbSearch.SelectedIndex = 0;

            cmbDonorType.DataSource = Enum.GetValues(typeof(DonorType));
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

            bool hasSelected = (_selectedDonor != null);
            btnEdit.Visible = (mode == PanelMode.View && hasSelected && canModify);
            btnDelete.Visible = (mode == PanelMode.View && hasSelected && canModify);

            switch (mode)
            {
                case PanelMode.View:
                    lblPanelTitle.Text = "تفاصيل المتبرع";
                    DisplayDonorDetails(_selectedDonor);
                    break;
                case PanelMode.Add:
                    lblPanelTitle.Text = "إضافة متبرع جديد";
                    ClearInputFields();
                    break;
                case PanelMode.Edit:
                    lblPanelTitle.Text = "تعديل بيانات المتبرع";
                    FillInputFieldsWithSelectedDonor();
                    break;
            }
            
            if (currentUser != null && currentUser.Role == UserRole.مستخدم_عادي)
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
        }

        private void LoadDonorsData()
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            string searchType = cmbSearch.SelectedItem?.ToString();

            var query = DataService.GetDonors().AsQueryable();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                if (searchType == "اسم المتبرع")
                    query = query.Where(d => d.FullName.ToLower().Contains(searchTerm));
                else if (searchType == "رقم الهاتف")
                    query = query.Where(d => d.Phone.Contains(searchTerm));
            }

            var items = query.Select(d => new {
                d.DonorID,
                d.FullName,
                d.Phone,
                DonorType = d.DonorType.ToString(),
                d.RegistrationDate
            }).ToList();

            dgvDonorsList.DataSource = null;
            dgvDonorsList.DataSource = items;
            CustomizeDataGridView();
        }

        private void CustomizeDataGridView()
        {
            if (dgvDonorsList.Columns.Count > 0)
            {
                dgvDonorsList.Columns["DonorID"].HeaderText = "رقم المتبرع";
                dgvDonorsList.Columns["FullName"].HeaderText = "اسم المتبرع";
                dgvDonorsList.Columns["Phone"].HeaderText = "رقم الهاتف";
                dgvDonorsList.Columns["DonorType"].HeaderText = "النوع";
                dgvDonorsList.Columns["RegistrationDate"].HeaderText = "تاريخ التسجيل";
                dgvDonorsList.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void DisplayDonorDetails(Donor donor)
        {
            if (donor != null)
            {
                lblFullNameText.Text = donor.FullName;
                lblPhoneText.Text = donor.Phone;
                lblEmailText.Text = string.IsNullOrWhiteSpace(donor.Email) ? "----" : donor.Email;
                lblDonorTypeText.Text = donor.DonorType.ToString();
                lblAddressText.Text = string.IsNullOrWhiteSpace(donor.Address) ? "----" : donor.Address;
                lblNotesText.Text = string.IsNullOrWhiteSpace(donor.Notes) ? "----" : donor.Notes;
            }
            else
            {
                lblFullNameText.Text = "----";
                lblPhoneText.Text = "----";
                lblEmailText.Text = "----";
                lblDonorTypeText.Text = "----";
                lblAddressText.Text = "----";
                lblNotesText.Text = "----";
            }
        }

        private void ClearInputFields()
        {
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtNotes.Clear();
            if (cmbDonorType.Items.Count > 0) cmbDonorType.SelectedIndex = 0;
        }

        private void FillInputFieldsWithSelectedDonor()
        {
            if (_selectedDonor != null)
            {
                txtFullName.Text = _selectedDonor.FullName;
                txtPhone.Text = _selectedDonor.Phone;
                txtEmail.Text = _selectedDonor.Email;
                cmbDonorType.SelectedItem = _selectedDonor.DonorType;
                txtAddress.Text = _selectedDonor.Address;
                txtNotes.Text = _selectedDonor.Notes;
            }
        }

        private void dgvDonorsList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDonorsList.CurrentRow != null)
            {
                string selectedId = dgvDonorsList.CurrentRow.Cells["DonorID"].Value.ToString();
                _selectedDonor = DataService.GetDonors().FirstOrDefault(d => d.DonorID == selectedId);
            }
            else
            {
                _selectedDonor = null;
            }

            if (_currentMode == PanelMode.View)
            {
                SetPanelMode(PanelMode.View);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                new frmAlert("يجب إدخال اسم المتبرع ورقم الهاتف.").ShowDialog();
                return;
            }

            if (_currentMode == PanelMode.Add)
            {
                int lastIdNumber = DataService.GetDonors().Any()
                    ? DataService.GetDonors().Select(d => int.Parse(d.DonorID.Substring(2))).Max()
                    : 0;
                string newId = "DN" + (lastIdNumber + 1).ToString("D3");

                var newDonor = new Donor
                {
                    DonorID = newId,
                    FullName = txtFullName.Text.Trim(),
                    Phone = txtPhone.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    DonorType = (DonorType)Enum.Parse(typeof(DonorType), cmbDonorType.SelectedItem.ToString()),
                    Address = txtAddress.Text.Trim(),
                    RegistrationDate = DateTime.Now,
                    Notes = txtNotes.Text.Trim()
                };

                DataService.AddDonor(newDonor);
                new frmAlert("تمت إضافة المتبرع بنجاح.").ShowDialog();
            }
            else if (_currentMode == PanelMode.Edit)
            {
                _selectedDonor.FullName = txtFullName.Text.Trim();
                _selectedDonor.Phone = txtPhone.Text.Trim();
                _selectedDonor.Email = txtEmail.Text.Trim();
                _selectedDonor.DonorType = (DonorType)Enum.Parse(typeof(DonorType), cmbDonorType.SelectedItem.ToString());
                _selectedDonor.Address = txtAddress.Text.Trim();
                _selectedDonor.Notes = txtNotes.Text.Trim();

                DataService.UpdateDonor(_selectedDonor);
                new frmAlert("تم تعديل بيانات المتبرع بنجاح.").ShowDialog();
            }

            LoadDonorsData();
            SetPanelMode(PanelMode.View);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDonor == null) return;

            frmConfirm confirmDialog = new frmConfirm($"هل أنت متأكد من أنك تريد حذف المتبرع '{_selectedDonor.FullName}'؟");
            if (confirmDialog.ShowDialog() == DialogResult.Yes)
            {
                DataService.DeleteDonor(_selectedDonor.DonorID);
                new frmAlert("تم حذف المتبرع بنجاح.").ShowDialog();
                LoadDonorsData();
                SetPanelMode(PanelMode.View);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) { LoadDonorsData(); }
        private void btnClear_Click(object sender, EventArgs e) { txtSearch.Clear(); LoadDonorsData(); }
        private void btnAddNew_Click(object sender, EventArgs e) { SetPanelMode(PanelMode.Add); }
        private void btnEdit_Click(object sender, EventArgs e) { if (_selectedDonor != null) SetPanelMode(PanelMode.Edit); }
        private void btnCancel_Click(object sender, EventArgs e) { SetPanelMode(PanelMode.View); }
    }
}
