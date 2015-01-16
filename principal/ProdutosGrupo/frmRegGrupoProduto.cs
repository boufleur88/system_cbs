using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace cbs_sistema
{
   public partial class frmRegGrupoProduto : Form
   {
      public frmRegGrupoProduto()
      {
         InitializeComponent();
      }

      // instanciar clase validar datos...
      validar_datos v1 = new validar_datos();

      // VARIABLE
      public int codigo;
      public String grupo;

      private void frmRegGrupoProduto_Load(object sender, EventArgs e)
      {
         txt_cod_grupo.Text = Convert.ToString(codigo);
         txt_grupo.Text = Convert.ToString(grupo);
      }

      private void btn_salir_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void btn_guardar_Click(object sender, EventArgs e)
      {
         if (txt_cod_grupo.Text != "0")
         {
            // ALTERA           
            if (txt_grupo.Text == "")
            {
               txt_grupo.BackColor = Color.Aqua;
               txt_grupo.Focus();
            }
            else
            {
               txt_grupo.BackColor = Color.White;

               grupo = txt_grupo.Text.ToString();
               grupo = grupo.ToUpper();
               grupo = grupo.Trim();

               try
               {
                      NpgsqlConnection conexion = Servidor.conectar();
                
                      NpgsqlCommand sql = new NpgsqlCommand("select * from st_grupo where st_grupo ='"+grupo+"'", conexion);
               
                      NpgsqlDataReader leer_datos = sql.ExecuteReader();

                      if (leer_datos.Read())
                      {
                         MessageBox.Show("YA EXISTE ESTE REGISTRO");
                         txt_grupo.Focus();

                         conexion.Close();
                      }
                      else
                      {
                         conexion.Close();

                         GrupoProduto obj = new GrupoProduto();
                         obj.Id = codigo;
                         obj.Grupo = grupo;

                         GrupoProdutoDal editar = new GrupoProdutoDal();
                         editar.alterar(obj);


                         MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");

                         this.Close();
                      }
               }
               catch (Exception erro)
               {
                  MessageBox.Show("Error al guardar ciudad" + erro);
               }
            }
         }
         else
         {
            // GRAVAR
            if (txt_grupo.Text == "")
            {
               txt_grupo.BackColor = Color.Aqua;
               txt_grupo.Focus();
            }
            else
            {
               txt_grupo.BackColor = Color.White;

               grupo = txt_grupo.Text.ToString();
               grupo = grupo.ToUpper();
               grupo = grupo.Trim();

               try
               {
                      NpgsqlConnection conexion = Servidor.conectar();
                
                      NpgsqlCommand sql = new NpgsqlCommand("select * from st_grupo where st_grupo ='"+grupo+"'", conexion);
               
                      NpgsqlDataReader leer_datos = sql.ExecuteReader();

                      if (leer_datos.Read())
                      {
                         MessageBox.Show("YA EXISTE ESTE REGISTRO");
                         txt_grupo.BackColor = Color.Aqua;
                         txt_grupo.Focus();

                         conexion.Close();
                      }
                      else
                      {
                         conexion.Close();

                         txt_grupo.BackColor = Color.White;

                         GrupoProduto obj = new GrupoProduto();
                         obj.Grupo = grupo;

                         GrupoProdutoDal gravar = new GrupoProdutoDal();
                         gravar.gravar(obj);


                         MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");

                         this.Close();
                      }
               }
               catch (Exception erro)
               {
                  MessageBox.Show("Error al guardar ciudad" + erro);
               }
            }
         }
      }

      private void txt_grupo_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == Convert.ToChar(Keys.Enter))
         {
            btn_guardar.Focus();
         }
      }
   }
}
