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
    public partial class frm_tabla_compra : Form
    {
        public frm_tabla_compra()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_compra fr = new frm_compra();
            fr.Show();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SeleccionarCompras();
            this.Close(); 
        }

        private void SeleccionarCompras()
        {
            int CodCom = 0, CodPro = 0;
            string NomPro = "", ObsCom = "", TelPro = "", RucPro = "";
            DateTime DatInc, DatVen;
            // string grupo, subgrupo, marca, descripcion, iva, moneda, observacion, medida, stminimo;
            // Double costo_adm, costo_cont, ventamay, ventamin;

            try
            {
                if (dtLista.SelectedRows.Count == 1)
                {
                    CodCom = Convert.ToInt32(dtLista.CurrentRow.Cells[0].Value);
                    CodPro = Convert.ToInt32(dtLista.CurrentRow.Cells[3].Value);
                    DatInc = Convert.ToDateTime(dtLista.CurrentRow.Cells[1].Value);
                    DatVen = Convert.ToDateTime(dtLista.CurrentRow.Cells[2].Value);
                    ObsCom = Convert.ToString(dtLista.CurrentRow.Cells[6].Value);
                    NomPro = Convert.ToString(dtLista.CurrentRow.Cells[4].Value);
                    TelPro = Convert.ToString(dtLista.CurrentRow.Cells[7].Value);
                    RucPro = Convert.ToString(dtLista.CurrentRow.Cells[8].Value);

                    frm_compra obj = new frm_compra();
                    obj.ultimoCodigo = CodCom;
                    obj.idProveedor = CodPro;
                    obj.nomeProveedor = NomPro;
                    obj.inclusion = DatInc;
                    obj.vencimiento = DatVen;
                    obj.obs = ObsCom;
                    obj.ruc = RucPro;
                    obj.telefono = TelPro;
                    obj.Show();
                    
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERROR AL TRAER ITEMS DE LA COMPRA" + erro);
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_tabla_compra_Load(object sender, EventArgs e)
        {
            CompraDal ls = new CompraDal();
            dtLista.DataSource = ls.listar_Compras();

            formata_tabla();
        }

        private void formata_tabla()
        {
            dtLista.Columns["id_compra"].HeaderText = "Numero";
            dtLista.Columns["id_compra"].DefaultCellStyle.Format = "00000";
            dtLista.Columns["c_inclusion"].HeaderText = "Fecha";
            dtLista.Columns["c_vencimiento"].HeaderText = "Vencimiento";
            dtLista.Columns["id_cliente"].HeaderText = "Codigo";
            dtLista.Columns["id_cliente"].DefaultCellStyle.Format = "00000";
            dtLista.Columns["per_nombre"].HeaderText = "Proveedor";
            dtLista.Columns["c_total"].HeaderText = "Total";
            dtLista.Columns["c_total"].DefaultCellStyle.Format = "N0";
            dtLista.Columns["c_total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;            
            dtLista.Columns["c_obs"].HeaderText = "Observacion";
            dtLista.Columns["per_tel1"].HeaderText = "Telefono";
            dtLista.Columns["per_ruc"].HeaderText = "Ruc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_testeGrid fr = new frm_testeGrid();
            fr.Show();
        }
    }
}
