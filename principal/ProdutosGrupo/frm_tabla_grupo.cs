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
    public partial class frm_tabla_grupo : Form
    {
        public frm_tabla_grupo()
        {
            InitializeComponent();
        }

       // VARIABLES.
        String buscar;
        public DataGridViewContentAlignment Alignment { get; set; }

        DataSet resultado = new DataSet();
        DataView mifiltro;

        private void frm_tabla_grupo_Load(object sender, EventArgs e)
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

       // Funcion para actualizar la tabla Grupos.
        public void atualiza_tabla()
        {
           GrupoProdutoDal listar = new GrupoProdutoDal();
           listar.Buscar_datos("select id_grupo, st_grupo from st_grupo order by id_grupo", ref resultado, "st_grupo");

           this.mifiltro = ((DataTable)resultado.Tables["st_grupo"]).DefaultView;

           this.dt_lista_grupo.DataSource = mifiltro;

           dt_lista_grupo.Columns["id_grupo"].HeaderText = "CODIGO";
           dt_lista_grupo.Columns["id_grupo"].Width = 80;
           dt_lista_grupo.Columns["st_grupo"].HeaderText = "GRUPO";
           dt_lista_grupo.Columns["st_grupo"].Width = 380;

           /* metodo antigo de buscar 
           GrupoProdutoDal lista = new GrupoProdutoDal();
           dt_lista_grupo.DataSource = lista.listar();

           dt_lista_grupo.Columns["id_grupo"].HeaderText = "CODIGO";
           dt_lista_grupo.Columns["st_grupo"].HeaderText = "GRUPO";
            * */
        }

       // Cuando abre el formulario para registro de grupo, cambia el focus del boton nuevo para el boton buscar, para que logre ejecutar el evente leave del bonton nuevo donde cargar nuevamente la lista.
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
           this.Close();

           frm_reg_grupo grupo = new frm_reg_grupo();
           grupo.Show();

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

                 this.Close();

                 frm_reg_grupo obj = new frm_reg_grupo();
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           editar_datos();

           this.Close();
        }

        private void dt_lista_grupo_DoubleClick(object sender, EventArgs e)
        {
           editar_datos();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
           if (MessageBox.Show("ELIMINAR REGISTROS", "ELIMINAR", MessageBoxButtons.OKCancel) == DialogResult.OK)
           {

              int codigo;

              if (dt_lista_grupo.SelectedRows.Count == 1)
              {

                 codigo = Convert.ToInt32(dt_lista_grupo.CurrentRow.Cells[0].Value);

                 MessageBox.Show("SEGURO QUE QUIERES ELIMINAR EL REGISTRO NUMERO " + codigo);

                 GrupoProduto obj = new GrupoProduto();
                 obj.Id = codigo;

                 this.Close();
                 frm_tabla_grupo fr = new frm_tabla_grupo();
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

        private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
           string salida_datos = ""; // muestra el resultado final.

           string[] palabras_busqueda = this.txt_buscar.Text.Split(' '); // posibles palabras que el usuario digitara...

           foreach (string palabra in palabras_busqueda)
           {
              if (salida_datos.Length == 0)
              {
                 salida_datos = "( st_grupo LIKE '%" + palabra + "%')";
              }
              else
              {
                 salida_datos += " AND (st_grupo LIKE '%" + palabra + "%')";
              }
           }

           this.mifiltro.RowFilter = salida_datos;

        }   



    }
}
