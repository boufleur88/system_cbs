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
    public partial class frm_tabla_marca : Form
    {
        public frm_tabla_marca()
        {
            InitializeComponent();
        }

       // VARIABLES
        String buscar;
        public DataGridViewContentAlignment Alignment { get; set; }

        public void atualiza_tabla()
        {
           ProdutoMarcaDal listar = new ProdutoMarcaDal();
           dt_lista_marca.DataSource = listar.listar();

           dt_lista_marca.Columns["id_marca"].HeaderText = "CODIGO";
           dt_lista_marca.Columns["st_marca"].HeaderText = "MARCA";
        }
        
        private void frm_tabla_marca_Load(object sender, EventArgs e)
        {
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

                 // this.Close();

                 frm_reg_marca obj = new frm_reg_marca();
                 obj.codigo = codigo;
                 obj.marca = marca;

                 obj.ShowDialog();

              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
           }
        }
        

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frm_reg_marca marca = new frm_reg_marca();
            marca.ShowDialog();
            
            btn_buscar.Focus();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           editar_datos();

           btn_buscar.Focus();
        }

        private void dt_lista_marca_DoubleClick(object sender, EventArgs e)
        {
           editar_datos();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           int codigo;

           try
           {
              if (dt_lista_marca.SelectedRows.Count == 1)
              {

                 codigo = Convert.ToInt32(dt_lista_marca.CurrentRow.Cells[0].Value);

                 MessageBox.Show("SEGURO QUE QUIERES ELIMINAR EL REGISTRO NUMERO " + codigo);

                 ProdutoMarca obj = new ProdutoMarca();
                 obj.codigo = codigo;

                 ProdutoMarcaDal excluir = new ProdutoMarcaDal();
                 excluir.excluir(obj);
                 
                 btn_buscar.Focus();
              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERRO AL EXCLUIR MARCA" + erro);
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

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
           // verificar si el usuario preciono la tecla enter.
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              btn_buscar.Focus();
           }
        }

        private void btn_nuevo_Leave(object sender, EventArgs e)
        {
           atualiza_tabla();
        }

        private void button1_Leave(object sender, EventArgs e)
        {
           atualiza_tabla();
        }

        private void btn_excluir_Leave(object sender, EventArgs e)
        {
           atualiza_tabla();
        }   
    }
}
