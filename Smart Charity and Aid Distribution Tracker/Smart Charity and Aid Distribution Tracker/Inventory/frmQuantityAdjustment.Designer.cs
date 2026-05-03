namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    partial class frmQuantityAdjustment
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
            this.lblQuantityAdjustment = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.lblCorrectQuantity = new System.Windows.Forms.Label();
            this.txtAddedQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSep1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDifference = new System.Windows.Forms.Label();
            this.lblDifferenceValue = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCard.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlSep1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.Transparent;
            this.pnlCard.BorderRadius = 16;
            this.pnlCard.Controls.Add(this.pnlHeader);
            this.pnlCard.Controls.Add(this.lblCorrectQuantity);
            this.pnlCard.Controls.Add(this.txtAddedQuantity);
            this.pnlCard.Controls.Add(this.lblComments);
            this.pnlCard.Controls.Add(this.txtComments);
            this.pnlCard.Controls.Add(this.pnlSep1);
            this.pnlCard.Controls.Add(this.btnSave);
            this.pnlCard.Controls.Add(this.btnCancel);
            this.pnlCard.FillColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(15, 15);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCard.ShadowDecoration.Depth = 15;
            this.pnlCard.ShadowDecoration.Enabled = true;
            this.pnlCard.Size = new System.Drawing.Size(503, 388);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblQuantityAdjustment);
            this.pnlHeader.Controls.Add(this.lblItem);
            this.pnlHeader.Controls.Add(this.lblItemName);
            this.pnlHeader.Controls.Add(this.lblQuantity);
            this.pnlHeader.Controls.Add(this.lblItemQuantity);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(503, 88);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblQuantityAdjustment
            // 
            this.lblQuantityAdjustment.AutoSize = true;
            this.lblQuantityAdjustment.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblQuantityAdjustment.ForeColor = System.Drawing.Color.White;
            this.lblQuantityAdjustment.Location = new System.Drawing.Point(375, 3);
            this.lblQuantityAdjustment.Name = "lblQuantityAdjustment";
            this.lblQuantityAdjustment.Size = new System.Drawing.Size(117, 29);
            this.lblQuantityAdjustment.TabIndex = 0;
            this.lblQuantityAdjustment.Text = "تعديل الكمية";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblItem.Location = new System.Drawing.Point(413, 35);
            this.lblItem.Name = "lblItem";
            this.lblItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblItem.Size = new System.Drawing.Size(55, 21);
            this.lblItem.TabIndex = 1;
            this.lblItem.Text = "الصنف:";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(317, 35);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(79, 21);
            this.lblItemName.TabIndex = 2;
            this.lblItemName.Text = "اسم الصنف";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblQuantity.Location = new System.Drawing.Point(413, 59);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblQuantity.Size = new System.Drawing.Size(48, 21);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "الكمية:";
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblItemQuantity.ForeColor = System.Drawing.Color.White;
            this.lblItemQuantity.Location = new System.Drawing.Point(312, 59);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(84, 21);
            this.lblItemQuantity.TabIndex = 4;
            this.lblItemQuantity.Text = "كمية الصنف";
            // 
            // lblCorrectQuantity
            // 
            this.lblCorrectQuantity.AutoSize = true;
            this.lblCorrectQuantity.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblCorrectQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCorrectQuantity.Location = new System.Drawing.Point(308, 96);
            this.lblCorrectQuantity.Name = "lblCorrectQuantity";
            this.lblCorrectQuantity.Size = new System.Drawing.Size(165, 21);
            this.lblCorrectQuantity.TabIndex = 1;
            this.lblCorrectQuantity.Text = "الكمية الصحيحة بعد الجرد";
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
            this.txtAddedQuantity.Location = new System.Drawing.Point(10, 122);
            this.txtAddedQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddedQuantity.Name = "txtAddedQuantity";
            this.txtAddedQuantity.PlaceholderText = "";
            this.txtAddedQuantity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddedQuantity.SelectedText = "";
            this.txtAddedQuantity.Size = new System.Drawing.Size(480, 36);
            this.txtAddedQuantity.TabIndex = 2;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblComments.Location = new System.Drawing.Point(406, 170);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(67, 21);
            this.lblComments.TabIndex = 3;
            this.lblComments.Text = "ملاحظات";
            // 
            // txtComments
            // 
            this.txtComments.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtComments.BorderRadius = 8;
            this.txtComments.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComments.DefaultText = "";
            this.txtComments.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtComments.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtComments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtComments.Location = new System.Drawing.Point(10, 196);
            this.txtComments.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtComments.Name = "txtComments";
            this.txtComments.PlaceholderText = "";
            this.txtComments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtComments.SelectedText = "";
            this.txtComments.Size = new System.Drawing.Size(480, 36);
            this.txtComments.TabIndex = 4;
            // 
            // pnlSep1
            // 
            this.pnlSep1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlSep1.BorderRadius = 8;
            this.pnlSep1.BorderThickness = 1;
            this.pnlSep1.Controls.Add(this.lblDifference);
            this.pnlSep1.Controls.Add(this.lblDifferenceValue);
            this.pnlSep1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.pnlSep1.Location = new System.Drawing.Point(10, 250);
            this.pnlSep1.Name = "pnlSep1";
            this.pnlSep1.Size = new System.Drawing.Size(480, 48);
            this.pnlSep1.TabIndex = 5;
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblDifference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblDifference.Location = new System.Drawing.Point(400, 13);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDifference.Size = new System.Drawing.Size(55, 23);
            this.lblDifference.TabIndex = 0;
            this.lblDifference.Text = "الفرق :";
            // 
            // lblDifferenceValue
            // 
            this.lblDifferenceValue.AutoSize = true;
            this.lblDifferenceValue.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblDifferenceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblDifferenceValue.Location = new System.Drawing.Point(360, 13);
            this.lblDifferenceValue.Name = "lblDifferenceValue";
            this.lblDifferenceValue.Size = new System.Drawing.Size(30, 23);
            this.lblDifferenceValue.TabIndex = 1;
            this.lblDifferenceValue.Text = "00";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnSave.Location = new System.Drawing.Point(10, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "حفظ التعديل";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.Location = new System.Drawing.Point(262, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(231, 40);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmQuantityAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(533, 418);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmQuantityAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuantityAdjustment";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSep1.ResumeLayout(false);
            this.pnlSep1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblQuantityAdjustment;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Label lblCorrectQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtAddedQuantity;
        private System.Windows.Forms.Label lblComments;
        private Guna.UI2.WinForms.Guna2TextBox txtComments;
        private Guna.UI2.WinForms.Guna2Panel pnlSep1;
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.Label lblDifferenceValue;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
