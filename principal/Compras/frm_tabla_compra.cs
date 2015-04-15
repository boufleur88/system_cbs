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
    public partial class frm_tabla_compra : Form
    {
        public frm_tabla_compra()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_compra fr = new frm_compra();
            fr.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frm_compra fr = new frm_compra();
            fr.Show();   
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
