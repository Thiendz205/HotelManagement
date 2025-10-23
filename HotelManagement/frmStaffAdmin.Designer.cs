namespace HotelManagement
{
    partial class frmStaffAdmin
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
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.editorPanel = new Guna.UI.WinForms.GunaPanel();
            this.cboRole = new Guna.UI.WinForms.GunaComboBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.txtStaffID = new Guna.UI.WinForms.GunaTextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI.WinForms.GunaTextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new Guna.UI.WinForms.GunaComboBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.lblCitizen = new System.Windows.Forms.Label();
            this.txtCitizen = new Guna.UI.WinForms.GunaTextBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI.WinForms.GunaTextBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCitizen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboFilterRole = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.editorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.headerPanel.Controls.Add(this.cboFilterRole);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.txtSearch);
            this.headerPanel.Controls.Add(this.btnAdd);
            this.headerPanel.Controls.Add(this.btnEdit);
            this.headerPanel.Controls.Add(this.btnDelete);
            this.headerPanel.Controls.Add(this.btnRefresh);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1330, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nhân viên";
            // 
            // txtSearch
            // 
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(180, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(260, 33);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
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
            this.btnAdd.Location = new System.Drawing.Point(821, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(100, 34);
            this.btnAdd.TabIndex = 2;
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
            this.btnEdit.Location = new System.Drawing.Point(931, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Size = new System.Drawing.Size(100, 34);
            this.btnEdit.TabIndex = 3;
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
            this.btnDelete.Location = new System.Drawing.Point(1041, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnDelete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDelete.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDelete.OnHoverImage = null;
            this.btnDelete.OnPressedColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(100, 34);
            this.btnDelete.TabIndex = 4;
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
            this.btnRefresh.Location = new System.Drawing.Point(1151, 23);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(140)))), ((int)(((byte)(141)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(120, 34);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // editorPanel
            // 
            this.editorPanel.AutoSize = true;
            this.editorPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.editorPanel.Controls.Add(this.cboRole);
            this.editorPanel.Controls.Add(this.lblStaffID);
            this.editorPanel.Controls.Add(this.txtStaffID);
            this.editorPanel.Controls.Add(this.lblFullName);
            this.editorPanel.Controls.Add(this.txtFullName);
            this.editorPanel.Controls.Add(this.lblRole);
            this.editorPanel.Controls.Add(this.lblGender);
            this.editorPanel.Controls.Add(this.cboGender);
            this.editorPanel.Controls.Add(this.lblPhone);
            this.editorPanel.Controls.Add(this.txtPhone);
            this.editorPanel.Controls.Add(this.lblCitizen);
            this.editorPanel.Controls.Add(this.txtCitizen);
            this.editorPanel.Controls.Add(this.lblDOB);
            this.editorPanel.Controls.Add(this.dtpDOB);
            this.editorPanel.Controls.Add(this.lblStartDate);
            this.editorPanel.Controls.Add(this.dtpStartDate);
            this.editorPanel.Controls.Add(this.lblNotes);
            this.editorPanel.Controls.Add(this.txtNotes);
            this.editorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editorPanel.Location = new System.Drawing.Point(0, 80);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(1330, 143);
            this.editorPanel.TabIndex = 6;
            this.editorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editorPanel_Paint);
            // 
            // cboRole
            // 
            this.cboRole.BackColor = System.Drawing.Color.Transparent;
            this.cboRole.BaseColor = System.Drawing.Color.White;
            this.cboRole.BorderColor = System.Drawing.Color.Silver;
            this.cboRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRole.FocusedColor = System.Drawing.Color.Empty;
            this.cboRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRole.ForeColor = System.Drawing.Color.Black;
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(617, 33);
            this.cboRole.Margin = new System.Windows.Forms.Padding(2);
            this.cboRole.Name = "cboRole";
            this.cboRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboRole.Size = new System.Drawing.Size(158, 26);
            this.cboRole.TabIndex = 18;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStaffID.Location = new System.Drawing.Point(271, 9);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(52, 19);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "Mã NV";
            // 
            // txtStaffID
            // 
            this.txtStaffID.BaseColor = System.Drawing.Color.White;
            this.txtStaffID.BorderColor = System.Drawing.Color.Silver;
            this.txtStaffID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStaffID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtStaffID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtStaffID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStaffID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStaffID.Location = new System.Drawing.Point(275, 31);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.PasswordChar = '\0';
            this.txtStaffID.SelectedText = "";
            this.txtStaffID.Size = new System.Drawing.Size(120, 33);
            this.txtStaffID.TabIndex = 1;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFullName.Location = new System.Drawing.Point(407, 9);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(69, 19);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Họ và tên";
            // 
            // txtFullName
            // 
            this.txtFullName.BaseColor = System.Drawing.Color.White;
            this.txtFullName.BorderColor = System.Drawing.Color.Silver;
            this.txtFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFullName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFullName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtFullName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFullName.Location = new System.Drawing.Point(411, 31);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(200, 33);
            this.txtFullName.TabIndex = 3;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRole.Location = new System.Drawing.Point(667, 9);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 19);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblGender.Location = new System.Drawing.Point(799, 9);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 19);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Giới tính";
            // 
            // cboGender
            // 
            this.cboGender.BackColor = System.Drawing.Color.Transparent;
            this.cboGender.BaseColor = System.Drawing.Color.White;
            this.cboGender.BorderColor = System.Drawing.Color.Silver;
            this.cboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FocusedColor = System.Drawing.Color.Empty;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGender.ForeColor = System.Drawing.Color.Black;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(803, 33);
            this.cboGender.Name = "cboGender";
            this.cboGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboGender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboGender.Size = new System.Drawing.Size(120, 26);
            this.cboGender.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPhone.Location = new System.Drawing.Point(271, 71);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(33, 19);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "SĐT";
            // 
            // txtPhone
            // 
            this.txtPhone.BaseColor = System.Drawing.Color.White;
            this.txtPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPhone.Location = new System.Drawing.Point(275, 93);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(160, 33);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // lblCitizen
            // 
            this.lblCitizen.AutoSize = true;
            this.lblCitizen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCitizen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCitizen.Location = new System.Drawing.Point(447, 71);
            this.lblCitizen.Name = "lblCitizen";
            this.lblCitizen.Size = new System.Drawing.Size(93, 19);
            this.lblCitizen.TabIndex = 10;
            this.lblCitizen.Text = "CCCD/CMND";
            // 
            // txtCitizen
            // 
            this.txtCitizen.BaseColor = System.Drawing.Color.White;
            this.txtCitizen.BorderColor = System.Drawing.Color.Silver;
            this.txtCitizen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCitizen.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCitizen.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCitizen.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCitizen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCitizen.Location = new System.Drawing.Point(451, 93);
            this.txtCitizen.Name = "txtCitizen";
            this.txtCitizen.PasswordChar = '\0';
            this.txtCitizen.SelectedText = "";
            this.txtCitizen.Size = new System.Drawing.Size(160, 33);
            this.txtCitizen.TabIndex = 11;
            this.txtCitizen.TextChanged += new System.EventHandler(this.txtCitizenID_TextChanged);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDOB.Location = new System.Drawing.Point(623, 71);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(70, 19);
            this.lblDOB.TabIndex = 12;
            this.lblDOB.Text = "Ngày sinh";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDOB.Location = new System.Drawing.Point(627, 93);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(170, 25);
            this.dtpDOB.TabIndex = 13;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStartDate.Location = new System.Drawing.Point(799, 71);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(92, 19);
            this.lblStartDate.TabIndex = 14;
            this.lblStartDate.Text = "Ngày bắt đầu";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Location = new System.Drawing.Point(803, 93);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(170, 25);
            this.dtpStartDate.TabIndex = 15;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNotes.Location = new System.Drawing.Point(975, 9);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(56, 19);
            this.lblNotes.TabIndex = 16;
            this.lblNotes.Text = "Ghi chú";
            // 
            // txtNotes
            // 
            this.txtNotes.BaseColor = System.Drawing.Color.White;
            this.txtNotes.BorderColor = System.Drawing.Color.Silver;
            this.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNotes.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNotes.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtNotes.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotes.Location = new System.Drawing.Point(979, 31);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(200, 109);
            this.txtNotes.TabIndex = 17;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStaffID,
            this.colFullName,
            this.colRole,
            this.colDOB,
            this.colGender,
            this.colPhone,
            this.colCitizen,
            this.colStartDate,
            this.colNotes});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 223);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMain.Size = new System.Drawing.Size(1330, 577);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // colStaffID
            // 
            this.colStaffID.DataPropertyName = "StaffID";
            this.colStaffID.HeaderText = "StaffID";
            this.colStaffID.MinimumWidth = 6;
            this.colStaffID.Name = "colStaffID";
            this.colStaffID.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "FullName";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colRole
            // 
            this.colRole.DataPropertyName = "Role";
            this.colRole.HeaderText = "Role";
            this.colRole.MinimumWidth = 6;
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            // 
            // colDOB
            // 
            this.colDOB.DataPropertyName = "DateOfBirth";
            this.colDOB.HeaderText = "DateOfBirth";
            this.colDOB.MinimumWidth = 6;
            this.colDOB.Name = "colDOB";
            this.colDOB.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.MinimumWidth = 6;
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "PhoneNumber";
            this.colPhone.HeaderText = "PhoneNumber";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colCitizen
            // 
            this.colCitizen.DataPropertyName = "CitizenID";
            this.colCitizen.HeaderText = "CitizenID";
            this.colCitizen.MinimumWidth = 6;
            this.colCitizen.Name = "colCitizen";
            this.colCitizen.ReadOnly = true;
            // 
            // colStartDate
            // 
            this.colStartDate.DataPropertyName = "StartDate";
            this.colStartDate.HeaderText = "StartDate";
            this.colStartDate.MinimumWidth = 6;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.DataPropertyName = "Notes";
            this.colNotes.HeaderText = "Notes";
            this.colNotes.MinimumWidth = 6;
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
            // 
            // cboFilterRole
            // 
            this.cboFilterRole.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterRole.BaseColor = System.Drawing.Color.White;
            this.cboFilterRole.BorderColor = System.Drawing.Color.Silver;
            this.cboFilterRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilterRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterRole.FocusedColor = System.Drawing.Color.Empty;
            this.cboFilterRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilterRole.ForeColor = System.Drawing.Color.Black;
            this.cboFilterRole.FormattingEnabled = true;
            this.cboFilterRole.Location = new System.Drawing.Point(546, 31);
            this.cboFilterRole.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterRole.Name = "cboFilterRole";
            this.cboFilterRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboFilterRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboFilterRole.Size = new System.Drawing.Size(158, 26);
            this.cboFilterRole.TabIndex = 20;
            this.cboFilterRole.SelectedIndexChanged += new System.EventHandler(this.cboFilterRole_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(596, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lọc Role";
            // 
            // frmStaffAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 800);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.editorPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "frmStaffAdmin";
            this.Text = "frmStaffAdmin";
            this.Load += new System.EventHandler(this.frmStaffAdmin_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.editorPanel.ResumeLayout(false);
            this.editorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnDelete;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private System.Windows.Forms.DataGridView dgvMain;
        private Guna.UI.WinForms.GunaPanel editorPanel;
        private System.Windows.Forms.Label lblStaffID;
        private Guna.UI.WinForms.GunaTextBox txtStaffID;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI.WinForms.GunaTextBox txtFullName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblGender;
        private Guna.UI.WinForms.GunaComboBox cboGender;
        private System.Windows.Forms.Label lblPhone;
        private Guna.UI.WinForms.GunaTextBox txtPhone;
        private System.Windows.Forms.Label lblCitizen;
        private Guna.UI.WinForms.GunaTextBox txtCitizen;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblNotes;
        private Guna.UI.WinForms.GunaTextBox txtNotes;
        private Guna.UI.WinForms.GunaComboBox cboRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCitizen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private Guna.UI.WinForms.GunaComboBox cboFilterRole;
        private System.Windows.Forms.Label label1;
    }
}