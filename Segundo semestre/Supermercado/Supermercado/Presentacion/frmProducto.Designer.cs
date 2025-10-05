namespace Supermercado.Presentacion
{
    partial class Productos
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
            lblLimpiarCajas.Location = new Point(778, 249);
            lblLimpiarCajas.Name = "lblLimpiarCajas";
            lblLimpiarCajas.Size = new Size(98, 20);
            lblLimpiarCajas.TabIndex = 9;
            lblLimpiarCajas.TabStop = true;
            lblLimpiarCajas.Text = "Limpiar Cajas";
            lblLimpiarCajas.LinkClicked += lblLimpiarCajas_LinkClicked;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(756, 172);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 59);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(756, 97);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(150, 59);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(756, 23);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 59);
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
            groupBox1.Location = new Point(16, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(734, 592);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cmbFamilia
            // 
            cmbFamilia.FormattingEnabled = true;
            cmbFamilia.Location = new Point(306, 124);
            cmbFamilia.Name = "cmbFamilia";
            cmbFamilia.Size = new Size(191, 28);
            cmbFamilia.TabIndex = 16;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(306, 226);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(191, 27);
            txtStock.TabIndex = 15;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(227, 226);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(73, 31);
            lblStock.TabIndex = 14;
            lblStock.Text = "Stock:";
            lblStock.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(306, 190);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(191, 27);
            txtPrecio.TabIndex = 13;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(306, 157);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(191, 27);
            txtUnidad.TabIndex = 12;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(217, 189);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(82, 31);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio:";
            lblPrecio.TextAlign = ContentAlignment.TopRight;
            // 
            // lblUnidad
            // 
            lblUnidad.AutoSize = true;
            lblUnidad.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUnidad.Location = new Point(206, 151);
            lblUnidad.Name = "lblUnidad";
            lblUnidad.Size = new Size(94, 31);
            lblUnidad.TabIndex = 10;
            lblUnidad.Text = "Unidad:";
            lblUnidad.TextAlign = ContentAlignment.TopRight;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(306, 91);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(191, 27);
            txtMarca.TabIndex = 8;
            // 
            // lblFamilia
            // 
            lblFamilia.AutoSize = true;
            lblFamilia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFamilia.Location = new Point(209, 118);
            lblFamilia.Name = "lblFamilia";
            lblFamilia.Size = new Size(91, 31);
            lblFamilia.TabIndex = 7;
            lblFamilia.Text = "Familia:";
            lblFamilia.TextAlign = ContentAlignment.TopRight;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(217, 85);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(83, 31);
            lblMarca.TabIndex = 6;
            lblMarca.Text = "Marca:";
            // 
            // lblMensaje
            // 
            lblMensaje.BorderStyle = BorderStyle.FixedSingle;
            lblMensaje.Enabled = false;
            lblMensaje.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(18, 546);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(691, 43);
            lblMensaje.TabIndex = 5;
            lblMensaje.Text = "label1";
            // 
            // lvsProductos
            // 
            lvsProductos.Columns.AddRange(new ColumnHeader[] { Id, Nombre, Marca, Familia, Unidad, Precio, Stock });
            lvsProductos.FullRowSelect = true;
            lvsProductos.GridLines = true;
            lvsProductos.Location = new Point(18, 277);
            lvsProductos.MultiSelect = false;
            lvsProductos.Name = "lvsProductos";
            lvsProductos.Size = new Size(691, 266);
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
            txtNombre.Location = new Point(306, 58);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(191, 27);
            txtNombre.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Location = new Point(306, 25);
            txtId.Name = "txtId";
            txtId.Size = new Size(191, 27);
            txtId.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(197, 52);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(103, 31);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(259, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(41, 31);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 620);
            Controls.Add(lblLimpiarCajas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Name = "Productos";
            Text = "frmProducto";
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