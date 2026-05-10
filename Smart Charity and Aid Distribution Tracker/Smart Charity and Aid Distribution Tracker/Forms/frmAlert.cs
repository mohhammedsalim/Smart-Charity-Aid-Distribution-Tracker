using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using System;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmAlert : Form
    {
        public frmAlert(string message)
        {
            InitializeComponent(); FontManager.ApplyFontToControls(this);
            this.Shown += new EventHandler(frmAlert_Shown);
            lblMessage.Text = message;
        }
        private void frmAlert_Shown(object sender, EventArgs e)
        {
            this.Activate(); 
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private void frmAlert_Load(object sender, EventArgs e)
        {
            btnOk.Focus();
        }

    }
}
