namespace HotelManagement
{
    partial class frmReportListMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportListMaintenance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbLoai = new Guna.UI.WinForms.GunaComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXemBaoCao = new Guna.UI.WinForms.GunaButton();
            this.cbThang = new Guna.UI.WinForms.GunaComboBox();
            this.dtNam = new System.Windows.Forms.DateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 141);
            this.panel1.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 141);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1221, 598);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel4.Location = new System.Drawing.Point(139, 76);
            this.gunaLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(40, 20);
            this.gunaLabel4.TabIndex = 30;
            this.gunaLabel4.Text = "Loại:";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(128, 35);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(53, 20);
            this.gunaLabel1.TabIndex = 28;
            this.gunaLabel1.Text = "Tháng:";
            // 
            // cbLoai
            // 
            this.cbLoai.BackColor = System.Drawing.Color.Transparent;
            this.cbLoai.BaseColor = System.Drawing.Color.White;
            this.cbLoai.BorderColor = System.Drawing.Color.Silver;
            this.cbLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoai.FocusedColor = System.Drawing.Color.Empty;
            this.cbLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoai.ForeColor = System.Drawing.Color.Black;
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "Room",
            "Equipment"});
            this.cbLoai.Location = new System.Drawing.Point(227, 71);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbLoai.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbLoai.Size = new System.Drawing.Size(248, 31);
            this.cbLoai.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gunaLabel2);
            this.panel2.Controls.Add(this.dtNam);
            this.panel2.Controls.Add(this.cbThang);
            this.panel2.Controls.Add(this.cbLoai);
            this.panel2.Controls.Add(this.gunaLabel4);
            this.panel2.Controls.Add(this.gunaLabel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(768, 141);
            this.panel2.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnXemBaoCao);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(768, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 141);
            this.panel3.TabIndex = 34;
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
            this.btnXemBaoCao.Location = new System.Drawing.Point(120, 44);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXemBaoCao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXemBaoCao.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.OnHoverImage = null;
            this.btnXemBaoCao.OnPressedColor = System.Drawing.Color.Black;
            this.btnXemBaoCao.Size = new System.Drawing.Size(213, 52);
            this.btnXemBaoCao.TabIndex = 17;
            this.btnXemBaoCao.Text = "Xem Báo Cáo";
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // cbThang
            // 
            this.cbThang.BackColor = System.Drawing.Color.Transparent;
            this.cbThang.BaseColor = System.Drawing.Color.White;
            this.cbThang.BorderColor = System.Drawing.Color.Silver;
            this.cbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThang.FocusedColor = System.Drawing.Color.Empty;
            this.cbThang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbThang.ForeColor = System.Drawing.Color.Black;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(227, 30);
            this.cbThang.Margin = new System.Windows.Forms.Padding(4);
            this.cbThang.Name = "cbThang";
            this.cbThang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbThang.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbThang.Size = new System.Drawing.Size(82, 31);
            this.cbThang.TabIndex = 31;
            // 
            // dtNam
            // 
            this.dtNam.CustomFormat = "yyyy";
            this.dtNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNam.Location = new System.Drawing.Point(422, 34);
            this.dtNam.Name = "dtNam";
            this.dtNam.ShowUpDown = true;
            this.dtNam.Size = new System.Drawing.Size(84, 22);
            this.dtNam.TabIndex = 32;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(371, 35);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(44, 20);
            this.gunaLabel2.TabIndex = 33;
            this.gunaLabel2.Text = "Năm:";
            // 
            // frmReportListMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 739);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportListMaintenance";
            this.Text = "frmReportListMaintenance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaComboBox cbLoai;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaButton btnXemBaoCao;
        private Guna.UI.WinForms.GunaComboBox cbThang;
        private System.Windows.Forms.DateTimePicker dtNam;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
    }
}