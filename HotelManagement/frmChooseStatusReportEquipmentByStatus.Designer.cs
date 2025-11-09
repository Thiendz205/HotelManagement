namespace HotelManagement
{
    partial class frmChooseStatusReportEquipmentByStatus
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
            this.cachedrptInvoiceDetailByBooking1 = new HotelManagement.Reports.CachedrptInvoiceDetailByBooking();
            this.dtDSEquipmentByStatus = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grouud = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.btnIn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSEquipmentByStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.grouud.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtDSEquipmentByStatus
            // 
            this.dtDSEquipmentByStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtDSEquipmentByStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSEquipmentByStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDSEquipmentByStatus.Location = new System.Drawing.Point(0, 0);
            this.dtDSEquipmentByStatus.MultiSelect = false;
            this.dtDSEquipmentByStatus.Name = "dtDSEquipmentByStatus";
            this.dtDSEquipmentByStatus.ReadOnly = true;
            this.dtDSEquipmentByStatus.RowHeadersWidth = 51;
            this.dtDSEquipmentByStatus.RowTemplate.Height = 24;
            this.dtDSEquipmentByStatus.Size = new System.Drawing.Size(1222, 312);
            this.dtDSEquipmentByStatus.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtDSEquipmentByStatus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 312);
            this.panel1.TabIndex = 8;
            // 
            // grouud
            // 
            this.grouud.Controls.Add(this.btnIn);
            this.grouud.Controls.Add(this.cbTrangThai);
            this.grouud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grouud.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grouud.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grouud.Location = new System.Drawing.Point(0, 0);
            this.grouud.Name = "grouud";
            this.grouud.ShadowDecoration.Parent = this.grouud;
            this.grouud.Size = new System.Drawing.Size(1222, 589);
            this.grouud.TabIndex = 9;
            this.grouud.Text = "Chọn trạng thái";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Available",
            "Maintenance",
            "In Use"});
            this.cbTrangThai.Location = new System.Drawing.Point(460, 134);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(170, 36);
            this.cbTrangThai.TabIndex = 0;
            this.cbTrangThai.SelectedIndexChanged += new System.EventHandler(this.cbTrangThai_SelectedIndexChanged);
            // 
            // btnIn
            // 
            this.btnIn.BorderRadius = 10;
            this.btnIn.CheckedState.Parent = this.btnIn;
            this.btnIn.CustomImages.Parent = this.btnIn;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.HoverState.Parent = this.btnIn;
            this.btnIn.Location = new System.Drawing.Point(698, 115);
            this.btnIn.Name = "btnIn";
            this.btnIn.ShadowDecoration.Parent = this.btnIn;
            this.btnIn.Size = new System.Drawing.Size(221, 64);
            this.btnIn.TabIndex = 7;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmChooseStatusReportEquipmentByStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 589);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grouud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChooseStatusReportEquipmentByStatus";
            this.Text = "frmChooseStatusReportEquipmentByStatus";
            this.Load += new System.EventHandler(this.frmChooseStatusReportEquipmentByStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDSEquipmentByStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.grouud.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Reports.CachedrptInvoiceDetailByBooking cachedrptInvoiceDetailByBooking1;
        private System.Windows.Forms.DataGridView dtDSEquipmentByStatus;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox grouud;
        private Guna.UI2.WinForms.Guna2Button btnIn;
        private System.Windows.Forms.ComboBox cbTrangThai;
    }
}