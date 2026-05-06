using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Distrbution
{
    public partial class frmDistrbution : Form
    {
        public frmDistrbution()
        {
            InitializeComponent();
        }

        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNewDisbursementProcess_Click(object sender, EventArgs e)
        {
            frmNewDisbursementProcess newDisbursementProcessForm = new frmNewDisbursementProcess();
            newDisbursementProcessForm.ShowDialog();
        }

        private void btnDetailsProcess_Click(object sender, EventArgs e)
        {
            frmDetailsProcess detailsProcessForm = new frmDetailsProcess();
            detailsProcessForm.ShowDialog();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            frmDeleteRecord deleteRecordForm = new frmDeleteRecord();
            deleteRecordForm.ShowDialog();
        }
    }
}
