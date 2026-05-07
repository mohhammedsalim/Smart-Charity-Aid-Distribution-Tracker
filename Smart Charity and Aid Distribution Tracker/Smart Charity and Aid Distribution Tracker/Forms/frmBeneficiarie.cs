using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using System;
using System.Collections.Generic; // مهم لإضافة هذا السطر
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmBeneficiarie : Form
    {
        // متغير لتخزين وضع اللوحة الحالية (عرض، إضافة، تعديل)
        private enum PanelMode { View, Add, Edit }
        private PanelMode _currentMode;


        // متغير لتخزين المستفيد المحدد حالياً
        private Beneficiary _selectedBeneficiary;

        private string GenerateNewBeneficiaryId()
        {
            var allBeneficiaries = DataService.GetBeneficiaries();
            if (!allBeneficiaries.Any())
            {
                return "B001"; // أول مستفيد في النظام
            }

            // هذا الكود يستخرج الرقم من أكبر ID ويزيده بواحد
            // مثال: إذا كان أكبر ID هو "B023", فسيقوم بإنشاء "B024"
            int maxIdNumber = allBeneficiaries
                .Select(b => int.Parse(b.BeneficiaryID.Substring(1))) // تحويل "B001" -> 1
                .Max();

            return "B" + (maxIdNumber + 1).ToString("D3"); // "D3" تضمن وجود 3 أرقام مثل 001, 024
        }

        public frmBeneficiarie()
        {
            InitializeComponent();
        }

        // --- 1. أحداث تحميل وإغلاق الفورم ---

        private void frmBeneficiarie_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; // اجعل الفورم يلتقط ضغات المفاتيح قبل عناصر التحكم
            // إعداد عناصر التحكم عند التحميل لأول مرة
            SetupSearchComboBox();
            LoadBeneficiaries(); // تم تغيير اسم الدالة للتوحيد
            SetPanelMode(PanelMode.View); // ابدأ بوضع العرض
        }

        private void frmBeneficiarie_FormClosed(object sender, FormClosedEventArgs e)
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

            // قائمة بجميع عناصر الإدخال
            var inputControls = new List<Control> { txtFullName, txtNationalID, txtPhone, txtAddress, numFamilySize, cmbSocialStatus, txtNeedReason, dtpRegistrationDate, txtNotes };
            // قائمة بجميع عناصر العرض (Labels)
            var displayLabels = new List<Control> { lblFullNameText, lblNationalIDText, lblPhoneText, lblAddressText, lblFamilySizeText, lblSocialStatusText, lblNeedReasonText, lblRegistrationDateText, lblNotesText };

            // إظهار/إخفاء عناصر الإدخال مقابل عناصر العرض
            bool isViewMode = (mode == PanelMode.View);
            foreach (var control in inputControls) control.Visible = !isViewMode;
            foreach (var label in displayLabels) label.Visible = isViewMode;

            // التحكم في الأزرار بناءً على الوضع
            btnAddNew.Visible = isViewMode;
            btnEdit.Visible = isViewMode && _selectedBeneficiary != null; // لا تظهر "تعديل" إذا لم يتم تحديد أي شيء
            btnDelete.Visible = isViewMode && _selectedBeneficiary != null; // لا تظهر "حذف" إذا لم يتم تحديد أي شيء
            btnSave.Visible = !isViewMode;
            btnCancel.Visible = !isViewMode;

            // تحديث عنوان اللوحة وتفريغ/ملء الحقول
            switch (mode)
            {
                case PanelMode.View:
                    lblPanelTitle.Text = "تفاصيل المستفيد";
                    DisplayBeneficiaryDetails(_selectedBeneficiary);
                    break;

                case PanelMode.Add:
                    lblPanelTitle.Text = "إضافة مستفيد جديد";
                    ClearInputFields();
                    txtFullName.Focus(); // التركيز على أول حقل
                    break;

                case PanelMode.Edit:
                    lblPanelTitle.Text = "تعديل بيانات المستفيد";
                    FillInputFieldsWithSelectedBeneficiary();
                    txtFullName.Focus(); // التركيز على أول حقل
                    break;
            }
        }

        // --- 3. وظائف مساعدة للبيانات والواجهة ---

        private void LoadBeneficiaries()
        {
            // حفظ السجل المحدد حالياً (إن وجد)
            string selectedId = _selectedBeneficiary?.BeneficiaryID ?? null;

            dgvBeneficiariesList.DataSource = null;
            dgvBeneficiariesList.DataSource = DataService.GetBeneficiaries();
            //CustomizeDataGridView();

            // محاولة إعادة تحديد نفس السجل بعد التحديث
            if (selectedId != null)
            {
                foreach (DataGridViewRow row in dgvBeneficiariesList.Rows)
                {
                    // استخدم nameof لضمان الوصول الصحيح للخلية
                    if (Convert.ToString(row.Cells[nameof(Beneficiary.BeneficiaryID)].Value) == selectedId)
                    {
                        row.Selected = true;
                        // قم بتعيين الخلية الحالية إلى أول عمود مرئي (الاسم الكامل)
                        dgvBeneficiariesList.CurrentCell = row.Cells[nameof(Beneficiary.FullName)];
                        break;
                    }
                }


            }
        }

        //private void CustomizeDataGridView()
        //{
        //    // إخفاء الأعمدة غير المرغوب فيها
        //    dgvBeneficiariesList.Columns["Id"].Visible = false;
        //    dgvBeneficiariesList.Columns["Notes"].Visible = false;
        //    dgvBeneficiariesList.Columns["NeedReason"].Visible = false;
        //    dgvBeneficiariesList.Columns["RegistrationDate"].Visible = false;

        //    // تغيير عناوين الأعمدة
        //    dgvBeneficiariesList.Columns["FullName"].HeaderText = "الاسم الكامل";
        //    dgvBeneficiariesList.Columns["NationalID"].HeaderText = "الرقم الوطني";
        //    dgvBeneficiariesList.Columns["Phone"].HeaderText = "رقم الهاتف";
        //    dgvBeneficiariesList.Columns["Address"].HeaderText = "العنوان";
        //    dgvBeneficiariesList.Columns["FamilySize"].HeaderText = "عدد الأفراد";
        //    dgvBeneficiariesList.Columns["SocialStatus"].HeaderText = "الحالة الاجتماعية";

        //    // تعديل عرض الأعمدة
        //    dgvBeneficiariesList.Columns["FullName"].Width = 200;
        //    dgvBeneficiariesList.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //}

        private void DisplayBeneficiaryDetails(Beneficiary b)
        {
            if (b != null)
            {
                lblFullNameText.Text = b.FullName;
                lblNationalIDText.Text = b.NationalID;
                lblPhoneText.Text = b.Phone;
                lblAddressText.Text = b.Address;
                lblFamilySizeText.Text = b.FamilySize.ToString();
                lblSocialStatusText.Text = b.SocialStatus;
                lblNeedReasonText.Text = b.NeedReason;
                lblRegistrationDateText.Text = b.RegistrationDate.ToShortDateString();
                lblNotesText.Text = b.Notes;
            }
            else
            {
                // تفريغ الحقول إذا لم يكن هناك مستفيد محدد
                var displayLabels = new List<Label> { lblFullNameText, lblNationalIDText, lblPhoneText, lblAddressText, lblFamilySizeText, lblSocialStatusText, lblNeedReasonText, lblRegistrationDateText, lblNotesText };
                foreach (var label in displayLabels) label.Text = "----";
            }
        }

        private void ClearInputFields()
        {
            txtFullName.Clear();
            txtNationalID.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            numFamilySize.Value = 0;
            cmbSocialStatus.SelectedIndex = -1; // مسح التحديد
            txtNeedReason.Clear();
            dtpRegistrationDate.Value = DateTime.Now;
            txtNotes.Clear();
        }

        private void FillInputFieldsWithSelectedBeneficiary()
        {
            if (_selectedBeneficiary != null)
            {
                txtFullName.Text = _selectedBeneficiary.FullName;
                txtNationalID.Text = _selectedBeneficiary.NationalID;
                txtPhone.Text = _selectedBeneficiary.Phone;
                txtAddress.Text = _selectedBeneficiary.Address;
                numFamilySize.Value = _selectedBeneficiary.FamilySize;
                if (cmbSocialStatus.Items.Contains(_selectedBeneficiary.SocialStatus))
                {
                    cmbSocialStatus.SelectedItem = _selectedBeneficiary.SocialStatus;
                }
                else
                {
                    cmbSocialStatus.SelectedIndex = -1; // إذا لم يتم العثور على القيمة، لا تحدد أي شيء
                }
                txtNeedReason.Text = _selectedBeneficiary.NeedReason;
                dtpRegistrationDate.Value = _selectedBeneficiary.RegistrationDate;
                txtNotes.Text = _selectedBeneficiary.Notes;
            }
        }

        private void SetupSearchComboBox()
        {
            // إعداد قائمة البحث
            cmbSearch.Items.Add("الاسم الكامل");
            cmbSearch.Items.Add("الرقم الوطني");
            cmbSearch.Items.Add("رقم الهاتف");
            cmbSearch.SelectedIndex = 0; // تحديد "الاسم الكامل" كخيار افتراضي
        }

        // --- 4. أحداث الأزرار والجدول ---

        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // الكود الجديد والمحصّن
        private void dgvBeneficiariesList_SelectionChanged(object sender, EventArgs e)
        {
            // --- التحقق الأهم: هل الجدول فارغ؟ ---
            if (dgvBeneficiariesList.Rows.Count == 0 || dgvBeneficiariesList.CurrentRow == null)
            {
                // إذا كان الجدول فارغاً، لا يوجد شيء لعرضه
                _selectedBeneficiary = null;
            }
            else if (dgvBeneficiariesList.CurrentRow.DataBoundItem is Beneficiary selected)
            {
                // إذا كان هناك صف محدد، قم بتعيين المستفيد
                _selectedBeneficiary = selected;
            }
            else
            {
                // حالات أخرى غير متوقعة
                _selectedBeneficiary = null;
            }

            // الآن، قم بتحديث الواجهة بناءً على _selectedBeneficiary
            // هذا الجزء سيعمل بشكل صحيح سواء كان المتغير null أو يحتوي على بيانات
            if (_currentMode == PanelMode.View)
            {
                DisplayBeneficiaryDetails(_selectedBeneficiary);
                btnEdit.Visible = (_selectedBeneficiary != null);
                btnDelete.Visible = (_selectedBeneficiary != null);
            }
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            _selectedBeneficiary = null; // إلغاء تحديد أي مستفيد حالي عند الإضافة
            dgvBeneficiariesList.ClearSelection();
            SetPanelMode(PanelMode.Add);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_selectedBeneficiary != null)
            {
                SetPanelMode(PanelMode.Edit);
            }
            else
            {
                new frmAlert("الرجاء تحديد مستفيد أولاً لتعديل بياناته.").ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // إعادة تحديد المستفيد الذي كان محدداً قبل الضغط على "إضافة" أو "تعديل"
            if (dgvBeneficiariesList.SelectedRows.Count > 0)
            {
                _selectedBeneficiary = dgvBeneficiariesList.SelectedRows[0].DataBoundItem as Beneficiary;
            }
            else
            {
                _selectedBeneficiary = null;
            }
            SetPanelMode(PanelMode.View);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // --- 1. التحقق من صحة المدخلات ---
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                new frmAlert("يرجى إدخال الاسم الكامل للمستفيد.").ShowDialog();
                txtFullName.Focus();
                return; // إيقاف التنفيذ
            }
            if (string.IsNullOrWhiteSpace(txtNationalID.Text))
            {
                new frmAlert("يرجى إدخال الرقم الوطني للمستفيد.").ShowDialog();
                txtNationalID.Focus();
                return;
            }

            // --- 2. تحديد وضع التشغيل (إضافة أو تعديل) ---
            if (_currentMode == PanelMode.Add)
            {
                // --- وضع الإضافة ---
                var newBeneficiary = new Beneficiary
                {
                    BeneficiaryID = GenerateNewBeneficiaryId(),
                    FullName = txtFullName.Text,
                    NationalID = txtNationalID.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    FamilySize = (int)numFamilySize.Value,
                    SocialStatus = cmbSocialStatus.Text,
                    NeedReason = txtNeedReason.Text,
                    RegistrationDate = dtpRegistrationDate.Value,
                    Notes = txtNotes.Text
                };

                DataService.AddBeneficiary(newBeneficiary);
                _selectedBeneficiary = newBeneficiary; // تحديد المستفيد الجديد بعد إضافته
                new frmAlert("تمت إضافة المستفيد بنجاح!").ShowDialog();
            }
            else if (_currentMode == PanelMode.Edit)
            {
                // --- وضع التعديل ---
                if (_selectedBeneficiary != null)
                {
                    _selectedBeneficiary.FullName = txtFullName.Text;
                    _selectedBeneficiary.NationalID = txtNationalID.Text;
                    _selectedBeneficiary.Phone = txtPhone.Text;
                    _selectedBeneficiary.Address = txtAddress.Text;
                    _selectedBeneficiary.FamilySize = (int)numFamilySize.Value;
                    _selectedBeneficiary.SocialStatus = cmbSocialStatus.Text;
                    _selectedBeneficiary.NeedReason = txtNeedReason.Text;
                    _selectedBeneficiary.RegistrationDate = dtpRegistrationDate.Value;
                    _selectedBeneficiary.Notes = txtNotes.Text;

                    DataService.UpdateBeneficiary(_selectedBeneficiary);
                    new frmAlert("تم تعديل بيانات المستفيد بنجاح!").ShowDialog();
                }
            }

            // --- 3. تحديث الواجهة ---
            LoadBeneficiaries();    // إعادة تحميل القائمة لإظهار التغييرات
            SetPanelMode(PanelMode.View);     // العودة إلى وضع العرض
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedBeneficiary == null)
            {
                new frmAlert("يرجى تحديد مستفيد لحذفه أولاً.").ShowDialog();
                return;
            }

            frmConfirm confirmDialog = new frmConfirm($"هل أنت متأكد من أنك تريد حذف المستفيد '{_selectedBeneficiary.FullName}'؟ لا يمكن التراجع عن هذا الإجراء.");

            if (confirmDialog.ShowDialog() == DialogResult.Yes)
            {
                DataService.DeleteBeneficiary(_selectedBeneficiary.BeneficiaryID);
                new frmAlert("تم حذف المستفيد بنجاح.").ShowDialog();

                _selectedBeneficiary = null; // مسح التحديد بعد الحذف
                LoadBeneficiaries();
                SetPanelMode(PanelMode.View);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // منطق البحث الفعلي
            string searchTerm = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadBeneficiaries();
                return;
            }

            var allBeneficiaries = DataService.GetBeneficiaries();
            List<Beneficiary> filteredList = new List<Beneficiary>();

            switch (cmbSearch.SelectedItem.ToString())
            {
                case "الاسم الكامل":
                    filteredList = allBeneficiaries.Where(b => b.FullName.ToLower().Contains(searchTerm)).ToList();
                    break;
                case "الرقم الوطني":
                    filteredList = allBeneficiaries.Where(b => b.NationalID.Contains(searchTerm)).ToList();
                    break;
                case "رقم الهاتف":
                    filteredList = allBeneficiaries.Where(b => b.Phone.Contains(searchTerm)).ToList();
                    break;
            }

            dgvBeneficiariesList.DataSource = null;
            dgvBeneficiariesList.DataSource = filteredList;
            //CustomizeDataGridView();

            // ... بعد تحديث مصدر البيانات للجدول
            if (filteredList.Count == 0)
            {
                new frmAlert("لم يتم العثور على نتائج تطابق بحثك.").ShowDialog();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbSearch.SelectedIndex = 0;
            LoadBeneficiaries(); // إعادة تحميل القائمة الكاملة
            txtSearch.Focus();
        }

        private void frmBeneficiarie_KeyDown(object sender, KeyEventArgs e)
        {
            // إذا كان المستخدم في وضع الإضافة أو التعديل
            if (_currentMode == PanelMode.Add || _currentMode == PanelMode.Edit)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // إيقاف صوت "الدينغ" المزعج عند الضغط على Enter
                    e.SuppressKeyPress = true;
                    // الانتقال إلى الحقل التالي
                    this.SelectNextControl(this.ActiveControl, true, true, true, true);
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    // الضغط على Escape يعادل الضغط على زر "إلغاء"
                    btnCancel.PerformClick();
                }
            }
        }

        private void txtNotes_KeyDown(object sender, KeyEventArgs e)
        {
            // إذا ضغط المستخدم على Enter داخل حقل الملاحظات، لا تنتقل للحقل التالي
            if (e.KeyCode == Keys.Enter)
            {
                // اسمح للـ TextBox بمعالجة ضغطة Enter (لإنشاء سطر جديد)
                // ولا تمررها إلى الفورم
                e.Handled = true;
            }
        }

        // هذه هي الدالة الجديدة التي أنشأتها من المصمم
        // الكود الجديد والموثوق
        private void dgvBeneficiariesList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // التأكد من أن الجدول يحتوي على أعمدة قبل محاولة تخصيصها
            if (dgvBeneficiariesList.Columns.Count == 0) return;

            // --- استخدام nameof لضمان تطابق الأسماء ---
            dgvBeneficiariesList.Columns[nameof(Beneficiary.BeneficiaryID)].Visible = false;
            dgvBeneficiariesList.Columns[nameof(Beneficiary.Notes)].Visible = false;
            dgvBeneficiariesList.Columns[nameof(Beneficiary.NeedReason)].Visible = false;
            dgvBeneficiariesList.Columns[nameof(Beneficiary.RegistrationDate)].Visible = false;

            // تغيير عناوين الأعمدة
            dgvBeneficiariesList.Columns[nameof(Beneficiary.FullName)].HeaderText = "الاسم الكامل";
            dgvBeneficiariesList.Columns[nameof(Beneficiary.NationalID)].HeaderText = "الرقم الوطني";
            dgvBeneficiariesList.Columns[nameof(Beneficiary.Phone)].HeaderText = "رقم الهاتف";
            dgvBeneficiariesList.Columns[nameof(Beneficiary.Address)].HeaderText = "العنوان";
            dgvBeneficiariesList.Columns[nameof(Beneficiary.FamilySize)].HeaderText = "عدد الأفراد";
            dgvBeneficiariesList.Columns[nameof(Beneficiary.SocialStatus)].HeaderText = "الحالة الاجتماعية";

            // تعديل عرض الأعمدة
            dgvBeneficiariesList.Columns[nameof(Beneficiary.FullName)].Width = 200;
            dgvBeneficiariesList.Columns[nameof(Beneficiary.Address)].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


    }
}
