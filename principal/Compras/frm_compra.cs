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


        

        private void frm_compra_Load(object sender, EventArgs e)
        {

        }

        

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frm_tabla_stock fr = new frm_tabla_stock();
            fr.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_tabla_compra fr = new frm_tabla_compra();
            fr.Show();

        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            frm_tabla_personas fr = new frm_tabla_personas();
            fr.Show();
        }

        
    }
}
