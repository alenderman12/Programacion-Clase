using Taller_Obligatorio.Presentacion;
using Taller_Obligatorio.Dominio;
using Supermercado.Presentacion;

namespace Taller_Obligatorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        #region "Patron Singleton"

        private void Singleton(string pNombreFrm)
        {
            bool encontrado = false;
            foreach (Form unFrm in this.MdiChildren)
            {
                if (unFrm.Name.Equals(pNombreFrm))
                {
                    encontrado = true;
                    unFrm.Activate();
                }
            }
            if (!encontrado)
            {
                switch (pNombreFrm)
                {
                    case "frmCliente":
                        frmCliente unfrmCliente = new frmCliente();
                        unfrmCliente.MdiParent = this;
                        unfrmCliente.Show();
                        break;
                    case "frmVehiculo":
                        frmVehiculo unfrmVehiculo = new frmVehiculo();
                        unfrmVehiculo.MdiParent = this;
                        unfrmVehiculo.Show();
                        break;
                    case "frmReparacion":
                        frmReparacion unfrmReparacion = new frmReparacion();
                        unfrmReparacion.MdiParent = this;
                        unfrmReparacion.Show();
                        break;
                }
            }
        }

        #endregion

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Controladora controladora = new Controladora();
            controladora.CargarDatos();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton("frmVehiculo");
        }

        private void reparacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton("frmReparacion");
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton("frmCliente");
        }
    }
}
