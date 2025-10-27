namespace Taller_Obligatorio
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            vehiculoToolStripMenuItem = new ToolStripMenuItem();
            reparacionesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { clienteToolStripMenuItem, vehiculoToolStripMenuItem, reparacionesToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(126, 490);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(113, 19);
            clienteToolStripMenuItem.Text = "Clientes";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // vehiculoToolStripMenuItem
            // 
            vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            vehiculoToolStripMenuItem.Size = new Size(113, 19);
            vehiculoToolStripMenuItem.Text = "Vehiculos";
            vehiculoToolStripMenuItem.Click += vehiculoToolStripMenuItem_Click;
            // 
            // reparacionesToolStripMenuItem
            // 
            reparacionesToolStripMenuItem.Name = "reparacionesToolStripMenuItem";
            reparacionesToolStripMenuItem.Size = new Size(113, 19);
            reparacionesToolStripMenuItem.Text = "Reparaciones";
            reparacionesToolStripMenuItem.Click += reparacionesToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 490);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "Taller";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem vehiculoToolStripMenuItem;
        private ToolStripMenuItem reparacionesToolStripMenuItem;
    }
}
