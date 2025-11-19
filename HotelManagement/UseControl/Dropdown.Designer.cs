namespace Design__Combobox.UseControl
{
    partial class Dropdown
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.mainButton = new System.Windows.Forms.Button();
            this.panelDrop = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(0, 0);
            this.mainButton.Margin = new System.Windows.Forms.Padding(0);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(200, 60);
            this.mainButton.Text = "Menu";
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // panelDrop
            // 
            this.panelDrop.Location = new System.Drawing.Point(200, 0);
            this.panelDrop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDrop.Name = "panelDrop";
            this.panelDrop.Size = new System.Drawing.Size(0, 60);
            this.panelDrop.MinimumSize = new System.Drawing.Size(0, 60);
            this.panelDrop.MaximumSize = new System.Drawing.Size(9999, 60);
            this.panelDrop.WrapContents = false;
            this.panelDrop.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.panelDrop.AutoSize = false;
            this.panelDrop.BackColor = System.Drawing.Color.Transparent;
            this.panelDrop.Padding = new System.Windows.Forms.Padding(0);
            // 
            // Dropdown (UserControl)
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelDrop);
            this.Controls.Add(this.mainButton);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Dropdown";
            this.Size = new System.Drawing.Size(200, 60);
            this.mainButton.BringToFront();     // ✨ Quan trọng: button luôn nhận click
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.FlowLayoutPanel panelDrop;
    }
}
