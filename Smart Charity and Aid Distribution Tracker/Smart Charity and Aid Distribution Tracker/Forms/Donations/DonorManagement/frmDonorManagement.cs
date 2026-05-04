using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Donations.DonorManagement
{
    public partial class frmDonorManagement : Form
    {
        public frmDonorManagement()
        {
            InitializeComponent();
        }

        private void btnBackToDonationsManagement_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewDonor_Click(object sender, EventArgs e)
        {
            frmAddNewDonor addNewDonorForm = new frmAddNewDonor();
            addNewDonorForm.ShowDialog();
        }

        private void btnDonorAdjustment_Click(object sender, EventArgs e)
        {
            frmDonorAdjustment donorAdjustmentForm = new frmDonorAdjustment();
            donorAdjustmentForm.ShowDialog();
        }

        private void btnDeleteDonor_Click(object sender, EventArgs e)
        {
            frmDeleteDonor deleteDonorForm = new frmDeleteDonor();
            deleteDonorForm.ShowDialog();
        }
    }
}
