namespace Smart_Charity_and_Aid_Distribution_Tracker.Donations
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
            this.pnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.btnBackToDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.pnlActionsBox = new Guna.UI2.WinForms.Guna2Panel();
            this.lblActionsBox = new System.Windows.Forms.Label();
            this.btnRegisterNewDonation = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteSelected = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdjustingSelector = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonorManagement = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.picSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.lblResearchValue = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDonationsLog = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDonationsLog = new System.Windows.Forms.Label();
            this.picDonationsLog = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDonationsLogDis = new System.Windows.Forms.Label();
            this.pnlStatsBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDesignatedDonations = new System.Windows.Forms.Label();
            this.lblNumbeDesignatedDonations = new System.Windows.Forms.Label();
            this.lblTextDesignatedDonations = new System.Windows.Forms.Label();
            this.lblFinancialDonations = new System.Windows.Forms.Label();
            this.lblNumbeFinancialDonations = new System.Windows.Forms.Label();
            this.lblTextFinancialDonations = new System.Windows.Forms.Label();
            this.lblTotalDonations = new System.Windows.Forms.Label();
            this.lblNumberTotalDonations = new System.Windows.Forms.Label();
            this.lblTextTotalDonations = new System.Windows.Forms.Label();
            this.lblTotalAmounts = new System.Windows.Forms.Label();
            this.lblNumberTotalAmounts = new System.Windows.Forms.Label();
            this.lblTextTotalAmounts = new System.Windows.Forms.Label();
            this.dgvDonationsLog = new System.Windows.Forms.DataGridView();
            this.pnlTopBar.SuspendLayout();
            this.pnlActionsBox.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlDonationsLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDonationsLog)).BeginInit();
            this.pnlStatsBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationsLog)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopBar.Controls.Add(this.lblPageTitle);
            this.pnlTopBar.Controls.Add(this.btnBackToDashBoard);
            this.pnlTopBar.FillColor = System.Drawing.Color.White;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlTopBar.ShadowDecoration.Depth = 8;
            this.pnlTopBar.ShadowDecoration.Enabled = true;
            this.pnlTopBar.Size = new System.Drawing.Size(1312, 55);
            this.pnlTopBar.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(20)))));
            this.lblPageTitle.Location = new System.Drawing.Point(575, 14);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(112, 27);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "إدارة التبرعات";
            // 
            // btnBackToDashBoard
            // 
            this.btnBackToDashBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToDashBoard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnBackToDashBoard.BorderRadius = 8;
            this.btnBackToDashBoard.BorderThickness = 2;
            this.btnBackToDashBoard.FillColor = System.Drawing.Color.White;
            this.btnBackToDashBoard.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnBackToDashBoard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnBackToDashBoard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnBackToDashBoard.Location = new System.Drawing.Point(1072, 10);
            this.btnBackToDashBoard.Name = "btnBackToDashBoard";
            this.btnBackToDashBoard.Size = new System.Drawing.Size(224, 34);
            this.btnBackToDashBoard.TabIndex = 1;
            this.btnBackToDashBoard.Text = "العودة إلى لوحة التحكم";
            this.btnBackToDashBoard.Click += new System.EventHandler(this.btnBackToDashBoard_Click);
            // 
            // pnlActionsBox
            // 
            this.pnlActionsBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlActionsBox.BorderRadius = 14;
            this.pnlActionsBox.Controls.Add(this.lblActionsBox);
            this.pnlActionsBox.Controls.Add(this.btnRegisterNewDonation);
            this.pnlActionsBox.Controls.Add(this.btnDeleteSelected);
            this.pnlActionsBox.Controls.Add(this.btnAdjustingSelector);
            this.pnlActionsBox.Controls.Add(this.btnDonorManagement);
            this.pnlActionsBox.FillColor = System.Drawing.Color.White;
            this.pnlActionsBox.Location = new System.Drawing.Point(16, 64);
            this.pnlActionsBox.Name = "pnlActionsBox";
            this.pnlActionsBox.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlActionsBox.ShadowDecoration.Depth = 8;
            this.pnlActionsBox.ShadowDecoration.Enabled = true;
            this.pnlActionsBox.Size = new System.Drawing.Size(498, 146);
            this.pnlActionsBox.TabIndex = 1;
            // 
            // lblActionsBox
            // 
            this.lblActionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActionsBox.AutoSize = true;
            this.lblActionsBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblActionsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblActionsBox.Location = new System.Drawing.Point(330, 14);
            this.lblActionsBox.Name = "lblActionsBox";
            this.lblActionsBox.Size = new System.Drawing.Size(134, 24);
            this.lblActionsBox.TabIndex = 0;
            this.lblActionsBox.Text = "صندوق الإجراءات";
            // 
            // btnRegisterNewDonation
            // 
            this.btnRegisterNewDonation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegisterNewDonation.BorderRadius = 8;
            this.btnRegisterNewDonation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnRegisterNewDonation.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegisterNewDonation.ForeColor = System.Drawing.Color.White;
            this.btnRegisterNewDonation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnRegisterNewDonation.Location = new System.Drawing.Point(252, 46);
            this.btnRegisterNewDonation.Name = "btnRegisterNewDonation";
            this.btnRegisterNewDonation.Size = new System.Drawing.Size(230, 36);
            this.btnRegisterNewDonation.TabIndex = 1;
            this.btnRegisterNewDonation.Text = "تسجيل تبرع جديد";
            this.btnRegisterNewDonation.Click += new System.EventHandler(this.btnRegisterNewDonation_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelected.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteSelected.BorderRadius = 8;
            this.btnDeleteSelected.BorderThickness = 2;
            this.btnDeleteSelected.FillColor = System.Drawing.Color.White;
            this.btnDeleteSelected.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteSelected.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteSelected.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSelected.Location = new System.Drawing.Point(14, 46);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(224, 36);
            this.btnDeleteSelected.TabIndex = 2;
            this.btnDeleteSelected.Text = "حذف المحدد";
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnAdjustingSelector
            // 
            this.btnAdjustingSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdjustingSelector.BorderRadius = 8;
            this.btnAdjustingSelector.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnAdjustingSelector.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdjustingSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAdjustingSelector.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.btnAdjustingSelector.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(20)))));
            this.btnAdjustingSelector.Location = new System.Drawing.Point(14, 96);
            this.btnAdjustingSelector.Name = "btnAdjustingSelector";
            this.btnAdjustingSelector.Size = new System.Drawing.Size(224, 36);
            this.btnAdjustingSelector.TabIndex = 3;
            this.btnAdjustingSelector.Text = "تعديل المحدد";
            this.btnAdjustingSelector.Click += new System.EventHandler(this.btnAdjustingSelector_Click);
            // 
            // btnDonorManagement
            // 
            this.btnDonorManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonorManagement.BorderRadius = 8;
            this.btnDonorManagement.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDonorManagement.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnDonorManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDonorManagement.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.btnDonorManagement.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(20)))));
            this.btnDonorManagement.Location = new System.Drawing.Point(252, 96);
            this.btnDonorManagement.Name = "btnDonorManagement";
            this.btnDonorManagement.Size = new System.Drawing.Size(230, 36);
            this.btnDonorManagement.TabIndex = 4;
            this.btnDonorManagement.Text = "إدارة المتبرعين";
            this.btnDonorManagement.Click += new System.EventHandler(this.btnDonorManagement_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BorderRadius = 14;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.picSearch);
            this.pnlSearch.Controls.Add(this.lblSearchBy);
            this.pnlSearch.Controls.Add(this.cmbSearch);
            this.pnlSearch.Controls.Add(this.lblResearchValue);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.btnClear);
            this.pnlSearch.FillColor = System.Drawing.Color.White;
            this.pnlSearch.Location = new System.Drawing.Point(523, 64);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSearch.ShadowDecoration.Depth = 8;
            this.pnlSearch.ShadowDecoration.Enabled = true;
            this.pnlSearch.Size = new System.Drawing.Size(773, 146);
            this.pnlSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblSearch.Location = new System.Drawing.Point(554, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(174, 24);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "صندوق البحث و الفلترة";
            // 
            // picSearch
            // 
            this.picSearch.ImageRotate = 0F;
            this.picSearch.Location = new System.Drawing.Point(730, 14);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(24, 24);
            this.picSearch.TabIndex = 1;
            this.picSearch.TabStop = false;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearchBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblSearchBy.Location = new System.Drawing.Point(628, 56);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearchBy.Size = new System.Drawing.Size(105, 21);
            this.lblSearchBy.TabIndex = 1;
            this.lblSearchBy.Text = "البحث بواسطة :";
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cmbSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSearch.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(498, 80);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSearch.Size = new System.Drawing.Size(254, 29);
            this.cmbSearch.TabIndex = 2;
            // 
            // lblResearchValue
            // 
            this.lblResearchValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResearchValue.AutoSize = true;
            this.lblResearchValue.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblResearchValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblResearchValue.Location = new System.Drawing.Point(372, 56);
            this.lblResearchValue.Name = "lblResearchValue";
            this.lblResearchValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblResearchValue.Size = new System.Drawing.Size(88, 21);
            this.lblResearchValue.TabIndex = 3;
            this.lblResearchValue.Text = "قيمة البحث :";
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
            this.txtSearch.Location = new System.Drawing.Point(130, 80);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(352, 36);
            this.txtSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnSearch.Location = new System.Drawing.Point(14, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "بحث";
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 8;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(14, 42);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 32);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "مسح";
            // 
            // pnlDonationsLog
            // 
            this.pnlDonationsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDonationsLog.BackColor = System.Drawing.Color.Transparent;
            this.pnlDonationsLog.BorderRadius = 14;
            this.pnlDonationsLog.Controls.Add(this.lblDonationsLog);
            this.pnlDonationsLog.Controls.Add(this.picDonationsLog);
            this.pnlDonationsLog.Controls.Add(this.lblDonationsLogDis);
            this.pnlDonationsLog.Controls.Add(this.pnlStatsBar);
            this.pnlDonationsLog.Controls.Add(this.dgvDonationsLog);
            this.pnlDonationsLog.FillColor = System.Drawing.Color.White;
            this.pnlDonationsLog.Location = new System.Drawing.Point(16, 224);
            this.pnlDonationsLog.Name = "pnlDonationsLog";
            this.pnlDonationsLog.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlDonationsLog.ShadowDecoration.Depth = 8;
            this.pnlDonationsLog.ShadowDecoration.Enabled = true;
            this.pnlDonationsLog.Size = new System.Drawing.Size(1279, 452);
            this.pnlDonationsLog.TabIndex = 3;
            // 
            // lblDonationsLog
            // 
            this.lblDonationsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDonationsLog.AutoSize = true;
            this.lblDonationsLog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDonationsLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblDonationsLog.Location = new System.Drawing.Point(1125, 8);
            this.lblDonationsLog.Name = "lblDonationsLog";
            this.lblDonationsLog.Size = new System.Drawing.Size(110, 24);
            this.lblDonationsLog.TabIndex = 0;
            this.lblDonationsLog.Text = "سجل التبرعات";
            // 
            // picDonationsLog
            // 
            this.picDonationsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDonationsLog.ImageRotate = 0F;
            this.picDonationsLog.Location = new System.Drawing.Point(1244, 9);
            this.picDonationsLog.Name = "picDonationsLog";
            this.picDonationsLog.Size = new System.Drawing.Size(24, 24);
            this.picDonationsLog.TabIndex = 1;
            this.picDonationsLog.TabStop = false;
            // 
            // lblDonationsLogDis
            // 
            this.lblDonationsLogDis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDonationsLogDis.AutoSize = true;
            this.lblDonationsLogDis.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDonationsLogDis.ForeColor = System.Drawing.Color.DimGray;
            this.lblDonationsLogDis.Location = new System.Drawing.Point(978, 32);
            this.lblDonationsLogDis.Name = "lblDonationsLogDis";
            this.lblDonationsLogDis.Size = new System.Drawing.Size(240, 18);
            this.lblDonationsLogDis.TabIndex = 1;
            this.lblDonationsLogDis.Text = "جدول يعرض جميع التبرعات المسجلة في النظام";
            // 
            // pnlStatsBar
            // 
            this.pnlStatsBar.BorderRadius = 8;
            this.pnlStatsBar.Controls.Add(this.lblDesignatedDonations);
            this.pnlStatsBar.Controls.Add(this.lblNumbeDesignatedDonations);
            this.pnlStatsBar.Controls.Add(this.lblTextDesignatedDonations);
            this.pnlStatsBar.Controls.Add(this.lblFinancialDonations);
            this.pnlStatsBar.Controls.Add(this.lblNumbeFinancialDonations);
            this.pnlStatsBar.Controls.Add(this.lblTextFinancialDonations);
            this.pnlStatsBar.Controls.Add(this.lblTotalDonations);
            this.pnlStatsBar.Controls.Add(this.lblNumberTotalDonations);
            this.pnlStatsBar.Controls.Add(this.lblTextTotalDonations);
            this.pnlStatsBar.Controls.Add(this.lblTotalAmounts);
            this.pnlStatsBar.Controls.Add(this.lblNumberTotalAmounts);
            this.pnlStatsBar.Controls.Add(this.lblTextTotalAmounts);
            this.pnlStatsBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.pnlStatsBar.Location = new System.Drawing.Point(12, 32);
            this.pnlStatsBar.Name = "pnlStatsBar";
            this.pnlStatsBar.Size = new System.Drawing.Size(366, 50);
            this.pnlStatsBar.TabIndex = 2;
            // 
            // lblDesignatedDonations
            // 
            this.lblDesignatedDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesignatedDonations.AutoSize = true;
            this.lblDesignatedDonations.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDesignatedDonations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDesignatedDonations.Location = new System.Drawing.Point(104, 5);
            this.lblDesignatedDonations.Name = "lblDesignatedDonations";
            this.lblDesignatedDonations.Size = new System.Drawing.Size(72, 18);
            this.lblDesignatedDonations.TabIndex = 0;
            this.lblDesignatedDonations.Text = "تبرعات عينية";
            // 
            // lblNumbeDesignatedDonations
            // 
            this.lblNumbeDesignatedDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumbeDesignatedDonations.AutoSize = true;
            this.lblNumbeDesignatedDonations.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumbeDesignatedDonations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumbeDesignatedDonations.Location = new System.Drawing.Point(60, 5);
            this.lblNumbeDesignatedDonations.Name = "lblNumbeDesignatedDonations";
            this.lblNumbeDesignatedDonations.Size = new System.Drawing.Size(36, 18);
            this.lblNumbeDesignatedDonations.TabIndex = 1;
            this.lblNumbeDesignatedDonations.Text = "0000";
            // 
            // lblTextDesignatedDonations
            // 
            this.lblTextDesignatedDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextDesignatedDonations.AutoSize = true;
            this.lblTextDesignatedDonations.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTextDesignatedDonations.ForeColor = System.Drawing.Color.DimGray;
            this.lblTextDesignatedDonations.Location = new System.Drawing.Point(14, 5);
            this.lblTextDesignatedDonations.Name = "lblTextDesignatedDonations";
            this.lblTextDesignatedDonations.Size = new System.Drawing.Size(28, 18);
            this.lblTextDesignatedDonations.TabIndex = 2;
            this.lblTextDesignatedDonations.Text = "تبرع";
            // 
            // lblFinancialDonations
            // 
            this.lblFinancialDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinancialDonations.AutoSize = true;
            this.lblFinancialDonations.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblFinancialDonations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblFinancialDonations.Location = new System.Drawing.Point(260, 5);
            this.lblFinancialDonations.Name = "lblFinancialDonations";
            this.lblFinancialDonations.Size = new System.Drawing.Size(70, 18);
            this.lblFinancialDonations.TabIndex = 3;
            this.lblFinancialDonations.Text = "تبرعات مالية";
            // 
            // lblNumbeFinancialDonations
            // 
            this.lblNumbeFinancialDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumbeFinancialDonations.AutoSize = true;
            this.lblNumbeFinancialDonations.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumbeFinancialDonations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumbeFinancialDonations.Location = new System.Drawing.Point(216, 5);
            this.lblNumbeFinancialDonations.Name = "lblNumbeFinancialDonations";
            this.lblNumbeFinancialDonations.Size = new System.Drawing.Size(36, 18);
            this.lblNumbeFinancialDonations.TabIndex = 4;
            this.lblNumbeFinancialDonations.Text = "0000";
            // 
            // lblTextFinancialDonations
            // 
            this.lblTextFinancialDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextFinancialDonations.AutoSize = true;
            this.lblTextFinancialDonations.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTextFinancialDonations.ForeColor = System.Drawing.Color.DimGray;
            this.lblTextFinancialDonations.Location = new System.Drawing.Point(185, 5);
            this.lblTextFinancialDonations.Name = "lblTextFinancialDonations";
            this.lblTextFinancialDonations.Size = new System.Drawing.Size(28, 18);
            this.lblTextFinancialDonations.TabIndex = 5;
            this.lblTextFinancialDonations.Text = "تبرع";
            // 
            // lblTotalDonations
            // 
            this.lblTotalDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalDonations.AutoSize = true;
            this.lblTotalDonations.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTotalDonations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTotalDonations.Location = new System.Drawing.Point(260, 22);
            this.lblTotalDonations.Name = "lblTotalDonations";
            this.lblTotalDonations.Size = new System.Drawing.Size(85, 18);
            this.lblTotalDonations.TabIndex = 6;
            this.lblTotalDonations.Text = "إجمالي التبرعات";
            // 
            // lblNumberTotalDonations
            // 
            this.lblNumberTotalDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberTotalDonations.AutoSize = true;
            this.lblNumberTotalDonations.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumberTotalDonations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumberTotalDonations.Location = new System.Drawing.Point(215, 25);
            this.lblNumberTotalDonations.Name = "lblNumberTotalDonations";
            this.lblNumberTotalDonations.Size = new System.Drawing.Size(36, 18);
            this.lblNumberTotalDonations.TabIndex = 7;
            this.lblNumberTotalDonations.Text = "0000";
            // 
            // lblTextTotalDonations
            // 
            this.lblTextTotalDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextTotalDonations.AutoSize = true;
            this.lblTextTotalDonations.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTextTotalDonations.ForeColor = System.Drawing.Color.DimGray;
            this.lblTextTotalDonations.Location = new System.Drawing.Point(185, 24);
            this.lblTextTotalDonations.Name = "lblTextTotalDonations";
            this.lblTextTotalDonations.Size = new System.Drawing.Size(28, 18);
            this.lblTextTotalDonations.TabIndex = 8;
            this.lblTextTotalDonations.Text = "تبرع";
            // 
            // lblTotalAmounts
            // 
            this.lblTotalAmounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalAmounts.AutoSize = true;
            this.lblTotalAmounts.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTotalAmounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTotalAmounts.Location = new System.Drawing.Point(104, 22);
            this.lblTotalAmounts.Name = "lblTotalAmounts";
            this.lblTotalAmounts.Size = new System.Drawing.Size(76, 18);
            this.lblTotalAmounts.TabIndex = 9;
            this.lblTotalAmounts.Text = "إجمالي المبالغ";
            // 
            // lblNumberTotalAmounts
            // 
            this.lblNumberTotalAmounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumberTotalAmounts.AutoSize = true;
            this.lblNumberTotalAmounts.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumberTotalAmounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumberTotalAmounts.Location = new System.Drawing.Point(60, 21);
            this.lblNumberTotalAmounts.Name = "lblNumberTotalAmounts";
            this.lblNumberTotalAmounts.Size = new System.Drawing.Size(36, 18);
            this.lblNumberTotalAmounts.TabIndex = 10;
            this.lblNumberTotalAmounts.Text = "0000";
            // 
            // lblTextTotalAmounts
            // 
            this.lblTextTotalAmounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTextTotalAmounts.AutoSize = true;
            this.lblTextTotalAmounts.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTextTotalAmounts.ForeColor = System.Drawing.Color.DimGray;
            this.lblTextTotalAmounts.Location = new System.Drawing.Point(13, 20);
            this.lblTextTotalAmounts.Name = "lblTextTotalAmounts";
            this.lblTextTotalAmounts.Size = new System.Drawing.Size(32, 18);
            this.lblTextTotalAmounts.TabIndex = 11;
            this.lblTextTotalAmounts.Text = "دينار";
            // 
            // dgvDonationsLog
            // 
            this.dgvDonationsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDonationsLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvDonationsLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDonationsLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonationsLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvDonationsLog.Location = new System.Drawing.Point(12, 92);
            this.dgvDonationsLog.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDonationsLog.Name = "dgvDonationsLog";
            this.dgvDonationsLog.RowHeadersWidth = 50;
            this.dgvDonationsLog.Size = new System.Drawing.Size(1252, 348);
            this.dgvDonationsLog.TabIndex = 3;
            // 
            // frmDonations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlActionsBox);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlDonationsLog);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDonations";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التبرعات";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDonations_FormClosed);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlActionsBox.ResumeLayout(false);
            this.pnlActionsBox.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlDonationsLog.ResumeLayout(false);
            this.pnlDonationsLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDonationsLog)).EndInit();
            this.pnlStatsBar.ResumeLayout(false);
            this.pnlStatsBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationsLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private Guna.UI2.WinForms.Guna2Button btnBackToDashBoard;
        private Guna.UI2.WinForms.Guna2Panel pnlActionsBox;
        private System.Windows.Forms.Label lblActionsBox;
        private Guna.UI2.WinForms.Guna2Button btnRegisterNewDonation;
        private Guna.UI2.WinForms.Guna2Button btnDeleteSelected;
        private Guna.UI2.WinForms.Guna2Button btnAdjustingSelector;
        private Guna.UI2.WinForms.Guna2Button btnDonorManagement;
        private Guna.UI2.WinForms.Guna2Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2PictureBox picSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label lblResearchValue;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Panel pnlDonationsLog;
        private System.Windows.Forms.Label lblDonationsLog;
        private Guna.UI2.WinForms.Guna2PictureBox picDonationsLog;
        private System.Windows.Forms.Label lblDonationsLogDis;
        private Guna.UI2.WinForms.Guna2Panel pnlStatsBar;
        private System.Windows.Forms.Label lblDesignatedDonations;
        private System.Windows.Forms.Label lblNumbeDesignatedDonations;
        private System.Windows.Forms.Label lblTextDesignatedDonations;
        private System.Windows.Forms.Label lblFinancialDonations;
        private System.Windows.Forms.Label lblNumbeFinancialDonations;
        private System.Windows.Forms.Label lblTextFinancialDonations;
        private System.Windows.Forms.Label lblTotalDonations;
        private System.Windows.Forms.Label lblNumberTotalDonations;
        private System.Windows.Forms.Label lblTextTotalDonations;
        private System.Windows.Forms.Label lblTotalAmounts;
        private System.Windows.Forms.Label lblNumberTotalAmounts;
        private System.Windows.Forms.Label lblTextTotalAmounts;
        private System.Windows.Forms.DataGridView dgvDonationsLog;
    }
}
