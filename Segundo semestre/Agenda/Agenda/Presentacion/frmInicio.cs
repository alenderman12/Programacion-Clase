using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda.Presentacion
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void mnuContactos_Click(object sender, EventArgs e)
        {
            string pForm = "frmContacto";
            this.Singleton(pForm);
        }

        private void mnuCiudades_Click(object sender, EventArgs e)
        {
            string pForm = "frmCiudad";
            this.Singleton(pForm);
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
                    case "frmContacto":
                        frmContacto unfrmContacto = new frmContacto();
                        unfrmContacto.MdiParent = this;
                        unfrmContacto.Show();
                        break;
                    case "frmCiudad":
                        frmCiudad unfrmCiudad = new frmCiudad();
                        unfrmCiudad.MdiParent = this;
                        unfrmCiudad.Show();
                        break;
                }
            }

        }

        #endregion

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }
    }
}
