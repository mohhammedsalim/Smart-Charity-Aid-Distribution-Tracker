namespace Smart_Charity_and_Aid_Distribution_Tracker.Donations.DonorManagement
{
    partial class frmDeleteDonor
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
            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDeleteDonor = new System.Windows.Forms.Label();
            this.lblDeleteDonorDis = new System.Windows.Forms.Label();
            this.lblDonorName = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderRadius = 16;
            this.pnlCard.Controls.Add(this.pnlHeader);
            this.pnlCard.Controls.Add(this.lblDeleteDonorDis);
            this.pnlCard.Controls.Add(this.lblDonorName);
            this.pnlCard.Controls.Add(this.lblWarning);
            this.pnlCard.Controls.Add(this.btnDelete);
            this.pnlCard.Controls.Add(this.btnCancel);
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(15, 15);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCard.ShadowDecoration.Depth = 15;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(503, 230);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblDeleteDonor);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(503, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblDeleteDonor
            // 
            this.lblDeleteDonor.AutoSize = true;
            this.lblDeleteDonor.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblDeleteDonor.ForeColor = System.Drawing.Color.White;
            this.lblDeleteDonor.Location = new System.Drawing.Point(276, 13);
            this.lblDeleteDonor.Name = "lblDeleteDonor";
            this.lblDeleteDonor.Size = new System.Drawing.Size(181, 29);
            this.lblDeleteDonor.TabIndex = 0;
            this.lblDeleteDonor.Text = "تأكيد الحذف المتبرع";
            // 
            // lblDeleteDonorDis
            // 
            this.lblDeleteDonorDis.AutoSize = true;
            this.lblDeleteDonorDis.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDeleteDonorDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDeleteDonorDis.Location = new System.Drawing.Point(277, 70);
            this.lblDeleteDonorDis.Name = "lblDeleteDonorDis";
            this.lblDeleteDonorDis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDeleteDonorDis.Size = new System.Drawing.Size(201, 21);
            this.lblDeleteDonorDis.TabIndex = 1;
            this.lblDeleteDonorDis.Text = "هل انت متأكد من حذف الصنف :";
            // 
            // lblDonorName
            // 
            this.lblDonorName.AutoSize = true;
            this.lblDonorName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblDonorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblDonorName.Location = new System.Drawing.Point(183, 68);
            this.lblDonorName.Name = "lblDonorName";
            this.lblDonorName.Size = new System.Drawing.Size(88, 23);
            this.lblDonorName.TabIndex = 2;
            this.lblDonorName.Text = "اسم الصنف";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblWarning.Location = new System.Drawing.Point(262, 100);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWarning.Size = new System.Drawing.Size(195, 21);
            this.lblWarning.TabIndex = 3;
            this.lblWarning.Text = "هذا الاجراء لا يمكن التراجع عنه!";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDelete.Location = new System.Drawing.Point(16, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(228, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnCancel.Location = new System.Drawing.Point(259, 174);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDeleteDonor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(533, 260);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDeleteDonor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeleteDonor";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblDeleteDonor;
        private System.Windows.Forms.Label lblDeleteDonorDis;
        private System.Windows.Forms.Label lblDonorName;
        private System.Windows.Forms.Label lblWarning;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
