namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnBackToDashBoard = new Guna.UI2.WinForms.Guna2Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvDonationsList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.cmbSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlSmart = new System.Windows.Forms.Panel();
            this.pnlInputs = new System.Windows.Forms.Panel();
            this.txtNotes = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNotes = new System.Windows.Forms.Label();
            this.txtAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.cmbItem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.cmbDonationType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelDonationType = new System.Windows.Forms.Label();
            this.cmbDonor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.labelDonor = new System.Windows.Forms.Label();
            this.pnlView = new System.Windows.Forms.Panel();
            this.lblNotesText = new System.Windows.Forms.Label();
            this.labelNotesView = new System.Windows.Forms.Label();
            this.lblAmountText = new System.Windows.Forms.Label();
            this.labelAmountView = new System.Windows.Forms.Label();
            this.lblQuantityText = new System.Windows.Forms.Label();
            this.labelQuantityView = new System.Windows.Forms.Label();
            this.lblItemText = new System.Windows.Forms.Label();
            this.labelItemView = new System.Windows.Forms.Label();
            this.lblDonationTypeText = new System.Windows.Forms.Label();
            this.labelDonationTypeView = new System.Windows.Forms.Label();
            this.lblDonorText = new System.Windows.Forms.Label();
            this.labelDonorView = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationsList)).BeginInit();
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
            this.lblFormTitle.Size = new System.Drawing.Size(145, 29);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "استلام التبرعات";
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgvDonationsList);
            this.pnlBody.Controls.Add(this.pnlSearch);
            this.pnlBody.Controls.Add(this.pnlSmart);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 60);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(10);
            this.pnlBody.Size = new System.Drawing.Size(1200, 661);
            this.pnlBody.TabIndex = 1;
            // 
            // dgvDonationsList
            // 
            this.dgvDonationsList.AllowUserToAddRows = false;
            this.dgvDonationsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDonationsList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonationsList.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonationsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonationsList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonationsList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonationsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonationsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDonationsList.Location = new System.Drawing.Point(440, 70);
            this.dgvDonationsList.MultiSelect = false;
            this.dgvDonationsList.Name = "dgvDonationsList";
            this.dgvDonationsList.ReadOnly = true;
            this.dgvDonationsList.RowHeadersVisible = false;
            this.dgvDonationsList.RowTemplate.Height = 30;
            this.dgvDonationsList.Size = new System.Drawing.Size(750, 581);
            this.dgvDonationsList.TabIndex = 2;
            this.dgvDonationsList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDonationsList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.dgvDonationsList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
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
            this.pnlInputs.Controls.Add(this.txtNotes);
            this.pnlInputs.Controls.Add(this.labelNotes);
            this.pnlInputs.Controls.Add(this.txtAmount);
            this.pnlInputs.Controls.Add(this.labelAmount);
            this.pnlInputs.Controls.Add(this.txtQuantity);
            this.pnlInputs.Controls.Add(this.labelQuantity);
            this.pnlInputs.Controls.Add(this.cmbItem);
            this.pnlInputs.Controls.Add(this.labelItem);
            this.pnlInputs.Controls.Add(this.cmbDonationType);
            this.pnlInputs.Controls.Add(this.labelDonationType);
            this.pnlInputs.Controls.Add(this.cmbDonor);
            this.pnlInputs.Controls.Add(this.labelDonor);
            this.pnlInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInputs.Location = new System.Drawing.Point(0, 40);
            this.pnlInputs.Name = "pnlInputs";
            this.pnlInputs.Size = new System.Drawing.Size(430, 471);
            this.pnlInputs.TabIndex = 3;
            // 
            // txtNotes
            // 
            this.txtNotes.BorderRadius = 6;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.DefaultText = "";
            this.txtNotes.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtNotes.Location = new System.Drawing.Point(32, 410);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.PlaceholderText = "ملاحظات إضافية...";
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(366, 60);
            this.txtNotes.TabIndex = 11;
            // 
            // labelNotes
            // 
            this.labelNotes.AutoSize = true;
            this.labelNotes.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelNotes.Location = new System.Drawing.Point(341, 388);
            this.labelNotes.Name = "labelNotes";
            this.labelNotes.Size = new System.Drawing.Size(57, 18);
            this.labelNotes.TabIndex = 10;
            this.labelNotes.Text = "ملاحظات";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderRadius = 6;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.DefaultText = "";
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtAmount.Location = new System.Drawing.Point(32, 340);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.PlaceholderText = "المبلغ النقدي...";
            this.txtAmount.SelectedText = "";
            this.txtAmount.Size = new System.Drawing.Size(366, 40);
            this.txtAmount.TabIndex = 9;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelAmount.Location = new System.Drawing.Point(356, 318);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(42, 18);
            this.labelAmount.TabIndex = 8;
            this.labelAmount.Text = "المبلغ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderRadius = 6;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtQuantity.Location = new System.Drawing.Point(32, 270);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "الكمية العينية...";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(366, 40);
            this.txtQuantity.TabIndex = 7;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelQuantity.Location = new System.Drawing.Point(354, 248);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(44, 18);
            this.labelQuantity.TabIndex = 6;
            this.labelQuantity.Text = "الكمية";
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.Transparent;
            this.cmbItem.BorderRadius = 6;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbItem.ItemHeight = 34;
            this.cmbItem.Location = new System.Drawing.Point(32, 200);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(366, 40);
            this.cmbItem.TabIndex = 5;
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelItem.Location = new System.Drawing.Point(356, 178);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(42, 18);
            this.labelItem.TabIndex = 4;
            this.labelItem.Text = "الصنف";
            // 
            // cmbDonationType
            // 
            this.cmbDonationType.BackColor = System.Drawing.Color.Transparent;
            this.cmbDonationType.BorderRadius = 6;
            this.cmbDonationType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDonationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonationType.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbDonationType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDonationType.ItemHeight = 34;
            this.cmbDonationType.Location = new System.Drawing.Point(32, 130);
            this.cmbDonationType.Name = "cmbDonationType";
            this.cmbDonationType.Size = new System.Drawing.Size(366, 40);
            this.cmbDonationType.TabIndex = 3;
            // 
            // labelDonationType
            // 
            this.labelDonationType.AutoSize = true;
            this.labelDonationType.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelDonationType.Location = new System.Drawing.Point(326, 108);
            this.labelDonationType.Name = "labelDonationType";
            this.labelDonationType.Size = new System.Drawing.Size(72, 18);
            this.labelDonationType.TabIndex = 2;
            this.labelDonationType.Text = "نوع التبرع";
            // 
            // cmbDonor
            // 
            this.cmbDonor.BackColor = System.Drawing.Color.Transparent;
            this.cmbDonor.BorderRadius = 6;
            this.cmbDonor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDonor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDonor.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.cmbDonor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDonor.ItemHeight = 34;
            this.cmbDonor.Location = new System.Drawing.Point(32, 60);
            this.cmbDonor.Name = "cmbDonor";
            this.cmbDonor.Size = new System.Drawing.Size(366, 40);
            this.cmbDonor.TabIndex = 1;
            // 
            // labelDonor
            // 
            this.labelDonor.AutoSize = true;
            this.labelDonor.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelDonor.Location = new System.Drawing.Point(351, 38);
            this.labelDonor.Name = "labelDonor";
            this.labelDonor.Size = new System.Drawing.Size(47, 18);
            this.labelDonor.TabIndex = 0;
            this.labelDonor.Text = "المتبرع";
            // 
            // pnlView
            // 
            this.pnlView.AutoScroll = true;
            this.pnlView.Controls.Add(this.lblNotesText);
            this.pnlView.Controls.Add(this.labelNotesView);
            this.pnlView.Controls.Add(this.lblAmountText);
            this.pnlView.Controls.Add(this.labelAmountView);
            this.pnlView.Controls.Add(this.lblQuantityText);
            this.pnlView.Controls.Add(this.labelQuantityView);
            this.pnlView.Controls.Add(this.lblItemText);
            this.pnlView.Controls.Add(this.labelItemView);
            this.pnlView.Controls.Add(this.lblDonationTypeText);
            this.pnlView.Controls.Add(this.labelDonationTypeView);
            this.pnlView.Controls.Add(this.lblDonorText);
            this.pnlView.Controls.Add(this.labelDonorView);
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 40);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(430, 471);
            this.pnlView.TabIndex = 4;
            // 
            // lblNotesText
            // 
            this.lblNotesText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblNotesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNotesText.Location = new System.Drawing.Point(32, 350);
            this.lblNotesText.Name = "lblNotesText";
            this.lblNotesText.Size = new System.Drawing.Size(366, 60);
            this.lblNotesText.TabIndex = 11;
            this.lblNotesText.Text = "----";
            // 
            // labelNotesView
            // 
            this.labelNotesView.AutoSize = true;
            this.labelNotesView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelNotesView.Location = new System.Drawing.Point(341, 328);
            this.labelNotesView.Name = "labelNotesView";
            this.labelNotesView.Size = new System.Drawing.Size(57, 18);
            this.labelNotesView.TabIndex = 10;
            this.labelNotesView.Text = "ملاحظات";
            // 
            // lblAmountText
            // 
            this.lblAmountText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblAmountText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAmountText.Location = new System.Drawing.Point(32, 280);
            this.lblAmountText.Name = "lblAmountText";
            this.lblAmountText.Size = new System.Drawing.Size(366, 23);
            this.lblAmountText.TabIndex = 9;
            this.lblAmountText.Text = "----";
            // 
            // labelAmountView
            // 
            this.labelAmountView.AutoSize = true;
            this.labelAmountView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelAmountView.Location = new System.Drawing.Point(356, 258);
            this.labelAmountView.Name = "labelAmountView";
            this.labelAmountView.Size = new System.Drawing.Size(42, 18);
            this.labelAmountView.TabIndex = 8;
            this.labelAmountView.Text = "المبلغ";
            // 
            // lblQuantityText
            // 
            this.lblQuantityText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuantityText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuantityText.Location = new System.Drawing.Point(32, 210);
            this.lblQuantityText.Name = "lblQuantityText";
            this.lblQuantityText.Size = new System.Drawing.Size(366, 23);
            this.lblQuantityText.TabIndex = 7;
            this.lblQuantityText.Text = "----";
            // 
            // labelQuantityView
            // 
            this.labelQuantityView.AutoSize = true;
            this.labelQuantityView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelQuantityView.Location = new System.Drawing.Point(354, 188);
            this.labelQuantityView.Name = "labelQuantityView";
            this.labelQuantityView.Size = new System.Drawing.Size(44, 18);
            this.labelQuantityView.TabIndex = 6;
            this.labelQuantityView.Text = "الكمية";
            // 
            // lblItemText
            // 
            this.lblItemText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblItemText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblItemText.Location = new System.Drawing.Point(32, 140);
            this.lblItemText.Name = "lblItemText";
            this.lblItemText.Size = new System.Drawing.Size(366, 23);
            this.lblItemText.TabIndex = 5;
            this.lblItemText.Text = "----";
            // 
            // labelItemView
            // 
            this.labelItemView.AutoSize = true;
            this.labelItemView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelItemView.Location = new System.Drawing.Point(356, 118);
            this.labelItemView.Name = "labelItemView";
            this.labelItemView.Size = new System.Drawing.Size(42, 18);
            this.labelItemView.TabIndex = 4;
            this.labelItemView.Text = "الصنف";
            // 
            // lblDonationTypeText
            // 
            this.lblDonationTypeText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDonationTypeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDonationTypeText.Location = new System.Drawing.Point(32, 70);
            this.lblDonationTypeText.Name = "lblDonationTypeText";
            this.lblDonationTypeText.Size = new System.Drawing.Size(366, 23);
            this.lblDonationTypeText.TabIndex = 3;
            this.lblDonationTypeText.Text = "----";
            // 
            // labelDonationTypeView
            // 
            this.labelDonationTypeView.AutoSize = true;
            this.labelDonationTypeView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelDonationTypeView.Location = new System.Drawing.Point(326, 48);
            this.labelDonationTypeView.Name = "labelDonationTypeView";
            this.labelDonationTypeView.Size = new System.Drawing.Size(72, 18);
            this.labelDonationTypeView.TabIndex = 2;
            this.labelDonationTypeView.Text = "نوع التبرع";
            // 
            // lblDonorText
            // 
            this.lblDonorText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblDonorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDonorText.Location = new System.Drawing.Point(32, 0);
            this.lblDonorText.Name = "lblDonorText";
            this.lblDonorText.Size = new System.Drawing.Size(366, 23);
            this.lblDonorText.TabIndex = 1;
            this.lblDonorText.Text = "----";
            // 
            // labelDonorView
            // 
            this.labelDonorView.AutoSize = true;
            this.labelDonorView.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.labelDonorView.Location = new System.Drawing.Point(351, -22);
            this.labelDonorView.Name = "labelDonorView";
            this.labelDonorView.Size = new System.Drawing.Size(47, 18);
            this.labelDonorView.TabIndex = 0;
            this.labelDonorView.Text = "المتبرع";
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
            this.lblPanelTitle.Text = "تفاصيل التبرع";
            this.lblPanelTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this.pnlSmart;
            // 
            // frmDonations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1200, 721);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmDonations";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "استلام التبرعات - نظام سند";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonationsList)).EndInit();
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
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonationsList;
        private System.Windows.Forms.Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSearch;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.Panel pnlSmart;
        private System.Windows.Forms.Panel pnlInputs;
        private Guna.UI2.WinForms.Guna2TextBox txtNotes;
        private System.Windows.Forms.Label labelNotes;
        private Guna.UI2.WinForms.Guna2TextBox txtAmount;
        private System.Windows.Forms.Label labelAmount;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private Guna.UI2.WinForms.Guna2ComboBox cmbItem;
        private System.Windows.Forms.Label labelItem;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDonationType;
        private System.Windows.Forms.Label labelDonationType;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDonor;
        private System.Windows.Forms.Label labelDonor;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Label lblNotesText;
        private System.Windows.Forms.Label labelNotesView;
        private System.Windows.Forms.Label lblAmountText;
        private System.Windows.Forms.Label labelAmountView;
        private System.Windows.Forms.Label lblQuantityText;
        private System.Windows.Forms.Label labelQuantityView;
        private System.Windows.Forms.Label lblItemText;
        private System.Windows.Forms.Label labelItemView;
        private System.Windows.Forms.Label lblDonationTypeText;
        private System.Windows.Forms.Label labelDonationTypeView;
        private System.Windows.Forms.Label lblDonorText;
        private System.Windows.Forms.Label labelDonorView;
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
