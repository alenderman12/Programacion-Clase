namespace Supermercado.Presentacion
{
    partial class frmCliente
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
            ListViewItem listViewItem1 = new ListViewItem("");
            lblLimpiarCajas = new LinkLabel();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            groupBox1 = new GroupBox();
            txtTelefono = new TextBox();
            txtPuntos = new TextBox();
            txtDescuento = new TextBox();
            lblPuntos = new Label();
            lblDescuento = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblMensaje = new Label();
            lvsClientes = new ListView();
            Id = new ColumnHeader();
            Nombre = new ColumnHeader();
            Direccion = new ColumnHeader();
            Telefono = new ColumnHeader();
            Descuento = new ColumnHeader();
            Puntos = new ColumnHeader();
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
            lblLimpiarCajas.Location = new Point(674, 184);
            lblLimpiarCajas.Name = "lblLimpiarCajas";
            lblLimpiarCajas.Size = new Size(78, 15);
            lblLimpiarCajas.TabIndex = 19;
            lblLimpiarCajas.TabStop = true;
            lblLimpiarCajas.Text = "Limpiar Cajas";
            lblLimpiarCajas.LinkClicked += lblLimpiarCajas_LinkClicked;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(655, 126);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 44);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(655, 70);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 44);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(655, 14);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 44);
            btnAgregar.TabIndex = 16;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtPuntos);
            groupBox1.Controls.Add(txtDescuento);
            groupBox1.Controls.Add(lblPuntos);
            groupBox1.Controls.Add(lblDescuento);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(lblTelefono);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(lblMensaje);
            groupBox1.Controls.Add(lvsClientes);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(7, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(642, 416);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(268, 92);
            txtTelefono.Margin = new Padding(3, 2, 3, 2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(168, 23);
            txtTelefono.TabIndex = 15;
            // 
            // txtPuntos
            // 
            txtPuntos.Location = new Point(268, 142);
            txtPuntos.Margin = new Padding(3, 2, 3, 2);
            txtPuntos.Name = "txtPuntos";
            txtPuntos.Size = new Size(168, 23);
            txtPuntos.TabIndex = 13;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(268, 118);
            txtDescuento.Margin = new Padding(3, 2, 3, 2);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(168, 23);
            txtDescuento.TabIndex = 12;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntos.Location = new Point(183, 136);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(74, 25);
            lblPuntos.TabIndex = 11;
            lblPuntos.Text = "Puntos:";
            lblPuntos.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescuento.Location = new Point(152, 111);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(105, 25);
            lblDescuento.TabIndex = 10;
            lblDescuento.Text = "Descuento:";
            lblDescuento.TextAlign = ContentAlignment.TopRight;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(268, 68);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(168, 23);
            txtDireccion.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(169, 86);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(88, 25);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Telefono:";
            lblTelefono.TextAlign = ContentAlignment.TopRight;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(161, 62);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(96, 25);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Direccion:";
            lblDireccion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMensaje
            // 
            lblMensaje.BorderStyle = BorderStyle.FixedSingle;
            lblMensaje.Enabled = false;
            lblMensaje.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(16, 377);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(605, 33);
            lblMensaje.TabIndex = 5;
            lblMensaje.Text = "label1";
            // 
            // lvsClientes
            // 
            lvsClientes.Columns.AddRange(new ColumnHeader[] { Id, Nombre, Direccion, Telefono, Descuento, Puntos });
            lvsClientes.FullRowSelect = true;
            lvsClientes.GridLines = true;
            lvsClientes.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvsClientes.Location = new Point(16, 175);
            lvsClientes.Margin = new Padding(3, 2, 3, 2);
            lvsClientes.MultiSelect = false;
            lvsClientes.Name = "lvsClientes";
            lvsClientes.Size = new Size(605, 200);
            lvsClientes.TabIndex = 4;
            lvsClientes.UseCompatibleStateImageBehavior = false;
            lvsClientes.View = View.Details;
            lvsClientes.SelectedIndexChanged += lvsClientes_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 40;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.TextAlign = HorizontalAlignment.Center;
            Nombre.Width = 120;
            // 
            // Direccion
            // 
            Direccion.Text = "Direccion";
            Direccion.TextAlign = HorizontalAlignment.Center;
            Direccion.Width = 210;
            // 
            // Telefono
            // 
            Telefono.Text = "Telfono";
            Telefono.TextAlign = HorizontalAlignment.Center;
            Telefono.Width = 90;
            // 
            // Descuento
            // 
            Descuento.Text = "Descuento";
            Descuento.TextAlign = HorizontalAlignment.Center;
            // 
            // Puntos
            // 
            Puntos.Text = "Puntos";
            Puntos.TextAlign = HorizontalAlignment.Center;
            Puntos.Width = 80;
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
            lblNombre.Location = new Point(172, 37);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(223, 12);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 434);
            Controls.Add(lblLimpiarCajas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmCliente";
            Text = "Cliente";
            Load += frmCliente_Load;
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
        private TextBox txtTelefono;
        private TextBox txtPuntos;
        private TextBox txtDescuento;
        private Label lblPuntos;
        private Label lblDescuento;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblMensaje;
        private ListView lvsClientes;
        private ColumnHeader Id;
        private ColumnHeader Nombre;
        private ColumnHeader Direccion;
        private ColumnHeader Telefono;
        private ColumnHeader Descuento;
        private ColumnHeader Puntos;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label lblNombre;
        private Label lblId;
    }
}