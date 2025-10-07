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
            this.txtServiceTotal = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemoveService = new Guna.UI.WinForms.GunaButton();
            this.btnAddService = new Guna.UI.WinForms.GunaButton();
            this.txtUnitPrice = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCategory = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtServiceName = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServiceID = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtStatus = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCheckInDate = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomNumber = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookingID = new Guna.UI.WinForms.GunaTextBox();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.btnSearchBooking = new Guna.UI.WinForms.GunaButton();
            this.txtSearchBooking = new Guna.UI.WinForms.GunaTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
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
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1200, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 30);
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
            this.btnClose.Location = new System.Drawing.Point(1150, 15);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlMain.Controls.Add(this.gunaGroupBox3);
            this.pnlMain.Controls.Add(this.gunaGroupBox2);
            this.pnlMain.Controls.Add(this.gunaGroupBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 740);
            this.pnlMain.TabIndex = 1;
            // 
            // gunaGroupBox3
            // 
            this.gunaGroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox3.BackColor = System.Drawing.Color.Transparent;
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
            this.gunaGroupBox3.Location = new System.Drawing.Point(620, 240);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Size = new System.Drawing.Size(560, 480);
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
            this.dgvServiceList.BackgroundColor = System.Drawing.Color.White;
            this.dgvServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceList.Location = new System.Drawing.Point(20, 40);
            this.dgvServiceList.Name = "dgvServiceList";
            this.dgvServiceList.ReadOnly = true;
            this.dgvServiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceList.Size = new System.Drawing.Size(520, 350);
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
            this.txtTotalAmount.Location = new System.Drawing.Point(400, 400);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.PasswordChar = '\0';
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.SelectedText = "";
            this.txtTotalAmount.Size = new System.Drawing.Size(140, 30);
            this.txtTotalAmount.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label11.Location = new System.Drawing.Point(300, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 19);
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
            this.btnConfirmService.Location = new System.Drawing.Point(200, 440);
            this.btnConfirmService.Name = "btnConfirmService";
            this.btnConfirmService.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnConfirmService.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirmService.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirmService.OnHoverImage = null;
            this.btnConfirmService.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirmService.Size = new System.Drawing.Size(100, 30);
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
            this.btnClearAll.Location = new System.Drawing.Point(80, 440);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnClearAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClearAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClearAll.OnHoverImage = null;
            this.btnClearAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnClearAll.Size = new System.Drawing.Size(100, 30);
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
            this.gunaGroupBox2.Controls.Add(this.txtServiceTotal);
            this.gunaGroupBox2.Controls.Add(this.label10);
            this.gunaGroupBox2.Controls.Add(this.numQuantity);
            this.gunaGroupBox2.Controls.Add(this.label9);
            this.gunaGroupBox2.Controls.Add(this.btnRemoveService);
            this.gunaGroupBox2.Controls.Add(this.btnAddService);
            this.gunaGroupBox2.Controls.Add(this.txtUnitPrice);
            this.gunaGroupBox2.Controls.Add(this.label8);
            this.gunaGroupBox2.Controls.Add(this.txtCategory);
            this.gunaGroupBox2.Controls.Add(this.label7);
            this.gunaGroupBox2.Controls.Add(this.txtServiceName);
            this.gunaGroupBox2.Controls.Add(this.label6);
            this.gunaGroupBox2.Controls.Add(this.txtServiceID);
            this.gunaGroupBox2.Controls.Add(this.label5);
            this.gunaGroupBox2.Controls.Add(this.dgvServices);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(20, 240);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(580, 480);
            this.gunaGroupBox2.TabIndex = 1;
            this.gunaGroupBox2.Text = "Chọn Dịch vụ";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
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
            this.txtServiceTotal.Location = new System.Drawing.Point(400, 400);
            this.txtServiceTotal.Name = "txtServiceTotal";
            this.txtServiceTotal.PasswordChar = '\0';
            this.txtServiceTotal.ReadOnly = true;
            this.txtServiceTotal.SelectedText = "";
            this.txtServiceTotal.Size = new System.Drawing.Size(160, 30);
            this.txtServiceTotal.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(300, 405);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Thành tiền:";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numQuantity.Location = new System.Drawing.Point(400, 360);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(80, 23);
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
            this.label9.Location = new System.Drawing.Point(300, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
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
            this.btnRemoveService.Location = new System.Drawing.Point(200, 440);
            this.btnRemoveService.Name = "btnRemoveService";
            this.btnRemoveService.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnRemoveService.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemoveService.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRemoveService.OnHoverImage = null;
            this.btnRemoveService.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemoveService.Size = new System.Drawing.Size(100, 30);
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
            this.btnAddService.Location = new System.Drawing.Point(80, 440);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAddService.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddService.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddService.OnHoverImage = null;
            this.btnAddService.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddService.Size = new System.Drawing.Size(100, 30);
            this.btnAddService.TabIndex = 9;
            this.btnAddService.Text = "Thêm dịch vụ";
            this.btnAddService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
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
            this.txtUnitPrice.Location = new System.Drawing.Point(400, 320);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.PasswordChar = '\0';
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.SelectedText = "";
            this.txtUnitPrice.Size = new System.Drawing.Size(160, 30);
            this.txtUnitPrice.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label8.Location = new System.Drawing.Point(300, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
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
            this.txtCategory.Location = new System.Drawing.Point(400, 280);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.ReadOnly = true;
            this.txtCategory.SelectedText = "";
            this.txtCategory.Size = new System.Drawing.Size(160, 30);
            this.txtCategory.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(300, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Danh mục:";
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
            this.txtServiceName.Location = new System.Drawing.Point(400, 240);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PasswordChar = '\0';
            this.txtServiceName.ReadOnly = true;
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.Size = new System.Drawing.Size(160, 30);
            this.txtServiceName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(300, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
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
            this.txtServiceID.Location = new System.Drawing.Point(400, 200);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.PasswordChar = '\0';
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.SelectedText = "";
            this.txtServiceID.Size = new System.Drawing.Size(160, 30);
            this.txtServiceID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(300, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã dịch vụ:";
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(20, 40);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(260, 150);
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
            this.gunaGroupBox1.Controls.Add(this.txtStatus);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.txtCheckInDate);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.txtRoomNumber);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.txtCustomerName);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.txtBookingID);
            this.gunaGroupBox1.Controls.Add(this.lblBookingID);
            this.gunaGroupBox1.Controls.Add(this.dgvBookings);
            this.gunaGroupBox1.Controls.Add(this.btnSearchBooking);
            this.gunaGroupBox1.Controls.Add(this.txtSearchBooking);
            this.gunaGroupBox1.Controls.Add(this.lblSearch);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(25, 21);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(1160, 200);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Tìm kiếm Đặt phòng";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            this.gunaGroupBox1.Click += new System.EventHandler(this.gunaGroupBox1_Click);
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
            this.txtStatus.Location = new System.Drawing.Point(1000, 69);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.ReadOnly = true;
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(140, 30);
            this.txtStatus.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(905, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Trạng thái:";
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckInDate.BaseColor = System.Drawing.Color.White;
            this.txtCheckInDate.BorderColor = System.Drawing.Color.Silver;
            this.txtCheckInDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCheckInDate.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCheckInDate.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCheckInDate.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCheckInDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCheckInDate.Location = new System.Drawing.Point(719, 69);
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.PasswordChar = '\0';
            this.txtCheckInDate.ReadOnly = true;
            this.txtCheckInDate.SelectedText = "";
            this.txtCheckInDate.Size = new System.Drawing.Size(180, 30);
            this.txtCheckInDate.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(611, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ngày Check-in:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomNumber.BaseColor = System.Drawing.Color.White;
            this.txtRoomNumber.BorderColor = System.Drawing.Color.Silver;
            this.txtRoomNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNumber.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRoomNumber.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRoomNumber.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRoomNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomNumber.Location = new System.Drawing.Point(520, 69);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.PasswordChar = '\0';
            this.txtRoomNumber.ReadOnly = true;
            this.txtRoomNumber.SelectedText = "";
            this.txtRoomNumber.Size = new System.Drawing.Size(80, 30);
            this.txtRoomNumber.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(443, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số phòng:";
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
            this.txtCustomerName.Location = new System.Drawing.Point(130, 73);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(200, 26);
            this.txtCustomerName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên khách hàng:";
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
            this.txtBookingID.Location = new System.Drawing.Point(130, 34);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.PasswordChar = '\0';
            this.txtBookingID.ReadOnly = true;
            this.txtBookingID.SelectedText = "";
            this.txtBookingID.Size = new System.Drawing.Size(100, 26);
            this.txtBookingID.TabIndex = 5;
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBookingID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBookingID.Location = new System.Drawing.Point(16, 34);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(100, 19);
            this.lblBookingID.TabIndex = 4;
            this.lblBookingID.Text = "Mã đặt phòng:";
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
            this.dgvBookings.Location = new System.Drawing.Point(15, 111);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(1125, 69);
            this.dgvBookings.TabIndex = 3;
            this.dgvBookings.SelectionChanged += new System.EventHandler(this.dgvBookings_SelectionChanged);
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
            this.btnSearchBooking.Location = new System.Drawing.Point(475, 30);
            this.btnSearchBooking.Name = "btnSearchBooking";
            this.btnSearchBooking.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearchBooking.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearchBooking.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearchBooking.OnHoverImage = null;
            this.btnSearchBooking.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearchBooking.Size = new System.Drawing.Size(80, 30);
            this.btnSearchBooking.TabIndex = 2;
            this.btnSearchBooking.Text = "Tìm kiếm";
            this.btnSearchBooking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearchBooking.Click += new System.EventHandler(this.btnSearchBooking_Click);
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
            this.txtSearchBooking.Location = new System.Drawing.Point(369, 30);
            this.txtSearchBooking.Name = "txtSearchBooking";
            this.txtSearchBooking.PasswordChar = '\0';
            this.txtSearchBooking.SelectedText = "";
            this.txtSearchBooking.Size = new System.Drawing.Size(90, 30);
            this.txtSearchBooking.TabIndex = 1;
            this.txtSearchBooking.TextChanged += new System.EventHandler(this.txtSearchBooking_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSearch.Location = new System.Drawing.Point(288, 34);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 19);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // frmServiceProvision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServiceProvision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cung cấp Dịch vụ";
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
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.DataGridView dgvServiceList;
        private Guna.UI.WinForms.GunaTextBox txtSearchBooking;
        private Guna.UI.WinForms.GunaButton btnSearchBooking;
        private Guna.UI.WinForms.GunaTextBox txtBookingID;
        private Guna.UI.WinForms.GunaTextBox txtCustomerName;
        private Guna.UI.WinForms.GunaTextBox txtRoomNumber;
        private Guna.UI.WinForms.GunaTextBox txtCheckInDate;
        private Guna.UI.WinForms.GunaTextBox txtStatus;
        private Guna.UI.WinForms.GunaTextBox txtServiceID;
        private Guna.UI.WinForms.GunaTextBox txtServiceName;
        private Guna.UI.WinForms.GunaTextBox txtCategory;
        private Guna.UI.WinForms.GunaTextBox txtUnitPrice;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private Guna.UI.WinForms.GunaTextBox txtServiceTotal;
        private Guna.UI.WinForms.GunaTextBox txtTotalAmount;
        private Guna.UI.WinForms.GunaButton btnAddService;
        private Guna.UI.WinForms.GunaButton btnRemoveService;
        private Guna.UI.WinForms.GunaButton btnConfirmService;
        private Guna.UI.WinForms.GunaButton btnClearAll;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}