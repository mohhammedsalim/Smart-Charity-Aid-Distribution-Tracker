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
        private Form activeForm = null;
        private Panel pnlContainer;

        public frmDashBoard(string currentUserName)
        {
            InitializeComponent();
            InitializeContainer();
            SetupHomeButton();

            lblUserName.Text = currentUserName;
        }

        private void HighlightActiveButton(Guna.UI2.WinForms.Guna2Button activeButton)
        {
            btnBeneficiaries.FillColor = Color.FromArgb(240, 240, 240);
            btnInventory.FillColor = Color.FromArgb(240, 240, 240);
            btnDonations.FillColor = Color.FromArgb(240, 240, 240);
            btnDisbursement.FillColor = Color.FromArgb(240, 240, 240);
            btnReports.FillColor = Color.FromArgb(240, 240, 240);
            btnUsers.FillColor = Color.FromArgb(240, 240, 240);

            if (activeButton != null)
            {
                activeButton.FillColor = Color.FromArgb(235, 248, 235);
            }
        }

        private void InitializeContainer()
        {
            pnlContainer = new Panel();
            pnlContainer.Location = new Point(0, 65);
            pnlContainer.Size = new Size(this.ClientSize.Width, this.ClientSize.Height - 65 - 38);
            pnlContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContainer.BackColor = this.BackColor;

            this.Controls.Add(pnlContainer);
            pnlContainer.BringToFront();

            pnlContainer.Visible = false;
        }

        private void SetupHomeButton()
        {
            lblLogo.Cursor = Cursors.Hand;
            pictureBox7.Cursor = Cursors.Hand;

            lblLogo.Click += (sender, e) => ShowDashboardHome();
            pictureBox7.Click += (sender, e) => ShowDashboardHome();
        }

        private void ShowDashboardHome()
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = null;
            }
            pnlContainer.Visible = false;
            HighlightActiveButton(null);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            childForm.FormClosed += (sender, e) =>
            {
                pnlContainer.Visible = false;
                activeForm = null;
            };

            pnlContainer.Visible = true;
            pnlContainer.BringToFront();
            pnlContainer.Controls.Add(childForm);
            pnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnRegisterNewDonation_Click(object sender, EventArgs e)
        {
            frmRegisterNewDonation registerDonationForm = new frmRegisterNewDonation();
            registerDonationForm.ShowDialog();
        }

        private void btnNewDisbursementProcess_Click(object sender, EventArgs e)
        {
            frmNewDisbursementProcess newDisbursementForm = new frmNewDisbursementProcess();
            newDisbursementForm.ShowDialog();
        }

        private void btnAddNewBeneficiary_Click(object sender, EventArgs e)
        {
            frmAddBeneficiary addBeneficiaryForm = new frmAddBeneficiary();
            addBeneficiaryForm.ShowDialog();
        }

        private void btnBeneficiaries_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnBeneficiaries);
            OpenChildForm(new frmBeneficiarie());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnInventory);
            OpenChildForm(new frmInventory());
        }

        private void btnDonations_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnDonations);
            OpenChildForm(new frmDonations());
        }

        private void btnDisbursement_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnDisbursement);
            OpenChildForm(new frmDistrbution());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnReports);
            OpenChildForm(new frmReports());
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            HighlightActiveButton(btnUsers);
            OpenChildForm(new frmUser());
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
