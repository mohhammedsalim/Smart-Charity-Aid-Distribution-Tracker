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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.pnlView = new System.Windows.Forms.Panel();
            this.dgvCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.numQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBeneficiary = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlType = new System.Windows.Forms.Panel();
            this.rbCash = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rbInKind = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddItemToCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnRemoveFromCart = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearCart = new Guna.UI2.WinForms.Guna2Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pnlHeader.SuspendLayout();
            this.pnlCart.SuspendLayout();
            this.pnlView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.pnlInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.pnlType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblFormTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1600, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFormTitle.Location = new System.Drawing.Point(710, 9);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(196, 37);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "صرف المساعدات";
            // 
            // pnlCart
            // 
            this.pnlCart.Controls.Add(this.pnlView);
            this.pnlCart.Controls.Add(this.pnlInputs);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCart.Location = new System.Drawing.Point(0, 60);
            this.pnlCart.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlCart.Size = new System.Drawing.Size(1600, 740);
            this.pnlCart.TabIndex = 1;
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.Color.White;
            this.pnlView.Controls.Add(this.dgvCart);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(13, 12);
            this.pnlView.Margin = new System.Windows.Forms.Padding(4);
            this.pnlView.Name = "pnlView";
            this.pnlView.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlView.Size = new System.Drawing.Size(1032, 716);
            this.pnlView.TabIndex = 1;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.ColumnHeadersHeight = 35;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colItemID,
            this.colItemName,
            this.colQuantity,
            this.colUnit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCart.Location = new System.Drawing.Point(13, 12);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.ReadOnly = true;
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 30;
            this.dgvCart.Size = new System.Drawing.Size(1006, 692);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCart.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCart.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvCart.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCart.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCart.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCart.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dgvCart.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCart.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCart.ThemeStyle.ReadOnly = true;
            this.dgvCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCart.ThemeStyle.RowsStyle.Height = 30;
            this.dgvCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colItemID
            // 
            this.colItemID.HeaderText = "رقم الصنف";
            this.colItemID.MinimumWidth = 6;
            this.colItemID.Name = "colItemID";
            this.colItemID.ReadOnly = true;
            this.colItemID.Visible = false;
            // 
            // colItemName
            // 
            this.colItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colItemName.HeaderText = "اسم الصنف";
            this.colItemName.MinimumWidth = 6;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "الكمية";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colUnit
            // 
            this.colUnit.HeaderText = "الوحدة";
            this.colUnit.MinimumWidth = 6;
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            // 
            // pnlInputs
            // 
            this.pnlInputs.AutoScroll = true;
            this.pnlInputs.BackColor = System.Drawing.Color.White;
            this.pnlInputs.Controls.Add(this.numQuantity);
            this.pnlInputs.Controls.Add(this.label2);
            this.pnlInputs.Controls.Add(this.cmbBeneficiary);
            this.pnlInputs.Controls.Add(this.label6);
            this.pnlInputs.Controls.Add(this.pnlType);
            this.pnlInputs.Controls.Add(this.label3);
            this.pnlInputs.Controls.Add(this.cmbItem);
            this.pnlInputs.Controls.Add(this.label4);
            this.pnlInputs.Controls.Add(this.btnAddItemToCart);
            this.pnlInputs.Controls.Add(this.btnRemoveFromCart);
            this.pnlInputs.Controls.Add(this.btnClearCart);
            this.pnlInputs.Controls.Add(this.lblAmount);
            this.pnlInputs.Controls.Add(this.txtAmount);
            this.pnlInputs.Controls.Add(this.label5);
            this.pnlInputs.Controls.Add(this.txtNotes);
            this.pnlInputs.Controls.Add(this.btnSave);
            this.pnlInputs.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInputs.Location = new System.Drawing.Point(1045, 12);
            this.pnlInputs.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(542, 716);
            this.pnlInputs.TabIndex = 0;
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
            this.numQuantity.Location = new System.Drawing.Point(292, 331);
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
            this.numQuantity.Size = new System.Drawing.Size(212, 38);
            this.numQuantity.TabIndex = 18;
            this.numQuantity.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.numQuantity.UpDownButtonForeColor = System.Drawing.Color.White;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label2.Location = new System.Drawing.Point(407, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "المستفيد";
            // 
            // cmbBeneficiary
            // 
            this.cmbBeneficiary.AllowDrop = true;
            this.cmbBeneficiary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.cmbBeneficiary.BackColor = System.Drawing.Color.Transparent;
            this.cmbBeneficiary.BorderRadius = 6;
            this.cmbBeneficiary.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBeneficiary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeneficiary.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBeneficiary.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbBeneficiary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBeneficiary.ItemHeight = 30;
            this.cmbBeneficiary.Location = new System.Drawing.Point(81, 59);
            this.cmbBeneficiary.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBeneficiary.Name = "cmbBeneficiary";
            this.cmbBeneficiary.Size = new System.Drawing.Size(390, 36);
            this.cmbBeneficiary.Sorted = true;
            this.cmbBeneficiary.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label6.Location = new System.Drawing.Point(398, 113);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "نوع الصرف";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // pnlType
            // 
            this.pnlType.Controls.Add(this.rbCash);
            this.pnlType.Controls.Add(this.rbInKind);
            this.pnlType.Location = new System.Drawing.Point(81, 140);
            this.pnlType.Margin = new System.Windows.Forms.Padding(4);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(390, 41);
            this.pnlType.TabIndex = 13;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbCash.CheckedState.BorderThickness = 0;
            this.rbCash.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbCash.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbCash.CheckedState.InnerOffset = -4;
            this.rbCash.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.rbCash.Location = new System.Drawing.Point(69, 10);
            this.rbCash.Margin = new System.Windows.Forms.Padding(4);
            this.rbCash.Name = "rbCash";
            this.rbCash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbCash.Size = new System.Drawing.Size(105, 27);
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
            this.rbInKind.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInKind.CheckedState.BorderThickness = 0;
            this.rbInKind.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbInKind.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbInKind.CheckedState.InnerOffset = -4;
            this.rbInKind.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.rbInKind.Location = new System.Drawing.Point(237, 10);
            this.rbInKind.Margin = new System.Windows.Forms.Padding(4);
            this.rbInKind.Name = "rbInKind";
            this.rbInKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbInKind.Size = new System.Drawing.Size(99, 27);
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
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label3.Location = new System.Drawing.Point(419, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "الصنف";
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.Transparent;
            this.cmbItem.BorderRadius = 6;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FocusedColor = System.Drawing.Color.Empty;
            this.cmbItem.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbItem.ItemHeight = 30;
            this.cmbItem.Location = new System.Drawing.Point(81, 234);
            this.cmbItem.Margin = new System.Windows.Forms.Padding(4);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(390, 36);
            this.cmbItem.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label4.Location = new System.Drawing.Point(428, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "الكمية";
            // 
            // btnAddItemToCart
            // 
            this.btnAddItemToCart.BorderRadius = 8;
            this.btnAddItemToCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddItemToCart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddItemToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddItemToCart.Location = new System.Drawing.Point(81, 331);
            this.btnAddItemToCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItemToCart.Name = "btnAddItemToCart";
            this.btnAddItemToCart.Size = new System.Drawing.Size(157, 38);
            this.btnAddItemToCart.TabIndex = 6;
            this.btnAddItemToCart.Text = "إضافة للسلة";
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.BorderRadius = 8;
            this.btnRemoveFromCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRemoveFromCart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRemoveFromCart.ForeColor = System.Drawing.Color.White;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(259, 394);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(224, 38);
            this.btnRemoveFromCart.TabIndex = 16;
            this.btnRemoveFromCart.Text = "حذف الصنف المحدد";
            // 
            // btnClearCart
            // 
            this.btnClearCart.BorderRadius = 8;
            this.btnClearCart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClearCart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnClearCart.ForeColor = System.Drawing.Color.White;
            this.btnClearCart.Location = new System.Drawing.Point(81, 394);
            this.btnClearCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(157, 38);
            this.btnClearCart.TabIndex = 17;
            this.btnClearCart.Text = "إفراغ السلة";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblAmount.Location = new System.Drawing.Point(428, 207);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(47, 23);
            this.lblAmount.TabIndex = 14;
            this.lblAmount.Text = "المبلغ";
            this.lblAmount.Visible = false;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderRadius = 6;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtAmount.Location = new System.Drawing.Point(81, 239);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PlaceholderText = "أدخل المبلغ النقدي";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(390, 31);
            this.txtAmount.TabIndex = 15;
            this.txtAmount.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.label5.Location = new System.Drawing.Point(405, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "ملاحظات";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 6;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtNotes.Location = new System.Drawing.Point(81, 479);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "أي ملاحظات إضافية حول عملية الصرف...";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(402, 73);
            this.txtNotes.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(138, 562);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(312, 35);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "حفظ واعتماد عملية الصرف";
            // 
            // frmDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1600, 800);
            this.Controls.Add(this.pnlCart);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDistribution";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "صرف المساعدات - نظام سند";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlCart.ResumeLayout(false);
            this.pnlView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.pnlInputs.ResumeLayout(false);
            this.pnlInputs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlCart;
        private System.Windows.Forms.Panel pnlInputs;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBeneficiary;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbItem;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnAddItemToCart;
        private Guna.UI2.WinForms.Guna2Button btnRemoveFromCart;
        private Guna.UI2.WinForms.Guna2Button btnClearCart;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Panel pnlView;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlType;
        private Guna.UI2.WinForms.Guna2RadioButton rbCash;
        private Guna.UI2.WinForms.Guna2RadioButton rbInKind;
        private System.Windows.Forms.Label lblAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private Guna.UI2.WinForms.Guna2NumericUpDown numQuantity;
    }
}
