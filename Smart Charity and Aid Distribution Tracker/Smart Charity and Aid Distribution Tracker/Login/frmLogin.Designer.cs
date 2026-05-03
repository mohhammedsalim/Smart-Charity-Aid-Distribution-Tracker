namespace Smart_Charity_and_Aid_Distribution_Tracker
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.guna2PanelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PanelCard = new Guna.UI2.WinForms.Guna2Panel();
            this.picFront = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblSanadSystem = new System.Windows.Forms.Label();
            this.lblDis = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblShowPass = new System.Windows.Forms.Label();
            this.chbShowPassword = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PanelMain.SuspendLayout();
            this.guna2PanelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFront)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelMain
            // 
            this.guna2PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelMain.BorderRadius = 20;
            this.guna2PanelMain.Controls.Add(this.guna2PanelCard);
            this.guna2PanelMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.guna2PanelMain.Location = new System.Drawing.Point(0, 0);
            this.guna2PanelMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PanelMain.Name = "guna2PanelMain";
            this.guna2PanelMain.Size = new System.Drawing.Size(518, 775);
            this.guna2PanelMain.TabIndex = 0;
            // 
            // guna2PanelCard
            // 
            this.guna2PanelCard.BackColor = System.Drawing.Color.Transparent;
            this.guna2PanelCard.BorderRadius = 24;
            this.guna2PanelCard.Controls.Add(this.picFront);
            this.guna2PanelCard.Controls.Add(this.lblSanadSystem);
            this.guna2PanelCard.Controls.Add(this.lblDis);
            this.guna2PanelCard.Controls.Add(this.lblUserName);
            this.guna2PanelCard.Controls.Add(this.txtUserName);
            this.guna2PanelCard.Controls.Add(this.lblPassword);
            this.guna2PanelCard.Controls.Add(this.txtPassword);
            this.guna2PanelCard.Controls.Add(this.lblShowPass);
            this.guna2PanelCard.Controls.Add(this.chbShowPassword);
            this.guna2PanelCard.Controls.Add(this.btnLogin);
            this.guna2PanelCard.Controls.Add(this.btnExit);
            this.guna2PanelCard.FillColor = System.Drawing.Color.White;
            this.guna2PanelCard.Location = new System.Drawing.Point(12, 13);
            this.guna2PanelCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PanelCard.Name = "guna2PanelCard";
            this.guna2PanelCard.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.guna2PanelCard.ShadowDecoration.Depth = 20;
            this.guna2PanelCard.ShadowDecoration.Enabled = true;
            this.guna2PanelCard.Size = new System.Drawing.Size(494, 749);
            this.guna2PanelCard.TabIndex = 1;
            // 
            // picFront
            // 
            this.picFront.BorderRadius = 50;
            this.picFront.Image = ((System.Drawing.Image)(resources.GetObject("picFront.Image")));
            this.picFront.ImageRotate = 0F;
            this.picFront.Location = new System.Drawing.Point(189, 35);
            this.picFront.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picFront.Name = "picFront";
            this.picFront.Size = new System.Drawing.Size(112, 125);
            this.picFront.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFront.TabIndex = 0;
            this.picFront.TabStop = false;
            // 
            // lblSanadSystem
            // 
            this.lblSanadSystem.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.lblSanadSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(20)))));
            this.lblSanadSystem.Location = new System.Drawing.Point(133, 164);
            this.lblSanadSystem.Name = "lblSanadSystem";
            this.lblSanadSystem.Size = new System.Drawing.Size(225, 55);
            this.lblSanadSystem.TabIndex = 1;
            this.lblSanadSystem.Text = "نظام سند";
            this.lblSanadSystem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDis
            // 
            this.lblDis.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblDis.Location = new System.Drawing.Point(103, 219);
            this.lblDis.Name = "lblDis";
            this.lblDis.Size = new System.Drawing.Size(270, 35);
            this.lblDis.TabIndex = 2;
            this.lblDis.Text = "لإدارة الجمعيات الخيرية";
            this.lblDis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblUserName.Location = new System.Drawing.Point(76, 272);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(382, 32);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "اسم المستخدم";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.White;
            this.txtUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.txtUserName.BorderRadius = 10;
            this.txtUserName.BorderThickness = 2;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtUserName.Location = new System.Drawing.Point(37, 310);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PlaceholderText = "أدخل اسم المستخدم";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(421, 52);
            this.txtUserName.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblPassword.Location = new System.Drawing.Point(76, 378);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(382, 32);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "كلمة المرور";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(180)))));
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(253)))), ((int)(((byte)(248)))));
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtPassword.Location = new System.Drawing.Point(37, 415);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "أدخل كلمة المرور";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(421, 52);
            this.txtPassword.TabIndex = 6;
            // 
            // lblShowPass
            // 
            this.lblShowPass.AutoSize = true;
            this.lblShowPass.Font = new System.Drawing.Font("Calibri", 10F);
            this.lblShowPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lblShowPass.Location = new System.Drawing.Point(313, 495);
            this.lblShowPass.Name = "lblShowPass";
            this.lblShowPass.Size = new System.Drawing.Size(125, 24);
            this.lblShowPass.TabIndex = 8;
            this.lblShowPass.Text = "إظهار كلمة المرور";
            // 
            // chbShowPassword
            // 
            this.chbShowPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.chbShowPassword.Location = new System.Drawing.Point(84, 488);
            this.chbShowPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chbShowPassword.Name = "chbShowPassword";
            this.chbShowPassword.Size = new System.Drawing.Size(70, 38);
            this.chbShowPassword.TabIndex = 7;
            this.chbShowPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 12;
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(139)))), ((int)(((byte)(34)))));
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(115)))), ((int)(((byte)(28)))));
            this.btnLogin.Location = new System.Drawing.Point(37, 548);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(421, 58);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "تسجيل الدخول";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnExit.BorderRadius = 12;
            this.btnExit.BorderThickness = 2;
            this.btnExit.FillColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.btnExit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(37, 618);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(421, 58);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(248)))), ((int)(((byte)(235)))));
            this.ClientSize = new System.Drawing.Size(518, 775);
            this.Controls.Add(this.guna2PanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.guna2PanelMain.ResumeLayout(false);
            this.guna2PanelCard.ResumeLayout(false);
            this.guna2PanelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFront)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelMain;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelCard;
        private Guna.UI2.WinForms.Guna2PictureBox picFront;
        private System.Windows.Forms.Label lblSanadSystem;
        private System.Windows.Forms.Label lblDis;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label lblShowPass;
        private Guna.UI2.WinForms.Guna2ToggleSwitch chbShowPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnExit;
    }
}