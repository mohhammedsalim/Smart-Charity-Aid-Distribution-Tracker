using Smart_Charity_and_Aid_Distribution_Tracker.Inventory.ItemManagement;
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
    public partial class frmItemManagement : Form
    {
        public frmItemManagement()
        {
            InitializeComponent();
        }

        private void btnBackToInventoryManagement_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddNewItem_Click(object sender, EventArgs e)
        {
            frmAddNewCategory addNewCategoryForm = new frmAddNewCategory();
            addNewCategoryForm.ShowDialog();
        }

        private void btnItemAdjustment_Click(object sender, EventArgs e)
        {
            frmEditCategory editCategoryForm = new frmEditCategory();
            editCategoryForm.ShowDialog();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            frmDeleteItem deleteItemForm = new frmDeleteItem();
            deleteItemForm.ShowDialog();
        }
    }
}
