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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void btnBackToDashBoard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewBalance_Click(object sender, EventArgs e)
        {
            frmAddNewBalance addNewBalanceForm = new frmAddNewBalance();
            addNewBalanceForm.ShowDialog();
        }

        private void btnViewMotionLog_Click(object sender, EventArgs e)
        {
            frmInventoryMovementLog inventoryMovementLogForm = new frmInventoryMovementLog();
            inventoryMovementLogForm.ShowDialog();
        }

        private void btnQuantityAdjustment_Click(object sender, EventArgs e)
        {
            frmQuantityAdjustment quantityAdjustmentForm = new frmQuantityAdjustment();
            quantityAdjustmentForm.ShowDialog();
        }

        private void btnItemManagement_Click(object sender, EventArgs e)
        {
            frmItemManagement itemManagementForm = new frmItemManagement();
            itemManagementForm.ShowDialog();
        }
    }
}
