using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller_Obligatorio.Dominio;

namespace Taller_Obligatorio.Presentacion
{
    public partial class frmReparacion : Form
    {
        Controladora controladora = new Controladora();
        public frmReparacion()
        {
            InitializeComponent();
        }

        private void LimpiarCajas()
        {
            txtId.Text = controladora.IdReparacion().ToString();
            dteFecha.Value = DateTime.Now;
            cmbVehiculo.SelectedIndex = 0;
            txtDescripcion.Clear();
            txtCosto.Clear();
            lblMensaje.Visible = false;
            txtId.Focus();
        }

        private void ListarReparaciones()
        {
            lvsReparaciones.Items.Clear();
            foreach (Reparacion reparacion in controladora.ListaReparaciones())
            {
                ListViewItem item = new ListViewItem(reparacion.Id.ToString());
                item.SubItems.Add(reparacion.Fecha.ToString());
                item.SubItems.Add(reparacion.Vehiculo.Matricula);
                item.SubItems.Add(reparacion.Descripcion);
                item.SubItems.Add(reparacion.Costo.ToString());
                lvsReparaciones.Items.Add(item);
            }
            txtId.Text = controladora.IdReparacion().ToString();
        }
        private void DisplayError(string msg)
        {
            lblMensaje.Text = msg;
            lblMensaje.Visible = true;
        }

        private void CargarVehiculos()
        {
            cmbVehiculo.Items.Clear();
            cmbVehiculo.Items.Add("Seleccione un vehiculo");
            foreach (Vehiculo vehiculo in controladora.ListaVehiculos())
            {
                cmbVehiculo.Items.Add(vehiculo.Id + " : " + vehiculo.Matricula);
            }
            cmbVehiculo.SelectedIndex = 0;
        }

        private void frmReparacion_Load(object sender, EventArgs e)
        {
            CargarVehiculos();
            ListarReparaciones();
            LimpiarCajas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtCosto.Text == "")
            {
                DisplayError("Debe completar todos los campos requeridos");
                return;
            }
            if (!int.TryParse(txtCosto.Text, out _))
            {
                DisplayError("El costo debe ser numerico.");
                return;
            }

            int Id = controladora.IdReparacion();
            DateTime Fecha = dteFecha.Value;

            if (cmbVehiculo.SelectedIndex == 0)
            {
                DisplayError("Debe seleccionar un Vehiculo");
                return;
            }
            string lineaV = cmbVehiculo.SelectedItem.ToString();
            string[] arrayLineaV = lineaV.Split(':');
            int idVehiculo = int.Parse(arrayLineaV[0]);
            Vehiculo vehiculo = controladora.BuscarVehiculo(idVehiculo);

            string Descripcion = txtDescripcion.Text;
            int Costo = int.Parse(txtCosto.Text);

            Reparacion reparacion = new Reparacion(Id, Fecha, vehiculo, Descripcion, Costo);
            if (controladora.AltaReparacion(reparacion))
            {
                ListarReparaciones();
                LimpiarCajas();
            }
            else
            {
                DisplayError("Ya existe un reparacion con ese ID");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                DisplayError("Debe completar todos los campos requeridos");
                return;
            }
            if (!int.TryParse(txtCosto.Text, out _))
            {
                DisplayError("El costo debe ser numerico.");
                return;
            }

            int Id = int.Parse(txtId.Text);
            DateTime Fecha = dteFecha.Value;

            if (cmbVehiculo.SelectedIndex == 0)
            {
                DisplayError("Debe seleccionar un Dueno");
                return;
            }
            string lineaV = cmbVehiculo.SelectedItem.ToString();
            string[] arrayLineaV = lineaV.Split(':');
            int idVehiculo = int.Parse(arrayLineaV[0]);
            Vehiculo vehiculo = controladora.BuscarVehiculo(idVehiculo);

            string Descripcion = txtDescripcion.Text;
            int Costo = int.Parse(txtCosto.Text);


            if (controladora.ModificarReparacion(Id, Fecha, vehiculo, Descripcion, Costo))
            {
                ListarReparaciones();
                LimpiarCajas();
            }
            else
            {
                DisplayError("No existe un reparacion con ese ID");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ListViewItem item = lvsReparaciones.SelectedItems[0];
            int Id = int.Parse(item.SubItems[0].Text);

            if (controladora.BajaReparacion(Id))
            {
                ListarReparaciones();
                LimpiarCajas();
            }
        }

        private void lblLimpiarCajas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimpiarCajas();
        }

        private void lvsReparaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsReparaciones.SelectedItems.Count > 0)
            {
                ListViewItem item = lvsReparaciones.SelectedItems[0];

                txtId.Text = item.SubItems[0].Text;
                Reparacion reparacion = controladora.BuscarReparacion(int.Parse(txtId.Text));

                dteFecha.Text = item.SubItems[1].Text;
                cmbVehiculo.Text = reparacion.Vehiculo.Id + " : " + reparacion.Vehiculo.Matricula;
                txtDescripcion.Text = item.SubItems[3].Text;
                txtCosto.Text = item.SubItems[4].Text;
            }
        }
    }
}
