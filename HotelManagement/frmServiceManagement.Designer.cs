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
            this.pnlMain = new Guna.UI.WinForms.GunaPanel();
            this.dgvServiceUsage = new System.Windows.Forms.DataGridView();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.cboFilterKhachHang = new Guna.UI.WinForms.GunaComboBox();
            this.lblFilterKhachHang = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.cboFilterRoom = new Guna.UI.WinForms.GunaComboBox();
            this.txtServiceName = new Guna.UI.WinForms.GunaTextBox();
            this.lblFilterRoom = new System.Windows.Forms.Label();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.cboFilterService = new Guna.UI.WinForms.GunaComboBox();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.lblFilterService = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.txtCustomerName = new Guna.UI.WinForms.GunaTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExportPDF = new Guna.UI.WinForms.GunaButton();
            this.txtStatus = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomName = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsageID = new Guna.UI.WinForms.GunaTextBox();
            this.txtDateTime = new Guna.UI.WinForms.GunaTextBox();
            this.lblUsageID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceUsage)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1365, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlMain.Controls.Add(this.gunaPanel1);
            this.pnlMain.Controls.Add(this.gunaGroupBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1365, 652);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvServiceUsage
            // 
            this.dgvServiceUsage.AllowUserToAddRows = false;
            this.dgvServiceUsage.AllowUserToDeleteRows = false;
            this.dgvServiceUsage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceUsage.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceUsage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceUsage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvServiceUsage.Location = new System.Drawing.Point(0, 0);
            this.dgvServiceUsage.Name = "dgvServiceUsage";
            this.dgvServiceUsage.ReadOnly = true;
            this.dgvServiceUsage.RowHeadersWidth = 51;
            this.dgvServiceUsage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceUsage.Size = new System.Drawing.Size(1365, 408);
            this.dgvServiceUsage.TabIndex = 6;
            this.dgvServiceUsage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceUsage_CellClick);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.gunaPanel3);
            this.gunaGroupBox1.Controls.Add(this.gunaPanel2);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(1365, 245);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.Text = "Chi tiết Sử dụng Dịch vụ";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            this.gunaGroupBox1.Click += new System.EventHandler(this.gunaGroupBox1_Click);
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
            this.cboFilterKhachHang.Location = new System.Drawing.Point(256, 111);
            this.cboFilterKhachHang.Name = "cboFilterKhachHang";
            this.cboFilterKhachHang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboFilterKhachHang.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboFilterKhachHang.Size = new System.Drawing.Size(200, 24);
            this.cboFilterKhachHang.TabIndex = 9;
            this.cboFilterKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboFilterKhachHang_SelectedIndexChanged);
            // 
            // lblFilterKhachHang
            // 
            this.lblFilterKhachHang.AutoSize = true;
            this.lblFilterKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFilterKhachHang.Location = new System.Drawing.Point(130, 113);
            this.lblFilterKhachHang.Name = "lblFilterKhachHang";
            this.lblFilterKhachHang.Size = new System.Drawing.Size(94, 15);
            this.lblFilterKhachHang.TabIndex = 10;
            this.lblFilterKhachHang.Text = "Lọc khách hàng:";
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
            this.btnRefresh.Location = new System.Drawing.Point(349, 55);
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
            this.cboFilterRoom.Location = new System.Drawing.Point(256, 147);
            this.cboFilterRoom.Name = "cboFilterRoom";
            this.cboFilterRoom.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboFilterRoom.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboFilterRoom.Size = new System.Drawing.Size(200, 24);
            this.cboFilterRoom.TabIndex = 11;
            this.cboFilterRoom.SelectedIndexChanged += new System.EventHandler(this.cboFilterRoom_SelectedIndexChanged);
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
            this.txtServiceName.Location = new System.Drawing.Point(135, 182);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PasswordChar = '\0';
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.Size = new System.Drawing.Size(238, 30);
            this.txtServiceName.TabIndex = 18;
            // 
            // lblFilterRoom
            // 
            this.lblFilterRoom.AutoSize = true;
            this.lblFilterRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFilterRoom.Location = new System.Drawing.Point(148, 150);
            this.lblFilterRoom.Name = "lblFilterRoom";
            this.lblFilterRoom.Size = new System.Drawing.Size(67, 15);
            this.lblFilterRoom.TabIndex = 12;
            this.lblFilterRoom.Text = "Lọc phòng:";
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
            this.btnSearch.Location = new System.Drawing.Point(249, 55);
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
            this.cboFilterService.Location = new System.Drawing.Point(256, 186);
            this.cboFilterService.Name = "cboFilterService";
            this.cboFilterService.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboFilterService.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboFilterService.Size = new System.Drawing.Size(200, 24);
            this.cboFilterService.TabIndex = 13;
            this.cboFilterService.SelectedIndexChanged += new System.EventHandler(this.cboFilterService_SelectedIndexChanged);
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
            this.txtQuantity.Location = new System.Drawing.Point(549, 97);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ReadOnly = true;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(238, 30);
            this.txtQuantity.TabIndex = 9;
            // 
            // lblFilterService
            // 
            this.lblFilterService.AutoSize = true;
            this.lblFilterService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFilterService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFilterService.Location = new System.Drawing.Point(148, 189);
            this.lblFilterService.Name = "lblFilterService";
            this.lblFilterService.Size = new System.Drawing.Size(71, 15);
            this.lblFilterService.TabIndex = 14;
            this.lblFilterService.Text = "Lọc dịch vụ:";
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
            this.txtSearch.Location = new System.Drawing.Point(77, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(156, 30);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            this.txtCustomerName.Location = new System.Drawing.Point(135, 102);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(238, 30);
            this.txtCustomerName.TabIndex = 16;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSearch.Location = new System.Drawing.Point(9, 62);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 19);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(430, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng:";
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
            this.btnExportPDF.Location = new System.Drawing.Point(448, 55);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnExportPDF.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExportPDF.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExportPDF.OnHoverImage = null;
            this.btnExportPDF.OnPressedColor = System.Drawing.Color.Black;
            this.btnExportPDF.Size = new System.Drawing.Size(86, 30);
            this.btnExportPDF.TabIndex = 8;
            this.btnExportPDF.Text = "Xuất PDF";
            this.btnExportPDF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
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
            this.txtStatus.Location = new System.Drawing.Point(549, 182);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.ReadOnly = true;
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(238, 30);
            this.txtStatus.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(10, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên khách hàng:";
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
            this.txtRoomName.Location = new System.Drawing.Point(135, 142);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.PasswordChar = '\0';
            this.txtRoomName.ReadOnly = true;
            this.txtRoomName.SelectedText = "";
            this.txtRoomName.Size = new System.Drawing.Size(238, 30);
            this.txtRoomName.TabIndex = 17;
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
            this.txtUsageID.Location = new System.Drawing.Point(135, 62);
            this.txtUsageID.Name = "txtUsageID";
            this.txtUsageID.PasswordChar = '\0';
            this.txtUsageID.ReadOnly = true;
            this.txtUsageID.SelectedText = "";
            this.txtUsageID.Size = new System.Drawing.Size(238, 30);
            this.txtUsageID.TabIndex = 1;
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
            this.txtDateTime.Location = new System.Drawing.Point(549, 57);
            this.txtDateTime.Name = "txtDateTime";
            this.txtDateTime.PasswordChar = '\0';
            this.txtDateTime.ReadOnly = true;
            this.txtDateTime.SelectedText = "";
            this.txtDateTime.Size = new System.Drawing.Size(238, 30);
            this.txtDateTime.TabIndex = 15;
            // 
            // lblUsageID
            // 
            this.lblUsageID.AutoSize = true;
            this.lblUsageID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsageID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUsageID.Location = new System.Drawing.Point(15, 68);
            this.lblUsageID.Name = "lblUsageID";
            this.lblUsageID.Size = new System.Drawing.Size(86, 19);
            this.lblUsageID.TabIndex = 0;
            this.lblUsageID.Text = "Mã sử dụng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(429, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Thời gian sử dụng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(429, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng tiền:";
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
            this.txtTotalPrice.Location = new System.Drawing.Point(549, 140);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.PasswordChar = '\0';
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.SelectedText = "";
            this.txtTotalPrice.Size = new System.Drawing.Size(238, 30);
            this.txtTotalPrice.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(429, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(15, 185);
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
            this.label2.Location = new System.Drawing.Point(15, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số phòng:";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.dgvServiceUsage);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 245);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1365, 408);
            this.gunaPanel1.TabIndex = 3;
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
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.txtServiceName);
            this.gunaPanel2.Controls.Add(this.txtUsageID);
            this.gunaPanel2.Controls.Add(this.txtQuantity);
            this.gunaPanel2.Controls.Add(this.label3);
            this.gunaPanel2.Controls.Add(this.label2);
            this.gunaPanel2.Controls.Add(this.txtCustomerName);
            this.gunaPanel2.Controls.Add(this.label6);
            this.gunaPanel2.Controls.Add(this.label4);
            this.gunaPanel2.Controls.Add(this.txtTotalPrice);
            this.gunaPanel2.Controls.Add(this.txtStatus);
            this.gunaPanel2.Controls.Add(this.label5);
            this.gunaPanel2.Controls.Add(this.label1);
            this.gunaPanel2.Controls.Add(this.label7);
            this.gunaPanel2.Controls.Add(this.txtRoomName);
            this.gunaPanel2.Controls.Add(this.lblUsageID);
            this.gunaPanel2.Controls.Add(this.txtDateTime);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(812, 245);
            this.gunaPanel2.TabIndex = 0;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.btnRefresh);
            this.gunaPanel3.Controls.Add(this.cboFilterKhachHang);
            this.gunaPanel3.Controls.Add(this.cboFilterService);
            this.gunaPanel3.Controls.Add(this.btnSearch);
            this.gunaPanel3.Controls.Add(this.lblFilterService);
            this.gunaPanel3.Controls.Add(this.lblFilterRoom);
            this.gunaPanel3.Controls.Add(this.lblFilterKhachHang);
            this.gunaPanel3.Controls.Add(this.txtSearch);
            this.gunaPanel3.Controls.Add(this.lblSearch);
            this.gunaPanel3.Controls.Add(this.cboFilterRoom);
            this.gunaPanel3.Controls.Add(this.btnExportPDF);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel3.Location = new System.Drawing.Point(818, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(547, 245);
            this.gunaPanel3.TabIndex = 1;
            // 
            // frmServiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 712);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceUsage)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        // Controls declaration
        private Guna.UI.WinForms.GunaPanel pnlHeader;
        private Guna.UI.WinForms.GunaPanel pnlMain;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
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
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
    }
}