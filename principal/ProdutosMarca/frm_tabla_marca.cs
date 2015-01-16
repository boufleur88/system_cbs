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
    public partial class frm_tabla_marca : Form
    {
        public frm_tabla_marca()
        {
            InitializeComponent();
        }

       // VARIABLES
        String buscar;
        public DataGridViewContentAlignment Alignment { get; set; }

        DataSet resultado = new DataSet();
        DataView mifiltro;

        public void atualiza_tabla()
        {
           ProdutoMarcaDal listar = new ProdutoMarcaDal();
           listar.Buscar_datos("select id_marca, st_marca from st_marca order by id_marca", ref resultado, "stmarca");

           this.mifiltro = ((DataTable)resultado.Tables["stmarca"]).DefaultView;

           this.dt_lista_marca.DataSource = mifiltro;

           dt_lista_marca.Columns["id_marca"].HeaderText = "CODIGO";
           dt_lista_marca.Columns["id_marca"].Width = 80;
           dt_lista_marca.Columns["st_marca"].HeaderText = "MARCA";
           dt_lista_marca.Columns["st_marca"].Width=380;
           
        }
        
        private void frm_tabla_marca_Load(object sender, EventArgs e)
        {
           txt_buscar.Focus();
 
           try
            {
                atualiza_tabla();
               
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al cargar los datos." + error);

            }
        }

        private void editar_datos()
        {
           int codigo;
           string marca;

           try
           {
              if (dt_lista_marca.SelectedRows.Count == 1)
              {
                 codigo = Convert.ToInt32(dt_lista_marca.CurrentRow.Cells[0].Value);
                 marca = Convert.ToString(dt_lista_marca.CurrentRow.Cells[1].Value);

                 frm_reg_marca obj = new frm_reg_marca();
                 obj.codigo = codigo;
                 obj.marca = marca;

                 obj.Show();

              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
           }
        }
        

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
           this.Close();

           frm_reg_marca marca = new frm_reg_marca();
           marca.Show();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           editar_datos();

           this.Close();

        }

        private void dt_lista_marca_DoubleClick(object sender, EventArgs e)
        {
           editar_datos();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

           if (MessageBox.Show("ELIMINAR REGISTROS", "ELIMINAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
           {
              int codigo;


              if (dt_lista_marca.SelectedRows.Count == 1)
              {

                 codigo = Convert.ToInt32(dt_lista_marca.CurrentRow.Cells[0].Value);

                 MessageBox.Show("SEGURO QUE QUIERES ELIMINAR EL REGISTRO NUMERO " + codigo);

                 ProdutoMarca obj = new ProdutoMarca();
                 obj.codigo = codigo;

                 ProdutoMarcaDal excluir = new ProdutoMarcaDal();
                 excluir.excluir(obj);

                 this.Close();

                 frm_tabla_marca fr = new frm_tabla_marca();
                 fr.Show();
              }
           }
           else
           {
              btn_excluir.Focus();
           }
      
    }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           buscar = txt_buscar.Text.ToString();
           buscar = buscar.Trim();

           if (txt_buscar.Text == "")
           {
              ProdutoMarcaDal lista = new ProdutoMarcaDal();
              dt_lista_marca.DataSource = lista.listar();
           }
           else 
           { 
              ProdutoMarcaDal lista = new ProdutoMarcaDal();
              dt_lista_marca.DataSource = lista.Buscar(buscar);
           }
   
        }

        private void btn_nuevo_Leave(object sender, EventArgs e)
        {
           atualiza_tabla();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
           // atualiza_tabla();
        }

        private void btn_excluir_Leave(object sender, EventArgs e)
        {
           atualiza_tabla();
        }

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
           string salida_datos = ""; // muestra el resultado final.

           string[] palabras_busqueda = this.txt_buscar.Text.Split(' '); // posibles palabras que el usuario digitara...

           foreach (string palabra in palabras_busqueda)
           {
              if (salida_datos.Length == 0)
              {
                 salida_datos = "( st_marca LIKE '%" + palabra + "%')";
              }
              else
              {
                 salida_datos += " AND (st_marca LIKE '%" + palabra + "%')";
              }
           }
           this.mifiltro.RowFilter = salida_datos;
        }   




    }
}
