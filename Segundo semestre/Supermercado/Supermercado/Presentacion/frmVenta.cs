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
    public partial class Ventas : Form
    {
        Controladora controladora = new Controladora();
        double Total = 0;
        public Ventas()
        {
            InitializeComponent();
        }

        private void LimpiarCajas()
        {
            txtLinea.Text = controladora.IdCliente().ToString();
            txtId.Text = controladora.IdVenta().ToString();
            cmbProducto.SelectedIndex = 0;
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtId.Focus();
        }
        private void LimpiarCajasVenta()
        {
            txtId.Text = controladora.IdVenta().ToString();
            dteFecha.Value = DateTime.Now;
            txtTotal.Clear();
            Total = 0;
            CargarClientes();
            CargarEmpleados();
            lvsLinea.Items.Clear();
        }

        private void ListarDetallesVenta()
        {
            lvsLinea.Items.Clear();
            foreach (DetalleVenta dVenta in controladora.ListaDetalleVentas())
            {
                ListViewItem item = new ListViewItem(dVenta.Id.ToString());
                item.SubItems.Add(dVenta.Producto.ToString());
                item.SubItems.Add(dVenta.Cantidad.ToString());
                item.SubItems.Add(dVenta.Precio.ToString());
                item.SubItems.Add((dVenta.Precio * dVenta.Cantidad).ToString());
                lvsLinea.Items.Add(item);
            }
            txtTotal.Text = Total.ToString();
            txtLinea.Text = controladora.IdDetalleVenta().ToString();
        }
        private void CargarProductos()
        {
            cmbProducto.Items.Clear();
            cmbProducto.Items.Add("Seleccione un producto");
            foreach (Producto producto in controladora.ListaProductos())
            {
                cmbProducto.Items.Add(producto.Id + " : " + producto.Nombre);
            }
            cmbProducto.SelectedIndex = 0;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos requeridos");
                return;
            }
            else if (!int.TryParse(txtId.Text, out int a))
            {
                MessageBox.Show("El ID debe ser un numero");
                return;
            }
            int Id = controladora.IdVenta();
            DateTime Fecha = dteFecha.Value;

            if (cmbCliente.SelectedIndex == 0 && cmbEmpleado.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente y un empleado");
                return;
            }
            string eLinea = cmbEmpleado.SelectedItem.ToString();
            string[] eArrayLinea = eLinea.Split(':');
            int idEmpleado = int.Parse(eArrayLinea[0]);
            Empleado empleado = controladora.BuscarEmpleado(idEmpleado);

            string cLinea = cmbCliente.SelectedItem.ToString();
            string[] cArrayLinea = cLinea.Split(':');
            int idCliente = int.Parse(cArrayLinea[0]);
            Cliente cliente = controladora.BuscarCliente(idCliente);

            Venta venta = new Venta(Id, Fecha, cliente, empleado, controladora.ListaDetalleVentas(), Total);
            if (controladora.AltaVenta(venta))
            {
                ListarDetallesVenta();
                LimpiarCajas();
                MessageBox.Show("Venta registrada con exito");
            }
            else
            {
                MessageBox.Show("Ya existe una venta con ese ID");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos requeridos");
                return;
            }
            else if (!int.TryParse(txtId.Text, out int a))
            {
                MessageBox.Show("El ID debe ser un numero");
                return;
            }
            int Id = controladora.IdDetalleVenta();

            if (cmbProducto.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente");
                return;
            }
            string linea = cmbProducto.SelectedItem.ToString();
            string[] arrayLinea = linea.Split(':');
            int idProducto = int.Parse(arrayLinea[0]);
            Producto producto = controladora.BuscarProducto(idProducto);

            int Cantidad = int.Parse(txtCantidad.Text);
            double Precio = double.Parse(txtPrecio.Text);

            DetalleVenta detalleVenta = new DetalleVenta(Id, producto, Precio, Cantidad);
            if (controladora.AltaDetalleVenta(detalleVenta))
            {
                Total += Cantidad * Precio;
                ListarDetallesVenta();
                LimpiarCajas();
            }
            else
            {
                MessageBox.Show("Ya existe un detalle de venta con ese ID");
            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarEmpleados();
            CargarProductos();
            ListarDetallesVenta();
            LimpiarCajasVenta();
            LimpiarCajas();
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex == 0)
            {
                //DisplayError("Debe seleccionar una familia");
                return;
            }
            string linea = cmbProducto.SelectedItem.ToString();
            string[] arrayLinea = linea.Split(':');
            int idProducto = int.Parse(arrayLinea[0]);
            Producto producto = controladora.BuscarProducto(idProducto);

            txtPrecio.Text = producto.Precio.ToString();
        }

        private void lvsLinea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
