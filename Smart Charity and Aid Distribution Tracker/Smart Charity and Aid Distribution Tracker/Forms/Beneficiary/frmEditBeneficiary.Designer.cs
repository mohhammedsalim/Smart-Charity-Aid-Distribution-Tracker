namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    partial class frmEditBeneficiary
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
            this.components = new System.ComponentModel.Container();
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNationalID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNationalID = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFamilySize = new System.Windows.Forms.Label();
            this.numFamilySize = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmbSocialStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSocialStatus = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.dtpRegistrationDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.txtNeedReason = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNeedReason = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFamilySize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.pnlTopBar.Controls.Add(this.lblTitle);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(850, 60);
            this.pnlTopBar.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(308, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(165, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "تعديل مستفيد";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pnlTopBar;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblFullName.Location = new System.Drawing.Point(446, 90);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(87, 21);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "الاسم بالكامل";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderRadius = 8;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtFullName.Location = new System.Drawing.Point(450, 115);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderText = "";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(370, 36);
            this.txtFullName.TabIndex = 1;
            // 
            // txtNationalID
            // 
            this.txtNationalID.BorderRadius = 8;
            this.txtNationalID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNationalID.DefaultText = "";
            this.txtNationalID.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtNationalID.Location = new System.Drawing.Point(30, 115);
            this.txtNationalID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.PlaceholderText = "";
            this.txtNationalID.SelectedText = "";
            this.txtNationalID.Size = new System.Drawing.Size(370, 36);
            this.txtNationalID.TabIndex = 2;
            // 
            // lblNationalID
            // 
            this.lblNationalID.AutoSize = true;
            this.lblNationalID.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblNationalID.Location = new System.Drawing.Point(26, 90);
            this.lblNationalID.Name = "lblNationalID";
            this.lblNationalID.Size = new System.Drawing.Size(80, 21);
            this.lblNationalID.TabIndex = 3;
            this.lblNationalID.Text = "الرقم الوطني";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 8;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtPhone.Location = new System.Drawing.Point(450, 200);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(370, 36);
            this.txtPhone.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhone.Location = new System.Drawing.Point(446, 175);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(72, 21);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "رقم الهاتف";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderRadius = 8;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtAddress.Location = new System.Drawing.Point(30, 200);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(370, 36);
            this.txtAddress.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(26, 175);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(49, 21);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "العنوان";
            // 
            // lblFamilySize
            // 
            this.lblFamilySize.AutoSize = true;
            this.lblFamilySize.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblFamilySize.Location = new System.Drawing.Point(446, 260);
            this.lblFamilySize.Name = "lblFamilySize";
            this.lblFamilySize.Size = new System.Drawing.Size(100, 21);
            this.lblFamilySize.TabIndex = 9;
            this.lblFamilySize.Text = "عدد أفراد الأسرة";
            // 
            // numFamilySize
            // 
            this.numFamilySize.BackColor = System.Drawing.Color.Transparent;
            this.numFamilySize.BorderRadius = 8;
            this.numFamilySize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numFamilySize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numFamilySize.Location = new System.Drawing.Point(450, 285);
            this.numFamilySize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFamilySize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFamilySize.Name = "numFamilySize";
            this.numFamilySize.Size = new System.Drawing.Size(370, 36);
            this.numFamilySize.TabIndex = 5;
            this.numFamilySize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbSocialStatus
            // 
            this.cmbSocialStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbSocialStatus.BorderRadius = 8;
            this.cmbSocialStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSocialStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSocialStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSocialStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSocialStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSocialStatus.ItemHeight = 30;
            this.cmbSocialStatus.Items.AddRange(new object[] {
            "متزوج",
            "أعزب",
            "أرملة",
            "مطلقة",
            "يتيم"});
            this.cmbSocialStatus.Location = new System.Drawing.Point(30, 285);
            this.cmbSocialStatus.Name = "cmbSocialStatus";
            this.cmbSocialStatus.Size = new System.Drawing.Size(370, 36);
            this.cmbSocialStatus.TabIndex = 6;
            // 
            // lblSocialStatus
            // 
            this.lblSocialStatus.AutoSize = true;
            this.lblSocialStatus.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblSocialStatus.Location = new System.Drawing.Point(26, 260);
            this.lblSocialStatus.Name = "lblSocialStatus";
            this.lblSocialStatus.Size = new System.Drawing.Size(109, 21);
            this.lblSocialStatus.TabIndex = 12;
            this.lblSocialStatus.Text = "الحالة الاجتماعية";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegistrationDate.Location = new System.Drawing.Point(446, 441);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(95, 21);
            this.lblRegistrationDate.TabIndex = 13;
            this.lblRegistrationDate.Text = "تاريخ التسجيل";
            // 
            // dtpRegistrationDate
            // 
            this.dtpRegistrationDate.BorderRadius = 8;
            this.dtpRegistrationDate.Checked = true;
            this.dtpRegistrationDate.FillColor = System.Drawing.Color.White;
            this.dtpRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpRegistrationDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpRegistrationDate.Location = new System.Drawing.Point(450, 465);
            this.dtpRegistrationDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpRegistrationDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpRegistrationDate.Name = "dtpRegistrationDate";
            this.dtpRegistrationDate.Size = new System.Drawing.Size(370, 36);
            this.dtpRegistrationDate.TabIndex = 8;
            this.dtpRegistrationDate.Value = new System.DateTime(2024, 5, 21, 15, 3, 2, 60);
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 8;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtNotes.Location = new System.Drawing.Point(30, 465);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(370, 100);
            this.txtNotes.TabIndex = 9;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotes.Location = new System.Drawing.Point(26, 440);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(67, 21);
            this.lblNotes.TabIndex = 16;
            this.lblNotes.Text = "ملاحظات";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(450, 590);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "حفظ";
            this.btnSave.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCancel.Location = new System.Drawing.Point(220, 590);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "إلغاء";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtNeedReason
            // 
            this.txtNeedReason.BorderRadius = 8;
            this.txtNeedReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNeedReason.DefaultText = "";
            this.txtNeedReason.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtNeedReason.Location = new System.Drawing.Point(30, 355);
            this.txtNeedReason.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNeedReason.Multiline = true;
            this.txtNeedReason.Name = "txtNeedReason";
            this.txtNeedReason.PlaceholderText = "";
            this.txtNeedReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNeedReason.SelectedText = "";
            this.txtNeedReason.Size = new System.Drawing.Size(790, 60);
            this.txtNeedReason.TabIndex = 7;
            // 
            // lblNeedReason
            // 
            this.lblNeedReason.AutoSize = true;
            this.lblNeedReason.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblNeedReason.Location = new System.Drawing.Point(26, 330);
            this.lblNeedReason.Name = "lblNeedReason";
            this.lblNeedReason.Size = new System.Drawing.Size(93, 21);
            this.lblNeedReason.TabIndex = 22;
            this.lblNeedReason.Text = "سبب الاحتياج";
            // 
            // frmEditBeneficiary
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.Controls.Add(this.lblNeedReason);
            this.Controls.Add(this.txtNeedReason);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.dtpRegistrationDate);
            this.Controls.Add(this.lblRegistrationDate);
            this.Controls.Add(this.lblSocialStatus);
            this.Controls.Add(this.cmbSocialStatus);
            this.Controls.Add(this.numFamilySize);
            this.Controls.Add(this.lblFamilySize);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtNationalID);
            this.Controls.Add(this.lblNationalID);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditBeneficiary";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تعديل بيانات مستفيد";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFamilySize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtNationalID;
        private System.Windows.Forms.Label lblNationalID;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFamilySize;
        private Guna.UI2.WinForms.Guna2NumericUpDown numFamilySize;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSocialStatus;
        private System.Windows.Forms.Label lblSocialStatus;
        private System.Windows.Forms.Label lblRegistrationDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpRegistrationDate;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2TextBox txtNeedReason;
        private System.Windows.Forms.Label lblNeedReason;
    }
}