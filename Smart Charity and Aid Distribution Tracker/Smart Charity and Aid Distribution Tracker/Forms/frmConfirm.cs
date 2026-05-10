using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using System;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmConfirm : Form
    {
        public frmConfirm(string message)
        {
            InitializeComponent();
            lblMessage.Text = message; FontManager.ApplyFontToControls(this);

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        
       
       
    }
}
