namespace HotelManagement
{
    partial class frmUseServiceAdmin
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
            this.headerPanel = new Guna.UI.WinForms.GunaPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.editorPanel = new Guna.UI.WinForms.GunaPanel();
            this.lblService = new System.Windows.Forms.Label();
            this.cboService = new Guna.UI.WinForms.GunaComboBox();
            this.lblBooking = new System.Windows.Forms.Label();
            this.cboBooking = new Guna.UI.WinForms.GunaComboBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.cboStaff = new Guna.UI.WinForms.GunaComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblUsageDate = new System.Windows.Forms.Label();
            this.dtpUsageDate = new System.Windows.Forms.DateTimePicker();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colUsageID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsageDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headerPanel.SuspendLayout();
            this.editorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.btnAdd);
            this.headerPanel.Controls.Add(this.btnEdit);
            this.headerPanel.Controls.Add(this.btnDelete);
            this.headerPanel.Controls.Add(this.btnRefresh);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1744, 98);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTitle.Location = new System.Drawing.Point(27, 38);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(222, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Sử dụng dịch vụ";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(800, 39);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(133, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = null;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(947, 39);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Size = new System.Drawing.Size(133, 42);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = null;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(1093, 39);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(133, 42);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = null;
            this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.Location = new System.Drawing.Point(1240, 39);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(160, 42);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // editorPanel
            // 
            this.editorPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.editorPanel.Controls.Add(this.lblService);
            this.editorPanel.Controls.Add(this.cboService);
            this.editorPanel.Controls.Add(this.lblBooking);
            this.editorPanel.Controls.Add(this.cboBooking);
            this.editorPanel.Controls.Add(this.lblStaff);
            this.editorPanel.Controls.Add(this.cboStaff);
            this.editorPanel.Controls.Add(this.lblQuantity);
            this.editorPanel.Controls.Add(this.nudQuantity);
            this.editorPanel.Controls.Add(this.lblUsageDate);
            this.editorPanel.Controls.Add(this.dtpUsageDate);
            this.editorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editorPanel.Location = new System.Drawing.Point(0, 98);
            this.editorPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(1744, 185);
            this.editorPanel.TabIndex = 1;
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblService.Location = new System.Drawing.Point(129, 20);
            this.lblService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(67, 23);
            this.lblService.TabIndex = 0;
            this.lblService.Text = "Dịch vụ";
            // 
            // cboService
            // 
            this.cboService.BackColor = System.Drawing.Color.Transparent;
            this.cboService.BaseColor = System.Drawing.Color.White;
            this.cboService.BorderColor = System.Drawing.Color.Silver;
            this.cboService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboService.FocusedColor = System.Drawing.Color.Empty;
            this.cboService.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboService.ForeColor = System.Drawing.Color.Black;
            this.cboService.FormattingEnabled = true;
            this.cboService.Location = new System.Drawing.Point(129, 48);
            this.cboService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboService.Name = "cboService";
            this.cboService.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboService.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboService.Size = new System.Drawing.Size(265, 31);
            this.cboService.TabIndex = 1;
            // 
            // lblBooking
            // 
            this.lblBooking.AutoSize = true;
            this.lblBooking.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBooking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblBooking.Location = new System.Drawing.Point(488, 18);
            this.lblBooking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBooking.Name = "lblBooking";
            this.lblBooking.Size = new System.Drawing.Size(72, 23);
            this.lblBooking.TabIndex = 2;
            this.lblBooking.Text = "Booking";
            // 
            // cboBooking
            // 
            this.cboBooking.BackColor = System.Drawing.Color.Transparent;
            this.cboBooking.BaseColor = System.Drawing.Color.White;
            this.cboBooking.BorderColor = System.Drawing.Color.Silver;
            this.cboBooking.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBooking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBooking.FocusedColor = System.Drawing.Color.Empty;
            this.cboBooking.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboBooking.ForeColor = System.Drawing.Color.Black;
            this.cboBooking.FormattingEnabled = true;
            this.cboBooking.Location = new System.Drawing.Point(488, 47);
            this.cboBooking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboBooking.Name = "cboBooking";
            this.cboBooking.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboBooking.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboBooking.Size = new System.Drawing.Size(265, 31);
            this.cboBooking.TabIndex = 3;
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStaff.Location = new System.Drawing.Point(839, 18);
            this.lblStaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(88, 23);
            this.lblStaff.TabIndex = 4;
            this.lblStaff.Text = "Nhân viên";
            // 
            // cboStaff
            // 
            this.cboStaff.BackColor = System.Drawing.Color.Transparent;
            this.cboStaff.BaseColor = System.Drawing.Color.White;
            this.cboStaff.BorderColor = System.Drawing.Color.Silver;
            this.cboStaff.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStaff.FocusedColor = System.Drawing.Color.Empty;
            this.cboStaff.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStaff.ForeColor = System.Drawing.Color.Black;
            this.cboStaff.FormattingEnabled = true;
            this.cboStaff.Location = new System.Drawing.Point(839, 47);
            this.cboStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboStaff.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboStaff.Size = new System.Drawing.Size(265, 31);
            this.cboStaff.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblQuantity.Location = new System.Drawing.Point(1196, 20);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(78, 23);
            this.lblQuantity.TabIndex = 6;
            this.lblQuantity.Text = "Số lượng";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nudQuantity.Location = new System.Drawing.Point(1196, 48);
            this.nudQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(160, 30);
            this.nudQuantity.TabIndex = 7;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblUsageDate
            // 
            this.lblUsageDate.AutoSize = true;
            this.lblUsageDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsageDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUsageDate.Location = new System.Drawing.Point(1432, 21);
            this.lblUsageDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsageDate.Name = "lblUsageDate";
            this.lblUsageDate.Size = new System.Drawing.Size(117, 23);
            this.lblUsageDate.TabIndex = 8;
            this.lblUsageDate.Text = "Ngày sử dụng";
            // 
            // dtpUsageDate
            // 
            this.dtpUsageDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpUsageDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUsageDate.Location = new System.Drawing.Point(1432, 49);
            this.dtpUsageDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpUsageDate.Name = "dtpUsageDate";
            this.dtpUsageDate.Size = new System.Drawing.Size(265, 30);
            this.dtpUsageDate.TabIndex = 9;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMain.ColumnHeadersHeight = 30;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUsageID,
            this.colServiceName,
            this.colCustomerName,
            this.colRoomName,
            this.colQuantity,
            this.colTotalAmount,
            this.colStaffName,
            this.colUsageDate});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.GridColor = System.Drawing.Color.LightGray;
            this.dgvMain.Location = new System.Drawing.Point(0, 283);
            this.dgvMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 25;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMain.Size = new System.Drawing.Size(1744, 702);
            this.dgvMain.TabIndex = 2;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // colUsageID
            // 
            this.colUsageID.HeaderText = "UsageID";
            this.colUsageID.MinimumWidth = 6;
            this.colUsageID.Name = "colUsageID";
            this.colUsageID.ReadOnly = true;
            // 
            // colServiceName
            // 
            this.colServiceName.HeaderText = "Dịch vụ";
            this.colServiceName.MinimumWidth = 6;
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.ReadOnly = true;
            // 
            // colCustomerName
            // 
            this.colCustomerName.HeaderText = "Khách hàng";
            this.colCustomerName.MinimumWidth = 6;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colRoomName
            // 
            this.colRoomName.HeaderText = "Phòng";
            this.colRoomName.MinimumWidth = 6;
            this.colRoomName.Name = "colRoomName";
            this.colRoomName.ReadOnly = true;
            // 
            // colQuantity
            // 
            this.colQuantity.HeaderText = "Số lượng";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.HeaderText = "Tổng tiền";
            this.colTotalAmount.MinimumWidth = 6;
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            // 
            // colStaffName
            // 
            this.colStaffName.HeaderText = "Nhân viên";
            this.colStaffName.MinimumWidth = 6;
            this.colStaffName.Name = "colStaffName";
            this.colStaffName.ReadOnly = true;
            // 
            // colUsageDate
            // 
            this.colUsageDate.HeaderText = "Ngày sử dụng";
            this.colUsageDate.MinimumWidth = 6;
            this.colUsageDate.Name = "colUsageDate";
            this.colUsageDate.ReadOnly = true;
            // 
            // frmUseServiceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1744, 985);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.editorPanel);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUseServiceAdmin";
            this.Text = "frmUseServiceAdmin";
            this.Load += new System.EventHandler(this.frmUseServiceAdmin_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.editorPanel.ResumeLayout(false);
            this.editorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private Guna.UI.WinForms.GunaPanel editorPanel;
        private System.Windows.Forms.Label lblService;
        private Guna.UI.WinForms.GunaComboBox cboService;
        private System.Windows.Forms.Label lblBooking;
        private Guna.UI.WinForms.GunaComboBox cboBooking;
        private System.Windows.Forms.Label lblStaff;
        private Guna.UI.WinForms.GunaComboBox cboStaff;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblUsageDate;
        private System.Windows.Forms.DateTimePicker dtpUsageDate;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsageID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRoomName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsageDate;
    }
}