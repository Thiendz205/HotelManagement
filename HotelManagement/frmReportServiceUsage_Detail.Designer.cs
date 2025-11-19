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
            this.dtpTo = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFrom = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cboRoom = new Guna.UI.WinForms.GunaComboBox();
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
            this.btnXemBaoCao.Location = new System.Drawing.Point(1308, 23);
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
            this.panel1.Controls.Add(this.btnXemBaoCao);
            this.panel1.Controls.Add(this.dtpTo);
            this.panel1.Controls.Add(this.dtpFrom);
            this.panel1.Controls.Add(this.gunaLabel4);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.cboRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1740, 116);
            this.panel1.TabIndex = 17;
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
            this.dtpTo.Location = new System.Drawing.Point(911, 18);
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
            this.dtpFrom.Location = new System.Drawing.Point(384, 18);
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
            this.gunaLabel4.Location = new System.Drawing.Point(242, 63);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(54, 20);
            this.gunaLabel4.TabIndex = 24;
            this.gunaLabel4.Text = "Phòng:";
            this.gunaLabel4.Click += new System.EventHandler(this.gunaLabel4_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(789, 24);
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
            this.gunaLabel1.Location = new System.Drawing.Point(231, 22);
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
            this.cboRoom.Location = new System.Drawing.Point(384, 58);
            this.cboRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboRoom.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboRoom.Size = new System.Drawing.Size(248, 31);
            this.cboRoom.TabIndex = 20;
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
        private Guna.UI.WinForms.GunaDateTimePicker dtpTo;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFrom;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cboRoom;
        private System.Windows.Forms.Panel panel2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}