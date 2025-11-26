namespace HotelManagement
{
    partial class frmMaintenanceCreateGUI
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
            this.btnBack = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddBooking = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.cboTechnician = new System.Windows.Forms.ComboBox();
            this.cboMaintenanceType = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2GroupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BorderRadius = 20;
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.CustomImages.Parent = this.btnBack;
            this.btnBack.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = global::HotelManagement.Properties.Resources.ChangeRommRECP;
            this.btnBack.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBack.Location = new System.Drawing.Point(510, 67);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(185, 66);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Quay Lại";
            this.btnBack.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.BorderRadius = 20;
            this.btnAddBooking.CheckedState.Parent = this.btnAddBooking;
            this.btnAddBooking.CustomImages.Parent = this.btnAddBooking;
            this.btnAddBooking.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddBooking.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.ForeColor = System.Drawing.Color.Black;
            this.btnAddBooking.HoverState.Parent = this.btnAddBooking;
            this.btnAddBooking.Image = global::HotelManagement.Properties.Resources.confirmRECP;
            this.btnAddBooking.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAddBooking.Location = new System.Drawing.Point(114, 67);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.ShadowDecoration.Parent = this.btnAddBooking;
            this.btnAddBooking.Size = new System.Drawing.Size(185, 66);
            this.btnAddBooking.TabIndex = 0;
            this.btnAddBooking.Text = "Lưu";
            this.btnAddBooking.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.BorderRadius = 20;
            this.guna2GroupBox3.BorderThickness = 4;
            this.guna2GroupBox3.Controls.Add(this.btnBack);
            this.guna2GroupBox3.Controls.Add(this.btnAddBooking);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(306, 438);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(795, 172);
            this.guna2GroupBox3.TabIndex = 12;
            this.guna2GroupBox3.Text = "Chức Năng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2GroupBox3);
            this.panel1.Controls.Add(this.guna2GroupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 610);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.BorderRadius = 20;
            this.guna2GroupBox2.BorderThickness = 4;
            this.guna2GroupBox2.Controls.Add(this.lstRooms);
            this.guna2GroupBox2.Controls.Add(this.cboTechnician);
            this.guna2GroupBox2.Controls.Add(this.cboMaintenanceType);
            this.guna2GroupBox2.Controls.Add(this.label17);
            this.guna2GroupBox2.Controls.Add(this.label9);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(112, 38);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(1074, 345);
            this.guna2GroupBox2.TabIndex = 2;
            this.guna2GroupBox2.Text = "Bào trì";
            // 
            // lstRooms
            // 
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.ItemHeight = 22;
            this.lstRooms.Location = new System.Drawing.Point(622, 67);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(380, 246);
            this.lstRooms.TabIndex = 46;
            // 
            // cboTechnician
            // 
            this.cboTechnician.FormattingEnabled = true;
            this.cboTechnician.Location = new System.Drawing.Point(214, 131);
            this.cboTechnician.Name = "cboTechnician";
            this.cboTechnician.Size = new System.Drawing.Size(175, 30);
            this.cboTechnician.TabIndex = 45;
            // 
            // cboMaintenanceType
            // 
            this.cboMaintenanceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaintenanceType.FormattingEnabled = true;
            this.cboMaintenanceType.Location = new System.Drawing.Point(214, 67);
            this.cboMaintenanceType.Name = "cboMaintenanceType";
            this.cboMaintenanceType.Size = new System.Drawing.Size(175, 30);
            this.cboMaintenanceType.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(30, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 22);
            this.label17.TabIndex = 4;
            this.label17.Text = "Nhân viên bảo trì";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Loại bảo trì";
            // 
            // frmMaintenanceCreateGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1248, 610);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMaintenanceCreateGUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMaintenanceCreateGUI";
            this.Load += new System.EventHandler(this.frmMaintenanceCreateGUI_Load);
            this.guna2GroupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnBack;
        private Guna.UI2.WinForms.Guna2Button btnAddBooking;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.ComboBox cboMaintenanceType;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTechnician;
        private System.Windows.Forms.ListBox lstRooms;
    }
}