using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado.Presentacion
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
                    case "frmEmpleado":
                        frmEmpleado unfrmEmpleado = new frmEmpleado();
                        unfrmEmpleado.MdiParent = this;
                        unfrmEmpleado.Show();
                        break;
                    case "frmFamilia":
                        frmFamilia unfrmFamilia = new frmFamilia();
                        unfrmFamilia.MdiParent = this;
                        unfrmFamilia.Show();
                        break;
                    case "frmProducto":
                        Productos unfrmProducto = new Productos();
                        unfrmProducto.MdiParent = this;
                        unfrmProducto.Show();
                        break;
                }
            }
        }

        #endregion

        private void mnuFamilia_Click(object sender, EventArgs e)
        {
            string NombreForm = "frmFamilia";
            Singleton(NombreForm);
        }
        private void mnuCliente_Click(object sender, EventArgs e)
        {
            Singleton("frmCliente");
        }

        private void mnuEmpleado_Click(object sender, EventArgs e)
        {
            Singleton("frmEmpleado");
        }

        private void mnuProducto_Click(object sender, EventArgs e)
        {
            Singleton("frmProducto");
        }
    }
}
