namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    partial class frmDonations
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
            this.dgvDonationsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cmbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSmart = new System.Windows.Forms.Panel();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.cmbItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.cmbDonationType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelDonationType = new System.Windows.Forms.Label();
            this.cmbDonor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelDonor = new System.Windows.Forms.Label();
            this.pnlView = new System.Windows.Forms.Panel();
            this.lblNotesText = new System.Windows.Forms.Label();
            this.labelNotesView = new System.Windows.Forms.Label();
            this.lblAmountText = new System.Windows.Forms.Label();
            this.labelAmountView = new System.Windows.Forms.Label();
            this.lblQuantityText = new System.Windows.Forms.Label();
            this.labelQuantityView = new System.Windows.Forms.Label();
            this.lblItemText = new System.Windows.Forms.Label();
            this.labelItemView = new System.Windows.Forms.Label();
            this.lblDonationTypeText = new System.Windows.Forms.Label();
            this.labelDonationTypeView = new System.Windows.Forms.Label();
            this.lblDonorText = new System.Windows.Forms.Label();
            this.labelDonorView = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationsList)).BeginInit();
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
            this.pnlList.Controls.Add(this.dgvDonationsList);
            this.pnlList.Controls.Add(this.pnlSearch);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Padding = new System.Windows.Forms.Padding(20);
            this.pnlList.Size = new System.Drawing.Size(1050, 800);
            this.pnlList.TabIndex = 3;
            // 
            // dgvDonationsList
            // 
            this.dgvDonationsList.AllowUserToAddRows = false;
            this.dgvDonationsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDonationsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonationsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonationsList.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonationsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonationsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonationsList.Location = new System.Drawing.Point(20, 100);
            this.dgvDonationsList.MultiSelect = false;
            this.dgvDonationsList.Name = "dgvDonationsList";
            this.dgvDonationsList.ReadOnly = true;
            this.dgvDonationsList.RowHeadersVisible = false;
            this.dgvDonationsList.RowHeadersWidth = 51;
            this.dgvDonationsList.RowTemplate.Height = 40;
            this.dgvDonationsList.Size = new System.Drawing.Size(1010, 680);
            this.dgvDonationsList.TabIndex = 2;
            this.dgvDonationsList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonationsList.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dgvDonationsList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonationsList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.dgvDonationsList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.dgvDonationsList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.dgvDonationsList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonationsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.dgvDonationsList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDonationsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dgvDonationsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDonationsList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDonationsList.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvDonationsList.ThemeStyle.ReadOnly = true;
            this.dgvDonationsList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonationsList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonationsList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dgvDonationsList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDonationsList.ThemeStyle.RowsStyle.Height = 40;
            this.dgvDonationsList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.dgvDonationsList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
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
            this.pnlInputs.Controls.Add(this.txtAmount);
            this.pnlInputs.Controls.Add(this.labelAmount);
            this.pnlInputs.Controls.Add(this.txtQuantity);
            this.pnlInputs.Controls.Add(this.labelQuantity);
            this.pnlInputs.Controls.Add(this.cmbItem);
            this.pnlInputs.Controls.Add(this.labelItem);
            this.pnlInputs.Controls.Add(this.cmbDonationType);
            this.pnlInputs.Controls.Add(this.labelDonationType);
            this.pnlInputs.Controls.Add(this.cmbDonor);
            this.pnlInputs.Controls.Add(this.labelDonor);
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
            this.txtAmount.PlaceholderText = "المبلغ النقدي...";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(380, 40);
            this.txtAmount.TabIndex = 9;
            // 
            // labelAmount
            // 
            this.labelAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelAmount.Location = new System.Drawing.Point(445, 325);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 24);
            this.labelAmount.TabIndex = 8;
            this.labelAmount.Text = "المبلغ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.BorderRadius = 8;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtQuantity.Location = new System.Drawing.Point(120, 275);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "الكمية العينية...";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(380, 40);
            this.txtQuantity.TabIndex = 7;
            // 
            // labelQuantity
            // 
            this.labelQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelQuantity.Location = new System.Drawing.Point(445, 245);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(44, 24);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "الكمية";
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
            this.cmbItem.TabIndex = 5;
            this.cmbItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelItem
            // 
            this.labelItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelItem.Location = new System.Drawing.Point(440, 165);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(54, 24);
            this.labelItem.TabIndex = 4;
            this.labelItem.Text = "الصنف";
            // 
            // cmbDonationType
            // 
            this.cmbDonationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDonationType.BackColor = System.Drawing.Color.Transparent;
            this.cmbDonationType.BorderRadius = 8;
            this.cmbDonationType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDonationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonationType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbDonationType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbDonationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbDonationType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDonationType.ItemHeight = 35;
            this.cmbDonationType.Location = new System.Drawing.Point(120, 115);
            this.cmbDonationType.Name = "cmbDonationType";
            this.cmbDonationType.Size = new System.Drawing.Size(380, 41);
            this.cmbDonationType.TabIndex = 3;
            this.cmbDonationType.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDonationType
            // 
            this.labelDonationType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDonationType.AutoSize = true;
            this.labelDonationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDonationType.Location = new System.Drawing.Point(420, 85);
            this.labelDonationType.Name = "labelDonationType";
            this.labelDonationType.Size = new System.Drawing.Size(75, 24);
            this.labelDonationType.TabIndex = 2;
            this.labelDonationType.Text = "نوع التبرع";
            // 
            // cmbDonor
            // 
            this.cmbDonor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDonor.BackColor = System.Drawing.Color.Transparent;
            this.cmbDonor.BorderRadius = 8;
            this.cmbDonor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDonor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbDonor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.cmbDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDonor.ItemHeight = 35;
            this.cmbDonor.Location = new System.Drawing.Point(120, 35);
            this.cmbDonor.Name = "cmbDonor";
            this.cmbDonor.Size = new System.Drawing.Size(380, 41);
            this.cmbDonor.TabIndex = 1;
            this.cmbDonor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDonor
            // 
            this.labelDonor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDonor.AutoSize = true;
            this.labelDonor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDonor.Location = new System.Drawing.Point(440, 5);
            this.labelDonor.Name = "labelDonor";
            this.labelDonor.Size = new System.Drawing.Size(54, 24);
            this.labelDonor.TabIndex = 0;
            this.labelDonor.Text = "المتبرع";
            // 
            // pnlView
            // 
            this.pnlView.AutoScroll = true;
            this.pnlView.Controls.Add(this.lblNotesText);
            this.pnlView.Controls.Add(this.labelNotesView);
            this.pnlView.Controls.Add(this.lblAmountText);
            this.pnlView.Controls.Add(this.labelAmountView);
            this.pnlView.Controls.Add(this.lblQuantityText);
            this.pnlView.Controls.Add(this.labelQuantityView);
            this.pnlView.Controls.Add(this.lblItemText);
            this.pnlView.Controls.Add(this.labelItemView);
            this.pnlView.Controls.Add(this.lblDonationTypeText);
            this.pnlView.Controls.Add(this.labelDonationTypeView);
            this.pnlView.Controls.Add(this.lblDonorText);
            this.pnlView.Controls.Add(this.labelDonorView);
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
            // lblAmountText
            // 
            this.lblAmountText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblAmountText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAmountText.Location = new System.Drawing.Point(10, 315);
            this.lblAmountText.Name = "lblAmountText";
            this.lblAmountText.Size = new System.Drawing.Size(490, 30);
            this.lblAmountText.TabIndex = 9;
            this.lblAmountText.Text = "----";
            // 
            // labelAmountView
            // 
            this.labelAmountView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAmountView.AutoSize = true;
            this.labelAmountView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelAmountView.Location = new System.Drawing.Point(445, 285);
            this.labelAmountView.Name = "labelAmountView";
            this.labelAmountView.Size = new System.Drawing.Size(43, 24);
            this.labelAmountView.TabIndex = 8;
            this.labelAmountView.Text = "المبلغ";
            // 
            // lblQuantityText
            // 
            this.lblQuantityText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantityText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantityText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuantityText.Location = new System.Drawing.Point(10, 245);
            this.lblQuantityText.Name = "lblQuantityText";
            this.lblQuantityText.Size = new System.Drawing.Size(490, 30);
            this.lblQuantityText.TabIndex = 7;
            this.lblQuantityText.Text = "----";
            // 
            // labelQuantityView
            // 
            this.labelQuantityView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuantityView.AutoSize = true;
            this.labelQuantityView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelQuantityView.Location = new System.Drawing.Point(445, 215);
            this.labelQuantityView.Name = "labelQuantityView";
            this.labelQuantityView.Size = new System.Drawing.Size(44, 24);
            this.labelQuantityView.TabIndex = 6;
            this.labelQuantityView.Text = "الكمية";
            // 
            // lblItemText
            // 
            this.lblItemText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemText.Location = new System.Drawing.Point(10, 175);
            this.lblItemText.Name = "lblItemText";
            this.lblItemText.Size = new System.Drawing.Size(490, 30);
            this.lblItemText.TabIndex = 5;
            this.lblItemText.Text = "----";
            // 
            // labelItemView
            // 
            this.labelItemView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelItemView.AutoSize = true;
            this.labelItemView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelItemView.Location = new System.Drawing.Point(440, 145);
            this.labelItemView.Name = "labelItemView";
            this.labelItemView.Size = new System.Drawing.Size(54, 24);
            this.labelItemView.TabIndex = 4;
            this.labelItemView.Text = "الصنف";
            // 
            // lblDonationTypeText
            // 
            this.lblDonationTypeText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDonationTypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDonationTypeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDonationTypeText.Location = new System.Drawing.Point(10, 105);
            this.lblDonationTypeText.Name = "lblDonationTypeText";
            this.lblDonationTypeText.Size = new System.Drawing.Size(490, 30);
            this.lblDonationTypeText.TabIndex = 3;
            this.lblDonationTypeText.Text = "----";
            // 
            // labelDonationTypeView
            // 
            this.labelDonationTypeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDonationTypeView.AutoSize = true;
            this.labelDonationTypeView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDonationTypeView.Location = new System.Drawing.Point(420, 75);
            this.labelDonationTypeView.Name = "labelDonationTypeView";
            this.labelDonationTypeView.Size = new System.Drawing.Size(75, 24);
            this.labelDonationTypeView.TabIndex = 2;
            this.labelDonationTypeView.Text = "نوع التبرع";
            // 
            // lblDonorText
            // 
            this.lblDonorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDonorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblDonorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDonorText.Location = new System.Drawing.Point(10, 35);
            this.lblDonorText.Name = "lblDonorText";
            this.lblDonorText.Size = new System.Drawing.Size(490, 30);
            this.lblDonorText.TabIndex = 1;
            this.lblDonorText.Text = "----";
            // 
            // labelDonorView
            // 
            this.labelDonorView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDonorView.AutoSize = true;
            this.labelDonorView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.labelDonorView.Location = new System.Drawing.Point(440, 5);
            this.labelDonorView.Name = "labelDonorView";
            this.labelDonorView.Size = new System.Drawing.Size(54, 24);
            this.labelDonorView.TabIndex = 0;
            this.labelDonorView.Text = "المتبرع";
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
            this.lblPanelTitle.Text = "تفاصيل التبرع";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.pnlSmart;
            // 
            // frmDonations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.pnlBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDonations";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "استلام التبرعات";
            this.pnlBody.ResumeLayout(false);
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationsList)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonationsList;
        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel pnlSmart;
        private System.Windows.Forms.Panel pnlInputs;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label labelNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label labelAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private Guna.UI2.WinForms.Guna2ComboBox cmbItem;
        private System.Windows.Forms.Label labelItem;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDonationType;
        private System.Windows.Forms.Label labelDonationType;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDonor;
        private System.Windows.Forms.Label labelDonor;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Label lblNotesText;
        private System.Windows.Forms.Label labelNotesView;
        private System.Windows.Forms.Label lblAmountText;
        private System.Windows.Forms.Label labelAmountView;
        private System.Windows.Forms.Label lblQuantityText;
        private System.Windows.Forms.Label labelQuantityView;
        private System.Windows.Forms.Label lblItemText;
        private System.Windows.Forms.Label labelItemView;
        private System.Windows.Forms.Label lblDonationTypeText;
        private System.Windows.Forms.Label labelDonationTypeView;
        private System.Windows.Forms.Label lblDonorText;
        private System.Windows.Forms.Label labelDonorView;
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

