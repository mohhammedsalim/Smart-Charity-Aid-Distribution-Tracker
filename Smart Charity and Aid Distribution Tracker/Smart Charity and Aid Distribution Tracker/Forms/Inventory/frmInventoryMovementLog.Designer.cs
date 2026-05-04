namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    partial class frmInventoryMovementLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCard = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInventoryMovementLog = new System.Windows.Forms.Label();
            this.lblDash = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblInventoryMovementLogDis = new System.Windows.Forms.Label();
            this.dgvInventoryMovementLog = new System.Windows.Forms.DataGridView();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryMovementLog)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderRadius = 16;
            this.pnlCard.Controls.Add(this.pnlHeader);
            this.pnlCard.Controls.Add(this.dgvInventoryMovementLog);
            this.pnlCard.Controls.Add(this.btnClose);
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(15, 15);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCard.ShadowDecoration.Depth = 15;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(770, 494);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblInventoryMovementLog);
            this.pnlHeader.Controls.Add(this.lblDash);
            this.pnlHeader.Controls.Add(this.lblItemName);
            this.pnlHeader.Controls.Add(this.lblInventoryMovementLogDis);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(770, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblInventoryMovementLog
            // 
            this.lblInventoryMovementLog.AutoSize = true;
            this.lblInventoryMovementLog.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblInventoryMovementLog.ForeColor = System.Drawing.Color.White;
            this.lblInventoryMovementLog.Location = new System.Drawing.Point(575, 11);
            this.lblInventoryMovementLog.Name = "lblInventoryMovementLog";
            this.lblInventoryMovementLog.Size = new System.Drawing.Size(182, 29);
            this.lblInventoryMovementLog.TabIndex = 0;
            this.lblInventoryMovementLog.Text = "سجل حركة المخزون";
            // 
            // lblDash
            // 
            this.lblDash.AutoSize = true;
            this.lblDash.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblDash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblDash.Location = new System.Drawing.Point(557, 11);
            this.lblDash.Name = "lblDash";
            this.lblDash.Size = new System.Drawing.Size(20, 29);
            this.lblDash.TabIndex = 1;
            this.lblDash.Text = "-";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblItemName.Location = new System.Drawing.Point(427, 11);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(112, 29);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "اسم الصنف";
            // 
            // lblInventoryMovementLogDis
            // 
            this.lblInventoryMovementLogDis.AutoSize = true;
            this.lblInventoryMovementLogDis.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblInventoryMovementLogDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblInventoryMovementLogDis.Location = new System.Drawing.Point(429, 40);
            this.lblInventoryMovementLogDis.Name = "lblInventoryMovementLogDis";
            this.lblInventoryMovementLogDis.Size = new System.Drawing.Size(293, 18);
            this.lblInventoryMovementLogDis.TabIndex = 3;
            this.lblInventoryMovementLogDis.Text = "عرض جميع حركات الواردات و المصروفات للصنف المحدد";
            // 
            // dgvInventoryMovementLog
            // 
            this.dgvInventoryMovementLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventoryMovementLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvInventoryMovementLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryMovementLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryMovementLog.EnableHeadersVisualStyles = false;
            this.dgvInventoryMovementLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvInventoryMovementLog.Location = new System.Drawing.Point(12, 82);
            this.dgvInventoryMovementLog.Name = "dgvInventoryMovementLog";
            this.dgvInventoryMovementLog.RowHeadersWidth = 62;
            this.dgvInventoryMovementLog.Size = new System.Drawing.Size(745, 350);
            this.dgvInventoryMovementLog.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BorderRadius = 10;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClose.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnClose.Location = new System.Drawing.Point(267, 438);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(233, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "إغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmInventoryMovementLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInventoryMovementLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInventoryMovementLog";
            this.pnlCard.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryMovementLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblInventoryMovementLog;
        private System.Windows.Forms.Label lblDash;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblInventoryMovementLogDis;
        private System.Windows.Forms.DataGridView dgvInventoryMovementLog;
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}
