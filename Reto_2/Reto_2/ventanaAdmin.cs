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
            string busqueda = busquedaRadicado.Text.Trim(); // Le entrega a la variable busqueda lo ingresado en el textbox

            if (string.IsNullOrEmpty(busqueda)) // Si el textbox no tiene informacion, se muestra toda la lista.
            {
                dvg_datos.DataSource = null;
                dvg_datos.DataSource = pqrs;
                return;
            }

            List<RegistrarPeticion.PQRS> resultados; // Lista para almacenar los resultados de la busqueda

            if (int.TryParse(busqueda, out int radicadoBuscado)) // Si el valor ingresado es un numero, se busca por radicado
            {
                // Buscar por radicado
                resultados = pqrs.Where(item => item.Radicado.ToString().StartsWith(busqueda)).ToList();
                // Si se encuentra, se muestra la lista filtrada con los datos que inicien o sean iguales al radicado ingresado
            }
            else
            {
                // Buscar por texto en Correo o tipoSolicitud solo si los valores no son números
                resultados = pqrs.Where(item =>
                    (!string.IsNullOrEmpty(item.Correo) && item.Correo.ToLower().Contains(busqueda.ToLower())) ||
                    (!string.IsNullOrEmpty(item.tipoSolicitud) && item.tipoSolicitud.ToLower().Contains(busqueda.ToLower()))
                ).ToList();
            }

            if (resultados.Any()) // Si se encuentra al menos un resultado, se muestra la lista filtrada
            {
                dvg_datos.DataSource = null;
                dvg_datos.DataSource = resultados;
            }
            else // Si no se encuentra ningun resultado, se muestra un mensaje
            {
                MessageBox.Show("No se encontró ningún resultado que coincida.");
            }
        }
    }
}