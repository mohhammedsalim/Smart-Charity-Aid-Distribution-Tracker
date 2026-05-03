using Smart_Charity_and_Aid_Distribution_Tracker.Distrbution;
using Smart_Charity_and_Aid_Distribution_Tracker.Donations;
using Smart_Charity_and_Aid_Distribution_Tracker.Reports;
using Smart_Charity_and_Aid_Distribution_Tracker.Users;
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
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void btnBeneficiaries_Click(object sender, EventArgs e)
        {
            frmBeneficiarie beneficiariesForm = new frmBeneficiarie();
            beneficiariesForm.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory inventoryForm = new frmInventory();
            inventoryForm.ShowDialog();
        }

        private void btnDonations_Click(object sender, EventArgs e)
        {
            frmDonations donationsForm = new frmDonations();
            donationsForm.ShowDialog();
        }

        private void btnDisbursement_Click(object sender, EventArgs e)
        {
            frmDistrbution disbursementForm = new frmDistrbution();
            disbursementForm.ShowDialog();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports frmReports = new frmReports();
            frmReports.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser();
            frmUser.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form loginForm = Application.OpenForms["frmLogin"];

            if (loginForm != null)
            {
                loginForm.Show();
            }
            else
            {
                frmLogin newLoginForm = new frmLogin();
                newLoginForm.Show();
            }
            this.Close();
        }
    }
}
