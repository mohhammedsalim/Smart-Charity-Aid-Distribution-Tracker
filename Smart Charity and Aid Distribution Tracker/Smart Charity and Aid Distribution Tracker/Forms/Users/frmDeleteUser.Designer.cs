namespace Smart_Charity_and_Aid_Distribution_Tracker.Users
{
    partial class frmDeleteUser
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDeleteUser = new System.Windows.Forms.Label();
            this.lblDeleteUserDis = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();

            this.pnlCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════
            // pnlCard
            // ════════════════════════════════════
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.BorderRadius = 16;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.ShadowDecoration.Depth = 15;
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(40, 0, 0, 0);
            this.pnlCard.Location = new System.Drawing.Point(15, 15);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(503, 155);
            this.pnlCard.TabIndex = 0;
            this.pnlCard.Controls.Add(this.pnlHeader);
            this.pnlCard.Controls.Add(this.lblDeleteUserDis);
            this.pnlCard.Controls.Add(this.lblUserName);
            this.pnlCard.Controls.Add(this.lblWarning);
            this.pnlCard.Controls.Add(this.btnDelete);
            this.pnlCard.Controls.Add(this.btnCancel);

            // ════════════════════════════════════
            // pnlHeader
            // ════════════════════════════════════
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(200, 40, 40);
            this.pnlHeader.BorderRadius = 0;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(503, 40);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Controls.Add(this.lblDeleteUser);

            this.lblDeleteUser.AutoSize = true;
            this.lblDeleteUser.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblDeleteUser.ForeColor = System.Drawing.Color.White;
            this.lblDeleteUser.Location = new System.Drawing.Point(344, 8);
            this.lblDeleteUser.Name = "lblDeleteUser";
            this.lblDeleteUser.TabIndex = 0;
            this.lblDeleteUser.Text = "تأكيد الحذف";

            // ════════════════════════════════════
            // Confirmation text
            // ════════════════════════════════════
            this.lblDeleteUserDis.AutoSize = true;
            this.lblDeleteUserDis.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDeleteUserDis.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblDeleteUserDis.Location = new System.Drawing.Point(216, 50);
            this.lblDeleteUserDis.Name = "lblDeleteUserDis";
            this.lblDeleteUserDis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDeleteUserDis.TabIndex = 1;
            this.lblDeleteUserDis.Text = "هل انت متأكد من حذف المستخدم :";

            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(34, 139, 34);
            this.lblUserName.Location = new System.Drawing.Point(100, 50);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "اسم المستخدم";

            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(200, 40, 40);
            this.lblWarning.Location = new System.Drawing.Point(240, 74);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "هذا الاجراء لا يمكن التراجع عنه!";

            // ════════════════════════════════════
            // Buttons
            // ════════════════════════════════════
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(200, 40, 40);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(170, 20, 20);
            this.btnDelete.Location = new System.Drawing.Point(10, 106);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(228, 38);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";

            this.btnCancel.BorderRadius = 10;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.btnCancel.Location = new System.Drawing.Point(256, 106);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(236, 38);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // ════════════════════════════════════
            // frmDeleteUser
            // ════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(235, 248, 235);
            this.ClientSize = new System.Drawing.Size(533, 185);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDeleteUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeleteUser";

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblDeleteUser;
        private System.Windows.Forms.Label lblDeleteUserDis;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblWarning;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
