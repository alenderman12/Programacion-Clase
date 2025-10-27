namespace Taller_Obligatorio.Presentacion
{
    partial class frmReparacion
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
            cmbVehiculo = new ComboBox();
            cmbCliente = new ComboBox();
            dteFecha = new DateTimePicker();
            txtCosto = new TextBox();
            label1 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lblTelefono = new Label();
            lblMensaje = new Label();
            lvsReparaciones = new ListView();
            Id = new ColumnHeader();
            Fecha = new ColumnHeader();
            Vehiculo = new ColumnHeader();
            txtId = new TextBox();
            lblNombre = new Label();
            lblId = new Label();
            Dueno = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Costo = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblLimpiarCajas
            // 
            lblLimpiarCajas.AutoSize = true;
            lblLimpiarCajas.Location = new Point(678, 192);
            lblLimpiarCajas.Name = "lblLimpiarCajas";
            lblLimpiarCajas.Size = new Size(78, 15);
            lblLimpiarCajas.TabIndex = 24;
            lblLimpiarCajas.TabStop = true;
            lblLimpiarCajas.Text = "Limpiar Cajas";
            lblLimpiarCajas.LinkClicked += lblLimpiarCajas_LinkClicked;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(659, 134);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 44);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(659, 78);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 44);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(659, 22);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 44);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbVehiculo);
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(dteFecha);
            groupBox1.Controls.Add(txtCosto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblTelefono);
            groupBox1.Controls.Add(lblMensaje);
            groupBox1.Controls.Add(lvsReparaciones);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(11, 17);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(642, 416);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Location = new Point(268, 71);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(168, 23);
            cmbVehiculo.TabIndex = 24;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(268, 97);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(168, 23);
            cmbCliente.TabIndex = 23;
            // 
            // dteFecha
            // 
            dteFecha.Format = DateTimePickerFormat.Short;
            dteFecha.Location = new Point(268, 45);
            dteFecha.Name = "dteFecha";
            dteFecha.Size = new Size(168, 23);
            dteFecha.TabIndex = 22;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(268, 150);
            txtCosto.Margin = new Padding(3, 2, 3, 2);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(168, 23);
            txtCosto.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 145);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 20;
            label1.Text = "Costo:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(268, 123);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(168, 23);
            txtDescripcion.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(142, 117);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 17;
            label2.Text = "Descripcion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(185, 90);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 16;
            label3.Text = "Dueno:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(168, 65);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(89, 25);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Vehiculo:";
            lblTelefono.TextAlign = ContentAlignment.TopRight;
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
            // lvsReparaciones
            // 
            lvsReparaciones.Columns.AddRange(new ColumnHeader[] { Id, Fecha, Vehiculo, Dueno, Descripcion, Costo });
            lvsReparaciones.FullRowSelect = true;
            lvsReparaciones.GridLines = true;
            lvsReparaciones.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvsReparaciones.Location = new Point(16, 177);
            lvsReparaciones.Margin = new Padding(3, 2, 3, 2);
            lvsReparaciones.MultiSelect = false;
            lvsReparaciones.Name = "lvsReparaciones";
            lvsReparaciones.Size = new Size(605, 198);
            lvsReparaciones.TabIndex = 4;
            lvsReparaciones.UseCompatibleStateImageBehavior = false;
            lvsReparaciones.View = View.Details;
            lvsReparaciones.SelectedIndexChanged += lvsReparaciones_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 80;
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.TextAlign = HorizontalAlignment.Center;
            Fecha.Width = 200;
            // 
            // Vehiculo
            // 
            Vehiculo.Text = "Vehiculo";
            Vehiculo.TextAlign = HorizontalAlignment.Center;
            Vehiculo.Width = 140;
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
            lblNombre.Location = new Point(192, 39);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Fecha:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(223, 11);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // Dueno
            // 
            Dueno.Text = "Dueño";
            Dueno.TextAlign = HorizontalAlignment.Center;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion";
            Descripcion.TextAlign = HorizontalAlignment.Center;
            // 
            // Costo
            // 
            Costo.Text = "Costo";
            Costo.TextAlign = HorizontalAlignment.Center;
            // 
            // frmReparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLimpiarCajas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Name = "frmReparacion";
            Text = "frmReparacion";
            Load += frmReparacion_Load;
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
        private Label lblTelefono;
        private Label lblMensaje;
        private ListView lvsReparaciones;
        private ColumnHeader Id;
        private ColumnHeader Fecha;
        private ColumnHeader Vehiculo;
        private TextBox txtId;
        private Label lblNombre;
        private Label lblId;
        private TextBox txtCosto;
        private Label label1;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label3;
        private DateTimePicker dteFecha;
        private ComboBox cmbVehiculo;
        private ComboBox cmbCliente;
        private ColumnHeader Dueno;
        private ColumnHeader Descripcion;
        private ColumnHeader Costo;
    }
}