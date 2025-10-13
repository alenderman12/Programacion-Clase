namespace Supermercado.Presentacion
{
    partial class frmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblLimpiarCajas = new LinkLabel();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            groupBox1 = new GroupBox();
            cmbFamilia = new ComboBox();
            txtStock = new TextBox();
            lblStock = new Label();
            txtPrecio = new TextBox();
            txtUnidad = new TextBox();
            lblPrecio = new Label();
            lblUnidad = new Label();
            txtMarca = new TextBox();
            lblFamilia = new Label();
            lblMarca = new Label();
            lblMensaje = new Label();
            lvsProductos = new ListView();
            Id = new ColumnHeader();
            Nombre = new ColumnHeader();
            Marca = new ColumnHeader();
            Familia = new ColumnHeader();
            Unidad = new ColumnHeader();
            Precio = new ColumnHeader();
            Stock = new ColumnHeader();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lblNombre = new Label();
            lblId = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLimpiarCajas
            // 
            lblLimpiarCajas.AutoSize = true;
            lblLimpiarCajas.Location = new Point(681, 187);
            lblLimpiarCajas.Name = "lblLimpiarCajas";
            lblLimpiarCajas.Size = new Size(78, 15);
            lblLimpiarCajas.TabIndex = 9;
            lblLimpiarCajas.TabStop = true;
            lblLimpiarCajas.Text = "Limpiar Cajas";
            lblLimpiarCajas.LinkClicked += lblLimpiarCajas_LinkClicked;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(662, 129);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 44);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(662, 73);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 44);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(662, 17);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 44);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbFamilia);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(lblStock);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(txtUnidad);
            groupBox1.Controls.Add(lblPrecio);
            groupBox1.Controls.Add(lblUnidad);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(lblFamilia);
            groupBox1.Controls.Add(lblMarca);
            groupBox1.Controls.Add(lblMensaje);
            groupBox1.Controls.Add(lvsProductos);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(14, 12);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(642, 444);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbFamilia
            // 
            cmbFamilia.FormattingEnabled = true;
            cmbFamilia.Location = new Point(268, 93);
            cmbFamilia.Margin = new Padding(3, 2, 3, 2);
            cmbFamilia.Name = "cmbFamilia";
            cmbFamilia.Size = new Size(168, 23);
            cmbFamilia.TabIndex = 16;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(268, 170);
            txtStock.Margin = new Padding(3, 2, 3, 2);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(168, 23);
            txtStock.TabIndex = 15;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(199, 170);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(60, 25);
            lblStock.TabIndex = 14;
            lblStock.Text = "Stock:";
            lblStock.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(268, 142);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(168, 23);
            txtPrecio.TabIndex = 13;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(268, 118);
            txtUnidad.Margin = new Padding(3, 2, 3, 2);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(168, 23);
            txtUnidad.TabIndex = 12;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(190, 142);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(69, 25);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio:";
            lblPrecio.TextAlign = ContentAlignment.TopRight;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnidad.Location = new Point(180, 113);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(77, 25);
            lblUnidad.TabIndex = 10;
            lblUnidad.Text = "Unidad:";
            lblUnidad.TextAlign = ContentAlignment.TopRight;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(268, 68);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(168, 23);
            txtMarca.TabIndex = 8;
            // 
            // lblFamilia
            // 
            lblFamilia.AutoSize = true;
            lblFamilia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFamilia.Location = new Point(183, 88);
            lblFamilia.Name = "lblFamilia";
            lblFamilia.Size = new Size(75, 25);
            lblFamilia.TabIndex = 7;
            lblFamilia.Text = "Familia:";
            lblFamilia.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(190, 64);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(69, 25);
            lblMarca.TabIndex = 6;
            lblMarca.Text = "Marca:";
            // 
            // lblMensaje
            // 
            lblMensaje.BorderStyle = BorderStyle.FixedSingle;
            lblMensaje.Enabled = false;
            lblMensaje.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(16, 410);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(605, 33);
            lblMensaje.TabIndex = 5;
            lblMensaje.Text = "label1";
            // 
            // lvsProductos
            // 
            lvsProductos.Columns.AddRange(new ColumnHeader[] { Id, Nombre, Marca, Familia, Unidad, Precio, Stock });
            lvsProductos.FullRowSelect = true;
            lvsProductos.GridLines = true;
            lvsProductos.Location = new Point(16, 208);
            lvsProductos.Margin = new Padding(3, 2, 3, 2);
            lvsProductos.MultiSelect = false;
            lvsProductos.Name = "lvsProductos";
            lvsProductos.Size = new Size(605, 200);
            lvsProductos.TabIndex = 4;
            lvsProductos.UseCompatibleStateImageBehavior = false;
            lvsProductos.View = View.Details;
            lvsProductos.SelectedIndexChanged += lvsFamilias_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.TextAlign = HorizontalAlignment.Center;
            // 
            // Marca
            // 
            Marca.Text = "Marca";
            Marca.TextAlign = HorizontalAlignment.Center;
            // 
            // Familia
            // 
            Familia.Text = "Familia";
            Familia.TextAlign = HorizontalAlignment.Center;
            // 
            // Unidad
            // 
            Unidad.Text = "Unidad";
            Unidad.TextAlign = HorizontalAlignment.Center;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.TextAlign = HorizontalAlignment.Center;
            // 
            // Stock
            // 
            Stock.Text = "Stock";
            Stock.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(268, 44);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(268, 19);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(168, 23);
            txtId.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(172, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(227, 14);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 465);
            Controls.Add(lblLimpiarCajas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmProducto";
            Text = "Producto";
            Load += frmProducto_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel lblLimpiarCajas;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private GroupBox groupBox1;
        private TextBox txtStock;
        private Label lblStock;
        private TextBox txtPrecio;
        private TextBox txtUnidad;
        private Label lblPrecio;
        private Label lblUnidad;
        private TextBox txtMarca;
        private Label lblFamilia;
        private Label lblMarca;
        private Label lblMensaje;
        private ListView lvsProductos;
        private ColumnHeader Id;
        private ColumnHeader Nombre;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label lblNombre;
        private Label lblId;
        private ComboBox cmbFamilia;
        private ColumnHeader Marca;
        private ColumnHeader Familia;
        private ColumnHeader Unidad;
        private ColumnHeader Precio;
        private ColumnHeader Stock;
    }
}