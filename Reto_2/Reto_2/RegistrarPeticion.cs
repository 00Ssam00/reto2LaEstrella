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
    public partial class RegistrarPeticion : Form
    {
        public RegistrarPeticion()
        {
            InitializeComponent();
        }

        private void btn_Inicio_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();

        }

        private void pb_Registrar_Click(object sender, EventArgs e)
        {

        }
    }
}
