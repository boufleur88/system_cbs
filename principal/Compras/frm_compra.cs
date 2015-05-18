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
        // variables cabecera compra.
        public int cid, pid, uid;
        public string factura;
        public DateTime inclusion = DateTime.Now;
        public DateTime f_factura = DateTime.Now;

        public string persona, fantasia, direccion, telefono, ruc, observacion;
        public Double totalCompra, cantidad, costoadm, costocont, ventamay, ventamin;

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

            txtInclusion.Text = inclusion.ToShortDateString();
            txtVencimiento.Text = f_factura.ToShortDateString();

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdProveedor.Text == "")
            {
                MessageBox.Show("Adicionar al menos un proveedor para tu compra");
            }
            else
            {
                pid = Convert.ToInt32(txtIdProveedor.Text);
                uid = 1;
                //string dataInclusion = string.Format("{0:d}", inclusion);
                //string dataFactura = string.Format("{0:d}", f_factura);
                factura = Convert.ToString(txtFactura.Text);
                factura = factura.Trim();
                totalCompra = 1000; //Convert.ToDouble(txtTotal.Text);
                observacion = txtObservacion.Text;
                //MessageBox.Show("Codigo Proveedor " + pid);
                //MessageBox.Show("Codigo usuario " + uid);
                //MessageBox.Show("Inclusion " + dataInclusion);
                //MessageBox.Show("Factura " + dataFactura);
                //MessageBox.Show("Total Compra " + totalCompra);
                try
                {
                    Compra obj = new Compra();
                    obj.pid = pid;
                    obj.uid = uid;
                    obj.f_inclusion = inclusion;
                    obj.factura = factura;
                    obj.totalCompra = totalCompra;
                    
                    CompraDal guardar = new CompraDal();
                    guardar.gravar_cabecera(obj);

                    MessageBox.Show("COMPRA GUARDADA CORRECTAMENTE");

                    this.Close();
                    frm_tabla_compra fr = new frm_tabla_compra();
                    fr.Show();
                }

                catch (Exception erro)
                {
                    MessageBox.Show("ERROR AL GUARDAR PRODUCTO" + erro);
                }
            }
        }

        
    }
}
