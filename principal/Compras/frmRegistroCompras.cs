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
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
