namespace Smart_Charity_and_Aid_Distribution_Tracker.Distrbution
{
    partial class frmDistrbution
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
            this.btnNewDisbursementProcess = new Guna.UI2.WinForms.Guna2Button();
            this.btnDetailsProcess = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteSelected = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.picSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTypeAssistance = new System.Windows.Forms.Label();
            this.cmbTypeAssistance = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblBeneficiaryName = new System.Windows.Forms.Label();
            this.txtBeneficiaryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.pnlDisbursementTransactionLog = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDisbursementTransactionLog = new System.Windows.Forms.Label();
            this.picDisbursementTransactionLog = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDisbursementTransactionLogDis = new System.Windows.Forms.Label();
            this.pnlStatsBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFinancialAid = new System.Windows.Forms.Label();
            this.lblNumbeFinancialAid = new System.Windows.Forms.Label();
            this.lblDesignatedAid = new System.Windows.Forms.Label();
            this.lblNumbeDesignatedAid = new System.Windows.Forms.Label();
            this.lblTotalOperations = new System.Windows.Forms.Label();
            this.lblNumberTotalOperations = new System.Windows.Forms.Label();
            this.lblTotalAmounts = new System.Windows.Forms.Label();
            this.lblNumberTotalAmounts = new System.Windows.Forms.Label();
            this.lblTextTotalAmounts = new System.Windows.Forms.Label();
            this.dgvDisbursementTransactionLog = new System.Windows.Forms.DataGridView();
            this.pnlTopBar.SuspendLayout();
            this.pnlActionsBox.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlDisbursementTransactionLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisbursementTransactionLog)).BeginInit();
            this.pnlStatsBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisbursementTransactionLog)).BeginInit();
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
            this.lblPageTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(20)))));
            this.lblPageTitle.Location = new System.Drawing.Point(555, 14);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(174, 27);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "سجل عمليات الصرف";
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
            this.pnlActionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActionsBox.BackColor = System.Drawing.Color.Transparent;
            this.pnlActionsBox.BorderRadius = 14;
            this.pnlActionsBox.Controls.Add(this.lblActionsBox);
            this.pnlActionsBox.Controls.Add(this.btnNewDisbursementProcess);
            this.pnlActionsBox.Controls.Add(this.btnDetailsProcess);
            this.pnlActionsBox.Controls.Add(this.btnDeleteSelected);
            this.pnlActionsBox.FillColor = System.Drawing.Color.White;
            this.pnlActionsBox.Location = new System.Drawing.Point(16, 68);
            this.pnlActionsBox.Name = "pnlActionsBox";
            this.pnlActionsBox.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlActionsBox.ShadowDecoration.Depth = 8;
            this.pnlActionsBox.ShadowDecoration.Enabled = true;
            this.pnlActionsBox.Size = new System.Drawing.Size(816, 100);
            this.pnlActionsBox.TabIndex = 1;
            // 
            // lblActionsBox
            // 
            this.lblActionsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblActionsBox.AutoSize = true;
            this.lblActionsBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblActionsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblActionsBox.Location = new System.Drawing.Point(620, 12);
            this.lblActionsBox.Name = "lblActionsBox";
            this.lblActionsBox.Size = new System.Drawing.Size(134, 24);
            this.lblActionsBox.TabIndex = 0;
            this.lblActionsBox.Text = "صندوق الإجراءات";
            // 
            // btnNewDisbursementProcess
            // 
            this.btnNewDisbursementProcess.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewDisbursementProcess.BorderRadius = 8;
            this.btnNewDisbursementProcess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnNewDisbursementProcess.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewDisbursementProcess.ForeColor = System.Drawing.Color.White;
            this.btnNewDisbursementProcess.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnNewDisbursementProcess.Location = new System.Drawing.Point(550, 42);
            this.btnNewDisbursementProcess.Name = "btnNewDisbursementProcess";
            this.btnNewDisbursementProcess.Size = new System.Drawing.Size(230, 38);
            this.btnNewDisbursementProcess.TabIndex = 1;
            this.btnNewDisbursementProcess.Text = "عملية صرف جديدة";
            this.btnNewDisbursementProcess.Click += new System.EventHandler(this.btnNewDisbursementProcess_Click);
            // 
            // btnDetailsProcess
            // 
            this.btnDetailsProcess.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDetailsProcess.BorderRadius = 8;
            this.btnDetailsProcess.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDetailsProcess.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnDetailsProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDetailsProcess.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.btnDetailsProcess.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(20)))));
            this.btnDetailsProcess.Location = new System.Drawing.Point(300, 42);
            this.btnDetailsProcess.Name = "btnDetailsProcess";
            this.btnDetailsProcess.Size = new System.Drawing.Size(230, 38);
            this.btnDetailsProcess.TabIndex = 2;
            this.btnDetailsProcess.Text = "تفاصيل العملية";
            this.btnDetailsProcess.Click += new System.EventHandler(this.btnDetailsProcess_Click);
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
            this.btnDeleteSelected.Location = new System.Drawing.Point(46, 42);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(230, 38);
            this.btnDeleteSelected.TabIndex = 3;
            this.btnDeleteSelected.Text = "حذف المحدد";
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.BorderRadius = 14;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.picSearch);
            this.pnlSearch.Controls.Add(this.lblTypeAssistance);
            this.pnlSearch.Controls.Add(this.cmbTypeAssistance);
            this.pnlSearch.Controls.Add(this.lblFrom);
            this.pnlSearch.Controls.Add(this.dtpFrom);
            this.pnlSearch.Controls.Add(this.lblTo);
            this.pnlSearch.Controls.Add(this.dtpTo);
            this.pnlSearch.Controls.Add(this.lblBeneficiaryName);
            this.pnlSearch.Controls.Add(this.txtBeneficiaryName);
            this.pnlSearch.Controls.Add(this.lblEmployeeName);
            this.pnlSearch.Controls.Add(this.txtEmployeeName);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.btnClear);
            this.pnlSearch.FillColor = System.Drawing.Color.White;
            this.pnlSearch.Location = new System.Drawing.Point(841, 68);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSearch.ShadowDecoration.Depth = 8;
            this.pnlSearch.ShadowDecoration.Enabled = true;
            this.pnlSearch.Size = new System.Drawing.Size(454, 608);
            this.pnlSearch.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblSearch.Location = new System.Drawing.Point(220, 14);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(174, 24);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "صندوق البحث و الفلترة";
            // 
            // picSearch
            // 
            this.picSearch.ImageRotate = 0F;
            this.picSearch.Location = new System.Drawing.Point(406, 12);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(24, 24);
            this.picSearch.TabIndex = 1;
            this.picSearch.TabStop = false;
            // 
            // lblTypeAssistance
            // 
            this.lblTypeAssistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTypeAssistance.AutoSize = true;
            this.lblTypeAssistance.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblTypeAssistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTypeAssistance.Location = new System.Drawing.Point(324, 57);
            this.lblTypeAssistance.Name = "lblTypeAssistance";
            this.lblTypeAssistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTypeAssistance.Size = new System.Drawing.Size(96, 21);
            this.lblTypeAssistance.TabIndex = 1;
            this.lblTypeAssistance.Text = "نوع المساعدة :";
            // 
            // cmbTypeAssistance
            // 
            this.cmbTypeAssistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTypeAssistance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cmbTypeAssistance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTypeAssistance.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbTypeAssistance.FormattingEnabled = true;
            this.cmbTypeAssistance.Location = new System.Drawing.Point(22, 80);
            this.cmbTypeAssistance.Name = "cmbTypeAssistance";
            this.cmbTypeAssistance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTypeAssistance.Size = new System.Drawing.Size(406, 29);
            this.cmbTypeAssistance.TabIndex = 2;
            // 
            // lblFrom
            // 
            this.lblFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblFrom.Location = new System.Drawing.Point(354, 127);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblFrom.Size = new System.Drawing.Size(71, 21);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "من تاريخ :";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.Font = new System.Drawing.Font("Calibri", 10F);
            this.dtpFrom.Location = new System.Drawing.Point(22, 152);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFrom.Size = new System.Drawing.Size(406, 28);
            this.dtpFrom.TabIndex = 4;
            // 
            // lblTo
            // 
            this.lblTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTo.Location = new System.Drawing.Point(354, 207);
            this.lblTo.Name = "lblTo";
            this.lblTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTo.Size = new System.Drawing.Size(68, 21);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "الى تاريخ :";
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.Font = new System.Drawing.Font("Calibri", 10F);
            this.dtpTo.Location = new System.Drawing.Point(22, 232);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpTo.Size = new System.Drawing.Size(406, 28);
            this.dtpTo.TabIndex = 6;
            // 
            // lblBeneficiaryName
            // 
            this.lblBeneficiaryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBeneficiaryName.AutoSize = true;
            this.lblBeneficiaryName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblBeneficiaryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblBeneficiaryName.Location = new System.Drawing.Point(314, 287);
            this.lblBeneficiaryName.Name = "lblBeneficiaryName";
            this.lblBeneficiaryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBeneficiaryName.Size = new System.Drawing.Size(99, 21);
            this.lblBeneficiaryName.TabIndex = 7;
            this.lblBeneficiaryName.Text = "اسم المستفيد :";
            // 
            // txtBeneficiaryName
            // 
            this.txtBeneficiaryName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBeneficiaryName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtBeneficiaryName.BorderRadius = 8;
            this.txtBeneficiaryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBeneficiaryName.DefaultText = "";
            this.txtBeneficiaryName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtBeneficiaryName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtBeneficiaryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtBeneficiaryName.Location = new System.Drawing.Point(22, 312);
            this.txtBeneficiaryName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBeneficiaryName.Name = "txtBeneficiaryName";
            this.txtBeneficiaryName.PlaceholderText = "";
            this.txtBeneficiaryName.SelectedText = "";
            this.txtBeneficiaryName.Size = new System.Drawing.Size(406, 36);
            this.txtBeneficiaryName.TabIndex = 8;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblEmployeeName.Location = new System.Drawing.Point(322, 371);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmployeeName.Size = new System.Drawing.Size(95, 21);
            this.lblEmployeeName.TabIndex = 9;
            this.lblEmployeeName.Text = "اسم الموظف :";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtEmployeeName.BorderRadius = 8;
            this.txtEmployeeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmployeeName.DefaultText = "";
            this.txtEmployeeName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtEmployeeName.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtEmployeeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtEmployeeName.Location = new System.Drawing.Point(22, 396);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PlaceholderText = "";
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.Size = new System.Drawing.Size(406, 36);
            this.txtEmployeeName.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnSearch.Location = new System.Drawing.Point(22, 460);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(192, 38);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "بحث";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BorderRadius = 8;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnClear.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(236, 460);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(192, 38);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "مسح";
            // 
            // pnlDisbursementTransactionLog
            // 
            this.pnlDisbursementTransactionLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisbursementTransactionLog.BackColor = System.Drawing.Color.Transparent;
            this.pnlDisbursementTransactionLog.BorderRadius = 14;
            this.pnlDisbursementTransactionLog.Controls.Add(this.lblDisbursementTransactionLog);
            this.pnlDisbursementTransactionLog.Controls.Add(this.picDisbursementTransactionLog);
            this.pnlDisbursementTransactionLog.Controls.Add(this.lblDisbursementTransactionLogDis);
            this.pnlDisbursementTransactionLog.Controls.Add(this.pnlStatsBar);
            this.pnlDisbursementTransactionLog.Controls.Add(this.dgvDisbursementTransactionLog);
            this.pnlDisbursementTransactionLog.FillColor = System.Drawing.Color.White;
            this.pnlDisbursementTransactionLog.Location = new System.Drawing.Point(16, 180);
            this.pnlDisbursementTransactionLog.Name = "pnlDisbursementTransactionLog";
            this.pnlDisbursementTransactionLog.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlDisbursementTransactionLog.ShadowDecoration.Depth = 8;
            this.pnlDisbursementTransactionLog.ShadowDecoration.Enabled = true;
            this.pnlDisbursementTransactionLog.Size = new System.Drawing.Size(816, 496);
            this.pnlDisbursementTransactionLog.TabIndex = 3;
            // 
            // lblDisbursementTransactionLog
            // 
            this.lblDisbursementTransactionLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisbursementTransactionLog.AutoSize = true;
            this.lblDisbursementTransactionLog.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDisbursementTransactionLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lblDisbursementTransactionLog.Location = new System.Drawing.Point(620, 12);
            this.lblDisbursementTransactionLog.Name = "lblDisbursementTransactionLog";
            this.lblDisbursementTransactionLog.Size = new System.Drawing.Size(156, 24);
            this.lblDisbursementTransactionLog.TabIndex = 0;
            this.lblDisbursementTransactionLog.Text = "سجل عمليات الصرف";
            // 
            // picDisbursementTransactionLog
            // 
            this.picDisbursementTransactionLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picDisbursementTransactionLog.ImageRotate = 0F;
            this.picDisbursementTransactionLog.Location = new System.Drawing.Point(766, 12);
            this.picDisbursementTransactionLog.Name = "picDisbursementTransactionLog";
            this.picDisbursementTransactionLog.Size = new System.Drawing.Size(24, 24);
            this.picDisbursementTransactionLog.TabIndex = 1;
            this.picDisbursementTransactionLog.TabStop = false;
            // 
            // lblDisbursementTransactionLogDis
            // 
            this.lblDisbursementTransactionLogDis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisbursementTransactionLogDis.AutoSize = true;
            this.lblDisbursementTransactionLogDis.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDisbursementTransactionLogDis.ForeColor = System.Drawing.Color.DimGray;
            this.lblDisbursementTransactionLogDis.Location = new System.Drawing.Point(482, 40);
            this.lblDisbursementTransactionLogDis.Name = "lblDisbursementTransactionLogDis";
            this.lblDisbursementTransactionLogDis.Size = new System.Drawing.Size(274, 18);
            this.lblDisbursementTransactionLogDis.TabIndex = 1;
            this.lblDisbursementTransactionLogDis.Text = "جدول يعرض جميع عمليات الصرف المسجلة في النظام";
            // 
            // pnlStatsBar
            // 
            this.pnlStatsBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsBar.BorderRadius = 8;
            this.pnlStatsBar.Controls.Add(this.lblFinancialAid);
            this.pnlStatsBar.Controls.Add(this.lblNumbeFinancialAid);
            this.pnlStatsBar.Controls.Add(this.lblDesignatedAid);
            this.pnlStatsBar.Controls.Add(this.lblNumbeDesignatedAid);
            this.pnlStatsBar.Controls.Add(this.lblTotalOperations);
            this.pnlStatsBar.Controls.Add(this.lblNumberTotalOperations);
            this.pnlStatsBar.Controls.Add(this.lblTotalAmounts);
            this.pnlStatsBar.Controls.Add(this.lblNumberTotalAmounts);
            this.pnlStatsBar.Controls.Add(this.lblTextTotalAmounts);
            this.pnlStatsBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.pnlStatsBar.Location = new System.Drawing.Point(12, 65);
            this.pnlStatsBar.Name = "pnlStatsBar";
            this.pnlStatsBar.Size = new System.Drawing.Size(790, 28);
            this.pnlStatsBar.TabIndex = 2;
            // 
            // lblFinancialAid
            // 
            this.lblFinancialAid.AutoSize = true;
            this.lblFinancialAid.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblFinancialAid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblFinancialAid.Location = new System.Drawing.Point(660, 5);
            this.lblFinancialAid.Name = "lblFinancialAid";
            this.lblFinancialAid.Size = new System.Drawing.Size(84, 18);
            this.lblFinancialAid.TabIndex = 0;
            this.lblFinancialAid.Text = "مساعدات مالية";
            // 
            // lblNumbeFinancialAid
            // 
            this.lblNumbeFinancialAid.AutoSize = true;
            this.lblNumbeFinancialAid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumbeFinancialAid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumbeFinancialAid.Location = new System.Drawing.Point(621, 5);
            this.lblNumbeFinancialAid.Name = "lblNumbeFinancialAid";
            this.lblNumbeFinancialAid.Size = new System.Drawing.Size(36, 18);
            this.lblNumbeFinancialAid.TabIndex = 1;
            this.lblNumbeFinancialAid.Text = "0000";
            // 
            // lblDesignatedAid
            // 
            this.lblDesignatedAid.AutoSize = true;
            this.lblDesignatedAid.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDesignatedAid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDesignatedAid.Location = new System.Drawing.Point(508, 5);
            this.lblDesignatedAid.Name = "lblDesignatedAid";
            this.lblDesignatedAid.Size = new System.Drawing.Size(86, 18);
            this.lblDesignatedAid.TabIndex = 2;
            this.lblDesignatedAid.Text = "مساعدات عينية";
            // 
            // lblNumbeDesignatedAid
            // 
            this.lblNumbeDesignatedAid.AutoSize = true;
            this.lblNumbeDesignatedAid.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumbeDesignatedAid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumbeDesignatedAid.Location = new System.Drawing.Point(469, 5);
            this.lblNumbeDesignatedAid.Name = "lblNumbeDesignatedAid";
            this.lblNumbeDesignatedAid.Size = new System.Drawing.Size(36, 18);
            this.lblNumbeDesignatedAid.TabIndex = 3;
            this.lblNumbeDesignatedAid.Text = "0000";
            // 
            // lblTotalOperations
            // 
            this.lblTotalOperations.AutoSize = true;
            this.lblTotalOperations.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTotalOperations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTotalOperations.Location = new System.Drawing.Point(356, 5);
            this.lblTotalOperations.Name = "lblTotalOperations";
            this.lblTotalOperations.Size = new System.Drawing.Size(88, 18);
            this.lblTotalOperations.TabIndex = 4;
            this.lblTotalOperations.Text = "إجمالي العمليات";
            // 
            // lblNumberTotalOperations
            // 
            this.lblNumberTotalOperations.AutoSize = true;
            this.lblNumberTotalOperations.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumberTotalOperations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumberTotalOperations.Location = new System.Drawing.Point(316, 5);
            this.lblNumberTotalOperations.Name = "lblNumberTotalOperations";
            this.lblNumberTotalOperations.Size = new System.Drawing.Size(36, 18);
            this.lblNumberTotalOperations.TabIndex = 5;
            this.lblNumberTotalOperations.Text = "0000";
            // 
            // lblTotalAmounts
            // 
            this.lblTotalAmounts.AutoSize = true;
            this.lblTotalAmounts.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTotalAmounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTotalAmounts.Location = new System.Drawing.Point(190, 5);
            this.lblTotalAmounts.Name = "lblTotalAmounts";
            this.lblTotalAmounts.Size = new System.Drawing.Size(85, 18);
            this.lblTotalAmounts.TabIndex = 6;
            this.lblTotalAmounts.Text = "القيمة الاجمالية";
            // 
            // lblNumberTotalAmounts
            // 
            this.lblNumberTotalAmounts.AutoSize = true;
            this.lblNumberTotalAmounts.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblNumberTotalAmounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumberTotalAmounts.Location = new System.Drawing.Point(153, 5);
            this.lblNumberTotalAmounts.Name = "lblNumberTotalAmounts";
            this.lblNumberTotalAmounts.Size = new System.Drawing.Size(36, 18);
            this.lblNumberTotalAmounts.TabIndex = 7;
            this.lblNumberTotalAmounts.Text = "0000";
            // 
            // lblTextTotalAmounts
            // 
            this.lblTextTotalAmounts.AutoSize = true;
            this.lblTextTotalAmounts.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTextTotalAmounts.ForeColor = System.Drawing.Color.DimGray;
            this.lblTextTotalAmounts.Location = new System.Drawing.Point(115, 5);
            this.lblTextTotalAmounts.Name = "lblTextTotalAmounts";
            this.lblTextTotalAmounts.Size = new System.Drawing.Size(32, 18);
            this.lblTextTotalAmounts.TabIndex = 8;
            this.lblTextTotalAmounts.Text = "دينار";
            // 
            // dgvDisbursementTransactionLog
            // 
            this.dgvDisbursementTransactionLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDisbursementTransactionLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisbursementTransactionLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisbursementTransactionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisbursementTransactionLog.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvDisbursementTransactionLog.Location = new System.Drawing.Point(12, 106);
            this.dgvDisbursementTransactionLog.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDisbursementTransactionLog.Name = "dgvDisbursementTransactionLog";
            this.dgvDisbursementTransactionLog.RowHeadersWidth = 50;
            this.dgvDisbursementTransactionLog.Size = new System.Drawing.Size(790, 376);
            this.dgvDisbursementTransactionLog.TabIndex = 3;
            // 
            // frmDistrbution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlActionsBox);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlDisbursementTransactionLog);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDistrbution";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التوزيع";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlActionsBox.ResumeLayout(false);
            this.pnlActionsBox.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlDisbursementTransactionLog.ResumeLayout(false);
            this.pnlDisbursementTransactionLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDisbursementTransactionLog)).EndInit();
            this.pnlStatsBar.ResumeLayout(false);
            this.pnlStatsBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisbursementTransactionLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private System.Windows.Forms.Label lblPageTitle;
        private Guna.UI2.WinForms.Guna2Button btnBackToDashBoard;
        private Guna.UI2.WinForms.Guna2Panel pnlActionsBox;
        private System.Windows.Forms.Label lblActionsBox;
        private Guna.UI2.WinForms.Guna2Button btnNewDisbursementProcess;
        private Guna.UI2.WinForms.Guna2Button btnDetailsProcess;
        private Guna.UI2.WinForms.Guna2Button btnDeleteSelected;
        private Guna.UI2.WinForms.Guna2Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private Guna.UI2.WinForms.Guna2PictureBox picSearch;
        private System.Windows.Forms.Label lblTypeAssistance;
        private System.Windows.Forms.ComboBox cmbTypeAssistance;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblBeneficiaryName;
        private Guna.UI2.WinForms.Guna2TextBox txtBeneficiaryName;
        private System.Windows.Forms.Label lblEmployeeName;
        private Guna.UI2.WinForms.Guna2TextBox txtEmployeeName;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Panel pnlDisbursementTransactionLog;
        private System.Windows.Forms.Label lblDisbursementTransactionLog;
        private Guna.UI2.WinForms.Guna2PictureBox picDisbursementTransactionLog;
        private System.Windows.Forms.Label lblDisbursementTransactionLogDis;
        private Guna.UI2.WinForms.Guna2Panel pnlStatsBar;
        private System.Windows.Forms.Label lblFinancialAid;
        private System.Windows.Forms.Label lblNumbeFinancialAid;
        private System.Windows.Forms.Label lblDesignatedAid;
        private System.Windows.Forms.Label lblNumbeDesignatedAid;
        private System.Windows.Forms.Label lblTotalOperations;
        private System.Windows.Forms.Label lblNumberTotalOperations;
        private System.Windows.Forms.Label lblTotalAmounts;
        private System.Windows.Forms.Label lblNumberTotalAmounts;
        private System.Windows.Forms.Label lblTextTotalAmounts;
        private System.Windows.Forms.DataGridView dgvDisbursementTransactionLog;
    }
}
