namespace HotelManagement
{
    partial class frmServiceProvision
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
            this.gunaGroupBox3 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvServiceList = new System.Windows.Forms.DataGridView();
            this.txtTotalAmount = new Guna.UI.WinForms.GunaTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConfirmService = new Guna.UI.WinForms.GunaButton();
            this.btnClearAll = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.cmbStaff = new Guna.UI.WinForms.GunaComboBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.txtServiceName = new Guna.UI.WinForms.GunaTextBox();
            this.txtUnitPrice = new Guna.UI.WinForms.GunaTextBox();
            this.txtServiceTotal = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemoveService = new Guna.UI.WinForms.GunaButton();
            this.btnAddService = new Guna.UI.WinForms.GunaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategory = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServiceID = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.txtSearchBooking = new Guna.UI.WinForms.GunaTextBox();
            this.btnSearchBooking = new Guna.UI.WinForms.GunaButton();
            this.lblSearchBooking = new System.Windows.Forms.Label();
            this.txtBookingID = new Guna.UI.WinForms.GunaTextBox();
            this.txtCustomerName = new Guna.UI.WinForms.GunaTextBox();
            this.txtRoomName = new Guna.UI.WinForms.GunaTextBox();
            this.txtBookingStatus = new Guna.UI.WinForms.GunaTextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblRoomName = new System.Windows.Forms.Label();
            this.lblBookingStatus = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gunaGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).BeginInit();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1569, 74);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(27, 18);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Cung cấp Dịch vụ";
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
            this.btnClose.Location = new System.Drawing.Point(1503, 18);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClose.OnHoverImage = null;
            this.btnClose.OnPressedColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(53, 37);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlMain.Controls.Add(this.gunaGroupBox3);
            this.pnlMain.Controls.Add(this.gunaGroupBox2);
            this.pnlMain.Controls.Add(this.gunaGroupBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 74);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1569, 1007);
            this.pnlMain.TabIndex = 1;
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox3.BackColor = System.Drawing.Color.White;
            this.gunaGroupBox3.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox3.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox3.Controls.Add(this.dgvServiceList);
            this.gunaGroupBox3.Controls.Add(this.txtTotalAmount);
            this.gunaGroupBox3.Controls.Add(this.label11);
            this.gunaGroupBox3.Controls.Add(this.btnConfirmService);
            this.gunaGroupBox3.Controls.Add(this.btnClearAll);
            this.gunaGroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox3.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox3.Location = new System.Drawing.Point(825, 345);
            this.gunaGroupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Size = new System.Drawing.Size(740, 640);
            this.gunaGroupBox3.TabIndex = 2;
            this.gunaGroupBox3.Text = "Danh sách Dịch vụ đã chọn";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvServiceList
            // 
            this.dgvServiceList.AllowUserToAddRows = false;
            this.dgvServiceList.AllowUserToDeleteRows = false;
            this.dgvServiceList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceList.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceList.Location = new System.Drawing.Point(27, 49);
            this.dgvServiceList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvServiceList.Name = "dgvServiceList";
            this.dgvServiceList.ReadOnly = true;
            this.dgvServiceList.RowHeadersWidth = 51;
            this.dgvServiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceList.Size = new System.Drawing.Size(685, 246);
            this.dgvServiceList.TabIndex = 4;
            this.dgvServiceList.SelectionChanged += new System.EventHandler(this.dgvServiceList_SelectionChanged);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalAmount.BaseColor = System.Drawing.Color.White;
            this.txtTotalAmount.BorderColor = System.Drawing.Color.Silver;
            this.txtTotalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalAmount.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTotalAmount.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotalAmount.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTotalAmount.Location = new System.Drawing.Point(497, 318);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.Size = new System.Drawing.Size(187, 37);
            this.txtTotalAmount.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(364, 324);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 23);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tổng cộng:";
            // 
            // btnConfirmService
            // 
            this.btnConfirmService.AnimationHoverSpeed = 0.07F;
            this.btnConfirmService.AnimationSpeed = 0.03F;
            this.btnConfirmService.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfirmService.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmService.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirmService.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirmService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirmService.ForeColor = System.Drawing.Color.White;
            this.btnConfirmService.Image = null;
            this.btnConfirmService.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirmService.Location = new System.Drawing.Point(237, 529);
            this.btnConfirmService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmService.Name = "btnConfirmService";
            this.btnConfirmService.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnConfirmService.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirmService.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirmService.OnHoverImage = null;
            this.btnConfirmService.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirmService.Size = new System.Drawing.Size(133, 37);
            this.btnConfirmService.TabIndex = 1;
            this.btnConfirmService.Text = "Xác nhận";
            this.btnConfirmService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirmService.Click += new System.EventHandler(this.btnConfirmService_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.AnimationHoverSpeed = 0.07F;
            this.btnClearAll.AnimationSpeed = 0.03F;
            this.btnClearAll.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClearAll.BorderColor = System.Drawing.Color.Black;
            this.btnClearAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClearAll.FocusedColor = System.Drawing.Color.Empty;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Image = null;
            this.btnClearAll.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClearAll.Location = new System.Drawing.Point(77, 529);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnClearAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClearAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClearAll.OnHoverImage = null;
            this.btnClearAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnClearAll.Size = new System.Drawing.Size(133, 37);
            this.btnClearAll.TabIndex = 0;
            this.btnClearAll.Text = "Xóa tất cả";
            this.btnClearAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.cmbStaff);
            this.gunaGroupBox2.Controls.Add(this.lblStaff);
            this.gunaGroupBox2.Controls.Add(this.txtServiceName);
            this.gunaGroupBox2.Controls.Add(this.txtUnitPrice);
            this.gunaGroupBox2.Controls.Add(this.txtServiceTotal);
            this.gunaGroupBox2.Controls.Add(this.label10);
            this.gunaGroupBox2.Controls.Add(this.numQuantity);
            this.gunaGroupBox2.Controls.Add(this.label9);
            this.gunaGroupBox2.Controls.Add(this.btnRemoveService);
            this.gunaGroupBox2.Controls.Add(this.btnAddService);
            this.gunaGroupBox2.Controls.Add(this.label8);
            this.gunaGroupBox2.Controls.Add(this.txtCategory);
            this.gunaGroupBox2.Controls.Add(this.label7);
            this.gunaGroupBox2.Controls.Add(this.label6);
            this.gunaGroupBox2.Controls.Add(this.txtServiceID);
            this.gunaGroupBox2.Controls.Add(this.label5);
            this.gunaGroupBox2.Controls.Add(this.dgvServices);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(27, 345);
            this.gunaGroupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(792, 640);
            this.gunaGroupBox2.TabIndex = 1;
            this.gunaGroupBox2.Text = "Chọn Dịch vụ";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cmbStaff
            // 
            this.cmbStaff.BackColor = System.Drawing.Color.Transparent;
            this.cmbStaff.BaseColor = System.Drawing.Color.White;
            this.cmbStaff.BorderColor = System.Drawing.Color.Silver;
            this.cmbStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaff.FocusedColor = System.Drawing.Color.Empty;
            this.cmbStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStaff.ForeColor = System.Drawing.Color.Black;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(172, 514);
            this.cmbStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbStaff.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbStaff.Size = new System.Drawing.Size(269, 31);
            this.cmbStaff.TabIndex = 27;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStaff.Location = new System.Drawing.Point(31, 518);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(92, 23);
            this.lblStaff.TabIndex = 26;
            this.lblStaff.Text = "Nhân viên:";
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
            this.txtServiceName.Location = new System.Drawing.Point(172, 363);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PasswordChar = '\0';
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.Size = new System.Drawing.Size(271, 37);
            this.txtServiceName.TabIndex = 25;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtUnitPrice.BaseColor = System.Drawing.Color.White;
            this.txtUnitPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtUnitPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUnitPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUnitPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUnitPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUnitPrice.Location = new System.Drawing.Point(172, 464);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PasswordChar = '\0';
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.SelectedText = "";
            this.txtUnitPrice.Size = new System.Drawing.Size(271, 37);
            this.txtUnitPrice.TabIndex = 24;
            // 
            // txtServiceTotal
            // 
            this.txtServiceTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtServiceTotal.BaseColor = System.Drawing.Color.White;
            this.txtServiceTotal.BorderColor = System.Drawing.Color.Silver;
            this.txtServiceTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceTotal.FocusedBaseColor = System.Drawing.Color.White;
            this.txtServiceTotal.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtServiceTotal.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtServiceTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServiceTotal.Location = new System.Drawing.Point(613, 414);
            this.txtServiceTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServiceTotal.Name = "txtServiceTotal";
            this.txtServiceTotal.PasswordChar = '\0';
            this.txtServiceTotal.ReadOnly = true;
            this.txtServiceTotal.SelectedText = "";
            this.txtServiceTotal.Size = new System.Drawing.Size(149, 37);
            this.txtServiceTotal.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(484, 414);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Thành tiền:";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numQuantity.Location = new System.Drawing.Point(613, 363);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(149, 27);
            this.numQuantity.TabIndex = 12;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(489, 362);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Số lượng:";
            // 
            // btnRemoveService
            // 
            this.btnRemoveService.AnimationHoverSpeed = 0.07F;
            this.btnRemoveService.AnimationSpeed = 0.03F;
            this.btnRemoveService.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnRemoveService.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveService.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemoveService.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemoveService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveService.ForeColor = System.Drawing.Color.White;
            this.btnRemoveService.Image = null;
            this.btnRemoveService.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRemoveService.Location = new System.Drawing.Point(331, 564);
            this.btnRemoveService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnRemoveService.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemoveService.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRemoveService.OnHoverImage = null;
            this.btnRemoveService.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemoveService.Size = new System.Drawing.Size(133, 37);
            this.btnRemoveService.TabIndex = 10;
            this.btnRemoveService.Text = "Xóa dịch vụ";
            this.btnRemoveService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemoveService.Click += new System.EventHandler(this.btnRemoveService_Click);
            // 
            // btnAddService
            // 
            this.btnAddService.AnimationHoverSpeed = 0.07F;
            this.btnAddService.AnimationSpeed = 0.03F;
            this.btnAddService.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAddService.BorderColor = System.Drawing.Color.Black;
            this.btnAddService.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddService.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddService.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddService.ForeColor = System.Drawing.Color.White;
            this.btnAddService.Image = null;
            this.btnAddService.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddService.Location = new System.Drawing.Point(152, 564);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAddService.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddService.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddService.OnHoverImage = null;
            this.btnAddService.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddService.Size = new System.Drawing.Size(133, 37);
            this.btnAddService.TabIndex = 9;
            this.btnAddService.Text = "Thêm dịch vụ";
            this.btnAddService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(39, 464);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Đơn giá:";
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtCategory.BaseColor = System.Drawing.Color.White;
            this.txtCategory.BorderColor = System.Drawing.Color.Silver;
            this.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCategory.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCategory.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategory.Location = new System.Drawing.Point(172, 414);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.ReadOnly = true;
            this.txtCategory.SelectedText = "";
            this.txtCategory.Size = new System.Drawing.Size(271, 37);
            this.txtCategory.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(39, 414);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Danh mục:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(39, 363);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên dịch vụ:";
            // 
            // txtServiceID
            // 
            this.txtServiceID.BackColor = System.Drawing.Color.Transparent;
            this.txtServiceID.BaseColor = System.Drawing.Color.White;
            this.txtServiceID.BorderColor = System.Drawing.Color.Silver;
            this.txtServiceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtServiceID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtServiceID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtServiceID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServiceID.Location = new System.Drawing.Point(172, 315);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.PasswordChar = '\0';
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.SelectedText = "";
            this.txtServiceID.Size = new System.Drawing.Size(271, 37);
            this.txtServiceID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(39, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã dịch vụ:";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(27, 49);
            this.dgvServices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(736, 246);
            this.dgvServices.TabIndex = 0;
            this.dgvServices.SelectionChanged += new System.EventHandler(this.dgvServices_SelectionChanged);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.dgvBookings);
            this.gunaGroupBox1.Controls.Add(this.txtSearchBooking);
            this.gunaGroupBox1.Controls.Add(this.btnSearchBooking);
            this.gunaGroupBox1.Controls.Add(this.lblSearchBooking);
            this.gunaGroupBox1.Controls.Add(this.txtBookingID);
            this.gunaGroupBox1.Controls.Add(this.txtCustomerName);
            this.gunaGroupBox1.Controls.Add(this.txtRoomName);
            this.gunaGroupBox1.Controls.Add(this.txtBookingStatus);
            this.gunaGroupBox1.Controls.Add(this.lblBookingID);
            this.gunaGroupBox1.Controls.Add(this.lblCustomerName);
            this.gunaGroupBox1.Controls.Add(this.lblRoomName);
            this.gunaGroupBox1.Controls.Add(this.lblBookingStatus);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(27, 43);
            this.gunaGroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(1539, 283);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Chọn Booking";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.White;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(27, 42);
            this.dgvBookings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(1063, 148);
            this.dgvBookings.TabIndex = 0;
            this.dgvBookings.SelectionChanged += new System.EventHandler(this.dgvBookings_SelectionChanged);
            // 
            // txtSearchBooking
            // 
            this.txtSearchBooking.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchBooking.BaseColor = System.Drawing.Color.White;
            this.txtSearchBooking.BorderColor = System.Drawing.Color.Silver;
            this.txtSearchBooking.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchBooking.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearchBooking.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearchBooking.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchBooking.Location = new System.Drawing.Point(107, 209);
            this.txtSearchBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearchBooking.Name = "txtSearchBooking";
            this.txtSearchBooking.PasswordChar = '\0';
            this.txtSearchBooking.SelectedText = "";
            this.txtSearchBooking.Size = new System.Drawing.Size(267, 37);
            this.txtSearchBooking.TabIndex = 1;
            this.txtSearchBooking.TextChanged += new System.EventHandler(this.txtSearchBooking_TextChanged);
            // 
            // btnSearchBooking
            // 
            this.btnSearchBooking.AnimationHoverSpeed = 0.07F;
            this.btnSearchBooking.AnimationSpeed = 0.03F;
            this.btnSearchBooking.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearchBooking.BorderColor = System.Drawing.Color.Black;
            this.btnSearchBooking.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearchBooking.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearchBooking.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchBooking.ForeColor = System.Drawing.Color.White;
            this.btnSearchBooking.Image = null;
            this.btnSearchBooking.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearchBooking.Location = new System.Drawing.Point(387, 209);
            this.btnSearchBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchBooking.Name = "btnSearchBooking";
            this.btnSearchBooking.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearchBooking.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearchBooking.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearchBooking.OnHoverImage = null;
            this.btnSearchBooking.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearchBooking.Size = new System.Drawing.Size(120, 37);
            this.btnSearchBooking.TabIndex = 2;
            this.btnSearchBooking.Text = "Tìm kiếm";
            this.btnSearchBooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearchBooking.Click += new System.EventHandler(this.btnSearchBooking_Click);
            // 
            // lblSearchBooking
            // 
            this.lblSearchBooking.AutoSize = true;
            this.lblSearchBooking.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearchBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSearchBooking.Location = new System.Drawing.Point(27, 215);
            this.lblSearchBooking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBooking.Name = "lblSearchBooking";
            this.lblSearchBooking.Size = new System.Drawing.Size(83, 23);
            this.lblSearchBooking.TabIndex = 3;
            this.lblSearchBooking.Text = "Tìm kiếm:";
            // 
            // txtBookingID
            // 
            this.txtBookingID.BackColor = System.Drawing.Color.Transparent;
            this.txtBookingID.BaseColor = System.Drawing.Color.White;
            this.txtBookingID.BorderColor = System.Drawing.Color.Silver;
            this.txtBookingID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookingID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookingID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookingID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookingID.Location = new System.Drawing.Point(1289, 54);
            this.txtBookingID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.PasswordChar = '\0';
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.SelectedText = "";
            this.txtBookingID.Size = new System.Drawing.Size(240, 37);
            this.txtBookingID.TabIndex = 4;
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
            this.txtCustomerName.Location = new System.Drawing.Point(1289, 103);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(240, 37);
            this.txtCustomerName.TabIndex = 5;
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
            this.txtRoomName.Location = new System.Drawing.Point(1289, 153);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.PasswordChar = '\0';
            this.txtRoomName.ReadOnly = true;
            this.txtRoomName.SelectedText = "";
            this.txtRoomName.Size = new System.Drawing.Size(240, 37);
            this.txtRoomName.TabIndex = 6;
            // 
            // txtBookingStatus
            // 
            this.txtBookingStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtBookingStatus.BaseColor = System.Drawing.Color.White;
            this.txtBookingStatus.BorderColor = System.Drawing.Color.Silver;
            this.txtBookingStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookingStatus.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBookingStatus.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBookingStatus.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBookingStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBookingStatus.Location = new System.Drawing.Point(1289, 202);
            this.txtBookingStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBookingStatus.Name = "txtBookingStatus";
            this.txtBookingStatus.PasswordChar = '\0';
            this.txtBookingStatus.ReadOnly = true;
            this.txtBookingStatus.SelectedText = "";
            this.txtBookingStatus.Size = new System.Drawing.Size(240, 37);
            this.txtBookingStatus.TabIndex = 7;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBookingID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBookingID.Location = new System.Drawing.Point(1137, 62);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(105, 23);
            this.lblBookingID.TabIndex = 8;
            this.lblBookingID.Text = "Mã booking:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCustomerName.Location = new System.Drawing.Point(1108, 117);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(134, 23);
            this.lblCustomerName.TabIndex = 9;
            this.lblCustomerName.Text = "Tên khách hàng:";
            // 
            // lblRoomName
            // 
            this.lblRoomName.AutoSize = true;
            this.lblRoomName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoomName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRoomName.Location = new System.Drawing.Point(1157, 166);
            this.lblRoomName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomName.Name = "lblRoomName";
            this.lblRoomName.Size = new System.Drawing.Size(88, 23);
            this.lblRoomName.TabIndex = 10;
            this.lblRoomName.Text = "Số phòng:";
            // 
            // lblBookingStatus
            // 
            this.lblBookingStatus.AutoSize = true;
            this.lblBookingStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBookingStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBookingStatus.Location = new System.Drawing.Point(1155, 209);
            this.lblBookingStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingStatus.Name = "lblBookingStatus";
            this.lblBookingStatus.Size = new System.Drawing.Size(91, 23);
            this.lblBookingStatus.TabIndex = 11;
            this.lblBookingStatus.Text = "Trạng thái:";
            // 
            // frmServiceProvision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 1081);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmServiceProvision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cung cấp Dịch vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.gunaGroupBox3.ResumeLayout(false);
            this.gunaGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).EndInit();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.ResumeLayout(false);

        }

        // Controls declaration
        private Guna.UI.WinForms.GunaPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaPanel pnlMain;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private System.Windows.Forms.DataGridView dgvServiceList;
        private Guna.UI.WinForms.GunaTextBox txtTotalAmount;
        private Guna.UI.WinForms.GunaButton btnConfirmService;
        private Guna.UI.WinForms.GunaButton btnClearAll;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaTextBox txtServiceTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaButton btnRemoveService;
        private Guna.UI.WinForms.GunaButton btnAddService;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvServices;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.DataGridView dgvBookings;
        private Guna.UI.WinForms.GunaTextBox txtSearchBooking;
        private Guna.UI.WinForms.GunaButton btnSearchBooking;
        private System.Windows.Forms.Label lblSearchBooking;
        private Guna.UI.WinForms.GunaTextBox txtBookingID;
        private Guna.UI.WinForms.GunaTextBox txtCustomerName;
        private Guna.UI.WinForms.GunaTextBox txtRoomName;
        private Guna.UI.WinForms.GunaTextBox txtBookingStatus;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblRoomName;
        private System.Windows.Forms.Label lblBookingStatus;
        private Guna.UI.WinForms.GunaComboBox cmbStaff;
        private System.Windows.Forms.Label lblStaff;
        private Guna.UI.WinForms.GunaTextBox txtServiceName;
        private Guna.UI.WinForms.GunaTextBox txtUnitPrice;
        private Guna.UI.WinForms.GunaTextBox txtServiceID;
    }
}