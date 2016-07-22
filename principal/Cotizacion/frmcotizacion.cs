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
   public partial class frmcotizacion : Form
   {
      public frmcotizacion()
      {
         InitializeComponent();
      }

      public double compraUs = 0, compraRs = 0, ventaUs = 0, ventaRs = 0;

      private void button1_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void txtdolar_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == Convert.ToChar(Keys.Enter))
         {
            txtCompraRs.Focus();
         }
      }

      private void txtreal_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == Convert.ToChar(Keys.Enter))
         {
            btn_guardar.Focus();
         }
      }

      private void btn_guardar_Click(object sender, EventArgs e)
      {
          // comparacion de texto es con igual igual, compraracion de numero es igual
          
          if ( (txtCompraRs.Text == "") || (txtVentaRs.Text == "") || (txtCompraUs.Text == "") || (txtVentaUs.Text == "") )
          {
              MessageBox.Show("Falta Completar todos los valores");

          }
          else { 

            compraRs = Convert.ToDouble(txtCompraRs.Text);
            compraUs = Convert.ToDouble(txtCompraUs.Text);
            ventaRs = Convert.ToDouble(txtVentaRs.Text);
            ventaUs = Convert.ToDouble(txtVentaUs.Text);

           

          }
      }

      private void frmcotizacion_Load(object sender, EventArgs e)
      {

      }

      
   }
}
