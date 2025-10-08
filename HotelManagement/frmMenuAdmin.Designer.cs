namespace HotelManagement
{
    partial class frmMenuAdmin
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
            this.pnlSidebar = new Guna.UI.WinForms.GunaPanel();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.btnBill = new Guna.UI.WinForms.GunaButton();
            this.btnUseService = new Guna.UI.WinForms.GunaButton();
            this.btnService = new Guna.UI.WinForms.GunaButton();
            this.btnStaff = new Guna.UI.WinForms.GunaButton();
            this.btnAccount = new Guna.UI.WinForms.GunaButton();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlMainContent = new Guna.UI.WinForms.GunaPanel();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnBill);
            this.pnlSidebar.Controls.Add(this.btnUseService);
            this.pnlSidebar.Controls.Add(this.btnService);
            this.pnlSidebar.Controls.Add(this.btnStaff);
            this.pnlSidebar.Controls.Add(this.btnAccount);
            this.pnlSidebar.Controls.Add(this.lblRole);
            this.pnlSidebar.Controls.Add(this.lblWelcome);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 800);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = null;
            this.btnLogout.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogout.Location = new System.Drawing.Point(20, 720);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(210, 50);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBill
            // 
            this.btnBill.AnimationHoverSpeed = 0.07F;
            this.btnBill.AnimationSpeed = 0.03F;
            this.btnBill.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnBill.BorderColor = System.Drawing.Color.Black;
            this.btnBill.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBill.FocusedColor = System.Drawing.Color.Empty;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = null;
            this.btnBill.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBill.Location = new System.Drawing.Point(20, 360);
            this.btnBill.Name = "btnBill";
            this.btnBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBill.OnHoverImage = null;
            this.btnBill.OnPressedColor = System.Drawing.Color.Black;
            this.btnBill.Size = new System.Drawing.Size(210, 50);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "Hóa đơn";
            this.btnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnUseService
            // 
            this.btnUseService.AnimationHoverSpeed = 0.07F;
            this.btnUseService.AnimationSpeed = 0.03F;
            this.btnUseService.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnUseService.BorderColor = System.Drawing.Color.Black;
            this.btnUseService.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUseService.FocusedColor = System.Drawing.Color.Empty;
            this.btnUseService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUseService.ForeColor = System.Drawing.Color.White;
            this.btnUseService.Image = null;
            this.btnUseService.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUseService.Location = new System.Drawing.Point(20, 290);
            this.btnUseService.Name = "btnUseService";
            this.btnUseService.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnUseService.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUseService.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUseService.OnHoverImage = null;
            this.btnUseService.OnPressedColor = System.Drawing.Color.Black;
            this.btnUseService.Size = new System.Drawing.Size(210, 50);
            this.btnUseService.TabIndex = 5;
            this.btnUseService.Text = "Sử dụng dịch vụ";
            this.btnUseService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUseService.Click += new System.EventHandler(this.btnUseService_Click);
            // 
            // btnService
            // 
            this.btnService.AnimationHoverSpeed = 0.07F;
            this.btnService.AnimationSpeed = 0.03F;
            this.btnService.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnService.BorderColor = System.Drawing.Color.Black;
            this.btnService.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnService.FocusedColor = System.Drawing.Color.Empty;
            this.btnService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnService.ForeColor = System.Drawing.Color.White;
            this.btnService.Image = null;
            this.btnService.ImageSize = new System.Drawing.Size(20, 20);
            this.btnService.Location = new System.Drawing.Point(20, 220);
            this.btnService.Name = "btnService";
            this.btnService.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnService.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnService.OnHoverForeColor = System.Drawing.Color.White;
            this.btnService.OnHoverImage = null;
            this.btnService.OnPressedColor = System.Drawing.Color.Black;
            this.btnService.Size = new System.Drawing.Size(210, 50);
            this.btnService.TabIndex = 4;
            this.btnService.Text = "Dịch vụ";
            this.btnService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.AnimationHoverSpeed = 0.07F;
            this.btnStaff.AnimationSpeed = 0.03F;
            this.btnStaff.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnStaff.BorderColor = System.Drawing.Color.Black;
            this.btnStaff.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStaff.FocusedColor = System.Drawing.Color.Empty;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = null;
            this.btnStaff.ImageSize = new System.Drawing.Size(20, 20);
            this.btnStaff.Location = new System.Drawing.Point(20, 150);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnStaff.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStaff.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStaff.OnHoverImage = null;
            this.btnStaff.OnPressedColor = System.Drawing.Color.Black;
            this.btnStaff.Size = new System.Drawing.Size(210, 50);
            this.btnStaff.TabIndex = 3;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.AnimationHoverSpeed = 0.07F;
            this.btnAccount.AnimationSpeed = 0.03F;
            this.btnAccount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.btnAccount.BorderColor = System.Drawing.Color.Black;
            this.btnAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccount.FocusedColor = System.Drawing.Color.Empty;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = null;
            this.btnAccount.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAccount.Location = new System.Drawing.Point(20, 110);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btnAccount.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAccount.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAccount.OnHoverImage = null;
            this.btnAccount.OnPressedColor = System.Drawing.Color.Black;
            this.btnAccount.Size = new System.Drawing.Size(210, 34);
            this.btnAccount.TabIndex = 2;
            this.btnAccount.Text = "Tài khoản";
            this.btnAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(20, 60);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(67, 21);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Quản trị";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(140, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Chào mừng!";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(250, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(950, 800);
            this.pnlMainContent.TabIndex = 1;
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Khách sạn - Quản trị";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnlSidebar;
        private Guna.UI.WinForms.GunaPanel pnlMainContent;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblRole;
        private Guna.UI.WinForms.GunaButton btnAccount;
        private Guna.UI.WinForms.GunaButton btnStaff;
        private Guna.UI.WinForms.GunaButton btnService;
        private Guna.UI.WinForms.GunaButton btnUseService;
        private Guna.UI.WinForms.GunaButton btnBill;
        private Guna.UI.WinForms.GunaButton btnLogout;
    }
}