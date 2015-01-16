using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace sistema_cbs
{
    public partial class frm_reg_marca : Form
    {
        public frm_reg_marca()
        {
            InitializeComponent();
        }

        // instanciar clase validar datos...
        validar_datos v1 = new validar_datos();

        // variables
        public int codigo; 
        public String marca;

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
                         ProdutoMarca obj = new ProdutoMarca();
                         obj.codigo = codigo;
                         obj.marca = marca;

                          // chamando clase para gravar os dados. 
                          ProdutoMarcaDal editar = new ProdutoMarcaDal();
                          editar.alterar(obj);

                          MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");
                          
                         this.Close();
                         
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
                         ProdutoMarca obj = new ProdutoMarca();
                         obj.marca = marca;

                         // chamando clase para gravar os dados. 
                         ProdutoMarcaDal gravar = new ProdutoMarcaDal();
                         gravar.gravar(obj);

                          MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");

                         this.Close();
                      }
                      catch (Exception erro)
                      {
                          MessageBox.Show("ERROR AL GUARDA LA MARCA" + erro);
                      }
                  }
           }
        }


        public void limpar()
        {
            txt_cod_marca.Text = "";
            txt_marca.Text = "";
            txt_marca.Focus();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
           this.Close();
           // frm_tabla_marca fr = new frm_tabla_marca();
           // fr.Show();
           // this.Hide();

        }

        private void txt_cod_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            v1.solonumeros(e);
        }

        private void frm_reg_marca_Load(object sender, EventArgs e)
        {
                      
           txt_cod_marca.Text = Convert.ToString(codigo);
           txt_marca.Text = Convert.ToString(marca);
        }

        private void txt_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              btn_guardar.Focus();
           }
        }

        private void btn_guardar_Leave(object sender, EventArgs e)
        {
           
        }
    }
}
