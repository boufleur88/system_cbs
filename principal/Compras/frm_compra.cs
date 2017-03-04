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
        public int ultimoCodigo = 0, linha = 0;
        public int cid = 0, pid = 0, uid = 1;
        public int cMoneda = 1, cSucursal = 1, cStatus = 1;
        public string nFactura = "";
        public string nTimbrado = "";
        public DateTime inclusion = DateTime.Now;
        public DateTime vencimiento = DateTime.Now;

        public string persona = "", fantasia = "", direccion = "", telefono = "", ruc = "", obs = "";
        public Double totalCompra = 0, cantidad = 0, costoadm = 0, costocont = 0, ventamay = 0, ventamin = 0;
        public Double iva10 = 0, iva05 = 0, iva00 = 0;


        private void frm_compra_Load(object sender, EventArgs e)
        {
            // Reset values for default
            OptContado.Select(); // option contado

            // Carrega o codigo da compra
            CompraDal codigo = new CompraDal();
            ultimoCodigo = codigo.GeraCodigo();
            txtIdCompra.Text = Convert.ToString(ultimoCodigo);

            txtProveedor.Enabled = false;
            txtIdProveedor.Enabled = true;
            txtTelefono.Enabled = false;
            txtRuc.Enabled = false;
            txtInclusion.Enabled = false;
            txtIdCompra.Enabled = false;

            txtInclusion.Text = inclusion.ToShortDateString();
            txtVencimiento.Text = vencimiento.ToShortDateString();
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

            txtTotal.Enabled = true;


            dtLista.ColumnCount = 4;
            dtLista.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle =
                new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Aqua;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dtLista.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dtLista.Columns[0].Name = "CODIGO";
            dtLista.Columns[1].Name = "DESCRIPCION";
            dtLista.Columns[2].Name = "CANTIDAD";
            dtLista.Columns[3].Name = "COSTO";

            // Populate the rows.
            for (linha = 0; linha==24; linha++)
            {
                
            }
            
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmTablaMercaderiasCompras fr = new frmTablaMercaderiasCompras();
            //fr.pasado += new frmTablaMercaderiasCompras.pasar
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
            fr.pasado += new frmTablaPersonasCompras.pasar(pasarPessoa);
            fr.Show();
        }

        // EVENT DELEGATE
        public void pasarPessoa(int codigo, string nombre, string telefono, string ruc)
        {
            txtIdProveedor.Text = Convert.ToString(codigo);
            txtProveedor.Text = Convert.ToString(nombre);
            txtTelefono.Text = Convert.ToString(telefono);
            txtRuc.Text = Convert.ToString(ruc);
        }


        public void pasarProduto(int idProduto, string descripcion, double costo1, double costo2, double precio1, double precio2)
        {
            dtLista.Rows[1].Cells[0].Value = Convert.ToString(idProduto);
            dtLista.Rows[1].Cells[1].Value = Convert.ToString(descripcion);
            dtLista.Rows[1].Cells[2].Value = Convert.ToString(cantidad);
            dtLista.Rows[1].Cells[3].Value = Convert.ToString(costo1);
            dtLista.Rows[1].Cells[4].Value = Convert.ToString(costo2);
            dtLista.Rows[1].Cells[5].Value = Convert.ToString(precio1);
            dtLista.Rows[1].Cells[6].Value = Convert.ToString(precio2);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (txtIdProveedor.Text == "")
            {
                MessageBox.Show("Adicionar al menos un Proveedor para la Compra");
            }
            else
            {
                /* ###################################################################### */
                pid = Convert.ToInt32(txtIdProveedor.Text);
                string dataInclusion = string.Format("{0:d}", inclusion);
                string dataVencimiento = string.Format("{0:d}", vencimiento);
                nFactura = Convert.ToString(txtFactura.Text);
                nFactura = nFactura.Trim();

                if (iva00 == 0)
                    //iva00 = Convert.ToDouble(txtIva00.Text);
                    iva00 = 0;

                if (iva05 == 0)
                    //iva05 = Convert.ToDouble(txtIva05.Text);
                    iva05 = 0;

                if (iva10 == 0)
                    //iva10 = Convert.ToDouble(txtIva10.Text);
                    iva10 = 0;
                
                if (totalCompra == 0)
                    //totalCompra = Convert.ToDouble(txtTotal.Text); 
                    totalCompra = 0;
                    MessageBox.Show("No hay ninguna mercaderia incluida en la compra");

                obs = txtObservacion.Text;
                obs = obs.Trim();

                try
                {
                    Compra obj = new Compra();

                    obj.pid = pid;
                    obj.uid = uid;
                    obj.f_inclusion = inclusion;
                    obj.f_vencimiento = vencimiento;
                    obj.factura = nFactura;
                    obj.observacion = obs;
                    obj.iva00 = iva00;
                    obj.iva05 = iva05;
                    obj.iva10 = iva10;
                    obj.totalCompra = totalCompra;
                    obj.moneda = cMoneda;
                    obj.sucursal = cSucursal;
                    obj.status = cStatus;

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

        private void txtIdProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show("Preciono Enter");
                txtObservacion.Focus();
            }
        }

        private void txtInclusion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                MessageBox.Show("Preciono Enter");
                txtVencimiento.Focus();
            }
        }

        private void dtLista_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string msg = String.Format("Cell at row {0}, column {1} value changed",e.RowIndex, e.ColumnIndex);
            MessageBox.Show(msg, "Cell Value Changed");
        }
    }
}
