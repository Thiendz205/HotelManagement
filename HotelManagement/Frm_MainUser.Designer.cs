namespace GUI
{
    partial class Frm_MainUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MainUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuContainerQL = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQL = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnChinhSuaPhong = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLoaiPhong = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnGiaPhongThoiGian = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnKhoThietBi = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnTrangThietBiTrongPhong = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnDanhGiaPhong = new System.Windows.Forms.Button();
            this.menuContainerRP = new System.Windows.Forms.FlowLayoutPanel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnRP = new System.Windows.Forms.Button();
            this.panel22 = new System.Windows.Forms.Panel();
            this.btnINBL = new System.Windows.Forms.Button();
            this.panel23 = new System.Windows.Forms.Panel();
            this.btnPhieuVay = new System.Windows.Forms.Button();
            this.panel24 = new System.Windows.Forms.Panel();
            this.btnPhieuTraNo = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnInGiaoDich = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.btnHopDong = new System.Windows.Forms.Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.btnChuyenKhoan = new System.Windows.Forms.Button();
            this.panel18 = new System.Windows.Forms.Panel();
            this.btnTaiKhoan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.menuTransitionRP = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.tmrBannerLoop = new System.Windows.Forms.Timer(this.components);
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.sidebar.SuspendLayout();
            this.menuContainerQL.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.menuContainerRP.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnZoom);
            this.panel1.Controls.Add(this.btnMM);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 46);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(243, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 743);
            this.panel3.TabIndex = 8;
            // 
            // btnZoom
            // 
            this.btnZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoom.FlatAppearance.BorderSize = 0;
            this.btnZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoom.Location = new System.Drawing.Point(1314, 6);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(35, 35);
            this.btnZoom.TabIndex = 4;
            this.btnZoom.Text = "🗕";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnMM
            // 
            this.btnMM.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMM.FlatAppearance.BorderSize = 0;
            this.btnMM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMM.Location = new System.Drawing.Point(1355, 6);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(35, 35);
            this.btnMM.TabIndex = 4;
            this.btnMM.Text = "🗖";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1396, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOTEL  | ADMIN";
            // 
            // sidebar
            // 
            this.sidebar.AutoScroll = true;
            this.sidebar.BackColor = System.Drawing.Color.LightBlue;
            this.sidebar.Controls.Add(this.menuContainerQL);
            this.sidebar.Controls.Add(this.menuContainerRP);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 46);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(314, 743);
            this.sidebar.TabIndex = 1;
            // 
            // menuContainerQL
            // 
            this.menuContainerQL.BackColor = System.Drawing.Color.LightBlue;
            this.menuContainerQL.Controls.Add(this.panel2);
            this.menuContainerQL.Controls.Add(this.panel5);
            this.menuContainerQL.Controls.Add(this.panel6);
            this.menuContainerQL.Controls.Add(this.panel8);
            this.menuContainerQL.Controls.Add(this.panel7);
            this.menuContainerQL.Controls.Add(this.panel12);
            this.menuContainerQL.Controls.Add(this.panel11);
            this.menuContainerQL.Controls.Add(this.panel10);
            this.menuContainerQL.Location = new System.Drawing.Point(3, 35);
            this.menuContainerQL.Margin = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.menuContainerQL.Name = "menuContainerQL";
            this.menuContainerQL.Size = new System.Drawing.Size(311, 370);
            this.menuContainerQL.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQL);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 45);
            this.panel2.TabIndex = 3;
            // 
            // btnQL
            // 
            this.btnQL.BackColor = System.Drawing.Color.LightBlue;
            this.btnQL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQL.ForeColor = System.Drawing.Color.White;
            this.btnQL.Image = ((System.Drawing.Image)(resources.GetObject("btnQL.Image")));
            this.btnQL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQL.Location = new System.Drawing.Point(-13, -24);
            this.btnQL.Name = "btnQL";
            this.btnQL.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnQL.Size = new System.Drawing.Size(324, 94);
            this.btnQL.TabIndex = 2;
            this.btnQL.Text = "                 Quản Lý phòng";
            this.btnQL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQL.UseVisualStyleBackColor = false;
            this.btnQL.Click += new System.EventHandler(this.btnQL_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.btnChinhSuaPhong);
            this.panel5.Location = new System.Drawing.Point(0, 45);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 45);
            this.panel5.TabIndex = 5;
            // 
            // btnChinhSuaPhong
            // 
            this.btnChinhSuaPhong.BackColor = System.Drawing.Color.LightBlue;
            this.btnChinhSuaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSuaPhong.ForeColor = System.Drawing.Color.White;
            this.btnChinhSuaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSuaPhong.Location = new System.Drawing.Point(-20, -24);
            this.btnChinhSuaPhong.Name = "btnChinhSuaPhong";
            this.btnChinhSuaPhong.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnChinhSuaPhong.Size = new System.Drawing.Size(302, 94);
            this.btnChinhSuaPhong.TabIndex = 2;
            this.btnChinhSuaPhong.Text = "    -           Chỉnh sửa phòng";
            this.btnChinhSuaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChinhSuaPhong.UseVisualStyleBackColor = false;
            this.btnChinhSuaPhong.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Controls.Add(this.btnLoaiPhong);
            this.panel6.Location = new System.Drawing.Point(0, 90);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 45);
            this.panel6.TabIndex = 6;
            // 
            // btnLoaiPhong
            // 
            this.btnLoaiPhong.BackColor = System.Drawing.Color.LightBlue;
            this.btnLoaiPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.btnLoaiPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiPhong.Location = new System.Drawing.Point(-20, -24);
            this.btnLoaiPhong.Name = "btnLoaiPhong";
            this.btnLoaiPhong.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLoaiPhong.Size = new System.Drawing.Size(302, 94);
            this.btnLoaiPhong.TabIndex = 2;
            this.btnLoaiPhong.Text = "    -           Loại phòng";
            this.btnLoaiPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiPhong.UseVisualStyleBackColor = false;
            this.btnLoaiPhong.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.btnGiaPhongThoiGian);
            this.panel8.Location = new System.Drawing.Point(0, 135);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(270, 45);
            this.panel8.TabIndex = 7;
            // 
            // btnGiaPhongThoiGian
            // 
            this.btnGiaPhongThoiGian.BackColor = System.Drawing.Color.LightBlue;
            this.btnGiaPhongThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaPhongThoiGian.ForeColor = System.Drawing.Color.White;
            this.btnGiaPhongThoiGian.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaPhongThoiGian.Location = new System.Drawing.Point(-20, -24);
            this.btnGiaPhongThoiGian.Name = "btnGiaPhongThoiGian";
            this.btnGiaPhongThoiGian.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnGiaPhongThoiGian.Size = new System.Drawing.Size(302, 94);
            this.btnGiaPhongThoiGian.TabIndex = 2;
            this.btnGiaPhongThoiGian.Text = "    -           Giá phòng theo thời gian";
            this.btnGiaPhongThoiGian.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaPhongThoiGian.UseVisualStyleBackColor = false;
            this.btnGiaPhongThoiGian.Click += new System.EventHandler(this.btnCK_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.btnKhoThietBi);
            this.panel7.Location = new System.Drawing.Point(0, 180);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 45);
            this.panel7.TabIndex = 8;
            // 
            // btnKhoThietBi
            // 
            this.btnKhoThietBi.BackColor = System.Drawing.Color.LightBlue;
            this.btnKhoThietBi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhoThietBi.ForeColor = System.Drawing.Color.White;
            this.btnKhoThietBi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoThietBi.Location = new System.Drawing.Point(-20, -24);
            this.btnKhoThietBi.Name = "btnKhoThietBi";
            this.btnKhoThietBi.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnKhoThietBi.Size = new System.Drawing.Size(268, 94);
            this.btnKhoThietBi.TabIndex = 2;
            this.btnKhoThietBi.Text = "    -           Kho thiết bị";
            this.btnKhoThietBi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoThietBi.UseVisualStyleBackColor = false;
            this.btnKhoThietBi.Click += new System.EventHandler(this.btnGD_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.Control;
            this.panel12.Controls.Add(this.btnTrangThietBiTrongPhong);
            this.panel12.Location = new System.Drawing.Point(0, 225);
            this.panel12.Margin = new System.Windows.Forms.Padding(0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(282, 45);
            this.panel12.TabIndex = 9;
            // 
            // btnTrangThietBiTrongPhong
            // 
            this.btnTrangThietBiTrongPhong.BackColor = System.Drawing.Color.LightBlue;
            this.btnTrangThietBiTrongPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangThietBiTrongPhong.ForeColor = System.Drawing.Color.White;
            this.btnTrangThietBiTrongPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangThietBiTrongPhong.Location = new System.Drawing.Point(-20, -24);
            this.btnTrangThietBiTrongPhong.Name = "btnTrangThietBiTrongPhong";
            this.btnTrangThietBiTrongPhong.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTrangThietBiTrongPhong.Size = new System.Drawing.Size(325, 94);
            this.btnTrangThietBiTrongPhong.TabIndex = 2;
            this.btnTrangThietBiTrongPhong.Text = "    -           Trang thiết bị trong phòng";
            this.btnTrangThietBiTrongPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangThietBiTrongPhong.UseVisualStyleBackColor = false;
            this.btnTrangThietBiTrongPhong.Click += new System.EventHandler(this.btnVay_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.btnDatPhong);
            this.panel11.Location = new System.Drawing.Point(0, 270);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(240, 45);
            this.panel11.TabIndex = 10;
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.BackColor = System.Drawing.Color.LightBlue;
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ForeColor = System.Drawing.Color.White;
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.Location = new System.Drawing.Point(-20, -24);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDatPhong.Size = new System.Drawing.Size(268, 94);
            this.btnDatPhong.TabIndex = 2;
            this.btnDatPhong.Text = "    -           Đăt phòng";
            this.btnDatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.UseVisualStyleBackColor = false;
            this.btnDatPhong.Click += new System.EventHandler(this.btnLS_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.Control;
            this.panel10.Controls.Add(this.btnDanhGiaPhong);
            this.panel10.Location = new System.Drawing.Point(0, 315);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(240, 45);
            this.panel10.TabIndex = 11;
            // 
            // btnDanhGiaPhong
            // 
            this.btnDanhGiaPhong.BackColor = System.Drawing.Color.LightBlue;
            this.btnDanhGiaPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhGiaPhong.ForeColor = System.Drawing.Color.White;
            this.btnDanhGiaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhGiaPhong.Location = new System.Drawing.Point(-20, -24);
            this.btnDanhGiaPhong.Name = "btnDanhGiaPhong";
            this.btnDanhGiaPhong.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDanhGiaPhong.Size = new System.Drawing.Size(268, 94);
            this.btnDanhGiaPhong.TabIndex = 2;
            this.btnDanhGiaPhong.Text = "    -           Đánh giá phòng";
            this.btnDanhGiaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhGiaPhong.UseVisualStyleBackColor = false;
            this.btnDanhGiaPhong.Click += new System.EventHandler(this.btnBL_Click);
            // 
            // menuContainerRP
            // 
            this.menuContainerRP.BackColor = System.Drawing.Color.LightBlue;
            this.menuContainerRP.Controls.Add(this.panel21);
            this.menuContainerRP.Controls.Add(this.panel22);
            this.menuContainerRP.Controls.Add(this.panel23);
            this.menuContainerRP.Controls.Add(this.panel24);
            this.menuContainerRP.Controls.Add(this.panel13);
            this.menuContainerRP.Controls.Add(this.panel16);
            this.menuContainerRP.Controls.Add(this.panel17);
            this.menuContainerRP.Controls.Add(this.panel18);
            this.menuContainerRP.Location = new System.Drawing.Point(3, 415);
            this.menuContainerRP.Margin = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.menuContainerRP.Name = "menuContainerRP";
            this.menuContainerRP.Size = new System.Drawing.Size(305, 45);
            this.menuContainerRP.TabIndex = 15;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnRP);
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Margin = new System.Windows.Forms.Padding(0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(240, 45);
            this.panel21.TabIndex = 3;
            // 
            // btnRP
            // 
            this.btnRP.BackColor = System.Drawing.Color.LightBlue;
            this.btnRP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRP.ForeColor = System.Drawing.Color.White;
            this.btnRP.Image = ((System.Drawing.Image)(resources.GetObject("btnRP.Image")));
            this.btnRP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRP.Location = new System.Drawing.Point(-14, -26);
            this.btnRP.Name = "btnRP";
            this.btnRP.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRP.Size = new System.Drawing.Size(268, 94);
            this.btnRP.TabIndex = 2;
            this.btnRP.Text = "                 In Ấn / Báo Cáo";
            this.btnRP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRP.UseVisualStyleBackColor = false;
            this.btnRP.Click += new System.EventHandler(this.btnRP_Click);
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.SystemColors.Control;
            this.panel22.Controls.Add(this.btnINBL);
            this.panel22.Location = new System.Drawing.Point(0, 45);
            this.panel22.Margin = new System.Windows.Forms.Padding(0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(240, 45);
            this.panel22.TabIndex = 13;
            // 
            // btnINBL
            // 
            this.btnINBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnINBL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINBL.ForeColor = System.Drawing.Color.White;
            this.btnINBL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnINBL.Location = new System.Drawing.Point(-20, -24);
            this.btnINBL.Name = "btnINBL";
            this.btnINBL.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnINBL.Size = new System.Drawing.Size(268, 94);
            this.btnINBL.TabIndex = 2;
            this.btnINBL.Text = "    -           In Biên Lai";
            this.btnINBL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnINBL.UseVisualStyleBackColor = false;
            this.btnINBL.Click += new System.EventHandler(this.btnINBL_Click);
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.SystemColors.Control;
            this.panel23.Controls.Add(this.btnPhieuVay);
            this.panel23.Location = new System.Drawing.Point(0, 90);
            this.panel23.Margin = new System.Windows.Forms.Padding(0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(240, 45);
            this.panel23.TabIndex = 14;
            // 
            // btnPhieuVay
            // 
            this.btnPhieuVay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnPhieuVay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuVay.ForeColor = System.Drawing.Color.White;
            this.btnPhieuVay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuVay.Location = new System.Drawing.Point(-20, -24);
            this.btnPhieuVay.Name = "btnPhieuVay";
            this.btnPhieuVay.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPhieuVay.Size = new System.Drawing.Size(268, 94);
            this.btnPhieuVay.TabIndex = 2;
            this.btnPhieuVay.Text = "    -           Phiếu Vay";
            this.btnPhieuVay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuVay.UseVisualStyleBackColor = false;
            this.btnPhieuVay.Click += new System.EventHandler(this.btnPhieuVay_Click);
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.SystemColors.Control;
            this.panel24.Controls.Add(this.btnPhieuTraNo);
            this.panel24.Location = new System.Drawing.Point(0, 135);
            this.panel24.Margin = new System.Windows.Forms.Padding(0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(240, 45);
            this.panel24.TabIndex = 16;
            // 
            // btnPhieuTraNo
            // 
            this.btnPhieuTraNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnPhieuTraNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhieuTraNo.ForeColor = System.Drawing.Color.White;
            this.btnPhieuTraNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuTraNo.Location = new System.Drawing.Point(-20, -24);
            this.btnPhieuTraNo.Name = "btnPhieuTraNo";
            this.btnPhieuTraNo.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnPhieuTraNo.Size = new System.Drawing.Size(268, 94);
            this.btnPhieuTraNo.TabIndex = 2;
            this.btnPhieuTraNo.Text = "    -           Phiếu Trả Nợ";
            this.btnPhieuTraNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuTraNo.UseVisualStyleBackColor = false;
            this.btnPhieuTraNo.Click += new System.EventHandler(this.btnPhieuTraNo_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.Control;
            this.panel13.Controls.Add(this.btnInGiaoDich);
            this.panel13.Location = new System.Drawing.Point(0, 180);
            this.panel13.Margin = new System.Windows.Forms.Padding(0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(240, 45);
            this.panel13.TabIndex = 17;
            // 
            // btnInGiaoDich
            // 
            this.btnInGiaoDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnInGiaoDich.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInGiaoDich.ForeColor = System.Drawing.Color.White;
            this.btnInGiaoDich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInGiaoDich.Location = new System.Drawing.Point(-20, -24);
            this.btnInGiaoDich.Name = "btnInGiaoDich";
            this.btnInGiaoDich.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnInGiaoDich.Size = new System.Drawing.Size(268, 94);
            this.btnInGiaoDich.TabIndex = 2;
            this.btnInGiaoDich.Text = "    -           Giao Dịch";
            this.btnInGiaoDich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInGiaoDich.UseVisualStyleBackColor = false;
            this.btnInGiaoDich.Click += new System.EventHandler(this.btnInGiaoDich_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.Control;
            this.panel16.Controls.Add(this.btnHopDong);
            this.panel16.Location = new System.Drawing.Point(0, 225);
            this.panel16.Margin = new System.Windows.Forms.Padding(0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(240, 45);
            this.panel16.TabIndex = 18;
            // 
            // btnHopDong
            // 
            this.btnHopDong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnHopDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHopDong.ForeColor = System.Drawing.Color.White;
            this.btnHopDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.Location = new System.Drawing.Point(-20, -24);
            this.btnHopDong.Name = "btnHopDong";
            this.btnHopDong.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHopDong.Size = new System.Drawing.Size(268, 94);
            this.btnHopDong.TabIndex = 2;
            this.btnHopDong.Text = "    -           Hợp Đồng";
            this.btnHopDong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHopDong.UseVisualStyleBackColor = false;
            this.btnHopDong.Click += new System.EventHandler(this.btnHopDong_Click);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.Control;
            this.panel17.Controls.Add(this.btnChuyenKhoan);
            this.panel17.Location = new System.Drawing.Point(0, 270);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(240, 45);
            this.panel17.TabIndex = 19;
            // 
            // btnChuyenKhoan
            // 
            this.btnChuyenKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnChuyenKhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenKhoan.ForeColor = System.Drawing.Color.White;
            this.btnChuyenKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenKhoan.Location = new System.Drawing.Point(-20, -24);
            this.btnChuyenKhoan.Name = "btnChuyenKhoan";
            this.btnChuyenKhoan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnChuyenKhoan.Size = new System.Drawing.Size(268, 94);
            this.btnChuyenKhoan.TabIndex = 2;
            this.btnChuyenKhoan.Text = "    -           Chuyển Khoản";
            this.btnChuyenKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChuyenKhoan.UseVisualStyleBackColor = false;
            this.btnChuyenKhoan.Click += new System.EventHandler(this.btnChuyenKhoan_Click);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.SystemColors.Control;
            this.panel18.Controls.Add(this.btnTaiKhoan);
            this.panel18.Location = new System.Drawing.Point(0, 315);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(240, 45);
            this.panel18.TabIndex = 20;
            // 
            // btnTaiKhoan
            // 
            this.btnTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.btnTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.Location = new System.Drawing.Point(-20, -24);
            this.btnTaiKhoan.Name = "btnTaiKhoan";
            this.btnTaiKhoan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnTaiKhoan.Size = new System.Drawing.Size(268, 94);
            this.btnTaiKhoan.TabIndex = 2;
            this.btnTaiKhoan.Text = "    -           Tài Khoản";
            this.btnTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaiKhoan.UseVisualStyleBackColor = false;
            this.btnTaiKhoan.Click += new System.EventHandler(this.btnTaiKhoan_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLogout);
            this.panel4.Location = new System.Drawing.Point(3, 470);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 5, 0, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 45);
            this.panel4.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-14, -25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(268, 94);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "                 Đăng Xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 1;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // menuTransitionRP
            // 
            this.menuTransitionRP.Interval = 1;
            this.menuTransitionRP.Tick += new System.EventHandler(this.menuTransitionRP_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // tmrBannerLoop
            // 
            this.tmrBannerLoop.Interval = 150;
            // 
            // picBanner
            // 
            this.picBanner.BackColor = System.Drawing.Color.Transparent;
            this.picBanner.BackgroundImage = global::HotelManagement.Properties.Resources.view_hotel1;
            this.picBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBanner.Location = new System.Drawing.Point(314, 46);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(1129, 743);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 14;
            this.picBanner.TabStop = false;
            // 
            // Frm_MainUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::HotelManagement.Properties.Resources.view_hotel1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 789);
            this.Controls.Add(this.picBanner);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Frm_MainUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sidebar.ResumeLayout(false);
            this.menuContainerQL.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.menuContainerRP.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Button btnQL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel menuContainerQL;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnChinhSuaPhong;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLoaiPhong;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnKhoThietBi;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnGiaPhongThoiGian;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnDanhGiaPhong;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnTrangThietBiTrongPhong;
        private System.Windows.Forms.FlowLayoutPanel menuContainerRP;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btnRP;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.Button btnINBL;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Button btnPhieuVay;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Button btnPhieuTraNo;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer menuTransitionRP;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Timer tmrBannerLoop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnInGiaoDich;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Button btnHopDong;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Button btnChuyenKhoan;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Button btnTaiKhoan;
    }
}

