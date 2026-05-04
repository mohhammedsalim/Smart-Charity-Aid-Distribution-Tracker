namespace Smart_Charity_and_Aid_Distribution_Tracker.Donations.DonorManagement
{
    partial class frmDonorManagement
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
            this.btnBackToDonationsManagement = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDonorProcedures = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDonorProcedures = new System.Windows.Forms.Label();
            this.btnAddNewDonor = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonorAdjustment = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteDonor = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.picSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.lblResearchValue = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.pnlListDonors = new Guna.UI2.WinForms.Guna2Panel();
            this.lblListDonors = new System.Windows.Forms.Label();
            this.picListDonors = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblListDonorsDis = new System.Windows.Forms.Label();
            this.pnlStatsBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblLabelNumberDonors = new System.Windows.Forms.Label();
            this.lblNumberNumberDonors = new System.Windows.Forms.Label();
            this.lblTextNumberDonors = new System.Windows.Forms.Label();
            this.dgvListDonors = new System.Windows.Forms.DataGridView();
            this.pnlTopBar.SuspendLayout();
            this.pnlDonorProcedures.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlListDonors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListDonors)).BeginInit();
            this.pnlStatsBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDonors)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopBar.Controls.Add(this.lblPageTitle);
            this.pnlTopBar.Controls.Add(this.btnBackToDonationsManagement);
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
            this.lblPageTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(20)))));
            this.lblPageTitle.Location = new System.Drawing.Point(565, 14);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(117, 27);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "إدارة المتبرعين";
            // 
            // btnBackToDonationsManagement
            // 
            this.btnBackToDonationsManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToDonationsManagement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnBackToDonationsManagement.BorderRadius = 8;
            this.btnBackToDonationsManagement.BorderThickness = 2;
            this.btnBackToDonationsManagement.FillColor = System.Drawing.Color.White;
            this.btnBackToDonationsManagement.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnBackToDonationsManagement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnBackToDonationsManagement.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnBackToDonationsManagement.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnBackToDonationsManagement.Location = new System.Drawing.Point(1072, 10);
            this.btnBackToDonationsManagement.Name = "btnBackToDonationsManagement";
            this.btnBackToDonationsManagement.Size = new System.Drawing.Size(224, 34);
            this.btnBackToDonationsManagement.TabIndex = 1;
            this.btnBackToDonationsManagement.Text = "العودة إلى إدارة التبرعات";
            this.btnBackToDonationsManagement.Click += new System.EventHandler(this.btnBackToDonationsManagement_Click);
            // 
            // pnlDonorProcedures
            // 
            this.pnlDonorProcedures.BackColor = System.Drawing.Color.Transparent;
            this.pnlDonorProcedures.BorderRadius = 14;
            this.pnlDonorProcedures.Controls.Add(this.lblDonorProcedures);
            this.pnlDonorProcedures.Controls.Add(this.btnAddNewDonor);
            this.pnlDonorProcedures.Controls.Add(this.btnDonorAdjustment);
            this.pnlDonorProcedures.Controls.Add(this.btnDeleteDonor);
            this.pnlDonorProcedures.FillColor = System.Drawing.Color.White;
            this.pnlDonorProcedures.Location = new System.Drawing.Point(16, 64);
            this.pnlDonorProcedures.Name = "pnlDonorProcedures";
            this.pnlDonorProcedures.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlDonorProcedures.ShadowDecoration.Depth = 8;
            this.pnlDonorProcedures.ShadowDecoration.Enabled = true;
            this.pnlDonorProcedures.Size = new System.Drawing.Size(498, 146);
            this.pnlDonorProcedures.TabIndex = 1;
            // 
            // lblDonorProcedures
            // 
            this.lblDonorProcedures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDonorProcedures.AutoSize = true;
            this.lblDonorProcedures.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDonorProcedures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblDonorProcedures.Location = new System.Drawing.Point(334, 14);
            this.lblDonorProcedures.Name = "lblDonorProcedures";
            this.lblDonorProcedures.Size = new System.Drawing.Size(131, 24);
            this.lblDonorProcedures.TabIndex = 0;
            this.lblDonorProcedures.Text = "اجراءات المتبرعين";
            // 
            // btnAddNewDonor
            // 
            this.btnAddNewDonor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewDonor.BorderRadius = 8;
            this.btnAddNewDonor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnAddNewDonor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddNewDonor.ForeColor = System.Drawing.Color.White;
            this.btnAddNewDonor.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnAddNewDonor.Location = new System.Drawing.Point(14, 46);
            this.btnAddNewDonor.Name = "btnAddNewDonor";
            this.btnAddNewDonor.Size = new System.Drawing.Size(468, 36);
            this.btnAddNewDonor.TabIndex = 1;
            this.btnAddNewDonor.Text = "إضافة متبرع جديد";
            this.btnAddNewDonor.Click += new System.EventHandler(this.btnAddNewDonor_Click);
            // 
            // btnDonorAdjustment
            // 
            this.btnDonorAdjustment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonorAdjustment.BorderRadius = 8;
            this.btnDonorAdjustment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDonorAdjustment.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnDonorAdjustment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDonorAdjustment.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.btnDonorAdjustment.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(20)))));
            this.btnDonorAdjustment.Location = new System.Drawing.Point(244, 96);
            this.btnDonorAdjustment.Name = "btnDonorAdjustment";
            this.btnDonorAdjustment.Size = new System.Drawing.Size(238, 36);
            this.btnDonorAdjustment.TabIndex = 2;
            this.btnDonorAdjustment.Text = "تعديل المتبرع";
            this.btnDonorAdjustment.Click += new System.EventHandler(this.btnDonorAdjustment_Click);
            // 
            // btnDeleteDonor
            // 
            this.btnDeleteDonor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteDonor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteDonor.BorderRadius = 8;
            this.btnDeleteDonor.BorderThickness = 2;
            this.btnDeleteDonor.FillColor = System.Drawing.Color.White;
            this.btnDeleteDonor.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteDonor.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDeleteDonor.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDonor.Location = new System.Drawing.Point(14, 96);
            this.btnDeleteDonor.Name = "btnDeleteDonor";
            this.btnDeleteDonor.Size = new System.Drawing.Size(210, 36);
            this.btnDeleteDonor.TabIndex = 3;
            this.btnDeleteDonor.Text = "حذف المتبرع";
            this.btnDeleteDonor.Click += new System.EventHandler(this.btnDeleteDonor_Click);
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
            this.lblSearch.Location = new System.Drawing.Point(596, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(124, 24);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "البحث عن متبرع";
            // 
            // picSearch
            // 
            this.picSearch.ImageRotate = 0F;
            this.picSearch.Location = new System.Drawing.Point(736, 14);
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
            this.lblSearchBy.Location = new System.Drawing.Point(651, 55);
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
            this.lblResearchValue.Location = new System.Drawing.Point(387, 55);
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
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            // pnlListDonors
            // 
            this.pnlListDonors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListDonors.BackColor = System.Drawing.Color.Transparent;
            this.pnlListDonors.BorderRadius = 14;
            this.pnlListDonors.Controls.Add(this.lblListDonors);
            this.pnlListDonors.Controls.Add(this.picListDonors);
            this.pnlListDonors.Controls.Add(this.lblListDonorsDis);
            this.pnlListDonors.Controls.Add(this.pnlStatsBar);
            this.pnlListDonors.Controls.Add(this.dgvListDonors);
            this.pnlListDonors.FillColor = System.Drawing.Color.White;
            this.pnlListDonors.Location = new System.Drawing.Point(16, 224);
            this.pnlListDonors.Name = "pnlListDonors";
            this.pnlListDonors.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlListDonors.ShadowDecoration.Depth = 8;
            this.pnlListDonors.ShadowDecoration.Enabled = true;
            this.pnlListDonors.Size = new System.Drawing.Size(1279, 452);
            this.pnlListDonors.TabIndex = 3;
            // 
            // lblListDonors
            // 
            this.lblListDonors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListDonors.AutoSize = true;
            this.lblListDonors.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblListDonors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblListDonors.Location = new System.Drawing.Point(1110, 10);
            this.lblListDonors.Name = "lblListDonors";
            this.lblListDonors.Size = new System.Drawing.Size(111, 24);
            this.lblListDonors.TabIndex = 0;
            this.lblListDonors.Text = "قائمة المتبرعين";
            // 
            // picListDonors
            // 
            this.picListDonors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picListDonors.ImageRotate = 0F;
            this.picListDonors.Location = new System.Drawing.Point(1244, 9);
            this.picListDonors.Name = "picListDonors";
            this.picListDonors.Size = new System.Drawing.Size(24, 24);
            this.picListDonors.TabIndex = 1;
            this.picListDonors.TabStop = false;
            // 
            // lblListDonorsDis
            // 
            this.lblListDonorsDis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblListDonorsDis.AutoSize = true;
            this.lblListDonorsDis.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblListDonorsDis.ForeColor = System.Drawing.Color.DimGray;
            this.lblListDonorsDis.Location = new System.Drawing.Point(990, 32);
            this.lblListDonorsDis.Name = "lblListDonorsDis";
            this.lblListDonorsDis.Size = new System.Drawing.Size(226, 18);
            this.lblListDonorsDis.TabIndex = 1;
            this.lblListDonorsDis.Text = "قائمة بجميع المتبرعين و إحصائيات تبرعاتهم";
            // 
            // pnlStatsBar
            // 
            this.pnlStatsBar.BorderRadius = 8;
            this.pnlStatsBar.Controls.Add(this.lblLabelNumberDonors);
            this.pnlStatsBar.Controls.Add(this.lblNumberNumberDonors);
            this.pnlStatsBar.Controls.Add(this.lblTextNumberDonors);
            this.pnlStatsBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.pnlStatsBar.Location = new System.Drawing.Point(12, 54);
            this.pnlStatsBar.Name = "pnlStatsBar";
            this.pnlStatsBar.Size = new System.Drawing.Size(340, 28);
            this.pnlStatsBar.TabIndex = 2;
            // 
            // lblLabelNumberDonors
            // 
            this.lblLabelNumberDonors.AutoSize = true;
            this.lblLabelNumberDonors.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblLabelNumberDonors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblLabelNumberDonors.Location = new System.Drawing.Point(220, 5);
            this.lblLabelNumberDonors.Name = "lblLabelNumberDonors";
            this.lblLabelNumberDonors.Size = new System.Drawing.Size(75, 18);
            this.lblLabelNumberDonors.TabIndex = 0;
            this.lblLabelNumberDonors.Text = "عدد المتبرعين";
            // 
            // lblNumberNumberDonors
            // 
            this.lblNumberNumberDonors.AutoSize = true;
            this.lblNumberNumberDonors.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumberNumberDonors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumberNumberDonors.Location = new System.Drawing.Point(166, 5);
            this.lblNumberNumberDonors.Name = "lblNumberNumberDonors";
            this.lblNumberNumberDonors.Size = new System.Drawing.Size(36, 18);
            this.lblNumberNumberDonors.TabIndex = 1;
            this.lblNumberNumberDonors.Text = "0000";
            // 
            // lblTextNumberDonors
            // 
            this.lblTextNumberDonors.AutoSize = true;
            this.lblTextNumberDonors.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTextNumberDonors.ForeColor = System.Drawing.Color.DimGray;
            this.lblTextNumberDonors.Location = new System.Drawing.Point(114, 5);
            this.lblTextNumberDonors.Name = "lblTextNumberDonors";
            this.lblTextNumberDonors.Size = new System.Drawing.Size(34, 18);
            this.lblTextNumberDonors.TabIndex = 2;
            this.lblTextNumberDonors.Text = "متبرع";
            // 
            // dgvListDonors
            // 
            this.dgvListDonors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListDonors.BackgroundColor = System.Drawing.Color.White;
            this.dgvListDonors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListDonors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListDonors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvListDonors.Location = new System.Drawing.Point(12, 92);
            this.dgvListDonors.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListDonors.Name = "dgvListDonors";
            this.dgvListDonors.RowHeadersWidth = 50;
            this.dgvListDonors.Size = new System.Drawing.Size(1252, 348);
            this.dgvListDonors.TabIndex = 3;
            // 
            // frmDonorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlDonorProcedures);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlListDonors);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDonorManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إدارة المتبرعين";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlDonorProcedures.ResumeLayout(false);
            this.pnlDonorProcedures.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlListDonors.ResumeLayout(false);
            this.pnlListDonors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picListDonors)).EndInit();
            this.pnlStatsBar.ResumeLayout(false);
            this.pnlStatsBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListDonors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private Guna.UI2.WinForms.Guna2Button btnBackToDonationsManagement;
        private Guna.UI2.WinForms.Guna2Panel pnlDonorProcedures;
        private System.Windows.Forms.Label lblDonorProcedures;
        private Guna.UI2.WinForms.Guna2Button btnAddNewDonor;
        private Guna.UI2.WinForms.Guna2Button btnDonorAdjustment;
        private Guna.UI2.WinForms.Guna2Button btnDeleteDonor;
        private Guna.UI2.WinForms.Guna2Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2PictureBox picSearch;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label lblResearchValue;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Panel pnlListDonors;
        private System.Windows.Forms.Label lblListDonors;
        private Guna.UI2.WinForms.Guna2PictureBox picListDonors;
        private System.Windows.Forms.Label lblListDonorsDis;
        private Guna.UI2.WinForms.Guna2Panel pnlStatsBar;
        private System.Windows.Forms.Label lblLabelNumberDonors;
        private System.Windows.Forms.Label lblNumberNumberDonors;
        private System.Windows.Forms.Label lblTextNumberDonors;
        private System.Windows.Forms.DataGridView dgvListDonors;
    }
}
