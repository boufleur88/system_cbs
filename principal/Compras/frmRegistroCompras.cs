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


        public int idProduto = 0, cantidad = 1;
        public string descripcion = "";
        public double costo1 = 0, costo2 = 0, precio1 = 0, precio2 = 0;

        // CREAR NUESTRO DELEGADO. 
        public delegate void pasar(int idProduto, string descripcion, int cantidad, double costo1, double costo2, double precio1, double precio2); // tipo del metodo y parametros que llevara el metodol

        // CREAR NUESTRO EVENTO.
        // public event pasar pasado;


        private void frmRegistroCompras_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(idProduto);
            txtDescripcion.Text = Convert.ToString(descripcion);
            txtCantidad.Text = Convert.ToString(cantidad);
            txtCosto2.Text = Convert.ToString(costo1);
            txtCosto1.Text = Convert.ToString(costo2);
            txtPrecio1.Text = Convert.ToString(precio1);
            txtPrecio2.Text = Convert.ToString(precio2);

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
            lblMinimo.Text = Convert.ToString(CalcularPorcentaje(costo1, precio1));
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            llamar_datos();
          
        }

        public void llamar_datos()
        {
            try
            {
                idProduto = Convert.ToInt32(txtCodigo.Text);
                descripcion = Convert.ToString(txtDescripcion.Text.Trim());
                cantidad = Convert.ToInt32(txtCantidad.Text);
                costo1 = Convert.ToDouble(txtCosto1.Text);
                costo2 = Convert.ToDouble(txtCosto1.Text);
                precio1 = Convert.ToDouble(txtPrecio1.Text);
                precio2 = Convert.ToDouble(txtPrecio2.Text);

                this.Close();

                /* UTILIZANDO DELEGADOS.
                frmTablaPersonasCompras fr = new frmTablaPersonasCompras();
                fr.pasado += new frmTablaPersonasCompras.pasar(pasarPessoa);
                fr.Show();

                pasado(idProduto, descripcion, cantidad, costo1, costo2, precio1, precio2);
                 */

            }
            catch (Exception erro)
            {
                MessageBox.Show("ERROR AL MOSTRAR EL ITEM EN LA COMPRA", "CBS INFORMATICA" + erro);
            }
        }

        
        public double CalcularPorcentaje(double costo, double precio)
        {
            //double cost, price;

            double precioCalculado = ((precio * 100) / costo);

            return precioCalculado;
        }

        
    }
}
