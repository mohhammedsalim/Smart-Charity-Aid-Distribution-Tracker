using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Users
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            frmAddUser frmAddUser = new frmAddUser();
            frmAddUser.ShowDialog();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            frmDeleteUser frmDeleteUser = new frmDeleteUser();  
            frmDeleteUser.ShowDialog();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            frnResetPassword frmResetPassword = new frnResetPassword();
            frmResetPassword.ShowDialog();
        }

        private void btnDataModification_Click(object sender, EventArgs e)
        {
            frmfrmEditUser frmEditUser = new frmfrmEditUser();
            frmEditUser.ShowDialog();
        }
    }
}
