namespace HotelManagement
{
    partial class frmServiceManagement
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

        private void InitializeComponent()
        {
            this.pnlHeader = new Guna.UI.WinForms.GunaPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.pnlMain = new Guna.UI.WinForms.GunaPanel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvServiceUsage = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnExportPDF = new Guna.UI.WinForms.GunaButton();
            this.cboFilterKhachHang = new Guna.UI.WinForms.GunaComboBox();
            this.lblFilterKhachHang = new System.Windows.Forms.Label();
            this.cboFilterRoom = new Guna.UI.WinForms.GunaComboBox();
            this.lblFilterRoom = new System.Windows.Forms.Label();
            this.cboFilterService = new Guna.UI.WinForms.GunaComboBox();
            this.lblFilterService = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtStatus = new Guna.UI.WinForms.GunaTextBox();
            this.txtServiceName = new Guna.UI.WinForms.GunaTextBox();
            this.txtRoomName = new Guna.UI.WinForms.GunaTextBox();
            this.txtCustomerName = new Guna.UI.WinForms.GunaTextBox();
            this.txtDateTime = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsageID = new Guna.UI.WinForms.GunaTextBox();
            this.lblUsageID = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceUsage)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1361, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý Dịch vụ";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.AnimationHoverSpeed = 0.07F;
            this.btnClose.AnimationSpeed = 0.03F;
            this.btnClose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClose.BorderColor = System.Drawing.Color.Black;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.FocusedColor = System.Drawing.Color.Empty;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = null;
            this.btnClose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClose.Location = new System.Drawing.Point(1311, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlMain.Controls.Add(this.gunaGroupBox2);
            this.pnlMain.Controls.Add(this.gunaGroupBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1361, 640);
            this.pnlMain.TabIndex = 1;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.dgvServiceUsage);
            this.gunaGroupBox2.Controls.Add(this.btnRefresh);
            this.gunaGroupBox2.Controls.Add(this.btnSearch);
            this.gunaGroupBox2.Controls.Add(this.txtSearch);
            this.gunaGroupBox2.Controls.Add(this.lblSearch);
            this.gunaGroupBox2.Controls.Add(this.btnExportPDF);
            this.gunaGroupBox2.Controls.Add(this.cboFilterKhachHang);
            this.gunaGroupBox2.Controls.Add(this.lblFilterKhachHang);
            this.gunaGroupBox2.Controls.Add(this.cboFilterRoom);
            this.gunaGroupBox2.Controls.Add(this.lblFilterRoom);
            this.gunaGroupBox2.Controls.Add(this.cboFilterService);
            this.gunaGroupBox2.Controls.Add(this.lblFilterService);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(432, 20);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(926, 600);
            this.gunaGroupBox2.TabIndex = 2;
            this.gunaGroupBox2.Text = "Danh sách Sử dụng Dịch vụ";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvServiceUsage
            // 
            this.dgvServiceUsage.AllowUserToAddRows = false;
            this.dgvServiceUsage.AllowUserToDeleteRows = false;
            this.dgvServiceUsage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServiceUsage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceUsage.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceUsage.Location = new System.Drawing.Point(3, 180);
            this.dgvServiceUsage.Name = "dgvServiceUsage";
            this.dgvServiceUsage.ReadOnly = true;
            this.dgvServiceUsage.RowHeadersWidth = 51;
            this.dgvServiceUsage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceUsage.Size = new System.Drawing.Size(920, 400);
            this.dgvServiceUsage.TabIndex = 6;
            this.dgvServiceUsage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceUsage_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = null;
            this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.Location = new System.Drawing.Point(350, 120);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = null;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.Location = new System.Drawing.Point(250, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(84, 125);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(156, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSearch.Location = new System.Drawing.Point(20, 125);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 19);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.AnimationHoverSpeed = 0.07F;
            this.btnExportPDF.AnimationSpeed = 0.03F;
            this.btnExportPDF.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnExportPDF.BorderColor = System.Drawing.Color.Black;
            this.btnExportPDF.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExportPDF.FocusedColor = System.Drawing.Color.Empty;
            this.btnExportPDF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportPDF.ForeColor = System.Drawing.Color.White;
            this.btnExportPDF.Image = null;
            this.btnExportPDF.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExportPDF.Location = new System.Drawing.Point(457, 120);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnExportPDF.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExportPDF.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExportPDF.OnHoverImage = null;
            this.btnExportPDF.OnPressedColor = System.Drawing.Color.Black;
            this.btnExportPDF.Size = new System.Drawing.Size(140, 30);
            this.btnExportPDF.TabIndex = 8;
            this.btnExportPDF.Text = "Xuất PDF";
            this.btnExportPDF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // cboFilterKhachHang
            // 
            this.cboFilterKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterKhachHang.BaseColor = System.Drawing.Color.White;
            this.cboFilterKhachHang.BorderColor = System.Drawing.Color.Silver;
            this.cboFilterKhachHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilterKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterKhachHang.FocusedColor = System.Drawing.Color.Empty;
            this.cboFilterKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFilterKhachHang.ForeColor = System.Drawing.Color.Black;
            this.cboFilterKhachHang.FormattingEnabled = true;
            this.cboFilterKhachHang.Location = new System.Drawing.Point(24, 54);
            this.cboFilterKhachHang.Name = "cboFilterKhachHang";
            this.cboFilterKhachHang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboFilterKhachHang.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboFilterKhachHang.Size = new System.Drawing.Size(150, 24);
            this.cboFilterKhachHang.TabIndex = 9;
            this.cboFilterKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboFilterKhachHang_SelectedIndexChanged);
            // 
            // lblFilterKhachHang
            // 
            this.lblFilterKhachHang.AutoSize = true;
            this.lblFilterKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFilterKhachHang.Location = new System.Drawing.Point(41, 36);
            this.lblFilterKhachHang.Name = "lblFilterKhachHang";
            this.lblFilterKhachHang.Size = new System.Drawing.Size(94, 15);
            this.lblFilterKhachHang.TabIndex = 10;
            this.lblFilterKhachHang.Text = "Lọc khách hàng:";
            // 
            // cboFilterRoom
            // 
            this.cboFilterRoom.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterRoom.BaseColor = System.Drawing.Color.White;
            this.cboFilterRoom.BorderColor = System.Drawing.Color.Silver;
            this.cboFilterRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilterRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterRoom.FocusedColor = System.Drawing.Color.Empty;
            this.cboFilterRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFilterRoom.ForeColor = System.Drawing.Color.Black;
            this.cboFilterRoom.FormattingEnabled = true;
            this.cboFilterRoom.Location = new System.Drawing.Point(271, 54);
            this.cboFilterRoom.Name = "cboFilterRoom";
            this.cboFilterRoom.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboFilterRoom.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboFilterRoom.Size = new System.Drawing.Size(156, 24);
            this.cboFilterRoom.TabIndex = 11;
            this.cboFilterRoom.SelectedIndexChanged += new System.EventHandler(this.cboFilterRoom_SelectedIndexChanged);
            // 
            // lblFilterRoom
            // 
            this.lblFilterRoom.AutoSize = true;
            this.lblFilterRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFilterRoom.Location = new System.Drawing.Point(313, 36);
            this.lblFilterRoom.Name = "lblFilterRoom";
            this.lblFilterRoom.Size = new System.Drawing.Size(67, 15);
            this.lblFilterRoom.TabIndex = 12;
            this.lblFilterRoom.Text = "Lọc phòng:";
            // 
            // cboFilterService
            // 
            this.cboFilterService.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterService.BaseColor = System.Drawing.Color.White;
            this.cboFilterService.BorderColor = System.Drawing.Color.Silver;
            this.cboFilterService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilterService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterService.FocusedColor = System.Drawing.Color.Empty;
            this.cboFilterService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboFilterService.ForeColor = System.Drawing.Color.Black;
            this.cboFilterService.FormattingEnabled = true;
            this.cboFilterService.Location = new System.Drawing.Point(533, 54);
            this.cboFilterService.Name = "cboFilterService";
            this.cboFilterService.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboFilterService.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboFilterService.Size = new System.Drawing.Size(150, 24);
            this.cboFilterService.TabIndex = 13;
            this.cboFilterService.SelectedIndexChanged += new System.EventHandler(this.cboFilterService_SelectedIndexChanged);
            // 
            // lblFilterService
            // 
            this.lblFilterService.AutoSize = true;
            this.lblFilterService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFilterService.Location = new System.Drawing.Point(557, 36);
            this.lblFilterService.Name = "lblFilterService";
            this.lblFilterService.Size = new System.Drawing.Size(71, 15);
            this.lblFilterService.TabIndex = 14;
            this.lblFilterService.Text = "Lọc dịch vụ:";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.txtStatus);
            this.gunaGroupBox1.Controls.Add(this.txtServiceName);
            this.gunaGroupBox1.Controls.Add(this.txtRoomName);
            this.gunaGroupBox1.Controls.Add(this.txtCustomerName);
            this.gunaGroupBox1.Controls.Add(this.txtDateTime);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.txtTotalPrice);
            this.gunaGroupBox1.Controls.Add(this.label5);
            this.gunaGroupBox1.Controls.Add(this.txtQuantity);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.txtUsageID);
            this.gunaGroupBox1.Controls.Add(this.lblUsageID);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(20, 20);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(406, 600);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.Text = "Chi tiết Sử dụng Dịch vụ";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.BaseColor = System.Drawing.Color.White;
            this.txtStatus.BorderColor = System.Drawing.Color.Silver;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.FocusedBaseColor = System.Drawing.Color.White;
            this.txtStatus.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtStatus.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStatus.Location = new System.Drawing.Point(140, 444);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.ReadOnly = true;
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(238, 30);
            this.txtStatus.TabIndex = 19;
            // 
            // txtServiceName
            // 
            this.txtServiceName.BackColor = System.Drawing.Color.Transparent;
            this.txtServiceName.BaseColor = System.Drawing.Color.White;
            this.txtServiceName.BorderColor = System.Drawing.Color.Silver;
            this.txtServiceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtServiceName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtServiceName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtServiceName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServiceName.Location = new System.Drawing.Point(140, 262);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PasswordChar = '\0';
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.Size = new System.Drawing.Size(238, 30);
            this.txtServiceName.TabIndex = 18;
            // 
            // txtRoomName
            // 
            this.txtRoomName.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomName.BaseColor = System.Drawing.Color.White;
            this.txtRoomName.BorderColor = System.Drawing.Color.Silver;
            this.txtRoomName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRoomName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRoomName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomName.Location = new System.Drawing.Point(140, 202);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.PasswordChar = '\0';
            this.txtRoomName.ReadOnly = true;
            this.txtRoomName.SelectedText = "";
            this.txtRoomName.Size = new System.Drawing.Size(238, 30);
            this.txtRoomName.TabIndex = 17;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerName.BaseColor = System.Drawing.Color.White;
            this.txtCustomerName.BorderColor = System.Drawing.Color.Silver;
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCustomerName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCustomerName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerName.Location = new System.Drawing.Point(134, 145);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(244, 30);
            this.txtCustomerName.TabIndex = 16;
            // 
            // txtDateTime
            // 
            this.txtDateTime.BackColor = System.Drawing.Color.Transparent;
            this.txtDateTime.BaseColor = System.Drawing.Color.White;
            this.txtDateTime.BorderColor = System.Drawing.Color.Silver;
            this.txtDateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateTime.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDateTime.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDateTime.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDateTime.Location = new System.Drawing.Point(140, 500);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.PasswordChar = '\0';
            this.txtDateTime.ReadOnly = true;
            this.txtDateTime.SelectedText = "";
            this.txtDateTime.Size = new System.Drawing.Size(238, 30);
            this.txtDateTime.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(20, 505);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Thời gian sử dụng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(20, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trạng thái:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalPrice.BaseColor = System.Drawing.Color.White;
            this.txtTotalPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTotalPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotalPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalPrice.Location = new System.Drawing.Point(140, 380);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(238, 30);
            this.txtTotalPrice.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(20, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng tiền:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantity.BaseColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.Silver;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.Location = new System.Drawing.Point(140, 320);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(238, 30);
            this.txtQuantity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(20, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(20, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên dịch vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(20, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(20, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên khách hàng:";
            // 
            // txtUsageID
            // 
            this.txtUsageID.BackColor = System.Drawing.Color.Transparent;
            this.txtUsageID.BaseColor = System.Drawing.Color.White;
            this.txtUsageID.BorderColor = System.Drawing.Color.Silver;
            this.txtUsageID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsageID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsageID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUsageID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsageID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsageID.Location = new System.Drawing.Point(140, 80);
            this.txtUsageID.Name = "txtUsageID";
            this.txtUsageID.PasswordChar = '\0';
            this.txtUsageID.ReadOnly = true;
            this.txtUsageID.SelectedText = "";
            this.txtUsageID.Size = new System.Drawing.Size(238, 30);
            this.txtUsageID.TabIndex = 1;
            // 
            // lblUsageID
            // 
            this.lblUsageID.AutoSize = true;
            this.lblUsageID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsageID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUsageID.Location = new System.Drawing.Point(20, 85);
            this.lblUsageID.Name = "lblUsageID";
            this.lblUsageID.Size = new System.Drawing.Size(86, 19);
            this.lblUsageID.TabIndex = 0;
            this.lblUsageID.Text = "Mã sử dụng:";
            // 
            // frmServiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServiceManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Dịch vụ";
            this.Load += new System.EventHandler(this.frmServiceManagement_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceUsage)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        // Controls declaration
        private Guna.UI.WinForms.GunaPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaPanel pnlMain;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.DataGridView dgvServiceUsage;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaTextBox txtUsageID;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private Guna.UI.WinForms.GunaTextBox txtTotalPrice;
        private Guna.UI.WinForms.GunaTextBox txtDateTime;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblUsageID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtCustomerName;
        private Guna.UI.WinForms.GunaTextBox txtStatus;
        private Guna.UI.WinForms.GunaTextBox txtServiceName;
        private Guna.UI.WinForms.GunaTextBox txtRoomName;
        private Guna.UI.WinForms.GunaButton btnExportPDF;
        private Guna.UI.WinForms.GunaComboBox cboFilterKhachHang;
        private System.Windows.Forms.Label lblFilterKhachHang;
        private Guna.UI.WinForms.GunaComboBox cboFilterRoom;
        private System.Windows.Forms.Label lblFilterRoom;
        private Guna.UI.WinForms.GunaComboBox cboFilterService;
        private System.Windows.Forms.Label lblFilterService;
    }
}