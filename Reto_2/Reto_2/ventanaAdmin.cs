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
        private List<RegistrarPeticion.PQRS> pqrs;
        public ventanaAdmin(List<RegistrarPeticion.PQRS> pqrs)
        {
            InitializeComponent();
            this.pqrs = pqrs;
            MessageBox.Show($"Pqrs recibidas: {pqrs.Count}");
            CargarDatos();
        }

        private void CargarDatos()
        {
            dvg_datos.DataSource = null;
            dvg_datos.DataSource = pqrs;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
