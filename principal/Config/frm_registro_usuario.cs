using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Npgsql;                       // adicionar com o postgresql.

namespace sistema_cbs
{
    public partial class frm_registro_usuario : Form
    {
        public frm_registro_usuario()
        {
            InitializeComponent();
        }

        // inicializar clase validar datos.
        validar_datos v1 = new validar_datos();

        private void frm_registro_usuario_Load(object sender, EventArgs e)
        {
            limpiar_datos();

        }

        public void limpiar_datos()
        {
            // Limpiar los datos del formulario.
            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_tel1.Text = "";
            txt_usuario.Text = "";
            txt_correo.Text = "";
            txt_clave1.Text = "";
            txt_clave2.Text = "";
            txt_cedula.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_clave1.Text == txt_clave2.Text)
            {
                // MessageBox.Show("Las claves son iguales");
                modelo_datos obj_usuario = new modelo_datos();
                obj_usuario.codigo = txt_codigo.Text.ToString();
                obj_usuario.nombre = txt_nombre.Text.ToString();
                obj_usuario.usuario = txt_usuario.Text.ToString();
                obj_usuario.cedula = txt_cedula.Text.ToString();
                obj_usuario.clave = txt_clave1.Text.ToString();
                obj_usuario.email = txt_correo.Text.ToString();
                obj_usuario.telefono1 = txt_tel1.Text.ToString();

                // chamando clase para gravar os dados. 
                conexao_datos gravar_usuarios = new conexao_datos();
                gravar_usuarios.grava_datos_usuarios(obj_usuario);

                MessageBox.Show("Operacion realizada con exito");
                limpiar_datos();  
            }
            else
            { 
                MessageBox.Show("Las claves no son iguales, Por favor intentan nuevamente");
                txt_clave1.Text = "";
                txt_clave2.Text = "";
                txt_clave1.Focus();
            }          
            
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_nombre.Focus();
           }
           v1.solonumeros(e);
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_usuario.Focus();
           }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_cedula.Focus();
           }
        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_tel1.Focus();
           }
           v1.solonumeros(e);
        }

        private void txt_tel1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_correo.Focus();
           }

           v1.solonumeros(e);
        }

        private void txt_correo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_clave1.Focus();
           }
        }

        private void txt_clave1_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_clave2.Focus();
           }
        }

        private void txt_clave2_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              btn_guardar.Focus();
           }
        }

       private void btn_alterar_Click(object sender, EventArgs e)
        {
          this.Close();

          frm_lista_usuarios fr = new frm_lista_usuarios();
          fr.Show();
            
        }

       private void btn_guardar_KeyPress(object sender, KeyPressEventArgs e)
       {
          if (txt_clave1.Text == txt_clave2.Text)
          {
             // MessageBox.Show("Las claves son iguales");
             modelo_datos obj_usuario = new modelo_datos();
             obj_usuario.codigo = txt_codigo.Text.ToString();
             obj_usuario.nombre = txt_nombre.Text.ToString();
             obj_usuario.usuario = txt_usuario.Text.ToString();
             obj_usuario.cedula = txt_cedula.Text.ToString();
             obj_usuario.clave = txt_clave1.Text.ToString();
             obj_usuario.email = txt_correo.Text.ToString();
             obj_usuario.telefono1 = txt_tel1.Text.ToString();

             // chamando clase para gravar os dados. 
             conexao_datos gravar_usuarios = new conexao_datos();
             gravar_usuarios.grava_datos_usuarios(obj_usuario);

             MessageBox.Show("Operacion realizada con exito");
             limpiar_datos();
          }
          else
          {
             MessageBox.Show("Las claves no son iguales, Por favor intentan nuevamente");
             txt_clave1.Text = "";
             txt_clave2.Text = "";
             txt_clave1.Focus();
          }  
       }

       
    }
}
