using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Design__Combobox.UseControl
{
    public partial class Dropdown : UserControl
    {
        private bool expanded = false;

        // 🔥 Sự kiện click option
        public event EventHandler<string> OptionClicked;

        public Dropdown()
        {
            InitializeComponent();
        }

        // =====================================
        //              Toggle
        // =====================================
        private void mainButton_Click(object sender, EventArgs e)
        {
            expanded = !expanded;
            Toggle();
        }

        private void Toggle()
        {
            if (expanded)
            {
                panelDrop.Width = panelDrop.PreferredSize.Width;
                this.Width = mainButton.Width + panelDrop.Width;
            }
            else
            {
                panelDrop.Width = 0;
                this.Width = mainButton.Width;
            }
        }

        // =====================================
        //        Add option
        // =====================================
        public void AddOption(string text)
        {
            Button btn = new Button();
            btn.Text = text;

            // Style
            btn.Size = new Size(_optionSize.Width, mainButton.Height);
            btn.Margin = _optionMargin;
            btn.Font = _optionFont;
            btn.BackColor = _optionBackColor;
            btn.ForeColor = _optionForeColor;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            // 🔥 Gửi event ra Form
            btn.Click += (s, e) => OptionClicked?.Invoke(this, text);

            panelDrop.Controls.Add(btn);

            panelDrop.Height = mainButton.Height;
            panelDrop.Width = panelDrop.PreferredSize.Width;

            if (expanded)
                Toggle();
        }

        // =====================================
        //        Items list
        // =====================================
        private List<string> _items = new List<string>();

        [Category("Dropdown")]
        public List<string> Items
        {
            get => _items;
            set
            {
                _items = value;
                Reload();
            }
        }

        private void Reload()
        {
            panelDrop.Controls.Clear();

            foreach (var item in _items)
                AddOption(item);

            panelDrop.Height = mainButton.Height;
        }

        // =====================================
        //           Appearance
        // =====================================
        [Category("Appearance")]
        public string MainText
        {
            get => mainButton.Text;
            set => mainButton.Text = value;
        }

        [Category("Appearance")]
        public Color MainBackColor
        {
            get => mainButton.BackColor;
            set => mainButton.BackColor = value;
        }

        [Category("Appearance")]
        public Color MainForeColor
        {
            get => mainButton.ForeColor;
            set => mainButton.ForeColor = value;
        }

        [Category("Appearance")]
        public Font MainFont
        {
            get => mainButton.Font;
            set => mainButton.Font = value;
        }

        [Category("Appearance")]
        public Size MainButtonSize
        {
            get => mainButton.Size;
            set
            {
                mainButton.Size = value;

                panelDrop.Location = new Point(value.Width, 0);
                panelDrop.Height = value.Height;

                this.Size = new Size(value.Width, value.Height);
            }
        }

        // =====================================
        //       Option Appearance
        // =====================================

        private Color _optionBackColor = Color.Gainsboro;
        private Color _optionForeColor = Color.Black;
        private Font _optionFont = new Font("Segoe UI", 10f);
        private Size _optionSize = new Size(150, 60);
        private Padding _optionMargin = new Padding(5, 0, 5, 0);

        [Category("Option Style")]
        public Color OptionBackColor { get => _optionBackColor; set { _optionBackColor = value; ApplyOptionStyle(); } }

        [Category("Option Style")]
        public Color OptionForeColor { get => _optionForeColor; set { _optionForeColor = value; ApplyOptionStyle(); } }

        [Category("Option Style")]
        public Font OptionFont { get => _optionFont; set { _optionFont = value; ApplyOptionStyle(); } }

        [Category("Option Style")]
        public Size OptionSize { get => _optionSize; set { _optionSize = value; ApplyOptionStyle(); } }

        [Category("Option Style")]
        public Padding OptionMargin { get => _optionMargin; set { _optionMargin = value; ApplyOptionStyle(); } }

        private void ApplyOptionStyle()
        {
            foreach (Control ctrl in panelDrop.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Size = new Size(_optionSize.Width, mainButton.Height);
                    btn.Margin = _optionMargin;
                    btn.Font = _optionFont;
                    btn.BackColor = _optionBackColor;
                    btn.ForeColor = _optionForeColor;
                }
            }

            panelDrop.Height = mainButton.Height;
        }
    }
}
