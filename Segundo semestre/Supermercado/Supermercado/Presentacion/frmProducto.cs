using Supermercado.Dominio;

namespace Supermercado.Presentacion
{
    public partial class Productos : Form
    {
        Controladora controladora = new Controladora();
        public Productos()
        {
            InitializeComponent();
        }

        private void LimpiarCajas()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            cmbFamilia.SelectedIndex = 0;
            txtStock.Clear();
            txtUnidad.Clear();
            lblMensaje.Visible = false;
            txtId.Focus();
        }

        private void ListarProductos()
        {
            lvsProductos.Items.Clear();
            foreach (Producto producto in controladora.ListaProductos())
            {
                ListViewItem item = new ListViewItem(producto.Id.ToString());
                item.SubItems.Add(producto.Nombre);
                item.SubItems.Add(producto.Marca);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Familia.Nombre);
                item.SubItems.Add(producto.Stock.ToString());
                item.SubItems.Add(producto.Unidad);
                lvsProductos.Items.Add(item);
            }
        }

        private void CargarFamilias()
        {
            cmbFamilia.Items.Clear();
            cmbFamilia.Items.Add("Seleccione una familia");
            foreach (Familia familia in controladora.ListaFamilias())
            {
                cmbFamilia.Items.Add(familia.Id + " : " + familia.Nombre);
            }
            cmbFamilia.SelectedIndex = 0;
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            ListarProductos();
            LimpiarCajas();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                lblMensaje.Text = "Debe completar todos los campos requeridos";
                lblMensaje.Visible = true;
                return;
            }
            else if (!int.TryParse(txtId.Text, out int a))
            {
                lblMensaje.Text = "El ID debe ser un numero";
                lblMensaje.Visible = true;
                return;
            }
            int Id = int.Parse(txtId.Text);
            string Nombre = txtNombre.Text;
            string Marca = txtMarca.Text;
            float Precio = float.Parse(txtPrecio.Text);

            string linea = cmbFamilia.SelectedItem.ToString();
            string[] arrayLinea = linea.Split(':');
            int idFamilia = int.Parse(arrayLinea[0]);
            Familia familia = controladora.BuscarFamilia(idFamilia);

            int Stock = int.Parse(txtStock.Text);
            string Unidad = txtUnidad.Text;

            Producto producto = new Producto(Id, Nombre, Marca, familia, Unidad, Precio, Stock);
            if (controladora.AltaProducto(producto))
            {
                ListarProductos();
                LimpiarCajas();
            }
            else
            {
                lblMensaje.Text = "Ya existe un producto con ese ID";
                lblMensaje.Visible = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                lblMensaje.Text = "Debe completar todos los campos requeridos";
                lblMensaje.Visible = true;
                return;
            }

            int Id = int.Parse(lvsProductos.SelectedItems[0].SubItems[0].Text);
            string Nombre = txtNombre.Text;
            string Marca = txtMarca.Text;
            float Precio = float.Parse(txtPrecio.Text);

            string linea = cmbFamilia.SelectedItem.ToString();
            string[] arrayLinea = linea.Split(':');
            int idFamilia = int.Parse(arrayLinea[0]);
            Familia familia = controladora.BuscarFamilia(idFamilia);

            int Stock = int.Parse(txtStock.Text);
            string Unidad = txtUnidad.Text;


            if (controladora.ModificarProducto(Id, Nombre, Marca, familia, Unidad, Precio, Stock))
            {
                ListarProductos();
                LimpiarCajas();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                lblMensaje.Text = "Seleccione un producto";
                lblMensaje.Visible = true;
                return;
            }

            int Id = int.Parse(txtId.Text);

            if (controladora.BajaFamilia(Id))
            {
                ListarProductos();
                LimpiarCajas();
            }
        }

        private void lblLimpiarCajas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimpiarCajas();
        }

        private void lvsFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsProductos.SelectedItems.Count > 0)
            {
                ListViewItem item = lvsProductos.SelectedItems[0];
                txtId.Text = item.SubItems[0].Text;
                txtNombre.Text = item.SubItems[1].Text;
                txtMarca.Text = item.SubItems[2].Text;
                cmbFamilia.Text = item.SubItems[3].Text;
                txtUnidad.Text = item.SubItems[4].Text;
                txtPrecio.Text = item.SubItems[5].Text;
                txtStock.Text = item.SubItems[6].Text;
            }
        }
    }
}
