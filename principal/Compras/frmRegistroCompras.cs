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
    public partial class frmRegistroCompras : Form
    {
        public frmRegistroCompras()
        {
            InitializeComponent();
        }
        validar_datos v1 = new validar_datos();
        public int codigo, cantidad = 1;
        public string descripcion;
        public double costoadm, costocon, preciomin, precionormal;

        private void frmRegistroCompras_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(codigo);
            txtDescripcion.Text = Convert.ToString(descripcion);
            txtCantidad.Text = Convert.ToString(cantidad);
            txtCosto2.Text = Convert.ToString(costoadm);
            txtCosto1.Text = Convert.ToString(costocon);
            txtPrecio1.Text = Convert.ToString(preciomin);
            txtPrecio2.Text = Convert.ToString(precionormal);

            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio1.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio1.Text));
            txtPrecio2.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio2.Text));
            txtCosto2.Text = string.Format("{0:N0}", Convert.ToDouble(txtCosto2.Text));
            txtCosto1.Text = string.Format("{0:N0}", Convert.ToDouble(txtCosto1.Text));
            
            txtCantidad.Focus();
            txtCantidad.TabIndex = 0;
            txtCosto1.TabIndex = 1;
            txtCosto2.TabIndex = 2;
            txtPrecio1.TabIndex = 4;
            txtPrecio2.TabIndex = 5;
            btnGuardar.TabIndex = 6;
            btnSalir.TabIndex = 7;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void txtCostoCont_Leave(object sender, EventArgs e)
        {
            txtCosto1.Text = string.Format("{0:N0}", Convert.ToDouble(txtCosto1.Text));
        }

        private void txtCostoAdm_Leave(object sender, EventArgs e)
        {
            txtCosto2.Text = string.Format("{0:N0}", Convert.ToDouble(txtCosto2.Text));
        }

        private void txtPrecioCont_Leave(object sender, EventArgs e)
        {
            txtPrecio2.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio2.Text));
        }

        private void txtPrecioMin_Leave(object sender, EventArgs e)
        {
            txtPrecio1.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio1.Text));
        }


        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCosto1.Focus();
            }
            v1.solonumeros(e);
        }

        private void txtPrecioCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnGuardar.Focus();
            }
            v1.solonumeros(e);
        }

        private void txtCostoCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCosto2.Focus();
            }
            v1.solonumeros(e);
        }


        private void txtCostoAdm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecio1.Focus();
            }
            v1.solonumeros(e);
        }       

        private void txtPrecioMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecio2.Focus();
            }
            v1.solonumeros(e);
        }

        
        
    }
}
