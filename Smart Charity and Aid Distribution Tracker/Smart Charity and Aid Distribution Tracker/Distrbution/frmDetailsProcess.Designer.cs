namespace Smart_Charity_and_Aid_Distribution_Tracker.Distrbution
{
    partial class frmDetailsProcess
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
            this.lblDetailsProcess = new System.Windows.Forms.Label();
            this.lblDash1 = new System.Windows.Forms.Label();
            this.lblProcessCode = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDash2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDispensedItems = new System.Windows.Forms.Label();
            this.dgvBeneficiariesList = new System.Windows.Forms.DataGridView();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiariesList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderRadius = 20;
            this.pnlCard.Controls.Add(this.pnlHeader);
            this.pnlCard.Controls.Add(this.dgvBeneficiariesList);
            this.pnlCard.Controls.Add(this.btnClose);
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(16, 16);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCard.ShadowDecoration.Depth = 15;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(768, 460);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblDetailsProcess);
            this.pnlHeader.Controls.Add(this.lblDash1);
            this.pnlHeader.Controls.Add(this.lblProcessCode);
            this.pnlHeader.Controls.Add(this.lblUserName);
            this.pnlHeader.Controls.Add(this.lblDash2);
            this.pnlHeader.Controls.Add(this.lblDate);
            this.pnlHeader.Controls.Add(this.lblDispensedItems);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(768, 95);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblDetailsProcess
            // 
            this.lblDetailsProcess.AutoSize = true;
            this.lblDetailsProcess.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblDetailsProcess.ForeColor = System.Drawing.Color.White;
            this.lblDetailsProcess.Location = new System.Drawing.Point(584, 10);
            this.lblDetailsProcess.Name = "lblDetailsProcess";
            this.lblDetailsProcess.Size = new System.Drawing.Size(166, 31);
            this.lblDetailsProcess.TabIndex = 0;
            this.lblDetailsProcess.Text = "سجل المساعدات";
            // 
            // lblDash1
            // 
            this.lblDash1.AutoSize = true;
            this.lblDash1.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblDash1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.lblDash1.Location = new System.Drawing.Point(559, 10);
            this.lblDash1.Name = "lblDash1";
            this.lblDash1.Size = new System.Drawing.Size(22, 31);
            this.lblDash1.TabIndex = 1;
            this.lblDash1.Text = "-";
            // 
            // lblProcessCode
            // 
            this.lblProcessCode.AutoSize = true;
            this.lblProcessCode.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblProcessCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.lblProcessCode.Location = new System.Drawing.Point(432, 10);
            this.lblProcessCode.Name = "lblProcessCode";
            this.lblProcessCode.Size = new System.Drawing.Size(110, 31);
            this.lblProcessCode.TabIndex = 2;
            this.lblProcessCode.Text = "رمز العملية";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblUserName.Location = new System.Drawing.Point(653, 41);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(88, 21);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "اسم المستفيد";
            // 
            // lblDash2
            // 
            this.lblDash2.AutoSize = true;
            this.lblDash2.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDash2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.lblDash2.Location = new System.Drawing.Point(631, 41);
            this.lblDash2.Name = "lblDash2";
            this.lblDash2.Size = new System.Drawing.Size(15, 21);
            this.lblDash2.TabIndex = 4;
            this.lblDash2.Text = "-";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblDate.Location = new System.Drawing.Point(503, 41);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 21);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "dd-mm-yyyy";
            // 
            // lblDispensedItems
            // 
            this.lblDispensedItems.AutoSize = true;
            this.lblDispensedItems.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDispensedItems.ForeColor = System.Drawing.Color.White;
            this.lblDispensedItems.Location = new System.Drawing.Point(605, 62);
            this.lblDispensedItems.Name = "lblDispensedItems";
            this.lblDispensedItems.Size = new System.Drawing.Size(120, 21);
            this.lblDispensedItems.TabIndex = 6;
            this.lblDispensedItems.Text = "الاصناف المصروفة";
            // 
            // dgvBeneficiariesList
            // 
            this.dgvBeneficiariesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvBeneficiariesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBeneficiariesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiariesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvBeneficiariesList.Location = new System.Drawing.Point(12, 106);
            this.dgvBeneficiariesList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBeneficiariesList.Name = "dgvBeneficiariesList";
            this.dgvBeneficiariesList.RowHeadersWidth = 50;
            this.dgvBeneficiariesList.Size = new System.Drawing.Size(744, 300);
            this.dgvBeneficiariesList.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btnClose.BorderRadius = 10;
            this.btnClose.BorderThickness = 2;
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(267, 414);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(234, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDetailsProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDetailsProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetailsProcess";
            this.pnlCard.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiariesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblDetailsProcess;
        private System.Windows.Forms.Label lblDash1;
        private System.Windows.Forms.Label lblProcessCode;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDash2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDispensedItems;
        private System.Windows.Forms.DataGridView dgvBeneficiariesList;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}
