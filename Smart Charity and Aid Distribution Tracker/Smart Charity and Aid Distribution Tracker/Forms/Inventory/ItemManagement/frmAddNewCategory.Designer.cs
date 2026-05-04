namespace Smart_Charity_and_Aid_Distribution_Tracker.Inventory.ItemManagement
{
    partial class frmAddNewCategory
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
            this.lblAddNewCategory = new System.Windows.Forms.Label();
            this.lblAddNewCategoryDis = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.txtItemCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.txtMinimum = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEstimatedValue = new System.Windows.Forms.Label();
            this.txtEstimatedValue = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.pnlCard.Controls.Add(this.lblItemName);
            this.pnlCard.Controls.Add(this.txtItemName);
            this.pnlCard.Controls.Add(this.lblItemCode);
            this.pnlCard.Controls.Add(this.txtItemCode);
            this.pnlCard.Controls.Add(this.lblUnit);
            this.pnlCard.Controls.Add(this.cmbUnit);
            this.pnlCard.Controls.Add(this.lblCategory);
            this.pnlCard.Controls.Add(this.cmbCategory);
            this.pnlCard.Controls.Add(this.lblMinimum);
            this.pnlCard.Controls.Add(this.txtMinimum);
            this.pnlCard.Controls.Add(this.lblEstimatedValue);
            this.pnlCard.Controls.Add(this.txtEstimatedValue);
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
            this.pnlCard.Size = new System.Drawing.Size(500, 428);
            this.pnlCard.TabIndex = 0;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblAddNewCategory);
            this.pnlHeader.Controls.Add(this.lblAddNewCategoryDis);
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(500, 72);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblAddNewCategory
            // 
            this.lblAddNewCategory.AutoSize = true;
            this.lblAddNewCategory.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblAddNewCategory.ForeColor = System.Drawing.Color.White;
            this.lblAddNewCategory.Location = new System.Drawing.Point(319, 15);
            this.lblAddNewCategory.Name = "lblAddNewCategory";
            this.lblAddNewCategory.Size = new System.Drawing.Size(167, 29);
            this.lblAddNewCategory.TabIndex = 0;
            this.lblAddNewCategory.Text = "إضافة صنف جديد";
            // 
            // lblAddNewCategoryDis
            // 
            this.lblAddNewCategoryDis.AutoSize = true;
            this.lblAddNewCategoryDis.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblAddNewCategoryDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.lblAddNewCategoryDis.Location = new System.Drawing.Point(267, 44);
            this.lblAddNewCategoryDis.Name = "lblAddNewCategoryDis";
            this.lblAddNewCategoryDis.Size = new System.Drawing.Size(197, 18);
            this.lblAddNewCategoryDis.TabIndex = 1;
            this.lblAddNewCategoryDis.Text = "املأ البيانات التالية لإضافة صنف جديد";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblItemName.Location = new System.Drawing.Point(154, 88);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(79, 21);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "اسم الصنف";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtItemName.BorderRadius = 8;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.DefaultText = "";
            this.txtItemName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtItemName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtItemName.Location = new System.Drawing.Point(14, 110);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PlaceholderText = "";
            this.txtItemName.SelectedText = "";
            this.txtItemName.Size = new System.Drawing.Size(228, 36);
            this.txtItemName.TabIndex = 2;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblItemCode.Location = new System.Drawing.Point(397, 85);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(78, 21);
            this.lblItemCode.TabIndex = 3;
            this.lblItemCode.Text = "كود الصنف";
            // 
            // txtItemCode
            // 
            this.txtItemCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtItemCode.BorderRadius = 8;
            this.txtItemCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemCode.DefaultText = "";
            this.txtItemCode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtItemCode.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtItemCode.Location = new System.Drawing.Point(258, 110);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.PlaceholderText = "";
            this.txtItemCode.SelectedText = "";
            this.txtItemCode.Size = new System.Drawing.Size(228, 36);
            this.txtItemCode.TabIndex = 4;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblUnit.Location = new System.Drawing.Point(183, 158);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(50, 21);
            this.lblUnit.TabIndex = 5;
            this.lblUnit.Text = "الوحدة";
            // 
            // cmbUnit
            // 
            this.cmbUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cmbUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbUnit.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(14, 182);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbUnit.Size = new System.Drawing.Size(228, 29);
            this.cmbUnit.TabIndex = 6;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblCategory.Location = new System.Drawing.Point(438, 158);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(37, 21);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "الفئة";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategory.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(258, 182);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbCategory.Size = new System.Drawing.Size(228, 29);
            this.cmbCategory.TabIndex = 8;
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblMinimum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblMinimum.Location = new System.Drawing.Point(162, 223);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(71, 21);
            this.lblMinimum.TabIndex = 9;
            this.lblMinimum.Text = "الحد الادنى";
            // 
            // txtMinimum
            // 
            this.txtMinimum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtMinimum.BorderRadius = 8;
            this.txtMinimum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinimum.DefaultText = "";
            this.txtMinimum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtMinimum.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtMinimum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtMinimum.Location = new System.Drawing.Point(14, 248);
            this.txtMinimum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinimum.Name = "txtMinimum";
            this.txtMinimum.PlaceholderText = "";
            this.txtMinimum.SelectedText = "";
            this.txtMinimum.Size = new System.Drawing.Size(228, 36);
            this.txtMinimum.TabIndex = 10;
            // 
            // lblEstimatedValue
            // 
            this.lblEstimatedValue.AutoSize = true;
            this.lblEstimatedValue.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblEstimatedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEstimatedValue.Location = new System.Drawing.Point(375, 226);
            this.lblEstimatedValue.Name = "lblEstimatedValue";
            this.lblEstimatedValue.Size = new System.Drawing.Size(100, 21);
            this.lblEstimatedValue.TabIndex = 11;
            this.lblEstimatedValue.Text = "القيمة التقديرية";
            // 
            // txtEstimatedValue
            // 
            this.txtEstimatedValue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtEstimatedValue.BorderRadius = 8;
            this.txtEstimatedValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEstimatedValue.DefaultText = "";
            this.txtEstimatedValue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtEstimatedValue.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtEstimatedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtEstimatedValue.Location = new System.Drawing.Point(258, 248);
            this.txtEstimatedValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEstimatedValue.Name = "txtEstimatedValue";
            this.txtEstimatedValue.PlaceholderText = "";
            this.txtEstimatedValue.SelectedText = "";
            this.txtEstimatedValue.Size = new System.Drawing.Size(228, 36);
            this.txtEstimatedValue.TabIndex = 12;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDescription.Location = new System.Drawing.Point(429, 295);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(46, 21);
            this.lblDescription.TabIndex = 13;
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
            this.txtDescription.Location = new System.Drawing.Point(14, 320);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(472, 36);
            this.txtDescription.TabIndex = 14;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 10;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnSave.Location = new System.Drawing.Point(14, 374);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 40);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "حفظ";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCancel.Location = new System.Drawing.Point(258, 374);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(228, 40);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddNewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(530, 458);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddNewCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewCategory";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCard;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label lblAddNewCategory;
        private System.Windows.Forms.Label lblAddNewCategoryDis;
        private System.Windows.Forms.Label lblItemName;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private System.Windows.Forms.Label lblItemCode;
        private Guna.UI2.WinForms.Guna2TextBox txtItemCode;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblMinimum;
        private Guna.UI2.WinForms.Guna2TextBox txtMinimum;
        private System.Windows.Forms.Label lblEstimatedValue;
        private Guna.UI2.WinForms.Guna2TextBox txtEstimatedValue;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
