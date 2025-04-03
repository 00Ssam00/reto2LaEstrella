using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto_2
{
    public partial class ventanaAdmin : Form
    {
        public ventanaAdmin()
        {
            InitializeComponent();
        }

        private void Llbl_Clickaqui_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pop_Up pop_Up = new Pop_Up();
            pop_Up.ShowDialog();
        }
    }
}
