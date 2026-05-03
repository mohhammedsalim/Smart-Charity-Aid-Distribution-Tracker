namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    partial class frmBeneficiaryAidRecord
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
            this.lblBeneficiaryAidRecord = new System.Windows.Forms.Label();
            this.lblDash = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblBeneficiaryAidRecordDis = new System.Windows.Forms.Label();
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
            this.pnlCard.Location = new System.Drawing.Point(22, 25);
            this.pnlCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCard.ShadowDecoration.Depth = 15;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(855, 565);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblBeneficiaryAidRecord);
            this.pnlHeader.Controls.Add(this.lblDash);
            this.pnlHeader.Controls.Add(this.lblUserName);
            this.pnlHeader.Controls.Add(this.lblBeneficiaryAidRecordDis);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(855, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblBeneficiaryAidRecord
            // 
            this.lblBeneficiaryAidRecord.AutoSize = true;
            this.lblBeneficiaryAidRecord.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblBeneficiaryAidRecord.ForeColor = System.Drawing.Color.White;
            this.lblBeneficiaryAidRecord.Location = new System.Drawing.Point(643, 13);
            this.lblBeneficiaryAidRecord.Name = "lblBeneficiaryAidRecord";
            this.lblBeneficiaryAidRecord.Size = new System.Drawing.Size(197, 37);
            this.lblBeneficiaryAidRecord.TabIndex = 0;
            this.lblBeneficiaryAidRecord.Text = "سجل المساعدات";
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.lblDash.Location = new System.Drawing.Point(615, 13);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(26, 37);
            this.lblDash.TabIndex = 1;
            this.lblDash.Text = "-";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.lblUserName.Location = new System.Drawing.Point(440, 13);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(160, 37);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "اسم المستفيد";
            // 
            // lblBeneficiaryAidRecordDis
            // 
            this.lblBeneficiaryAidRecordDis.AutoSize = true;
            this.lblBeneficiaryAidRecordDis.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblBeneficiaryAidRecordDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblBeneficiaryAidRecordDis.Location = new System.Drawing.Point(497, 58);
            this.lblBeneficiaryAidRecordDis.Name = "lblBeneficiaryAidRecordDis";
            this.lblBeneficiaryAidRecordDis.Size = new System.Drawing.Size(297, 24);
            this.lblBeneficiaryAidRecordDis.TabIndex = 3;
            this.lblBeneficiaryAidRecordDis.Text = "عرض جميع المساعدات المقدمة للمستفيد";
            // 
            // dgvBeneficiariesList
            // 
            this.dgvBeneficiariesList.BackgroundColor = System.Drawing.Color.White;
            this.dgvBeneficiariesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBeneficiariesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiariesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvBeneficiariesList.Location = new System.Drawing.Point(16, 115);
            this.dgvBeneficiariesList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvBeneficiariesList.Name = "dgvBeneficiariesList";
            this.dgvBeneficiariesList.RowHeadersWidth = 50;
            this.dgvBeneficiariesList.Size = new System.Drawing.Size(824, 375);
            this.dgvBeneficiariesList.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.BorderRadius = 10;
            this.btnClose.BorderThickness = 2;
            this.btnClose.FillColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(296, 505);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(263, 48);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmBeneficiaryAidRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(900, 615);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBeneficiaryAidRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBeneficiaryAidRecord";
            this.pnlCard.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiariesList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblBeneficiaryAidRecord;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblBeneficiaryAidRecordDis;
        private System.Windows.Forms.DataGridView dgvBeneficiariesList;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}
