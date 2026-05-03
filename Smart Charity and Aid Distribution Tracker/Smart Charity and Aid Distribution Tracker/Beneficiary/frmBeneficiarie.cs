using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    public partial class frmBeneficiarie : Form
    {
        public frmBeneficiarie()
        {
            InitializeComponent();
        }

        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            Form dashboardForm = Application.OpenForms["frmDashBoard"];

            if (dashboardForm != null)
            {
                dashboardForm.Show();
            }
            else
            {
                frmDashBoard newDashboardForm = new frmDashBoard();
                newDashboardForm.Show();
            }
            this.Close();
        }

        private void btnAddNewBeneficiary_Click(object sender, EventArgs e)
        {
            frmAddBeneficiary addBeneficiaryForm = new frmAddBeneficiary();
            addBeneficiaryForm.ShowDialog();
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

        private void frmBeneficiarie_Load(object sender, EventArgs e)
        {

        }

        private void lblResearchValue_Click(object sender, EventArgs e)
        {

        }
    }
}
