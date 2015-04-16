using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sistema_cbs
{
    public partial class frmRegistroVentas : Form
    {
        public frmRegistroVentas()
        {
            InitializeComponent();
        }

        // Declaraciones de variables.
        validar_datos v1 = new validar_datos();
        public int codigo, cantidad = 1;
        public string descripcion;
        public double precio;

        private void frmRegistroVentas_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(codigo);
            txtDescripcion.Text = Convert.ToString(descripcion);
            txtCantidad.Text = Convert.ToString(cantidad);
            txtPrecio.Text = Convert.ToString(precio);
            
            txtDescripcion.Enabled = false;
            txtCodigo.Enabled = false;
            txtPrecio.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio.Text));
            txtCantidad.Focus();
            txtCantidad.TabIndex = 0;
            txtPrecio.TabIndex = 1;

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmTablaMercaderiasVentas fr = new frmTablaMercaderiasVentas();
            fr.Show();
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            txtPrecio.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio.Text));
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecio.Focus();
            }
            v1.solonumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_guardar.Focus();
            }
            v1.solonumeros(e);
        }

    }
}
