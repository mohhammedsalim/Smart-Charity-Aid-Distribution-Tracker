namespace Smart_Charity_and_Aid_Distribution_Tracker.Users
{
    partial class frmUser
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
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBackToDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlUserManagement = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUserManagement = new System.Windows.Forms.Label();
            this.btnAddNewUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnResetPassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnDataModification = new Guna.UI2.WinForms.Guna2Button();
            this.pnlUserDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUserDetails = new System.Windows.Forms.Label();
            this.pnlSep1 = new System.Windows.Forms.Panel();
            this.lblEmployeeNumber = new System.Windows.Forms.Label();
            this.lblEmployeeNumberText = new System.Windows.Forms.Label();
            this.pnlSep2 = new System.Windows.Forms.Panel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblFullNameText = new System.Windows.Forms.Label();
            this.pnlSep3 = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblUserNameText = new System.Windows.Forms.Label();
            this.pnlSep4 = new System.Windows.Forms.Panel();
            this.lblValidity = new System.Windows.Forms.Label();
            this.lblValidityText = new System.Windows.Forms.Label();
            this.lblAccountStatus = new System.Windows.Forms.Label();
            this.lblAccountStatusText = new System.Windows.Forms.Label();
            this.pnlUserList = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUserList = new System.Windows.Forms.Label();
            this.picUserList = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTextUserList = new System.Windows.Forms.Label();
            this.lblNumberUserList = new System.Windows.Forms.Label();
            this.dgvUserList = new System.Windows.Forms.DataGridView();
            this.pnlTopBar.SuspendLayout();
            this.pnlUserManagement.SuspendLayout();
            this.pnlUserDetails.SuspendLayout();
            this.pnlUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopBar.Controls.Add(this.btnBackToDashBoard);
            this.pnlTopBar.Controls.Add(this.lblFormTitle);
            this.pnlTopBar.FillColor = System.Drawing.Color.White;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1312, 54);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnBackToDashBoard
            // 
            this.btnBackToDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToDashBoard.BorderRadius = 8;
            this.btnBackToDashBoard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnBackToDashBoard.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBackToDashBoard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnBackToDashBoard.Location = new System.Drawing.Point(1072, 8);
            this.btnBackToDashBoard.Name = "btnBackToDashBoard";
            this.btnBackToDashBoard.Size = new System.Drawing.Size(224, 38);
            this.btnBackToDashBoard.TabIndex = 0;
            this.btnBackToDashBoard.Text = "العودة إلى لوحة التحكم";
            this.btnBackToDashBoard.Click += new System.EventHandler(this.btnBackToDashBoard_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblFormTitle.Location = new System.Drawing.Point(572, 14);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(159, 29);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "إدارة المستخدمين";
            // 
            // pnlUserManagement
            // 
            this.pnlUserManagement.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserManagement.BorderRadius = 12;
            this.pnlUserManagement.Controls.Add(this.lblUserManagement);
            this.pnlUserManagement.Controls.Add(this.btnAddNewUser);
            this.pnlUserManagement.Controls.Add(this.btnDeleteUser);
            this.pnlUserManagement.Controls.Add(this.btnResetPassword);
            this.pnlUserManagement.Controls.Add(this.btnDataModification);
            this.pnlUserManagement.FillColor = System.Drawing.Color.White;
            this.pnlUserManagement.Location = new System.Drawing.Point(16, 62);
            this.pnlUserManagement.Name = "pnlUserManagement";
            this.pnlUserManagement.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlUserManagement.ShadowDecoration.Depth = 8;
            this.pnlUserManagement.ShadowDecoration.Enabled = true;
            this.pnlUserManagement.Size = new System.Drawing.Size(498, 146);
            this.pnlUserManagement.TabIndex = 1;
            // 
            // lblUserManagement
            // 
            this.lblUserManagement.AutoSize = true;
            this.lblUserManagement.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblUserManagement.Location = new System.Drawing.Point(350, 14);
            this.lblUserManagement.Name = "lblUserManagement";
            this.lblUserManagement.Size = new System.Drawing.Size(109, 24);
            this.lblUserManagement.TabIndex = 0;
            this.lblUserManagement.Text = "إدارة المستفيد";
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.BorderRadius = 10;
            this.btnAddNewUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnAddNewUser.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddNewUser.ForeColor = System.Drawing.Color.White;
            this.btnAddNewUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnAddNewUser.Location = new System.Drawing.Point(249, 50);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(231, 39);
            this.btnAddNewUser.TabIndex = 1;
            this.btnAddNewUser.Text = "إضافة مستخدم جديد";
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeleteUser.BorderRadius = 10;
            this.btnDeleteUser.BorderThickness = 1;
            this.btnDeleteUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnDeleteUser.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeleteUser.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.btnDeleteUser.Location = new System.Drawing.Point(18, 50);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(224, 39);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "حذف المستخدم";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BorderRadius = 10;
            this.btnResetPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnResetPassword.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnResetPassword.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnResetPassword.Location = new System.Drawing.Point(249, 98);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(231, 39);
            this.btnResetPassword.TabIndex = 3;
            this.btnResetPassword.Text = "إعادة تعيين كلمة المرور";
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnDataModification
            // 
            this.btnDataModification.BorderRadius = 10;
            this.btnDataModification.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDataModification.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnDataModification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDataModification.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnDataModification.Location = new System.Drawing.Point(18, 98);
            this.btnDataModification.Name = "btnDataModification";
            this.btnDataModification.Size = new System.Drawing.Size(224, 39);
            this.btnDataModification.TabIndex = 4;
            this.btnDataModification.Text = "تعديل البيانات";
            this.btnDataModification.Click += new System.EventHandler(this.btnDataModification_Click);
            // 
            // pnlUserDetails
            // 
            this.pnlUserDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUserDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserDetails.BorderRadius = 12;
            this.pnlUserDetails.Controls.Add(this.lblUserDetails);
            this.pnlUserDetails.Controls.Add(this.pnlSep1);
            this.pnlUserDetails.Controls.Add(this.lblEmployeeNumber);
            this.pnlUserDetails.Controls.Add(this.lblEmployeeNumberText);
            this.pnlUserDetails.Controls.Add(this.pnlSep2);
            this.pnlUserDetails.Controls.Add(this.lblFullName);
            this.pnlUserDetails.Controls.Add(this.lblFullNameText);
            this.pnlUserDetails.Controls.Add(this.pnlSep3);
            this.pnlUserDetails.Controls.Add(this.lblUserName);
            this.pnlUserDetails.Controls.Add(this.lblUserNameText);
            this.pnlUserDetails.Controls.Add(this.pnlSep4);
            this.pnlUserDetails.Controls.Add(this.lblValidity);
            this.pnlUserDetails.Controls.Add(this.lblValidityText);
            this.pnlUserDetails.Controls.Add(this.lblAccountStatus);
            this.pnlUserDetails.Controls.Add(this.lblAccountStatusText);
            this.pnlUserDetails.FillColor = System.Drawing.Color.White;
            this.pnlUserDetails.Location = new System.Drawing.Point(16, 224);
            this.pnlUserDetails.Name = "pnlUserDetails";
            this.pnlUserDetails.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlUserDetails.ShadowDecoration.Depth = 8;
            this.pnlUserDetails.ShadowDecoration.Enabled = true;
            this.pnlUserDetails.Size = new System.Drawing.Size(498, 452);
            this.pnlUserDetails.TabIndex = 2;
            // 
            // lblUserDetails
            // 
            this.lblUserDetails.AutoSize = true;
            this.lblUserDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblUserDetails.Location = new System.Drawing.Point(310, 14);
            this.lblUserDetails.Name = "lblUserDetails";
            this.lblUserDetails.Size = new System.Drawing.Size(138, 24);
            this.lblUserDetails.TabIndex = 0;
            this.lblUserDetails.Text = "تفاصيل المستخدم";
            // 
            // pnlSep1
            // 
            this.pnlSep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep1.Location = new System.Drawing.Point(4, 117);
            this.pnlSep1.Name = "pnlSep1";
            this.pnlSep1.Size = new System.Drawing.Size(488, 1);
            this.pnlSep1.TabIndex = 1;
            // 
            // lblEmployeeNumber
            // 
            this.lblEmployeeNumber.AutoSize = true;
            this.lblEmployeeNumber.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblEmployeeNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblEmployeeNumber.Location = new System.Drawing.Point(360, 60);
            this.lblEmployeeNumber.Name = "lblEmployeeNumber";
            this.lblEmployeeNumber.Size = new System.Drawing.Size(81, 21);
            this.lblEmployeeNumber.TabIndex = 2;
            this.lblEmployeeNumber.Text = "رقم الموظف";
            // 
            // lblEmployeeNumberText
            // 
            this.lblEmployeeNumberText.AutoSize = true;
            this.lblEmployeeNumberText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeNumberText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblEmployeeNumberText.Location = new System.Drawing.Point(355, 82);
            this.lblEmployeeNumberText.Name = "lblEmployeeNumberText";
            this.lblEmployeeNumberText.Size = new System.Drawing.Size(96, 23);
            this.lblEmployeeNumberText.TabIndex = 3;
            this.lblEmployeeNumberText.Text = "0000-0000";
            this.lblEmployeeNumberText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlSep2
            // 
            this.pnlSep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep2.Location = new System.Drawing.Point(4, 190);
            this.pnlSep2.Name = "pnlSep2";
            this.pnlSep2.Size = new System.Drawing.Size(488, 1);
            this.pnlSep2.TabIndex = 4;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblFullName.Location = new System.Drawing.Point(360, 140);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(85, 21);
            this.lblFullName.TabIndex = 5;
            this.lblFullName.Text = "الاسم بالكامل";
            // 
            // lblFullNameText
            // 
            this.lblFullNameText.AutoSize = true;
            this.lblFullNameText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblFullNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblFullNameText.Location = new System.Drawing.Point(220, 160);
            this.lblFullNameText.Name = "lblFullNameText";
            this.lblFullNameText.Size = new System.Drawing.Size(216, 23);
            this.lblFullNameText.TabIndex = 6;
            this.lblFullNameText.Text = "xxxxxxxx xxxxx xxxxxxxxx";
            this.lblFullNameText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlSep3
            // 
            this.pnlSep3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep3.Location = new System.Drawing.Point(4, 256);
            this.pnlSep3.Name = "pnlSep3";
            this.pnlSep3.Size = new System.Drawing.Size(488, 1);
            this.pnlSep3.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblUserName.Location = new System.Drawing.Point(342, 206);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 21);
            this.lblUserName.TabIndex = 8;
            this.lblUserName.Text = "اسم المستخدم";
            // 
            // lblUserNameText
            // 
            this.lblUserNameText.AutoSize = true;
            this.lblUserNameText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblUserNameText.Location = new System.Drawing.Point(294, 229);
            this.lblUserNameText.Name = "lblUserNameText";
            this.lblUserNameText.Size = new System.Drawing.Size(140, 23);
            this.lblUserNameText.TabIndex = 9;
            this.lblUserNameText.Text = "XXXXXXXXXXXXX";
            this.lblUserNameText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlSep4
            // 
            this.pnlSep4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep4.Location = new System.Drawing.Point(4, 329);
            this.pnlSep4.Name = "pnlSep4";
            this.pnlSep4.Size = new System.Drawing.Size(488, 1);
            this.pnlSep4.TabIndex = 10;
            // 
            // lblValidity
            // 
            this.lblValidity.AutoSize = true;
            this.lblValidity.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblValidity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblValidity.Location = new System.Drawing.Point(376, 277);
            this.lblValidity.Name = "lblValidity";
            this.lblValidity.Size = new System.Drawing.Size(61, 21);
            this.lblValidity.TabIndex = 11;
            this.lblValidity.Text = "الصلاحية";
            // 
            // lblValidityText
            // 
            this.lblValidityText.AutoSize = true;
            this.lblValidityText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblValidityText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblValidityText.Location = new System.Drawing.Point(368, 299);
            this.lblValidityText.Name = "lblValidityText";
            this.lblValidityText.Size = new System.Drawing.Size(70, 23);
            this.lblValidityText.TabIndex = 12;
            this.lblValidityText.Text = "XXXXXX";
            this.lblValidityText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAccountStatus
            // 
            this.lblAccountStatus.AutoSize = true;
            this.lblAccountStatus.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblAccountStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblAccountStatus.Location = new System.Drawing.Point(350, 350);
            this.lblAccountStatus.Name = "lblAccountStatus";
            this.lblAccountStatus.Size = new System.Drawing.Size(86, 21);
            this.lblAccountStatus.TabIndex = 13;
            this.lblAccountStatus.Text = "حالة الحساب";
            // 
            // lblAccountStatusText
            // 
            this.lblAccountStatusText.AutoSize = true;
            this.lblAccountStatusText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblAccountStatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblAccountStatusText.Location = new System.Drawing.Point(316, 372);
            this.lblAccountStatusText.Name = "lblAccountStatusText";
            this.lblAccountStatusText.Size = new System.Drawing.Size(120, 23);
            this.lblAccountStatusText.TabIndex = 14;
            this.lblAccountStatusText.Text = "XXXXXXXXXXX";
            this.lblAccountStatusText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlUserList
            // 
            this.pnlUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUserList.BackColor = System.Drawing.Color.Transparent;
            this.pnlUserList.BorderRadius = 12;
            this.pnlUserList.Controls.Add(this.lblUserList);
            this.pnlUserList.Controls.Add(this.picUserList);
            this.pnlUserList.Controls.Add(this.lblTextUserList);
            this.pnlUserList.Controls.Add(this.lblNumberUserList);
            this.pnlUserList.Controls.Add(this.dgvUserList);
            this.pnlUserList.FillColor = System.Drawing.Color.White;
            this.pnlUserList.Location = new System.Drawing.Point(523, 62);
            this.pnlUserList.Name = "pnlUserList";
            this.pnlUserList.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlUserList.ShadowDecoration.Depth = 8;
            this.pnlUserList.ShadowDecoration.Enabled = true;
            this.pnlUserList.Size = new System.Drawing.Size(773, 614);
            this.pnlUserList.TabIndex = 3;
            // 
            // lblUserList
            // 
            this.lblUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserList.AutoSize = true;
            this.lblUserList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblUserList.Location = new System.Drawing.Point(570, 22);
            this.lblUserList.Name = "lblUserList";
            this.lblUserList.Size = new System.Drawing.Size(135, 24);
            this.lblUserList.TabIndex = 0;
            this.lblUserList.Text = "قائمة المستخدمين";
            // 
            // picUserList
            // 
            this.picUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUserList.ImageRotate = 0F;
            this.picUserList.Location = new System.Drawing.Point(719, 22);
            this.picUserList.Name = "picUserList";
            this.picUserList.Size = new System.Drawing.Size(24, 25);
            this.picUserList.TabIndex = 1;
            this.picUserList.TabStop = false;
            // 
            // lblTextUserList
            // 
            this.lblTextUserList.AutoSize = true;
            this.lblTextUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.lblTextUserList.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblTextUserList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblTextUserList.Location = new System.Drawing.Point(19, 30);
            this.lblTextUserList.Name = "lblTextUserList";
            this.lblTextUserList.Size = new System.Drawing.Size(55, 18);
            this.lblTextUserList.TabIndex = 2;
            this.lblTextUserList.Text = "مستخدم";
            // 
            // lblNumberUserList
            // 
            this.lblNumberUserList.AutoSize = true;
            this.lblNumberUserList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.lblNumberUserList.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumberUserList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumberUserList.Location = new System.Drawing.Point(75, 30);
            this.lblNumberUserList.Name = "lblNumberUserList";
            this.lblNumberUserList.Size = new System.Drawing.Size(36, 18);
            this.lblNumberUserList.TabIndex = 3;
            this.lblNumberUserList.Text = "0000";
            // 
            // dgvUserList
            // 
            this.dgvUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserList.BackgroundColor = System.Drawing.Color.White;
            this.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvUserList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserList.EnableHeadersVisualStyles = false;
            this.dgvUserList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvUserList.Location = new System.Drawing.Point(12, 60);
            this.dgvUserList.Name = "dgvUserList";
            this.dgvUserList.RowHeadersWidth = 62;
            this.dgvUserList.Size = new System.Drawing.Size(745, 534);
            this.dgvUserList.TabIndex = 4;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlUserManagement);
            this.Controls.Add(this.pnlUserDetails);
            this.Controls.Add(this.pnlUserList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "المستخدمين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUser_FormClosed);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlUserManagement.ResumeLayout(false);
            this.pnlUserManagement.PerformLayout();
            this.pnlUserDetails.ResumeLayout(false);
            this.pnlUserDetails.PerformLayout();
            this.pnlUserList.ResumeLayout(false);
            this.pnlUserList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private Guna.UI2.WinForms.Guna2Button btnBackToDashBoard;
        private System.Windows.Forms.Label lblFormTitle;

        private Guna.UI2.WinForms.Guna2Panel pnlUserManagement;
        private System.Windows.Forms.Label lblUserManagement;
        private Guna.UI2.WinForms.Guna2Button btnAddNewUser;
        private Guna.UI2.WinForms.Guna2Button btnDeleteUser;
        private Guna.UI2.WinForms.Guna2Button btnResetPassword;
        private Guna.UI2.WinForms.Guna2Button btnDataModification;

        private Guna.UI2.WinForms.Guna2Panel pnlUserDetails;
        private System.Windows.Forms.Label lblUserDetails;
        private System.Windows.Forms.Panel pnlSep1;
        private System.Windows.Forms.Label lblEmployeeNumber;
        private System.Windows.Forms.Label lblEmployeeNumberText;
        private System.Windows.Forms.Panel pnlSep2;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblFullNameText;
        private System.Windows.Forms.Panel pnlSep3;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblUserNameText;
        private System.Windows.Forms.Panel pnlSep4;
        private System.Windows.Forms.Label lblValidity;
        private System.Windows.Forms.Label lblValidityText;
        private System.Windows.Forms.Label lblAccountStatus;
        private System.Windows.Forms.Label lblAccountStatusText;

        private Guna.UI2.WinForms.Guna2Panel pnlUserList;
        private System.Windows.Forms.Label lblUserList;
        private Guna.UI2.WinForms.Guna2PictureBox picUserList;
        private System.Windows.Forms.Label lblTextUserList;
        private System.Windows.Forms.Label lblNumberUserList;
        private System.Windows.Forms.DataGridView dgvUserList;
    }
}
