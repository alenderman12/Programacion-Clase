using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_Obligatorio.Dominio;

namespace Taller_Obligatorio.Presentacion
{
    public partial class frmVehiculo : Form
    {
        Controladora controladora = new Controladora();
        public frmVehiculo()
        {
            InitializeComponent();
        }

        private void LimpiarCajas()
        {
            txtId.Text = controladora.IdVehiculo().ToString();
            txtMatricula.Clear();
            txtModelo.Clear();
            txtMarca.Clear();
            cmbCliente.SelectedIndex = 0;
            lblMensaje.Visible = false;
            txtId.Focus();
        }

        private void ListarVehiculos()
        {
            lvsVehiculos.Items.Clear();
            foreach (Vehiculo vehiculo in controladora.ListaVehiculos())
            {
                ListViewItem item = new ListViewItem(vehiculo.Id.ToString());
                item.SubItems.Add(vehiculo.Matricula);
                item.SubItems.Add(vehiculo.Modelo);
                item.SubItems.Add(vehiculo.Marca);
                item.SubItems.Add(vehiculo.Dueno.Nombre);
                lvsVehiculos.Items.Add(item);
            }
            txtId.Text = controladora.IdVehiculo().ToString();
        }
        private void DisplayError(string msg)
        {
            lblMensaje.Text = msg;
            lblMensaje.Visible = true;
        }

        private void CargarClientes()
        {
            cmbCliente.Items.Clear();
            cmbCliente.Items.Add("Seleccione un cliente");
            foreach (Cliente cliente in controladora.ListaClientes())
            {
                cmbCliente.Items.Add(cliente.Id + " : " + cliente.Nombre);
            }
            cmbCliente.SelectedIndex = 0;
        }

        private void frmVehiculo_Load(object sender, EventArgs e)
        {
            CargarClientes();
            ListarVehiculos();
            LimpiarCajas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtMatricula.Text == "")
            {
                DisplayError("Debe completar todos los campos requeridos");
                return;
            }

            int Id = controladora.IdVehiculo();
            string Matricula = txtMatricula.Text;
            string Modelo = txtMarca.Text;
            string Marca = txtMarca.Text;

            if (cmbCliente.SelectedIndex == 0)
            {
                DisplayError("Debe seleccionar un Dueno");
                return;
            }
            string linea = cmbCliente.SelectedItem.ToString();
            string[] arrayLinea = linea.Split(':');
            int idCliente = int.Parse(arrayLinea[0]);
            Cliente Dueno = controladora.BuscarCliente(idCliente);

            Vehiculo vehiculo = new Vehiculo(Id, Matricula, Modelo, Marca, Dueno);
            if (controladora.AltaVehiculo(vehiculo))
            {
                ListarVehiculos();
                LimpiarCajas();
            }
            else
            {
                DisplayError("Ya existe un vehiculo con ese ID");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtMatricula.Text == "")
            {
                DisplayError("Debe completar todos los campos requeridos");
                return;
            }

            int Id = int.Parse(txtId.Text);
            string Matricula = txtMatricula.Text;
            string Modelo = txtMarca.Text;
            string Marca = txtMarca.Text;

            if (cmbCliente.SelectedIndex == 0)
            {
                DisplayError("Debe seleccionar un Dueno");
                return;
            }
            DisplayError("asdfasdfasdfasfas");
            string linea = cmbCliente.SelectedItem.ToString();
            string[] arrayLinea = linea.Split(':');
            int idCliente = int.Parse(arrayLinea[0]);
            Cliente Dueno = controladora.BuscarCliente(idCliente);


            if (controladora.ModificarVehiculo(Id, Matricula, Modelo, Marca, Dueno))
            {
                ListarVehiculos();
                LimpiarCajas();
            }
            else
            {
                DisplayError("No existe un vehiculo con ese ID");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvsVehiculos.SelectedItems[0];
            int Id = int.Parse(item.SubItems[0].Text);

            if (controladora.BajaVehiculo(Id))
            {
                ListarVehiculos();
                LimpiarCajas();
            }
        }

        private void lblLimpiarCajas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimpiarCajas();
        }

        private void lvsVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsVehiculos.SelectedItems.Count > 0)
            {
                ListViewItem item = lvsVehiculos.SelectedItems[0];

                txtId.Text = item.SubItems[0].Text;
                Vehiculo vehiculo = controladora.BuscarVehiculo(int.Parse(txtId.Text));

                txtMatricula.Text = item.SubItems[1].Text;
                txtModelo.Text = item.SubItems[3].Text;
                txtMarca.Text = item.SubItems[2].Text;
                cmbCliente.Text = vehiculo.Dueno.ToString();
            }
        }
    }
}
