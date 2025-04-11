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
        private List<RegistrarPeticion.PQRS> pqrs = new List<RegistrarPeticion.PQRS>();
        public HomePage()
        {
            InitializeComponent();
        }
        private void adminButtonClick(object sender, EventArgs e) // Boton para abrir la ventana de admin
        {
            LoginAdmin ventanaAdmin = new LoginAdmin(pqrs);
            this.Hide();
            ventanaAdmin.Show();
        }

        private void zoomButtonClick(object sender, EventArgs e)
        {

        }
        private void btnRegistrarClick(object sender, EventArgs e)
        {
            RegistrarPeticion registrarPeticion = new RegistrarPeticion();
            this.Hide();
            registrarPeticion.Show();
        }

        private void lbl_Denuncia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Esconder y mostrar el panel de denuncia
        {
            panelDenuncia.Visible = !panelDenuncia.Visible;

        }

        private void btnHideClick(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarPqrs consultarPqrs = new ConsultarPqrs(pqrs);
            this.Hide();
            consultarPqrs.Show();
        }
    }
}
