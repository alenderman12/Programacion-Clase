using Agenda.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Presentacion
{
    public partial class frmCiudad : Form
    {
        Dominio.Controladora controladora = new Dominio.Controladora();
        public frmCiudad()
        {
            InitializeComponent();
        }

        private void DisplayError(string msg)
        {
            lbmMensaje.Text = msg;
            lbmMensaje.Visible = true;
        }

        private void LimpiarCajas()
        {
            txtId.Text = controladora.IdCiudad.ToString();
            txtNombre.Text = "";
            txtId.Focus();
            lbmMensaje.Visible = false;
        }
        private void ListarCiudades()
        {
            lstCiudades.DataSource = null;
            lstCiudades.DataSource = controladora.ListaCiudades();
        }

        private void frmCiudad_Load(object sender, EventArgs e)
        {
            LimpiarCajas();
            ListarCiudades();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                DisplayError("Debe ingresar un nombre y un ID");
                return;
            }
            int Id = controladora.IdCiudad;
            string Nombre = txtNombre.Text;

            Dominio.Ciudad unCliente = new Dominio.Ciudad(Id, Nombre);

            if (controladora.AltaCiudad(unCliente))
            {
                ListarCiudades();
                LimpiarCajas();
            }
            else
            {
                DisplayError("Esta ciuduad no tiene un ID unico");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string[] linea = lstCiudades.SelectedItem.ToString().Split(':');
            int Id = int.Parse(linea[0]);
            controladora.BajaCiudad(Id);
            ListarCiudades();
            LimpiarCajas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string[] linea = lstCiudades.SelectedItem.ToString().Split(':');
            int Id = int.Parse(linea[0]);
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                DisplayError("Debe ingresar un nombre y un ID");
                return;
            }

            if (controladora.ModificarCiudad(Id, txtNombre.Text))
            {
                ListarCiudades();
                LimpiarCajas();
            }
            else
            {
                DisplayError("Esta ciudad no tiene un ID unico");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCiudades.SelectedItem != null)
            {
                string linea = lstCiudades.SelectedItem.ToString();
                string[] arrayLinea = linea.Split(':');
                int Id = int.Parse(arrayLinea[0]);

                Dominio.Ciudad unCliente = controladora.BuscarCiudad(Id);

                if (unCliente != null)
                {
                    txtId.Text = unCliente.Id.ToString();
                    txtNombre.Text = unCliente.Nombre;
                }
            }
        }

        private void btnLimpiarCajas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimpiarCajas();
        }
    }
}
