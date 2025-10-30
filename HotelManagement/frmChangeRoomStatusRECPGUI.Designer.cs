namespace HotelManagement
{
    partial class frmChangeRoomStatusRECPGUI
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.cboRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.BorderRadius = 20;
            this.guna2GroupBox1.BorderThickness = 4;
            this.guna2GroupBox1.Controls.Add(this.lblCurrentStatus);
            this.guna2GroupBox1.Controls.Add(this.cboRoom);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.cboStatus);
            this.guna2GroupBox1.Controls.Add(this.btnUpdateStatus);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 36);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(1427, 211);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Chức năng";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentStatus.Location = new System.Drawing.Point(636, 144);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(43, 33);
            this.lblCurrentStatus.TabIndex = 7;
            this.lblCurrentStatus.Text = "__";
            // 
            // cboRoom
            // 
            this.cboRoom.FormattingEnabled = true;
            this.cboRoom.Location = new System.Drawing.Point(170, 74);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(389, 39);
            this.cboRoom.TabIndex = 6;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chọn phòng";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Trống",
            "Dọn dẹp",
            "Bảo trì"});
            this.cboStatus.Location = new System.Drawing.Point(170, 138);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(389, 39);
            this.cboStatus.TabIndex = 4;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateStatus.BorderRadius = 20;
            this.btnUpdateStatus.CheckedState.Parent = this.btnUpdateStatus;
            this.btnUpdateStatus.CustomImages.Parent = this.btnUpdateStatus;
            this.btnUpdateStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdateStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateStatus.HoverState.Parent = this.btnUpdateStatus;
            this.btnUpdateStatus.Image = global::HotelManagement.Properties.Resources.updateHR;
            this.btnUpdateStatus.ImageSize = new System.Drawing.Size(40, 40);
            this.btnUpdateStatus.Location = new System.Drawing.Point(1188, 114);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.ShadowDecoration.Parent = this.btnUpdateStatus;
            this.btnUpdateStatus.Size = new System.Drawing.Size(205, 63);
            this.btnUpdateStatus.TabIndex = 3;
            this.btnUpdateStatus.Text = "Chuyển đổi";
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn trạng thái";
            // 
            // frmChangeRoomStatusRECPGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "frmChangeRoomStatusRECPGUI";
            this.Text = "frmChangeRoomStatusRECPGUI";
            this.Load += new System.EventHandler(this.frmChangeRoomStatusRECPGUI_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.ComboBox cboRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboStatus;
        private Guna.UI2.WinForms.Guna2Button btnUpdateStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurrentStatus;
    }
}