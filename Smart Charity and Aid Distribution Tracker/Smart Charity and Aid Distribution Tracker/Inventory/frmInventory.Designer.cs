namespace Smart_Charity_and_Aid_Distribution_Tracker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBackToDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlInventoryProcedures = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInventoryProcedures = new System.Windows.Forms.Label();
            this.btnAddNewBalance = new Guna.UI2.WinForms.Guna2Button();
            this.btnViewMotionLog = new Guna.UI2.WinForms.Guna2Button();
            this.btnQuantityAdjustment = new Guna.UI2.WinForms.Guna2Button();
            this.btnItemManagement = new Guna.UI2.WinForms.Guna2Button();
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
            this.pnlSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.picSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.lblResearchValue = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.pnlInventoryBalances = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInventoryBalances = new System.Windows.Forms.Label();
            this.picInventoryBalances = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblTextTotalValue = new System.Windows.Forms.Label();
            this.lblNumberTotalValue = new System.Windows.Forms.Label();
            this.lblLabelInventoryBalances = new System.Windows.Forms.Label();
            this.lblNumberInventoryBalances = new System.Windows.Forms.Label();
            this.lblTextInventoryBalances = new System.Windows.Forms.Label();
            this.dgvInventoryBalances = new System.Windows.Forms.DataGridView();
            this.pnlTopBar.SuspendLayout();
            this.pnlInventoryProcedures.SuspendLayout();
            this.pnlItemDetails.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlInventoryBalances.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryBalances)).BeginInit();
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
            this.lblFormTitle.Size = new System.Drawing.Size(124, 29);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "إدارة المخزون";
            // 
            // pnlInventoryProcedures
            // 
            this.pnlInventoryProcedures.BackColor = System.Drawing.Color.Transparent;
            this.pnlInventoryProcedures.BorderRadius = 12;
            this.pnlInventoryProcedures.Controls.Add(this.lblInventoryProcedures);
            this.pnlInventoryProcedures.Controls.Add(this.btnAddNewBalance);
            this.pnlInventoryProcedures.Controls.Add(this.btnViewMotionLog);
            this.pnlInventoryProcedures.Controls.Add(this.btnQuantityAdjustment);
            this.pnlInventoryProcedures.Controls.Add(this.btnItemManagement);
            this.pnlInventoryProcedures.FillColor = System.Drawing.Color.White;
            this.pnlInventoryProcedures.Location = new System.Drawing.Point(16, 62);
            this.pnlInventoryProcedures.Name = "pnlInventoryProcedures";
            this.pnlInventoryProcedures.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlInventoryProcedures.ShadowDecoration.Depth = 8;
            this.pnlInventoryProcedures.ShadowDecoration.Enabled = true;
            this.pnlInventoryProcedures.Size = new System.Drawing.Size(498, 146);
            this.pnlInventoryProcedures.TabIndex = 1;
            // 
            // lblInventoryProcedures
            // 
            this.lblInventoryProcedures.AutoSize = true;
            this.lblInventoryProcedures.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblInventoryProcedures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblInventoryProcedures.Location = new System.Drawing.Point(341, 14);
            this.lblInventoryProcedures.Name = "lblInventoryProcedures";
            this.lblInventoryProcedures.Size = new System.Drawing.Size(128, 24);
            this.lblInventoryProcedures.TabIndex = 0;
            this.lblInventoryProcedures.Text = "اجراءات المخزون";
            // 
            // btnAddNewBalance
            // 
            this.btnAddNewBalance.BorderRadius = 10;
            this.btnAddNewBalance.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnAddNewBalance.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddNewBalance.ForeColor = System.Drawing.Color.White;
            this.btnAddNewBalance.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnAddNewBalance.Location = new System.Drawing.Point(249, 50);
            this.btnAddNewBalance.Name = "btnAddNewBalance";
            this.btnAddNewBalance.Size = new System.Drawing.Size(231, 39);
            this.btnAddNewBalance.TabIndex = 1;
            this.btnAddNewBalance.Text = "إضافة رصيد جديد";
            this.btnAddNewBalance.Click += new System.EventHandler(this.btnAddNewBalance_Click);
            // 
            // btnViewMotionLog
            // 
            this.btnViewMotionLog.BorderRadius = 10;
            this.btnViewMotionLog.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnViewMotionLog.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnViewMotionLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnViewMotionLog.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnViewMotionLog.Location = new System.Drawing.Point(18, 50);
            this.btnViewMotionLog.Name = "btnViewMotionLog";
            this.btnViewMotionLog.Size = new System.Drawing.Size(224, 39);
            this.btnViewMotionLog.TabIndex = 2;
            this.btnViewMotionLog.Text = "عرض سجل الحركة";
            this.btnViewMotionLog.Click += new System.EventHandler(this.btnViewMotionLog_Click);
            // 
            // btnQuantityAdjustment
            // 
            this.btnQuantityAdjustment.BorderRadius = 10;
            this.btnQuantityAdjustment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnQuantityAdjustment.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnQuantityAdjustment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnQuantityAdjustment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnQuantityAdjustment.Location = new System.Drawing.Point(249, 98);
            this.btnQuantityAdjustment.Name = "btnQuantityAdjustment";
            this.btnQuantityAdjustment.Size = new System.Drawing.Size(231, 39);
            this.btnQuantityAdjustment.TabIndex = 3;
            this.btnQuantityAdjustment.Text = "تعديل الكمية";
            this.btnQuantityAdjustment.Click += new System.EventHandler(this.btnQuantityAdjustment_Click);
            // 
            // btnItemManagement
            // 
            this.btnItemManagement.BorderRadius = 10;
            this.btnItemManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnItemManagement.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnItemManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnItemManagement.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnItemManagement.Location = new System.Drawing.Point(18, 98);
            this.btnItemManagement.Name = "btnItemManagement";
            this.btnItemManagement.Size = new System.Drawing.Size(224, 39);
            this.btnItemManagement.TabIndex = 4;
            this.btnItemManagement.Text = "إدارة الأصناف";
            this.btnItemManagement.Click += new System.EventHandler(this.btnItemManagement_Click);
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
            this.lblItemDetails.Location = new System.Drawing.Point(348, 14);
            this.lblItemDetails.Name = "lblItemDetails";
            this.lblItemDetails.Size = new System.Drawing.Size(117, 24);
            this.lblItemDetails.TabIndex = 0;
            this.lblItemDetails.Text = "تفاصيل الصنف";
            // 
            // pnlSep1
            // 
            this.pnlSep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep1.Location = new System.Drawing.Point(4, 126);
            this.pnlSep1.Name = "pnlSep1";
            this.pnlSep1.Size = new System.Drawing.Size(488, 1);
            this.pnlSep1.TabIndex = 1;
            // 
            // lblItemCode
            // 
            this.lblItemCode.AutoSize = true;
            this.lblItemCode.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblItemCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblItemCode.Location = new System.Drawing.Point(380, 69);
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
            this.lblItemCodeText.Location = new System.Drawing.Point(362, 91);
            this.lblItemCodeText.Name = "lblItemCodeText";
            this.lblItemCodeText.Size = new System.Drawing.Size(96, 23);
            this.lblItemCodeText.TabIndex = 3;
            this.lblItemCodeText.Text = "0000-0000";
            this.lblItemCodeText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlSep2
            // 
            this.pnlSep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep2.Location = new System.Drawing.Point(4, 199);
            this.pnlSep2.Name = "pnlSep2";
            this.pnlSep2.Size = new System.Drawing.Size(488, 1);
            this.pnlSep2.TabIndex = 4;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblItemName.Location = new System.Drawing.Point(376, 148);
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
            this.lblItemNameText.Location = new System.Drawing.Point(315, 170);
            this.lblItemNameText.Name = "lblItemNameText";
            this.lblItemNameText.Size = new System.Drawing.Size(130, 23);
            this.lblItemNameText.TabIndex = 6;
            this.lblItemNameText.Text = "XXXXXXXXXXXX";
            this.lblItemNameText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlSep3
            // 
            this.pnlSep3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep3.Location = new System.Drawing.Point(4, 265);
            this.pnlSep3.Name = "pnlSep3";
            this.pnlSep3.Size = new System.Drawing.Size(488, 1);
            this.pnlSep3.TabIndex = 7;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblCategory.Location = new System.Drawing.Point(423, 215);
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
            this.lblCategoryText.Location = new System.Drawing.Point(304, 238);
            this.lblCategoryText.Name = "lblCategoryText";
            this.lblCategoryText.Size = new System.Drawing.Size(140, 23);
            this.lblCategoryText.TabIndex = 9;
            this.lblCategoryText.Text = "XXXXXXXXXXXXX";
            this.lblCategoryText.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlSep4
            // 
            this.pnlSep4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep4.Location = new System.Drawing.Point(4, 338);
            this.pnlSep4.Name = "pnlSep4";
            this.pnlSep4.Size = new System.Drawing.Size(488, 1);
            this.pnlSep4.TabIndex = 10;
            // 
            // lblMinimum
            // 
            this.lblMinimum.AutoSize = true;
            this.lblMinimum.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblMinimum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblMinimum.Location = new System.Drawing.Point(384, 282);
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
            this.lblMinimumText.Location = new System.Drawing.Point(304, 304);
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
            this.lblEstimatedValue.Location = new System.Drawing.Point(352, 354);
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
            this.lblEstimatedValueText.Location = new System.Drawing.Point(326, 375);
            this.lblEstimatedValueText.Name = "lblEstimatedValueText";
            this.lblEstimatedValueText.Size = new System.Drawing.Size(120, 23);
            this.lblEstimatedValueText.TabIndex = 14;
            this.lblEstimatedValueText.Text = "XXXXXXXXXXX";
            this.lblEstimatedValueText.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // pnlInventoryBalances
            // 
            this.pnlInventoryBalances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInventoryBalances.BackColor = System.Drawing.Color.Transparent;
            this.pnlInventoryBalances.BorderRadius = 12;
            this.pnlInventoryBalances.Controls.Add(this.lblInventoryBalances);
            this.pnlInventoryBalances.Controls.Add(this.picInventoryBalances);
            this.pnlInventoryBalances.Controls.Add(this.lblTotalValue);
            this.pnlInventoryBalances.Controls.Add(this.lblTextTotalValue);
            this.pnlInventoryBalances.Controls.Add(this.lblNumberTotalValue);
            this.pnlInventoryBalances.Controls.Add(this.lblLabelInventoryBalances);
            this.pnlInventoryBalances.Controls.Add(this.lblNumberInventoryBalances);
            this.pnlInventoryBalances.Controls.Add(this.lblTextInventoryBalances);
            this.pnlInventoryBalances.Controls.Add(this.dgvInventoryBalances);
            this.pnlInventoryBalances.FillColor = System.Drawing.Color.White;
            this.pnlInventoryBalances.Location = new System.Drawing.Point(523, 224);
            this.pnlInventoryBalances.Name = "pnlInventoryBalances";
            this.pnlInventoryBalances.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlInventoryBalances.ShadowDecoration.Depth = 8;
            this.pnlInventoryBalances.ShadowDecoration.Enabled = true;
            this.pnlInventoryBalances.Size = new System.Drawing.Size(773, 452);
            this.pnlInventoryBalances.TabIndex = 4;
            // 
            // lblInventoryBalances
            // 
            this.lblInventoryBalances.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInventoryBalances.AutoSize = true;
            this.lblInventoryBalances.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblInventoryBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblInventoryBalances.Location = new System.Drawing.Point(616, 15);
            this.lblInventoryBalances.Name = "lblInventoryBalances";
            this.lblInventoryBalances.Size = new System.Drawing.Size(116, 24);
            this.lblInventoryBalances.TabIndex = 0;
            this.lblInventoryBalances.Text = "أرصدة المخزون";
            // 
            // picInventoryBalances
            // 
            this.picInventoryBalances.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picInventoryBalances.ImageRotate = 0F;
            this.picInventoryBalances.Location = new System.Drawing.Point(740, 14);
            this.picInventoryBalances.Name = "picInventoryBalances";
            this.picInventoryBalances.Size = new System.Drawing.Size(24, 25);
            this.picInventoryBalances.TabIndex = 1;
            this.picInventoryBalances.TabStop = false;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTotalValue.Location = new System.Drawing.Point(125, 11);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(85, 18);
            this.lblTotalValue.TabIndex = 2;
            this.lblTotalValue.Text = "القيمة الإجمالية";
            // 
            // lblTextTotalValue
            // 
            this.lblTextTotalValue.AutoSize = true;
            this.lblTextTotalValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.lblTextTotalValue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblTextTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblTextTotalValue.Location = new System.Drawing.Point(34, 11);
            this.lblTextTotalValue.Name = "lblTextTotalValue";
            this.lblTextTotalValue.Size = new System.Drawing.Size(27, 18);
            this.lblTextTotalValue.TabIndex = 3;
            this.lblTextTotalValue.Text = "د.ل";
            // 
            // lblNumberTotalValue
            // 
            this.lblNumberTotalValue.AutoSize = true;
            this.lblNumberTotalValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.lblNumberTotalValue.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumberTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumberTotalValue.Location = new System.Drawing.Point(76, 11);
            this.lblNumberTotalValue.Name = "lblNumberTotalValue";
            this.lblNumberTotalValue.Size = new System.Drawing.Size(36, 18);
            this.lblNumberTotalValue.TabIndex = 4;
            this.lblNumberTotalValue.Text = "0000";
            // 
            // lblLabelInventoryBalances
            // 
            this.lblLabelInventoryBalances.AutoSize = true;
            this.lblLabelInventoryBalances.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblLabelInventoryBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblLabelInventoryBalances.Location = new System.Drawing.Point(133, 46);
            this.lblLabelInventoryBalances.Name = "lblLabelInventoryBalances";
            this.lblLabelInventoryBalances.Size = new System.Drawing.Size(74, 18);
            this.lblLabelInventoryBalances.TabIndex = 5;
            this.lblLabelInventoryBalances.Text = "عدد الاصناف";
            // 
            // lblNumberInventoryBalances
            // 
            this.lblNumberInventoryBalances.AutoSize = true;
            this.lblNumberInventoryBalances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.lblNumberInventoryBalances.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumberInventoryBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumberInventoryBalances.Location = new System.Drawing.Point(84, 46);
            this.lblNumberInventoryBalances.Name = "lblNumberInventoryBalances";
            this.lblNumberInventoryBalances.Size = new System.Drawing.Size(36, 18);
            this.lblNumberInventoryBalances.TabIndex = 6;
            this.lblNumberInventoryBalances.Text = "0000";
            // 
            // lblTextInventoryBalances
            // 
            this.lblTextInventoryBalances.AutoSize = true;
            this.lblTextInventoryBalances.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.lblTextInventoryBalances.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblTextInventoryBalances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblTextInventoryBalances.Location = new System.Drawing.Point(30, 46);
            this.lblTextInventoryBalances.Name = "lblTextInventoryBalances";
            this.lblTextInventoryBalances.Size = new System.Drawing.Size(39, 18);
            this.lblTextInventoryBalances.TabIndex = 7;
            this.lblTextInventoryBalances.Text = "صنف";
            // 
            // dgvInventoryBalances
            // 
            this.dgvInventoryBalances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventoryBalances.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventoryBalances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvInventoryBalances.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventoryBalances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryBalances.EnableHeadersVisualStyles = false;
            this.dgvInventoryBalances.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvInventoryBalances.Location = new System.Drawing.Point(12, 82);
            this.dgvInventoryBalances.Name = "dgvInventoryBalances";
            this.dgvInventoryBalances.RowHeadersWidth = 62;
            this.dgvInventoryBalances.Size = new System.Drawing.Size(745, 350);
            this.dgvInventoryBalances.TabIndex = 8;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlInventoryProcedures);
            this.Controls.Add(this.pnlItemDetails);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlInventoryBalances);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInventory";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المخزون";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlInventoryProcedures.ResumeLayout(false);
            this.pnlInventoryProcedures.PerformLayout();
            this.pnlItemDetails.ResumeLayout(false);
            this.pnlItemDetails.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlInventoryBalances.ResumeLayout(false);
            this.pnlInventoryBalances.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInventoryBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryBalances)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private Guna.UI2.WinForms.Guna2Button btnBackToDashBoard;
        private System.Windows.Forms.Label lblFormTitle;

        private Guna.UI2.WinForms.Guna2Panel pnlInventoryProcedures;
        private System.Windows.Forms.Label lblInventoryProcedures;
        private Guna.UI2.WinForms.Guna2Button btnAddNewBalance;
        private Guna.UI2.WinForms.Guna2Button btnViewMotionLog;
        private Guna.UI2.WinForms.Guna2Button btnQuantityAdjustment;
        private Guna.UI2.WinForms.Guna2Button btnItemManagement;

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

        private Guna.UI2.WinForms.Guna2Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2PictureBox picSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.Label lblResearchValue;
        private System.Windows.Forms.ComboBox cmbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;

        private Guna.UI2.WinForms.Guna2Panel pnlInventoryBalances;
        private System.Windows.Forms.Label lblInventoryBalances;
        private Guna.UI2.WinForms.Guna2PictureBox picInventoryBalances;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.Label lblTextTotalValue;
        private System.Windows.Forms.Label lblNumberTotalValue;
        private System.Windows.Forms.Label lblLabelInventoryBalances;
        private System.Windows.Forms.Label lblNumberInventoryBalances;
        private System.Windows.Forms.Label lblTextInventoryBalances;
        private System.Windows.Forms.DataGridView dgvInventoryBalances;
    }
}
