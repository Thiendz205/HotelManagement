using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.CustomControl
{
    public partial class btnRooms : UserControl
    {
        public string RoomId { get; set; }
        public string TypeRoom
        {
            get { return btnTypeRoom.Text; }
            set { btnTypeRoom.Text = value; }
        }
        public string PriceRoom
        {
            get { return txtPtice.Text; }
            set { txtPtice.Text = value; }
        }

        public string NumberRoom
        {
            get { return txtNumber.Text; }
            set { txtNumber.Text = value; }
        }

        public btnRooms()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Tomato; // Hover
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent; // Reset
        }


        [Browsable(true)]
        [Category("Appearance")]
        [Description("Màu nền phòng")]
        public Color RoomColor
        {
            get { return panel1.BackColor; }
            set
            {
                panel1.BackColor = value;
                panel2.BackColor = value;
                panel3.BackColor = value;
            }
        }




    }
}
