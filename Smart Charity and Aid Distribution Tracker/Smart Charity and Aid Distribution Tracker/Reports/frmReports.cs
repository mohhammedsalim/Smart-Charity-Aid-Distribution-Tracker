using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Reports
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {

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
    }
}
