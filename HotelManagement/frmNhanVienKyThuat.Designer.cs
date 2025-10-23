namespace HotelManagement
{
    partial class frmNhanVienKyThuat
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
            this.components = new System.ComponentModel.Container();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnKhoThietBi = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThayDoiTrangThai = new Guna.UI2.WinForms.Guna2Button();
            this.btnThietBiTrongPhong = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnThongTin = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnThongTin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnKhoThietBi);
            this.panel1.Controls.Add(this.btnDangXuat);
            this.panel1.Controls.Add(this.btnThayDoiTrangThai);
            this.panel1.Controls.Add(this.btnThietBiTrongPhong);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1536, 112);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.guna2ControlBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(170, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1364, 29);
            this.panel2.TabIndex = 8;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.MistyRose;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1309, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(56, 31);
            this.guna2ControlBox2.TabIndex = 6;
            // 
            // btnKhoThietBi
            // 
            this.btnKhoThietBi.BackColor = System.Drawing.Color.Transparent;
            this.btnKhoThietBi.BorderRadius = 10;
            this.btnKhoThietBi.CheckedState.Parent = this.btnKhoThietBi;
            this.btnKhoThietBi.CustomImages.Parent = this.btnKhoThietBi;
            this.btnKhoThietBi.FillColor = System.Drawing.Color.DarkCyan;
            this.btnKhoThietBi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhoThietBi.ForeColor = System.Drawing.Color.White;
            this.btnKhoThietBi.HoverState.Parent = this.btnKhoThietBi;
            this.btnKhoThietBi.Location = new System.Drawing.Point(635, 47);
            this.btnKhoThietBi.Name = "btnKhoThietBi";
            this.btnKhoThietBi.ShadowDecoration.Parent = this.btnKhoThietBi;
            this.btnKhoThietBi.Size = new System.Drawing.Size(169, 43);
            this.btnKhoThietBi.TabIndex = 6;
            this.btnKhoThietBi.Text = "Kho thiết bị";
            this.btnKhoThietBi.Click += new System.EventHandler(this.btnKhoThietBi_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BorderRadius = 10;
            this.btnDangXuat.CheckedState.Parent = this.btnDangXuat;
            this.btnDangXuat.CustomImages.Parent = this.btnDangXuat;
            this.btnDangXuat.FillColor = System.Drawing.Color.DarkCyan;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.HoverState.Parent = this.btnDangXuat;
            this.btnDangXuat.Location = new System.Drawing.Point(1085, 47);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ShadowDecoration.Parent = this.btnDangXuat;
            this.btnDangXuat.Size = new System.Drawing.Size(169, 43);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThayDoiTrangThai
            // 
            this.btnThayDoiTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.btnThayDoiTrangThai.BorderRadius = 10;
            this.btnThayDoiTrangThai.CheckedState.Parent = this.btnThayDoiTrangThai;
            this.btnThayDoiTrangThai.CustomImages.Parent = this.btnThayDoiTrangThai;
            this.btnThayDoiTrangThai.FillColor = System.Drawing.Color.DarkCyan;
            this.btnThayDoiTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThayDoiTrangThai.ForeColor = System.Drawing.Color.White;
            this.btnThayDoiTrangThai.HoverState.Parent = this.btnThayDoiTrangThai;
            this.btnThayDoiTrangThai.Location = new System.Drawing.Point(867, 47);
            this.btnThayDoiTrangThai.Name = "btnThayDoiTrangThai";
            this.btnThayDoiTrangThai.ShadowDecoration.Parent = this.btnThayDoiTrangThai;
            this.btnThayDoiTrangThai.Size = new System.Drawing.Size(169, 43);
            this.btnThayDoiTrangThai.TabIndex = 4;
            this.btnThayDoiTrangThai.Text = "Thay đổi trạng thái phòng";
            this.btnThayDoiTrangThai.Click += new System.EventHandler(this.btnThayDoiTrangThai_Click);
            // 
            // btnThietBiTrongPhong
            // 
            this.btnThietBiTrongPhong.BackColor = System.Drawing.Color.Transparent;
            this.btnThietBiTrongPhong.BorderRadius = 10;
            this.btnThietBiTrongPhong.CheckedState.Parent = this.btnThietBiTrongPhong;
            this.btnThietBiTrongPhong.CustomImages.Parent = this.btnThietBiTrongPhong;
            this.btnThietBiTrongPhong.FillColor = System.Drawing.Color.DarkCyan;
            this.btnThietBiTrongPhong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThietBiTrongPhong.ForeColor = System.Drawing.Color.White;
            this.btnThietBiTrongPhong.HoverState.Parent = this.btnThietBiTrongPhong;
            this.btnThietBiTrongPhong.Location = new System.Drawing.Point(423, 47);
            this.btnThietBiTrongPhong.Name = "btnThietBiTrongPhong";
            this.btnThietBiTrongPhong.ShadowDecoration.Parent = this.btnThietBiTrongPhong;
            this.btnThietBiTrongPhong.Size = new System.Drawing.Size(169, 43);
            this.btnThietBiTrongPhong.TabIndex = 3;
            this.btnThietBiTrongPhong.Text = "Trang thết bị trong phòng";
            this.btnThietBiTrongPhong.Click += new System.EventHandler(this.btnThietBiTrongPhong_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::HotelManagement.Properties.Resources.icon_setting;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(170, 110);
            this.panel4.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.Transparent;
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 112);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1536, 732);
            this.panelBody.TabIndex = 2;
            // 
            // btnThongTin
            // 
            this.btnThongTin.BackColor = System.Drawing.Color.Transparent;
            this.btnThongTin.BorderRadius = 10;
            this.btnThongTin.CheckedState.Parent = this.btnThongTin;
            this.btnThongTin.CustomImages.Parent = this.btnThongTin;
            this.btnThongTin.FillColor = System.Drawing.Color.DarkCyan;
            this.btnThongTin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThongTin.ForeColor = System.Drawing.Color.White;
            this.btnThongTin.HoverState.Parent = this.btnThongTin;
            this.btnThongTin.Location = new System.Drawing.Point(218, 47);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.ShadowDecoration.Parent = this.btnThongTin;
            this.btnThongTin.Size = new System.Drawing.Size(169, 43);
            this.btnThongTin.TabIndex = 9;
            this.btnThongTin.Text = "Thông tin cá nhân";
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // frmNhanVienKyThuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::HotelManagement.Properties.Resources.Technology1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1536, 844);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNhanVienKyThuat";
            this.Text = "frmNhanVienKyThuat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnThayDoiTrangThai;
        private Guna.UI2.WinForms.Guna2Button btnThietBiTrongPhong;
        private Guna.UI2.WinForms.Guna2Button btnKhoThietBi;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2Button btnThongTin;
    }
}