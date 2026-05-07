namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    partial class frmDashBoard
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
            this.pnlNavbar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDonors = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnDisbursement = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonations = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.btnBeneficiaries = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlUserAndTime = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pnlNavbar.SuspendLayout();
            this.pnlUserAndTime.SuspendLayout();
            this.pnlBeneficiaries.SuspendLayout();
            this.pnlDonations.SuspendLayout();
            this.pnlInventory.SuspendLayout();
            this.pnlDisbursement.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.White;
            this.pnlNavbar.Controls.Add(this.btnDonors);
            this.pnlNavbar.Controls.Add(this.btnLogout);
            this.pnlNavbar.Controls.Add(this.btnUsers);
            this.pnlNavbar.Controls.Add(this.btnReports);
            this.pnlNavbar.Controls.Add(this.btnDisbursement);
            this.pnlNavbar.Controls.Add(this.btnDonations);
            this.pnlNavbar.Controls.Add(this.btnInventory);
            this.pnlNavbar.Controls.Add(this.btnBeneficiaries);
            this.pnlNavbar.Controls.Add(this.label1);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(1579, 80);
            this.pnlNavbar.TabIndex = 0;
            // 
            // btnDonors
            // 
            this.btnDonors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonors.BorderRadius = 8;
            this.btnDonors.FillColor = System.Drawing.Color.White;
            this.btnDonors.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDonors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDonors.Location = new System.Drawing.Point(219, 15);
            this.btnDonors.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonors.Name = "btnDonors";
            this.btnDonors.Size = new System.Drawing.Size(160, 49);
            this.btnDonors.TabIndex = 8;
            this.btnDonors.Text = "المتبرعين";
            this.btnDonors.Click += new System.EventHandler(this.btnDonors_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnLogout.Location = new System.Drawing.Point(16, 15);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(187, 49);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "تسجيل الخروج";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsers.BorderRadius = 8;
            this.btnUsers.FillColor = System.Drawing.Color.White;
            this.btnUsers.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsers.Location = new System.Drawing.Point(355, 15);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(160, 49);
            this.btnUsers.TabIndex = 6;
            this.btnUsers.Text = "المستخدمون";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.BorderRadius = 8;
            this.btnReports.FillColor = System.Drawing.Color.White;
            this.btnReports.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReports.Location = new System.Drawing.Point(523, 15);
            this.btnReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(160, 49);
            this.btnReports.TabIndex = 5;
            this.btnReports.Text = "التقارير";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnDisbursement
            // 
            this.btnDisbursement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisbursement.BorderRadius = 8;
            this.btnDisbursement.FillColor = System.Drawing.Color.White;
            this.btnDisbursement.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDisbursement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDisbursement.Location = new System.Drawing.Point(691, 15);
            this.btnDisbursement.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisbursement.Name = "btnDisbursement";
            this.btnDisbursement.Size = new System.Drawing.Size(160, 49);
            this.btnDisbursement.TabIndex = 4;
            this.btnDisbursement.Text = "عمليات الصرف";
            this.btnDisbursement.Click += new System.EventHandler(this.btnDisbursement_Click);
            // 
            // btnDonations
            // 
            this.btnDonations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDonations.BorderRadius = 8;
            this.btnDonations.FillColor = System.Drawing.Color.White;
            this.btnDonations.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDonations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDonations.Location = new System.Drawing.Point(859, 15);
            this.btnDonations.Margin = new System.Windows.Forms.Padding(4);
            this.btnDonations.Name = "btnDonations";
            this.btnDonations.Size = new System.Drawing.Size(160, 49);
            this.btnDonations.TabIndex = 3;
            this.btnDonations.Text = "التبرعات";
            this.btnDonations.Click += new System.EventHandler(this.btnDonations_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventory.BorderRadius = 8;
            this.btnInventory.FillColor = System.Drawing.Color.White;
            this.btnInventory.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInventory.Location = new System.Drawing.Point(1027, 15);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(160, 49);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "المخزون";
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnBeneficiaries
            // 
            this.btnBeneficiaries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeneficiaries.BorderRadius = 8;
            this.btnBeneficiaries.FillColor = System.Drawing.Color.White;
            this.btnBeneficiaries.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnBeneficiaries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBeneficiaries.Location = new System.Drawing.Point(1195, 15);
            this.btnBeneficiaries.Margin = new System.Windows.Forms.Padding(4);
            this.btnBeneficiaries.Name = "btnBeneficiaries";
            this.btnBeneficiaries.Size = new System.Drawing.Size(160, 49);
            this.btnBeneficiaries.TabIndex = 1;
            this.btnBeneficiaries.Text = "المستفيدون";
            this.btnBeneficiaries.Click += new System.EventHandler(this.btnBeneficiaries_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(1403, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "نظام سند الخيري";
            // 
            // pnlUserAndTime
            // 
            this.pnlUserAndTime.BackColor = System.Drawing.Color.White;
            this.pnlUserAndTime.Controls.Add(this.lblUserName);
            this.pnlUserAndTime.Controls.Add(this.label3);
            this.pnlUserAndTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUserAndTime.Location = new System.Drawing.Point(0, 765);
            this.pnlUserAndTime.Margin = new System.Windows.Forms.Padding(4);
            this.pnlUserAndTime.Name = "pnlUserAndTime";
            this.pnlUserAndTime.Size = new System.Drawing.Size(1579, 49);
            this.pnlUserAndTime.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblUserName.Location = new System.Drawing.Point(1276, 14);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(34, 23);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "----";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(1341, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "المستخدم الحالي :";
            // 
            // pnlBeneficiaries
            // 
            this.pnlBeneficiaries.BackColor = System.Drawing.Color.White;
            this.pnlBeneficiaries.BorderRadius = 12;
            this.pnlBeneficiaries.Controls.Add(this.lblNumberBeneficiaries);
            this.pnlBeneficiaries.Controls.Add(this.label4);
            this.pnlBeneficiaries.Location = new System.Drawing.Point(1176, 123);
            this.pnlBeneficiaries.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBeneficiaries.Name = "pnlBeneficiaries";
            this.pnlBeneficiaries.Size = new System.Drawing.Size(373, 148);
            this.pnlBeneficiaries.TabIndex = 2;
            // 
            // lblNumberBeneficiaries
            // 
            this.lblNumberBeneficiaries.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberBeneficiaries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lblNumberBeneficiaries.Location = new System.Drawing.Point(4, 68);
            this.lblNumberBeneficiaries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberBeneficiaries.Name = "lblNumberBeneficiaries";
            this.lblNumberBeneficiaries.Size = new System.Drawing.Size(365, 48);
            this.lblNumberBeneficiaries.TabIndex = 1;
            this.lblNumberBeneficiaries.Text = "0";
            this.lblNumberBeneficiaries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(189, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "إجمالي المستفيدين";
            // 
            // pnlDonations
            // 
            this.pnlDonations.BackColor = System.Drawing.Color.White;
            this.pnlDonations.BorderRadius = 12;
            this.pnlDonations.Controls.Add(this.lblNumberDonations);
            this.pnlDonations.Controls.Add(this.label6);
            this.pnlDonations.Location = new System.Drawing.Point(795, 123);
            this.pnlDonations.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDonations.Name = "pnlDonations";
            this.pnlDonations.Size = new System.Drawing.Size(373, 148);
            this.pnlDonations.TabIndex = 3;
            // 
            // lblNumberDonations
            // 
            this.lblNumberDonations.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberDonations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.lblNumberDonations.Location = new System.Drawing.Point(4, 68);
            this.lblNumberDonations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberDonations.Name = "lblNumberDonations";
            this.lblNumberDonations.Size = new System.Drawing.Size(365, 48);
            this.lblNumberDonations.TabIndex = 1;
            this.lblNumberDonations.Text = "0";
            this.lblNumberDonations.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(212, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "إجمالي التبرعات";
            // 
            // pnlInventory
            // 
            this.pnlInventory.BackColor = System.Drawing.Color.White;
            this.pnlInventory.BorderRadius = 12;
            this.pnlInventory.Controls.Add(this.lblNumberInventory);
            this.pnlInventory.Controls.Add(this.label8);
            this.pnlInventory.Location = new System.Drawing.Point(413, 123);
            this.pnlInventory.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInventory.Name = "pnlInventory";
            this.pnlInventory.Size = new System.Drawing.Size(373, 148);
            this.pnlInventory.TabIndex = 4;
            // 
            // lblNumberInventory
            // 
            this.lblNumberInventory.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNumberInventory.Location = new System.Drawing.Point(4, 68);
            this.lblNumberInventory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberInventory.Name = "lblNumberInventory";
            this.lblNumberInventory.Size = new System.Drawing.Size(365, 48);
            this.lblNumberInventory.TabIndex = 1;
            this.lblNumberInventory.Text = "0";
            this.lblNumberInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(212, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "أصناف المخزون";
            // 
            // pnlDisbursement
            // 
            this.pnlDisbursement.BackColor = System.Drawing.Color.White;
            this.pnlDisbursement.BorderRadius = 12;
            this.pnlDisbursement.Controls.Add(this.lblNumberDisbursement);
            this.pnlDisbursement.Controls.Add(this.label10);
            this.pnlDisbursement.Location = new System.Drawing.Point(32, 123);
            this.pnlDisbursement.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDisbursement.Name = "pnlDisbursement";
            this.pnlDisbursement.Size = new System.Drawing.Size(373, 148);
            this.pnlDisbursement.TabIndex = 5;
            // 
            // lblNumberDisbursement
            // 
            this.lblNumberDisbursement.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberDisbursement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumberDisbursement.Location = new System.Drawing.Point(4, 68);
            this.lblNumberDisbursement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberDisbursement.Name = "lblNumberDisbursement";
            this.lblNumberDisbursement.Size = new System.Drawing.Size(365, 48);
            this.lblNumberDisbursement.TabIndex = 1;
            this.lblNumberDisbursement.Text = "0";
            this.lblNumberDisbursement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(219, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "عمليات الصرف";
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1579, 814);
            this.Controls.Add(this.pnlDisbursement);
            this.Controls.Add(this.pnlInventory);
            this.Controls.Add(this.pnlDonations);
            this.Controls.Add(this.pnlBeneficiaries);
            this.Controls.Add(this.pnlUserAndTime);
            this.Controls.Add(this.pnlNavbar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashBoard";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لوحة التحكم الرئيسية - نظام سند";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmDashBoard_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDashBoard_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDashBoard_FormClosed);
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.pnlNavbar.ResumeLayout(false);
            this.pnlNavbar.PerformLayout();
            this.pnlUserAndTime.ResumeLayout(false);
            this.pnlUserAndTime.PerformLayout();
            this.pnlBeneficiaries.ResumeLayout(false);
            this.pnlBeneficiaries.PerformLayout();
            this.pnlDonations.ResumeLayout(false);
            this.pnlDonations.PerformLayout();
            this.pnlInventory.ResumeLayout(false);
            this.pnlInventory.PerformLayout();
            this.pnlDisbursement.ResumeLayout(false);
            this.pnlDisbursement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlNavbar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnBeneficiaries;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnDisbursement;
        private Guna.UI2.WinForms.Guna2Button btnDonations;
        private Guna.UI2.WinForms.Guna2Button btnInventory;
        private Guna.UI2.WinForms.Guna2Panel pnlUserAndTime;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label3;
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
        private Guna.UI2.WinForms.Guna2Button btnDonors;
    }
}
