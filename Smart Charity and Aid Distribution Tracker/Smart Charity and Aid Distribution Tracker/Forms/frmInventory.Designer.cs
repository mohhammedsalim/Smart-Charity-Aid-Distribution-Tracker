namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    partial class frmInventory
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
            this.dgvInventoryList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cmbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSmart = new System.Windows.Forms.Panel();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.chkIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.txtMinimumQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelMinQty = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnit = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlView = new System.Windows.Forms.Panel();
            this.lblIsActiveText = new System.Windows.Forms.Label();
            this.labelIsActiveView = new System.Windows.Forms.Label();
            this.lblMinQtyText = new System.Windows.Forms.Label();
            this.labelMinQtyView = new System.Windows.Forms.Label();
            this.lblDescriptionText = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCurrentQuantityText = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblUnitText = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCategoryText = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblItemNameText = new System.Windows.Forms.Label();
            this.lblItemNameLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryList)).BeginInit();
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
            this.lblFormTitle.Size = new System.Drawing.Size(126, 29);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "إدارة المخزون";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvInventoryList);
            this.pnlBody.Controls.Add(this.pnlSearch);
            this.pnlBody.Controls.Add(this.pnlSmart);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBody.Size = new System.Drawing.Size(1200, 661);
            this.pnlBody.TabIndex = 1;
            // 
            // dgvInventoryList
            // 
            this.dgvInventoryList.AllowUserToAddRows = false;
            this.dgvInventoryList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvInventoryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryList.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventoryList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventoryList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventoryList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvInventoryList.Location = new System.Drawing.Point(440, 70);
            this.dgvInventoryList.MultiSelect = false;
            this.dgvInventoryList.Name = "dgvInventoryList";
            this.dgvInventoryList.ReadOnly = true;
            this.dgvInventoryList.RowHeadersVisible = false;
            this.dgvInventoryList.RowTemplate.Height = 30;
            this.dgvInventoryList.Size = new System.Drawing.Size(750, 581);
            this.dgvInventoryList.TabIndex = 2;
            this.dgvInventoryList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvInventoryList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dgvInventoryList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
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
            this.pnlInputs.Controls.Add(this.chkIsActive);
            this.pnlInputs.Controls.Add(this.txtMinimumQuantity);
            this.pnlInputs.Controls.Add(this.labelMinQty);
            this.pnlInputs.Controls.Add(this.txtDescription);
            this.pnlInputs.Controls.Add(this.label6);
            this.pnlInputs.Controls.Add(this.txtCurrentQuantity);
            this.pnlInputs.Controls.Add(this.label4);
            this.pnlInputs.Controls.Add(this.txtUnit);
            this.pnlInputs.Controls.Add(this.label5);
            this.pnlInputs.Controls.Add(this.cmbCategory);
            this.pnlInputs.Controls.Add(this.label3);
            this.pnlInputs.Controls.Add(this.txtItemName);
            this.pnlInputs.Controls.Add(this.label1);
            this.pnlInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputs.Location = new System.Drawing.Point(0, 40);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(430, 471);
            this.pnlInputs.TabIndex = 3;
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.CheckedState.BorderRadius = 2;
            this.chkIsActive.CheckedState.BorderThickness = 0;
            this.chkIsActive.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkIsActive.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.chkIsActive.Location = new System.Drawing.Point(305, 480);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(93, 22);
            this.chkIsActive.TabIndex = 14;
            this.chkIsActive.Text = "صنف نشط";
            this.chkIsActive.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkIsActive.UncheckedState.BorderRadius = 2;
            this.chkIsActive.UncheckedState.BorderThickness = 0;
            this.chkIsActive.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // txtMinimumQuantity
            // 
            this.txtMinimumQuantity.BorderRadius = 6;
            this.txtMinimumQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinimumQuantity.DefaultText = "";
            this.txtMinimumQuantity.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtMinimumQuantity.Location = new System.Drawing.Point(32, 340);
            this.txtMinimumQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMinimumQuantity.Name = "txtMinimumQuantity";
            this.txtMinimumQuantity.PasswordChar = '\0';
            this.txtMinimumQuantity.PlaceholderText = "الحد الأدنى للتنبيه...";
            this.txtMinimumQuantity.SelectedText = "";
            this.txtMinimumQuantity.Size = new System.Drawing.Size(366, 40);
            this.txtMinimumQuantity.TabIndex = 13;
            // 
            // labelMinQty
            // 
            this.labelMinQty.AutoSize = true;
            this.labelMinQty.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelMinQty.Location = new System.Drawing.Point(326, 318);
            this.labelMinQty.Name = "labelMinQty";
            this.labelMinQty.Size = new System.Drawing.Size(72, 18);
            this.labelMinQty.TabIndex = 12;
            this.labelMinQty.Text = "الحد الأدنى";
            // 
            // txtDescription
            // 
            this.txtDescription.BorderRadius = 6;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.DefaultText = "";
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtDescription.Location = new System.Drawing.Point(32, 410);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.PlaceholderText = "وصف الصنف...";
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(366, 60);
            this.txtDescription.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label6.Location = new System.Drawing.Point(351, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "الوصف";
            // 
            // txtCurrentQuantity
            // 
            this.txtCurrentQuantity.BorderRadius = 6;
            this.txtCurrentQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCurrentQuantity.DefaultText = "";
            this.txtCurrentQuantity.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtCurrentQuantity.Location = new System.Drawing.Point(32, 270);
            this.txtCurrentQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCurrentQuantity.Name = "txtCurrentQuantity";
            this.txtCurrentQuantity.PasswordChar = '\0';
            this.txtCurrentQuantity.PlaceholderText = "الكمية الحالية...";
            this.txtCurrentQuantity.SelectedText = "";
            this.txtCurrentQuantity.Size = new System.Drawing.Size(366, 40);
            this.txtCurrentQuantity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label4.Location = new System.Drawing.Point(313, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "الكمية الحالية";
            // 
            // txtUnit
            // 
            this.txtUnit.BorderRadius = 6;
            this.txtUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnit.DefaultText = "";
            this.txtUnit.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtUnit.Location = new System.Drawing.Point(32, 200);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.PasswordChar = '\0';
            this.txtUnit.PlaceholderText = "مثال: كيس، قطعة، لتر";
            this.txtUnit.SelectedText = "";
            this.txtUnit.Size = new System.Drawing.Size(366, 40);
            this.txtUnit.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label5.Location = new System.Drawing.Point(328, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "وحدة القياس";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BorderRadius = 6;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCategory.ItemHeight = 34;
            this.cmbCategory.Location = new System.Drawing.Point(32, 130);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(366, 40);
            this.cmbCategory.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label3.Location = new System.Drawing.Point(363, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "الفئة";
            // 
            // txtItemName
            // 
            this.txtItemName.BorderRadius = 6;
            this.txtItemName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtItemName.DefaultText = "";
            this.txtItemName.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtItemName.Location = new System.Drawing.Point(32, 60);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.PasswordChar = '\0';
            this.txtItemName.PlaceholderText = "اسم الصنف...";
            this.txtItemName.SelectedText = "";
            this.txtItemName.Size = new System.Drawing.Size(366, 40);
            this.txtItemName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label1.Location = new System.Drawing.Point(323, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم الصنف";
            // 
            // pnlView
            // 
            this.pnlView.AutoScroll = true;
            this.pnlView.Controls.Add(this.lblIsActiveText);
            this.pnlView.Controls.Add(this.labelIsActiveView);
            this.pnlView.Controls.Add(this.lblMinQtyText);
            this.pnlView.Controls.Add(this.labelMinQtyView);
            this.pnlView.Controls.Add(this.lblDescriptionText);
            this.pnlView.Controls.Add(this.label11);
            this.pnlView.Controls.Add(this.lblCurrentQuantityText);
            this.pnlView.Controls.Add(this.label12);
            this.pnlView.Controls.Add(this.lblUnitText);
            this.pnlView.Controls.Add(this.label14);
            this.pnlView.Controls.Add(this.lblCategoryText);
            this.pnlView.Controls.Add(this.label16);
            this.pnlView.Controls.Add(this.lblItemNameText);
            this.pnlView.Controls.Add(this.lblItemNameLabel);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 40);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(430, 471);
            this.pnlView.TabIndex = 4;
            // 
            // lblIsActiveText
            // 
            this.lblIsActiveText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblIsActiveText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblIsActiveText.Location = new System.Drawing.Point(32, 420);
            this.lblIsActiveText.Name = "lblIsActiveText";
            this.lblIsActiveText.Size = new System.Drawing.Size(366, 23);
            this.lblIsActiveText.TabIndex = 15;
            this.lblIsActiveText.Text = "----";
            // 
            // labelIsActiveView
            // 
            this.labelIsActiveView.AutoSize = true;
            this.labelIsActiveView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelIsActiveView.Location = new System.Drawing.Point(326, 398);
            this.labelIsActiveView.Name = "labelIsActiveView";
            this.labelIsActiveView.Size = new System.Drawing.Size(72, 18);
            this.labelIsActiveView.TabIndex = 14;
            this.labelIsActiveView.Text = "حالة الصنف";
            // 
            // lblMinQtyText
            // 
            this.lblMinQtyText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblMinQtyText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMinQtyText.Location = new System.Drawing.Point(32, 350);
            this.lblMinQtyText.Name = "lblMinQtyText";
            this.lblMinQtyText.Size = new System.Drawing.Size(366, 23);
            this.lblMinQtyText.TabIndex = 13;
            this.lblMinQtyText.Text = "----";
            // 
            // labelMinQtyView
            // 
            this.labelMinQtyView.AutoSize = true;
            this.labelMinQtyView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelMinQtyView.Location = new System.Drawing.Point(326, 328);
            this.labelMinQtyView.Name = "labelMinQtyView";
            this.labelMinQtyView.Size = new System.Drawing.Size(72, 18);
            this.labelMinQtyView.TabIndex = 12;
            this.labelMinQtyView.Text = "الحد الأدنى";
            // 
            // lblDescriptionText
            // 
            this.lblDescriptionText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDescriptionText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescriptionText.Location = new System.Drawing.Point(32, 280);
            this.lblDescriptionText.Name = "lblDescriptionText";
            this.lblDescriptionText.Size = new System.Drawing.Size(366, 40);
            this.lblDescriptionText.TabIndex = 11;
            this.lblDescriptionText.Text = "----";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label11.Location = new System.Drawing.Point(351, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "الوصف";
            // 
            // lblCurrentQuantityText
            // 
            this.lblCurrentQuantityText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentQuantityText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentQuantityText.Location = new System.Drawing.Point(32, 210);
            this.lblCurrentQuantityText.Name = "lblCurrentQuantityText";
            this.lblCurrentQuantityText.Size = new System.Drawing.Size(366, 23);
            this.lblCurrentQuantityText.TabIndex = 9;
            this.lblCurrentQuantityText.Text = "----";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label12.Location = new System.Drawing.Point(313, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "الكمية الحالية";
            // 
            // lblUnitText
            // 
            this.lblUnitText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnitText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUnitText.Location = new System.Drawing.Point(32, 140);
            this.lblUnitText.Name = "lblUnitText";
            this.lblUnitText.Size = new System.Drawing.Size(366, 23);
            this.lblUnitText.TabIndex = 7;
            this.lblUnitText.Text = "----";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label14.Location = new System.Drawing.Point(328, 118);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 6;
            this.label14.Text = "وحدة القياس";
            // 
            // lblCategoryText
            // 
            this.lblCategoryText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCategoryText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCategoryText.Location = new System.Drawing.Point(32, 70);
            this.lblCategoryText.Name = "lblCategoryText";
            this.lblCategoryText.Size = new System.Drawing.Size(366, 23);
            this.lblCategoryText.TabIndex = 5;
            this.lblCategoryText.Text = "----";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label16.Location = new System.Drawing.Point(363, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 18);
            this.label16.TabIndex = 4;
            this.label16.Text = "الفئة";
            // 
            // lblItemNameText
            // 
            this.lblItemNameText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemNameText.Location = new System.Drawing.Point(32, 0);
            this.lblItemNameText.Name = "lblItemNameText";
            this.lblItemNameText.Size = new System.Drawing.Size(366, 23);
            this.lblItemNameText.TabIndex = 1;
            this.lblItemNameText.Text = "----";
            // 
            // lblItemNameLabel
            // 
            this.lblItemNameLabel.AutoSize = true;
            this.lblItemNameLabel.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblItemNameLabel.Location = new System.Drawing.Point(323, -22);
            this.lblItemNameLabel.Name = "lblItemNameLabel";
            this.lblItemNameLabel.Size = new System.Drawing.Size(75, 18);
            this.lblItemNameLabel.TabIndex = 0;
            this.lblItemNameLabel.Text = "اسم الصنف";
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
            this.lblPanelTitle.Text = "تفاصيل الصنف";
            this.lblPanelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this.pnlSmart;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1200, 721);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmInventory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "إدارة المخزون - نظام سند";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryList)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvInventoryList;
        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel pnlSmart;
        private System.Windows.Forms.Panel pnlInputs;
        private Guna.UI2.WinForms.Guna2CheckBox chkIsActive;
        private Guna.UI2.WinForms.Guna2TextBox txtMinimumQuantity;
        private System.Windows.Forms.Label labelMinQty;
        private Guna.UI2.WinForms.Guna2TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtCurrentQuantity;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtUnit;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCategory;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Label lblIsActiveText;
        private System.Windows.Forms.Label labelIsActiveView;
        private System.Windows.Forms.Label lblMinQtyText;
        private System.Windows.Forms.Label labelMinQtyView;
        private System.Windows.Forms.Label lblDescriptionText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCurrentQuantityText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblUnitText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCategoryText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblItemNameText;
        private System.Windows.Forms.Label lblItemNameLabel;
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
