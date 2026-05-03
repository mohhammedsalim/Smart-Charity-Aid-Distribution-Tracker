namespace Smart_Charity_and_Aid_Distribution_Tracker.Donations
{
    partial class frmDonationModification
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
            this.lblDonationModification = new System.Windows.Forms.Label();
            this.lblDonationModificationDis = new System.Windows.Forms.Label();
            this.lblTypeDonation = new System.Windows.Forms.Label();
            this.cmbTypeDonation = new System.Windows.Forms.ComboBox();
            this.lblDonorName = new System.Windows.Forms.Label();
            this.txtDonorName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
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
            this.pnlCard.Controls.Add(this.lblTypeDonation);
            this.pnlCard.Controls.Add(this.cmbTypeDonation);
            this.pnlCard.Controls.Add(this.lblDonorName);
            this.pnlCard.Controls.Add(this.txtDonorName);
            this.pnlCard.Controls.Add(this.lblAmount);
            this.pnlCard.Controls.Add(this.txtAmount);
            this.pnlCard.Controls.Add(this.lblDescription);
            this.pnlCard.Controls.Add(this.txtDescription);
            this.pnlCard.Controls.Add(this.btnSave);
            this.pnlCard.Controls.Add(this.btnCancel);
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(15, 15);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCard.ShadowDecoration.Depth = 15;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(503, 403);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblDonationModification);
            this.pnlHeader.Controls.Add(this.lblDonationModificationDis);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(503, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblDonationModification
            // 
            this.lblDonationModification.AutoSize = true;
            this.lblDonationModification.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblDonationModification.ForeColor = System.Drawing.Color.White;
            this.lblDonationModification.Location = new System.Drawing.Point(372, 15);
            this.lblDonationModification.Name = "lblDonationModification";
            this.lblDonationModification.Size = new System.Drawing.Size(112, 29);
            this.lblDonationModification.TabIndex = 0;
            this.lblDonationModification.Text = "تعديل التبرع";
            // 
            // lblDonationModificationDis
            // 
            this.lblDonationModificationDis.AutoSize = true;
            this.lblDonationModificationDis.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDonationModificationDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblDonationModificationDis.Location = new System.Drawing.Point(301, 44);
            this.lblDonationModificationDis.Name = "lblDonationModificationDis";
            this.lblDonationModificationDis.Size = new System.Drawing.Size(171, 18);
            this.lblDonationModificationDis.TabIndex = 1;
            this.lblDonationModificationDis.Text = "قم بي تعديل بيانات التبرع المحدد";
            // 
            // lblTypeDonation
            // 
            this.lblTypeDonation.AutoSize = true;
            this.lblTypeDonation.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblTypeDonation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTypeDonation.Location = new System.Drawing.Point(420, 86);
            this.lblTypeDonation.Name = "lblTypeDonation";
            this.lblTypeDonation.Size = new System.Drawing.Size(64, 21);
            this.lblTypeDonation.TabIndex = 1;
            this.lblTypeDonation.Text = "نوع التبرع";
            // 
            // cmbTypeDonation
            // 
            this.cmbTypeDonation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cmbTypeDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTypeDonation.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbTypeDonation.FormattingEnabled = true;
            this.cmbTypeDonation.Location = new System.Drawing.Point(14, 110);
            this.cmbTypeDonation.Name = "cmbTypeDonation";
            this.cmbTypeDonation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTypeDonation.Size = new System.Drawing.Size(475, 29);
            this.cmbTypeDonation.TabIndex = 2;
            // 
            // lblDonorName
            // 
            this.lblDonorName.AutoSize = true;
            this.lblDonorName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDonorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDonorName.Location = new System.Drawing.Point(408, 151);
            this.lblDonorName.Name = "lblDonorName";
            this.lblDonorName.Size = new System.Drawing.Size(76, 21);
            this.lblDonorName.TabIndex = 3;
            this.lblDonorName.Text = "اسم المتبرع";
            // 
            // txtDonorName
            // 
            this.txtDonorName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDonorName.BorderRadius = 8;
            this.txtDonorName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonorName.DefaultText = "";
            this.txtDonorName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtDonorName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtDonorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtDonorName.Location = new System.Drawing.Point(14, 176);
            this.txtDonorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonorName.Name = "txtDonorName";
            this.txtDonorName.PlaceholderText = "";
            this.txtDonorName.SelectedText = "";
            this.txtDonorName.Size = new System.Drawing.Size(475, 36);
            this.txtDonorName.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAmount.Location = new System.Drawing.Point(440, 217);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(44, 21);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "المبلغ";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtAmount.BorderRadius = 8;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtAmount.Location = new System.Drawing.Point(14, 242);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(475, 36);
            this.txtAmount.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDescription.Location = new System.Drawing.Point(438, 283);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(46, 21);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "وصف";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDescription.BorderRadius = 8;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtDescription.Location = new System.Drawing.Point(14, 308);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(475, 36);
            this.txtDescription.TabIndex = 8;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnSave.Location = new System.Drawing.Point(14, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "حفظ";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.Location = new System.Drawing.Point(261, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 40);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDonationModification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(533, 430);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDonationModification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDonationModification";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblDonationModification;
        private System.Windows.Forms.Label lblDonationModificationDis;
        private System.Windows.Forms.Label lblTypeDonation;
        private System.Windows.Forms.ComboBox cmbTypeDonation;
        private System.Windows.Forms.Label lblDonorName;
        private Guna.UI2.WinForms.Guna2TextBox txtDonorName;
        private System.Windows.Forms.Label lblAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
