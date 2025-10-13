namespace Supermercado.Presentacion
{
    partial class frmFamilia
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
            groupBox1 = new GroupBox();
            lblMensaje = new Label();
            lvsFamilias = new ListView();
            Id = new ColumnHeader();
            Nombre = new ColumnHeader();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lblNombre = new Label();
            lblId = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblLimpiarCajas = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMensaje);
            groupBox1.Controls.Add(lvsFamilias);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(301, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // lblMensaje
            // 
            lblMensaje.BorderStyle = BorderStyle.FixedSingle;
            lblMensaje.Enabled = false;
            lblMensaje.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(16, 287);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(271, 33);
            lblMensaje.TabIndex = 5;
            lblMensaje.Text = "label1";
            // 
            // lvsFamilias
            // 
            lvsFamilias.Columns.AddRange(new ColumnHeader[] { Id, Nombre });
            lvsFamilias.FullRowSelect = true;
            lvsFamilias.GridLines = true;
            lvsFamilias.Location = new Point(16, 86);
            lvsFamilias.Margin = new Padding(3, 2, 3, 2);
            lvsFamilias.MultiSelect = false;
            lvsFamilias.Name = "lvsFamilias";
            lvsFamilias.Size = new Size(271, 200);
            lvsFamilias.TabIndex = 4;
            lvsFamilias.UseCompatibleStateImageBehavior = false;
            lvsFamilias.View = View.Details;
            lvsFamilias.SelectedIndexChanged += lvsFamilias_SelectedIndexChanged;
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
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 46);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(168, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(111, 22);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(168, 23);
            txtId.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(16, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(85, 25);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(70, 17);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(331, 14);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 44);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.Location = new Point(331, 70);
            btnModificar.Margin = new Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 44);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(331, 126);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 44);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblLimpiarCajas
            // 
            lblLimpiarCajas.AutoSize = true;
            lblLimpiarCajas.Location = new Point(350, 184);
            lblLimpiarCajas.Name = "lblLimpiarCajas";
            lblLimpiarCajas.Size = new Size(78, 15);
            lblLimpiarCajas.TabIndex = 4;
            lblLimpiarCajas.TabStop = true;
            lblLimpiarCajas.Text = "Limpiar Cajas";
            lblLimpiarCajas.LinkClicked += lblLimpiarCajas_LinkClicked;
            // 
            // frmFamilia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 338);
            Controls.Add(lblLimpiarCajas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmFamilia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Familia";
            Load += frmFamilia_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblNombre;
        private Label lblId;
        private TextBox txtNombre;
        private TextBox txtId;
        private ListView lvsFamilias;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private ColumnHeader Id;
        private ColumnHeader Nombre;
        private Label lblMensaje;
        private LinkLabel lblLimpiarCajas;
    }
}