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
    public partial class frmTablaMercaderiasCompras : Form
    {
        public frmTablaMercaderiasCompras()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTablaMercaderiasCompras_Load(object sender, EventArgs e)
        {
            ProdutoDal ls = new ProdutoDal();
            dt_lista.DataSource = ls.listarCompras();

            formata_tabla();
        }

        private void formata_tabla()
        {
            dt_lista.Columns["id_produto"].HeaderText = "CODIGO";
            dt_lista.Columns["pro_descr"].HeaderText = "DESCRIPCION";
            dt_lista.Columns["pro_costoadm"].HeaderText = "COSTO ADMINISTRATIVO";            
            dt_lista.Columns["pro_costoadm"].DefaultCellStyle.Format = "N0";
            dt_lista.Columns["pro_costoadm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dt_lista.Columns["pro_costocon"].HeaderText = "COSTO CONTABLE";
            dt_lista.Columns["pro_costocon"].DefaultCellStyle.Format = "N0";
            dt_lista.Columns["pro_costocon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dt_lista.Columns["pro_ventamay"].HeaderText = "VENTA MAYORISTA";
            dt_lista.Columns["pro_ventamay"].DefaultCellStyle.Format = "N0";
            dt_lista.Columns["pro_ventamay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dt_lista.Columns["pro_ventamin"].HeaderText = "VENTA MINORISTA";
            dt_lista.Columns["pro_ventamin"].DefaultCellStyle.Format = "N0";
            dt_lista.Columns["pro_ventamin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dt_lista.Columns["st_marca"].Visible = false;
            dt_lista.Columns["st_grupo"].Visible = false;
            dt_lista.Columns["st_subgrupo"].Visible = false;
            dt_lista.Columns["pro_unidad"].Visible = false;
            dt_lista.Columns["pro_cantmin"].Visible = false;
            dt_lista.Columns["pro_moneda"].Visible = false;
            dt_lista.Columns["pro_moneda"].Visible = false;
            dt_lista.Columns["pro_iva"].Visible = false;
            dt_lista.Columns["pro_obs"].Visible = false;
        }

        private void btmAdicionar_Click(object sender, EventArgs e)
        {
            llamar_datos();
        }

        public void llamar_datos()
        {
            int idMercaderia;
            string descripcion;
            double costoadm, costocon, preciomin, precio;

            try
            {
                if (dt_lista.SelectedRows.Count == 1)
                {
                    idMercaderia = Convert.ToInt32(dt_lista.CurrentRow.Cells[0].Value);
                    descripcion = Convert.ToString(dt_lista.CurrentRow.Cells[1].Value);
                    costocon = Convert.ToDouble(dt_lista.CurrentRow.Cells[2].Value);
                    costoadm = Convert.ToDouble(dt_lista.CurrentRow.Cells[3].Value);
                    preciomin = Convert.ToDouble(dt_lista.CurrentRow.Cells[4].Value);
                    precio = Convert.ToDouble(dt_lista.CurrentRow.Cells[5].Value);

                    this.Close();

                    frmRegistroCompras obj = new frmRegistroCompras();
                    obj.idProduto = idMercaderia;
                    obj.descripcion = descripcion;
                    obj.costo1 = costocon;
                    obj.costo2 = costoadm;
                    obj.precio1 = preciomin;
                    obj.precio2 = preciomin;
                    obj.Show();

                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
            }
        }


    }
}
