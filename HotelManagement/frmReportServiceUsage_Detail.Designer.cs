namespace HotelManagement
{
    partial class frmReportServiceUsage_Detail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportServiceUsage_Detail));
            this.btnXemBaoCao = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboCustomer = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.dtpTo = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFrom = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cboRoom = new Guna.UI.WinForms.GunaComboBox();
            this.cboStaff = new Guna.UI.WinForms.GunaComboBox();
            this.cboServiceCat = new Guna.UI.WinForms.GunaComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.AnimationHoverSpeed = 0.07F;
            this.btnXemBaoCao.AnimationSpeed = 0.03F;
            this.btnXemBaoCao.BaseColor = System.Drawing.Color.Gray;
            this.btnXemBaoCao.BorderColor = System.Drawing.Color.Black;
            this.btnXemBaoCao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXemBaoCao.FocusedColor = System.Drawing.Color.Empty;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnXemBaoCao.Image")));
            this.btnXemBaoCao.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXemBaoCao.Location = new System.Drawing.Point(1482, 23);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXemBaoCao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXemBaoCao.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.OnHoverImage = null;
            this.btnXemBaoCao.OnPressedColor = System.Drawing.Color.Black;
            this.btnXemBaoCao.Size = new System.Drawing.Size(213, 52);
            this.btnXemBaoCao.TabIndex = 16;
            this.btnXemBaoCao.Text = "Xem Báo Cáo";
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboCustomer);
            this.panel1.Controls.Add(this.btnXemBaoCao);
            this.panel1.Controls.Add(this.gunaLabel6);
            this.panel1.Controls.Add(this.gunaLabel5);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel3);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.cboRoom);
            this.panel1.Controls.Add(this.cboStaff);
            this.panel1.Controls.Add(this.cboServiceCat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1740, 116);
            this.panel1.TabIndex = 17;
            // 
            // cboCustomer
            // 
            this.cboCustomer.BackColor = System.Drawing.Color.Transparent;
            this.cboCustomer.BaseColor = System.Drawing.Color.White;
            this.cboCustomer.BorderColor = System.Drawing.Color.Silver;
            this.cboCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCustomer.FocusedColor = System.Drawing.Color.Empty;
            this.cboCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCustomer.ForeColor = System.Drawing.Color.Black;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(267, 61);
            this.cboCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboCustomer.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboCustomer.Size = new System.Drawing.Size(244, 31);
            this.cboCustomer.TabIndex = 29;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel6.Location = new System.Drawing.Point(555, 70);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(61, 20);
            this.gunaLabel6.TabIndex = 28;
            this.gunaLabel6.Text = "Dịch vụ:";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel5.Location = new System.Drawing.Point(1006, 25);
            this.gunaLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(80, 20);
            this.gunaLabel5.TabIndex = 27;
            this.gunaLabel5.Text = "Nhân Viên:";
            // 
            // dtpTo
            // 
            this.dtpTo.BaseColor = System.Drawing.Color.White;
            this.dtpTo.BorderColor = System.Drawing.Color.Silver;
            this.dtpTo.CustomFormat = null;
            this.dtpTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.ForeColor = System.Drawing.Color.Black;
            this.dtpTo.Location = new System.Drawing.Point(677, 18);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTo.OnPressedColor = System.Drawing.Color.Black;
            this.dtpTo.Size = new System.Drawing.Size(245, 32);
            this.dtpTo.TabIndex = 26;
            this.dtpTo.Text = "10 Tháng Mười Một 2025";
            this.dtpTo.Value = new System.DateTime(2025, 11, 10, 2, 45, 5, 761);
            // 
            // dtpFrom
            // 
            this.dtpFrom.BaseColor = System.Drawing.Color.White;
            this.dtpFrom.BorderColor = System.Drawing.Color.Silver;
            this.dtpFrom.CustomFormat = null;
            this.dtpFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.ForeColor = System.Drawing.Color.Black;
            this.dtpFrom.Location = new System.Drawing.Point(264, 18);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFrom.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFrom.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFrom.Size = new System.Drawing.Size(248, 32);
            this.dtpFrom.TabIndex = 25;
            this.dtpFrom.Text = "10 Tháng Mười Một 2025";
            this.dtpFrom.Value = new System.DateTime(2025, 11, 10, 2, 45, 5, 761);
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(1032, 69);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(54, 20);
            this.gunaLabel4.TabIndex = 24;
            this.gunaLabel4.Text = "Phòng:";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(52, 64);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(89, 20);
            this.gunaLabel3.TabIndex = 23;
            this.gunaLabel3.Text = "Khách hàng:";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(555, 24);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(75, 20);
            this.gunaLabel2.TabIndex = 22;
            this.gunaLabel2.Text = "Đến ngày:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(52, 22);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(65, 20);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Từ ngày:";
            // 
            // cboRoom
            // 
            this.cboRoom.BackColor = System.Drawing.Color.Transparent;
            this.cboRoom.BaseColor = System.Drawing.Color.White;
            this.cboRoom.BorderColor = System.Drawing.Color.Silver;
            this.cboRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FocusedColor = System.Drawing.Color.Empty;
            this.cboRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRoom.ForeColor = System.Drawing.Color.Black;
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(1141, 61);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboRoom.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboRoom.Size = new System.Drawing.Size(244, 31);
            this.cboRoom.TabIndex = 20;
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
            this.cboStaff.Location = new System.Drawing.Point(1138, 20);
            this.cboStaff.Margin = new System.Windows.Forms.Padding(4);
            this.cboStaff.Name = "cboStaff";
            this.cboStaff.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboStaff.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboStaff.Size = new System.Drawing.Size(247, 31);
            this.cboStaff.TabIndex = 19;
            // 
            // cboServiceCat
            // 
            this.cboServiceCat.BackColor = System.Drawing.Color.Transparent;
            this.cboServiceCat.BaseColor = System.Drawing.Color.White;
            this.cboServiceCat.BorderColor = System.Drawing.Color.Silver;
            this.cboServiceCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboServiceCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServiceCat.FocusedColor = System.Drawing.Color.Empty;
            this.cboServiceCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboServiceCat.ForeColor = System.Drawing.Color.Black;
            this.cboServiceCat.FormattingEnabled = true;
            this.cboServiceCat.Location = new System.Drawing.Point(677, 64);
            this.cboServiceCat.Margin = new System.Windows.Forms.Padding(4);
            this.cboServiceCat.Name = "cboServiceCat";
            this.cboServiceCat.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboServiceCat.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboServiceCat.Size = new System.Drawing.Size(244, 31);
            this.cboServiceCat.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.crystalReportViewer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1740, 588);
            this.panel2.TabIndex = 18;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1740, 588);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelWidth = 267;
            // 
            // frmReportServiceUsage_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1740, 704);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmReportServiceUsage_Detail";
            this.Text = "frmReportServiceUsage_Detail";
            this.Load += new System.EventHandler(this.frmReportServiceUsage_Detail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton btnXemBaoCao;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaComboBox cboCustomer;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDateTimePicker dtpTo;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFrom;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cboRoom;
        private Guna.UI.WinForms.GunaComboBox cboStaff;
        private Guna.UI.WinForms.GunaComboBox cboServiceCat;
        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}