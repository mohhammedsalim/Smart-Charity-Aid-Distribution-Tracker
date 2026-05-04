namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    partial class frmAddNewBalance
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
            this.lblAddNewBalance = new System.Windows.Forms.Label();
            this.lblAddNewBalanceDis = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblAddedQuantity = new System.Windows.Forms.Label();
            this.txtAddedQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.dtpExpirationDate = new System.Windows.Forms.DateTimePicker();
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
            this.pnlCard.Controls.Add(this.lblAddedQuantity);
            this.pnlCard.Controls.Add(this.txtAddedQuantity);
            this.pnlCard.Controls.Add(this.lblSource);
            this.pnlCard.Controls.Add(this.cmbSource);
            this.pnlCard.Controls.Add(this.lblExpirationDate);
            this.pnlCard.Controls.Add(this.dtpExpirationDate);
            this.pnlCard.Controls.Add(this.btnSave);
            this.pnlCard.Controls.Add(this.btnCancel);
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(15, 15);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCard.ShadowDecoration.Depth = 15;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(503, 390);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblAddNewBalance);
            this.pnlHeader.Controls.Add(this.lblAddNewBalanceDis);
            this.pnlHeader.Controls.Add(this.lblItemName);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(503, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblAddNewBalance
            // 
            this.lblAddNewBalance.AutoSize = true;
            this.lblAddNewBalance.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddNewBalance.ForeColor = System.Drawing.Color.White;
            this.lblAddNewBalance.Location = new System.Drawing.Point(326, 11);
            this.lblAddNewBalance.Name = "lblAddNewBalance";
            this.lblAddNewBalance.Size = new System.Drawing.Size(163, 29);
            this.lblAddNewBalance.TabIndex = 0;
            this.lblAddNewBalance.Text = "إضافة رصيد جديد";
            // 
            // lblAddNewBalanceDis
            // 
            this.lblAddNewBalanceDis.AutoSize = true;
            this.lblAddNewBalanceDis.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblAddNewBalanceDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblAddNewBalanceDis.Location = new System.Drawing.Point(251, 43);
            this.lblAddNewBalanceDis.Name = "lblAddNewBalanceDis";
            this.lblAddNewBalanceDis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAddNewBalanceDis.Size = new System.Drawing.Size(220, 18);
            this.lblAddNewBalanceDis.TabIndex = 1;
            this.lblAddNewBalanceDis.Text = "املأ البيانات التالية لإضافة رصيد لي الصنف:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblItemName.Location = new System.Drawing.Point(163, 43);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(79, 21);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "اسم الصنف";
            // 
            // lblAddedQuantity
            // 
            this.lblAddedQuantity.AutoSize = true;
            this.lblAddedQuantity.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddedQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblAddedQuantity.Location = new System.Drawing.Point(375, 89);
            this.lblAddedQuantity.Name = "lblAddedQuantity";
            this.lblAddedQuantity.Size = new System.Drawing.Size(96, 21);
            this.lblAddedQuantity.TabIndex = 1;
            this.lblAddedQuantity.Text = "الكمية المضافة";
            // 
            // txtAddedQuantity
            // 
            this.txtAddedQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtAddedQuantity.BorderRadius = 8;
            this.txtAddedQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddedQuantity.DefaultText = "";
            this.txtAddedQuantity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtAddedQuantity.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtAddedQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtAddedQuantity.Location = new System.Drawing.Point(14, 114);
            this.txtAddedQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddedQuantity.Name = "txtAddedQuantity";
            this.txtAddedQuantity.PlaceholderText = "";
            this.txtAddedQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddedQuantity.SelectedText = "";
            this.txtAddedQuantity.Size = new System.Drawing.Size(474, 36);
            this.txtAddedQuantity.TabIndex = 2;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblSource.Location = new System.Drawing.Point(416, 166);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(55, 21);
            this.lblSource.TabIndex = 3;
            this.lblSource.Text = "المصدر";
            // 
            // cmbSource
            // 
            this.cmbSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cmbSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSource.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(14, 188);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSource.Size = new System.Drawing.Size(474, 29);
            this.cmbSource.TabIndex = 4;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblExpirationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblExpirationDate.Location = new System.Drawing.Point(310, 240);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(133, 21);
            this.lblExpirationDate.TabIndex = 5;
            this.lblExpirationDate.Text = "تاريخ انتهاء الصلاحية";
            // 
            // dtpExpirationDate
            // 
            this.dtpExpirationDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.dtpExpirationDate.Location = new System.Drawing.Point(14, 264);
            this.dtpExpirationDate.Name = "dtpExpirationDate";
            this.dtpExpirationDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpExpirationDate.Size = new System.Drawing.Size(474, 28);
            this.dtpExpirationDate.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnSave.Location = new System.Drawing.Point(14, 340);
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
            this.btnCancel.Location = new System.Drawing.Point(260, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(229, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddNewBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(533, 420);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddNewBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewBalance";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblAddNewBalance;
        private System.Windows.Forms.Label lblAddNewBalanceDis;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblAddedQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtAddedQuantity;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.DateTimePicker dtpExpirationDate;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
