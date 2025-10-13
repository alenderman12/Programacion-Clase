using Supermercado.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado.Presentacion
{
    public partial class frmCliente : Form
    {
        Controladora controladora = new Controladora();

        public frmCliente()
        {
            InitializeComponent();
        }
        private void LimpiarCajas()
        {
            txtId.Text = controladora.IdCliente().ToString();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtDescuento.Clear();
            txtPuntos.Clear();
            lblMensaje.Visible = false;
            txtId.Focus();
        }

        private void ListarClientes()
        {
            lvsClientes.Items.Clear();
            foreach (Cliente cliente in controladora.ListaClientes())
            {
                ListViewItem item = new ListViewItem(cliente.Id.ToString());
                item.SubItems.Add(cliente.Nombre);
                item.SubItems.Add(cliente.Direccion);
                item.SubItems.Add(cliente.Telefono);
                item.SubItems.Add(cliente.Descuento.ToString());
                item.SubItems.Add(cliente.Puntos.ToString());
                lvsClientes.Items.Add(item);
            }
            txtId.Text = controladora.IdCliente().ToString();
        }
        private void DisplayError(string msg)
        {
            lblMensaje.Text = msg;
            lblMensaje.Visible = true;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            ListarClientes();
            LimpiarCajas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                DisplayError("Debe completar todos los campos requeridos");
                return;
            }
            else if (!int.TryParse(txtId.Text, out int a))
            {
                DisplayError("El ID debe ser un numero");
                return;
            }
            int Id = controladora.IdCliente();
            string Nombre = txtNombre.Text;
            string Direccion = txtDireccion.Text;
            string Telefono = txtTelefono.Text;
            int Descuento = int.Parse(txtDescuento.Text);
            int Puntos = int.Parse(txtPuntos.Text);

            Cliente cliente = new Cliente(Id, Nombre, Direccion, Telefono, Descuento, Puntos);
            if (controladora.AltaCliente(cliente))
            {
                ListarClientes();
                LimpiarCajas();
            }
            else
            {
                DisplayError("Ya existe un cliente con ese ID");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                DisplayError("Debe completar todos los campos requeridos");
                return;
            }

            int Id = int.Parse(txtId.Text);
            string Nombre = txtNombre.Text;
            string Direccion = txtDireccion.Text;
            string Telefono = txtTelefono.Text;
            int Descuento = int.Parse(txtDescuento.Text);
            int Puntos = int.Parse(txtPuntos.Text);


            if (controladora.ModificarCliente(Id, Nombre, Direccion, Telefono, Descuento, Puntos))
            {
                ListarClientes();
                LimpiarCajas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvsClientes.SelectedItems[0];
            int Id = int.Parse(item.SubItems[0].Text);

            if (controladora.BajaCliente(Id))
            {
                ListarClientes();
                LimpiarCajas();
            }
        }

        private void lblLimpiarCajas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimpiarCajas();
        }

        private void lvsClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsClientes.SelectedItems.Count > 0)
            {
                ListViewItem item = lvsClientes.SelectedItems[0];
                txtId.Text = item.SubItems[0].Text;
                txtNombre.Text = item.SubItems[1].Text;
                txtDireccion.Text = item.SubItems[2].Text;
                txtTelefono.Text = item.SubItems[3].Text;
                txtDescuento.Text = item.SubItems[4].Text;
                txtPuntos.Text = item.SubItems[5].Text;
            }
        }
    }
}
