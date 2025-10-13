using Supermercado.Dominio;

namespace Supermercado.Presentacion
{
    public partial class frmProducto : Form
    {
        Controladora controladora = new Controladora();
        public frmProducto()
        {
            InitializeComponent();
        }

        private void LimpiarCajas()
        {
            txtId.Text = controladora.IdProducto().ToString();
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
                item.SubItems.Add(producto.Familia.Nombre);
                item.SubItems.Add(producto.Unidad);
                item.SubItems.Add(producto.Precio.ToString());
                item.SubItems.Add(producto.Stock.ToString());
                lvsProductos.Items.Add(item);
            }
            txtId.Text = controladora.IdProducto().ToString();
        }
        private void DisplayError(string msg)
        {
            lblMensaje.Text = msg;
            lblMensaje.Visible = true;
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
            CargarFamilias();
            ListarProductos();
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
            int Id = controladora.IdProducto();
            string Nombre = txtNombre.Text;
            string Marca = txtMarca.Text;
            float Precio = float.Parse(txtPrecio.Text);

            if(cmbFamilia.SelectedIndex == 0)
            {
                DisplayError("Debe seleccionar una familia");
                return;
            }
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
                DisplayError("Ya existe un producto con ese ID");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                DisplayError("Debe completar todos los campos requeridos");
                return;
            }

            int Id = int.Parse(lvsProductos.SelectedItems[0].SubItems[0].Text);
            string Nombre = txtNombre.Text;
            string Marca = txtMarca.Text;
            float Precio = float.Parse(txtPrecio.Text);

            if (cmbFamilia.SelectedIndex == 0)
            {
                DisplayError("Debe seleccionar una familia");
                return;
            }
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
            ListViewItem item = lvsProductos.SelectedItems[0];
            int Id = int.Parse(item.SubItems[0].Text);

            if (controladora.BajaProducto(Id))
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
                Producto producto = controladora.BuscarProducto(int.Parse(txtId.Text));

                txtNombre.Text = item.SubItems[1].Text;
                txtMarca.Text = item.SubItems[2].Text;
                cmbFamilia.Text = producto.Familia.ToString();
                txtUnidad.Text = item.SubItems[4].Text;
                txtPrecio.Text = item.SubItems[5].Text;
                txtStock.Text = item.SubItems[6].Text;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
