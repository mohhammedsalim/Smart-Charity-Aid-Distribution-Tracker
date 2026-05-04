using Smart_Charity_and_Aid_Distribution_Tracker.Data;
using Smart_Charity_and_Aid_Distribution_Tracker.Forms.Login;
using Smart_Charity_and_Aid_Distribution_Tracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Smart_Charity_and_Aid_Distribution_Tracker.Forms.Login.frmAlert;

namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    public partial class frmAddBeneficiary : Form
    {
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void SetupEnterKeyNavigation()
        {
            txtFullName.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txtNationalID.Focus(); };
            txtNationalID.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txtPhone.Focus(); };
            txtPhone.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txtAddress.Focus(); };
            txtAddress.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) numFamilySize.Focus(); };
            numFamilySize.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) cmbSocialStatus.Focus(); };
            cmbSocialStatus.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txtNeedReason.Focus(); };
            txtNeedReason.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) dtpRegistrationDate.Focus(); };
            dtpRegistrationDate.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) txtNotes.Focus(); };
            txtNotes.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) btnSave.Focus(); };
        }
        //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public frmAddBeneficiary()
        {
            InitializeComponent();

            SetupEnterKeyNavigation();
        }

        private void frmAddBeneficiary_Load(object sender, EventArgs e)
        {
            dtpRegistrationDate.Value = DateTime.Now;
            if (cmbSocialStatus.Items.Count > 0)
            {
                cmbSocialStatus.SelectedIndex = 0;
            }

            txtFullName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                frmAlert.Show("الرجاء إدخال الاسم الكامل للمستفيد.", AlertType.Warning);
                txtFullName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNationalID.Text))
            {
                frmAlert.Show("الرجاء إدخال الرقم الوطني للمستفيد.", AlertType.Warning);
                txtNationalID.Focus();
                return;
            }
            if (txtNationalID.Text.Trim().Length != 12)
            {
                frmAlert.Show("يجب أن يتكون الرقم الوطني من 12 رقماً.", AlertType.Warning);
                txtNationalID.Focus();
                return;
            }
            if (!txtNationalID.Text.Trim().All(char.IsDigit))
            {
                frmAlert.Show("يجب أن يحتوي الرقم الوطني على أرقام فقط.", AlertType.Warning);
                txtNationalID.Focus();
                return;
            }
            if (cmbSocialStatus.SelectedItem == null)
            {
                frmAlert.Show("الرجاء اختيار الحالة الاجتماعية.", AlertType.Warning);
                cmbSocialStatus.Focus();
                return;
            }

            string nationalId = txtNationalID.Text.Trim();
            if (DataStore.B.Any(b => b.NationalID == nationalId))
            {
                frmAlert.Show("هذا الرقم الوطني مسجل بالفعل في النظام لمستفيد آخر.", AlertType.Error);
                txtNationalID.Focus();
                txtNationalID.SelectAll();
                return;
            }

            try
            {
                Beneficiary newBeneficiary = new Beneficiary
                {
                    BeneficiaryID = "B" + (DataStore.Beneficiaries.Count + 1).ToString("D4"),
                    FullName = txtFullName.Text.Trim(),
                    NationalID = nationalId,
                    Phone = txtPhone.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    FamilySize = (int)numFamilySize.Value,
                    SocialStatus = cmbSocialStatus.Text,
                    NeedReason = txtNeedReason.Text.Trim(),
                    RegistrationDate = dtpRegistrationDate.Value,
                    Notes = txtNotes.Text.Trim(),
                    IsActive = true,
                    LastAidDate = null
                };

                DataStore.B.Add(newBeneficiary);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                frmAlert.Show($"حدث خطأ غير متوقع أثناء حفظ البيانات: {ex.Message}", AlertType.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
