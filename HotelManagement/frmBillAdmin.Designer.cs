namespace HotelManagement
{
    partial class frmBillAdmin
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
            this.cboFilterAudit = new Guna.UI.WinForms.GunaComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnExport = new Guna.UI.WinForms.GunaButton();
            this.btnView = new Guna.UI.WinForms.GunaButton();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.btnRefresh = new Guna.UI.WinForms.GunaButton();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.colInvoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBookingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInvoiceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaidStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editorPanel = new Guna.UI.WinForms.GunaPanel();
            this.txtAuditNote = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAuditStatus = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.editorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.headerPanel.Controls.Add(this.cboFilterAudit);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.gunaComboBox1);
            this.headerPanel.Controls.Add(this.lblFilterStatus);
            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.txtSearch);
            this.headerPanel.Controls.Add(this.btnExport);
            this.headerPanel.Controls.Add(this.btnView);
            this.headerPanel.Controls.Add(this.btnUpdate);
            this.headerPanel.Controls.Add(this.btnRefresh);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1335, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // cboFilterAudit
            // 
            this.cboFilterAudit.BackColor = System.Drawing.Color.Transparent;
            this.cboFilterAudit.BaseColor = System.Drawing.Color.White;
            this.cboFilterAudit.BorderColor = System.Drawing.Color.Silver;
            this.cboFilterAudit.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFilterAudit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterAudit.FocusedColor = System.Drawing.Color.Empty;
            this.cboFilterAudit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilterAudit.ForeColor = System.Drawing.Color.Black;
            this.cboFilterAudit.FormattingEnabled = true;
            this.cboFilterAudit.Items.AddRange(new object[] {
            "Tiền mặt",
            "Quét QR",
            "Thẻ"});
            this.cboFilterAudit.Location = new System.Drawing.Point(642, 32);
            this.cboFilterAudit.Name = "cboFilterAudit";
            this.cboFilterAudit.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboFilterAudit.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboFilterAudit.Size = new System.Drawing.Size(160, 26);
            this.cboFilterAudit.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label1.Location = new System.Drawing.Point(660, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Lọc theo đánh giá";
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
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Tiền mặt",
            "Quét QR",
            "Thẻ"});
            this.gunaComboBox1.Location = new System.Drawing.Point(444, 31);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(160, 26);
            this.gunaComboBox1.TabIndex = 6;
            this.gunaComboBox1.SelectedIndexChanged += new System.EventHandler(this.gunaComboBox1_SelectedIndexChanged);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFilterStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblFilterStatus.Location = new System.Drawing.Point(462, 8);
            this.lblFilterStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(126, 19);
            this.lblFilterStatus.TabIndex = 17;
            this.lblFilterStatus.Text = "Lọc theo trạng thái";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Hóa đơn";
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
            this.txtSearch.Location = new System.Drawing.Point(140, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(260, 33);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnExport
            // 
            this.btnExport.AnimationHoverSpeed = 0.07F;
            this.btnExport.AnimationSpeed = 0.03F;
            this.btnExport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.btnExport.BorderColor = System.Drawing.Color.Black;
            this.btnExport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExport.FocusedColor = System.Drawing.Color.Empty;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = null;
            this.btnExport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExport.Location = new System.Drawing.Point(858, 24);
            this.btnExport.Name = "btnExport";
            this.btnExport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(60)))), ((int)(((byte)(152)))));
            this.btnExport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExport.OnHoverImage = null;
            this.btnExport.OnPressedColor = System.Drawing.Color.Black;
            this.btnExport.Size = new System.Drawing.Size(120, 34);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Xuất hóa đơn";
            this.btnExport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnView
            // 
            this.btnView.AnimationHoverSpeed = 0.07F;
            this.btnView.AnimationSpeed = 0.03F;
            this.btnView.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnView.BorderColor = System.Drawing.Color.Black;
            this.btnView.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnView.FocusedColor = System.Drawing.Color.Empty;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = null;
            this.btnView.ImageSize = new System.Drawing.Size(20, 20);
            this.btnView.Location = new System.Drawing.Point(988, 24);
            this.btnView.Name = "btnView";
            this.btnView.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnView.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnView.OnHoverForeColor = System.Drawing.Color.White;
            this.btnView.OnHoverImage = null;
            this.btnView.OnPressedColor = System.Drawing.Color.Black;
            this.btnView.Size = new System.Drawing.Size(100, 34);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "Xem";
            this.btnView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(1098, 24);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Đánh Giá";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(1208, 24);
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
            this.colInvoiceID,
            this.colBookingID,
            this.colInvoiceDate,
            this.colTotalAmount,
            this.colPaymentMethod,
            this.colPaidStatus,
            this.colStaffID});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 186);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidth = 51;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvMain.Size = new System.Drawing.Size(1335, 614);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // colInvoiceID
            // 
            this.colInvoiceID.HeaderText = "InvoiceID";
            this.colInvoiceID.MinimumWidth = 6;
            this.colInvoiceID.Name = "colInvoiceID";
            this.colInvoiceID.ReadOnly = true;
            // 
            // colBookingID
            // 
            this.colBookingID.HeaderText = "BookingID";
            this.colBookingID.MinimumWidth = 6;
            this.colBookingID.Name = "colBookingID";
            this.colBookingID.ReadOnly = true;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.HeaderText = "InvoiceDate";
            this.colInvoiceDate.MinimumWidth = 6;
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.HeaderText = "TotalAmount";
            this.colTotalAmount.MinimumWidth = 6;
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.HeaderText = "PaymentMethod";
            this.colPaymentMethod.MinimumWidth = 6;
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.ReadOnly = true;
            // 
            // colPaidStatus
            // 
            this.colPaidStatus.HeaderText = "PaidStatus";
            this.colPaidStatus.MinimumWidth = 6;
            this.colPaidStatus.Name = "colPaidStatus";
            this.colPaidStatus.ReadOnly = true;
            // 
            // colStaffID
            // 
            this.colStaffID.HeaderText = "StaffID";
            this.colStaffID.MinimumWidth = 6;
            this.colStaffID.Name = "colStaffID";
            this.colStaffID.ReadOnly = true;
            // 
            // editorPanel
            // 
            this.editorPanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.editorPanel.Controls.Add(this.txtAuditNote);
            this.editorPanel.Controls.Add(this.label3);
            this.editorPanel.Controls.Add(this.cboAuditStatus);
            this.editorPanel.Controls.Add(this.label2);
            this.editorPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.editorPanel.Location = new System.Drawing.Point(0, 80);
            this.editorPanel.Name = "editorPanel";
            this.editorPanel.Size = new System.Drawing.Size(1335, 106);
            this.editorPanel.TabIndex = 6;
            this.editorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editorPanel_Paint);
            // 
            // txtAuditNote
            // 
            this.txtAuditNote.BaseColor = System.Drawing.Color.White;
            this.txtAuditNote.BorderColor = System.Drawing.Color.Silver;
            this.txtAuditNote.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuditNote.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAuditNote.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.txtAuditNote.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAuditNote.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAuditNote.Location = new System.Drawing.Point(768, 44);
            this.txtAuditNote.Name = "txtAuditNote";
            this.txtAuditNote.PasswordChar = '\0';
            this.txtAuditNote.SelectedText = "";
            this.txtAuditNote.Size = new System.Drawing.Size(249, 28);
            this.txtAuditNote.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(439, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trạng thái đánh giá";
            // 
            // cboAuditStatus
            // 
            this.cboAuditStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboAuditStatus.BaseColor = System.Drawing.Color.White;
            this.cboAuditStatus.BorderColor = System.Drawing.Color.Silver;
            this.cboAuditStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAuditStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuditStatus.FocusedColor = System.Drawing.Color.Empty;
            this.cboAuditStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboAuditStatus.ForeColor = System.Drawing.Color.Black;
            this.cboAuditStatus.FormattingEnabled = true;
            this.cboAuditStatus.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cboAuditStatus.Location = new System.Drawing.Point(426, 44);
            this.cboAuditStatus.Name = "cboAuditStatus";
            this.cboAuditStatus.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.cboAuditStatus.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboAuditStatus.Size = new System.Drawing.Size(140, 26);
            this.cboAuditStatus.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(843, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ghi chú đánh giá";
            // 
            // frmBillAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 800);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.editorPanel);
            this.Controls.Add(this.headerPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBillAdmin";
            this.Text = "frmBillAdmin";
            this.Load += new System.EventHandler(this.frmBillAdmin_Load);
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
        private Guna.UI.WinForms.GunaButton btnExport;
        private Guna.UI.WinForms.GunaButton btnView;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private Guna.UI.WinForms.GunaButton btnRefresh;
        private System.Windows.Forms.DataGridView dgvMain;
        // editor
        private Guna.UI.WinForms.GunaPanel editorPanel;
        // columns
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBookingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInvoiceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaidStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffID;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private System.Windows.Forms.Label lblFilterStatus;
        private Guna.UI.WinForms.GunaComboBox cboFilterAudit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cboAuditStatus;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtAuditNote;
    }
}