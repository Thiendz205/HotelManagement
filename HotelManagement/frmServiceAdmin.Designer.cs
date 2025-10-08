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
            this.headerPanel = new Guna.UI.WinForms.GunaPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.btnEdit = new Guna.UI.WinForms.GunaButton();
            this.btnDelete = new Guna.UI.WinForms.GunaButton();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorPanel = new Guna.UI.WinForms.GunaPanel();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.txtServiceName = new Guna.UI.WinForms.GunaTextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtCategory = new Guna.UI.WinForms.GunaTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI.WinForms.GunaTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new Guna.UI.WinForms.GunaTextBox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.editorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.txtSearch);
            this.headerPanel.Controls.Add(this.btnAdd);
            this.headerPanel.Controls.Add(this.btnEdit);
            this.headerPanel.Controls.Add(this.btnDelete);
            this.headerPanel.Controls.Add(this.btnRefresh);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(950, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Dịch vụ";
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
            this.txtSearch.Size = new System.Drawing.Size(260, 30);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Tìm theo tên/nhóm dịch vụ...";
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
            this.btnAdd.Location = new System.Drawing.Point(470, 22);
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
            this.btnEdit.Location = new System.Drawing.Point(580, 22);
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
            this.btnDelete.Location = new System.Drawing.Point(690, 22);
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
            this.btnRefresh.Location = new System.Drawing.Point(800, 22);
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
            // Khởi tạo cột trước
            //this.colServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.colServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            //this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colServiceID.HeaderText = "ServiceID";
            this.colServiceName.HeaderText = "ServiceName";
            this.colCategory.HeaderText = "Category";
            this.colPrice.HeaderText = "Price";
            this.colDescription.HeaderText = "Description";
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colServiceID,
            this.colServiceName,
            this.colCategory,
            this.colPrice,
            this.colDescription});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 200);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(950, 720);
            this.dgvMain.TabIndex = 1;
            // 
            // editorPanel
            // 
            this.editorPanel.BackColor = System.Drawing.Color.White;
            this.editorPanel.Controls.Add(this.lblServiceName);
            this.editorPanel.Controls.Add(this.txtServiceName);
            this.editorPanel.Controls.Add(this.lblCategory);
            this.editorPanel.Controls.Add(this.txtCategory);
            this.editorPanel.Controls.Add(this.lblPrice);
            this.editorPanel.Controls.Add(this.txtPrice);
            this.editorPanel.Controls.Add(this.lblDescription);
            this.editorPanel.Controls.Add(this.txtDescription);
            this.editorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editorPanel.Location = new System.Drawing.Point(0, 80);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(950, 120);
            this.editorPanel.TabIndex = 6;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblServiceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblServiceName.Location = new System.Drawing.Point(24, 16);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(79, 19);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Tên dịch vụ";
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
            this.txtServiceName.Location = new System.Drawing.Point(28, 38);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PasswordChar = '\0';
            this.txtServiceName.Size = new System.Drawing.Size(220, 30);
            this.txtServiceName.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblCategory.Location = new System.Drawing.Point(260, 16);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(48, 19);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Nhóm";
            // 
            // txtCategory
            // 
            this.txtCategory.BaseColor = System.Drawing.Color.White;
            this.txtCategory.BorderColor = System.Drawing.Color.Silver;
            this.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCategory.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtCategory.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCategory.Location = new System.Drawing.Point(264, 38);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.Size = new System.Drawing.Size(160, 30);
            this.txtCategory.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblPrice.Location = new System.Drawing.Point(436, 16);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 19);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Giá";
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
            this.txtPrice.Location = new System.Drawing.Point(440, 38);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.Size = new System.Drawing.Size(140, 30);
            this.txtPrice.TabIndex = 5;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblDescription.Location = new System.Drawing.Point(596, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(39, 19);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Mô tả";
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
            this.txtDescription.Location = new System.Drawing.Point(600, 38);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PasswordChar = '\0';
            this.txtDescription.Size = new System.Drawing.Size(332, 30);
            this.txtDescription.TabIndex = 7;
            // 
            // frmServiceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 800);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.editorPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmServiceAdmin";
            this.Text = "frmServiceAdmin";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.editorPanel.ResumeLayout(false);
            this.editorPanel.PerformLayout();
            this.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private Guna.UI.WinForms.GunaPanel editorPanel;
        private System.Windows.Forms.Label lblServiceName;
        private Guna.UI.WinForms.GunaTextBox txtServiceName;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI.WinForms.GunaTextBox txtCategory;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI.WinForms.GunaTextBox txtPrice;
        private System.Windows.Forms.Label lblDescription;
        private Guna.UI.WinForms.GunaTextBox txtDescription;
    }
}