namespace HotelManagement.CustomControl
{
    partial class btnRooms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtPtice = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTypeRoom = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2GradientPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.BorderRadius = 50;
            this.guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2GradientPanel1.BorderThickness = 5;
            this.guna2GradientPanel1.Controls.Add(this.panel3);
            this.guna2GradientPanel1.Controls.Add(this.panel2);
            this.guna2GradientPanel1.Controls.Add(this.panel1);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(8, 8);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(168, 162);
            this.guna2GradientPanel1.TabIndex = 0;
            this.guna2GradientPanel1.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.guna2GradientPanel1.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPtice);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 42);
            this.panel3.TabIndex = 2;
            // 
            // txtPtice
            // 
            this.txtPtice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPtice.Enabled = false;
            this.txtPtice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPtice.Location = new System.Drawing.Point(19, 3);
            this.txtPtice.Name = "txtPtice";
            this.txtPtice.Size = new System.Drawing.Size(129, 34);
            this.txtPtice.TabIndex = 2;
            this.txtPtice.Text = "Price";
            this.txtPtice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNumber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 90);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel1_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // txtNumber
            // 
            this.txtNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumber.Enabled = false;
            this.txtNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.Location = new System.Drawing.Point(10, 23);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(147, 41);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.Text = "NUMBER";
            this.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTypeRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 29);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.MouseEnter += new System.EventHandler(this.panel2_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.panel2_MouseLeave);
            // 
            // btnTypeRoom
            // 
            this.btnTypeRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTypeRoom.BorderRadius = 15;
            this.btnTypeRoom.CheckedState.Parent = this.btnTypeRoom;
            this.btnTypeRoom.CustomImages.Parent = this.btnTypeRoom;
            this.btnTypeRoom.FillColor = System.Drawing.Color.Yellow;
            this.btnTypeRoom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTypeRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTypeRoom.HoverState.Parent = this.btnTypeRoom;
            this.btnTypeRoom.Location = new System.Drawing.Point(98, 0);
            this.btnTypeRoom.Name = "btnTypeRoom";
            this.btnTypeRoom.ShadowDecoration.Parent = this.btnTypeRoom;
            this.btnTypeRoom.Size = new System.Drawing.Size(70, 28);
            this.btnTypeRoom.TabIndex = 0;
            this.btnTypeRoom.Text = "VIP";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(82, 0);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(38, 22);
            this.guna2GradientButton1.TabIndex = 0;
            this.guna2GradientButton1.Text = "VIP";
            // 
            // btnRooms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "btnRooms";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(184, 178);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnTypeRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPtice;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
