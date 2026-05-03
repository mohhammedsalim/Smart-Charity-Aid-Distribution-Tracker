namespace Smart_Charity_and_Aid_Distribution_Tracker.Reports
{
    partial class frmReports
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
            this.pnlReportResults = new Guna.UI2.WinForms.Guna2Panel();
            this.lblReportResults = new System.Windows.Forms.Label();
            this.picReportResults = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblReportName = new System.Windows.Forms.Label();
            this.dgvReportResults = new System.Windows.Forms.DataGridView();
            this.pnlReportsControl = new Guna.UI2.WinForms.Guna2Panel();
            this.lblReportsControl = new System.Windows.Forms.Label();
            this.picReportsControl = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDesiredReport = new System.Windows.Forms.Label();
            this.cmbDesiredReport = new System.Windows.Forms.ComboBox();
            this.pnlSep1 = new System.Windows.Forms.Panel();
            this.lblReportFlters = new System.Windows.Forms.Label();
            this.txtReportFlters = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPresentReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSep2 = new System.Windows.Forms.Panel();
            this.lblProcedures = new System.Windows.Forms.Label();
            this.btnPrintReport = new Guna.UI2.WinForms.Guna2Button();
            this.btnImport = new Guna.UI2.WinForms.Guna2Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlReportResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReportResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResults)).BeginInit();
            this.pnlReportsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReportsControl)).BeginInit();
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
            this.lblFormTitle.Size = new System.Drawing.Size(72, 29);
            this.lblFormTitle.TabIndex = 1;
            this.lblFormTitle.Text = "التقارير";
            // 
            // pnlReportResults
            // 
            this.pnlReportResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReportResults.BackColor = System.Drawing.Color.Transparent;
            this.pnlReportResults.BorderRadius = 12;
            this.pnlReportResults.Controls.Add(this.lblReportResults);
            this.pnlReportResults.Controls.Add(this.picReportResults);
            this.pnlReportResults.Controls.Add(this.lblReportName);
            this.pnlReportResults.Controls.Add(this.dgvReportResults);
            this.pnlReportResults.FillColor = System.Drawing.Color.White;
            this.pnlReportResults.Location = new System.Drawing.Point(16, 62);
            this.pnlReportResults.Name = "pnlReportResults";
            this.pnlReportResults.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlReportResults.ShadowDecoration.Depth = 8;
            this.pnlReportResults.ShadowDecoration.Enabled = true;
            this.pnlReportResults.Size = new System.Drawing.Size(816, 613);
            this.pnlReportResults.TabIndex = 1;
            // 
            // lblReportResults
            // 
            this.lblReportResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportResults.AutoSize = true;
            this.lblReportResults.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblReportResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblReportResults.Location = new System.Drawing.Point(640, 14);
            this.lblReportResults.Name = "lblReportResults";
            this.lblReportResults.Size = new System.Drawing.Size(98, 24);
            this.lblReportResults.TabIndex = 0;
            this.lblReportResults.Text = "نتائج التقارير";
            // 
            // picReportResults
            // 
            this.picReportResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picReportResults.ImageRotate = 0F;
            this.picReportResults.Location = new System.Drawing.Point(762, 12);
            this.picReportResults.Name = "picReportResults";
            this.picReportResults.Size = new System.Drawing.Size(24, 25);
            this.picReportResults.TabIndex = 1;
            this.picReportResults.TabStop = false;
            // 
            // lblReportName
            // 
            this.lblReportName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportName.AutoSize = true;
            this.lblReportName.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblReportName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblReportName.Location = new System.Drawing.Point(660, 46);
            this.lblReportName.Name = "lblReportName";
            this.lblReportName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblReportName.Size = new System.Drawing.Size(69, 21);
            this.lblReportName.TabIndex = 2;
            this.lblReportName.Text = "نوع الحركة";
            // 
            // dgvReportResults
            // 
            this.dgvReportResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReportResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvReportResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.dgvReportResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportResults.EnableHeadersVisualStyles = false;
            this.dgvReportResults.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dgvReportResults.Location = new System.Drawing.Point(16, 80);
            this.dgvReportResults.Name = "dgvReportResults";
            this.dgvReportResults.RowHeadersWidth = 62;
            this.dgvReportResults.Size = new System.Drawing.Size(782, 510);
            this.dgvReportResults.TabIndex = 3;
            // 
            // pnlReportsControl
            // 
            this.pnlReportsControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReportsControl.BackColor = System.Drawing.Color.Transparent;
            this.pnlReportsControl.BorderRadius = 12;
            this.pnlReportsControl.Controls.Add(this.lblReportsControl);
            this.pnlReportsControl.Controls.Add(this.picReportsControl);
            this.pnlReportsControl.Controls.Add(this.lblDesiredReport);
            this.pnlReportsControl.Controls.Add(this.cmbDesiredReport);
            this.pnlReportsControl.Controls.Add(this.pnlSep1);
            this.pnlReportsControl.Controls.Add(this.lblReportFlters);
            this.pnlReportsControl.Controls.Add(this.txtReportFlters);
            this.pnlReportsControl.Controls.Add(this.btnPresentReport);
            this.pnlReportsControl.Controls.Add(this.btnClear);
            this.pnlReportsControl.Controls.Add(this.pnlSep2);
            this.pnlReportsControl.Controls.Add(this.lblProcedures);
            this.pnlReportsControl.Controls.Add(this.btnPrintReport);
            this.pnlReportsControl.Controls.Add(this.btnImport);
            this.pnlReportsControl.FillColor = System.Drawing.Color.White;
            this.pnlReportsControl.Location = new System.Drawing.Point(841, 62);
            this.pnlReportsControl.Name = "pnlReportsControl";
            this.pnlReportsControl.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlReportsControl.ShadowDecoration.Depth = 8;
            this.pnlReportsControl.ShadowDecoration.Enabled = true;
            this.pnlReportsControl.Size = new System.Drawing.Size(454, 613);
            this.pnlReportsControl.TabIndex = 2;
            // 
            // lblReportsControl
            // 
            this.lblReportsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportsControl.AutoSize = true;
            this.lblReportsControl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblReportsControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblReportsControl.Location = new System.Drawing.Point(224, 12);
            this.lblReportsControl.Name = "lblReportsControl";
            this.lblReportsControl.Size = new System.Drawing.Size(159, 24);
            this.lblReportsControl.TabIndex = 0;
            this.lblReportsControl.Text = "لوحة التحكم بالتقارير";
            // 
            // picReportsControl
            // 
            this.picReportsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picReportsControl.ImageRotate = 0F;
            this.picReportsControl.Location = new System.Drawing.Point(411, 12);
            this.picReportsControl.Name = "picReportsControl";
            this.picReportsControl.Size = new System.Drawing.Size(24, 25);
            this.picReportsControl.TabIndex = 1;
            this.picReportsControl.TabStop = false;
            // 
            // lblDesiredReport
            // 
            this.lblDesiredReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesiredReport.AutoSize = true;
            this.lblDesiredReport.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblDesiredReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblDesiredReport.Location = new System.Drawing.Point(264, 58);
            this.lblDesiredReport.Name = "lblDesiredReport";
            this.lblDesiredReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDesiredReport.Size = new System.Drawing.Size(132, 21);
            this.lblDesiredReport.TabIndex = 2;
            this.lblDesiredReport.Text = "اختر التقرير المطلوب";
            // 
            // cmbDesiredReport
            // 
            this.cmbDesiredReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDesiredReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.cmbDesiredReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDesiredReport.Font = new System.Drawing.Font("Calibri", 10F);
            this.cmbDesiredReport.FormattingEnabled = true;
            this.cmbDesiredReport.Location = new System.Drawing.Point(22, 82);
            this.cmbDesiredReport.Name = "cmbDesiredReport";
            this.cmbDesiredReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbDesiredReport.Size = new System.Drawing.Size(406, 29);
            this.cmbDesiredReport.TabIndex = 3;
            // 
            // pnlSep1
            // 
            this.pnlSep1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep1.Location = new System.Drawing.Point(12, 140);
            this.pnlSep1.Name = "pnlSep1";
            this.pnlSep1.Size = new System.Drawing.Size(427, 1);
            this.pnlSep1.TabIndex = 4;
            // 
            // lblReportFlters
            // 
            this.lblReportFlters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReportFlters.AutoSize = true;
            this.lblReportFlters.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblReportFlters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblReportFlters.Location = new System.Drawing.Point(308, 156);
            this.lblReportFlters.Name = "lblReportFlters";
            this.lblReportFlters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblReportFlters.Size = new System.Drawing.Size(80, 21);
            this.lblReportFlters.TabIndex = 5;
            this.lblReportFlters.Text = "فلاتر التقرير";
            // 
            // txtReportFlters
            // 
            this.txtReportFlters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReportFlters.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtReportFlters.BorderRadius = 8;
            this.txtReportFlters.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReportFlters.DefaultText = "";
            this.txtReportFlters.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.txtReportFlters.Font = new System.Drawing.Font("Calibri", 10F);
            this.txtReportFlters.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtReportFlters.Location = new System.Drawing.Point(22, 180);
            this.txtReportFlters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReportFlters.Name = "txtReportFlters";
            this.txtReportFlters.PlaceholderText = "";
            this.txtReportFlters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtReportFlters.SelectedText = "";
            this.txtReportFlters.Size = new System.Drawing.Size(406, 36);
            this.txtReportFlters.TabIndex = 6;
            // 
            // btnPresentReport
            // 
            this.btnPresentReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPresentReport.BorderRadius = 10;
            this.btnPresentReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnPresentReport.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnPresentReport.ForeColor = System.Drawing.Color.White;
            this.btnPresentReport.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnPresentReport.Location = new System.Drawing.Point(22, 238);
            this.btnPresentReport.Name = "btnPresentReport";
            this.btnPresentReport.Size = new System.Drawing.Size(227, 40);
            this.btnPresentReport.TabIndex = 7;
            this.btnPresentReport.Text = "عرض التقرير";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.BorderRadius = 10;
            this.btnClear.BorderThickness = 1;
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.btnClear.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnClear.Location = new System.Drawing.Point(258, 238);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(169, 40);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "مسح";
            // 
            // pnlSep2
            // 
            this.pnlSep2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.pnlSep2.Location = new System.Drawing.Point(12, 300);
            this.pnlSep2.Name = "pnlSep2";
            this.pnlSep2.Size = new System.Drawing.Size(427, 1);
            this.pnlSep2.TabIndex = 9;
            // 
            // lblProcedures
            // 
            this.lblProcedures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcedures.AutoSize = true;
            this.lblProcedures.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblProcedures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblProcedures.Location = new System.Drawing.Point(340, 316);
            this.lblProcedures.Name = "lblProcedures";
            this.lblProcedures.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProcedures.Size = new System.Drawing.Size(65, 21);
            this.lblProcedures.TabIndex = 10;
            this.lblProcedures.Text = "الإجراءات";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrintReport.BorderRadius = 10;
            this.btnPrintReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnPrintReport.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrintReport.ForeColor = System.Drawing.Color.White;
            this.btnPrintReport.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnPrintReport.Location = new System.Drawing.Point(22, 344);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(404, 40);
            this.btnPrintReport.TabIndex = 11;
            this.btnPrintReport.Text = "طباعة التقرير";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BorderRadius = 10;
            this.btnImport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnImport.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnImport.Location = new System.Drawing.Point(22, 400);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(404, 40);
            this.btnImport.TabIndex = 12;
            this.btnImport.Text = "Excel تصدير إلى  ";
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(1312, 690);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlReportResults);
            this.Controls.Add(this.pnlReportsControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReports";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "التقارير";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReports_Load);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlReportResults.ResumeLayout(false);
            this.pnlReportResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReportResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportResults)).EndInit();
            this.pnlReportsControl.ResumeLayout(false);
            this.pnlReportsControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReportsControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlTopBar;
        private Guna.UI2.WinForms.Guna2Button btnBackToDashBoard;
        private System.Windows.Forms.Label lblFormTitle;

        private Guna.UI2.WinForms.Guna2Panel pnlReportResults;
        private System.Windows.Forms.Label lblReportResults;
        private Guna.UI2.WinForms.Guna2PictureBox picReportResults;
        private System.Windows.Forms.Label lblReportName;
        private System.Windows.Forms.DataGridView dgvReportResults;

        private Guna.UI2.WinForms.Guna2Panel pnlReportsControl;
        private System.Windows.Forms.Label lblReportsControl;
        private Guna.UI2.WinForms.Guna2PictureBox picReportsControl;
        private System.Windows.Forms.Label lblDesiredReport;
        private System.Windows.Forms.ComboBox cmbDesiredReport;
        private System.Windows.Forms.Panel pnlSep1;
        private System.Windows.Forms.Label lblReportFlters;
        private Guna.UI2.WinForms.Guna2TextBox txtReportFlters;
        private Guna.UI2.WinForms.Guna2Button btnPresentReport;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private System.Windows.Forms.Panel pnlSep2;
        private System.Windows.Forms.Label lblProcedures;
        private Guna.UI2.WinForms.Guna2Button btnPrintReport;
        private Guna.UI2.WinForms.Guna2Button btnImport;
    }
}
