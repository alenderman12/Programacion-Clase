namespace Supermercado.Presentacion
{
    partial class frmEmpleado
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
            txtCargo = new TextBox();
            txtSueldo = new TextBox();
            lblCargo = new Label();
            lblSueldo = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblMensaje = new Label();
            lvsEmpleados = new ListView();
            Id = new ColumnHeader();
            Nombre = new ColumnHeader();
            Direccion = new ColumnHeader();
            Telefono = new ColumnHeader();
            Sueldo = new ColumnHeader();
            Cargo = new ColumnHeader();
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
            lblLimpiarCajas.Location = new Point(678, 186);
            lblLimpiarCajas.Name = "lblLimpiarCajas";
            lblLimpiarCajas.Size = new Size(78, 15);
            lblLimpiarCajas.TabIndex = 14;
            lblLimpiarCajas.TabStop = true;
            lblLimpiarCajas.Text = "Limpiar Cajas";
            lblLimpiarCajas.LinkClicked += lblLimpiarCajas_LinkClicked;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(659, 128);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 44);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(659, 72);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 44);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(659, 16);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 44);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtCargo);
            groupBox1.Controls.Add(txtSueldo);
            groupBox1.Controls.Add(lblCargo);
            groupBox1.Controls.Add(lblSueldo);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Controls.Add(lblTelefono);
            groupBox1.Controls.Add(lblDireccion);
            groupBox1.Controls.Add(lblMensaje);
            groupBox1.Controls.Add(lvsEmpleados);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(642, 416);
            groupBox1.TabIndex = 10;
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
            // txtCargo
            // 
            txtCargo.Location = new Point(268, 142);
            txtCargo.Margin = new Padding(3, 2, 3, 2);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(168, 23);
            txtCargo.TabIndex = 13;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(268, 118);
            txtSueldo.Margin = new Padding(3, 2, 3, 2);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(168, 23);
            txtSueldo.TabIndex = 12;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCargo.Location = new Point(190, 138);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(67, 25);
            lblCargo.TabIndex = 11;
            lblCargo.Text = "Cargo:";
            lblCargo.TextAlign = ContentAlignment.TopRight;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSueldo.Location = new Point(183, 113);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(74, 25);
            lblSueldo.TabIndex = 10;
            lblSueldo.Text = "Sueldo:";
            lblSueldo.TextAlign = ContentAlignment.TopRight;
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
            lblTelefono.Location = new Point(169, 87);
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
            lblDireccion.Location = new Point(161, 63);
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
            // lvsEmpleados
            // 
            lvsEmpleados.Columns.AddRange(new ColumnHeader[] { Id, Nombre, Direccion, Telefono, Sueldo, Cargo });
            lvsEmpleados.FullRowSelect = true;
            lvsEmpleados.GridLines = true;
            lvsEmpleados.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvsEmpleados.Location = new Point(16, 175);
            lvsEmpleados.Margin = new Padding(3, 2, 3, 2);
            lvsEmpleados.MultiSelect = false;
            lvsEmpleados.Name = "lvsEmpleados";
            lvsEmpleados.Size = new Size(605, 200);
            lvsEmpleados.TabIndex = 4;
            lvsEmpleados.UseCompatibleStateImageBehavior = false;
            lvsEmpleados.View = View.Details;
            lvsEmpleados.SelectedIndexChanged += lvsProductos_SelectedIndexChanged;
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
            // Sueldo
            // 
            Sueldo.Text = "Sueldo";
            Sueldo.TextAlign = HorizontalAlignment.Center;
            // 
            // Cargo
            // 
            Cargo.Text = "Cargo";
            Cargo.TextAlign = HorizontalAlignment.Center;
            Cargo.Width = 80;
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
            lblNombre.Location = new Point(172, 38);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(223, 13);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 435);
            Controls.Add(lblLimpiarCajas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmEmpleado";
            Text = "Empleado";
            Load += frmEmpleado_Load;
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
        private TextBox txtCargo;
        private TextBox txtSueldo;
        private Label lblCargo;
        private Label lblSueldo;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblMensaje;
        private ListView lvsEmpleados;
        private ColumnHeader Id;
        private ColumnHeader Nombre;
        private ColumnHeader Direccion;
        private ColumnHeader Telefono;
        private ColumnHeader Sueldo;
        private ColumnHeader Cargo;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label lblNombre;
        private Label lblId;
    }
}