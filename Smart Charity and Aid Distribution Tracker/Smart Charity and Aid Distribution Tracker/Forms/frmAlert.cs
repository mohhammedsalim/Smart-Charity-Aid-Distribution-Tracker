using Smart_Charity_and_Aid_Distribution_Tracker.Helpers;
using System;
using System.Windows.Forms;

namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    public partial class frmAlert : Form
    {
        public frmAlert(string message)
        {
            InitializeComponent();
            FontManager.ApplyFontToControls(this);

            lblMessage.Text = message;

            // --- الحل السحري والرسمي في الويندوز ---
            this.AcceptButton = btnOk; // عند الضغط على Enter
            this.CancelButton = btnOk; // عند الضغط على Escape
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // خاصية لجعل الفورم قابلاً للسحب من أي مكان
        private bool isDragging = false;
        private int mouseX, mouseY;
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (isDragging)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            isDragging = false;
        }
    }
}
