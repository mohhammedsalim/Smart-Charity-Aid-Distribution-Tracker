namespace Smart_Charity_and_Aid_Distribution_Tracker.Donations
{
    partial class frmDeleteSelected
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
            this.lblDeleteDonation = new System.Windows.Forms.Label();
            this.lblDeleteDonationDis = new System.Windows.Forms.Label();
            this.lblBeneficiaryNumber = new System.Windows.Forms.Label();
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
            this.pnlCard.Controls.Add(this.lblDeleteDonationDis);
            this.pnlCard.Controls.Add(this.lblBeneficiaryNumber);
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
            this.pnlHeader.Controls.Add(this.lblDeleteDonation);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(503, 55);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblDeleteDonation
            // 
            this.lblDeleteDonation.AutoSize = true;
            this.lblDeleteDonation.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblDeleteDonation.ForeColor = System.Drawing.Color.White;
            this.lblDeleteDonation.Location = new System.Drawing.Point(367, 15);
            this.lblDeleteDonation.Name = "lblDeleteDonation";
            this.lblDeleteDonation.Size = new System.Drawing.Size(120, 29);
            this.lblDeleteDonation.TabIndex = 0;
            this.lblDeleteDonation.Text = "تأكيد الحذف";
            // 
            // lblDeleteDonationDis
            // 
            this.lblDeleteDonationDis.AutoSize = true;
            this.lblDeleteDonationDis.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDeleteDonationDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDeleteDonationDis.Location = new System.Drawing.Point(274, 70);
            this.lblDeleteDonationDis.Name = "lblDeleteDonationDis";
            this.lblDeleteDonationDis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDeleteDonationDis.Size = new System.Drawing.Size(213, 21);
            this.lblDeleteDonationDis.TabIndex = 1;
            this.lblDeleteDonationDis.Text = "هل انت متأكد من حذف هذا التبرع :";
            // 
            // lblBeneficiaryNumber
            // 
            this.lblBeneficiaryNumber.AutoSize = true;
            this.lblBeneficiaryNumber.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblBeneficiaryNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblBeneficiaryNumber.Location = new System.Drawing.Point(196, 70);
            this.lblBeneficiaryNumber.Name = "lblBeneficiaryNumber";
            this.lblBeneficiaryNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBeneficiaryNumber.Size = new System.Drawing.Size(72, 23);
            this.lblBeneficiaryNumber.TabIndex = 2;
            this.lblBeneficiaryNumber.Text = "رقم التبرع";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblWarning.Location = new System.Drawing.Point(255, 102);
            this.lblWarning.Name = "lblWarning";
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
            // frmDeleteSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(533, 260);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDeleteSelected";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDeleteSelected";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblDeleteDonation;
        private System.Windows.Forms.Label lblDeleteDonationDis;
        private System.Windows.Forms.Label lblBeneficiaryNumber;
        private System.Windows.Forms.Label lblWarning;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
