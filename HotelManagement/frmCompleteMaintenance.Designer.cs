namespace HotelManagement
{
    partial class frmCompleteMaintenance
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCompleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnFailed = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(360, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Chọn kết quả bảo trì";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCompleted
            // 
            this.btnCompleted.BorderRadius = 8;
            this.btnCompleted.CheckedState.Parent = this.btnCompleted;
            this.btnCompleted.CustomImages.Parent = this.btnCompleted;
            this.btnCompleted.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCompleted.ForeColor = System.Drawing.Color.White;
            this.btnCompleted.HoverState.Parent = this.btnCompleted;
            this.btnCompleted.Location = new System.Drawing.Point(40, 80);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.ShadowDecoration.Parent = this.btnCompleted;
            this.btnCompleted.Size = new System.Drawing.Size(320, 45);
            this.btnCompleted.TabIndex = 1;
            this.btnCompleted.Text = "Bảo trì thành công";
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnFailed
            // 
            this.btnFailed.BorderRadius = 8;
            this.btnFailed.CheckedState.Parent = this.btnFailed;
            this.btnFailed.CustomImages.Parent = this.btnFailed;
            this.btnFailed.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnFailed.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnFailed.ForeColor = System.Drawing.Color.White;
            this.btnFailed.HoverState.Parent = this.btnFailed;
            this.btnFailed.Location = new System.Drawing.Point(40, 140);
            this.btnFailed.Name = "btnFailed";
            this.btnFailed.ShadowDecoration.Parent = this.btnFailed;
            this.btnFailed.Size = new System.Drawing.Size(320, 45);
            this.btnFailed.TabIndex = 2;
            this.btnFailed.Text = "Bảo trì không được";
            this.btnFailed.Click += new System.EventHandler(this.btnFailed_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(120, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(160, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCompleteMaintenance
            // 
            this.ClientSize = new System.Drawing.Size(400, 270);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFailed);
            this.Controls.Add(this.btnCompleted);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCompleteMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hoàn tất bảo trì";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnCompleted;
        private Guna.UI2.WinForms.Guna2Button btnFailed;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
