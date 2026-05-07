namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    partial class frmDistribution
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
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
            this.pnlSmart = new System.Windows.Forms.Panel();
            this.pnlCart = new System.Windows.Forms.Panel();
            this.dgvCart = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCartHeader = new System.Windows.Forms.Panel();
            this.lblCartTitle = new System.Windows.Forms.Label();
            this.pnlAddItem = new System.Windows.Forms.Panel();
            this.btnAddItemToCart = new Guna.UI2.WinForms.Guna2Button();
            this.numQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbInventoryItems = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlBeneficiary = new System.Windows.Forms.Panel();
            this.cmbBeneficiaries = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.lblPanelTitle = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlSmart.SuspendLayout();
            this.pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.pnlCartHeader.SuspendLayout();
            this.pnlAddItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.pnlBeneficiary.SuspendLayout();
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
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1600, 74);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnBackToDashBoard
            // 
            this.btnBackToDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToDashBoard.BorderRadius = 8;
            this.btnBackToDashBoard.FillColor = System.Drawing.Color.White;
            this.btnBackToDashBoard.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBackToDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBackToDashBoard.ImageSize = new System.Drawing.Size(24, 24);
            this.btnBackToDashBoard.Location = new System.Drawing.Point(1384, 15);
            this.btnBackToDashBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btnBackToDashBoard.Name = "btnBackToDashBoard";
            this.btnBackToDashBoard.Size = new System.Drawing.Size(200, 49);
            this.btnBackToDashBoard.TabIndex = 1;
            this.btnBackToDashBoard.Text = "العودة للرئيسية";
            this.btnBackToDashBoard.Click += new System.EventHandler(this.btnBackToDashBoard_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFormTitle.Location = new System.Drawing.Point(16, 20);
            this.lblFormTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(229, 37);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "تسجيل عملية توزيع";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.pnlSmart);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 74);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlBody.Size = new System.Drawing.Size(1600, 813);
            this.pnlBody.TabIndex = 2;
            // 
            // pnlSmart
            // 
            this.pnlSmart.BackColor = System.Drawing.Color.White;
            this.pnlSmart.Controls.Add(this.pnlCart);
            this.pnlSmart.Controls.Add(this.pnlAddItem);
            this.pnlSmart.Controls.Add(this.pnlBeneficiary);
            this.pnlSmart.Controls.Add(this.pnlActions);
            this.pnlSmart.Controls.Add(this.lblPanelTitle);
            this.pnlSmart.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSmart.Location = new System.Drawing.Point(13, 12);
            this.pnlSmart.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSmart.Name = "pnlSmart";
            this.pnlSmart.Size = new System.Drawing.Size(640, 789);
            this.pnlSmart.TabIndex = 1;
            // 
            // pnlCart
            // 
            this.pnlCart.Controls.Add(this.dgvCart);
            this.pnlCart.Controls.Add(this.pnlCartHeader);
            this.pnlCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCart.Location = new System.Drawing.Point(0, 262);
            this.pnlCart.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCart.Name = "pnlCart";
            this.pnlCart.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.pnlCart.Size = new System.Drawing.Size(640, 429);
            this.pnlCart.TabIndex = 5;
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
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
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
            this.dgvCart.Location = new System.Drawing.Point(13, 49);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 30;
            this.dgvCart.Size = new System.Drawing.Size(614, 380);
            this.dgvCart.TabIndex = 1;
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
            this.dgvCart.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvCart.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvCart.ThemeStyle.ReadOnly = false;
            this.dgvCart.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCart.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCart.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.dgvCart.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCart.ThemeStyle.RowsStyle.Height = 30;
            this.dgvCart.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCart.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCart.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvCart_UserDeletingRow);
            // 
            // colItemID
            // 
            this.colItemID.HeaderText = "ItemID";
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
            // pnlCartHeader
            // 
            this.pnlCartHeader.Controls.Add(this.lblCartTitle);
            this.pnlCartHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCartHeader.Location = new System.Drawing.Point(13, 0);
            this.pnlCartHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCartHeader.Name = "pnlCartHeader";
            this.pnlCartHeader.Size = new System.Drawing.Size(614, 49);
            this.pnlCartHeader.TabIndex = 0;
            // 
            // lblCartTitle
            // 
            this.lblCartTitle.AutoSize = true;
            this.lblCartTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCartTitle.Location = new System.Drawing.Point(427, 12);
            this.lblCartTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCartTitle.Name = "lblCartTitle";
            this.lblCartTitle.Size = new System.Drawing.Size(139, 24);
            this.lblCartTitle.TabIndex = 0;
            this.lblCartTitle.Text = "سلة المواد الموزعة";
            // 
            // pnlAddItem
            // 
            this.pnlAddItem.Controls.Add(this.btnAddItemToCart);
            this.pnlAddItem.Controls.Add(this.numQuantity);
            this.pnlAddItem.Controls.Add(this.label5);
            this.pnlAddItem.Controls.Add(this.cmbInventoryItems);
            this.pnlAddItem.Controls.Add(this.label4);
            this.pnlAddItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAddItem.Location = new System.Drawing.Point(0, 139);
            this.pnlAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAddItem.Name = "pnlAddItem";
            this.pnlAddItem.Size = new System.Drawing.Size(640, 123);
            this.pnlAddItem.TabIndex = 4;
            // 
            // btnAddItemToCart
            // 
            this.btnAddItemToCart.BorderRadius = 8;
            this.btnAddItemToCart.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnAddItemToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddItemToCart.Location = new System.Drawing.Point(29, 52);
            this.btnAddItemToCart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItemToCart.Name = "btnAddItemToCart";
            this.btnAddItemToCart.Size = new System.Drawing.Size(160, 49);
            this.btnAddItemToCart.TabIndex = 10;
            this.btnAddItemToCart.Text = "إضافة للسلة";
            this.btnAddItemToCart.Click += new System.EventHandler(this.btnAddItemToCart_Click);
            // 
            // numQuantity
            // 
            this.numQuantity.BackColor = System.Drawing.Color.Transparent;
            this.numQuantity.BorderRadius = 6;
            this.numQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numQuantity.DecimalPlaces = 2;
            this.numQuantity.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.numQuantity.Location = new System.Drawing.Point(211, 52);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(133, 49);
            this.numQuantity.TabIndex = 9;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(285, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "الكمية";
            // 
            // cmbInventoryItems
            // 
            this.cmbInventoryItems.BackColor = System.Drawing.Color.Transparent;
            this.cmbInventoryItems.BorderRadius = 6;
            this.cmbInventoryItems.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbInventoryItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInventoryItems.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbInventoryItems.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbInventoryItems.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbInventoryItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbInventoryItems.ItemHeight = 34;
            this.cmbInventoryItems.Location = new System.Drawing.Point(365, 52);
            this.cmbInventoryItems.Margin = new System.Windows.Forms.Padding(4);
            this.cmbInventoryItems.Name = "cmbInventoryItems";
            this.cmbInventoryItems.Size = new System.Drawing.Size(239, 40);
            this.cmbInventoryItems.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "اختر صنفاً";
            // 
            // pnlBeneficiary
            // 
            this.pnlBeneficiary.Controls.Add(this.cmbBeneficiaries);
            this.pnlBeneficiary.Controls.Add(this.label3);
            this.pnlBeneficiary.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBeneficiary.Location = new System.Drawing.Point(0, 41);
            this.pnlBeneficiary.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBeneficiary.Name = "pnlBeneficiary";
            this.pnlBeneficiary.Size = new System.Drawing.Size(640, 98);
            this.pnlBeneficiary.TabIndex = 3;
            // 
            // cmbBeneficiaries
            // 
            this.cmbBeneficiaries.BackColor = System.Drawing.Color.Transparent;
            this.cmbBeneficiaries.BorderRadius = 6;
            this.cmbBeneficiaries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBeneficiaries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBeneficiaries.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBeneficiaries.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBeneficiaries.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbBeneficiaries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBeneficiaries.ItemHeight = 34;
            this.cmbBeneficiaries.Location = new System.Drawing.Point(29, 34);
            this.cmbBeneficiaries.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBeneficiaries.Name = "cmbBeneficiaries";
            this.cmbBeneficiaries.Size = new System.Drawing.Size(575, 40);
            this.cmbBeneficiaries.TabIndex = 5;
            this.cmbBeneficiaries.SelectedIndexChanged += new System.EventHandler(this.cmbBeneficiaries_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(491, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "اختر المستفيد";
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlActions.Location = new System.Drawing.Point(0, 691);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(640, 98);
            this.pnlActions.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BorderRadius = 8;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(29, 22);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(576, 55);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ عملية التوزيع";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPanelTitle
            // 
            this.lblPanelTitle.AutoSize = true;
            this.lblPanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPanelTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPanelTitle.Location = new System.Drawing.Point(0, 0);
            this.lblPanelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPanelTitle.Name = "lblPanelTitle";
            this.lblPanelTitle.Padding = new System.Windows.Forms.Padding(0, 12, 13, 0);
            this.lblPanelTitle.Size = new System.Drawing.Size(235, 41);
            this.lblPanelTitle.TabIndex = 0;
            this.lblPanelTitle.Text = "الخطوة 1: اختر المستفيد";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this.pnlSmart;
            // 
            // frmDistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1600, 887);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDistribution";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "تسجيل عملية توزيع - نظام سند";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDistribution_FormClosed);
            this.Load += new System.EventHandler(this.frmDistribution_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            this.pnlSmart.ResumeLayout(false);
            this.pnlSmart.PerformLayout();
            this.pnlCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.pnlCartHeader.ResumeLayout(false);
            this.pnlCartHeader.PerformLayout();
            this.pnlAddItem.ResumeLayout(false);
            this.pnlAddItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.pnlBeneficiary.ResumeLayout(false);
            this.pnlBeneficiary.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Button btnBackToDashBoard;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlSmart;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblPanelTitle;
        private System.Windows.Forms.Panel pnlActions;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Panel pnlBeneficiary;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBeneficiaries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlAddItem;
        private Guna.UI2.WinForms.Guna2ComboBox cmbInventoryItems;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2NumericUpDown numQuantity;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnAddItemToCart;
        private System.Windows.Forms.Panel pnlCart;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCart;
        private System.Windows.Forms.Panel pnlCartHeader;
        private System.Windows.Forms.Label lblCartTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
    }
}
