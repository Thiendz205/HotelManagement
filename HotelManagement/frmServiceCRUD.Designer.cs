namespace HotelManagement
{
    partial class frmServiceCRUD
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
            this.pnlHeader = new Guna.UI.WinForms.GunaPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI.WinForms.GunaButton();
            this.pnlMain = new Guna.UI.WinForms.GunaPanel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.btnSearch = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtDescription = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategory = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServiceName = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceID = new Guna.UI.WinForms.GunaTextBox();
            this.lblServiceID = new System.Windows.Forms.Label();
            this.pnlButtons = new Guna.UI.WinForms.GunaPanel();
            this.btnClear = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.pnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.gunaGroupBox1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1000, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(285, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quản lý Dịch vụ Khách sạn";
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
            this.btnClose.Location = new System.Drawing.Point(950, 15);
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
            this.pnlMain.Controls.Add(this.gunaGroupBox2);
            this.pnlMain.Controls.Add(this.gunaGroupBox1);
            this.pnlMain.Controls.Add(this.pnlButtons);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 60);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1000, 640);
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
            this.gunaGroupBox2.Controls.Add(this.dgvServices);
            this.gunaGroupBox2.Controls.Add(this.btnSearch);
            this.gunaGroupBox2.Controls.Add(this.txtSearch);
            this.gunaGroupBox2.Controls.Add(this.label5);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Location = new System.Drawing.Point(520, 20);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(460, 570);
            this.gunaGroupBox2.TabIndex = 2;
            this.gunaGroupBox2.Text = "Danh sách Dịch vụ";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServices.BackgroundColor = System.Drawing.Color.White;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(20, 80);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(420, 470);
            this.dgvServices.TabIndex = 3;
            this.dgvServices.SelectionChanged += new System.EventHandler(this.dgvServices_SelectionChanged);
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
            this.btnSearch.Location = new System.Drawing.Point(350, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.TabIndex = 2;
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
            this.txtSearch.Location = new System.Drawing.Point(80, 40);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(260, 30);
            this.txtSearch.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label5.Location = new System.Drawing.Point(7, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.txtDescription);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.txtPrice);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.cmbCategory);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.txtServiceName);
            this.gunaGroupBox1.Controls.Add(this.label1);
            this.gunaGroupBox1.Controls.Add(this.txtServiceID);
            this.gunaGroupBox1.Controls.Add(this.lblServiceID);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Location = new System.Drawing.Point(20, 20);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(480, 400);
            this.gunaGroupBox1.TabIndex = 1;
            this.gunaGroupBox1.Text = "Thông tin Dịch vụ";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.Transparent;
            this.txtDescription.BaseColor = System.Drawing.Color.White;
            this.txtDescription.BorderColor = System.Drawing.Color.Silver;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(140, 320);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(320, 60);
            this.txtDescription.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label4.Location = new System.Drawing.Point(20, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mô tả:";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(140, 260);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(320, 30);
            this.txtPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(20, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BaseColor = System.Drawing.Color.White;
            this.cmbCategory.BorderColor = System.Drawing.Color.Silver;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(140, 200);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCategory.Size = new System.Drawing.Size(320, 26);
            this.cmbCategory.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(20, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh mục:";
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
            this.txtServiceName.Location = new System.Drawing.Point(140, 140);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PasswordChar = '\0';
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.Size = new System.Drawing.Size(320, 30);
            this.txtServiceName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(20, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên dịch vụ:";
            // 
            // txtServiceID
            // 
            this.txtServiceID.BackColor = System.Drawing.Color.Transparent;
            this.txtServiceID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtServiceID.BorderColor = System.Drawing.Color.Silver;
            this.txtServiceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceID.Enabled = false;
            this.txtServiceID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtServiceID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtServiceID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtServiceID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServiceID.Location = new System.Drawing.Point(140, 80);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.PasswordChar = '\0';
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.SelectedText = "";
            this.txtServiceID.Size = new System.Drawing.Size(320, 30);
            this.txtServiceID.TabIndex = 1;
            // 
            // lblServiceID
            // 
            this.lblServiceID.AutoSize = true;
            this.lblServiceID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblServiceID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblServiceID.Location = new System.Drawing.Point(20, 90);
            this.lblServiceID.Name = "lblServiceID";
            this.lblServiceID.Size = new System.Drawing.Size(80, 19);
            this.lblServiceID.TabIndex = 0;
            this.lblServiceID.Text = "Mã dịch vụ:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlButtons.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Location = new System.Drawing.Point(20, 440);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(480, 50);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.AnimationHoverSpeed = 0.07F;
            this.btnClear.AnimationSpeed = 0.03F;
            this.btnClear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.BorderColor = System.Drawing.Color.Black;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClear.FocusedColor = System.Drawing.Color.Empty;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = null;
            this.btnClear.ImageSize = new System.Drawing.Size(20, 20);
            this.btnClear.Location = new System.Drawing.Point(360, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnClear.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnClear.OnHoverForeColor = System.Drawing.Color.White;
            this.btnClear.OnHoverImage = null;
            this.btnClear.OnPressedColor = System.Drawing.Color.Black;
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Làm mới";
            this.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationHoverSpeed = 0.07F;
            this.btnDelete.AnimationSpeed = 0.03F;
            this.btnDelete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.BorderColor = System.Drawing.Color.Black;
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDelete.FocusedColor = System.Drawing.Color.Empty;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = null;
            this.btnDelete.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDelete.Location = new System.Drawing.Point(250, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(140, 10);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(30, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmServiceCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServiceCRUD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Dịch vụ";
            this.Load += new System.EventHandler(this.frmServiceCRUD_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaButton btnClose;
        private Guna.UI.WinForms.GunaPanel pnlMain;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.DataGridView dgvServices;
        private Guna.UI.WinForms.GunaButton btnSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaTextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtServiceName;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtServiceID;
        private System.Windows.Forms.Label lblServiceID;
        private Guna.UI.WinForms.GunaPanel pnlButtons;
        private Guna.UI.WinForms.GunaButton btnClear;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnAdd;
    }
}