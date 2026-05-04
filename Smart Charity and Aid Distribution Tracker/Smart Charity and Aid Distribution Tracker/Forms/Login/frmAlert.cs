using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms.Login
{
    public partial class frmAlert : Form
    {

        public enum AlertType
        {
            Success,
            Error,
            Info,
            Warning
        }

        public frmAlert()
        {
            InitializeComponent();
        }

        public static void Show(string message, AlertType type)
        {
            using (var form = new frmAlert())
            {
                form.lblMessage.Text = message;
                switch (type)
                {
                    case AlertType.Success:
                        form.pnlTop.FillColor = Color.FromArgb(46, 204, 113);
                        form.btnOk.FillColor = Color.FromArgb(46, 204, 113);
                        //form.picIcon.Image = Properties.Resources.success_icon;
                        break;
                    case AlertType.Error:
                        form.pnlTop.FillColor = Color.FromArgb(231, 76, 60);
                        form.btnOk.FillColor = Color.FromArgb(231, 76, 60);
                        // form.picIcon.Image = Properties.Resources.error_icon;
                        break;
                }
                form.ShowDialog();
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
