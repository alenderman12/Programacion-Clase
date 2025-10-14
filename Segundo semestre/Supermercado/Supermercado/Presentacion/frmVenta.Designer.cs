namespace Supermercado.Presentacion
{
    partial class Ventas
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
            btnAgregar = new Button();
            txtPrecio = new TextBox();
            label5 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            cmbProducto = new ComboBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            txtTotal = new TextBox();
            label1 = new Label();
            txtLinea = new TextBox();
            groupBox1 = new GroupBox();
            cmbEmpleado = new ComboBox();
            cmbCliente = new ComboBox();
            lblEmpleado = new Label();
            lblCliente = new Label();
            dteFecha = new DateTimePicker();
            txtId = new TextBox();
            lblFecha = new Label();
            lblId = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lvsLinea = new ListView();
            Linea = new ColumnHeader();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            Precio = new ColumnHeader();
            SubTotal = new ColumnHeader();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(573, 212);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 68);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(471, 249);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(94, 27);
            txtPrecio.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(481, 212);
            label5.Name = "label5";
            label5.Size = new Size(79, 32);
            label5.TabIndex = 26;
            label5.Text = "Precio";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(367, 249);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(94, 27);
            txtCantidad.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(366, 212);
            label4.Name = "label4";
            label4.Size = new Size(109, 32);
            label4.TabIndex = 24;
            label4.Text = "Cantidad";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(121, 249);
            cmbProducto.Margin = new Padding(3, 4, 3, 4);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(236, 28);
            cmbProducto.TabIndex = 23;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(185, 212);
            label2.Name = "label2";
            label2.Size = new Size(110, 32);
            label2.TabIndex = 21;
            label2.Text = "Producto";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(14, 608);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(693, 60);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(531, 21);
            txtTotal.Margin = new Padding(3, 4, 3, 4);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(154, 27);
            txtTotal.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(455, 21);
            label1.Name = "label1";
            label1.Size = new Size(70, 32);
            label1.TabIndex = 8;
            label1.Text = "Total:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLinea
            // 
            txtLinea.Location = new Point(19, 249);
            txtLinea.Margin = new Padding(3, 4, 3, 4);
            txtLinea.Name = "txtLinea";
            txtLinea.Size = new Size(94, 27);
            txtLinea.TabIndex = 20;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbEmpleado);
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(lblEmpleado);
            groupBox1.Controls.Add(lblCliente);
            groupBox1.Controls.Add(dteFecha);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblFecha);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(693, 172);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(424, 107);
            cmbEmpleado.Margin = new Padding(3, 4, 3, 4);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(236, 28);
            cmbEmpleado.TabIndex = 7;
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(424, 28);
            cmbCliente.Margin = new Padding(3, 4, 3, 4);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(236, 28);
            cmbCliente.TabIndex = 6;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpleado.Location = new Point(303, 104);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(125, 32);
            lblEmpleado.TabIndex = 5;
            lblEmpleado.Text = "Empleado:";
            lblEmpleado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(331, 25);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(94, 32);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente:";
            lblCliente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dteFecha
            // 
            dteFecha.Format = DateTimePickerFormat.Short;
            dteFecha.Location = new Point(128, 107);
            dteFecha.Margin = new Padding(3, 4, 3, 4);
            dteFecha.Name = "dteFecha";
            dteFecha.Size = new Size(154, 27);
            dteFecha.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(128, 28);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(154, 27);
            txtId.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(47, 104);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(81, 32);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            lblFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(85, 25);
            lblId.Name = "lblId";
            lblId.Size = new Size(39, 32);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            lblId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(34, 212);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 19;
            label3.Text = "Linea";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(713, 28);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(189, 45);
            btnGuardar.TabIndex = 30;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(713, 79);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(189, 45);
            btnModificar.TabIndex = 31;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(713, 130);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(189, 45);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lvsLinea
            // 
            lvsLinea.Columns.AddRange(new ColumnHeader[] { Linea, Producto, Cantidad, Precio, SubTotal });
            lvsLinea.FullRowSelect = true;
            lvsLinea.GridLines = true;
            lvsLinea.Location = new Point(19, 307);
            lvsLinea.MultiSelect = false;
            lvsLinea.Name = "lvsLinea";
            lvsLinea.Size = new Size(688, 315);
            lvsLinea.TabIndex = 33;
            lvsLinea.UseCompatibleStateImageBehavior = false;
            lvsLinea.View = View.Details;
            lvsLinea.SelectedIndexChanged += lvsLinea_SelectedIndexChanged;
            // 
            // Linea
            // 
            Linea.Text = "Linea";
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.TextAlign = HorizontalAlignment.Center;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            Precio.TextAlign = HorizontalAlignment.Center;
            // 
            // SubTotal
            // 
            SubTotal.Text = "Sub Total";
            SubTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 684);
            Controls.Add(lvsLinea);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(label5);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(cmbProducto);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(txtLinea);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmVenta";
            Load += Ventas_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private TextBox txtPrecio;
        private Label label5;
        private TextBox txtCantidad;
        private Label label4;
        private ComboBox cmbProducto;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtTotal;
        private Label label1;
        private TextBox txtLinea;
        private GroupBox groupBox1;
        private ComboBox cmbEmpleado;
        private ComboBox cmbCliente;
        private Label lblEmpleado;
        private Label lblCliente;
        private DateTimePicker dteFecha;
        private TextBox txtId;
        private Label lblFecha;
        private Label lblId;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private ListView lvsLinea;
        private ColumnHeader Linea;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader Precio;
        private ColumnHeader SubTotal;
    }
}