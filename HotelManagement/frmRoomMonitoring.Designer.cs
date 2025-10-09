namespace HotelManagement
{
    partial class frmRoomMonitoring
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
            this.dgvRoomEquipment = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvRoomServices = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtCheckInTime = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomer = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCondition = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatus = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRoomType = new Guna.UI.WinForms.GunaTextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.txtRoomNumber = new Guna.UI.WinForms.GunaTextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbRoomTypeFilter = new Guna.UI.WinForms.GunaComboBox();
            this.lblRoomTypeFilter = new System.Windows.Forms.Label();
            this.cmbStatusFilter = new Guna.UI.WinForms.GunaComboBox();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gunaGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomEquipment)).BeginInit();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomServices)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
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
            this.lblTitle.Size = new System.Drawing.Size(293, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Theo dõi Hoạt động Phòng";
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
            this.pnlMain.Controls.Add(this.gunaPanel1);
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
            this.gunaGroupBox3.Controls.Add(this.dgvRoomEquipment);
            this.gunaGroupBox3.Controls.Add(this.label6);
            this.gunaGroupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox3.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox3.Location = new System.Drawing.Point(820, 240);
            this.gunaGroupBox3.Name = "gunaGroupBox3";
            this.gunaGroupBox3.Size = new System.Drawing.Size(360, 230);
            this.gunaGroupBox3.TabIndex = 3;
            this.gunaGroupBox3.Text = "Thiết bị Phòng";
            this.gunaGroupBox3.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvRoomEquipment
            // 
            this.dgvRoomEquipment.AllowUserToAddRows = false;
            this.dgvRoomEquipment.AllowUserToDeleteRows = false;
            this.dgvRoomEquipment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoomEquipment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomEquipment.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomEquipment.Location = new System.Drawing.Point(20, 50);
            this.dgvRoomEquipment.Name = "dgvRoomEquipment";
            this.dgvRoomEquipment.ReadOnly = true;
            this.dgvRoomEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomEquipment.Size = new System.Drawing.Size(320, 160);
            this.dgvRoomEquipment.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label6.Location = new System.Drawing.Point(20, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thiết bị trong phòng:";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.dgvRoomServices);
            this.gunaGroupBox2.Controls.Add(this.label5);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(420, 240);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(380, 230);
            this.gunaGroupBox2.TabIndex = 2;
            this.gunaGroupBox2.Text = "Dịch vụ Phòng";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvRoomServices
            // 
            this.dgvRoomServices.AllowUserToAddRows = false;
            this.dgvRoomServices.AllowUserToDeleteRows = false;
            this.dgvRoomServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoomServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvRoomServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomServices.Location = new System.Drawing.Point(20, 50);
            this.dgvRoomServices.Name = "dgvRoomServices";
            this.dgvRoomServices.ReadOnly = true;
            this.dgvRoomServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRoomServices.Size = new System.Drawing.Size(340, 160);
            this.dgvRoomServices.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(20, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dịch vụ đang sử dụng:";
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.txtCheckInTime);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.txtCustomer);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.txtCondition);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.txtStatus);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.txtRoomType);
            this.gunaGroupBox1.Controls.Add(this.lblRoomType);
            this.gunaGroupBox1.Controls.Add(this.txtRoomNumber);
            this.gunaGroupBox1.Controls.Add(this.lblRoomNumber);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(20, 240);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(380, 480);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.Text = "Thông tin Phòng";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtCheckInTime
            // 
            this.txtCheckInTime.BackColor = System.Drawing.Color.Transparent;
            this.txtCheckInTime.BaseColor = System.Drawing.Color.White;
            this.txtCheckInTime.BorderColor = System.Drawing.Color.Silver;
            this.txtCheckInTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCheckInTime.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCheckInTime.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCheckInTime.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCheckInTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCheckInTime.Location = new System.Drawing.Point(140, 405);
            this.txtCheckInTime.Name = "txtCheckInTime";
            this.txtCheckInTime.PasswordChar = '\0';
            this.txtCheckInTime.ReadOnly = true;
            this.txtCheckInTime.SelectedText = "";
            this.txtCheckInTime.Size = new System.Drawing.Size(220, 30);
            this.txtCheckInTime.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(20, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thời gian Check-in:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomer.BaseColor = System.Drawing.Color.White;
            this.txtCustomer.BorderColor = System.Drawing.Color.Silver;
            this.txtCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomer.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCustomer.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCustomer.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomer.Location = new System.Drawing.Point(140, 340);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.PasswordChar = '\0';
            this.txtCustomer.ReadOnly = true;
            this.txtCustomer.SelectedText = "";
            this.txtCustomer.Size = new System.Drawing.Size(220, 30);
            this.txtCustomer.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(20, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Khách hàng:";
            // 
            // txtCondition
            // 
            this.txtCondition.BackColor = System.Drawing.Color.Transparent;
            this.txtCondition.BaseColor = System.Drawing.Color.White;
            this.txtCondition.BorderColor = System.Drawing.Color.Silver;
            this.txtCondition.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCondition.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCondition.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCondition.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCondition.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCondition.Location = new System.Drawing.Point(140, 280);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.PasswordChar = '\0';
            this.txtCondition.ReadOnly = true;
            this.txtCondition.SelectedText = "";
            this.txtCondition.Size = new System.Drawing.Size(220, 30);
            this.txtCondition.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(20, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tình trạng:";
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
            this.txtStatus.Location = new System.Drawing.Point(140, 220);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.ReadOnly = true;
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(220, 30);
            this.txtStatus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(20, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Trạng thái:";
            // 
            // txtRoomType
            // 
            this.txtRoomType.BackColor = System.Drawing.Color.Transparent;
            this.txtRoomType.BaseColor = System.Drawing.Color.White;
            this.txtRoomType.BorderColor = System.Drawing.Color.Silver;
            this.txtRoomType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomType.FocusedBaseColor = System.Drawing.Color.White;
            this.txtRoomType.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRoomType.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtRoomType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoomType.Location = new System.Drawing.Point(140, 160);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.PasswordChar = '\0';
            this.txtRoomType.ReadOnly = true;
            this.txtRoomType.SelectedText = "";
            this.txtRoomType.Size = new System.Drawing.Size(220, 30);
            this.txtRoomType.TabIndex = 3;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRoomType.Location = new System.Drawing.Point(20, 165);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(81, 19);
            this.lblRoomType.TabIndex = 2;
            this.lblRoomType.Text = "Loại phòng:";
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
            this.txtRoomNumber.Location = new System.Drawing.Point(140, 100);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.PasswordChar = '\0';
            this.txtRoomNumber.ReadOnly = true;
            this.txtRoomNumber.SelectedText = "";
            this.txtRoomNumber.Size = new System.Drawing.Size(220, 30);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRoomNumber.Location = new System.Drawing.Point(20, 105);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(71, 19);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "Số phòng:";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.gunaButton1);
            this.gunaPanel1.Controls.Add(this.dgvRooms);
            this.gunaPanel1.Controls.Add(this.btnRefresh);
            this.gunaPanel1.Controls.Add(this.btnSearch);
            this.gunaPanel1.Controls.Add(this.txtSearch);
            this.gunaPanel1.Controls.Add(this.lblSearch);
            this.gunaPanel1.Controls.Add(this.cmbRoomTypeFilter);
            this.gunaPanel1.Controls.Add(this.lblRoomTypeFilter);
            this.gunaPanel1.Controls.Add(this.cmbStatusFilter);
            this.gunaPanel1.Controls.Add(this.lblStatusFilter);
            this.gunaPanel1.Location = new System.Drawing.Point(20, 20);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1160, 200);
            this.gunaPanel1.TabIndex = 0;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(20, 60);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRooms.Size = new System.Drawing.Size(1120, 120);
            this.dgvRooms.TabIndex = 8;
            this.dgvRooms.SelectionChanged += new System.EventHandler(this.dgvRooms_SelectionChanged);
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
            this.btnRefresh.Location = new System.Drawing.Point(1000, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.TabIndex = 7;
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
            this.btnSearch.Location = new System.Drawing.Point(895, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(80, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(200, 30);
            this.txtSearch.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSearch.Location = new System.Drawing.Point(20, 25);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 19);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Tìm kiếm:";
            // 
            // cmbRoomTypeFilter
            // 
            this.cmbRoomTypeFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbRoomTypeFilter.BaseColor = System.Drawing.Color.White;
            this.cmbRoomTypeFilter.BorderColor = System.Drawing.Color.Silver;
            this.cmbRoomTypeFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRoomTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomTypeFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRoomTypeFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbRoomTypeFilter.ForeColor = System.Drawing.Color.Black;
            this.cmbRoomTypeFilter.FormattingEnabled = true;
            this.cmbRoomTypeFilter.Location = new System.Drawing.Point(600, 20);
            this.cmbRoomTypeFilter.Name = "cmbRoomTypeFilter";
            this.cmbRoomTypeFilter.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbRoomTypeFilter.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbRoomTypeFilter.Size = new System.Drawing.Size(120, 24);
            this.cmbRoomTypeFilter.TabIndex = 3;
            // 
            // lblRoomTypeFilter
            // 
            this.lblRoomTypeFilter.AutoSize = true;
            this.lblRoomTypeFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoomTypeFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRoomTypeFilter.Location = new System.Drawing.Point(500, 25);
            this.lblRoomTypeFilter.Name = "lblRoomTypeFilter";
            this.lblRoomTypeFilter.Size = new System.Drawing.Size(81, 19);
            this.lblRoomTypeFilter.TabIndex = 2;
            this.lblRoomTypeFilter.Text = "Loại phòng:";
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatusFilter.BaseColor = System.Drawing.Color.White;
            this.cmbStatusFilter.BorderColor = System.Drawing.Color.Silver;
            this.cmbStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbStatusFilter.ForeColor = System.Drawing.Color.Black;
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Location = new System.Drawing.Point(400, 20);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbStatusFilter.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbStatusFilter.Size = new System.Drawing.Size(80, 24);
            this.cmbStatusFilter.TabIndex = 1;
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatusFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStatusFilter.Location = new System.Drawing.Point(300, 25);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.Size = new System.Drawing.Size(73, 19);
            this.lblStatusFilter.TabIndex = 0;
            this.lblStatusFilter.Text = "Trạng thái:";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(768, 20);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(99, 30);
            this.gunaButton1.TabIndex = 9;
            this.gunaButton1.Text = "Thêm dịch vụ";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmRoomMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRoomMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theo dõi Hoạt động Phòng";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.gunaGroupBox3.ResumeLayout(false);
            this.gunaGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomEquipment)).EndInit();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomServices)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            this.ResumeLayout(false);

        }

        // Controls declaration
        private Guna.UI.WinForms.GunaPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaPanel pnlMain;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox3;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.DataGridView dgvRoomServices;
        private System.Windows.Forms.DataGridView dgvRoomEquipment;
        private Guna.UI.WinForms.GunaComboBox cmbStatusFilter;
        private Guna.UI.WinForms.GunaComboBox cmbRoomTypeFilter;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaTextBox txtRoomNumber;
        private Guna.UI.WinForms.GunaTextBox txtRoomType;
        private Guna.UI.WinForms.GunaTextBox txtStatus;
        private Guna.UI.WinForms.GunaTextBox txtCondition;
        private Guna.UI.WinForms.GunaTextBox txtCustomer;
        private Guna.UI.WinForms.GunaTextBox txtCheckInTime;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.Label lblRoomTypeFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}