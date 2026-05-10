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
            this.pnlBody = new System.Windows.Forms.Panel();
            this.pnlList = new System.Windows.Forms.Panel();
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
            this.pnlBody.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonorsList)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlSmart.SuspendLayout();
            this.pnlInputs.SuspendLayout();
            this.pnlView.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlList);
            this.pnlBody.Controls.Add(this.pnlSmart);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1600, 800);
            this.pnlBody.TabIndex = 1;
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.dgvDonorsList);
            this.pnlList.Controls.Add(this.pnlSearch);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Padding = new System.Windows.Forms.Padding(20);
            this.pnlList.Size = new System.Drawing.Size(1050, 800);
            this.pnlList.TabIndex = 3;
            // 
            // dgvDonorsList
            // 
            this.dgvDonorsList.AllowUserToAddRows = false;
            this.dgvDonorsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDonorsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonorsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonorsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonorsList.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonorsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonorsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonorsList.Location = new System.Drawing.Point(20, 100);
            this.dgvDonorsList.MultiSelect = false;
            this.dgvDonorsList.Name = "dgvDonorsList";
            this.dgvDonorsList.ReadOnly = true;
            this.dgvDonorsList.RowHeadersVisible = false;
            this.dgvDonorsList.RowHeadersWidth = 51;
            this.dgvDonorsList.RowTemplate.Height = 40;
            this.dgvDonorsList.Size = new System.Drawing.Size(1010, 680);
            this.dgvDonorsList.TabIndex = 2;
            this.dgvDonorsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonorsList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dgvDonorsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonorsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.dgvDonorsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.dgvDonorsList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvDonorsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonorsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.dgvDonorsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDonorsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dgvDonorsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDonorsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDonorsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvDonorsList.ThemeStyle.ReadOnly = true;
            this.dgvDonorsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonorsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonorsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dgvDonorsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonorsList.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDonorsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.dgvDonorsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Controls.Add(this.cmbSearch);
            this.pnlSearch.Controls.Add(this.btnClear);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(20, 20);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlSearch.Size = new System.Drawing.Size(1010, 80);
            this.pnlSearch.TabIndex = 1;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.BackColor = System.Drawing.Color.Transparent;
            this.cmbSearch.BorderRadius = 8;
            this.cmbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSearch.ItemHeight = 39;
            this.cmbSearch.Location = new System.Drawing.Point(800, 10);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(200, 45);
            this.cmbSearch.TabIndex = 7;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BorderRadius = 8;
            this.btnClear.FillColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.Location = new System.Drawing.Point(30, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 45);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "مسح";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(140, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 45);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "بحث";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSearch.Location = new System.Drawing.Point(250, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "ابحث هنا...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(540, 45);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlSmart
            // 
            this.pnlSmart.BackColor = System.Drawing.Color.White;
            this.pnlSmart.Controls.Add(this.pnlInputs);
            this.pnlSmart.Controls.Add(this.pnlView);
            this.pnlSmart.Controls.Add(this.pnlActions);
            this.pnlSmart.Controls.Add(this.lblPanelTitle);
            this.pnlSmart.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSmart.Location = new System.Drawing.Point(1050, 0);
            this.pnlSmart.Name = "pnlSmart";
            this.pnlSmart.Padding = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.pnlSmart.Size = new System.Drawing.Size(550, 800);
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
            this.pnlInputs.Location = new System.Drawing.Point(20, 65);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(510, 660);
            this.pnlInputs.TabIndex = 3;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.BorderRadius = 8;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNotes.Location = new System.Drawing.Point(120, 435);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "ملاحظات إضافية...";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(380, 70);
            this.txtNotes.TabIndex = 11;
            // 
            // labelNotes
            // 
            this.labelNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelNotes.Location = new System.Drawing.Point(428, 405);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(67, 24);
            this.labelNotes.TabIndex = 10;
            this.labelNotes.Text = "ملاحظات";
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.BorderRadius = 8;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAddress.Location = new System.Drawing.Point(120, 355);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "العنوان...";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(380, 40);
            this.txtAddress.TabIndex = 9;
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelAddress.Location = new System.Drawing.Point(445, 325);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 24);
            this.labelAddress.TabIndex = 8;
            this.labelAddress.Text = "العنوان";
            // 
            // cmbDonorType
            // 
            this.cmbDonorType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDonorType.BackColor = System.Drawing.Color.Transparent;
            this.cmbDonorType.BorderRadius = 8;
            this.cmbDonorType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDonorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonorType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbDonorType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbDonorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbDonorType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDonorType.ItemHeight = 35;
            this.cmbDonorType.Location = new System.Drawing.Point(120, 275);
            this.cmbDonorType.Name = "cmbDonorType";
            this.cmbDonorType.Size = new System.Drawing.Size(380, 41);
            this.cmbDonorType.TabIndex = 7;
            this.cmbDonorType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDonorType
            // 
            this.labelDonorType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDonorType.AutoSize = true;
            this.labelDonorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDonorType.Location = new System.Drawing.Point(415, 245);
            this.labelDonorType.Name = "labelDonorType";
            this.labelDonorType.Size = new System.Drawing.Size(82, 24);
            this.labelDonorType.TabIndex = 6;
            this.labelDonorType.Text = "نوع المتبرع";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BorderRadius = 8;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEmail.Location = new System.Drawing.Point(120, 195);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "البريد الإلكتروني...";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(380, 40);
            this.txtEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelEmail.Location = new System.Drawing.Point(385, 165);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(111, 24);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "البريد الإلكتروني";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.BorderRadius = 8;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtPhone.Location = new System.Drawing.Point(120, 115);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PlaceholderText = "رقم الهاتف...";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(380, 40);
            this.txtPhone.TabIndex = 3;
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelPhone.Location = new System.Drawing.Point(419, 85);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(74, 24);
            this.labelPhone.TabIndex = 2;
            this.labelPhone.Text = "رقم الهاتف";
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.BorderRadius = 8;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.DefaultText = "";
            this.txtFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtFullName.Location = new System.Drawing.Point(120, 35);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PlaceholderText = "اسم المتبرع أو الجهة...";
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(380, 40);
            this.txtFullName.TabIndex = 1;
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelFullName.Location = new System.Drawing.Point(410, 5);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(79, 24);
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
            this.pnlView.Location = new System.Drawing.Point(20, 65);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(510, 660);
            this.pnlView.TabIndex = 4;
            // 
            // lblNotesText
            // 
            this.lblNotesText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNotesText.Location = new System.Drawing.Point(10, 385);
            this.lblNotesText.Name = "lblNotesText";
            this.lblNotesText.Size = new System.Drawing.Size(490, 60);
            this.lblNotesText.TabIndex = 11;
            this.lblNotesText.Text = "----";
            // 
            // labelNotesView
            // 
            this.labelNotesView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNotesView.AutoSize = true;
            this.labelNotesView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelNotesView.Location = new System.Drawing.Point(428, 355);
            this.labelNotesView.Name = "labelNotesView";
            this.labelNotesView.Size = new System.Drawing.Size(67, 24);
            this.labelNotesView.TabIndex = 10;
            this.labelNotesView.Text = "ملاحظات";
            // 
            // lblAddressText
            // 
            this.lblAddressText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAddressText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAddressText.Location = new System.Drawing.Point(10, 315);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(490, 30);
            this.lblAddressText.TabIndex = 9;
            this.lblAddressText.Text = "----";
            // 
            // labelAddressView
            // 
            this.labelAddressView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddressView.AutoSize = true;
            this.labelAddressView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelAddressView.Location = new System.Drawing.Point(445, 285);
            this.labelAddressView.Name = "labelAddressView";
            this.labelAddressView.Size = new System.Drawing.Size(52, 24);
            this.labelAddressView.TabIndex = 8;
            this.labelAddressView.Text = "العنوان";
            // 
            // lblDonorTypeText
            // 
            this.lblDonorTypeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDonorTypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDonorTypeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDonorTypeText.Location = new System.Drawing.Point(10, 245);
            this.lblDonorTypeText.Name = "lblDonorTypeText";
            this.lblDonorTypeText.Size = new System.Drawing.Size(490, 30);
            this.lblDonorTypeText.TabIndex = 7;
            this.lblDonorTypeText.Text = "----";
            // 
            // labelDonorTypeView
            // 
            this.labelDonorTypeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDonorTypeView.AutoSize = true;
            this.labelDonorTypeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDonorTypeView.Location = new System.Drawing.Point(415, 215);
            this.labelDonorTypeView.Name = "labelDonorTypeView";
            this.labelDonorTypeView.Size = new System.Drawing.Size(82, 24);
            this.labelDonorTypeView.TabIndex = 6;
            this.labelDonorTypeView.Text = "نوع المتبرع";
            // 
            // lblEmailText
            // 
            this.lblEmailText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmailText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmailText.Location = new System.Drawing.Point(10, 175);
            this.lblEmailText.Name = "lblEmailText";
            this.lblEmailText.Size = new System.Drawing.Size(490, 30);
            this.lblEmailText.TabIndex = 5;
            this.lblEmailText.Text = "----";
            // 
            // labelEmailView
            // 
            this.labelEmailView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmailView.AutoSize = true;
            this.labelEmailView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelEmailView.Location = new System.Drawing.Point(385, 145);
            this.labelEmailView.Name = "labelEmailView";
            this.labelEmailView.Size = new System.Drawing.Size(111, 24);
            this.labelEmailView.TabIndex = 4;
            this.labelEmailView.Text = "البريد الإلكتروني";
            // 
            // lblPhoneText
            // 
            this.lblPhoneText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhoneText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhoneText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhoneText.Location = new System.Drawing.Point(10, 105);
            this.lblPhoneText.Name = "lblPhoneText";
            this.lblPhoneText.Size = new System.Drawing.Size(490, 30);
            this.lblPhoneText.TabIndex = 3;
            this.lblPhoneText.Text = "----";
            // 
            // labelPhoneView
            // 
            this.labelPhoneView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhoneView.AutoSize = true;
            this.labelPhoneView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelPhoneView.Location = new System.Drawing.Point(419, 75);
            this.labelPhoneView.Name = "labelPhoneView";
            this.labelPhoneView.Size = new System.Drawing.Size(74, 24);
            this.labelPhoneView.TabIndex = 2;
            this.labelPhoneView.Text = "رقم الهاتف";
            // 
            // lblFullNameText
            // 
            this.lblFullNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFullNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblFullNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFullNameText.Location = new System.Drawing.Point(10, 35);
            this.lblFullNameText.Name = "lblFullNameText";
            this.lblFullNameText.Size = new System.Drawing.Size(490, 30);
            this.lblFullNameText.TabIndex = 1;
            this.lblFullNameText.Text = "----";
            // 
            // labelFullNameView
            // 
            this.labelFullNameView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFullNameView.AutoSize = true;
            this.labelFullNameView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelFullNameView.Location = new System.Drawing.Point(410, 5);
            this.labelFullNameView.Name = "labelFullNameView";
            this.labelFullNameView.Size = new System.Drawing.Size(79, 24);
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
            this.pnlActions.Location = new System.Drawing.Point(20, 725);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(510, 75);
            this.pnlActions.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(10, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 45);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "حذف";
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BorderRadius = 8;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(175, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(160, 45);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "تعديل";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNew.BorderRadius = 8;
            this.btnAddNew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Location = new System.Drawing.Point(345, 15);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(155, 45);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Text = "إضافة جديد";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.FillColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(10, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(240, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "إلغاء";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BorderRadius = 8;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(260, 15);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 45);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "حفظ";
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPanelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblPanelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPanelTitle.Location = new System.Drawing.Point(20, 20);
            this.lblPanelTitle.Name = "lblPanelTitle";
            this.lblPanelTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblPanelTitle.Size = new System.Drawing.Size(510, 45);
            this.lblPanelTitle.TabIndex = 0;
            this.lblPanelTitle.Text = "تفاصيل المتبرع";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.pnlSmart;
            // 
            // frmDonors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDonors";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إدارة المتبرعين";
            this.pnlBody.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
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

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlList;
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

