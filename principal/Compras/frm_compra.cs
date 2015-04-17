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
            txtProveedor.Enabled = false;
            txtIdProveedor.Enabled = false;
            txtTelefono.Enabled = false;
            txtRuc.Enabled = false;
            txtInclusion.Enabled = false;
            txtNCompra.Enabled = false;

            txtVencimiento.Focus();
            txtVencimiento.TabIndex = 0;
            txtFactura.TabIndex = 1;
            btnAdicionarProveedor.TabIndex = 2;
            txtObservacion.TabIndex = 3;
            btnProductos.TabIndex = 4;
            btnGuardar.TabIndex = 5;
            btnFactura.TabIndex = 6;
            btnImprimir.TabIndex = 7;
            btnSalir.TabIndex = 8;

            txtTotal.Enabled = false;

            
        }

        

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmTablaMercaderiasCompras fr = new frmTablaMercaderiasCompras();
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
            // UTILIZANDO DELEGADOS.
            frmTablaPersonasCompras fr = new frmTablaPersonasCompras();
            fr.pasado += new frmTablaPersonasCompras.pasar(ejecutar);
            fr.Show();
        }

        // EVENT DELEGATE
        public void ejecutar(int codigo, string nombre, string telefono, string ruc)
        {
            txtIdProveedor.Text = Convert.ToString(codigo);
            txtProveedor.Text = Convert.ToString(nombre);
            txtTelefono.Text = Convert.ToString(telefono);
            txtRuc.Text = Convert.ToString(ruc);
        }

        
    }
}
