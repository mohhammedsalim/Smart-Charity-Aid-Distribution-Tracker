namespace Smart_Charity_and_Aid_Distribution_Tracker.Donations.DonorManagement
{
    partial class frmDonorAdjustment
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
            this.lblDonorAdjustment = new System.Windows.Forms.Label();
            this.lblDonorAdjustmentDis = new System.Windows.Forms.Label();
            this.lblDonorName = new System.Windows.Forms.Label();
            this.txtDonorName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.pnlCard.Controls.Add(this.lblDonorName);
            this.pnlCard.Controls.Add(this.txtDonorName);
            this.pnlCard.Controls.Add(this.lblPhone);
            this.pnlCard.Controls.Add(this.txtPhone);
            this.pnlCard.Controls.Add(this.lblEmail);
            this.pnlCard.Controls.Add(this.txtEmail);
            this.pnlCard.Controls.Add(this.btnSave);
            this.pnlCard.Controls.Add(this.btnCancel);
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(15, 15);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCard.ShadowDecoration.Depth = 15;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(503, 370);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblDonorAdjustment);
            this.pnlHeader.Controls.Add(this.lblDonorAdjustmentDis);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(503, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblDonorAdjustment
            // 
            this.lblDonorAdjustment.AutoSize = true;
            this.lblDonorAdjustment.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblDonorAdjustment.ForeColor = System.Drawing.Color.White;
            this.lblDonorAdjustment.Location = new System.Drawing.Point(366, 10);
            this.lblDonorAdjustment.Name = "lblDonorAdjustment";
            this.lblDonorAdjustment.Size = new System.Drawing.Size(123, 29);
            this.lblDonorAdjustment.TabIndex = 0;
            this.lblDonorAdjustment.Text = "تعديل المتبرع";
            // 
            // lblDonorAdjustmentDis
            // 
            this.lblDonorAdjustmentDis.AutoSize = true;
            this.lblDonorAdjustmentDis.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDonorAdjustmentDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblDonorAdjustmentDis.Location = new System.Drawing.Point(301, 39);
            this.lblDonorAdjustmentDis.Name = "lblDonorAdjustmentDis";
            this.lblDonorAdjustmentDis.Size = new System.Drawing.Size(175, 18);
            this.lblDonorAdjustmentDis.TabIndex = 1;
            this.lblDonorAdjustmentDis.Text = "عدل البيانات التالية لتعديل المتبرع";
            // 
            // lblDonorName
            // 
            this.lblDonorName.AutoSize = true;
            this.lblDonorName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDonorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDonorName.Location = new System.Drawing.Point(400, 87);
            this.lblDonorName.Name = "lblDonorName";
            this.lblDonorName.Size = new System.Drawing.Size(76, 21);
            this.lblDonorName.TabIndex = 1;
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
            this.txtDonorName.Location = new System.Drawing.Point(14, 112);
            this.txtDonorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonorName.Name = "txtDonorName";
            this.txtDonorName.PlaceholderText = "";
            this.txtDonorName.SelectedText = "";
            this.txtDonorName.Size = new System.Drawing.Size(475, 36);
            this.txtDonorName.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblPhone.Location = new System.Drawing.Point(404, 163);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(72, 21);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "رقم الهاتف";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtPhone.BorderRadius = 8;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPhone.Location = new System.Drawing.Point(14, 188);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(475, 36);
            this.txtPhone.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEmail.Location = new System.Drawing.Point(377, 239);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(99, 21);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "البريد الإلكتروني";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtEmail.Location = new System.Drawing.Point(14, 264);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(475, 36);
            this.txtEmail.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnSave.Location = new System.Drawing.Point(14, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "حفظ";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.Location = new System.Drawing.Point(261, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmDonorAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(533, 400);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDonorAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDonorAdjustment";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblDonorAdjustment;
        private System.Windows.Forms.Label lblDonorAdjustmentDis;
        private System.Windows.Forms.Label lblDonorName;
        private Guna.UI2.WinForms.Guna2TextBox txtDonorName;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
