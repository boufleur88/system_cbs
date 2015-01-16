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
    public partial class frm_tabla_stock : Form
    {
        public frm_tabla_stock()
        {
            InitializeComponent();
        }

        public DataGridViewContentAlignment Alignment { get; set; }
        String buscar;

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_reg_productos registrar = new frm_reg_productos();
            registrar.Show();
            this.Hide();
        }

        private void frm_tabla_stock_Load(object sender, EventArgs e)
        {
           ProdutoDal listar = new ProdutoDal();
           dt_lista_produto.DataSource = listar.listar();

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
           dt_lista_produto.Columns["pro_orig"].HeaderText = "ORIGINAL";
           dt_lista_produto.Columns["pro_fabr"].HeaderText = "FABRICANTE";
           dt_lista_produto.Columns["st_marca"].HeaderText = "MARCA";
           dt_lista_produto.Columns["st_grupo"].HeaderText = "GRUPO";
           dt_lista_produto.Columns["st_subgrupo"].HeaderText = "SUBGRUPO";
           dt_lista_produto.Columns["pro_ean"].HeaderText = "EAN";
           dt_lista_produto.Columns["pro_unidad"].HeaderText = "UNIDAD MEDIDA";
           dt_lista_produto.Columns["pro_cantmin"].HeaderText = "STOCK MINIMO";
           dt_lista_produto.Columns["pro_moneda"].HeaderText = "MONEDA";
           dt_lista_produto.Columns["pro_iva"].HeaderText = "IVA";
           dt_lista_produto.Columns["pro_obs"].HeaderText = "OBSERVACION";
           dt_lista_produto.Columns["pro_costocon"].HeaderText = "COSTO CONTABLE";
           dt_lista_produto.Columns["pro_costocon"].DefaultCellStyle.Format = "N0";
           dt_lista_produto.Columns["pro_costocon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           dt_lista_produto.Columns["pro_costoadm"].HeaderText = "COSTO ADMINISTRATIVO";
           dt_lista_produto.Columns["pro_costoadm"].DefaultCellStyle.Format = "N0";
           dt_lista_produto.Columns["pro_costoadm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           int codigo;

           try
           {
              if (dt_lista_produto.SelectedRows.Count == 1)
              {

                 codigo = Convert.ToInt32(dt_lista_produto.CurrentRow.Cells[0].Value);

                 MessageBox.Show("SEGURO QUE QUIERES ELIMINAR EL REGISTRO NUMERO " + codigo);

                 Produto obj = new Produto();
                 obj.codigo = codigo;

                 ProdutoDal excluir = new ProdutoDal();
                 excluir.excluir(obj);
                 

                 this.Close();

                 frm_tabla_stock fr = new frm_tabla_stock();
                 fr.Show();

              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERROR AL ELIMINAR CIUDAD" + erro);
           }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
           editar_datos();
        }

        // FUNCAO PARA ALTERAR DATOS...
        private void editar_datos()
        {
           int codigo;
           string original, fabricante, grupo, subgrupo, marca, descripcion, iva, moneda, observacion, medida, ean, stminimo;
           Double costo_adm, costo_cont, ventamay, ventamin;

           try
           {
              if (dt_lista_produto.SelectedRows.Count == 1)
              {
                
                 codigo = Convert.ToInt32(dt_lista_produto.CurrentRow.Cells[0].Value);
                 descripcion = Convert.ToString(dt_lista_produto.CurrentRow.Cells[1].Value);
                 ventamay = Convert.ToDouble(dt_lista_produto.CurrentRow.Cells[2].Value);
                 ventamin = Convert.ToDouble(dt_lista_produto.CurrentRow.Cells[3].Value);
                 original = Convert.ToString(dt_lista_produto.CurrentRow.Cells[4].Value);
                 fabricante = Convert.ToString(dt_lista_produto.CurrentRow.Cells[5].Value);
                 marca = Convert.ToString(dt_lista_produto.CurrentRow.Cells[6].Value);
                 grupo = Convert.ToString(dt_lista_produto.CurrentRow.Cells[7].Value);
                 subgrupo = Convert.ToString(dt_lista_produto.CurrentRow.Cells[8].Value);
                 ean = Convert.ToString(dt_lista_produto.CurrentRow.Cells[9].Value);
                 medida = Convert.ToString(dt_lista_produto.CurrentRow.Cells[10].Value);
                 stminimo = Convert.ToString(dt_lista_produto.CurrentRow.Cells[11].Value);
                 moneda = Convert.ToString(dt_lista_produto.CurrentRow.Cells[12].Value);
                 iva = Convert.ToString(dt_lista_produto.CurrentRow.Cells[13].Value);
                 observacion = Convert.ToString(dt_lista_produto.CurrentRow.Cells[14].Value);
                 costo_adm = Convert.ToDouble(dt_lista_produto.CurrentRow.Cells[16].Value);
                 costo_cont = Convert.ToDouble(dt_lista_produto.CurrentRow.Cells[15].Value);

                 this.Close();

                 frm_reg_productos obj = new frm_reg_productos();
                 obj.codigo = codigo;
                 obj.descripcion = descripcion;
                 obj.original = original;
                 obj.ventamay = ventamay;
                 obj.ventamin = ventamin;
                 obj.fabricante = fabricante;
                 obj.marca = marca;
                 obj.grupo = grupo;
                 obj.subgrupo = subgrupo;
                 obj.ean = ean;
                 obj.medida = medida;
                 obj.moneda = moneda;
                 obj.iva = iva;
                 obj.observacion = observacion;
                 obj.costo_adm = costo_adm;
                 obj.costo_cont = costo_cont;
                 obj.stminimo = stminimo;

                 obj.Show();

                
              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
           }
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
           MessageBox.Show("FALTA IMPLEMENTAR TODAVIA");
        }

        private void button3_Click(object sender, EventArgs e)
        {
           MessageBox.Show("FALTA IMPLEMENTAR TODAVIA");
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           MessageBox.Show("FALTA IMPLEMENTAR TODAVIA");
        }

        private void dt_lista_produto_DoubleClick(object sender, EventArgs e)
        {
           editar_datos();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           buscar = txt_buscar.Text.ToString();
           buscar = buscar.Trim();

           if (txt_buscar.Text == "")
           {
              ProdutoDal lista = new ProdutoDal();
              dt_lista_produto.DataSource = lista.listar();

              formata_tabla();
           }
           else
           {
              ProdutoDal listar = new ProdutoDal();
              dt_lista_produto.DataSource = listar.Buscar(buscar);

              formata_tabla();
           }
        }

       
    }
}
