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
    public partial class frm_compra : Form
    {
        public frm_compra()
        {
            InitializeComponent();
        }

        public int codigo;
        public string persona, fantasia, direccion, telefono, ruc, observacion;
        public Double cantidad, costoadm, costocont, ventamay, ventamin;


        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
