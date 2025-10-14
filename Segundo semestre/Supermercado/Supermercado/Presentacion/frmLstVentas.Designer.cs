namespace Supermercado.Dominio
{
    partial class frmLstVentas
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
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            dteFechaHasta = new DateTimePicker();
            label1 = new Label();
            dteFechaDesde = new DateTimePicker();
            lblId = new Label();
            btnListar = new Button();
            cmbEmpleado = new ComboBox();
            lblFamilia = new Label();
            cmbCliente = new ComboBox();
            label2 = new Label();
            lvsVenta = new ListView();
            Id = new ColumnHeader();
            Fecha = new ColumnHeader();
            Cliente = new ColumnHeader();
            Empleado = new ColumnHeader();
            Totall = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(381, 508);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 30;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dteFechaHasta);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dteFechaDesde);
            groupBox1.Controls.Add(lblId);
            groupBox1.Location = new Point(79, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 125);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // dteFechaHasta
            // 
            dteFechaHasta.Format = DateTimePickerFormat.Short;
            dteFechaHasta.Location = new Point(112, 67);
            dteFechaHasta.Name = "dteFechaHasta";
            dteFechaHasta.Size = new Size(146, 27);
            dteFechaHasta.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(77, 31);
            label1.TabIndex = 34;
            label1.Text = "Hasta:";
            // 
            // dteFechaDesde
            // 
            dteFechaDesde.Format = DateTimePickerFormat.Short;
            dteFechaDesde.Location = new Point(112, 34);
            dteFechaDesde.Name = "dteFechaDesde";
            dteFechaDesde.Size = new Size(146, 27);
            dteFechaDesde.TabIndex = 33;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(12, 30);
            lblId.Name = "lblId";
            lblId.Size = new Size(83, 31);
            lblId.TabIndex = 32;
            lblId.Text = "Desde:";
            // 
            // btnListar
            // 
            btnListar.Location = new Point(691, 68);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(123, 49);
            btnListar.TabIndex = 32;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(481, 58);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(191, 28);
            cmbEmpleado.TabIndex = 34;
            // 
            // lblFamilia
            // 
            lblFamilia.AutoSize = true;
            lblFamilia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFamilia.Location = new Point(357, 52);
            lblFamilia.Name = "lblFamilia";
            lblFamilia.Size = new Size(122, 31);
            lblFamilia.TabIndex = 33;
            lblFamilia.Text = "Empleado:";
            lblFamilia.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(481, 90);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(191, 28);
            cmbCliente.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(357, 86);
            label2.Name = "label2";
            label2.Size = new Size(90, 31);
            label2.TabIndex = 35;
            label2.Text = "Cliente:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // lvsVenta
            // 
            lvsVenta.Columns.AddRange(new ColumnHeader[] { Id, Fecha, Cliente, Empleado, Totall });
            lvsVenta.FullRowSelect = true;
            lvsVenta.GridLines = true;
            lvsVenta.Location = new Point(79, 187);
            lvsVenta.MultiSelect = false;
            lvsVenta.Name = "lvsVenta";
            lvsVenta.Size = new Size(688, 315);
            lvsVenta.TabIndex = 38;
            lvsVenta.UseCompatibleStateImageBehavior = false;
            lvsVenta.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Fecha
            // 
            Fecha.Text = "Fecha";
            Fecha.TextAlign = HorizontalAlignment.Center;
            // 
            // Cliente
            // 
            Cliente.Text = "Cliente";
            Cliente.TextAlign = HorizontalAlignment.Center;
            // 
            // Empleado
            // 
            Empleado.Text = "Empleado";
            Empleado.TextAlign = HorizontalAlignment.Center;
            // 
            // Totall
            // 
            Totall.Text = "Total";
            // 
            // frmLstVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 549);
            Controls.Add(lvsVenta);
            Controls.Add(cmbCliente);
            Controls.Add(label2);
            Controls.Add(cmbEmpleado);
            Controls.Add(lblFamilia);
            Controls.Add(btnListar);
            Controls.Add(groupBox1);
            Controls.Add(btnCerrar);
            Name = "frmLstVentas";
            Text = "frmLstVentas";
            Load += frmLstVentas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCerrar;
        private GroupBox groupBox1;
        private Label lblId;
        private DateTimePicker dteFechaHasta;
        private Label label1;
        private DateTimePicker dteFechaDesde;
        private Button btnListar;
        private ComboBox cmbEmpleado;
        private Label lblFamilia;
        private ComboBox cmbCliente;
        private Label label2;
        private ColumnHeader Total;
        private ListView lvsVentas;
        private ListView lvsVenta;
        private ColumnHeader Id;
        private ColumnHeader Fecha;
        private ColumnHeader Cliente;
        private ColumnHeader Empleado;
        private ColumnHeader Totall;
    }
}