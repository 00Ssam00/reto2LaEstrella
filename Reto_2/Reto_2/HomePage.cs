using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Reto_2
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            vsb_Scroll.Minimum = 0;
            vsb_Scroll.Maximum = 1000;  
            vsb_Scroll.SmallChange = 10;
            vsb_Scroll.LargeChange = 100;
            pnl_Principal.AutoScroll = true;

        }

        private void vsb_Scroll_scroll(object sender, ScrollEventArgs e)
        {
            this.Top = -vsb_Scroll.Value;
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            lbl_Parrafo2.Hide();

        }
    }
}
