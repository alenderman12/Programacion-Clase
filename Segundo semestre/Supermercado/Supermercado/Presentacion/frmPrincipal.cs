using Supermercado.Dominio;
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
        Controladora controladora = new Controladora();
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
                        frmProducto unfrmProducto = new frmProducto();
                        unfrmProducto.MdiParent = this;
                        unfrmProducto.Show();
                        break;
                    case "frmVenta":
                        Ventas unFrmVenta = new Ventas();
                        unFrmVenta.MdiParent = this;
                        unFrmVenta.Show();
                        break;
                    case "frmLstVenta":
                        frmLstVentas1 unFrmLstVentas = new frmLstVentas1();
                        unFrmLstVentas.MdiParent = this;
                        unFrmLstVentas.Show();
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

        private void mnuVenta_Click(object sender, EventArgs e)
        {
            Singleton("frmVenta");
        }

        private void lstVentas_Click(object sender, EventArgs e)
        {
            Singleton("frmLstVenta");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            controladora.CargarDatos();
        }
    }
}
