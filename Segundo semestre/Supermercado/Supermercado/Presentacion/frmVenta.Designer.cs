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
            txrPrecio = new TextBox();
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
            lsvDetalle = new ListView();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(501, 159);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(117, 51);
            btnAgregar.TabIndex = 29;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txrPrecio
            // 
            txrPrecio.Location = new Point(412, 187);
            txrPrecio.Name = "txrPrecio";
            txrPrecio.Size = new Size(83, 23);
            txrPrecio.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(421, 159);
            label5.Name = "label5";
            label5.Size = new Size(65, 25);
            label5.TabIndex = 26;
            label5.Text = "Precio";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(321, 187);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(83, 23);
            txtCantidad.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(320, 159);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 24;
            label4.Text = "Cantidad";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(106, 187);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(207, 23);
            cmbProducto.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(162, 159);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 21;
            label2.Text = "Producto";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtTotal);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 456);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(606, 45);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // txtTotal
            // 
            txtTotal.Enabled = false;
            txtTotal.Location = new Point(465, 16);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(135, 23);
            txtTotal.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 16);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 8;
            label1.Text = "Total:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtLinea
            // 
            txtLinea.Enabled = false;
            txtLinea.Location = new Point(17, 187);
            txtLinea.Name = "txtLinea";
            txtLinea.Size = new Size(83, 23);
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(606, 129);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(371, 80);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(207, 23);
            cmbEmpleado.TabIndex = 7;
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(371, 21);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(207, 23);
            cmbCliente.TabIndex = 6;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmpleado.Location = new Point(265, 78);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(100, 25);
            lblEmpleado.TabIndex = 5;
            lblEmpleado.Text = "Empleado:";
            lblEmpleado.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(290, 19);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(75, 25);
            lblCliente.TabIndex = 4;
            lblCliente.Text = "Cliente:";
            lblCliente.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dteFecha
            // 
            dteFecha.Format = DateTimePickerFormat.Short;
            dteFecha.Location = new Point(112, 80);
            dteFecha.Name = "dteFecha";
            dteFecha.Size = new Size(135, 23);
            dteFecha.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(112, 21);
            txtId.Name = "txtId";
            txtId.Size = new Size(135, 23);
            txtId.TabIndex = 2;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(41, 78);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(65, 25);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha:";
            lblFecha.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(74, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 25);
            lblId.TabIndex = 0;
            lblId.Text = "Id:";
            lblId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 159);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 19;
            label3.Text = "Linea";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lsvDetalle
            // 
            lsvDetalle.Location = new Point(12, 216);
            lsvDetalle.Name = "lsvDetalle";
            lsvDetalle.Size = new Size(606, 234);
            lsvDetalle.TabIndex = 30;
            lsvDetalle.UseCompatibleStateImageBehavior = false;
            lsvDetalle.SelectedIndexChanged += lsvDetalle_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(634, 18);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(154, 51);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(634, 75);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(154, 51);
            btnModificar.TabIndex = 32;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(634, 132);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(154, 51);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 513);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(lsvDetalle);
            Controls.Add(btnAgregar);
            Controls.Add(txrPrecio);
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
        private TextBox txrPrecio;
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
        private ListView lsvDetalle;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnEliminar;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
    }
}