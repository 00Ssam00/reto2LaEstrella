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
        public HomePage()
        {
            InitializeComponent();
            
        }

       

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            lbl_Parrafo2.Hide();

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            ventanaAdmin ventanaAdmin = new ventanaAdmin();
            this.Hide();
            ventanaAdmin.Show();
        }

        private void pb_Registrar_Click(object sender, EventArgs e)
        {
            RegistrarPeticion registrarPeticion = new RegistrarPeticion();
            this.Hide();
            registrarPeticion.Show();
        }
    }
}
