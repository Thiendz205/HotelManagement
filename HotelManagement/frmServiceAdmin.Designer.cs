namespace HotelManagement
{
    partial class frmServiceAdmin
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.txtServiceID = new Guna.UI.WinForms.GunaTextBox();
            this.txtServiceName = new Guna.UI.WinForms.GunaTextBox();
            this.gunaComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.txtDescription = new Guna.UI.WinForms.GunaTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.headerPanel = new Guna.UI.WinForms.GunaPanel();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceID,
            this.colServiceName,
            this.colCategory,
            this.colPrice,
            this.colDescription});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMain.Size = new System.Drawing.Size(1200, 443);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // colServiceID
            // 
            this.colServiceID.HeaderText = "Mã dịch vụ";
            this.colServiceID.MinimumWidth = 6;
            this.colServiceID.Name = "colServiceID";
            this.colServiceID.ReadOnly = true;
            // 
            // colServiceName
            // 
            this.colServiceName.HeaderText = "Tên dịch vụ";
            this.colServiceName.MinimumWidth = 6;
            this.colServiceName.Name = "colServiceName";
            this.colServiceName.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Danh mục";
            this.colCategory.MinimumWidth = 6;
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Giá";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colDescription
            // 
            this.colDescription.HeaderText = "Mô tả";
            this.colDescription.MinimumWidth = 6;
            this.colDescription.Name = "colDescription";
            this.colDescription.ReadOnly = true;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblServiceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblServiceName.Location = new System.Drawing.Point(18, 74);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(77, 19);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Mã dịch vụ";
            // 
            // txtServiceID
            // 
            this.txtServiceID.BaseColor = System.Drawing.Color.White;
            this.txtServiceID.BorderColor = System.Drawing.Color.Silver;
            this.txtServiceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtServiceID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtServiceID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtServiceID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtServiceID.Location = new System.Drawing.Point(114, 74);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.PasswordChar = '\0';
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.SelectedText = "";
            this.txtServiceID.Size = new System.Drawing.Size(189, 33);
            this.txtServiceID.TabIndex = 8;
            // 
            // txtServiceName
            // 
            this.txtServiceName.BaseColor = System.Drawing.Color.White;
            this.txtServiceName.BorderColor = System.Drawing.Color.Silver;
            this.txtServiceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtServiceName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtServiceName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtServiceName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtServiceName.Location = new System.Drawing.Point(114, 168);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PasswordChar = '\0';
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.Size = new System.Drawing.Size(189, 33);
            this.txtServiceName.TabIndex = 9;
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
            this.gunaComboBox2.Location = new System.Drawing.Point(118, 261);
            this.gunaComboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaComboBox2.Name = "gunaComboBox2";
            this.gunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox2.Size = new System.Drawing.Size(161, 26);
            this.gunaComboBox2.TabIndex = 18;
            this.gunaComboBox2.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(134, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Lọc Theo Danh Mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(3, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tên dịch vụ";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCategory.Location = new System.Drawing.Point(377, 74);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(47, 19);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Nhóm";
            // 
            // txtPrice
            // 
            this.txtPrice.BaseColor = System.Drawing.Color.White;
            this.txtPrice.BorderColor = System.Drawing.Color.Silver;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPrice.Location = new System.Drawing.Point(114, 118);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(189, 33);
            this.txtPrice.TabIndex = 5;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
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
            this.gunaComboBox1.Location = new System.Drawing.Point(477, 76);
            this.gunaComboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(221, 26);
            this.gunaComboBox1.TabIndex = 17;
            // 
            // txtDescription
            // 
            this.txtDescription.BaseColor = System.Drawing.Color.White;
            this.txtDescription.BorderColor = System.Drawing.Color.Silver;
            this.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescription.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDescription.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtDescription.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.Location = new System.Drawing.Point(477, 126);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.SelectedText = "";
            this.txtDescription.Size = new System.Drawing.Size(221, 70);
            this.txtDescription.TabIndex = 7;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPrice.Location = new System.Drawing.Point(28, 116);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 19);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Giá";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDescription.Location = new System.Drawing.Point(378, 137);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(46, 19);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Mô tả";
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.gunaPanel1);
            this.headerPanel.Controls.Add(this.panel1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1200, 355);
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
            this.guna2Button4.Location = new System.Drawing.Point(200, 157);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.ShadowDecoration.Parent = this.guna2Button4;
            this.guna2Button4.Size = new System.Drawing.Size(134, 50);
            this.guna2Button4.TabIndex = 23;
            this.guna2Button4.Text = "Làm mới";
            this.guna2Button4.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Image = global::HotelManagement.Properties.Resources.updateHR;
            this.btnEdit.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Location = new System.Drawing.Point(54, 157);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(134, 50);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Controls.Add(this.txtServiceName);
            this.guna2GroupBox2.Controls.Add(this.lblCategory);
            this.guna2GroupBox2.Controls.Add(this.lblDescription);
            this.guna2GroupBox2.Controls.Add(this.lblServiceName);
            this.guna2GroupBox2.Controls.Add(this.lblPrice);
            this.guna2GroupBox2.Controls.Add(this.txtDescription);
            this.guna2GroupBox2.Controls.Add(this.txtServiceID);
            this.guna2GroupBox2.Controls.Add(this.gunaComboBox1);
            this.guna2GroupBox2.Controls.Add(this.txtPrice);
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox2.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(792, 355);
            this.guna2GroupBox2.TabIndex = 27;
            this.guna2GroupBox2.Text = "Thông tin dịch vụ";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::HotelManagement.Properties.Resources.signs_close_icon_png;
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(200, 74);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(134, 50);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::HotelManagement.Properties.Resources.addHR;
            this.btnAdd.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdd.Location = new System.Drawing.Point(55, 74);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(134, 50);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2GroupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 355);
            this.panel1.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.guna2Button4);
            this.gunaPanel1.Controls.Add(this.btnDelete);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Controls.Add(this.btnEdit);
            this.gunaPanel1.Controls.Add(this.gunaComboBox2);
            this.gunaPanel1.Controls.Add(this.btnAdd);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.gunaPanel1.Location = new System.Drawing.Point(797, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(403, 355);
            this.gunaPanel1.TabIndex = 1;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.dgvMain);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 355);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(1200, 443);
            this.gunaPanel2.TabIndex = 2;
            // 
            // frmServiceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmServiceAdmin";
            this.Text = "frmServiceAdmin";
            this.Load += new System.EventHandler(this.frmServiceAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.Label lblServiceName;
        private Guna.UI.WinForms.GunaTextBox txtServiceID;
        private Guna.UI.WinForms.GunaTextBox txtServiceName;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI.WinForms.GunaTextBox txtPrice;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaTextBox txtDescription;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI.WinForms.GunaPanel headerPanel;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
    }
}