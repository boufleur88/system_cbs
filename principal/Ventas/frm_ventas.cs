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

        public int idCliente;
        public string cliente, telefono, ruc;

        private void frm_ventas_Load(object sender, EventArgs e)
        {          
            // CONFIGURACION DE TABINDEX.
            txtCodigoVenta.Enabled = false;
            txtCodCliente.Enabled = false;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
            txtRuc.Enabled = false;
            btnBuscarClientes.Focus();
            btnBuscarClientes.TabIndex = 0;
            txtObservacion.TabIndex = 1;
            btnMercaderia.TabIndex = 2;
            btnGuardar.TabIndex = 3;
            btnFactura.TabIndex = 4;
            btn_salir.TabIndex = 5;
            txtTotalVenta.Enabled = false;

            dtVentas.Columns["PRECIO"].DefaultCellStyle.Format = "N0";
            dtVentas.Columns["PRECIO"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtVentas.Columns["TOTAL"].DefaultCellStyle.Format = "N0";
            dtVentas.Columns["TOTAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        private void btnMercaderia_Click(object sender, EventArgs e)
        {
            frmTablaMercaderiasVentas fr = new frmTablaMercaderiasVentas();
            fr.pasadoMercaderia += new frmTablaMercaderiasVentas.pasarMercaderia(ejecutarVenta);
            // fr.Show();
            fr.Show();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            frmTablaServiciosVentas fr = new frmTablaServiciosVentas();
            fr.pasadoServicio += new frmTablaServiciosVentas.pasarServicio(ejecutarServicio); 
            
            fr.Show();
        }

        // EVENT DELEGATE
        public void ejecutarServicio(int codigo, int cantidad, string descripcion, double precio)
        {
            dtVentas.Rows.Add(codigo, descripcion, cantidad, precio);
        }

        public void ejecutarVenta(int codigo, int cantidad, string descripcion, double precio)
        {
            dtVentas.Rows.Add(codigo, descripcion, cantidad, precio);
        }

        // EVENT DELEGATE
        public void ejecutar(int codigo, string nombre, string telefono, string ruc)
        {
            txtCodCliente.Text = Convert.ToString(codigo);
            txtNombre.Text = Convert.ToString(nombre);
            txtTelefono.Text = Convert.ToString(telefono);
            txtRuc.Text = Convert.ToString(ruc);
        }

        private void btnBuscarClientes_Click(object sender, EventArgs e)
        {
            // UTILIZANDO DELEGADOS.
            frmTablaPersonasVentas fr = new frmTablaPersonasVentas();
            fr.pasado += new frmTablaPersonasVentas.pasar(ejecutar);
            fr.Show();
        }

        
    }
}
