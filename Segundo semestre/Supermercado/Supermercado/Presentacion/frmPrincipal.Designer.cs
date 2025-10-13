namespace Supermercado.Presentacion
{
    partial class frmPrincipal
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
            menuStrip1 = new MenuStrip();
            mnuFamilia = new ToolStripMenuItem();
            mnuCliente = new ToolStripMenuItem();
            mnuEmpleado = new ToolStripMenuItem();
            mnuProducto = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            mnuVenta = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFamilia, mnuCliente, mnuEmpleado, mnuProducto, salirToolStripMenuItem, mnuVenta });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(126, 450);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFamilia
            // 
            mnuFamilia.Name = "mnuFamilia";
            mnuFamilia.Size = new Size(113, 19);
            mnuFamilia.Text = "Familias";
            mnuFamilia.Click += mnuFamilia_Click;
            // 
            // mnuCliente
            // 
            mnuCliente.Name = "mnuCliente";
            mnuCliente.Size = new Size(113, 19);
            mnuCliente.Text = "Clientes";
            mnuCliente.Click += mnuCliente_Click;
            // 
            // mnuEmpleado
            // 
            mnuEmpleado.Name = "mnuEmpleado";
            mnuEmpleado.Size = new Size(113, 19);
            mnuEmpleado.Text = "Empleados";
            mnuEmpleado.Click += mnuEmpleado_Click;
            // 
            // mnuProducto
            // 
            mnuProducto.Name = "mnuProducto";
            mnuProducto.Size = new Size(113, 19);
            mnuProducto.Text = "Productos";
            mnuProducto.Click += mnuProducto_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(113, 19);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // mnuVenta
            // 
            mnuVenta.Name = "mnuVenta";
            mnuVenta.Size = new Size(113, 19);
            mnuVenta.Text = "Ventas";
            mnuVenta.Click += mnuVenta_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Supermercado";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFamilia;
        private ToolStripMenuItem mnuCliente;
        private ToolStripMenuItem mnuEmpleado;
        private ToolStripMenuItem mnuProducto;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem mnuVenta;
    }
}