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

        private List<Usuario> usuarios = new List<Usuario>();
        private List<Admin> admins = new List<Admin>();

        public class Admin
        { 
            public string Documento;
            public string Password;

            public Admin(string documento, string password)
            {
                Documento = documento;
                Password = password;
            }
        }

    public class Usuario
    {
            public string tipoSolicitante {  get; set; }
            public string condicionEspecial {  get; set; }
            public string tipoSolicitud { get; set; }
            public string medioRespuesta { get; set; }

            public string Correo {  get; set; }

            public string correoConfirm {  get; set; }

            public string Descripcion { get; set; }

            public Usuario(string tiposolicitante, string condicionespecial, string tiposolicitud, string mediorespuesta, string correo, string correoconfirm, string descripcion)
            { 
                tipoSolicitante = tiposolicitante;
                condicionEspecial = condicionespecial;
                tipoSolicitud = tiposolicitud;
                medioRespuesta = mediorespuesta;
                Correo = correo;
                correoConfirm = correoconfirm;
                Descripcion = descripcion;
            }


    }
    
        public RegistrarPeticion()
        {
            InitializeComponent();
            condicionEspecialComboBox.Text = "Seleccionar";
        }

        private void inicioButtonClick(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Hide();
            homePage.Show();
        }
        private void checkBoxAutorizacionDatos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarClick(object sender, EventArgs e)
        {
            if (checkBoxAutorizacionDatos.Checked == true)
            {
                string tipoSolicitante = "";
                string CondicionEspecial = "";
                string tipoSolicitud = "";
                string medioRespuesta = "";
                string correo = "";
                string correoConfirm = "";
                string descripcion = "";
                tipoSolicitante = solicitanteComboBox.Text;
                CondicionEspecial = condicionEspecialComboBox.Text;
                tipoSolicitud = tipoSolicitudComboBox.Text;
                medioRespuesta = medioRespuestaComboBox.Text;
                correo = txtCorreo.Text;
                correoConfirm = txtConfirmacionCorreo.Text;
                if (string.IsNullOrWhiteSpace(solicitanteComboBox.Text) || string.IsNullOrWhiteSpace(condicionEspecialComboBox.Text) ||
                    string.IsNullOrWhiteSpace(tipoSolicitudComboBox.Text) || string.IsNullOrWhiteSpace(medioRespuestaComboBox.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text) ||string.IsNullOrWhiteSpace(txtConfirmacionCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if(correo != correoConfirm)
                {
                    MessageBox.Show("Por favor, verifica que el correo este bien diligenciado!");
                }
                else
                {
                    usuarios.Add(new Usuario(tipoSolicitante, CondicionEspecial, tipoSolicitud, medioRespuesta, correo, correoConfirm, descripcion));
                    admins.Add(new Admin("1010", "1010"));
                    Random rnd = new Random();
                    int Radicado = rnd.Next(1000000, 9999999);
                    Convert.ToString(Radicado);
                    MessageBox.Show($"Tu número de radicado es: {Radicado}");
                }

            }
            else
            {
                MessageBox.Show("Debes autorizar el tratamiento de datos");
            }
        }

    }
}
