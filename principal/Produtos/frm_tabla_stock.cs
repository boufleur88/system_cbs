using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cbs_sistema
{
    public partial class frm_tabla_stock : Form
    {
        public frm_tabla_stock()
        {
            InitializeComponent();
        }

        public DataGridViewContentAlignment Alignment { get; set; }
        String buscar;
        DataSet resultado = new DataSet();
        DataView mifiltro;

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.Close();

           frm_reg_productos registrar = new frm_reg_productos();
           registrar.Show();
        }

        private void frm_tabla_stock_Load(object sender, EventArgs e)
        {
           formata_tabla();
        }

        private void formata_tabla()
        {
           ProdutoDal listar = new ProdutoDal();
           listar.Buscar_datos("SELECT produto.id_produto, produto.pro_descr, produto.pro_ventamay, produto.pro_ventamin, produto.pro_orig, produto.pro_fabr, st_marca.st_marca, st_grupo.st_grupo, st_subgrupo.st_subgrupo, produto.pro_ean, produto.pro_unidad, produto.pro_cantmin, produto.pro_moneda, produto.pro_iva, produto.pro_obs, pro_costocon, produto.pro_costoadm FROM produto, st_grupo, st_marca, st_subgrupo WHERE produto.id_grupo = st_grupo.id_grupo AND produto.id_marca = st_marca.id_marca AND produto.id_subgrupo = st_subgrupo.id_subgrupo order by produto.id_produto", ref resultado, "produto");

           this.mifiltro = ((DataTable)resultado.Tables["produto"]).DefaultView;

           this.dt_lista_produto.DataSource = mifiltro;

           dt_lista_produto.Columns["id_produto"].HeaderText = "CODIGO";
           dt_lista_produto.Columns["id_produto"].Width = 50;

           dt_lista_produto.Columns["pro_descr"].HeaderText = "DESCRIPCION";
           dt_lista_produto.Columns["pro_descr"].Width = 350;

           dt_lista_produto.Columns["pro_ventamay"].HeaderText = "VENTA MAYORISTA";
           dt_lista_produto.Columns["pro_ventamay"].DefaultCellStyle.Format = "N0";
           dt_lista_produto.Columns["pro_ventamay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           dt_lista_produto.Columns["pro_ventamay"].Width = 100;

           dt_lista_produto.Columns["pro_ventamin"].HeaderText = "VENTA MINORISTA";
           dt_lista_produto.Columns["pro_ventamin"].DefaultCellStyle.Format = "N0";
           dt_lista_produto.Columns["pro_ventamin"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           dt_lista_produto.Columns["pro_ventamin"].Width = 100;

           dt_lista_produto.Columns["pro_orig"].HeaderText = "ORIGINAL";
           dt_lista_produto.Columns["pro_orig"].Width = 80;

           dt_lista_produto.Columns["pro_fabr"].HeaderText = "FABRICANTE";
           dt_lista_produto.Columns["pro_fabr"].Width = 80;

           dt_lista_produto.Columns["st_marca"].HeaderText = "MARCA";
           dt_lista_produto.Columns["st_marca"].Width = 80;

           dt_lista_produto.Columns["st_grupo"].HeaderText = "GRUPO";
           dt_lista_produto.Columns["st_grupo"].Width = 80;

           dt_lista_produto.Columns["st_subgrupo"].HeaderText = "SUBGRUPO";
           dt_lista_produto.Columns["st_subgrupo"].Width = 80;

           dt_lista_produto.Columns["pro_ean"].HeaderText = "EAN";
           dt_lista_produto.Columns["pro_ean"].Width = 100;

           dt_lista_produto.Columns["pro_unidad"].HeaderText = "UNIDAD MEDIDA";
           dt_lista_produto.Columns["pro_unidad"].Width = 50;

           dt_lista_produto.Columns["pro_cantmin"].HeaderText = "STOCK MINIMO";
           dt_lista_produto.Columns["pro_cantmin"].Width = 50;
           
           dt_lista_produto.Columns["pro_moneda"].HeaderText = "MONEDA";
           dt_lista_produto.Columns["pro_moneda"].Width = 50;

           dt_lista_produto.Columns["pro_iva"].HeaderText = "IVA";
           dt_lista_produto.Columns["pro_iva"].Width = 50;

           dt_lista_produto.Columns["pro_obs"].HeaderText = "OBSERVACION";

           dt_lista_produto.Columns["pro_costocon"].HeaderText = "COSTO CONTABLE";
           dt_lista_produto.Columns["pro_costocon"].DefaultCellStyle.Format = "N0";
           dt_lista_produto.Columns["pro_costocon"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           dt_lista_produto.Columns["pro_costocon"].Width = 100;
           
           dt_lista_produto.Columns["pro_costoadm"].HeaderText = "COSTO ADMINISTRATIVO";
           dt_lista_produto.Columns["pro_costoadm"].DefaultCellStyle.Format = "N0";
           dt_lista_produto.Columns["pro_costoadm"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
           dt_lista_produto.Columns["pro_costoadm"].Width = 100;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("ELIMINAR REGISTROS", "ELIMINAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
           {
              int codigo;


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
           else
           {
              btn_excluir.Focus();
           }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
           editar_datos();
        }

       // Declarar variable posicion que almacenara el row.index del datagrid.
        public int posicion = 0;

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

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
           string salida_datos = ""; // muestra el resultado final.

           string[] palabras_busqueda = this.txt_buscar.Text.Split(' '); // posibles palabras que el usuario digitara...

           foreach (string palabra in palabras_busqueda)
           {
              if (salida_datos.Length == 0)
              {
                 salida_datos = "( pro_descr LIKE '%" + palabra + "%')";
              }
              else
              {
                 salida_datos += " AND (pro_descr LIKE '%" + palabra + "%')";
              }
           }

           this.mifiltro.RowFilter = salida_datos;
        }

       
    }
}
