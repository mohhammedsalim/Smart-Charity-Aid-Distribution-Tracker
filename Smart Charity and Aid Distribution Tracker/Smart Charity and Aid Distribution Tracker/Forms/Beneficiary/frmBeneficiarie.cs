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
    public partial class frmBeneficiarie : Form
    {

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //user function
        private void LoadBeneficiariesData()
        {
            try
            {

                var beneficiaries = DataStore.B.ToList();
                dgvBeneficiariesList.DataSource = null;
                dgvBeneficiariesList.DataSource = beneficiaries;

                CustomizeDataGridView();

                lblNumberBeneficiariesList.Text = beneficiaries.Count.ToString();
                dgvBeneficiariesList.AutoGenerateColumns = true; // تأكد من أن هذه الخاصية مفعلة
                dgvBeneficiariesList.Refresh(); // 2. إجبار الجدول على إعادة رسم نفسه
            }
            catch (Exception ex)
            {
                frmAlert.Show($"حدث خطأ أثناء تحميل بيانات المستفيدين: {ex.Message}", AlertType.Error);
            }
        }


        private void CustomizeDataGridView()
        {
            if (dgvBeneficiariesList.Columns.Contains("BeneficiaryID")) dgvBeneficiariesList.Columns["BeneficiaryID"].Visible = false;
            if (dgvBeneficiariesList.Columns.Contains("Phone")) dgvBeneficiariesList.Columns["Phone"].Visible = false;
            if (dgvBeneficiariesList.Columns.Contains("Address")) dgvBeneficiariesList.Columns["Address"].Visible = false;
            if (dgvBeneficiariesList.Columns.Contains("NeedReason")) dgvBeneficiariesList.Columns["NeedReason"].Visible = false;
            if (dgvBeneficiariesList.Columns.Contains("RegistrationDate")) dgvBeneficiariesList.Columns["RegistrationDate"].Visible = false;
            if (dgvBeneficiariesList.Columns.Contains("IsActive")) dgvBeneficiariesList.Columns["IsActive"].Visible = false;
            if (dgvBeneficiariesList.Columns.Contains("Notes")) dgvBeneficiariesList.Columns["Notes"].Visible = false;
            if (dgvBeneficiariesList.Columns.Contains("LastAidDate")) dgvBeneficiariesList.Columns["LastAidDate"].Visible = false;

            if (dgvBeneficiariesList.Columns.Contains("FullName")) dgvBeneficiariesList.Columns["FullName"].HeaderText = "الاسم بالكامل";
            if (dgvBeneficiariesList.Columns.Contains("NationalID")) dgvBeneficiariesList.Columns["NationalID"].HeaderText = "الرقم الوطني";
            if (dgvBeneficiariesList.Columns.Contains("FamilySize")) dgvBeneficiariesList.Columns["FamilySize"].HeaderText = "عدد الأفراد";
            if (dgvBeneficiariesList.Columns.Contains("SocialStatus")) dgvBeneficiariesList.Columns["SocialStatus"].HeaderText = "الحالة الاجتماعية";

            if (dgvBeneficiariesList.Columns.Contains("FullName")) dgvBeneficiariesList.Columns["FullName"].Width = 250;
            if (dgvBeneficiariesList.Columns.Contains("NationalID")) dgvBeneficiariesList.Columns["NationalID"].Width = 150;

            dgvBeneficiariesList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        public frmBeneficiarie()
        {
            InitializeComponent();
        }

        private void frmBeneficiarie_Load(object sender, EventArgs e)
        {
            LoadBeneficiariesData();
        }

        private void frmBeneficiarie_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dashboard = Application.OpenForms.OfType<frmDashBoard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.Show();
            }
            else
            {
                frmDashBoard newDashboard = new frmDashBoard();
                newDashboard.Show();
            }
        }
        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewBeneficiary_Click(object sender, EventArgs e)
        {
            frmAddBeneficiary addForm = new frmAddBeneficiary();

            DialogResult result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                LoadBeneficiariesData();
                frmAlert.Show("تمت إضافة المستفيد بنجاح!", AlertType.Success);
            }
        }

        private void btnDeleteBeneficiary_Click(object sender, EventArgs e)
        {
            frmDeleteBeneficiary deleteBeneficiaryForm = new frmDeleteBeneficiary();
            deleteBeneficiaryForm.ShowDialog();
        }

        private void btnViewAidLog_Click(object sender, EventArgs e)
        {
            frmBeneficiaryAidRecord beneficiaryAidRecordForm = new frmBeneficiaryAidRecord();
            beneficiaryAidRecordForm.ShowDialog();
        }

        private void btnDataModification_Click(object sender, EventArgs e)
        {
            frmEditBeneficiary editBeneficiaryForm = new frmEditBeneficiary();
            editBeneficiaryForm.ShowDialog();
        }

        private void dgvBeneficiariesList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBeneficiariesList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBeneficiariesList.SelectedRows[0];

                Beneficiary selectedBeneficiary = selectedRow.DataBoundItem as Beneficiary;

                if (selectedBeneficiary != null)
                {
                    lblFullNameText.Text = selectedBeneficiary.FullName;
                    lblNationalNumberText.Text = selectedBeneficiary.NationalID;
                    lblMobileNumberText.Text = selectedBeneficiary.Phone;
                    lblAddressText.Text = selectedBeneficiary.Address;
                    lblNumberFamilyMembersText.Text = selectedBeneficiary.FamilySize.ToString();
                    lblFileTypeText.Text = selectedBeneficiary.SocialStatus;
                    lblRegistrationDateText.Text = selectedBeneficiary.RegistrationDate.ToShortDateString();
                    lblCommentsText.Text = selectedBeneficiary.Notes;
                }
            }
        }
    }
}
