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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.btnSuaDV = new Guna.UI.WinForms.GunaButton();
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.gunaComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaComboBox3 = new Guna.UI.WinForms.GunaComboBox();
            this.txtServiceID = new Guna.UI.WinForms.GunaTextBox();
            this.gunaComboBox4 = new Guna.UI.WinForms.GunaComboBox();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gunaGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceList)).BeginInit();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1542, 74);
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
            this.btnClose.Location = new System.Drawing.Point(1475, 18);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
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
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 74);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1542, 1006);
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
            this.gunaGroupBox3.Location = new System.Drawing.Point(798, 43);
            this.gunaGroupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Size = new System.Drawing.Size(740, 940);
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
            this.dgvServiceList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServiceList.Name = "dgvServiceList";
            this.dgvServiceList.ReadOnly = true;
            this.dgvServiceList.RowHeadersWidth = 51;
            this.dgvServiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServiceList.Size = new System.Drawing.Size(686, 402);
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
            this.txtTotalAmount.Location = new System.Drawing.Point(497, 475);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(4);
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
            this.label11.Location = new System.Drawing.Point(364, 481);
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
            this.btnConfirmService.Location = new System.Drawing.Point(237, 801);
            this.btnConfirmService.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnClearAll.Location = new System.Drawing.Point(77, 801);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4);
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
            this.gunaGroupBox2.Controls.Add(this.gunaComboBox4);
            this.gunaGroupBox2.Controls.Add(this.gunaComboBox3);
            this.gunaGroupBox2.Controls.Add(this.gunaComboBox2);
            this.gunaGroupBox2.Controls.Add(this.label2);
            this.gunaGroupBox2.Controls.Add(this.label1);
            this.gunaGroupBox2.Controls.Add(this.gunaComboBox1);
            this.gunaGroupBox2.Controls.Add(this.btnSuaDV);
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
            this.gunaGroupBox2.Location = new System.Drawing.Point(27, 43);
            this.gunaGroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(792, 940);
            this.gunaGroupBox2.TabIndex = 1;
            this.gunaGroupBox2.Text = "Chọn Dịch vụ";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(396, 554);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(404, 500);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã phòng:";
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Location = new System.Drawing.Point(172, 604);
            this.gunaComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(212, 31);
            this.gunaComboBox1.TabIndex = 16;
            // 
            // btnSuaDV
            // 
            this.btnSuaDV.AnimationHoverSpeed = 0.07F;
            this.btnSuaDV.AnimationSpeed = 0.03F;
            this.btnSuaDV.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSuaDV.BorderColor = System.Drawing.Color.Black;
            this.btnSuaDV.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSuaDV.FocusedColor = System.Drawing.Color.Empty;
            this.btnSuaDV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSuaDV.ForeColor = System.Drawing.Color.White;
            this.btnSuaDV.Image = null;
            this.btnSuaDV.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSuaDV.Location = new System.Drawing.Point(520, 801);
            this.btnSuaDV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSuaDV.Name = "btnSuaDV";
            this.btnSuaDV.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnSuaDV.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSuaDV.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSuaDV.OnHoverImage = null;
            this.btnSuaDV.OnPressedColor = System.Drawing.Color.Black;
            this.btnSuaDV.Size = new System.Drawing.Size(133, 37);
            this.btnSuaDV.TabIndex = 15;
            this.btnSuaDV.Text = "Sửa dịch vụ";
            this.btnSuaDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtServiceTotal.Location = new System.Drawing.Point(550, 649);
            this.txtServiceTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceTotal.Name = "txtServiceTotal";
            this.txtServiceTotal.PasswordChar = '\0';
            this.txtServiceTotal.ReadOnly = true;
            this.txtServiceTotal.SelectedText = "";
            this.txtServiceTotal.Size = new System.Drawing.Size(213, 37);
            this.txtServiceTotal.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label10.Location = new System.Drawing.Point(403, 655);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "Thành tiền:";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numQuantity.Location = new System.Drawing.Point(550, 604);
            this.numQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(213, 27);
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
            this.label9.Location = new System.Drawing.Point(403, 606);
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
            this.btnRemoveService.Location = new System.Drawing.Point(340, 801);
            this.btnRemoveService.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnAddService.Location = new System.Drawing.Point(161, 801);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(4);
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
            this.label8.Location = new System.Drawing.Point(39, 649);
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
            this.txtCategory.Location = new System.Drawing.Point(172, 649);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.ReadOnly = true;
            this.txtCategory.SelectedText = "";
            this.txtCategory.Size = new System.Drawing.Size(213, 37);
            this.txtCategory.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label7.Location = new System.Drawing.Point(39, 604);
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
            this.label6.Location = new System.Drawing.Point(39, 554);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên dịch vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(39, 500);
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
            this.dgvServices.Margin = new System.Windows.Forms.Padding(4);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersWidth = 51;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(736, 402);
            this.dgvServices.TabIndex = 0;
            this.dgvServices.SelectionChanged += new System.EventHandler(this.dgvServices_SelectionChanged);
            // 
            // gunaComboBox2
            // 
            this.gunaComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox2.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox2.FormattingEnabled = true;
            this.gunaComboBox2.Location = new System.Drawing.Point(550, 496);
            this.gunaComboBox2.Name = "gunaComboBox2";
            this.gunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox2.Size = new System.Drawing.Size(213, 31);
            this.gunaComboBox2.TabIndex = 21;
            // 
            // gunaComboBox3
            // 
            this.gunaComboBox3.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox3.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox3.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox3.FormattingEnabled = true;
            this.gunaComboBox3.Location = new System.Drawing.Point(550, 549);
            this.gunaComboBox3.Name = "gunaComboBox3";
            this.gunaComboBox3.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox3.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox3.Size = new System.Drawing.Size(214, 31);
            this.gunaComboBox3.TabIndex = 22;
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
            this.txtServiceID.Location = new System.Drawing.Point(172, 498);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.PasswordChar = '\0';
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.SelectedText = "";
            this.txtServiceID.Size = new System.Drawing.Size(213, 37);
            this.txtServiceID.TabIndex = 2;
            // 
            // gunaComboBox4
            // 
            this.gunaComboBox4.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox4.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox4.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox4.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox4.FormattingEnabled = true;
            this.gunaComboBox4.Location = new System.Drawing.Point(172, 554);
            this.gunaComboBox4.Name = "gunaComboBox4";
            this.gunaComboBox4.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox4.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox4.Size = new System.Drawing.Size(212, 31);
            this.gunaComboBox4.TabIndex = 23;
            // 
            // frmServiceProvision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 1080);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaButton btnSuaDV;
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
        private Guna.UI.WinForms.GunaComboBox gunaComboBox3;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox2;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox4;
        private Guna.UI.WinForms.GunaTextBox txtServiceID;
    }
}