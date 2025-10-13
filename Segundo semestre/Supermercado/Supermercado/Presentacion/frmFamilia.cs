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
    public partial class frmFamilia : Form
    {
        Controladora controladora = new Controladora();
        public frmFamilia()
        {
            InitializeComponent();
        }

        private void LimpiarCajas()
        {
            txtId.Text = controladora.IdFamilia().ToString();
            txtNombre.Clear();
            lblMensaje.Visible = false;
            txtId.Focus();
        }

        private void ListarFamilias()
        {
            lvsFamilias.Items.Clear();
            foreach (Familia familia in controladora.ListaFamilias())
            {
                ListViewItem item = new ListViewItem(familia.Id.ToString());
                item.SubItems.Add(familia.Nombre);
                lvsFamilias.Items.Add(item);
            }
            txtId.Text = controladora.IdFamilia().ToString();
        }

        private void frmFamilia_Load(object sender, EventArgs e)
        {
            ListarFamilias();
            LimpiarCajas();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                lblMensaje.Text = "Debe completar todos los campos requeridos";
                lblMensaje.Visible = true;
                return;
            }
            else if (!int.TryParse(txtId.Text, out int a))
            {
                lblMensaje.Text = "El ID debe ser un numero";
                lblMensaje.Visible = true;
                return;
            }
            int Id = controladora.IdFamilia();
            string Nombre = txtNombre.Text;

            Familia familia = new Familia(Id, Nombre);
            if (controladora.AltaFamilia(familia))
            {
                ListarFamilias();
                LimpiarCajas();
            }
            else
            {
                lblMensaje.Text = "Ya existe una familia con ese ID";
                lblMensaje.Visible = true;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtNombre.Text == "")
            {
                lblMensaje.Text = "Debe completar todos los campos requeridos";
                lblMensaje.Visible = true;
                return;
            }

            int Id = int.Parse(lvsFamilias.SelectedItems[0].SubItems[0].Text);
            string Nombre = txtNombre.Text;

            if (controladora.ModificarFamilia(Id, Nombre))
            {
                ListarFamilias();
                LimpiarCajas();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                lblMensaje.Text = "Seleccione una familia";
                lblMensaje.Visible = true;
                return;
            }

            int Id = int.Parse(txtId.Text);

            if (controladora.BajaFamilia(Id))
            {
                ListarFamilias();
                LimpiarCajas();
            }
        }

        private void lblLimpiarCajas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimpiarCajas();
        }




        private void lvsFamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvsFamilias.SelectedItems.Count > 0)
            {
                ListViewItem item = lvsFamilias.SelectedItems[0];
                txtId.Text = item.SubItems[0].Text;
                txtNombre.Text = item.SubItems[1].Text;
            }
        }
    }
}
