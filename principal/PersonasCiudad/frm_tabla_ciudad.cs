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
    public partial class frm_tabla_ciudad : Form
    {
        public frm_tabla_ciudad()
        {
            InitializeComponent();
        }
       // VARIABLES
        string buscar;

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_tabla_ciudad_Load(object sender, EventArgs e)
        {
           
            try
            {
               CiudadDal _lista = new CiudadDal();
               dt_lista_ciudad.DataSource = _lista.lista_ciudad();

               formata_tabla();

               
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al cargar los datos." + error);
            }
           
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {

            frm_reg_ciudad grupo = new frm_reg_ciudad();
            grupo.Show();
            this.Hide();
        }

       // FUNCAO PARA ALTERAR DATOS...
         private void editar_datos()
          {
             int codigo;
             string ciudad;
             
             try
             {
                if (dt_lista_ciudad.SelectedRows.Count == 1)
                {
                   codigo = Convert.ToInt32(dt_lista_ciudad.CurrentRow.Cells[0].Value);
                   ciudad = Convert.ToString(dt_lista_ciudad.CurrentRow.Cells[1].Value);

                   this.Close();

                   frm_reg_ciudad obj_ciudad = new frm_reg_ciudad();
                   obj_ciudad.codigo = codigo;
                   obj_ciudad.ciudad = ciudad;

                   obj_ciudad.Show();
                }
             }
             catch (Exception erro)
             {
                MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
             }
          }

       private void formata_tabla()
       {
            // FORMATEA EL DATATABLE
            dt_lista_ciudad.Columns["id_ciudad"].HeaderText = "CODIGO";
            dt_lista_ciudad.Columns["per_ciudad"].HeaderText = "CIUDAD";

       }

        private void btn_alterar_Click(object sender, EventArgs e)
        {

           editar_datos();
           
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
           buscar = txt_buscar.Text.ToString();
           buscar = buscar.Trim();

           if (txt_buscar.Text == "")
           {
              CiudadDal lista = new CiudadDal();
              dt_lista_ciudad.DataSource = lista.lista_ciudad();
           }
           else 
           { 
              CiudadDal lista = new CiudadDal();
              dt_lista_ciudad.DataSource = lista.buscar(buscar);
           }

        }

       // EXCLUIR CIUDAD...
        private void btn_excluir_Click(object sender, EventArgs e)
        {
           int codigo;

           try
           {
              if (dt_lista_ciudad.SelectedRows.Count == 1)
              {
                 
                 codigo = Convert.ToInt32(dt_lista_ciudad.CurrentRow.Cells[0].Value);

                 MessageBox.Show("SEGURO QUE QUIERES ELIMINAR EL REGISTRO NUMERO "+codigo);

                 CiudadDal obj_ciudad = new CiudadDal();
                 obj_ciudad.Id = codigo;

                 CiudadDal excluir = new CiudadDal();
                 excluir.excluir_ciudad(obj_ciudad);

                 this.Close();

                 frm_tabla_ciudad fr = new frm_tabla_ciudad();
                 fr.Show();

              }
           }
           catch (Exception erro)
           {
              MessageBox.Show("ERROR AL ELIMINAR CIUDAD" + erro);
           }
        }

        private void dt_lista_ciudad_DoubleClick(object sender, EventArgs e)
        {
           editar_datos();
        }

        private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              btn_buscar.Focus();
           }
        }

       

        /*
         * EVENTOS CON DATAGRID.
        // doble click sobre el encabezado de la fila. 
        private void dt_lista_ciudad_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("RowHeaderMouseDoubleClick = doble click sobre el encabezado de la fila");
        }

        // doble click sobre el encabezado de la fila.
        private void dt_lista_ciudad_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("RowHeaderMouseClick = doble click dentro de los limites de la fila");
        }
         * Estos eventos son muy similares con al diferencias que uno es un click y el otro es doble click.
         * 
         * 
        // No he encontrado mucha utlidad en este evento, ocurre cuando click en el divisor de la fila
        private void dt_lista_ciudad_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            MessageBox.Show("RowDividerDoubleClick = Click en el divisor de las filas");
        }
         
        EVENTOS CON MOUSE.
        // Interesante. este evento ocurre cuando el user click en el componente. MouseHover, MouseLeave, MouseMove, MouseDown, MouseEnter etc...
        private void dt_lista_ciudad_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("MouseUp = ocurre cuando suelta el raton del componente");
        }
        
        private void dt_lista_ciudad_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("CellMouseUp = Suelta el mouse en una celda");
        }

        private void dt_lista_ciudad_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            MessageBox.Show("CellMouseDoubleClick = Double Click en una celda.");
        }
         */
    }
}
