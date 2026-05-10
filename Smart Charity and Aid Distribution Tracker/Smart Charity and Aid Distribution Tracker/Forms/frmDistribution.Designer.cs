namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    partial class frmDistribution
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
            this.dgvDistributionsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBeneficiaryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDistDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSmart = new System.Windows.Forms.Panel();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBeneficiary = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlType = new System.Windows.Forms.Panel();
            this.rbCash = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbInKind = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlView = new System.Windows.Forms.Panel();
            this.lblBeneficiaryText = new System.Windows.Forms.Label();
            this.lblViewBeneficiary = new System.Windows.Forms.Label();
            this.lblTypeText = new System.Windows.Forms.Label();
            this.lblViewType = new System.Windows.Forms.Label();
            this.lblItemText = new System.Windows.Forms.Label();
            this.lblViewItem = new System.Windows.Forms.Label();
            this.lblQuantityText = new System.Windows.Forms.Label();
            this.lblViewQuantity = new System.Windows.Forms.Label();
            this.lblAmountText = new System.Windows.Forms.Label();
            this.lblViewAmount = new System.Windows.Forms.Label();
            this.lblNotesText = new System.Windows.Forms.Label();
            this.lblViewNotes = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributionsList)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlSmart.SuspendLayout();
            this.pnlInputs.SuspendLayout();
            this.pnlType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
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
            this.pnlList.Controls.Add(this.dgvDistributionsList);
            this.pnlList.Controls.Add(this.pnlSearch);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Padding = new System.Windows.Forms.Padding(20);
            this.pnlList.Size = new System.Drawing.Size(1050, 800);
            this.pnlList.TabIndex = 3;
            // 
            // dgvDistributionsList
            // 
            this.dgvDistributionsList.AllowUserToAddRows = false;
            this.dgvDistributionsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDistributionsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDistributionsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDistributionsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDistributionsList.ColumnHeadersHeight = 45;
            this.dgvDistributionsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colBeneficiaryName,
            this.colDistType,
            this.colDistDate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDistributionsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDistributionsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDistributionsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDistributionsList.Location = new System.Drawing.Point(20, 100);
            this.dgvDistributionsList.MultiSelect = false;
            this.dgvDistributionsList.Name = "dgvDistributionsList";
            this.dgvDistributionsList.ReadOnly = true;
            this.dgvDistributionsList.RowHeadersVisible = false;
            this.dgvDistributionsList.RowHeadersWidth = 51;
            this.dgvDistributionsList.RowTemplate.Height = 40;
            this.dgvDistributionsList.Size = new System.Drawing.Size(1010, 680);
            this.dgvDistributionsList.TabIndex = 2;
            this.dgvDistributionsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDistributionsList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dgvDistributionsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDistributionsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.dgvDistributionsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.dgvDistributionsList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvDistributionsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDistributionsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.dgvDistributionsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDistributionsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dgvDistributionsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDistributionsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDistributionsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvDistributionsList.ThemeStyle.ReadOnly = true;
            this.dgvDistributionsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDistributionsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDistributionsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dgvDistributionsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDistributionsList.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDistributionsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.dgvDistributionsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            // 
            // colID
            // 
            this.colID.HeaderText = "رقم العملية";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colBeneficiaryName
            // 
            this.colBeneficiaryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBeneficiaryName.HeaderText = "المستفيد";
            this.colBeneficiaryName.MinimumWidth = 6;
            this.colBeneficiaryName.Name = "colBeneficiaryName";
            this.colBeneficiaryName.ReadOnly = true;
            // 
            // colDistType
            // 
            this.colDistType.HeaderText = "نوع الصرف";
            this.colDistType.MinimumWidth = 6;
            this.colDistType.Name = "colDistType";
            this.colDistType.ReadOnly = true;
            // 
            // colDistDate
            // 
            this.colDistDate.HeaderText = "التاريخ";
            this.colDistDate.MinimumWidth = 6;
            this.colDistDate.Name = "colDistDate";
            this.colDistDate.ReadOnly = true;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
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
            this.txtSearch.PlaceholderText = "ابحث عن عملية صرف...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(750, 45);
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
            this.pnlInputs.Controls.Add(this.label2);
            this.pnlInputs.Controls.Add(this.cmbBeneficiary);
            this.pnlInputs.Controls.Add(this.label6);
            this.pnlInputs.Controls.Add(this.pnlType);
            this.pnlInputs.Controls.Add(this.label3);
            this.pnlInputs.Controls.Add(this.cmbItem);
            this.pnlInputs.Controls.Add(this.label4);
            this.pnlInputs.Controls.Add(this.numQuantity);
            this.pnlInputs.Controls.Add(this.lblAmount);
            this.pnlInputs.Controls.Add(this.txtAmount);
            this.pnlInputs.Controls.Add(this.label5);
            this.pnlInputs.Controls.Add(this.txtNotes);
            this.pnlInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputs.Location = new System.Drawing.Point(20, 65);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(510, 550);
            this.pnlInputs.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(435, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "المستفيد";
            // 
            // cmbBeneficiary
            // 
            this.cmbBeneficiary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBeneficiary.BackColor = System.Drawing.Color.Transparent;
            this.cmbBeneficiary.BorderRadius = 8;
            this.cmbBeneficiary.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBeneficiary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeneficiary.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbBeneficiary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbBeneficiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbBeneficiary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBeneficiary.ItemHeight = 35;
            this.cmbBeneficiary.Location = new System.Drawing.Point(120, 35);
            this.cmbBeneficiary.Name = "cmbBeneficiary";
            this.cmbBeneficiary.Size = new System.Drawing.Size(380, 41);
            this.cmbBeneficiary.TabIndex = 0;
            this.cmbBeneficiary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.Location = new System.Drawing.Point(405, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "نوع الصرف";
            // 
            // pnlType
            // 
            this.pnlType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlType.Controls.Add(this.rbCash);
            this.pnlType.Controls.Add(this.rbInKind);
            this.pnlType.Location = new System.Drawing.Point(120, 115);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(380, 45);
            this.pnlType.TabIndex = 13;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbCash.CheckedState.BorderThickness = 0;
            this.rbCash.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbCash.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbCash.CheckedState.InnerOffset = -4;
            this.rbCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbCash.Location = new System.Drawing.Point(26, 10);
            this.rbCash.Name = "rbCash";
            this.rbCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbCash.Size = new System.Drawing.Size(104, 28);
            this.rbCash.TabIndex = 1;
            this.rbCash.Text = "صرف نقدي";
            this.rbCash.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbCash.UncheckedState.BorderThickness = 2;
            this.rbCash.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbCash.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rbInKind
            // 
            this.rbInKind.AutoSize = true;
            this.rbInKind.Checked = true;
            this.rbInKind.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbInKind.CheckedState.BorderThickness = 0;
            this.rbInKind.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.rbInKind.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbInKind.CheckedState.InnerOffset = -4;
            this.rbInKind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rbInKind.Location = new System.Drawing.Point(225, 10);
            this.rbInKind.Name = "rbInKind";
            this.rbInKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbInKind.Size = new System.Drawing.Size(107, 28);
            this.rbInKind.TabIndex = 0;
            this.rbInKind.TabStop = true;
            this.rbInKind.Text = "صرف عيني";
            this.rbInKind.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbInKind.UncheckedState.BorderThickness = 2;
            this.rbInKind.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbInKind.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(437, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "الصنف";
            // 
            // cmbItem
            // 
            this.cmbItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbItem.BackColor = System.Drawing.Color.Transparent;
            this.cmbItem.BorderRadius = 8;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbItem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbItem.ItemHeight = 35;
            this.cmbItem.Location = new System.Drawing.Point(120, 195);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(380, 41);
            this.cmbItem.TabIndex = 2;
            this.cmbItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(447, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "الكمية";
            // 
            // numQuantity
            // 
            this.numQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numQuantity.BackColor = System.Drawing.Color.Transparent;
            this.numQuantity.BorderRadius = 8;
            this.numQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numQuantity.DecimalPlaces = 2;
            this.numQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numQuantity.Location = new System.Drawing.Point(120, 275);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numQuantity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numQuantity.Size = new System.Drawing.Size(380, 41);
            this.numQuantity.TabIndex = 18;
            this.numQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.numQuantity.UpDownButtonForeColor = System.Drawing.Color.White;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAmount.Location = new System.Drawing.Point(448, 325);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 24);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "المبلغ";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.BorderRadius = 8;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtAmount.Location = new System.Drawing.Point(120, 355);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "أدخل المبلغ النقدي";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(380, 41);
            this.txtAmount.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(424, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "ملاحظات";
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
            this.txtNotes.PlaceholderText = "أي ملاحظات إضافية حول عملية الصرف...";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(380, 80);
            this.txtNotes.TabIndex = 7;
            // 
            // pnlView
            // 
            this.pnlView.AutoScroll = true;
            this.pnlView.Controls.Add(this.lblBeneficiaryText);
            this.pnlView.Controls.Add(this.lblViewBeneficiary);
            this.pnlView.Controls.Add(this.lblTypeText);
            this.pnlView.Controls.Add(this.lblViewType);
            this.pnlView.Controls.Add(this.lblItemText);
            this.pnlView.Controls.Add(this.lblViewItem);
            this.pnlView.Controls.Add(this.lblQuantityText);
            this.pnlView.Controls.Add(this.lblViewQuantity);
            this.pnlView.Controls.Add(this.lblAmountText);
            this.pnlView.Controls.Add(this.lblViewAmount);
            this.pnlView.Controls.Add(this.lblNotesText);
            this.pnlView.Controls.Add(this.lblViewNotes);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(20, 65);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(510, 550);
            this.pnlView.TabIndex = 4;
            // 
            // lblBeneficiaryText
            // 
            this.lblBeneficiaryText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBeneficiaryText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblBeneficiaryText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBeneficiaryText.Location = new System.Drawing.Point(120, 35);
            this.lblBeneficiaryText.Name = "lblBeneficiaryText";
            this.lblBeneficiaryText.Size = new System.Drawing.Size(380, 30);
            this.lblBeneficiaryText.TabIndex = 1;
            this.lblBeneficiaryText.Text = "----";
            // 
            // lblViewBeneficiary
            // 
            this.lblViewBeneficiary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewBeneficiary.AutoSize = true;
            this.lblViewBeneficiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblViewBeneficiary.Location = new System.Drawing.Point(435, 5);
            this.lblViewBeneficiary.Name = "lblViewBeneficiary";
            this.lblViewBeneficiary.Size = new System.Drawing.Size(56, 24);
            this.lblViewBeneficiary.TabIndex = 0;
            this.lblViewBeneficiary.Text = "المستفيد";
            // 
            // lblTypeText
            // 
            this.lblTypeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTypeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTypeText.Location = new System.Drawing.Point(120, 115);
            this.lblTypeText.Name = "lblTypeText";
            this.lblTypeText.Size = new System.Drawing.Size(380, 30);
            this.lblTypeText.TabIndex = 3;
            this.lblTypeText.Text = "----";
            // 
            // lblViewType
            // 
            this.lblViewType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewType.AutoSize = true;
            this.lblViewType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblViewType.Location = new System.Drawing.Point(405, 85);
            this.lblViewType.Name = "lblViewType";
            this.lblViewType.Size = new System.Drawing.Size(86, 24);
            this.lblViewType.TabIndex = 2;
            this.lblViewType.Text = "نوع الصرف";
            // 
            // lblItemText
            // 
            this.lblItemText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemText.Location = new System.Drawing.Point(120, 195);
            this.lblItemText.Name = "lblItemText";
            this.lblItemText.Size = new System.Drawing.Size(380, 30);
            this.lblItemText.TabIndex = 5;
            this.lblItemText.Text = "----";
            // 
            // lblViewItem
            // 
            this.lblViewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewItem.AutoSize = true;
            this.lblViewItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblViewItem.Location = new System.Drawing.Point(437, 165);
            this.lblViewItem.Name = "lblViewItem";
            this.lblViewItem.Size = new System.Drawing.Size(54, 24);
            this.lblViewItem.TabIndex = 4;
            this.lblViewItem.Text = "الصنف";
            // 
            // lblQuantityText
            // 
            this.lblQuantityText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantityText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuantityText.Location = new System.Drawing.Point(120, 275);
            this.lblQuantityText.Name = "lblQuantityText";
            this.lblQuantityText.Size = new System.Drawing.Size(380, 30);
            this.lblQuantityText.TabIndex = 7;
            this.lblQuantityText.Text = "----";
            // 
            // lblViewQuantity
            // 
            this.lblViewQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewQuantity.AutoSize = true;
            this.lblViewQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblViewQuantity.Location = new System.Drawing.Point(447, 245);
            this.lblViewQuantity.Name = "lblViewQuantity";
            this.lblViewQuantity.Size = new System.Drawing.Size(44, 24);
            this.lblViewQuantity.TabIndex = 6;
            this.lblViewQuantity.Text = "الكمية";
            // 
            // lblAmountText
            // 
            this.lblAmountText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAmountText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAmountText.Location = new System.Drawing.Point(120, 355);
            this.lblAmountText.Name = "lblAmountText";
            this.lblAmountText.Size = new System.Drawing.Size(380, 30);
            this.lblAmountText.TabIndex = 9;
            this.lblAmountText.Text = "----";
            // 
            // lblViewAmount
            // 
            this.lblViewAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewAmount.AutoSize = true;
            this.lblViewAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblViewAmount.Location = new System.Drawing.Point(448, 325);
            this.lblViewAmount.Name = "lblViewAmount";
            this.lblViewAmount.Size = new System.Drawing.Size(43, 24);
            this.lblViewAmount.TabIndex = 8;
            this.lblViewAmount.Text = "المبلغ";
            // 
            // lblNotesText
            // 
            this.lblNotesText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNotesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNotesText.Location = new System.Drawing.Point(120, 435);
            this.lblNotesText.Name = "lblNotesText";
            this.lblNotesText.Size = new System.Drawing.Size(380, 80);
            this.lblNotesText.TabIndex = 11;
            this.lblNotesText.Text = "----";
            // 
            // lblViewNotes
            // 
            this.lblViewNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewNotes.AutoSize = true;
            this.lblViewNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblViewNotes.Location = new System.Drawing.Point(424, 405);
            this.lblViewNotes.Name = "lblViewNotes";
            this.lblViewNotes.Size = new System.Drawing.Size(67, 24);
            this.lblViewNotes.TabIndex = 10;
            this.lblViewNotes.Text = "ملاحظات";
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnDelete);
            this.pnlActions.Controls.Add(this.btnEdit);
            this.pnlActions.Controls.Add(this.btnAddNew);
            this.pnlActions.Controls.Add(this.btnCancel);
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(20, 615);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(510, 185);
            this.pnlActions.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BorderRadius = 8;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(10, 70);
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
            this.btnEdit.Location = new System.Drawing.Point(175, 70);
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
            this.btnAddNew.Location = new System.Drawing.Point(345, 70);
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
            this.lblPanelTitle.Text = "تفاصيل المساعدة";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.pnlSmart;
            // 
            // frmDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDistribution";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "صرف المساعدات";
            this.pnlBody.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributionsList)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSmart.ResumeLayout(false);
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.pnlView.ResumeLayout(false);
            this.pnlView.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlList;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDistributionsList;
        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel pnlSmart;
        private System.Windows.Forms.Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnAddNew;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label lblPanelTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBeneficiary;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlType;
        private Guna.UI2.WinForms.Guna2RadioButton rbCash;
        private Guna.UI2.WinForms.Guna2RadioButton rbInKind;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbItem;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Label lblBeneficiaryText;
        private System.Windows.Forms.Label lblViewBeneficiary;
        private System.Windows.Forms.Label lblTypeText;
        private System.Windows.Forms.Label lblViewType;
        private System.Windows.Forms.Label lblItemText;
        private System.Windows.Forms.Label lblViewItem;
        private System.Windows.Forms.Label lblQuantityText;
        private System.Windows.Forms.Label lblViewQuantity;
        private System.Windows.Forms.Label lblAmountText;
        private System.Windows.Forms.Label lblViewAmount;
        private System.Windows.Forms.Label lblNotesText;
        private System.Windows.Forms.Label lblViewNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBeneficiaryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDistDate;
    }
}