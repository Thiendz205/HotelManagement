namespace HotelManagement
{
    partial class frmGiaPhongDongTheoThoiGIan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtGiaPhongThayDoi = new System.Windows.Forms.DataGridView();
            this.btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Pannel5 = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNote = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaGiam = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGiaTheoNgay = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtNgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtGiaTheoGio = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBPhong = new System.Windows.Forms.ComboBox();
            this.dtNgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGiaPhongThayDoi)).BeginInit();
            this.panel4.SuspendLayout();
            this.Pannel5.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(743, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giá phòng thay đổi theo thời gian ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtGiaPhongThayDoi);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 780);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 300);
            this.panel2.TabIndex = 1;
            // 
            // dtGiaPhongThayDoi
            // 
            this.dtGiaPhongThayDoi.AllowUserToAddRows = false;
            this.dtGiaPhongThayDoi.AllowUserToDeleteRows = false;
            this.dtGiaPhongThayDoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGiaPhongThayDoi.BackgroundColor = System.Drawing.Color.White;
            this.dtGiaPhongThayDoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGiaPhongThayDoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGiaPhongThayDoi.Location = new System.Drawing.Point(0, 0);
            this.dtGiaPhongThayDoi.Name = "dtGiaPhongThayDoi";
            this.dtGiaPhongThayDoi.ReadOnly = true;
            this.dtGiaPhongThayDoi.RowHeadersWidth = 51;
            this.dtGiaPhongThayDoi.RowTemplate.Height = 24;
            this.dtGiaPhongThayDoi.Size = new System.Drawing.Size(1920, 300);
            this.dtGiaPhongThayDoi.TabIndex = 0;
            this.dtGiaPhongThayDoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGiaPhongThayDoi_CellClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BorderRadius = 20;
            this.btnLamMoi.CheckedState.Parent = this.btnLamMoi;
            this.btnLamMoi.CustomImages.Parent = this.btnLamMoi;
            this.btnLamMoi.FillColor = System.Drawing.Color.White;
            this.btnLamMoi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.Color.Black;
            this.btnLamMoi.HoverState.Parent = this.btnLamMoi;
            this.btnLamMoi.Image = global::HotelManagement.Properties.Resources.refreshRECP;
            this.btnLamMoi.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnLamMoi.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLamMoi.Location = new System.Drawing.Point(35, 450);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.ShadowDecoration.Parent = this.btnLamMoi;
            this.btnLamMoi.Size = new System.Drawing.Size(220, 60);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 20;
            this.btnSua.CheckedState.Parent = this.btnSua;
            this.btnSua.CustomImages.Parent = this.btnSua;
            this.btnSua.FillColor = System.Drawing.Color.White;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.HoverState.Parent = this.btnSua;
            this.btnSua.Image = global::HotelManagement.Properties.Resources.updateHR;
            this.btnSua.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnSua.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSua.Location = new System.Drawing.Point(35, 221);
            this.btnSua.Name = "btnSua";
            this.btnSua.ShadowDecoration.Parent = this.btnSua;
            this.btnSua.Size = new System.Drawing.Size(220, 60);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 20;
            this.btnXoa.CheckedState.Parent = this.btnXoa;
            this.btnXoa.CustomImages.Parent = this.btnXoa;
            this.btnXoa.FillColor = System.Drawing.Color.White;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.HoverState.Parent = this.btnXoa;
            this.btnXoa.Image = global::HotelManagement.Properties.Resources.signs_close_icon_png;
            this.btnXoa.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnXoa.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXoa.Location = new System.Drawing.Point(35, 127);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Parent = this.btnXoa;
            this.btnXoa.Size = new System.Drawing.Size(220, 60);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 20;
            this.btnThem.CheckedState.Parent = this.btnThem;
            this.btnThem.CustomImages.Parent = this.btnThem;
            this.btnThem.FillColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.HoverState.Parent = this.btnThem;
            this.btnThem.Image = global::HotelManagement.Properties.Resources.addHR;
            this.btnThem.ImageOffset = new System.Drawing.Point(-3, 0);
            this.btnThem.ImageSize = new System.Drawing.Size(40, 40);
            this.btnThem.Location = new System.Drawing.Point(35, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(7, 7, 0, 0);
            this.btnThem.ShadowDecoration.Parent = this.btnThem;
            this.btnThem.Size = new System.Drawing.Size(220, 60);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 680);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnThem);
            this.panel4.Controls.Add(this.btnXoa);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Controls.Add(this.btnLamMoi);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1641, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 680);
            this.panel4.TabIndex = 3;
            // 
            // Pannel5
            // 
            this.Pannel5.AutoScroll = true;
            this.Pannel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Pannel5.Controls.Add(this.guna2GroupBox2);
            this.Pannel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pannel5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pannel5.Location = new System.Drawing.Point(200, 100);
            this.Pannel5.Name = "Pannel5";
            this.Pannel5.Size = new System.Drawing.Size(1441, 680);
            this.Pannel5.TabIndex = 4;
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.label8);
            this.guna2GroupBox2.Controls.Add(this.label9);
            this.guna2GroupBox2.Controls.Add(this.txtNote);
            this.guna2GroupBox2.Controls.Add(this.txtMaGiam);
            this.guna2GroupBox2.Controls.Add(this.txtGiaTheoNgay);
            this.guna2GroupBox2.Controls.Add(this.dtNgayBatDau);
            this.guna2GroupBox2.Controls.Add(this.txtGiaTheoGio);
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.Controls.Add(this.cbBPhong);
            this.guna2GroupBox2.Controls.Add(this.dtNgayKetThuc);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2GroupBox2.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(53, 65);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(1191, 446);
            this.guna2GroupBox2.TabIndex = 28;
            this.guna2GroupBox2.Text = "Thông tin giá phòng thay đổi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã giá:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(595, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "Giá thuê theo giờ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(400, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 22);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mô tả";
            // 
            // txtNote
            // 
            this.txtNote.BorderRadius = 10;
            this.txtNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNote.DefaultText = "";
            this.txtNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.DisabledState.Parent = this.txtNote;
            this.txtNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.FocusedState.Parent = this.txtNote;
            this.txtNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNote.HoverState.Parent = this.txtNote;
            this.txtNote.Location = new System.Drawing.Point(484, 340);
            this.txtNote.Margin = new System.Windows.Forms.Padding(8);
            this.txtNote.Name = "txtNote";
            this.txtNote.PasswordChar = '\0';
            this.txtNote.PlaceholderText = "";
            this.txtNote.SelectedText = "";
            this.txtNote.ShadowDecoration.Parent = this.txtNote;
            this.txtNote.Size = new System.Drawing.Size(269, 59);
            this.txtNote.TabIndex = 12;
            // 
            // txtMaGiam
            // 
            this.txtMaGiam.BorderRadius = 10;
            this.txtMaGiam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaGiam.DefaultText = "";
            this.txtMaGiam.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaGiam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaGiam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaGiam.DisabledState.Parent = this.txtMaGiam;
            this.txtMaGiam.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaGiam.Enabled = false;
            this.txtMaGiam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaGiam.FocusedState.Parent = this.txtMaGiam;
            this.txtMaGiam.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaGiam.HoverState.Parent = this.txtMaGiam;
            this.txtMaGiam.Location = new System.Drawing.Point(273, 63);
            this.txtMaGiam.Margin = new System.Windows.Forms.Padding(8);
            this.txtMaGiam.Name = "txtMaGiam";
            this.txtMaGiam.PasswordChar = '\0';
            this.txtMaGiam.PlaceholderText = "";
            this.txtMaGiam.SelectedText = "";
            this.txtMaGiam.ShadowDecoration.Parent = this.txtMaGiam;
            this.txtMaGiam.Size = new System.Drawing.Size(245, 49);
            this.txtMaGiam.TabIndex = 0;
            this.txtMaGiam.TextChanged += new System.EventHandler(this.txtMaGiam_TextChanged);
            // 
            // txtGiaTheoNgay
            // 
            this.txtGiaTheoNgay.BorderRadius = 10;
            this.txtGiaTheoNgay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTheoNgay.DefaultText = "";
            this.txtGiaTheoNgay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaTheoNgay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaTheoNgay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaTheoNgay.DisabledState.Parent = this.txtGiaTheoNgay;
            this.txtGiaTheoNgay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaTheoNgay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaTheoNgay.FocusedState.Parent = this.txtGiaTheoNgay;
            this.txtGiaTheoNgay.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaTheoNgay.HoverState.Parent = this.txtGiaTheoNgay;
            this.txtGiaTheoNgay.Location = new System.Drawing.Point(800, 157);
            this.txtGiaTheoNgay.Margin = new System.Windows.Forms.Padding(8);
            this.txtGiaTheoNgay.Name = "txtGiaTheoNgay";
            this.txtGiaTheoNgay.PasswordChar = '\0';
            this.txtGiaTheoNgay.PlaceholderText = "";
            this.txtGiaTheoNgay.SelectedText = "";
            this.txtGiaTheoNgay.ShadowDecoration.Parent = this.txtGiaTheoNgay;
            this.txtGiaTheoNgay.Size = new System.Drawing.Size(245, 47);
            this.txtGiaTheoNgay.TabIndex = 4;
            this.txtGiaTheoNgay.TextChanged += new System.EventHandler(this.txtGiaTheoNgay_TextChanged);
            // 
            // dtNgayBatDau
            // 
            this.dtNgayBatDau.BorderRadius = 10;
            this.dtNgayBatDau.CheckedState.Parent = this.dtNgayBatDau;
            this.dtNgayBatDau.FillColor = System.Drawing.Color.White;
            this.dtNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtNgayBatDau.HoverState.Parent = this.dtNgayBatDau;
            this.dtNgayBatDau.Location = new System.Drawing.Point(273, 162);
            this.dtNgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgayBatDau.Name = "dtNgayBatDau";
            this.dtNgayBatDau.ShadowDecoration.Parent = this.dtNgayBatDau;
            this.dtNgayBatDau.Size = new System.Drawing.Size(245, 42);
            this.dtNgayBatDau.TabIndex = 14;
            this.dtNgayBatDau.Value = new System.DateTime(2025, 10, 6, 22, 43, 4, 246);
            // 
            // txtGiaTheoGio
            // 
            this.txtGiaTheoGio.BorderRadius = 10;
            this.txtGiaTheoGio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTheoGio.DefaultText = "";
            this.txtGiaTheoGio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGiaTheoGio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGiaTheoGio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaTheoGio.DisabledState.Parent = this.txtGiaTheoGio;
            this.txtGiaTheoGio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGiaTheoGio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaTheoGio.FocusedState.Parent = this.txtGiaTheoGio;
            this.txtGiaTheoGio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGiaTheoGio.HoverState.Parent = this.txtGiaTheoGio;
            this.txtGiaTheoGio.Location = new System.Drawing.Point(803, 254);
            this.txtGiaTheoGio.Margin = new System.Windows.Forms.Padding(8);
            this.txtGiaTheoGio.Name = "txtGiaTheoGio";
            this.txtGiaTheoGio.PasswordChar = '\0';
            this.txtGiaTheoGio.PlaceholderText = "";
            this.txtGiaTheoGio.SelectedText = "";
            this.txtGiaTheoGio.ShadowDecoration.Parent = this.txtGiaTheoGio;
            this.txtGiaTheoGio.Size = new System.Drawing.Size(242, 54);
            this.txtGiaTheoGio.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(592, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 22);
            this.label7.TabIndex = 10;
            this.label7.Text = "Giá thuê theo ngày:";
            // 
            // cbBPhong
            // 
            this.cbBPhong.FormattingEnabled = true;
            this.cbBPhong.Location = new System.Drawing.Point(800, 69);
            this.cbBPhong.Name = "cbBPhong";
            this.cbBPhong.Size = new System.Drawing.Size(245, 30);
            this.cbBPhong.TabIndex = 16;
            // 
            // dtNgayKetThuc
            // 
            this.dtNgayKetThuc.BorderRadius = 10;
            this.dtNgayKetThuc.CheckedState.Parent = this.dtNgayKetThuc;
            this.dtNgayKetThuc.FillColor = System.Drawing.Color.White;
            this.dtNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtNgayKetThuc.HoverState.Parent = this.dtNgayKetThuc;
            this.dtNgayKetThuc.Location = new System.Drawing.Point(273, 266);
            this.dtNgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgayKetThuc.Name = "dtNgayKetThuc";
            this.dtNgayKetThuc.ShadowDecoration.Parent = this.dtNgayKetThuc;
            this.dtNgayKetThuc.Size = new System.Drawing.Size(245, 42);
            this.dtNgayKetThuc.TabIndex = 15;
            this.dtNgayKetThuc.Value = new System.DateTime(2025, 10, 6, 22, 43, 4, 246);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại phòng áp dụng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày kết thúc:";
            // 
            // frmGiaPhongDongTheoThoiGIan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Pannel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiaPhongDongTheoThoiGIan";
            this.Text = "frmGiaPhongDongTheoThoiGIan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGiaPhongDongTheoThoiGIan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGiaPhongThayDoi)).EndInit();
            this.panel4.ResumeLayout(false);
            this.Pannel5.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel Pannel5;
        private System.Windows.Forms.DataGridView dtGiaPhongThayDoi;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtMaGiam;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNgayBatDau;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNgayKetThuc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtNote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbBPhong;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaTheoGio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtGiaTheoNgay;
    }
}