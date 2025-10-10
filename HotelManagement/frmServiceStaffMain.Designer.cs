namespace HotelManagement
{
    partial class frmServiceStaffMain
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
            this.btnRoomMonitoring = new Guna.UI.WinForms.GunaButton();
            this.btnServiceProvision = new Guna.UI.WinForms.GunaButton();
            this.btnServiceCRUD = new Guna.UI.WinForms.GunaButton();
            this.btnServiceManagement = new Guna.UI.WinForms.GunaButton();
            this.lblStaffInfo = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlMainContent = new Guna.UI.WinForms.GunaPanel();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnRoomMonitoring);
            this.pnlSidebar.Controls.Add(this.btnServiceProvision);
            this.pnlSidebar.Controls.Add(this.btnServiceCRUD);
            this.pnlSidebar.Controls.Add(this.btnServiceManagement);
            this.pnlSidebar.Controls.Add(this.lblStaffInfo);
            this.pnlSidebar.Controls.Add(this.lblWelcome);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(333, 985);
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
            this.btnLogout.Location = new System.Drawing.Point(27, 886);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(280, 62);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRoomMonitoring
            // 
            this.btnRoomMonitoring.AnimationHoverSpeed = 0.07F;
            this.btnRoomMonitoring.AnimationSpeed = 0.03F;
            this.btnRoomMonitoring.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnRoomMonitoring.BorderColor = System.Drawing.Color.Black;
            this.btnRoomMonitoring.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRoomMonitoring.FocusedColor = System.Drawing.Color.Empty;
            this.btnRoomMonitoring.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRoomMonitoring.ForeColor = System.Drawing.Color.White;
            this.btnRoomMonitoring.Image = null;
            this.btnRoomMonitoring.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRoomMonitoring.Location = new System.Drawing.Point(27, 443);
            this.btnRoomMonitoring.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRoomMonitoring.Name = "btnRoomMonitoring";
            this.btnRoomMonitoring.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnRoomMonitoring.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRoomMonitoring.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRoomMonitoring.OnHoverImage = null;
            this.btnRoomMonitoring.OnPressedColor = System.Drawing.Color.Black;
            this.btnRoomMonitoring.Size = new System.Drawing.Size(280, 62);
            this.btnRoomMonitoring.TabIndex = 3;
            this.btnRoomMonitoring.Text = "Theo dõi Phòng";
            this.btnRoomMonitoring.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRoomMonitoring.Click += new System.EventHandler(this.btnRoomMonitoring_Click);
            // 
            // btnServiceProvision
            // 
            this.btnServiceProvision.AnimationHoverSpeed = 0.07F;
            this.btnServiceProvision.AnimationSpeed = 0.03F;
            this.btnServiceProvision.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnServiceProvision.BorderColor = System.Drawing.Color.Black;
            this.btnServiceProvision.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnServiceProvision.FocusedColor = System.Drawing.Color.Empty;
            this.btnServiceProvision.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnServiceProvision.ForeColor = System.Drawing.Color.White;
            this.btnServiceProvision.Image = null;
            this.btnServiceProvision.ImageSize = new System.Drawing.Size(20, 20);
            this.btnServiceProvision.Location = new System.Drawing.Point(27, 357);
            this.btnServiceProvision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServiceProvision.Name = "btnServiceProvision";
            this.btnServiceProvision.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnServiceProvision.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnServiceProvision.OnHoverForeColor = System.Drawing.Color.White;
            this.btnServiceProvision.OnHoverImage = null;
            this.btnServiceProvision.OnPressedColor = System.Drawing.Color.Black;
            this.btnServiceProvision.Size = new System.Drawing.Size(280, 62);
            this.btnServiceProvision.TabIndex = 2;
            this.btnServiceProvision.Text = "Cung cấp Dịch vụ";
            this.btnServiceProvision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnServiceProvision.Click += new System.EventHandler(this.btnServiceProvision_Click);
            // 
            // btnServiceCRUD
            // 
            this.btnServiceCRUD.AnimationHoverSpeed = 0.07F;
            this.btnServiceCRUD.AnimationSpeed = 0.03F;
            this.btnServiceCRUD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnServiceCRUD.BorderColor = System.Drawing.Color.Black;
            this.btnServiceCRUD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnServiceCRUD.FocusedColor = System.Drawing.Color.Empty;
            this.btnServiceCRUD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnServiceCRUD.ForeColor = System.Drawing.Color.White;
            this.btnServiceCRUD.Image = null;
            this.btnServiceCRUD.ImageSize = new System.Drawing.Size(20, 20);
            this.btnServiceCRUD.Location = new System.Drawing.Point(27, 271);
            this.btnServiceCRUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServiceCRUD.Name = "btnServiceCRUD";
            this.btnServiceCRUD.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnServiceCRUD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnServiceCRUD.OnHoverForeColor = System.Drawing.Color.White;
            this.btnServiceCRUD.OnHoverImage = null;
            this.btnServiceCRUD.OnPressedColor = System.Drawing.Color.Black;
            this.btnServiceCRUD.Size = new System.Drawing.Size(280, 62);
            this.btnServiceCRUD.TabIndex = 1;
            this.btnServiceCRUD.Text = "Thêm/Sửa Dịch vụ";
            this.btnServiceCRUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnServiceCRUD.Click += new System.EventHandler(this.btnServiceCRUD_Click);
            // 
            // btnServiceManagement
            // 
            this.btnServiceManagement.AnimationHoverSpeed = 0.07F;
            this.btnServiceManagement.AnimationSpeed = 0.03F;
            this.btnServiceManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnServiceManagement.BorderColor = System.Drawing.Color.Black;
            this.btnServiceManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnServiceManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnServiceManagement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnServiceManagement.ForeColor = System.Drawing.Color.White;
            this.btnServiceManagement.Image = null;
            this.btnServiceManagement.ImageSize = new System.Drawing.Size(20, 20);
            this.btnServiceManagement.Location = new System.Drawing.Point(27, 185);
            this.btnServiceManagement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnServiceManagement.Name = "btnServiceManagement";
            this.btnServiceManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnServiceManagement.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnServiceManagement.OnHoverForeColor = System.Drawing.Color.White;
            this.btnServiceManagement.OnHoverImage = null;
            this.btnServiceManagement.OnPressedColor = System.Drawing.Color.Black;
            this.btnServiceManagement.Size = new System.Drawing.Size(280, 62);
            this.btnServiceManagement.TabIndex = 0;
            this.btnServiceManagement.Text = "Quản lý Dịch vụ";
            this.btnServiceManagement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnServiceManagement.Click += new System.EventHandler(this.btnServiceManagement_Click);
            // 
            // lblStaffInfo
            // 
            this.lblStaffInfo.AutoSize = true;
            this.lblStaffInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblStaffInfo.ForeColor = System.Drawing.Color.White;
            this.lblStaffInfo.Location = new System.Drawing.Point(27, 74);
            this.lblStaffInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaffInfo.Name = "lblStaffInfo";
            this.lblStaffInfo.Size = new System.Drawing.Size(170, 28);
            this.lblStaffInfo.TabIndex = 1;
            this.lblStaffInfo.Text = "Nhân viên Dịch vụ";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(27, 25);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(174, 37);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Chào mừng!";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(333, 0);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(1267, 985);
            this.pnlMainContent.TabIndex = 1;
            // 
            // frmServiceStaffMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1600, 985);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmServiceStaffMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Khách sạn - Nhân viên Dịch vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmServiceStaffMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnlSidebar;
        private Guna.UI.WinForms.GunaPanel pnlMainContent;
        private Guna.UI.WinForms.GunaButton btnServiceManagement;
        private Guna.UI.WinForms.GunaButton btnServiceCRUD;
        private Guna.UI.WinForms.GunaButton btnServiceProvision;
        private Guna.UI.WinForms.GunaButton btnRoomMonitoring;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblStaffInfo;
    }
}