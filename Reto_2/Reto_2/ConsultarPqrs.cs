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
    public partial class ConsultarPqrs : Form
    {
        private List<RegistrarPeticion.PQRS> pqrs;
        public ConsultarPqrs(List<RegistrarPeticion.PQRS> pqrs)
        {
            InitializeComponent();
            this.pqrs = pqrs;
            CargarDatos();
        }
        private void CargarDatos()
        {
        }
        public ConsultarPqrs()
        {
            InitializeComponent();
        }

        private void gbtn_Buscar_Click(object sender, EventArgs e)
        {
            string busqueda = gtxt_Radicado.Text.Trim(); // Le entrega a la variable busqueda lo ingresado en el textbox
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
            else {
                // Buscar por texto en Correo o tipoSolicitud solo si los valores no son números
                resultados = pqrs.Where(item =>
                    item.Correo.Contains(busqueda) || item.tipoSolicitud.Contains(busqueda)).ToList();
            }
            dvg_datos.DataSource = null;
            dvg_datos.DataSource = resultados; // Muestra los resultados de la busqueda en el datagridview
        }

        private void inicioButton_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            LoginAdmin ventanaAdmin = new LoginAdmin(pqrs);
            this.Hide();
            ventanaAdmin.Show();
        }

        private void gtxt_Radicado_TextChanged(object sender, EventArgs e)
        {

        }

        private void dvg_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
