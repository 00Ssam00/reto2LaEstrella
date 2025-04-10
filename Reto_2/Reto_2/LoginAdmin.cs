using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace Reto_2
{
    public partial class LoginAdmin : Form
    {
        private List<RegistrarPeticion.PQRS> pqrs = new List<RegistrarPeticion.PQRS>();
                
        
        public LoginAdmin(List<RegistrarPeticion.PQRS>pqrs)
        {
            InitializeComponent();
            this.pqrs = pqrs;

        }

        private void txtClickAquiLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pop_Up pop_Up = new Pop_Up();
            pop_Up.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gtxt_User.Text == "1010" && gtxt_password.Text == "1010")
            {
                ventanaAdmin ventanaadmin = new ventanaAdmin(pqrs);
                ventanaadmin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos");
            }

        }
    }
}
