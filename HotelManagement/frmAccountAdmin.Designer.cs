namespace HotelManagement
{
    partial class frmAccountAdmin
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
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.lblStaffId = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.cboStatus = new Guna.UI.WinForms.GunaComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.cboFilterStatus = new Guna.UI.WinForms.GunaComboBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colAccountID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel3 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.gunaPanel3.SuspendLayout();
            this.gunaPanel4.SuspendLayout();
            this.SuspendLayout();
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
            this.guna2Button4.Location = new System.Drawing.Point(142, 87);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(134, 50);
            this.guna2Button4.TabIndex = 49;
            this.guna2Button4.Text = "Làm mới";
            this.guna2Button4.Click += new System.EventHandler(this.btnRefresh_Click);
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
            this.guna2Button1.Location = new System.Drawing.Point(222, 24);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(134, 50);
            this.guna2Button1.TabIndex = 48;
            this.guna2Button1.Text = "Sửa";
            this.guna2Button1.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.guna2Button3.Location = new System.Drawing.Point(64, 24);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(134, 50);
            this.guna2Button3.TabIndex = 46;
            this.guna2Button3.Text = "Thêm ";
            this.guna2Button3.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Controls.Add(this.lblPassword);
            this.guna2GroupBox2.Controls.Add(this.gunaTextBox1);
            this.guna2GroupBox2.Controls.Add(this.lblUsername);
            this.guna2GroupBox2.Controls.Add(this.txtUsername);
            this.guna2GroupBox2.Controls.Add(this.txtPassword);
            this.guna2GroupBox2.Controls.Add(this.lblStaffId);
            this.guna2GroupBox2.Controls.Add(this.dtpStartDate);
            this.guna2GroupBox2.Controls.Add(this.lblStatus);
            this.guna2GroupBox2.Controls.Add(this.lblStartDate);
            this.guna2GroupBox2.Controls.Add(this.cboStatus);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GroupBox2.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(802, 281);
            this.guna2GroupBox2.TabIndex = 45;
            this.guna2GroupBox2.Text = "Tài Khoản";
            this.guna2GroupBox2.Click += new System.EventHandler(this.guna2GroupBox2_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPassword.Location = new System.Drawing.Point(31, 134);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 19);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaTextBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaTextBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaTextBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaTextBox1.FormattingEnabled = true;
            this.gunaTextBox1.Location = new System.Drawing.Point(142, 178);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaTextBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaTextBox1.Size = new System.Drawing.Size(200, 26);
            this.gunaTextBox1.TabIndex = 10;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblUsername.Location = new System.Drawing.Point(31, 85);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 19);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Tên tài khoản";
            // 
            // txtUsername
            // 
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.Silver;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.Location = new System.Drawing.Point(142, 77);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(200, 28);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.Location = new System.Drawing.Point(142, 125);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 28);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblStaffId
            // 
            this.lblStaffId.AutoSize = true;
            this.lblStaffId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStaffId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStaffId.Location = new System.Drawing.Point(29, 178);
            this.lblStaffId.Name = "lblStaffId";
            this.lblStaffId.Size = new System.Drawing.Size(93, 19);
            this.lblStaffId.TabIndex = 4;
            this.lblStaffId.Text = "Mã nhân viên";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Enabled = false;
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpStartDate.Location = new System.Drawing.Point(567, 129);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(188, 25);
            this.dtpStartDate.TabIndex = 9;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStatus.Location = new System.Drawing.Point(442, 82);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(70, 19);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Trạng thái";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblStartDate.Location = new System.Drawing.Point(442, 129);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(107, 19);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Ngày tạo (Auto)";
            // 
            // cboStatus
            // 
            this.cboStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboStatus.BaseColor = System.Drawing.Color.White;
            this.cboStatus.BorderColor = System.Drawing.Color.Silver;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatus.ForeColor = System.Drawing.Color.Black;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboStatus.Location = new System.Drawing.Point(567, 79);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboStatus.Size = new System.Drawing.Size(188, 26);
            this.cboStatus.TabIndex = 7;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFilterStatus.Location = new System.Drawing.Point(170, 158);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(95, 19);
            this.lblFilterStatus.TabIndex = 6;
            this.lblFilterStatus.Text = "Lọc Trạng thái";
            // 
            // cboFilterStatus
            // 
            this.cboFilterStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterStatus.BaseColor = System.Drawing.Color.White;
            this.cboFilterStatus.BorderColor = System.Drawing.Color.Silver;
            this.cboFilterStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilterStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cboFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilterStatus.ForeColor = System.Drawing.Color.Black;
            this.cboFilterStatus.FormattingEnabled = true;
            this.cboFilterStatus.Items.AddRange(new object[] {
            "Tất cả",
            "Active",
            "Inactive"});
            this.cboFilterStatus.Location = new System.Drawing.Point(125, 188);
            this.cboFilterStatus.Name = "cboFilterStatus";
            this.cboFilterStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboFilterStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboFilterStatus.Size = new System.Drawing.Size(182, 26);
            this.cboFilterStatus.TabIndex = 7;
            this.cboFilterStatus.SelectedIndexChanged += new System.EventHandler(this.cboFilterStatus_SelectedIndexChanged);
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
            this.colAccountID,
            this.colUsername,
            this.colStartDate,
            this.colStaffID,
            this.colStatus});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvMain.GridColor = System.Drawing.Color.LightGray;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.RowTemplate.Height = 25;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMain.Size = new System.Drawing.Size(1202, 568);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // colAccountID
            // 
            this.colAccountID.HeaderText = "Mã tài khoản";
            this.colAccountID.MinimumWidth = 6;
            this.colAccountID.Name = "colAccountID";
            this.colAccountID.ReadOnly = true;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Tên đăng nhập";
            this.colUsername.MinimumWidth = 6;
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            // 
            // colStartDate
            // 
            this.colStartDate.HeaderText = "Ngày tạo";
            this.colStartDate.MinimumWidth = 6;
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.ReadOnly = true;
            // 
            // colStaffID
            // 
            this.colStaffID.HeaderText = "Mã nhân viên";
            this.colStaffID.MinimumWidth = 6;
            this.colStaffID.Name = "colStaffID";
            this.colStaffID.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Trạng thái";
            this.colStatus.MinimumWidth = 6;
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.gunaPanel3);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1202, 281);
            this.gunaPanel1.TabIndex = 50;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.guna2Button4);
            this.gunaPanel2.Controls.Add(this.lblFilterStatus);
            this.gunaPanel2.Controls.Add(this.cboFilterStatus);
            this.gunaPanel2.Controls.Add(this.guna2Button1);
            this.gunaPanel2.Controls.Add(this.guna2Button3);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel2.Location = new System.Drawing.Point(807, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(395, 281);
            this.gunaPanel2.TabIndex = 0;
            // 
            // gunaPanel3
            // 
            this.gunaPanel3.Controls.Add(this.guna2GroupBox2);
            this.gunaPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel3.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel3.Name = "gunaPanel3";
            this.gunaPanel3.Size = new System.Drawing.Size(802, 281);
            this.gunaPanel3.TabIndex = 1;
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.Controls.Add(this.dgvMain);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 281);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(1202, 571);
            this.gunaPanel4.TabIndex = 51;
            // 
            // frmAccountAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1202, 800);
            this.Controls.Add(this.gunaPanel4);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "frmAccountAdmin";
            this.Text = "frmAccountAdmin";
            this.Load += new System.EventHandler(this.frmAccountAdmin_Load);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.gunaPanel2.PerformLayout();
            this.gunaPanel3.ResumeLayout(false);
            this.gunaPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label lblStatus;
        private Guna.UI.WinForms.GunaComboBox cboStatus;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private Guna.UI.WinForms.GunaComboBox gunaTextBox1;
        private System.Windows.Forms.Label lblFilterStatus;
        private Guna.UI.WinForms.GunaComboBox cboFilterStatus;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel3;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
    }
}