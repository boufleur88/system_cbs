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
            // CONFIGURACION DE TABINDEX.

            txtFecha.Enabled = false;
            txtCodigoVenta.Enabled = false;
            txtCodCliente.Focus();
            txtCodCliente.TabIndex = 0;
            txtNombre.TabIndex = 1;
            txtTelefono.Enabled = false;
            txtRuc.Enabled = false;
            txtObservacion.TabIndex = 2;
            btnMercaderia.TabIndex = 3;
            btnGuardar.TabIndex = 4;
            btnFactura.TabIndex = 5;
            btn_salir.TabIndex = 6;
            txtTotalVenta.Enabled = false;

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
            frmTablaVentas fr = new frmTablaVentas();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTablaPersonasVentas fr = new frmTablaPersonasVentas();
            fr.Show();
        }

        private void btnMercaderia_Click(object sender, EventArgs e)
        {
            frmTablaMercaderiasVentas fr = new frmTablaMercaderiasVentas();
            fr.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            frmTablaServiciosVentas fr = new frmTablaServiciosVentas();
            fr.Show();
        }

        
    }
}
