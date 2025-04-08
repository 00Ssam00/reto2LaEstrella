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

    public class Usuario
    {
            public string Nombre {  get; set; }
            public string Documento {  get; set; }
            public string Password { get; set; }

            public Usuario(string nombre, string documento, string password)
            { 
                Nombre = nombre;
                Documento = documento;
                Password = password;
            }


    }
    
        public RegistrarPeticion()
        {
            InitializeComponent();
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
                    
                }

            }
            else
            {
                MessageBox.Show("Debes autorizar el tratamiento de datos");
            }
        }

    }
}
