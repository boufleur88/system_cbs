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
        public string codigoItem = "";
        public string nomeProveedor = "";
      
        public int idProveedor = 0, pid = 0, uid = 1;
        public int cMoneda = 1, cSucursal = 1, cStatus = 1;
        public string nFactura = "";
        public string nTimbrado = "";
        public DateTime inclusion = DateTime.Now;
        public DateTime vencimiento = DateTime.Now;

        // itesm
        public string descricaoItem = "";

        public string persona = "", fantasia = "", direccion = "", telefono = "", ruc = "", obs = "";
        public Double totalCompra, cantidad = 0, costoadm = 0, costocont = 0, ventamay = 0, ventamin = 0;
                
        private void button1_Click(object sender, EventArgs e)
        {
            somaTotalCompra();
            
        }

        private void dtLista_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            somaTotalItems();
            somaTotalCompra();
        }

        void somaTotalCompra()
        {
            int tamanho = dtLista.Rows.Count - 1;
            totalCompra = 0;
            for (int c = 0; c < tamanho; c++)
            {
                totalCompra += Convert.ToDouble(dtLista.Rows[c].Cells["TOTAL"].Value);
                //MessageBox.Show(totalCompra.ToString());
                //MessageBox.Show("Tamanho " + tamanho.ToString());
            }          
            //MessageBox.Show("Total Compras " + totalCompra.ToString());
            txtTotal.Text = totalCompra.ToString();
        }

        void somaTotalItems()
        {

            for (int i = 0; i < dtLista.Rows.Count - 1; i++)
            {
                double q = Convert.ToDouble(dtLista.Rows[i].Cells["CANTIDAD"].Value);
                double c = Convert.ToDouble(dtLista.Rows[i].Cells["COSTO"].Value);
                dtLista.Rows[i].Cells["TOTAL"].Value = q * c;
            }
        }


        public Double iva10 = 0, iva05 = 0, iva00 = 0;


        private void frm_compra_Load(object sender, EventArgs e)
        {
            txtIdCompra.Enabled = false;
            txtProveedor.Enabled = false;
            txtIdProveedor.Enabled = false;

            // Reset values for default
            OptContado.Select(); // option contado
            // Carrega o codigo da compra se for alterar
            if (ultimoCodigo > 0)
            {
                txtIdCompra.Text = Convert.ToString(ultimoCodigo);
                txtIdCompra.Enabled = false;
                txtIdProveedor.Text = Convert.ToString(idProveedor);
                txtProveedor.Text = Convert.ToString(nomeProveedor);
                txtObservacion.Text = Convert.ToString(obs);
                txtRuc.Text = Convert.ToString(ruc);
                txtTelefono.Text = Convert.ToString(telefono);
                txtInclusion.Enabled = true;
                txtTotal.Enabled = true;


                CompraDal item = new CompraDal();
                dtLista.DataSource = item.listarItemsCompras(ultimoCodigo.ToString());
                FormataTablaItems();
            }
            else
            {
                CompraDal codigo = new CompraDal();
                ultimoCodigo = codigo.GeraCodigo();
                txtIdCompra.Text = Convert.ToString(ultimoCodigo);
                txtIdProveedor.Enabled = true;
                txtTelefono.Enabled = false;
                txtRuc.Enabled = false;
                txtInclusion.Enabled = false;
                txtIdCompra.Enabled = false;
                txtTotal.Enabled = true;
                CreaTablaItems();

            }

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
      

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle =
                new DataGridViewCellStyle();
            columnHeaderStyle.BackColor = Color.Aqua;
            columnHeaderStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
            dtLista.ColumnHeadersDefaultCellStyle = columnHeaderStyle;



        }

        public void CreaTablaItems()
        {
            dtLista.ColumnCount = 5;
            dtLista.ColumnHeadersVisible = true;
            dtLista.Columns[0].Name = "CODIGO";
            dtLista.Columns[0].ReadOnly = true;
            dtLista.Columns[1].Name = "DESCRIPCION";
            dtLista.Columns[1].ReadOnly = true;
            dtLista.Columns[2].Name = "CANTIDAD";
            dtLista.Columns[3].Name = "COSTO";
            dtLista.Columns[4].ReadOnly = true;
            dtLista.Columns[4].Name = "TOTAL";

        }

        public void FormataTablaItems()
        {
            // Set the column header names.
            dtLista.Columns["codpro"].HeaderText = "CODIGO";
            dtLista.Columns["codpro"].ReadOnly = true;
            dtLista.Columns["it_desc"].HeaderText = "DESCRIPCION";
            dtLista.Columns["it_desc"].ReadOnly = true;
            dtLista.Columns["it_cant"].HeaderText = "CANTIDAD";
            dtLista.Columns["it_cant"].DefaultCellStyle.Format = "N2";
            dtLista.Columns["it_costo1"].HeaderText = "COSTO";
            dtLista.Columns["it_costo1"].DefaultCellStyle.Format = "N0";
            dtLista.Columns["it_costo1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtLista.Columns["TOTAL"].HeaderText = "TOTAL";
            dtLista.Columns["TOTAL"].DefaultCellStyle.Format = "N0";
            dtLista.Columns["TOTAL"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dtLista.Columns["TOTAL"].ReadOnly = true;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            // UTILIZANDO DELEGADOS.
            frmTablaMercaderiasCompras fr = new frmTablaMercaderiasCompras();
            fr.EventoPassar += new frmTablaMercaderiasCompras.pasarItems(pasarProduto);
            fr.Show();
            
            // Exemplo para adicionar uma linha 
            //string[] row0 = { "Codigo", "Descricao", "Cantidad", "costo" };
            //dtLista.Rows.Add(row0);
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


        public void pasarProduto(int idProduto, string descripcion, int cantidad, double costo1)
        {
            string[] row0 = { Convert.ToString(idProduto), Convert.ToString(descripcion), Convert.ToString(cantidad), Convert.ToString(costo1)};
            dtLista.Rows.Add(row0);
        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdProveedor.Text == "")
            {
                MessageBox.Show("Adicionar al menos un Proveedor para la Compra");
            }
            else
            {
                btnAdicionarProveedor.Focus();
            }

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
                    //MessageBox.Show("No hay ninguna mercaderia incluida en la compra");

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

                    MessageBox.Show("Cabecalho guardado corretamente");

                 for (int linha=0; linha < dtLista.Rows.Count - 1; linha++)
                    {

                        codigoItem = Convert.ToString(dtLista.Rows[linha].Cells[0].Value);
                        descricaoItem = Convert.ToString(dtLista.Rows[linha].Cells[1].Value);
                        cantidad = Convert.ToInt32(dtLista.Rows[linha].Cells[2].Value);
                        costocont = Convert.ToDouble(dtLista.Rows[linha].Cells[3].Value);

                        Compra Item = new Compra();
                        Item.cid = Convert.ToInt32(txtIdCompra.Text);
                        Item.it_codigo = codigoItem;
                        Item.it_description = descricaoItem;
                        Item.it_cantidad = cantidad;
                        Item.it_costo = costocont;

                        CompraDal guardarItem = new CompraDal();
                        guardarItem.gravar_itens(Item);

                        MessageBox.Show("Item guardado corretamente");

                    }
                    
                    this.Close();
                    frm_tabla_compra fr = new frm_tabla_compra();
                    fr.Show();
                }

                catch (Exception erro)
                {
                    MessageBox.Show("ERROR AL GUARDAR PRODUCTO" + erro);
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
