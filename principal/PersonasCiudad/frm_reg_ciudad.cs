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
    public partial class frm_reg_ciudad : Form
    {
        public frm_reg_ciudad()
        {
            InitializeComponent();
        }
        
        // Variables
        public int codigo;
        public String ciudad;

        // instanciar clase validar datos.
        validar_datos v1 = new validar_datos();
       
        private void btn_guardar_Click(object sender, EventArgs e)
        {
           /*  SI CLICAR NO BOTAO GUARDAR VAI NO ELSE QUE GUARDA OS DATOS Y SI CLICAR NO BOTAO EDITAR VAI NO PRIMERO IF. 
            * O QUE DEFINE E SI GUARDAR == 0 Y EDITAR != 0;
            * 
            */
           if (txt_cod_ciudad.Text != "0")
           {

                      // MessageBox.Show("TEM NUMERO");
                      txt_ciudad.BackColor = Color.White;

                      try
                      {
                         codigo = Convert.ToInt32(txt_cod_ciudad.Text);
                         
                         ciudad = txt_ciudad.Text.ToString();
                         ciudad = ciudad.ToUpper();
                         ciudad = ciudad.Trim();

                         
                         CiudadDal obj_ciudad = new CiudadDal();
                         obj_ciudad.Id = codigo;
                         obj_ciudad.Nombre = ciudad;
                          
                          CiudadDal edita = new CiudadDal();
                          edita.alterar_Ciudad(obj_ciudad);
                    
                          // MessageBox.Show("OPERACION EXITOSA");
                         
                         // FECHA Y ABRE NOVAMENTE O FORMULARIO...
                         this.Close();
                         frm_tabla_ciudad fr = new frm_tabla_ciudad();
                         fr.Show();
                         
                      }
                      catch (Exception erro)
                      {
                          MessageBox.Show("ERROR AL EDITAR LA CIUDAD" + erro);
                      }
            }
           else
           { 
                    //MessageBox.Show("ZERO");


                  if (txt_ciudad.Text == "")
                  {

                      txt_ciudad.BackColor = Color.Aqua;
                      txt_ciudad.Focus();
                  }
                  else
                  {
                      txt_ciudad.BackColor = Color.White;

                      try
                      {
                          ciudad = txt_ciudad.Text.ToString();
                          ciudad = ciudad.ToUpper();
                          ciudad = ciudad.Trim();

                          CiudadDal objeto = new CiudadDal();
                          objeto.Nombre = ciudad;
                          //modelo_datos obj_ciudad = new modelo_datos();
                          //obj_ciudad.Ciudad = ciudad;


                          CiudadDal gravar = new CiudadDal();
                          gravar.gravar_Ciudad(objeto);
                    
                          // chamando clase para gravar os dados. 
                          //conexao_datos gravar_ciudad = new conexao_datos();
                          //gravar_ciudad.grava_datos_ciudad(obj_ciudad);

                         // MessageBox.Show("OPERACION EXITOSA");
                         
                         // FECHA Y ABRE NOVAMENTE O FORMULARIO...
                         this.Close();
                         frm_tabla_ciudad fr = new frm_tabla_ciudad();
                         fr.Show();
                      }
                      catch (Exception erro)
                      {
                          MessageBox.Show("ERROR AL GUARDAR LA CIUDAD" + erro);
                      }
                  }
            }
         }

        public void limpar()
        {
            txt_cod_ciudad.Text = "";
            txt_ciudad.Text = "";
            txt_ciudad.Focus();
        }
       
        private void txt_cod_ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            v1.solonumeros(e);
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            frm_tabla_ciudad fr = new frm_tabla_ciudad();
            fr.Show();
            this.Hide();
        }

        private void frm_reg_ciudad_Load(object sender, EventArgs e)
        {
           
           txt_cod_ciudad.Text = codigo.ToString();
           txt_ciudad.Text = ciudad;

        }

        private void txt_ciudad_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              btn_guardar.Focus();
           }
        }
    }
}
