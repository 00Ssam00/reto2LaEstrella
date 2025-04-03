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
    public partial class Pop_Up : Form
    {
        public Pop_Up()
        {
            InitializeComponent();
        }

        private void gbtn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
