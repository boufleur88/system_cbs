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
    public partial class frm_tabla_grupo_per : Form
    {
        public frm_tabla_grupo_per()
        {
            InitializeComponent();
        }

        string buscar;

        private void frm_tabla_grupo_per_Load(object sender, EventArgs e)
        {
            try
            {
               GrupoPersonaDal listar = new GrupoPersonaDal();
               dt_lista_grupo_per.DataSource = listar.lista_grupo_per();

               formata_tabla();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al cargar los datos." + error);
            }
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frm_reg_grupo_persona fr = new frm_reg_grupo_persona();
            fr.Show();
            this.Hide();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
           editar_datos();
        }

        private void formata_tabla()
        {
           // FORMATEA EL DATATABLE
           dt_lista_grupo_per.Columns["id_grupo"].HeaderText = "CODIGO";
           dt_lista_grupo_per.Columns["per_grupo"].HeaderText = "GRUPO";
           
        }

        // FUNCAO PARA ALTERAR DATOS...
        private void editar_datos()
        {
           int codigo;
           string grupo;

           try
           {
              if (dt_lista_grupo_per.SelectedRows.Count == 1)
              {
                 codigo = Convert.ToInt32(dt_lista_grupo_per.CurrentRow.Cells[0].Value);
                 grupo = Convert.ToString(dt_lista_grupo_per.CurrentRow.Cells[1].Value);

                 this.Close();

                 frm_reg_grupo_persona obj = new frm_reg_grupo_persona();
                 obj.codigo = codigo;
                 obj.grupo = grupo;

                 obj.Show();
              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
           }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           int codigo;

           try
           {
              if (dt_lista_grupo_per.SelectedRows.Count == 1)
              {

                 codigo = Convert.ToInt32(dt_lista_grupo_per.CurrentRow.Cells[0].Value);

                 MessageBox.Show("SEGURO QUE QUIERES ELIMINAR EL REGISTRO NUMERO " + codigo);

                 GrupoPersonaDal obj = new GrupoPersonaDal();
                 obj.id_grupo_per = codigo;

                 GrupoPersonaDal excluir = new GrupoPersonaDal();
                 excluir.excluir(obj);

                 this.Close();

                 frm_tabla_grupo_per fr = new frm_tabla_grupo_per();
                 fr.Show();

              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERROR AL ELIMINAR CIUDAD" + erro);
           }
        }

       
        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
           buscar = txt_buscar.Text.ToString();
           buscar = buscar.Trim();

           GrupoPersonaDal lista = new GrupoPersonaDal();
           dt_lista_grupo_per.DataSource = lista.Buscar(buscar);
        }

        private void dt_lista_grupo_per_DoubleClick(object sender, EventArgs e)
        {
           editar_datos();
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
           btn_buscar.Focus();
        }

        

    }
}
