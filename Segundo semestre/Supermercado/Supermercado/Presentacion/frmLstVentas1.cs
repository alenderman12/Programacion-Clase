using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado.Dominio
{
    public partial class frmLstVentas1 : Form
    {
        Controladora controladora = new Controladora();
        public frmLstVentas1()
        {
            InitializeComponent();
        }

        private void CargarEmpleados()
        {
            cmbEmpleado.Items.Clear();
            cmbEmpleado.Items.Add("Seleccione un empleado");
            foreach (Empleado empleado in controladora.ListaEmpleados())
            {
                cmbEmpleado.Items.Add(empleado.Id + " : " + empleado.Nombre);
            }
            cmbEmpleado.SelectedIndex = 0;
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

        private void ListarVentas(DateTime pFechaDesde, DateTime pFechaHasta)
        {
            lvsVenta.Items.Clear();
            foreach (Venta venta in controladora.ListaVentas())
            {
                if (venta.Fecha >= pFechaDesde && venta.Fecha <= pFechaHasta)
                {
                    ListViewItem item = new ListViewItem(venta.Id.ToString());
                    item.SubItems.Add(venta.Fecha.ToShortDateString());
                    item.SubItems.Add(venta.Cliente.Nombre);
                    item.SubItems.Add(venta.Empleado.Nombre);
                    item.SubItems.Add(venta.Total.ToString());
                    lvsVenta.Items.Add(item);
                }
            }
        }

        private void ListarVentasCliente(int pIdCliente)
        {
            lvsVenta.Items.Clear();
            foreach (Venta venta in controladora.ListaVentas())
            {
                if (venta.Cliente.Id == pIdCliente)
                {
                    ListViewItem item = new ListViewItem(venta.Id.ToString());
                    item.SubItems.Add(venta.Fecha.ToShortDateString());
                    item.SubItems.Add(venta.Cliente.Nombre);
                    item.SubItems.Add(venta.Empleado.Nombre);
                    item.SubItems.Add(venta.Total.ToString());
                    lvsVenta.Items.Add(item);
                }
            }
        }

        private void ListarVentasEmpleado(int pIdEmpleado)
        {
            lvsVenta.Items.Clear();
            foreach (Venta venta in controladora.ListaVentas())
            {
                if (venta.Empleado.Id == pIdEmpleado)
                {
                    ListViewItem item = new ListViewItem(venta.Id.ToString());
                    item.SubItems.Add(venta.Fecha.ToShortDateString());
                    item.SubItems.Add(venta.Cliente.Nombre);
                    item.SubItems.Add(venta.Empleado.Nombre);
                    item.SubItems.Add(venta.Total.ToString());
                    lvsVenta.Items.Add(item);
                }
            }
        }

        private void frmLstVentas_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarEmpleados();
            DateTime FechaDesde = DateTime.Today;
            DateTime FechaHasta = DateTime.Now;

            ListarVentas(FechaDesde, FechaHasta);
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
            if (cmbCliente.SelectedIndex > 0)
            {
                string cLinea = cmbCliente.SelectedItem.ToString();
                string[] cArrayLinea = cLinea.Split(':');
                int idCliente = int.Parse(cArrayLinea[0]);

                ListarVentasCliente(idCliente);
                cmbCliente.SelectedIndex = 0;

            }
            else if (cmbEmpleado.SelectedIndex > 0)
            {
                string eLinea = cmbEmpleado.SelectedItem.ToString();
                string[] eArrayLinea = eLinea.Split(':');
                int idEmpleado = int.Parse(eArrayLinea[0]);

                ListarVentasEmpleado(idEmpleado);
                cmbEmpleado.SelectedIndex = 0;
            }
            else
            {
                DateTime FechaDesde = DateTime.Today;
                DateTime FechaHasta = DateTime.Now;

                ListarVentas(FechaDesde, FechaHasta);
            }
        }
    }
}
