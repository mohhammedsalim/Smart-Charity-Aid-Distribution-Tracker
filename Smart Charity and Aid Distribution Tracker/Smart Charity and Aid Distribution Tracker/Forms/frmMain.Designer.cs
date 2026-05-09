namespace Smart_Charity_and_Aid_Distribution_Tracker.Forms
{
    partial class frmMain
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
            this.pnlNavbar = new Guna.UI2.WinForms.Guna2Panel();
            this.flpNavButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.btnBeneficiaries = new Guna.UI2.WinForms.Guna2Button();
            this.btnInventory = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonations = new Guna.UI2.WinForms.Guna2Button();
            this.btnDisbursement = new Guna.UI2.WinForms.Guna2Button();
            this.btnReports = new Guna.UI2.WinForms.Guna2Button();
            this.btnDonors = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pnlStatusBar = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlNavbar.SuspendLayout();
            this.flpNavButtons.SuspendLayout();
            this.pnlStatusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.White;
            this.pnlNavbar.Controls.Add(this.flpNavButtons);
            this.pnlNavbar.Controls.Add(this.lblBrand);
            this.pnlNavbar.Controls.Add(this.btnLogout);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnlNavbar.ShadowDecoration.Depth = 5;
            this.pnlNavbar.ShadowDecoration.Enabled = true;
            this.pnlNavbar.Size = new System.Drawing.Size(1600, 70);
            this.pnlNavbar.TabIndex = 0;
            // 
            // flpNavButtons
            // 
            this.flpNavButtons.Controls.Add(this.btnHome);
            this.flpNavButtons.Controls.Add(this.btnBeneficiaries);
            this.flpNavButtons.Controls.Add(this.btnInventory);
            this.flpNavButtons.Controls.Add(this.btnDisbursement);
            this.flpNavButtons.Controls.Add(this.btnReports);
            this.flpNavButtons.Controls.Add(this.btnDonors);
            this.flpNavButtons.Controls.Add(this.btnUsers);
            this.flpNavButtons.Controls.Add(this.btnDonations);
            this.flpNavButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpNavButtons.Location = new System.Drawing.Point(0, 0);
            this.flpNavButtons.Name = "flpNavButtons";
            this.flpNavButtons.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flpNavButtons.Size = new System.Drawing.Size(1294, 70);
            this.flpNavButtons.TabIndex = 10;
            // 
            // btnHome
            // 
            this.btnHome.BorderRadius = 8;
            this.btnHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnHome.Font = new System.Drawing.Font("Cairo", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(1175, 18);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 40);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "الرئيسية";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnBeneficiaries
            // 
            this.btnBeneficiaries.BorderRadius = 8;
            this.btnBeneficiaries.FillColor = System.Drawing.Color.Transparent;
            this.btnBeneficiaries.Font = new System.Drawing.Font("Cairo", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnBeneficiaries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnBeneficiaries.Location = new System.Drawing.Point(1013, 18);
            this.btnBeneficiaries.Name = "btnBeneficiaries";
            this.btnBeneficiaries.Size = new System.Drawing.Size(149, 40);
            this.btnBeneficiaries.TabIndex = 2;
            this.btnBeneficiaries.Text = "المستفيدون";
            this.btnBeneficiaries.Click += new System.EventHandler(this.btnBeneficiaries_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BorderRadius = 8;
            this.btnInventory.FillColor = System.Drawing.Color.Transparent;
            this.btnInventory.Font = new System.Drawing.Font("Cairo", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnInventory.Location = new System.Drawing.Point(894, 18);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(113, 40);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "المخزون";
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnDonations
            // 
            this.btnDonations.BorderRadius = 8;
            this.btnDonations.FillColor = System.Drawing.Color.Transparent;
            this.btnDonations.Font = new System.Drawing.Font("Cairo", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDonations.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDonations.Location = new System.Drawing.Point(202, 18);
            this.btnDonations.Name = "btnDonations";
            this.btnDonations.Size = new System.Drawing.Size(113, 40);
            this.btnDonations.TabIndex = 4;
            this.btnDonations.Text = "التبرعات";
            this.btnDonations.Click += new System.EventHandler(this.btnDonations_Click);
            // 
            // btnDisbursement
            // 
            this.btnDisbursement.BorderRadius = 8;
            this.btnDisbursement.FillColor = System.Drawing.Color.Transparent;
            this.btnDisbursement.Font = new System.Drawing.Font("Cairo", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDisbursement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDisbursement.Location = new System.Drawing.Point(725, 18);
            this.btnDisbursement.Name = "btnDisbursement";
            this.btnDisbursement.Size = new System.Drawing.Size(163, 40);
            this.btnDisbursement.TabIndex = 5;
            this.btnDisbursement.Text = "عمليات الصرف";
            this.btnDisbursement.Click += new System.EventHandler(this.btnDisbursement_Click);
            // 
            // btnReports
            // 
            this.btnReports.BorderRadius = 8;
            this.btnReports.FillColor = System.Drawing.Color.Transparent;
            this.btnReports.Font = new System.Drawing.Font("Cairo", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnReports.Location = new System.Drawing.Point(607, 18);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(112, 40);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "التقارير";
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnDonors
            // 
            this.btnDonors.BorderRadius = 8;
            this.btnDonors.FillColor = System.Drawing.Color.Transparent;
            this.btnDonors.Font = new System.Drawing.Font("Cairo", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDonors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnDonors.Location = new System.Drawing.Point(501, 18);
            this.btnDonors.Name = "btnDonors";
            this.btnDonors.Size = new System.Drawing.Size(100, 40);
            this.btnDonors.TabIndex = 7;
            this.btnDonors.Text = "المتبرعين";
            this.btnDonors.Click += new System.EventHandler(this.btnDonors_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BorderRadius = 8;
            this.btnUsers.FillColor = System.Drawing.Color.Transparent;
            this.btnUsers.Font = new System.Drawing.Font("Cairo", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnUsers.Location = new System.Drawing.Point(321, 18);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(174, 40);
            this.btnUsers.TabIndex = 8;
            this.btnUsers.Text = "المستخدمون";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBrand.Font = new System.Drawing.Font("Cairo", 14F, System.Drawing.FontStyle.Bold);
            this.lblBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblBrand.Location = new System.Drawing.Point(1294, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(306, 70);
            this.lblBrand.TabIndex = 0;
            this.lblBrand.Text = "🌿 نظام سند الخيري";
            this.lblBrand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.BorderRadius = 8;
            this.btnLogout.BorderThickness = 1;
            this.btnLogout.FillColor = System.Drawing.Color.White;
            this.btnLogout.Font = new System.Drawing.Font("Cairo", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.Location = new System.Drawing.Point(20, 15);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "تسجيل الخروج";
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlStatusBar
            // 
            this.pnlStatusBar.BackColor = System.Drawing.Color.White;
            this.pnlStatusBar.Controls.Add(this.lblUserName);
            this.pnlStatusBar.Controls.Add(this.label3);
            this.pnlStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlStatusBar.Location = new System.Drawing.Point(0, 850);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.ShadowDecoration.Color = System.Drawing.Color.Gray;
            this.pnlStatusBar.ShadowDecoration.Depth = 5;
            this.pnlStatusBar.ShadowDecoration.Enabled = true;
            this.pnlStatusBar.Size = new System.Drawing.Size(1600, 40);
            this.pnlStatusBar.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Cairo", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblUserName.Location = new System.Drawing.Point(1350, 7);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(37, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "----";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(1420, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "المستخدم الحالي :";
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 70);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1600, 780);
            this.pnlContainer.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 890);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlStatusBar);
            this.Controls.Add(this.pnlNavbar);
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نظام سند الخيري - الشاشة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlNavbar.ResumeLayout(false);
            this.flpNavButtons.ResumeLayout(false);
            this.pnlStatusBar.ResumeLayout(false);
            this.pnlStatusBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlNavbar;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.FlowLayoutPanel flpNavButtons;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnBeneficiaries;
        private Guna.UI2.WinForms.Guna2Button btnInventory;
        private Guna.UI2.WinForms.Guna2Button btnDonations;
        private Guna.UI2.WinForms.Guna2Button btnDisbursement;
        private Guna.UI2.WinForms.Guna2Button btnReports;
        private Guna.UI2.WinForms.Guna2Button btnDonors;
        private Guna.UI2.WinForms.Guna2Button btnUsers;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel pnlStatusBar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlContainer;
    }
}
