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
    public partial class frmEstadisticas : Form
    {
        Controladora controladora = new Controladora();
        public frmEstadisticas()
        {
            InitializeComponent();
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

        private void ListarVehiculosXCliente(int pIdCliente)
        {
            lvsClientes.Visible = false;
            lvsReparaciones.Visible = false;
            lvsVehiculos.Visible = true;
            lvsVehiculos.Items.Clear();
            foreach (Vehiculo vehiculo in controladora.ListaVehiculos())
            {
                if (vehiculo.Dueno.Id == pIdCliente)
                {
                    ListViewItem item = new ListViewItem(vehiculo.Id.ToString());
                    item.SubItems.Add(vehiculo.Matricula);
                    item.SubItems.Add(vehiculo.Modelo);
                    item.SubItems.Add(vehiculo.Marca);
                    item.SubItems.Add(vehiculo.Dueno.Nombre);
                    lvsVehiculos.Items.Add(item);
                }
            }
        }

        private void ListarReparacionesXVehiculo(int pIdVehiculo)
        {
            lvsClientes.Visible = false;
            lvsReparaciones.Visible = true;
            lvsVehiculos.Visible = false;
            lvsReparaciones.Items.Clear();
            foreach (Reparacion reparacion in controladora.ListaReparaciones())
            {
                if (reparacion.Vehiculo.Id == pIdVehiculo)
                {
                    ListViewItem item = new ListViewItem(reparacion.Id.ToString());
                    item.SubItems.Add(reparacion.Fecha.ToString());
                    item.SubItems.Add(reparacion.Vehiculo.Matricula);
                    item.SubItems.Add(reparacion.Descripcion);
                    item.SubItems.Add(reparacion.Costo.ToString());
                    lvsReparaciones.Items.Add(item);
                }
            }
        }
        private void ListarClientes()
        {
            lvsClientes.Visible = true;
            lvsReparaciones.Visible = false;
            lvsVehiculos.Visible = false;
            lvsClientes.Items.Clear();

            foreach (Cliente cliente in controladora.ListaClientes())
            {
                ListViewItem item = new ListViewItem(cliente.Id.ToString());
                item.SubItems.Add(cliente.Nombre);
                item.SubItems.Add(cliente.Telefono);
                int vehiculosCuenta = 0;
                foreach (Vehiculo vehiculo in controladora.ListaVehiculos())
                {
                    if (vehiculo.Dueno.Id == cliente.Id)
                    {
                        vehiculosCuenta++;
                    }
                }
                item.SubItems.Add(vehiculosCuenta.ToString());
                lvsClientes.Items.Add(item);
            }
        }

        private void frmLstVentas_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Para listar las reparaciones de un vehiculo seleccione Vehiculo y el vehiculo. " +
                "\n\nPara listar los vehiculos de un cliente seleccione Cliente y el cliente. " +
                "\n\nPara listar todos los clientes con la cantidad de vehiculos que poseen seleccione Listar Clientes y Vehiculos. ");
            CargarClientes();
            CargarVehiculos();

            ListarClientes();
        }

        private void lvsLinea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (rdoDueno.Checked)
            {
                if (cmbCliente.SelectedIndex == 0)
                {
                    return;
                }
                string cLinea = cmbCliente.SelectedItem.ToString();
                string[] cArrayLinea = cLinea.Split(':');
                int idCliente = int.Parse(cArrayLinea[0]);

                ListarVehiculosXCliente(idCliente);
                cmbCliente.SelectedIndex = 0;

            }
            else if(rdoVehiculo.Checked)
            {
                if (cmbVehiculo.SelectedIndex == 0)
                {
                    return;
                }
                string vLinea = cmbVehiculo.SelectedItem.ToString();
                string[] vArrayLinea = vLinea.Split(':');
                int idVehiculo = int.Parse(vArrayLinea[0]);

                ListarReparacionesXVehiculo(idVehiculo);
                cmbVehiculo.SelectedIndex = 0;
            }
            else if (rdoCliente.Checked)
            {
                ListarClientes();
                cmbVehiculo.SelectedIndex = 0;
            }
        }
    }
}
