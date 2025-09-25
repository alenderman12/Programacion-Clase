using Agenda.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Presentacion
{
    public partial class frmContacto : Form
    {
        Dominio.Controladora controladora = new Dominio.Controladora();
        public frmContacto()
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
            txtId.Text = controladora.IdContacto.ToString();
            txtNombre.Text = "";
            txtTelefono.Text = "";
            cmbCiudad.SelectedItem = "";
            txtId.Focus();
            lbmMensaje.Visible = false;
        }

        private void ListarContactos()
        {
            lstContactos.DataSource = null;
            lstContactos.DataSource = controladora.ListaContactos();
        }
        private void CargarCiudades()
        {
            cmbCiudad.Items.Clear();
            cmbCiudad.Items.Add("Seleccione una ciudad");
            foreach (Ciudad ciudad in controladora.ListaCiudades())
            {
                cmbCiudad.Items.Add(ciudad.Id + " : " + ciudad.Nombre);
            }
            cmbCiudad.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                DisplayError("Debe ingresar un ID y un nombre");
                return;
            }
            int Id = controladora.IdContacto;
            string Nombre = txtNombre.Text;
            string Telefono = txtTelefono.Text;
            string Email = txtEmail.Text;

            string lineaCiudad = cmbCiudad.SelectedIndex.ToString();
            string[] arrayCiudad = lineaCiudad.Split(':');
            int idCiudad = int.Parse(arrayCiudad[0]);
            Ciudad ciudad = controladora.BuscarCiudad(idCiudad);


            Dominio.Contacto unContacto = new Dominio.Contacto(Id, Nombre, Telefono, Email, ciudad);

            if (ciudad == null)
            {
                DisplayError("Debe seleccionar una ciudad");
                return;
            }

            if (controladora.AltaContacto(unContacto))
            {
                ListarContactos();
                LimpiarCajas();
            }
            else
            {
                DisplayError("Este contacto no tiene un ID unico");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string[] linea = lstContactos.SelectedItem.ToString().Split(':');
            int Id = int.Parse(linea[0]);
            controladora.BajaContacto(Id);
            ListarContactos();
            LimpiarCajas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string[] linea = lstContactos.SelectedItem.ToString().Split(':');
            int Id = int.Parse(linea[0]);
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                DisplayError("Debe ingresar un ID y un nombre");
                return;
            }
            string Nombre = txtNombre.Text;
            string Telefono = txtTelefono.Text;
            string Email = txtEmail.Text;

            string lineaCiudad = cmbCiudad.SelectedIndex.ToString();
            string[] arrayCiudad = lineaCiudad.Split(':');
            int idCiudad = int.Parse(arrayCiudad[0]);
            Ciudad ciudad = controladora.BuscarCiudad(idCiudad);

            Dominio.Contacto unContacto = new Dominio.Contacto(Id, Nombre, Telefono, Email, ciudad);


            if (ciudad == null)
            {
                DisplayError("Debe seleccionar una ciudad");
                return;
            }
            if (controladora.ModificarContacto(Id, Nombre, Telefono, Email, ciudad))
            {
                ListarContactos();
                LimpiarCajas();
            }
            else
            {
                DisplayError("Este contacto no tiene un ID unico");
            }
        }

        private void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContactos.SelectedItem != null)
            {
                string linea = lstContactos.SelectedItem.ToString();
                string[] arrayLinea = linea.Split(':');
                int Id = int.Parse(arrayLinea[0]);

                Dominio.Contacto unContacto = controladora.BuscarContacto(Id);

                if (unContacto != null)
                {
                    txtId.Text = unContacto.Id.ToString();
                    txtNombre.Text = unContacto.Nombre;
                    txtTelefono.Text = unContacto.Telefono;
                    txtEmail.Text = unContacto.Email;
                    cmbCiudad.SelectedItem = unContacto.Ciudad.Id + " : " + unContacto.Ciudad.Nombre;
                }
            }
        }

        private void frmContacto_Load(object sender, EventArgs e)
        {
            LimpiarCajas();
            CargarCiudades();
            ListarContactos();
        }
    }
}
