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
    public partial class frm_tabla_grupo : Form
    {
        public frm_tabla_grupo()
        {
            InitializeComponent();
        }

       // VARIABLES.
        String buscar;
        public DataGridViewContentAlignment Alignment { get; set; }

        private void frm_tabla_grupo_Load(object sender, EventArgs e)
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

       // Funcion para actualizar la tabla Grupos.
        public void atualiza_tabla()
        {
           GrupoProdutoDal lista = new GrupoProdutoDal();
           dt_lista_grupo.DataSource = lista.listar();

           dt_lista_grupo.Columns["id_grupo"].HeaderText = "CODIGO";
           dt_lista_grupo.Columns["id_grupo"].Width = 60;
           dt_lista_grupo.Columns["st_grupo"].HeaderText = "GRUPO";
           dt_lista_grupo.Columns["st_grupo"].Width = 280;

        }

       // Cuando abre el formulario para registro de grupo, cambia el focus del boton nuevo para el boton buscar, para que logre ejecutar el evente leave del bonton nuevo donde cargar nuevamente la lista.
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
           frm_reg_grupo grupo = new frm_reg_grupo();
           grupo.ShowDialog();

           btn_buscar.Focus();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        private void editar_datos()
        {
           int codigo;
           string grupo;

           try
           {
              if (dt_lista_grupo.SelectedRows.Count == 1)
              {
                 codigo = Convert.ToInt32(dt_lista_grupo.CurrentRow.Cells[0].Value);
                 grupo = Convert.ToString(dt_lista_grupo.CurrentRow.Cells[1].Value);

                 // this.Close();

                 frm_reg_grupo obj = new frm_reg_grupo();
                 obj.codigo = codigo;
                 obj.grupo = grupo;

                 obj.ShowDialog();
                 
              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
           }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           editar_datos();

           btn_buscar.Focus();
        }

        private void dt_lista_grupo_DoubleClick(object sender, EventArgs e)
        {
           editar_datos();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           int codigo;

           try
           {
              if (dt_lista_grupo.SelectedRows.Count == 1)
              {

                 codigo = Convert.ToInt32(dt_lista_grupo.CurrentRow.Cells[0].Value);

                 MessageBox.Show("SEGURO QUE QUIERES ELIMINAR EL REGISTRO NUMERO " + codigo);

                 GrupoProduto obj = new GrupoProduto();
                 obj.Id = codigo;

                 GrupoProdutoDal excluir = new GrupoProdutoDal();
                 excluir.excluir(obj);

                 btn_buscar.Focus();

                 // this.Close();

              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
           }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           buscar = txt_buscar.Text.ToString();
           buscar = buscar.Trim();

           GrupoProdutoDal lista = new GrupoProdutoDal();
           dt_lista_grupo.DataSource = lista.Buscar(buscar);
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
