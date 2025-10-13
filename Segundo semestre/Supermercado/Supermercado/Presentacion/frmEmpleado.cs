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
    public partial class frmEmpleado : Form
    {
        Controladora controladora = new Controladora();

        public frmEmpleado()
        {
            InitializeComponent();
        }
        private void LimpiarCajas()
        {
            txtId.Text = controladora.IdEmpleado().ToString();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtSueldo.Clear();
            txtCargo.Clear();
            lblMensaje.Visible = false;
            txtId.Focus();
        }

        private void ListarEmpleados()
        {
            lvsEmpleados.Items.Clear();
            foreach (Empleado empleado in controladora.ListaEmpleados())
            {
                ListViewItem item = new ListViewItem(empleado.Id.ToString());
                item.SubItems.Add(empleado.Nombre);
                item.SubItems.Add(empleado.Direccion);
                item.SubItems.Add(empleado.Telefono);
                item.SubItems.Add(empleado.Sueldo.ToString());
                item.SubItems.Add(empleado.Cargo);
                lvsEmpleados.Items.Add(item);
            }
            txtId.Text = controladora.IdEmpleado().ToString();
        }
        private void DisplayError(string msg)
        {
            lblMensaje.Text = msg;
            lblMensaje.Visible = true;
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            ListarEmpleados();
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
            int Id = controladora.IdEmpleado();
            string Nombre = txtNombre.Text;
            string Direccion = txtDireccion.Text;
            string Telefono = txtTelefono.Text;
            int Sueldo = int.Parse(txtSueldo.Text);
            string Cargo = txtCargo.Text;

            Empleado empleado = new Empleado(Id, Nombre, Direccion, Telefono, Sueldo, Cargo);
            if (controladora.AltaEmpleado(empleado))
            {
                ListarEmpleados();
                LimpiarCajas();
            }
            else
            {
                DisplayError("Ya existe un empleado con ese ID");
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
            int Sueldo = int.Parse(txtSueldo.Text);
            string Cargo = txtCargo.Text;


            if (controladora.ModificarEmpleado(Id, Nombre, Direccion, Telefono, Sueldo, Cargo))
            {
                ListarEmpleados();
                LimpiarCajas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvsEmpleados.SelectedItems[0];
            int Id = int.Parse(item.SubItems[0].Text);

            if (controladora.BajaEmpleado(Id))
            {
                ListarEmpleados();
                LimpiarCajas();
            }
        }

        private void lblLimpiarCajas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimpiarCajas();
        }

        private void lvsProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsEmpleados.SelectedItems.Count > 0)
            {
                ListViewItem item = lvsEmpleados.SelectedItems[0];
                txtId.Text = item.SubItems[0].Text;
                txtNombre.Text = item.SubItems[1].Text;
                txtDireccion.Text = item.SubItems[2].Text;
                txtTelefono.Text = item.SubItems[3].Text;
                txtSueldo.Text = item.SubItems[4].Text;
                txtCargo.Text = item.SubItems[5].Text;
            }
        }
    }
}
