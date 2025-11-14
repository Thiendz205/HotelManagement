namespace HotelManagement
{
    partial class frmSynthesisReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnThietBi = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1920, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(814, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng hợp các báo cáo";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 980);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1920, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(98, 880);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1797, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 880);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.guna2Button1);
            this.panel5.Controls.Add(this.btnThietBi);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(98, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1699, 880);
            this.panel5.TabIndex = 4;
            // 
            // btnThietBi
            // 
            this.btnThietBi.BorderRadius = 10;
            this.btnThietBi.CheckedState.Parent = this.btnThietBi;
            this.btnThietBi.CustomImages.Parent = this.btnThietBi;
            this.btnThietBi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThietBi.ForeColor = System.Drawing.Color.White;
            this.btnThietBi.HoverState.Parent = this.btnThietBi;
            this.btnThietBi.Location = new System.Drawing.Point(88, 57);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.ShadowDecoration.Parent = this.btnThietBi;
            this.btnThietBi.Size = new System.Drawing.Size(212, 54);
            this.btnThietBi.TabIndex = 0;
            this.btnThietBi.Text = "Các thiết bị trong kho";
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(359, 57);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(212, 54);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Chi tiết sử dụng dịch vụ";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frmSynthesisReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSynthesisReport";
            this.Text = "frmSynthesisReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnThietBi;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}