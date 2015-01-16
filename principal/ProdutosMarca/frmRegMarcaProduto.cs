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
   public partial class frmRegMarcaPersonas : Form
   {
      public frmRegMarcaPersonas()
      {
         InitializeComponent();

      }

      // instanciar clase validar datos...
      validar_datos v1 = new validar_datos();

      // variables
      public int codigo;
      public String marca;


      private void btn_alterar_Click(object sender, EventArgs e)
      {
         this.Close();
      }

      private void btn_guardar_Click(object sender, EventArgs e)
      {

         if (txt_cod_marca.Text != "0")
         {
            // editar
            if (txt_marca.Text == "")
            {
               txt_marca.BackColor = Color.Aqua;
               txt_marca.Focus();
            }
            else
            {
               txt_marca.BackColor = Color.White;

               marca = txt_marca.Text.ToString();
               marca = marca.ToUpper();
               marca = marca.Trim();

               try
               {
                  NpgsqlConnection conexion = Servidor.conectar();
                   
                         NpgsqlCommand sql = new NpgsqlCommand("select * from st_marca where st_marca ='"+marca+"'", conexion);

                         NpgsqlDataReader leer_datos = sql.ExecuteReader();

                         if (leer_datos.Read())
                         {
                            MessageBox.Show("Esta Marca ya existe");
                            txt_marca.BackColor = Color.Aqua;
                            txt_marca.Focus();

                            conexion.Close();
                         }
                         else
                         {
                            conexion.Close();

                            txt_marca.BackColor = Color.White;

                            ProdutoMarca obj = new ProdutoMarca();
                            obj.codigo = codigo;
                            obj.marca = marca;

                            // chamando clase para gravar os dados. 
                            ProdutoMarcaDal editar = new ProdutoMarcaDal();
                            editar.alterar(obj);

                            MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");

                            this.Close();
                         }

               }
               catch (Exception erro)
               {
                  MessageBox.Show("ERROR AL GUARDA LA MARCA" + erro);
               }
            }
         }
         else
         {
            // guardar
            if (txt_marca.Text == "")
            {
               txt_marca.BackColor = Color.Aqua;
               txt_marca.Focus();
            }
            else
            {
               txt_marca.BackColor = Color.White;

               marca = txt_marca.Text.ToString();
               marca = marca.ToUpper();
               marca = marca.Trim();

               try
               {
                  NpgsqlConnection conexion = Servidor.conectar();
                   
                         NpgsqlCommand sql = new NpgsqlCommand("select * from st_marca where st_marca ='"+marca+"'", conexion);

                         NpgsqlDataReader leer_datos = sql.ExecuteReader();

                         if (leer_datos.Read())
                         {
                            MessageBox.Show("Esta Marca ya existe");
                            txt_marca.BackColor = Color.Aqua;
                            txt_marca.Focus();

                            conexion.Close();
                         }
                         else
                         {
                            conexion.Close();

                            txt_marca.BackColor = Color.White;

                            ProdutoMarca obj = new ProdutoMarca();
                            obj.marca = marca;

                            // chamando clase para gravar os dados. 
                            ProdutoMarcaDal gravar = new ProdutoMarcaDal();
                            gravar.gravar(obj);

                            MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");

                            this.Close();
                         }
               }
               catch (Exception erro)
               {
                  MessageBox.Show("ERROR AL GUARDA LA MARCA" + erro);
               }
            }
         }
      }

      private void txt_marca_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == Convert.ToChar(Keys.Enter))
         {
            btn_guardar.Focus();
         }
      }

      private void frmRegMarcaPersonas_Load(object sender, EventArgs e)
      {

         txt_cod_marca.Text = Convert.ToString(codigo);
         txt_marca.Text = Convert.ToString(marca);
      }
   }
}
