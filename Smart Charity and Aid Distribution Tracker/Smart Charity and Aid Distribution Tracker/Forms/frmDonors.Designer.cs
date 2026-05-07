namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    partial class frmDonors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBackToDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvDonorsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cmbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSmart = new System.Windows.Forms.Panel();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.cmbDonorType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelDonorType = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.pnlView = new System.Windows.Forms.Panel();
            this.lblNotesText = new System.Windows.Forms.Label();
            this.labelNotesView = new System.Windows.Forms.Label();
            this.lblAddressText = new System.Windows.Forms.Label();
            this.labelAddressView = new System.Windows.Forms.Label();
            this.lblDonorTypeText = new System.Windows.Forms.Label();
            this.labelDonorTypeView = new System.Windows.Forms.Label();
            this.lblEmailText = new System.Windows.Forms.Label();
            this.labelEmailView = new System.Windows.Forms.Label();
            this.lblPhoneText = new System.Windows.Forms.Label();
            this.labelPhoneView = new System.Windows.Forms.Label();
            this.lblFullNameText = new System.Windows.Forms.Label();
            this.labelFullNameView = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNew = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonorsList)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlSmart.SuspendLayout();
            this.pnlInputs.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.btnBackToDashBoard);
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // btnBackToDashBoard
            // 
            this.btnBackToDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToDashBoard.BorderRadius = 8;
            this.btnBackToDashBoard.FillColor = System.Drawing.Color.White;
            this.btnBackToDashBoard.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBackToDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackToDashBoard.Location = new System.Drawing.Point(1038, 12);
            this.btnBackToDashBoard.Name = "btnBackToDashBoard";
            this.btnBackToDashBoard.Size = new System.Drawing.Size(150, 40);
            this.btnBackToDashBoard.TabIndex = 1;
            this.btnBackToDashBoard.Text = "العودة للرئيسية";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFormTitle.Location = new System.Drawing.Point(12, 16);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(135, 29);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "إدارة المتبرعين";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvDonorsList);
            this.pnlBody.Controls.Add(this.pnlSearch);
            this.pnlBody.Controls.Add(this.pnlSmart);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBody.Size = new System.Drawing.Size(1200, 661);
            this.pnlBody.TabIndex = 1;
            // 
            // dgvDonorsList
            // 
            this.dgvDonorsList.AllowUserToAddRows = false;
            this.dgvDonorsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDonorsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonorsList.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonorsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonorsList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonorsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonorsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonorsList.Location = new System.Drawing.Point(440, 70);
            this.dgvDonorsList.MultiSelect = false;
            this.dgvDonorsList.Name = "dgvDonorsList";
            this.dgvDonorsList.ReadOnly = true;
            this.dgvDonorsList.RowHeadersVisible = false;
            this.dgvDonorsList.RowTemplate.Height = 30;
            this.dgvDonorsList.Size = new System.Drawing.Size(750, 581);
            this.dgvDonorsList.TabIndex = 2;
            this.dgvDonorsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDonorsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dgvDonorsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.cmbSearch);
            this.pnlSearch.Controls.Add(this.btnClear);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(440, 10);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(750, 60);
            this.pnlSearch.TabIndex = 1;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cmbSearch.BorderRadius = 6;
            this.cmbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSearch.ItemHeight = 34;
            this.cmbSearch.Location = new System.Drawing.Point(594, 10);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(150, 40);
            this.cmbSearch.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 8;
            this.btnClear.FillColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Location = new System.Drawing.Point(16, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "مسح";
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(112, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 40);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "بحث";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 6;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtSearch.Location = new System.Drawing.Point(288, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "ابحث هنا...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(300, 40);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlSmart
            // 
            this.pnlSmart.BackColor = System.Drawing.Color.White;
            this.pnlSmart.Controls.Add(this.pnlInputs);
            this.pnlSmart.Controls.Add(this.pnlView);
            this.pnlSmart.Controls.Add(this.pnlActions);
            this.pnlSmart.Controls.Add(this.lblPanelTitle);
            this.pnlSmart.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSmart.Location = new System.Drawing.Point(10, 10);
            this.pnlSmart.Name = "pnlSmart";
            this.pnlSmart.Size = new System.Drawing.Size(430, 641);
            this.pnlSmart.TabIndex = 0;
            // 
            // pnlInputs
            // 
            this.pnlInputs.AutoScroll = true;
            this.pnlInputs.Controls.Add(this.txtNotes);
            this.pnlInputs.Controls.Add(this.labelNotes);
            this.pnlInputs.Controls.Add(this.txtAddress);
            this.pnlInputs.Controls.Add(this.labelAddress);
            this.pnlInputs.Controls.Add(this.cmbDonorType);
            this.pnlInputs.Controls.Add(this.labelDonorType);
            this.pnlInputs.Controls.Add(this.txtEmail);
            this.pnlInputs.Controls.Add(this.labelEmail);
            this.pnlInputs.Controls.Add(this.txtPhone);
            this.pnlInputs.Controls.Add(this.labelPhone);
            this.pnlInputs.Controls.Add(this.txtFullName);
            this.pnlInputs.Controls.Add(this.labelFullName);
            this.pnlInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputs.Location = new System.Drawing.Point(0, 40);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(430, 471);
            this.pnlInputs.TabIndex = 3;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 6;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtNotes.Location = new System.Drawing.Point(32, 410);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "ملاحظات إضافية...";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(366, 60);
            this.txtNotes.TabIndex = 11;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelNotes.Location = new System.Drawing.Point(341, 388);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(57, 18);
            this.labelNotes.TabIndex = 10;
            this.labelNotes.Text = "ملاحظات";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderRadius = 6;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtAddress.Location = new System.Drawing.Point(32, 340);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "العنوان...";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(366, 40);
            this.txtAddress.TabIndex = 9;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelAddress.Location = new System.Drawing.Point(351, 318);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(47, 18);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "العنوان";
            // 
            // cmbDonorType
            // 
            this.cmbDonorType.BackColor = System.Drawing.Color.Transparent;
            this.cmbDonorType.BorderRadius = 6;
            this.cmbDonorType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDonorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonorType.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbDonorType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDonorType.ItemHeight = 34;
            this.cmbDonorType.Location = new System.Drawing.Point(32, 270);
            this.cmbDonorType.Name = "cmbDonorType";
            this.cmbDonorType.Size = new System.Drawing.Size(366, 40);
            this.cmbDonorType.TabIndex = 7;
            // 
            // labelDonorType
            // 
            this.labelDonorType.AutoSize = true;
            this.labelDonorType.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelDonorType.Location = new System.Drawing.Point(323, 248);
            this.labelDonorType.Name = "labelDonorType";
            this.labelDonorType.Size = new System.Drawing.Size(75, 18);
            this.labelDonorType.TabIndex = 6;
            this.labelDonorType.Text = "نوع المتبرع";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 6;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtEmail.Location = new System.Drawing.Point(32, 200);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "البريد الإلكتروني...";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(366, 40);
            this.txtEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelEmail.Location = new System.Drawing.Point(296, 178);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(102, 18);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "البريد الإلكتروني";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderRadius = 6;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtPhone.Location = new System.Drawing.Point(32, 130);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "رقم الهاتف...";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(366, 40);
            this.txtPhone.TabIndex = 3;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelPhone.Location = new System.Drawing.Point(326, 108);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(72, 18);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "رقم الهاتف";
            // 
            // txtFullName
            // 
            this.txtFullName.BorderRadius = 6;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtFullName.Location = new System.Drawing.Point(32, 60);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PlaceholderText = "اسم المتبرع أو الجهة...";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(366, 40);
            this.txtFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelFullName.Location = new System.Drawing.Point(318, 38);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(80, 18);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "اسم المتبرع";
            // 
            // pnlView
            // 
            this.pnlView.AutoScroll = true;
            this.pnlView.Controls.Add(this.lblNotesText);
            this.pnlView.Controls.Add(this.labelNotesView);
            this.pnlView.Controls.Add(this.lblAddressText);
            this.pnlView.Controls.Add(this.labelAddressView);
            this.pnlView.Controls.Add(this.lblDonorTypeText);
            this.pnlView.Controls.Add(this.labelDonorTypeView);
            this.pnlView.Controls.Add(this.lblEmailText);
            this.pnlView.Controls.Add(this.labelEmailView);
            this.pnlView.Controls.Add(this.lblPhoneText);
            this.pnlView.Controls.Add(this.labelPhoneView);
            this.pnlView.Controls.Add(this.lblFullNameText);
            this.pnlView.Controls.Add(this.labelFullNameView);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 40);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(430, 471);
            this.pnlView.TabIndex = 4;
            // 
            // lblNotesText
            // 
            this.lblNotesText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNotesText.Location = new System.Drawing.Point(32, 350);
            this.lblNotesText.Name = "lblNotesText";
            this.lblNotesText.Size = new System.Drawing.Size(366, 60);
            this.lblNotesText.TabIndex = 11;
            this.lblNotesText.Text = "----";
            // 
            // labelNotesView
            // 
            this.labelNotesView.AutoSize = true;
            this.labelNotesView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelNotesView.Location = new System.Drawing.Point(341, 328);
            this.labelNotesView.Name = "labelNotesView";
            this.labelNotesView.Size = new System.Drawing.Size(57, 18);
            this.labelNotesView.TabIndex = 10;
            this.labelNotesView.Text = "ملاحظات";
            // 
            // lblAddressText
            // 
            this.lblAddressText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddressText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddressText.Location = new System.Drawing.Point(32, 280);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(366, 23);
            this.lblAddressText.TabIndex = 9;
            this.lblAddressText.Text = "----";
            // 
            // labelAddressView
            // 
            this.labelAddressView.AutoSize = true;
            this.labelAddressView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelAddressView.Location = new System.Drawing.Point(351, 258);
            this.labelAddressView.Name = "labelAddressView";
            this.labelAddressView.Size = new System.Drawing.Size(47, 18);
            this.labelAddressView.TabIndex = 8;
            this.labelAddressView.Text = "العنوان";
            // 
            // lblDonorTypeText
            // 
            this.lblDonorTypeText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDonorTypeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDonorTypeText.Location = new System.Drawing.Point(32, 210);
            this.lblDonorTypeText.Name = "lblDonorTypeText";
            this.lblDonorTypeText.Size = new System.Drawing.Size(366, 23);
            this.lblDonorTypeText.TabIndex = 7;
            this.lblDonorTypeText.Text = "----";
            // 
            // labelDonorTypeView
            // 
            this.labelDonorTypeView.AutoSize = true;
            this.labelDonorTypeView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelDonorTypeView.Location = new System.Drawing.Point(323, 188);
            this.labelDonorTypeView.Name = "labelDonorTypeView";
            this.labelDonorTypeView.Size = new System.Drawing.Size(75, 18);
            this.labelDonorTypeView.TabIndex = 6;
            this.labelDonorTypeView.Text = "نوع المتبرع";
            // 
            // lblEmailText
            // 
            this.lblEmailText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmailText.Location = new System.Drawing.Point(32, 140);
            this.lblEmailText.Name = "lblEmailText";
            this.lblEmailText.Size = new System.Drawing.Size(366, 23);
            this.lblEmailText.TabIndex = 5;
            this.lblEmailText.Text = "----";
            // 
            // labelEmailView
            // 
            this.labelEmailView.AutoSize = true;
            this.labelEmailView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelEmailView.Location = new System.Drawing.Point(296, 118);
            this.labelEmailView.Name = "labelEmailView";
            this.labelEmailView.Size = new System.Drawing.Size(102, 18);
            this.labelEmailView.TabIndex = 4;
            this.labelEmailView.Text = "البريد الإلكتروني";
            // 
            // lblPhoneText
            // 
            this.lblPhoneText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhoneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhoneText.Location = new System.Drawing.Point(32, 70);
            this.lblPhoneText.Name = "lblPhoneText";
            this.lblPhoneText.Size = new System.Drawing.Size(366, 23);
            this.lblPhoneText.TabIndex = 3;
            this.lblPhoneText.Text = "----";
            // 
            // labelPhoneView
            // 
            this.labelPhoneView.AutoSize = true;
            this.labelPhoneView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelPhoneView.Location = new System.Drawing.Point(326, 48);
            this.labelPhoneView.Name = "labelPhoneView";
            this.labelPhoneView.Size = new System.Drawing.Size(72, 18);
            this.labelPhoneView.TabIndex = 2;
            this.labelPhoneView.Text = "رقم الهاتف";
            // 
            // lblFullNameText
            // 
            this.lblFullNameText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblFullNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFullNameText.Location = new System.Drawing.Point(32, 0);
            this.lblFullNameText.Name = "lblFullNameText";
            this.lblFullNameText.Size = new System.Drawing.Size(366, 23);
            this.lblFullNameText.TabIndex = 1;
            this.lblFullNameText.Text = "----";
            // 
            // labelFullNameView
            // 
            this.labelFullNameView.AutoSize = true;
            this.labelFullNameView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelFullNameView.Location = new System.Drawing.Point(318, -22);
            this.labelFullNameView.Name = "labelFullNameView";
            this.labelFullNameView.Size = new System.Drawing.Size(80, 18);
            this.labelFullNameView.TabIndex = 0;
            this.labelFullNameView.Text = "اسم المتبرع";
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnDelete);
            this.pnlActions.Controls.Add(this.btnEdit);
            this.pnlActions.Controls.Add(this.btnAddNew);
            this.pnlActions.Controls.Add(this.btnCancel);
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 511);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(430, 130);
            this.pnlActions.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(32, 71);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 8;
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(158, 71);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 45);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "تعديل";
            // 
            // btnAddNew
            // 
            this.btnAddNew.BorderRadius = 8;
            this.btnAddNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(284, 71);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(114, 45);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "إضافة جديد";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.FillColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(32, 20);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "إلغاء";
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(218, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPanelTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPanelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPanelTitle.Name = "lblPanelTitle";
            this.lblPanelTitle.Padding = new System.Windows.Forms.Padding(0, 10, 10, 0);
            this.lblPanelTitle.Size = new System.Drawing.Size(430, 40);
            this.lblPanelTitle.TabIndex = 0;
            this.lblPanelTitle.Text = "تفاصيل المتبرع";
            this.lblPanelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this.pnlSmart;
            // 
            // frmDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1200, 721);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmDonors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إدارة المتبرعين - نظام سند";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonorsList)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSmart.ResumeLayout(false);
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Button btnBackToDashBoard;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlBody;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonorsList;
        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel pnlSmart;
        private System.Windows.Forms.Panel pnlInputs;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label labelNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label labelAddress;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDonorType;
        private System.Windows.Forms.Label labelDonorType;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label labelEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private System.Windows.Forms.Label labelPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Label lblNotesText;
        private System.Windows.Forms.Label labelNotesView;
        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label labelAddressView;
        private System.Windows.Forms.Label lblDonorTypeText;
        private System.Windows.Forms.Label labelDonorTypeView;
        private System.Windows.Forms.Label lblEmailText;
        private System.Windows.Forms.Label labelEmailView;
        private System.Windows.Forms.Label lblPhoneText;
        private System.Windows.Forms.Label labelPhoneView;
        private System.Windows.Forms.Label lblFullNameText;
        private System.Windows.Forms.Label labelFullNameView;
        private System.Windows.Forms.Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblPanelTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
