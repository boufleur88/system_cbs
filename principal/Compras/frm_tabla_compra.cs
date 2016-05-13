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
            frm_compra fr = new frm_compra();
            fr.Show();   
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
            dtLista.Columns["id_compra"].HeaderText = "CODIGO";
            dtLista.Columns["c_inclusion"].HeaderText = "FECHA";
            dtLista.Columns["c_vencimiento"].HeaderText = "VENCIMIENTO";
            dtLista.Columns["per_nombre"].HeaderText = "PROVEEDOR";
            dtLista.Columns["c_total"].HeaderText = "TOTAL";
            dtLista.Columns["c_total"].DefaultCellStyle.Format = "N0";
            dtLista.Columns["c_total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;            
            dtLista.Columns["c_obs"].HeaderText = "OBSERVACION";
        }
       
    }
}
