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
    public partial class frmTablaMercaderiasVentas : Form
    {
        public frmTablaMercaderiasVentas()
        {
            InitializeComponent();
        }

        private void frmTablaMercaderiasVentas_Load(object sender, EventArgs e)
        {
            txt_buscar.Focus();
            txt_buscar.TabIndex = 0;
            btn_buscar.TabIndex = 1;

            ProdutoDal ls = new ProdutoDal();
            dt_lista_produto.DataSource = ls.listar_algunos();

            formata_tabla();
        }

        private void formata_tabla()
        {
            dt_lista_produto.Columns["id_produto"].HeaderText = "CODIGO";
            dt_lista_produto.Columns["pro_descr"].HeaderText = "DESCRIPCION";
            dt_lista_produto.Columns["pro_ventamay"].HeaderText = "VENTA MAYORISTA";
            dt_lista_produto.Columns["pro_ventamay"].DefaultCellStyle.Format = "N0";
            dt_lista_produto.Columns["pro_ventamay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dt_lista_produto.Columns["pro_ventamin"].HeaderText = "VENTA MINORISTA";
            dt_lista_produto.Columns["pro_ventamin"].DefaultCellStyle.Format = "N0";
            dt_lista_produto.Columns["pro_ventamin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dt_lista_produto.Columns["st_marca"].Visible = false;
            dt_lista_produto.Columns["st_grupo"].Visible = false;
            dt_lista_produto.Columns["st_subgrupo"].Visible = false;
            dt_lista_produto.Columns["pro_unidad"].Visible = false;
            dt_lista_produto.Columns["pro_cantmin"].Visible = false;
            dt_lista_produto.Columns["pro_moneda"].Visible = false;
            dt_lista_produto.Columns["pro_moneda"].Visible = false;
            dt_lista_produto.Columns["pro_iva"].Visible = false;
            dt_lista_produto.Columns["pro_obs"].Visible = false;
            dt_lista_produto.Columns["pro_costoadm"].Visible = false;
            dt_lista_produto.Columns["pro_costocon"].Visible = false;

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
