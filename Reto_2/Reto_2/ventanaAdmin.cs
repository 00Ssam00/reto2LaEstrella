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

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //string busqueda = busquedaRadicado.Text;
            //if (string.IsNullOrEmpty(busqueda)) {
            //    MessageBox.Show("Por favor, ingresa un dato a buscar.");
            //    return;
            //}
            //bool encontrado = false;
            //foreach (var item in pqrs) {
            //    if (item.radicado.ToString() == busqueda) {
            //        dvg_datos.DataSource = null;
            //        dvg_datos.DataSource = new List<RegistrarPeticion.PQRS> { item };
            //        encontrado = true;
            //        break;
            //    }
            //}
            //if (!encontrado) {
            //    MessageBox.Show("No se encontró el radicado.");
            //}
            string busqueda = busquedaRadicado.Text.Trim();
            if (string.IsNullOrEmpty(busqueda)) {
                MessageBox.Show("Por favor, ingresa un dato a buscar.");
                return;
            }

            bool encontrado = false;

            foreach (var item in pqrs) {
                if (item.Radicado.ToString().Trim().Equals(busqueda, StringComparison.OrdinalIgnoreCase)) {
                    dvg_datos.DataSource = null;
                    dvg_datos.DataSource = new List<RegistrarPeticion.PQRS> { item };
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado) {
                MessageBox.Show("No se encontró el radicado.");
            }
        }

    }
}