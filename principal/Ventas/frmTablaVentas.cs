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
    public partial class frmTablaVentas : Form
    {
        public frmTablaVentas()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_ventas fr = new frm_ventas();
            fr.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTablaVentas_Load(object sender, EventArgs e)
        {
            txtBuscar.TabIndex = 0;
            txtBuscar.Focus();
            btnBuscar.TabIndex = 1;
            btnNuevo.TabIndex = 2;
            btnAlterar.TabIndex = 3;
            btnSalir.TabIndex = 4;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
