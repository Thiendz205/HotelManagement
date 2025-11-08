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
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cboRole = new Guna.UI.WinForms.GunaComboBox();
            this.lblDOB = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtCitizen = new Guna.UI.WinForms.GunaTextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblCitizen = new System.Windows.Forms.Label();
            this.txtNotes = new Guna.UI.WinForms.GunaTextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new Guna.UI.WinForms.GunaTextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cboGender = new Guna.UI.WinForms.GunaComboBox();
            this.txtStaffID = new Guna.UI.WinForms.GunaTextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new Guna.UI.WinForms.GunaTextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.cboFilterRole = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.editorPanel = new Guna.UI.WinForms.GunaPanel();
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
            this.headerPanel.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.headerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.headerPanel.Controls.Add(this.guna2Button4);
            this.headerPanel.Controls.Add(this.guna2Button1);
            this.headerPanel.Controls.Add(this.guna2GroupBox2);
            this.headerPanel.Controls.Add(this.guna2Button2);
            this.headerPanel.Controls.Add(this.guna2Button3);
            this.headerPanel.Controls.Add(this.cboFilterRole);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1330, 488);
            this.headerPanel.TabIndex = 0;
            // 
            // guna2Button4
            // 
            this.guna2Button4.BorderRadius = 20;
            this.guna2Button4.CheckedState.Parent = this.guna2Button4;
            this.guna2Button4.CustomImages.Parent = this.guna2Button4;
            this.guna2Button4.FillColor = System.Drawing.Color.White;
            this.guna2Button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.Black;
            this.guna2Button4.HoverState.Parent = this.guna2Button4;
            this.guna2Button4.Image = global::HotelManagement.Properties.Resources.refreshRECP;
            this.guna2Button4.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button4.Location = new System.Drawing.Point(1109, 204);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(134, 50);
            this.guna2Button4.TabIndex = 31;
            this.guna2Button4.Text = "Làm mới";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::HotelManagement.Properties.Resources.updateHR;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(963, 204);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(134, 50);
            this.guna2Button1.TabIndex = 30;
            this.guna2Button1.Text = "Sửa";
            this.guna2Button1.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Controls.Add(this.cboRole);
            this.guna2GroupBox2.Controls.Add(this.lblDOB);
            this.guna2GroupBox2.Controls.Add(this.dtpDOB);
            this.guna2GroupBox2.Controls.Add(this.txtCitizen);
            this.guna2GroupBox2.Controls.Add(this.lblStartDate);
            this.guna2GroupBox2.Controls.Add(this.lblNotes);
            this.guna2GroupBox2.Controls.Add(this.lblCitizen);
            this.guna2GroupBox2.Controls.Add(this.txtNotes);
            this.guna2GroupBox2.Controls.Add(this.dtpStartDate);
            this.guna2GroupBox2.Controls.Add(this.txtPhone);
            this.guna2GroupBox2.Controls.Add(this.lblStaffID);
            this.guna2GroupBox2.Controls.Add(this.lblPhone);
            this.guna2GroupBox2.Controls.Add(this.cboGender);
            this.guna2GroupBox2.Controls.Add(this.txtStaffID);
            this.guna2GroupBox2.Controls.Add(this.lblGender);
            this.guna2GroupBox2.Controls.Add(this.lblRole);
            this.guna2GroupBox2.Controls.Add(this.lblFullName);
            this.guna2GroupBox2.Controls.Add(this.txtFullName);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2GroupBox2.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(10, 36);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(837, 355);
            this.guna2GroupBox2.TabIndex = 32;
            this.guna2GroupBox2.Text = "Thông tin nhân viên";
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
            this.cboRole.Location = new System.Drawing.Point(133, 283);
            this.cboRole.Margin = new System.Windows.Forms.Padding(2);
            this.cboRole.Name = "cboRole";
            this.cboRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboRole.Size = new System.Drawing.Size(202, 26);
            this.cboRole.TabIndex = 18;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDOB.Location = new System.Drawing.Point(455, 78);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(70, 19);
            this.lblDOB.TabIndex = 12;
            this.lblDOB.Text = "Ngày sinh";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDOB.Location = new System.Drawing.Point(553, 72);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(202, 25);
            this.dtpDOB.TabIndex = 13;
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
            this.txtCitizen.Location = new System.Drawing.Point(133, 227);
            this.txtCitizen.Name = "txtCitizen";
            this.txtCitizen.PasswordChar = '\0';
            this.txtCitizen.SelectedText = "";
            this.txtCitizen.Size = new System.Drawing.Size(202, 28);
            this.txtCitizen.TabIndex = 11;
            this.txtCitizen.TextChanged += new System.EventHandler(this.txtCitizenID_TextChanged);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStartDate.Location = new System.Drawing.Point(433, 132);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(92, 19);
            this.lblStartDate.TabIndex = 14;
            this.lblStartDate.Text = "Ngày bắt đầu";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNotes.Location = new System.Drawing.Point(469, 271);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(56, 19);
            this.lblNotes.TabIndex = 16;
            this.lblNotes.Text = "Ghi chú";
            // 
            // lblCitizen
            // 
            this.lblCitizen.AutoSize = true;
            this.lblCitizen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCitizen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCitizen.Location = new System.Drawing.Point(2, 227);
            this.lblCitizen.Name = "lblCitizen";
            this.lblCitizen.Size = new System.Drawing.Size(93, 19);
            this.lblCitizen.TabIndex = 10;
            this.lblCitizen.Text = "CCCD/CMND";
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
            this.txtNotes.Location = new System.Drawing.Point(555, 234);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PasswordChar = '\0';
            this.txtNotes.SelectedText = "";
            this.txtNotes.Size = new System.Drawing.Size(200, 89);
            this.txtNotes.TabIndex = 17;
            this.txtNotes.TextChanged += new System.EventHandler(this.txtNotes_TextChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Location = new System.Drawing.Point(553, 132);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(202, 25);
            this.dtpStartDate.TabIndex = 15;
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
            this.txtPhone.Location = new System.Drawing.Point(133, 117);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(205, 28);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStaffID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStaffID.Location = new System.Drawing.Point(21, 69);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(52, 19);
            this.lblStaffID.TabIndex = 0;
            this.lblStaffID.Text = "Mã NV";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPhone.Location = new System.Drawing.Point(29, 117);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(33, 19);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "SĐT";
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
            this.cboGender.Location = new System.Drawing.Point(553, 189);
            this.cboGender.Name = "cboGender";
            this.cboGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboGender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboGender.Size = new System.Drawing.Size(202, 26);
            this.cboGender.TabIndex = 7;
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
            this.txtStaffID.Location = new System.Drawing.Point(134, 69);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.PasswordChar = '\0';
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.SelectedText = "";
            this.txtStaffID.Size = new System.Drawing.Size(204, 28);
            this.txtStaffID.TabIndex = 1;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblGender.Location = new System.Drawing.Point(455, 189);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(61, 19);
            this.lblGender.TabIndex = 6;
            this.lblGender.Text = "Giới tính";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblRole.Location = new System.Drawing.Point(24, 283);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 19);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Role";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFullName.Location = new System.Drawing.Point(12, 169);
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
            this.txtFullName.Location = new System.Drawing.Point(133, 169);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.SelectedText = "";
            this.txtFullName.Size = new System.Drawing.Size(205, 28);
            this.txtFullName.TabIndex = 3;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.White;
            this.guna2Button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::HotelManagement.Properties.Resources.signs_close_icon_png;
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(1109, 121);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(134, 50);
            this.guna2Button2.TabIndex = 29;
            this.guna2Button2.Text = "Xóa";
            this.guna2Button2.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BorderRadius = 20;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.White;
            this.guna2Button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.Black;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::HotelManagement.Properties.Resources.addHR;
            this.guna2Button3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button3.Location = new System.Drawing.Point(964, 121);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(134, 50);
            this.guna2Button3.TabIndex = 28;
            this.guna2Button3.Text = "Thêm ";
            this.guna2Button3.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.cboFilterRole.Location = new System.Drawing.Point(1040, 300);
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
            this.label1.Location = new System.Drawing.Point(1078, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lọc Role";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTitle.Location = new System.Drawing.Point(701, 434);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(117, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Nhân viên";
            // 
            // editorPanel
            // 
            this.editorPanel.AutoSize = true;
            this.editorPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.editorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editorPanel.Location = new System.Drawing.Point(0, 488);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(1330, 0);
            this.editorPanel.TabIndex = 6;
            this.editorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editorPanel_Paint);
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
            this.dgvMain.Location = new System.Drawing.Point(0, 488);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMain.Size = new System.Drawing.Size(1330, 312);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // colStaffID
            // 
            this.colStaffID.DataPropertyName = "StaffID";
            this.colStaffID.HeaderText = "Mã nhân viên";
            this.colStaffID.MinimumWidth = 6;
            this.colStaffID.Name = "colStaffID";
            this.colStaffID.ReadOnly = true;
            // 
            // colFullName
            // 
            this.colFullName.DataPropertyName = "FullName";
            this.colFullName.HeaderText = "Họ và tên";
            this.colFullName.MinimumWidth = 6;
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            // 
            // colRole
            // 
            this.colRole.DataPropertyName = "Role";
            this.colRole.HeaderText = "Vai trò";
            this.colRole.MinimumWidth = 6;
            this.colRole.Name = "colRole";
            this.colRole.ReadOnly = true;
            // 
            // colDOB
            // 
            this.colDOB.DataPropertyName = "DateOfBirth";
            this.colDOB.HeaderText = "Ngày sinh";
            this.colDOB.MinimumWidth = 6;
            this.colDOB.Name = "colDOB";
            this.colDOB.ReadOnly = true;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Giới tính";
            this.colGender.MinimumWidth = 6;
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            // 
            // colPhone
            // 
            this.colPhone.DataPropertyName = "PhoneNumber";
            this.colPhone.HeaderText = "Số điện thoại";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.ReadOnly = true;
            // 
            // colCitizen
            // 
            this.colCitizen.DataPropertyName = "CitizenID";
            this.colCitizen.HeaderText = "CCCD/CMND";
            this.colCitizen.MinimumWidth = 6;
            this.colCitizen.Name = "colCitizen";
            this.colCitizen.ReadOnly = true;
            // 
            // colStartDate
            // 
            this.colStartDate.DataPropertyName = "StartDate";
            this.colStartDate.HeaderText = "Ngày bắt đầu";
            this.colStartDate.MinimumWidth = 6;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            // 
            // colNotes
            // 
            this.colNotes.DataPropertyName = "Notes";
            this.colNotes.HeaderText = "Ghi chú";
            this.colNotes.MinimumWidth = 6;
            this.colNotes.Name = "colNotes";
            this.colNotes.ReadOnly = true;
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
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel headerPanel;
        private System.Windows.Forms.Label lblTitle;
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
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}