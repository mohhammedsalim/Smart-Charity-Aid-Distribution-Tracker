namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    partial class frmItemManagement
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
            this.btnBackToInventoryManagement = new Guna.UI2.WinForms.Guna2Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlItemProcedures = new Guna.UI2.WinForms.Guna2Panel();
            this.lblItemProcedures = new System.Windows.Forms.Label();
            this.btnAddNewItem = new Guna.UI2.WinForms.Guna2Button();
            this.btnItemAdjustment = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteItem = new Guna.UI2.WinForms.Guna2Button();
            this.pnlItemDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.lblItemDetails = new System.Windows.Forms.Label();
            this.pnlSep1 = new System.Windows.Forms.Panel();
            this.lblItemCode = new System.Windows.Forms.Label();
            this.lblItemCodeText = new System.Windows.Forms.Label();
            this.pnlSep2 = new System.Windows.Forms.Panel();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblItemNameText = new System.Windows.Forms.Label();
            this.pnlSep3 = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategoryText = new System.Windows.Forms.Label();
            this.pnlSep4 = new System.Windows.Forms.Panel();
            this.lblMinimum = new System.Windows.Forms.Label();
            this.lblMinimumText = new System.Windows.Forms.Label();
            this.lblEstimatedValue = new System.Windows.Forms.Label();
            this.lblEstimatedValueText = new System.Windows.Forms.Label();
            this.pnlSep5 = new System.Windows.Forms.Panel();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblUnitText = new System.Windows.Forms.Label();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.picSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblResearchValue = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.pnlListOfItems = new Guna.UI2.WinForms.Guna2Panel();
            this.lblListOfItems = new System.Windows.Forms.Label();
            this.picListOfItems = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblLabelInventoryBalances = new System.Windows.Forms.Label();
            this.lblNumberInventoryBalances = new System.Windows.Forms.Label();
            this.lblTextInventoryBalances = new System.Windows.Forms.Label();
            this.lblListOfItemsDis = new System.Windows.Forms.Label();
            this.dgvListOfItems = new System.Windows.Forms.DataGridView();
            this.pnlTopBar.SuspendLayout();
            this.pnlItemProcedures.SuspendLayout();
            this.pnlItemDetails.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlListOfItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListOfItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopBar.Controls.Add(this.btnBackToInventoryManagement);
            this.pnlTopBar.Controls.Add(this.lblFormTitle);
            this.pnlTopBar.FillColor = System.Drawing.Color.White;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1312, 54);
            this.pnlTopBar.TabIndex = 0;
            // 
            // btnBackToInventoryManagement
            // 
            this.btnBackToInventoryManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToInventoryManagement.BorderRadius = 8;
            this.btnBackToInventoryManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnBackToInventoryManagement.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToInventoryManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBackToInventoryManagement.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnBackToInventoryManagement.Location = new System.Drawing.Point(1072, 8);
            this.btnBackToInventoryManagement.Name = "btnBackToInventoryManagement";
            this.btnBackToInventoryManagement.Size = new System.Drawing.Size(224, 38);
            this.btnBackToInventoryManagement.TabIndex = 0;
            this.btnBackToInventoryManagement.Text = "العودة إلى ادارة المخزون";
            this.btnBackToInventoryManagement.Click += new System.EventHandler(this.btnBackToInventoryManagement_Click);
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblFormTitle.Location = new System.Drawing.Point(556, 14);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(127, 29);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "إدارة الاصناف";
            // 
            // pnlItemProcedures
            // 
            this.pnlItemProcedures.BackColor = System.Drawing.Color.Transparent;
            this.pnlItemProcedures.BorderRadius = 12;
            this.pnlItemProcedures.Controls.Add(this.lblItemProcedures);
            this.pnlItemProcedures.Controls.Add(this.btnAddNewItem);
            this.pnlItemProcedures.Controls.Add(this.btnItemAdjustment);
            this.pnlItemProcedures.Controls.Add(this.btnDeleteItem);
            this.pnlItemProcedures.FillColor = System.Drawing.Color.White;
            this.pnlItemProcedures.Location = new System.Drawing.Point(16, 62);
            this.pnlItemProcedures.Name = "pnlItemProcedures";
            this.pnlItemProcedures.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlItemProcedures.ShadowDecoration.Depth = 8;
            this.pnlItemProcedures.ShadowDecoration.Enabled = true;
            this.pnlItemProcedures.Size = new System.Drawing.Size(498, 146);
            this.pnlItemProcedures.TabIndex = 1;
            // 
            // lblItemProcedures
            // 
            this.lblItemProcedures.AutoSize = true;
            this.lblItemProcedures.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemProcedures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblItemProcedures.Location = new System.Drawing.Point(341, 14);
            this.lblItemProcedures.Name = "lblItemProcedures";
            this.lblItemProcedures.Size = new System.Drawing.Size(130, 24);
            this.lblItemProcedures.TabIndex = 0;
            this.lblItemProcedures.Text = "اجراءات الاصناف";
            // 
            // btnAddNewItem
            // 
            this.btnAddNewItem.BorderRadius = 10;
            this.btnAddNewItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnAddNewItem.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddNewItem.ForeColor = System.Drawing.Color.White;
            this.btnAddNewItem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnAddNewItem.Location = new System.Drawing.Point(18, 50);
            this.btnAddNewItem.Name = "btnAddNewItem";
            this.btnAddNewItem.Size = new System.Drawing.Size(462, 39);
            this.btnAddNewItem.TabIndex = 1;
            this.btnAddNewItem.Text = "إضافة صنف جديد";
            this.btnAddNewItem.Click += new System.EventHandler(this.btnAddNewItem_Click);
            // 
            // btnItemAdjustment
            // 
            this.btnItemAdjustment.BorderRadius = 10;
            this.btnItemAdjustment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnItemAdjustment.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnItemAdjustment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnItemAdjustment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnItemAdjustment.Location = new System.Drawing.Point(249, 98);
            this.btnItemAdjustment.Name = "btnItemAdjustment";
            this.btnItemAdjustment.Size = new System.Drawing.Size(231, 39);
            this.btnItemAdjustment.TabIndex = 2;
            this.btnItemAdjustment.Text = "تعديل الصنف";
            this.btnItemAdjustment.Click += new System.EventHandler(this.btnItemAdjustment_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.BorderRadius = 10;
            this.btnDeleteItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDeleteItem.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDeleteItem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnDeleteItem.Location = new System.Drawing.Point(18, 98);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(224, 39);
            this.btnDeleteItem.TabIndex = 3;
            this.btnDeleteItem.Text = "حذف الصنف";
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // pnlItemDetails
            // 
            this.pnlItemDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlItemDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlItemDetails.BorderRadius = 12;
            this.pnlItemDetails.Controls.Add(this.lblItemDetails);
            this.pnlItemDetails.Controls.Add(this.pnlSep1);
            this.pnlItemDetails.Controls.Add(this.lblItemCode);
            this.pnlItemDetails.Controls.Add(this.lblItemCodeText);
            this.pnlItemDetails.Controls.Add(this.pnlSep2);
            this.pnlItemDetails.Controls.Add(this.lblItemName);
            this.pnlItemDetails.Controls.Add(this.lblItemNameText);
            this.pnlItemDetails.Controls.Add(this.pnlSep3);
            this.pnlItemDetails.Controls.Add(this.lblCategory);
            this.pnlItemDetails.Controls.Add(this.lblCategoryText);
            this.pnlItemDetails.Controls.Add(this.pnlSep4);
            this.pnlItemDetails.Controls.Add(this.lblMinimum);
            this.pnlItemDetails.Controls.Add(this.lblMinimumText);
            this.pnlItemDetails.Controls.Add(this.lblEstimatedValue);
            this.pnlItemDetails.Controls.Add(this.lblEstimatedValueText);
            this.pnlItemDetails.Controls.Add(this.pnlSep5);
            this.pnlItemDetails.Controls.Add(this.lblUnit);
            this.pnlItemDetails.Controls.Add(this.lblUnitText);
            this.pnlItemDetails.FillColor = System.Drawing.Color.White;
            this.pnlItemDetails.Location = new System.Drawing.Point(16, 224);
            this.pnlItemDetails.Name = "pnlItemDetails";
            this.pnlItemDetails.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlItemDetails.ShadowDecoration.Depth = 8;
            this.pnlItemDetails.ShadowDecoration.Enabled = true;
            this.pnlItemDetails.Size = new System.Drawing.Size(498, 452);
            this.pnlItemDetails.TabIndex = 2;
            // 
            // lblItemDetails
            // 
            this.lblItemDetails.AutoSize = true;
            this.lblItemDetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblItemDetails.Location = new System.Drawing.Point(348, 10);
            this.lblItemDetails.Name = "lblItemDetails";
            this.lblItemDetails.Size = new System.Drawing.Size(117, 24);
            this.lblItemDetails.TabIndex = 0;
            this.lblItemDetails.Text = "تفاصيل الصنف";
            // 
            // pnlSep1
            // 
            this.pnlSep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep1.Location = new System.Drawing.Point(4, 89);
            this.pnlSep1.Name = "pnlSep1";
            this.pnlSep1.Size = new System.Drawing.Size(488, 1);
            this.pnlSep1.TabIndex = 1;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblItemCode.Location = new System.Drawing.Point(380, 32);
            this.lblItemCode.Name = "lblItemCode";
            this.lblItemCode.Size = new System.Drawing.Size(76, 21);
            this.lblItemCode.TabIndex = 2;
            this.lblItemCode.Text = "كود الصنف";
            // 
            // lblItemCodeText
            // 
            this.lblItemCodeText.AutoSize = true;
            this.lblItemCodeText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblItemCodeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblItemCodeText.Location = new System.Drawing.Point(362, 56);
            this.lblItemCodeText.Name = "lblItemCodeText";
            this.lblItemCodeText.Size = new System.Drawing.Size(96, 23);
            this.lblItemCodeText.TabIndex = 3;
            this.lblItemCodeText.Text = "0000-0000";
            this.lblItemCodeText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlSep2
            // 
            this.pnlSep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep2.Location = new System.Drawing.Point(4, 162);
            this.pnlSep2.Name = "pnlSep2";
            this.pnlSep2.Size = new System.Drawing.Size(488, 1);
            this.pnlSep2.TabIndex = 4;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblItemName.Location = new System.Drawing.Point(376, 110);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(77, 21);
            this.lblItemName.TabIndex = 5;
            this.lblItemName.Text = "اسم الصنف";
            // 
            // lblItemNameText
            // 
            this.lblItemNameText.AutoSize = true;
            this.lblItemNameText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblItemNameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblItemNameText.Location = new System.Drawing.Point(315, 133);
            this.lblItemNameText.Name = "lblItemNameText";
            this.lblItemNameText.Size = new System.Drawing.Size(130, 23);
            this.lblItemNameText.TabIndex = 6;
            this.lblItemNameText.Text = "XXXXXXXXXXXX";
            this.lblItemNameText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlSep3
            // 
            this.pnlSep3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep3.Location = new System.Drawing.Point(4, 228);
            this.pnlSep3.Name = "pnlSep3";
            this.pnlSep3.Size = new System.Drawing.Size(488, 1);
            this.pnlSep3.TabIndex = 7;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblCategory.Location = new System.Drawing.Point(423, 178);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(36, 21);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "الفئة";
            // 
            // lblCategoryText
            // 
            this.lblCategoryText.AutoSize = true;
            this.lblCategoryText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblCategoryText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblCategoryText.Location = new System.Drawing.Point(304, 201);
            this.lblCategoryText.Name = "lblCategoryText";
            this.lblCategoryText.Size = new System.Drawing.Size(140, 23);
            this.lblCategoryText.TabIndex = 9;
            this.lblCategoryText.Text = "XXXXXXXXXXXXX";
            this.lblCategoryText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlSep4
            // 
            this.pnlSep4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep4.Location = new System.Drawing.Point(4, 300);
            this.pnlSep4.Name = "pnlSep4";
            this.pnlSep4.Size = new System.Drawing.Size(488, 1);
            this.pnlSep4.TabIndex = 10;
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblMinimum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblMinimum.Location = new System.Drawing.Point(384, 245);
            this.lblMinimum.Name = "lblMinimum";
            this.lblMinimum.Size = new System.Drawing.Size(69, 21);
            this.lblMinimum.TabIndex = 11;
            this.lblMinimum.Text = "الحد الادنى";
            // 
            // lblMinimumText
            // 
            this.lblMinimumText.AutoSize = true;
            this.lblMinimumText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblMinimumText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblMinimumText.Location = new System.Drawing.Point(304, 267);
            this.lblMinimumText.Name = "lblMinimumText";
            this.lblMinimumText.Size = new System.Drawing.Size(140, 23);
            this.lblMinimumText.TabIndex = 12;
            this.lblMinimumText.Text = "XXXXXXXXXXXXX";
            this.lblMinimumText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEstimatedValue
            // 
            this.lblEstimatedValue.AutoSize = true;
            this.lblEstimatedValue.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblEstimatedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblEstimatedValue.Location = new System.Drawing.Point(352, 316);
            this.lblEstimatedValue.Name = "lblEstimatedValue";
            this.lblEstimatedValue.Size = new System.Drawing.Size(95, 21);
            this.lblEstimatedValue.TabIndex = 13;
            this.lblEstimatedValue.Text = "القيمة التقديرية";
            // 
            // lblEstimatedValueText
            // 
            this.lblEstimatedValueText.AutoSize = true;
            this.lblEstimatedValueText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblEstimatedValueText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblEstimatedValueText.Location = new System.Drawing.Point(326, 338);
            this.lblEstimatedValueText.Name = "lblEstimatedValueText";
            this.lblEstimatedValueText.Size = new System.Drawing.Size(120, 23);
            this.lblEstimatedValueText.TabIndex = 14;
            this.lblEstimatedValueText.Text = "XXXXXXXXXXX";
            this.lblEstimatedValueText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlSep5
            // 
            this.pnlSep5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep5.Location = new System.Drawing.Point(4, 364);
            this.pnlSep5.Name = "pnlSep5";
            this.pnlSep5.Size = new System.Drawing.Size(488, 1);
            this.pnlSep5.TabIndex = 15;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblUnit.Location = new System.Drawing.Point(409, 388);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(48, 21);
            this.lblUnit.TabIndex = 16;
            this.lblUnit.Text = "الوحدة";
            // 
            // lblUnitText
            // 
            this.lblUnitText.AutoSize = true;
            this.lblUnitText.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblUnitText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblUnitText.Location = new System.Drawing.Point(326, 410);
            this.lblUnitText.Name = "lblUnitText";
            this.lblUnitText.Size = new System.Drawing.Size(120, 23);
            this.lblUnitText.TabIndex = 17;
            this.lblUnitText.Text = "XXXXXXXXXXX";
            this.lblUnitText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BorderRadius = 12;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.picSearch);
            this.pnlSearch.Controls.Add(this.lblSearchBy);
            this.pnlSearch.Controls.Add(this.lblResearchValue);
            this.pnlSearch.Controls.Add(this.cmbSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.btnClear);
            this.pnlSearch.FillColor = System.Drawing.Color.White;
            this.pnlSearch.Location = new System.Drawing.Point(523, 62);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSearch.ShadowDecoration.Depth = 8;
            this.pnlSearch.ShadowDecoration.Enabled = true;
            this.pnlSearch.Size = new System.Drawing.Size(773, 146);
            this.pnlSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblSearch.Location = new System.Drawing.Point(579, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(128, 24);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "البحث عن صنف";
            // 
            // picSearch
            // 
            this.picSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSearch.ImageRotate = 0F;
            this.picSearch.Location = new System.Drawing.Point(739, 14);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(24, 25);
            this.picSearch.TabIndex = 1;
            this.picSearch.TabStop = false;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblSearchBy.Location = new System.Drawing.Point(620, 60);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchBy.Size = new System.Drawing.Size(105, 21);
            this.lblSearchBy.TabIndex = 2;
            this.lblSearchBy.Text = "البحث بواسطة :";
            // 
            // lblResearchValue
            // 
            this.lblResearchValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResearchValue.AutoSize = true;
            this.lblResearchValue.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblResearchValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblResearchValue.Location = new System.Drawing.Point(375, 60);
            this.lblResearchValue.Name = "lblResearchValue";
            this.lblResearchValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResearchValue.Size = new System.Drawing.Size(88, 21);
            this.lblResearchValue.TabIndex = 3;
            this.lblResearchValue.Text = "قيمة البحث :";
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cmbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSearch.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(516, 94);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearch.Size = new System.Drawing.Size(242, 29);
            this.cmbSearch.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtSearch.BorderRadius = 8;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtSearch.Location = new System.Drawing.Point(146, 94);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(348, 36);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnSearch.Location = new System.Drawing.Point(14, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "بحث";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BorderRadius = 8;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnClear.Location = new System.Drawing.Point(13, 50);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "مسح";
            // 
            // pnlListOfItems
            // 
            this.pnlListOfItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListOfItems.BackColor = System.Drawing.Color.Transparent;
            this.pnlListOfItems.BorderRadius = 12;
            this.pnlListOfItems.Controls.Add(this.lblListOfItems);
            this.pnlListOfItems.Controls.Add(this.picListOfItems);
            this.pnlListOfItems.Controls.Add(this.lblLabelInventoryBalances);
            this.pnlListOfItems.Controls.Add(this.lblNumberInventoryBalances);
            this.pnlListOfItems.Controls.Add(this.lblTextInventoryBalances);
            this.pnlListOfItems.Controls.Add(this.lblListOfItemsDis);
            this.pnlListOfItems.Controls.Add(this.dgvListOfItems);
            this.pnlListOfItems.FillColor = System.Drawing.Color.White;
            this.pnlListOfItems.Location = new System.Drawing.Point(523, 224);
            this.pnlListOfItems.Name = "pnlListOfItems";
            this.pnlListOfItems.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlListOfItems.ShadowDecoration.Depth = 8;
            this.pnlListOfItems.ShadowDecoration.Enabled = true;
            this.pnlListOfItems.Size = new System.Drawing.Size(773, 452);
            this.pnlListOfItems.TabIndex = 4;
            // 
            // lblListOfItems
            // 
            this.lblListOfItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListOfItems.AutoSize = true;
            this.lblListOfItems.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblListOfItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblListOfItems.Location = new System.Drawing.Point(592, 10);
            this.lblListOfItems.Name = "lblListOfItems";
            this.lblListOfItems.Size = new System.Drawing.Size(110, 24);
            this.lblListOfItems.TabIndex = 0;
            this.lblListOfItems.Text = "قائمة الاصناف";
            // 
            // picListOfItems
            // 
            this.picListOfItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picListOfItems.ImageRotate = 0F;
            this.picListOfItems.Location = new System.Drawing.Point(719, 8);
            this.picListOfItems.Name = "picListOfItems";
            this.picListOfItems.Size = new System.Drawing.Size(24, 25);
            this.picListOfItems.TabIndex = 1;
            this.picListOfItems.TabStop = false;
            // 
            // lblLabelInventoryBalances
            // 
            this.lblLabelInventoryBalances.AutoSize = true;
            this.lblLabelInventoryBalances.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblLabelInventoryBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLabelInventoryBalances.Location = new System.Drawing.Point(128, 12);
            this.lblLabelInventoryBalances.Name = "lblLabelInventoryBalances";
            this.lblLabelInventoryBalances.Size = new System.Drawing.Size(74, 18);
            this.lblLabelInventoryBalances.TabIndex = 2;
            this.lblLabelInventoryBalances.Text = "عدد الاصناف";
            // 
            // lblNumberInventoryBalances
            // 
            this.lblNumberInventoryBalances.AutoSize = true;
            this.lblNumberInventoryBalances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.lblNumberInventoryBalances.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumberInventoryBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumberInventoryBalances.Location = new System.Drawing.Point(78, 12);
            this.lblNumberInventoryBalances.Name = "lblNumberInventoryBalances";
            this.lblNumberInventoryBalances.Size = new System.Drawing.Size(36, 18);
            this.lblNumberInventoryBalances.TabIndex = 3;
            this.lblNumberInventoryBalances.Text = "0000";
            // 
            // lblTextInventoryBalances
            // 
            this.lblTextInventoryBalances.AutoSize = true;
            this.lblTextInventoryBalances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.lblTextInventoryBalances.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTextInventoryBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblTextInventoryBalances.Location = new System.Drawing.Point(25, 12);
            this.lblTextInventoryBalances.Name = "lblTextInventoryBalances";
            this.lblTextInventoryBalances.Size = new System.Drawing.Size(36, 18);
            this.lblTextInventoryBalances.TabIndex = 4;
            this.lblTextInventoryBalances.Text = "صنف";
            // 
            // lblListOfItemsDis
            // 
            this.lblListOfItemsDis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListOfItemsDis.AutoSize = true;
            this.lblListOfItemsDis.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblListOfItemsDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblListOfItemsDis.Location = new System.Drawing.Point(524, 32);
            this.lblListOfItemsDis.Name = "lblListOfItemsDis";
            this.lblListOfItemsDis.Size = new System.Drawing.Size(174, 18);
            this.lblListOfItemsDis.TabIndex = 5;
            this.lblListOfItemsDis.Text = "إدارة جميع أصناف المواد في النظام";
            // 
            // dgvListOfItems
            // 
            this.dgvListOfItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListOfItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvListOfItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvListOfItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListOfItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListOfItems.EnableHeadersVisualStyles = false;
            this.dgvListOfItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvListOfItems.Location = new System.Drawing.Point(12, 54);
            this.dgvListOfItems.Name = "dgvListOfItems";
            this.dgvListOfItems.RowHeadersWidth = 62;
            this.dgvListOfItems.Size = new System.Drawing.Size(745, 378);
            this.dgvListOfItems.TabIndex = 6;
            // 
            // frmItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlItemProcedures);
            this.Controls.Add(this.pnlItemDetails);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlListOfItems);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmItemManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة الأصناف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlItemProcedures.ResumeLayout(false);
            this.pnlItemProcedures.PerformLayout();
            this.pnlItemDetails.ResumeLayout(false);
            this.pnlItemDetails.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlListOfItems.ResumeLayout(false);
            this.pnlListOfItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListOfItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListOfItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private Guna.UI2.WinForms.Guna2Button btnBackToInventoryManagement;
        private System.Windows.Forms.Label lblFormTitle;

        private Guna.UI2.WinForms.Guna2Panel pnlItemProcedures;
        private System.Windows.Forms.Label lblItemProcedures;
        private Guna.UI2.WinForms.Guna2Button btnAddNewItem;
        private Guna.UI2.WinForms.Guna2Button btnItemAdjustment;
        private Guna.UI2.WinForms.Guna2Button btnDeleteItem;

        private Guna.UI2.WinForms.Guna2Panel pnlItemDetails;
        private System.Windows.Forms.Label lblItemDetails;
        private System.Windows.Forms.Panel pnlSep1;
        private System.Windows.Forms.Label lblItemCode;
        private System.Windows.Forms.Label lblItemCodeText;
        private System.Windows.Forms.Panel pnlSep2;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblItemNameText;
        private System.Windows.Forms.Panel pnlSep3;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryText;
        private System.Windows.Forms.Panel pnlSep4;
        private System.Windows.Forms.Label lblMinimum;
        private System.Windows.Forms.Label lblMinimumText;
        private System.Windows.Forms.Label lblEstimatedValue;
        private System.Windows.Forms.Label lblEstimatedValueText;
        private System.Windows.Forms.Panel pnlSep5;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblUnitText;

        private Guna.UI2.WinForms.Guna2Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2PictureBox picSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblResearchValue;
        private System.Windows.Forms.ComboBox cmbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;

        private Guna.UI2.WinForms.Guna2Panel pnlListOfItems;
        private System.Windows.Forms.Label lblListOfItems;
        private Guna.UI2.WinForms.Guna2PictureBox picListOfItems;
        private System.Windows.Forms.Label lblLabelInventoryBalances;
        private System.Windows.Forms.Label lblNumberInventoryBalances;
        private System.Windows.Forms.Label lblTextInventoryBalances;
        private System.Windows.Forms.Label lblListOfItemsDis;
        private System.Windows.Forms.DataGridView dgvListOfItems;
    }
}
