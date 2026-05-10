using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using System;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmAlert : Form
    {
        public frmAlert(string message)
        {
<<<<<<< HEAD
            InitializeComponent(); FontManager.ApplyFontToControls(this);
            this.Shown += new EventHandler(frmAlert_Shown);
=======
            InitializeComponent();
            FontManager.ApplyFontToControls(this);

>>>>>>> aa3a8eadc166087f9b57da3d20542af4f602b10d
            lblMessage.Text = message;

            // --- الحل السحري والرسمي في الويندوز ---
            this.AcceptButton = btnOk; // عند الضغط على Enter
            this.CancelButton = btnOk; // عند الضغط على Escape
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
