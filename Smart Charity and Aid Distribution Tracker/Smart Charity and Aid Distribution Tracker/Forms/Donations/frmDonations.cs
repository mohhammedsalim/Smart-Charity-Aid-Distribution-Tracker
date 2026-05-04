using Smart_Charity_and_Aid_Distribution_Tracker.Donations.DonorManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Donations
{
    public partial class frmDonations : Form
    {
        public frmDonations()
        {
            InitializeComponent();
        }

        private void frmDonations_FormClosed(object sender, FormClosedEventArgs e)
        {
            var dashboard = Application.OpenForms.OfType<frmDashBoard>().FirstOrDefault();
            if (dashboard != null)
            {
                dashboard.Show();
            }
            else
            {
                frmDashBoard newDashboardForm = new frmDashBoard();
                newDashboardForm.Show();
            }

        }

        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegisterNewDonation_Click(object sender, EventArgs e)
        {
            frmRegisterNewDonation registerNewDonationForm = new frmRegisterNewDonation();
            registerNewDonationForm.ShowDialog();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            frmDeleteSelected deleteSelectedForm = new frmDeleteSelected(); 
            deleteSelectedForm.ShowDialog();
        }

        private void btnDonorManagement_Click(object sender, EventArgs e)
        {
            frmDonorManagement donorManagementForm = new frmDonorManagement();
            donorManagementForm.ShowDialog();
        }

        private void btnAdjustingSelector_Click(object sender, EventArgs e)
        {
            frmDonationModification frmDonationModification = new frmDonationModification();
            frmDonationModification.ShowDialog();
        }

        
    }
}
