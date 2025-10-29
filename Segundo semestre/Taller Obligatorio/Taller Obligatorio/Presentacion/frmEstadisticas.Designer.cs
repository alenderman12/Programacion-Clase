namespace Taller_Obligatorio.Presentacion
{
    partial class frmEstadisticas
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
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            cmbCliente = new ComboBox();
            label2 = new Label();
            cmbVehiculo = new ComboBox();
            lblFamilia = new Label();
            btnListar = new Button();
            btnCerrar = new Button();
            lvsClientes = new ListView();
            Id = new ColumnHeader();
            Nombre = new ColumnHeader();
            Telefono = new ColumnHeader();
            Autos = new ColumnHeader();
            rdoCliente = new RadioButton();
            rdoVehiculo = new RadioButton();
            rdoDueno = new RadioButton();
            lvsReparaciones = new ListView();
            columnHeader1 = new ColumnHeader();
            Fecha = new ColumnHeader();
            Vehiculo = new ColumnHeader();
            Dueno = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Costo = new ColumnHeader();
            lvsVehiculos = new ListView();
            columnHeader2 = new ColumnHeader();
            Matricula = new ColumnHeader();
            Modelo = new ColumnHeader();
            Marca = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(451, 43);
            cmbCliente.Margin = new Padding(3, 2, 3, 2);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(168, 23);
            cmbCliente.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(370, 41);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 44;
            label2.Text = "Cliente:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbVehiculo
            // 
            cmbVehiculo.FormattingEnabled = true;
            cmbVehiculo.Location = new Point(176, 43);
            cmbVehiculo.Margin = new Padding(3, 2, 3, 2);
            cmbVehiculo.Name = "cmbVehiculo";
            cmbVehiculo.Size = new Size(168, 23);
            cmbVehiculo.TabIndex = 43;
            // 
            // lblFamilia
            // 
            lblFamilia.AutoSize = true;
            lblFamilia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFamilia.Location = new Point(81, 41);
            lblFamilia.Name = "lblFamilia";
            lblFamilia.Size = new Size(89, 25);
            lblFamilia.TabIndex = 42;
            lblFamilia.Text = "Vehiculo:";
            lblFamilia.TextAlign = ContentAlignment.TopRight;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(680, 66);
            btnListar.Margin = new Padding(3, 2, 3, 2);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(108, 37);
            btnListar.TabIndex = 41;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(343, 417);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(82, 22);
            btnCerrar.TabIndex = 39;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lvsClientes
            // 
            lvsClientes.Columns.AddRange(new ColumnHeader[] { Id, Nombre, Telefono, Autos });
            lvsClientes.FullRowSelect = true;
            lvsClientes.GridLines = true;
            lvsClientes.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvsClientes.Location = new Point(81, 148);
            lvsClientes.Margin = new Padding(3, 2, 3, 2);
            lvsClientes.MultiSelect = false;
            lvsClientes.Name = "lvsClientes";
            lvsClientes.Size = new Size(605, 265);
            lvsClientes.TabIndex = 46;
            lvsClientes.UseCompatibleStateImageBehavior = false;
            lvsClientes.View = View.Details;
            lvsClientes.Visible = false;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 100;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.TextAlign = HorizontalAlignment.Center;
            Nombre.Width = 200;
            // 
            // Telefono
            // 
            Telefono.Text = "Telefono";
            Telefono.TextAlign = HorizontalAlignment.Center;
            Telefono.Width = 140;
            // 
            // Autos
            // 
            Autos.Text = "Vehiculos";
            Autos.TextAlign = HorizontalAlignment.Center;
            Autos.Width = 100;
            // 
            // rdoCliente
            // 
            rdoCliente.AutoSize = true;
            rdoCliente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoCliente.Location = new Point(272, 101);
            rdoCliente.Name = "rdoCliente";
            rdoCliente.Size = new Size(247, 29);
            rdoCliente.TabIndex = 47;
            rdoCliente.TabStop = true;
            rdoCliente.Text = "Listar Clientes y Vehiculos";
            rdoCliente.UseVisualStyleBackColor = true;
            // 
            // rdoVehiculo
            // 
            rdoVehiculo.AutoSize = true;
            rdoVehiculo.Location = new Point(70, 49);
            rdoVehiculo.Name = "rdoVehiculo";
            rdoVehiculo.Size = new Size(14, 13);
            rdoVehiculo.TabIndex = 48;
            rdoVehiculo.TabStop = true;
            rdoVehiculo.UseVisualStyleBackColor = true;
            // 
            // rdoDueno
            // 
            rdoDueno.AutoSize = true;
            rdoDueno.Location = new Point(359, 49);
            rdoDueno.Name = "rdoDueno";
            rdoDueno.Size = new Size(14, 13);
            rdoDueno.TabIndex = 49;
            rdoDueno.TabStop = true;
            rdoDueno.UseVisualStyleBackColor = true;
            // 
            // lvsReparaciones
            // 
            lvsReparaciones.Columns.AddRange(new ColumnHeader[] { columnHeader1, Fecha, Vehiculo, Dueno, Descripcion, Costo });
            lvsReparaciones.FullRowSelect = true;
            lvsReparaciones.GridLines = true;
            lvsReparaciones.Items.AddRange(new ListViewItem[] { listViewItem2 });
            lvsReparaciones.Location = new Point(81, 148);
            lvsReparaciones.Margin = new Padding(3, 2, 3, 2);
            lvsReparaciones.MultiSelect = false;
            lvsReparaciones.Name = "lvsReparaciones";
            lvsReparaciones.Size = new Size(605, 265);
            lvsReparaciones.TabIndex = 50;
            lvsReparaciones.UseCompatibleStateImageBehavior = false;
            lvsReparaciones.View = View.Details;
            lvsReparaciones.Visible = false;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 80;
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
            // lvsVehiculos
            // 
            lvsVehiculos.Columns.AddRange(new ColumnHeader[] { columnHeader2, Matricula, Modelo, Marca, columnHeader3 });
            lvsVehiculos.FullRowSelect = true;
            lvsVehiculos.GridLines = true;
            lvsVehiculos.Items.AddRange(new ListViewItem[] { listViewItem3 });
            lvsVehiculos.Location = new Point(81, 148);
            lvsVehiculos.Margin = new Padding(3, 2, 3, 2);
            lvsVehiculos.MultiSelect = false;
            lvsVehiculos.Name = "lvsVehiculos";
            lvsVehiculos.Size = new Size(605, 265);
            lvsVehiculos.TabIndex = 51;
            lvsVehiculos.UseCompatibleStateImageBehavior = false;
            lvsVehiculos.View = View.Details;
            lvsVehiculos.Visible = false;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Id";
            columnHeader2.Width = 40;
            // 
            // Matricula
            // 
            Matricula.Text = "Matricula";
            Matricula.TextAlign = HorizontalAlignment.Center;
            Matricula.Width = 100;
            // 
            // Modelo
            // 
            Modelo.Text = "Modelo";
            Modelo.TextAlign = HorizontalAlignment.Center;
            Modelo.Width = 140;
            // 
            // Marca
            // 
            Marca.Text = "Marca";
            Marca.TextAlign = HorizontalAlignment.Center;
            Marca.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Dueño";
            columnHeader3.TextAlign = HorizontalAlignment.Center;
            columnHeader3.Width = 200;
            // 
            // frmEstadisticas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvsVehiculos);
            Controls.Add(lvsReparaciones);
            Controls.Add(rdoDueno);
            Controls.Add(rdoVehiculo);
            Controls.Add(rdoCliente);
            Controls.Add(lvsClientes);
            Controls.Add(cmbCliente);
            Controls.Add(label2);
            Controls.Add(cmbVehiculo);
            Controls.Add(lblFamilia);
            Controls.Add(btnListar);
            Controls.Add(btnCerrar);
            Name = "frmEstadisticas";
            Text = "frmLstVentas";
            Load += frmLstVentas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbCliente;
        private Label label2;
        private ComboBox cmbVehiculo;
        private Label lblFamilia;
        private Button btnListar;
        private Button btnCerrar;
        private ListView lvsClientes;
        private ColumnHeader Id;
        private ColumnHeader Nombre;
        private ColumnHeader Telefono;
        private ColumnHeader Autos;
        private RadioButton rdoCliente;
        private RadioButton rdoVehiculo;
        private RadioButton rdoDueno;
        private ListView lvsReparaciones;
        private ColumnHeader columnHeader1;
        private ColumnHeader Fecha;
        private ColumnHeader Vehiculo;
        private ColumnHeader Dueno;
        private ColumnHeader Descripcion;
        private ColumnHeader Costo;
        private ListView lvsVehiculos;
        private ColumnHeader columnHeader2;
        private ColumnHeader Matricula;
        private ColumnHeader Modelo;
        private ColumnHeader Marca;
        private ColumnHeader columnHeader3;
    }
}