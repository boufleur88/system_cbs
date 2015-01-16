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

      private void button1_Click(object sender, EventArgs e)
      {
         Close();
      }

      private void txtdolar_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == Convert.ToChar(Keys.Enter))
         {
            txtreal.Focus();
         }
      }

      private void txtreal_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == Convert.ToChar(Keys.Enter))
         {
            btn_guardar.Focus();
         }
      }

      
   }
}
