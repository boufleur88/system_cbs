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
    public partial class frm_ventas : Form
    {
        public frm_ventas()
        {
            InitializeComponent();
        }

        private void frm_ventas_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
