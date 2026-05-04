using Smart_Charity_and_Aid_Distribution_Tracker.Data;
using Smart_Charity_and_Aid_Distribution_Tracker.Distrbution;
using Smart_Charity_and_Aid_Distribution_Tracker.Donations;
using Smart_Charity_and_Aid_Distribution_Tracker.Forms.DashBoard;
using Smart_Charity_and_Aid_Distribution_Tracker.Reports;
using Smart_Charity_and_Aid_Distribution_Tracker.Services;
using Smart_Charity_and_Aid_Distribution_Tracker.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    public partial class frmDashBoard : Form
    {
        private bool isLoggingOut = false;

        public frmDashBoard()
        {
            InitializeComponent();
        }
        public frmDashBoard(string username)
        {
            InitializeComponent();
            lblUserName.Text = username;
        }

        private void frmDashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoggingOut)
            {
                return;
            }

            DialogResult result = frmConfirm.Show(
                "هل أنت متأكد أنك تريد الخروج من النظام؟",
                "تأكيد الخروج",
                MessageBoxIcon.Question
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmDashBoard_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isLoggingOut)
            {
                UserService.Logout();
                var loginForm = Application.OpenForms.OfType<frmLogin>().FirstOrDefault();
                if (loginForm != null)
                {
                    loginForm.Show();
                }
                else
                {
                    loginForm = new frmLogin();
                    loginForm.Show();
                }
            }
            else 
            {
                Environment.Exit(0);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = frmConfirm.Show(
            "هل أنت متأكد أنك تريد تسجيل الخروج؟",
            "تأكيد تسجيل الخروج",
            MessageBoxIcon.Question
        );

            if (result == DialogResult.Yes)
            {
                isLoggingOut = true;
                this.Close();
            }
        }

        private void btnBeneficiaries_Click(object sender, EventArgs e)
        {
            frmBeneficiarie beneficiariesForm = new frmBeneficiarie();
            beneficiariesForm.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory inventoryForm = new frmInventory();
            inventoryForm.Show();
            this.Hide();
        }

        private void btnDonations_Click(object sender, EventArgs e)
        {
            frmDonations donationsForm = new frmDonations();
            donationsForm.Show();
            this.Hide();
        }

        private void btnDisbursement_Click(object sender, EventArgs e)
        {
            frmDistrbution distrbutionForm = new frmDistrbution();  
            distrbutionForm.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            frmReports reportForm = new frmReports();
            reportForm.Show();
            this.Hide();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUser usersForm = new frmUser();
            usersForm.Show();
            this.Hide();
        }

        
    }
}
