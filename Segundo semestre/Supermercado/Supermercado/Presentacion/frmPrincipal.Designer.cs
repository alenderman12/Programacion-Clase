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
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuFamilia, mnuCliente, mnuEmpleado, mnuProducto, salirToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(157, 600);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuFamilia
            // 
            mnuFamilia.Name = "mnuFamilia";
            mnuFamilia.Size = new Size(142, 24);
            mnuFamilia.Text = "Familias";
            mnuFamilia.Click += mnuFamilia_Click;
            // 
            // mnuCliente
            // 
            mnuCliente.Name = "mnuCliente";
            mnuCliente.Size = new Size(142, 24);
            mnuCliente.Text = "Clientes";
            mnuCliente.Click += mnuCliente_Click;
            // 
            // mnuEmpleado
            // 
            mnuEmpleado.Name = "mnuEmpleado";
            mnuEmpleado.Size = new Size(142, 24);
            mnuEmpleado.Text = "Empleados";
            mnuEmpleado.Click += mnuEmpleado_Click;
            // 
            // mnuProducto
            // 
            mnuProducto.Name = "mnuProducto";
            mnuProducto.Size = new Size(142, 24);
            mnuProducto.Text = "Productos";
            mnuProducto.Click += mnuProducto_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(142, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "Supermercado";
            WindowState = FormWindowState.Maximized;
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
    }
}