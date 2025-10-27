namespace Taller_Obligatorio.Presentacion
{
    partial class frmVehiculo
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
            cmbCliente = new ComboBox();
            lblDueno = new Label();
            txtMarca = new TextBox();
            lblMarca = new Label();
            txtModelo = new TextBox();
            lblModelo = new Label();
            lblMensaje = new Label();
            lvsVehiculos = new ListView();
            Id = new ColumnHeader();
            Matricula = new ColumnHeader();
            Modelo = new ColumnHeader();
            Marca = new ColumnHeader();
            Dueno = new ColumnHeader();
            txtMatricula = new TextBox();
            txtId = new TextBox();
            lblMatricula = new Label();
            lblId = new Label();
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
            groupBox1.Controls.Add(cmbCliente);
            groupBox1.Controls.Add(lblDueno);
            groupBox1.Controls.Add(txtMarca);
            groupBox1.Controls.Add(lblMarca);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(lblModelo);
            groupBox1.Controls.Add(lblMensaje);
            groupBox1.Controls.Add(lvsVehiculos);
            groupBox1.Controls.Add(txtMatricula);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblMatricula);
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
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(268, 126);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(168, 23);
            cmbCliente.TabIndex = 19;
            // 
            // lblDueno
            // 
            lblDueno.AutoSize = true;
            lblDueno.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDueno.Location = new Point(185, 117);
            lblDueno.Name = "lblDueno";
            lblDueno.Size = new Size(72, 25);
            lblDueno.TabIndex = 18;
            lblDueno.Text = "Dueño:";
            lblDueno.TextAlign = ContentAlignment.TopRight;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(268, 98);
            txtMarca.Margin = new Padding(3, 2, 3, 2);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(168, 23);
            txtMarca.TabIndex = 17;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(188, 90);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(69, 25);
            lblMarca.TabIndex = 16;
            lblMarca.Text = "Marca:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(268, 71);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(168, 23);
            txtModelo.TabIndex = 15;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblModelo.Location = new Point(176, 65);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(81, 25);
            lblModelo.TabIndex = 7;
            lblModelo.Text = "Modelo:";
            lblModelo.TextAlign = ContentAlignment.TopRight;
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
            // lvsVehiculos
            // 
            lvsVehiculos.Columns.AddRange(new ColumnHeader[] { Id, Matricula, Modelo, Marca, Dueno });
            lvsVehiculos.FullRowSelect = true;
            lvsVehiculos.GridLines = true;
            lvsVehiculos.Items.AddRange(new ListViewItem[] { listViewItem1 });
            lvsVehiculos.Location = new Point(16, 154);
            lvsVehiculos.Margin = new Padding(3, 2, 3, 2);
            lvsVehiculos.MultiSelect = false;
            lvsVehiculos.Name = "lvsVehiculos";
            lvsVehiculos.Size = new Size(605, 221);
            lvsVehiculos.TabIndex = 4;
            lvsVehiculos.UseCompatibleStateImageBehavior = false;
            lvsVehiculos.View = View.Details;
            lvsVehiculos.SelectedIndexChanged += lvsVehiculos_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 40;
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
            // Dueno
            // 
            Dueno.Text = "Dueño";
            Dueno.TextAlign = HorizontalAlignment.Center;
            Dueno.Width = 200;
            // 
            // txtMatricula
            // 
            txtMatricula.Location = new Point(268, 44);
            txtMatricula.Margin = new Padding(3, 2, 3, 2);
            txtMatricula.Name = "txtMatricula";
            txtMatricula.Size = new Size(168, 23);
            txtMatricula.TabIndex = 3;
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
            // lblMatricula
            // 
            lblMatricula.AutoSize = true;
            lblMatricula.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMatricula.Location = new Point(161, 36);
            lblMatricula.Name = "lblMatricula";
            lblMatricula.Size = new Size(96, 25);
            lblMatricula.TabIndex = 1;
            lblMatricula.Text = "Matricula:";
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
            // frmVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLimpiarCajas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Name = "frmVehiculo";
            Text = "Vehiculo";
            Load += frmVehiculo_Load;
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
        private TextBox txtModelo;
        private Label lblModelo;
        private Label lblMensaje;
        private ListView lvsVehiculos;
        private ColumnHeader Id;
        private ColumnHeader Matricula;
        private ColumnHeader Modelo;
        private TextBox txtMatricula;
        private TextBox txtId;
        private Label lblMatricula;
        private Label lblId;
        private Label lblDueno;
        private TextBox txtMarca;
        private Label lblMarca;
        private ComboBox cmbCliente;
        private ColumnHeader Marca;
        private ColumnHeader Dueno;
    }
}