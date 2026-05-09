namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    partial class frmDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBeneficiaries = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNumberBeneficiaries = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlDonations = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNumberDonations = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlInventory = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNumberInventory = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlDisbursement = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNumberDisbursement = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlChart = new Guna.UI2.WinForms.Guna2Panel();
            this.chartStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRecent = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvRecentActivities = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpCards.SuspendLayout();
            this.pnlBeneficiaries.SuspendLayout();
            this.pnlDonations.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            this.pnlDisbursement.SuspendLayout();
            this.tlpContent.SuspendLayout();
            this.pnlChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).BeginInit();
            this.pnlRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpCards
            // 
            this.tlpCards.ColumnCount = 4;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.Controls.Add(this.pnlBeneficiaries, 0, 0);
            this.tlpCards.Controls.Add(this.pnlDonations, 1, 0);
            this.tlpCards.Controls.Add(this.pnlInventory, 2, 0);
            this.tlpCards.Controls.Add(this.pnlDisbursement, 3, 0);
            this.tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCards.Location = new System.Drawing.Point(0, 0);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.Padding = new System.Windows.Forms.Padding(20);
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(1579, 180);
            this.tlpCards.TabIndex = 11;
            // 
            // pnlBeneficiaries
            // 
            this.pnlBeneficiaries.BackColor = System.Drawing.Color.Transparent;
            this.pnlBeneficiaries.BorderRadius = 15;
            this.pnlBeneficiaries.Controls.Add(this.lblNumberBeneficiaries);
            this.pnlBeneficiaries.Controls.Add(this.label4);
            this.pnlBeneficiaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBeneficiaries.FillColor = System.Drawing.Color.White;
            this.pnlBeneficiaries.Location = new System.Drawing.Point(1185, 30);
            this.pnlBeneficiaries.Margin = new System.Windows.Forms.Padding(10);
            this.pnlBeneficiaries.Name = "pnlBeneficiaries";
            this.pnlBeneficiaries.ShadowDecoration.BorderRadius = 15;
            this.pnlBeneficiaries.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnlBeneficiaries.ShadowDecoration.Depth = 10;
            this.pnlBeneficiaries.ShadowDecoration.Enabled = true;
            this.pnlBeneficiaries.Size = new System.Drawing.Size(364, 120);
            this.pnlBeneficiaries.TabIndex = 2;
            // 
            // lblNumberBeneficiaries
            // 
            this.lblNumberBeneficiaries.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumberBeneficiaries.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold);
            this.lblNumberBeneficiaries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.lblNumberBeneficiaries.Location = new System.Drawing.Point(0, 55);
            this.lblNumberBeneficiaries.Name = "lblNumberBeneficiaries";
            this.lblNumberBeneficiaries.Size = new System.Drawing.Size(364, 65);
            this.lblNumberBeneficiaries.TabIndex = 1;
            this.lblNumberBeneficiaries.Text = "0";
            this.lblNumberBeneficiaries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            // 
            // label4
            // 
            this.label4.AutoSize = false; // 1. إيقاف التحجيم التلقائي
            this.label4.Dock = System.Windows.Forms.DockStyle.Top; // 2. التثبيت في الأعلى
            this.label4.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 50); // 3. إعطاء ارتفاع مناسب
            this.label4.TabIndex = 0;
            this.label4.Text = "إجمالي المستفيدين";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; // 4. توسيط النص
            // 
            // pnlDonations
            // 
            this.pnlDonations.BackColor = System.Drawing.Color.Transparent;
            this.pnlDonations.BorderRadius = 15;
            this.pnlDonations.Controls.Add(this.lblNumberDonations);
            this.pnlDonations.Controls.Add(this.label6);
            this.pnlDonations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDonations.FillColor = System.Drawing.Color.White;
            this.pnlDonations.Location = new System.Drawing.Point(801, 30);
            this.pnlDonations.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDonations.Name = "pnlDonations";
            this.pnlDonations.ShadowDecoration.BorderRadius = 15;
            this.pnlDonations.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnlDonations.ShadowDecoration.Depth = 10;
            this.pnlDonations.ShadowDecoration.Enabled = true;
            this.pnlDonations.Size = new System.Drawing.Size(364, 120);
            this.pnlDonations.TabIndex = 3;
            // 
            // lblNumberDonations
            // 
            this.lblNumberDonations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumberDonations.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold);
            this.lblNumberDonations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblNumberDonations.Location = new System.Drawing.Point(0, 55);
            this.lblNumberDonations.Name = "lblNumberDonations";
            this.lblNumberDonations.Size = new System.Drawing.Size(364, 65);
            this.lblNumberDonations.TabIndex = 1;
            this.lblNumberDonations.Text = "0";
            this.lblNumberDonations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = false;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(365, 50);
            this.label6.TabIndex = 0;
            this.label6.Text = "إجمالي التبرعات";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.Color.Transparent;
            this.pnlInventory.BorderRadius = 15;
            this.pnlInventory.Controls.Add(this.lblNumberInventory);
            this.pnlInventory.Controls.Add(this.label8);
            this.pnlInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInventory.FillColor = System.Drawing.Color.White;
            this.pnlInventory.Location = new System.Drawing.Point(417, 30);
            this.pnlInventory.Margin = new System.Windows.Forms.Padding(10);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.ShadowDecoration.BorderRadius = 15;
            this.pnlInventory.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnlInventory.ShadowDecoration.Depth = 10;
            this.pnlInventory.ShadowDecoration.Enabled = true;
            this.pnlInventory.Size = new System.Drawing.Size(364, 120);
            this.pnlInventory.TabIndex = 4;
            // 
            // lblNumberInventory
            // 
            this.lblNumberInventory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumberInventory.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold);
            this.lblNumberInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblNumberInventory.Location = new System.Drawing.Point(0, 55);
            this.lblNumberInventory.Name = "lblNumberInventory";
            this.lblNumberInventory.Size = new System.Drawing.Size(364, 65);
            this.lblNumberInventory.TabIndex = 1;
            this.lblNumberInventory.Text = "0";
            this.lblNumberInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = false;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 50);
            this.label8.TabIndex = 0;
            this.label8.Text = "أصناف المخزون";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlDisbursement
            // 
            this.pnlDisbursement.BackColor = System.Drawing.Color.Transparent;
            this.pnlDisbursement.BorderRadius = 15;
            this.pnlDisbursement.Controls.Add(this.lblNumberDisbursement);
            this.pnlDisbursement.Controls.Add(this.label10);
            this.pnlDisbursement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDisbursement.FillColor = System.Drawing.Color.White;
            this.pnlDisbursement.Location = new System.Drawing.Point(30, 30);
            this.pnlDisbursement.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDisbursement.Name = "pnlDisbursement";
            this.pnlDisbursement.ShadowDecoration.BorderRadius = 15;
            this.pnlDisbursement.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnlDisbursement.ShadowDecoration.Depth = 10;
            this.pnlDisbursement.ShadowDecoration.Enabled = true;
            this.pnlDisbursement.Size = new System.Drawing.Size(367, 120);
            this.pnlDisbursement.TabIndex = 5;
            // 
            // lblNumberDisbursement
            // 
            this.lblNumberDisbursement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNumberDisbursement.Font = new System.Drawing.Font("Cairo", 28F, System.Drawing.FontStyle.Bold);
            this.lblNumberDisbursement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblNumberDisbursement.Location = new System.Drawing.Point(0, 55);
            this.lblNumberDisbursement.Name = "lblNumberDisbursement";
            this.lblNumberDisbursement.Size = new System.Drawing.Size(367, 65);
            this.lblNumberDisbursement.TabIndex = 1;
            this.lblNumberDisbursement.Text = "0";
            this.lblNumberDisbursement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = false;
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(365, 50);
            this.label10.TabIndex = 0;
            this.label10.Text = "عمليات الصرف";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpContent.Controls.Add(this.pnlChart, 0, 0);
            this.tlpContent.Controls.Add(this.pnlRecent, 1, 0);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 180);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.tlpContent.RowCount = 1;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpContent.Size = new System.Drawing.Size(1579, 634);
            this.tlpContent.TabIndex = 10;
            // 
            // pnlChart
            // 
            this.pnlChart.BackColor = System.Drawing.Color.Transparent;
            this.pnlChart.BorderRadius = 15;
            this.pnlChart.Controls.Add(this.chartStatistics);
            this.pnlChart.Controls.Add(this.label1);
            this.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChart.FillColor = System.Drawing.Color.White;
            this.pnlChart.Location = new System.Drawing.Point(954, 10);
            this.pnlChart.Margin = new System.Windows.Forms.Padding(10);
            this.pnlChart.Name = "pnlChart";
            this.pnlChart.Padding = new System.Windows.Forms.Padding(20);
            this.pnlChart.ShadowDecoration.BorderRadius = 15;
            this.pnlChart.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnlChart.ShadowDecoration.Depth = 10;
            this.pnlChart.ShadowDecoration.Enabled = true;
            this.pnlChart.Size = new System.Drawing.Size(595, 594);
            this.pnlChart.TabIndex = 0;
            // 
            // chartStatistics
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistics.ChartAreas.Add(chartArea1);
            this.chartStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Font = new System.Drawing.Font("Cairo", 10F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.chartStatistics.Legends.Add(legend1);
            this.chartStatistics.Location = new System.Drawing.Point(20, 65);
            this.chartStatistics.Name = "chartStatistics";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            series1.Font = new System.Drawing.Font("Cairo", 10F);
            series1.Legend = "Legend1";
            series1.Name = "التبرعات";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            series2.Font = new System.Drawing.Font("Cairo", 10F);
            series2.Legend = "Legend1";
            series2.Name = "عمليات الصرف";
            this.chartStatistics.Series.Add(series1);
            this.chartStatistics.Series.Add(series2);
            this.chartStatistics.Size = new System.Drawing.Size(555, 509);
            this.chartStatistics.TabIndex = 1;
            this.chartStatistics.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "إحصائيات التبرعات والصرف";
            // 
            // pnlRecent
            // 
            this.pnlRecent.BackColor = System.Drawing.Color.Transparent;
            this.pnlRecent.BorderRadius = 15;
            this.pnlRecent.Controls.Add(this.dgvRecentActivities);
            this.pnlRecent.Controls.Add(this.label2);
            this.pnlRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecent.FillColor = System.Drawing.Color.White;
            this.pnlRecent.Location = new System.Drawing.Point(30, 10);
            this.pnlRecent.Margin = new System.Windows.Forms.Padding(10);
            this.pnlRecent.Name = "pnlRecent";
            this.pnlRecent.Padding = new System.Windows.Forms.Padding(20);
            this.pnlRecent.ShadowDecoration.BorderRadius = 15;
            this.pnlRecent.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnlRecent.ShadowDecoration.Depth = 10;
            this.pnlRecent.ShadowDecoration.Enabled = true;
            this.pnlRecent.Size = new System.Drawing.Size(904, 594);
            this.pnlRecent.TabIndex = 1;
            // 
            // dgvRecentActivities
            // 
            this.dgvRecentActivities.AllowUserToAddRows = false;
            this.dgvRecentActivities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRecentActivities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(132)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecentActivities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRecentActivities.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cairo", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRecentActivities.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRecentActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecentActivities.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecentActivities.Location = new System.Drawing.Point(20, 65);
            this.dgvRecentActivities.Name = "dgvRecentActivities";
            this.dgvRecentActivities.ReadOnly = true;
            this.dgvRecentActivities.RowHeadersVisible = false;
            this.dgvRecentActivities.RowHeadersWidth = 51;
            this.dgvRecentActivities.RowTemplate.Height = 40;
            this.dgvRecentActivities.Size = new System.Drawing.Size(864, 509);
            this.dgvRecentActivities.TabIndex = 2;
            this.dgvRecentActivities.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecentActivities.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Cairo", 11F);
            this.dgvRecentActivities.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRecentActivities.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.dgvRecentActivities.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.dgvRecentActivities.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecentActivities.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRecentActivities.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.dgvRecentActivities.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecentActivities.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold);
            this.dgvRecentActivities.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRecentActivities.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentActivities.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvRecentActivities.ThemeStyle.ReadOnly = true;
            this.dgvRecentActivities.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRecentActivities.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentActivities.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Cairo", 11F);
            this.dgvRecentActivities.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRecentActivities.ThemeStyle.RowsStyle.Height = 40;
            this.dgvRecentActivities.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(245)))), ((int)(((byte)(235)))));
            this.dgvRecentActivities.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(20, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(864, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "آخر عمليات التوزيع";
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.tlpContent);
            this.Controls.Add(this.tlpCards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashBoard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "لوحة التحكم";
            this.tlpCards.ResumeLayout(false);
            this.pnlBeneficiaries.ResumeLayout(false);
            this.pnlBeneficiaries.PerformLayout();
            this.pnlDonations.ResumeLayout(false);
            this.pnlDonations.PerformLayout();
            this.pnlInventory.ResumeLayout(false);
            this.pnlInventory.PerformLayout();
            this.pnlDisbursement.ResumeLayout(false);
            this.pnlDisbursement.PerformLayout();
            this.tlpContent.ResumeLayout(false);
            this.pnlChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics)).EndInit();
            this.pnlRecent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentActivities)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private Guna.UI2.WinForms.Guna2Panel pnlBeneficiaries;
        private System.Windows.Forms.Label lblNumberBeneficiaries;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Panel pnlDonations;
        private System.Windows.Forms.Label lblNumberDonations;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel pnlInventory;
        private System.Windows.Forms.Label lblNumberInventory;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Panel pnlDisbursement;
        private System.Windows.Forms.Label lblNumberDisbursement;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private Guna.UI2.WinForms.Guna2Panel pnlChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel pnlRecent;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRecentActivities;
        private System.Windows.Forms.Label label2;
    }
}

