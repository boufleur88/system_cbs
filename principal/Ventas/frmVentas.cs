using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cbs_sistema
{
    public partial class frm_ventas : Form
    {
        public frm_ventas()
        {
            InitializeComponent();
        }

        // VARIABLES.
        public String proveedor, direccion, observacion, telefono, ruc, timbrado, factura;
        public long iva0, iva05, iva10, liquidacion, total;
        public int cod_compra, cod_proveedor, cod_mercaderia;


        private void frm_ventas_Load(object sender, EventArgs e)
        {
           // asignar fecha en el textbox.
           txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddMercaderia_Click(object sender, EventArgs e)
        {
           
        }

        public void ejecutar(string nombre, string direccion, string telefono, string ruc)
        {
           
        }

        private void btnAddProveedor_Click(object sender, EventArgs e)
        {
           frmVentasPersonas fr = new frmVentasPersonas();
           fr.Show();
        }
    }
}
