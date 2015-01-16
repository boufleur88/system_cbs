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
    public partial class frm_tabla_subgrupo : Form
    {
        public frm_tabla_subgrupo()
        {
            InitializeComponent();
        }

       // VARIABLES.
        String buscar;
        public DataGridViewContentAlignment Alignment { get; set; }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_tabla_subgrupo_Load(object sender, EventArgs e)
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

        public void atualiza_tabla()
        {
           ProdutoSubGrupoDal listar = new ProdutoSubGrupoDal();
           dt_lista_subgrupo.DataSource = listar.listar();

           dt_lista_subgrupo.Columns["id_subgrupo"].HeaderText = "CODIGO";
           
           dt_lista_subgrupo.Columns["st_subgrupo"].HeaderText = "SUBGRUPO";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frm_reg_subgrupo sub_grupo = new frm_reg_subgrupo();
            sub_grupo.ShowDialog();

            btn_buscar.Focus();
            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           int codigo;

           try
           {
              if (dt_lista_subgrupo.SelectedRows.Count == 1)
              {

                 codigo = Convert.ToInt32(dt_lista_subgrupo.CurrentRow.Cells[0].Value);

                 MessageBox.Show("SEGURO QUE QUIERES ELIMINAR EL REGISTRO NUMERO " + codigo);

                 ProdutoSubGrupo obj = new ProdutoSubGrupo();
                 obj.Id = codigo;

                 ProdutoSubGrupoDal excluir = new ProdutoSubGrupoDal();
                 excluir.excluir(obj);

                 btn_buscar.Focus();
              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
           }
        }

        private void editar_datos()
        {
           int codigo;
           string subgrupo;

           try
           {
              if (dt_lista_subgrupo.SelectedRows.Count == 1)
              {
                 codigo = Convert.ToInt32(dt_lista_subgrupo.CurrentRow.Cells[0].Value);
                 subgrupo = Convert.ToString(dt_lista_subgrupo.CurrentRow.Cells[1].Value);
                 
                 frm_reg_subgrupo obj = new frm_reg_subgrupo();
                 obj.codigo = codigo;
                 obj.subgrupo = subgrupo;

                 obj.ShowDialog();

              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
           }
        }

        

        private void dt_lista_subgrupo_DoubleClick(object sender, EventArgs e)
        {
           editar_datos();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           buscar = txt_buscar.Text.ToString();
           buscar = buscar.Trim();

           ProdutoSubGrupoDal lista = new ProdutoSubGrupoDal();
           dt_lista_subgrupo.DataSource = lista.Buscar(buscar);
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              btn_buscar.Focus();
           }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           editar_datos();

           btn_buscar.Focus();
        }

        private void btn_nuevo_Leave(object sender, EventArgs e)
        {
           atualiza_tabla();
        }

        private void btnAlterar_Leave(object sender, EventArgs e)
        {
           atualiza_tabla();
        }

        private void btn_excluir_Leave(object sender, EventArgs e)
        {
           atualiza_tabla();
        }

    }
}
