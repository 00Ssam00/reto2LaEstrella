﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reto_2
{
    public partial class RegistrarPeticion : Form
    {

        private List<PQRS> pqrs = new List<PQRS>();
        

      

    public class PQRS
    {
            public string tipoSolicitante {  get; set; }
            public string condicionEspecial {  get; set; }
            public string tipoSolicitud { get; set; }
            public string medioRespuesta { get; set; }
            public string Correo {  get; set; }
            public string correoConfirm {  get; set; }
            public string Descripcion { get; set; }
            public int Radicado { get; set; }
            public bool Estado { get; set; } = false; // Estado por defecto es falso, no se ha atendido la solicitud
            public PQRS(string tiposolicitante, string condicionespecial, string tiposolicitud, string mediorespuesta, string correo, string correoconfirm, string descripcion, int radicado, bool estado)
            { 
                tipoSolicitante = tiposolicitante;
                condicionEspecial = condicionespecial;
                tipoSolicitud = tiposolicitud;
                medioRespuesta = mediorespuesta;
                Correo = correo;
                correoConfirm = correoconfirm;
                Descripcion = descripcion;
                Radicado = radicado;
                Estado = estado;
            }


    }
    
        public RegistrarPeticion()
        {
            InitializeComponent();
            solicitanteComboBox.Text = "Seleccione";
            condicionEspecialComboBox.Text = "Ninguno";
            tipoSolicitudComboBox.Text = "Seleccione";
            medioRespuestaComboBox.Text = "Seleccione ";

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
                string condicionEspecial = "";
                string tipoSolicitud = "";
                string medioRespuesta = "";
                string correo = "";
                string correoConfirm = "";
                string descripcion = "";
                int radicado = 0;
                bool estado = false;
                tipoSolicitante = solicitanteComboBox.Text;
                condicionEspecial = condicionEspecialComboBox.Text;
                tipoSolicitud = tipoSolicitudComboBox.Text;
                medioRespuesta = medioRespuestaComboBox.Text;
                correo = txtCorreo.Text;
                correoConfirm = txtConfirmacionCorreo.Text; 
                descripcion = txtDescripcion.Text;
                if (string.IsNullOrWhiteSpace(solicitanteComboBox.Text) || string.IsNullOrWhiteSpace(condicionEspecialComboBox.Text) ||
                    string.IsNullOrWhiteSpace(tipoSolicitudComboBox.Text) || string.IsNullOrWhiteSpace(medioRespuestaComboBox.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text) ||string.IsNullOrWhiteSpace(txtConfirmacionCorreo.Text) ||
                    string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de continuar.");
                    return;
                }
                if (tipoSolicitante == "Seleccione") { // Verifica si el campo solicitante tiene el valor por defecto.
                    MessageBox.Show("Por favor, selecciona un tipo de solicitante.");
                    return;
                }
                else if (tipoSolicitud == "Seleccione") { // Verifica si el campo tipo de solicitud tiene el valor por defecto.
                    MessageBox.Show("Por favor, selecciona un tipo de solicitud.");
                    return;
                }
                else if (medioRespuesta == "Seleccione") { // Verifica si el campo medio de respuesta tiene el valor por defecto.
                    MessageBox.Show("Por favor, selecciona un medio de respuesta.");
                    return;
                }
                else if (condicionEspecial == "Seleccione") { // Verifica si el campo condicion especial tiene el valor por defecto.
                    MessageBox.Show("Por favor, selecciona una condicion especial.");
                    return;
                }
                if (Regex.IsMatch(correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) // Verifica si el campo correo tiene el formato adecuado.
                {
                    if (correo != correoConfirm)
                    {
                        MessageBox.Show("Por favor, verifica que el correo coincida con su verificacion!");
                    }
                    else
                    {
                        Random rnd = new Random();
                        int Radicado = rnd.Next(10000, 99999);
                        Convert.ToString(Radicado);
                        MessageBox.Show($"Tu número de radicado es: {Radicado}");
                        radicado = Radicado;
                        pqrs.Add(new PQRS(tipoSolicitante, condicionEspecial, tipoSolicitud, medioRespuesta, correo, correoConfirm, descripcion, radicado, estado));
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, verifica que el correo tenga el formato adecuado!");
                }

            }
            else
            {
                MessageBox.Show("Debes autorizar el tratamiento de datos");
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            LoginAdmin loginadmin = new LoginAdmin(pqrs);
            loginadmin.Show();
            this.Hide();
        }
    }
}
