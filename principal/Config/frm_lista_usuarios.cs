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
    public partial class frm_lista_usuarios : Form
    {
        public frm_lista_usuarios()
        {
            InitializeComponent();
        }


        // instanciar clase validar datos...
        validar_datos v1 = new validar_datos();

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            frm_registro_usuario usuarios = new frm_registro_usuario();
            usuarios.Show();
        }

        private void frm_lista_usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                conexao_datos conectar_lista_user = new conexao_datos();
                dt_lista_usuarios.DataSource = conectar_lista_user.lista_usuarios();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error al cargar los datos."+error);
            
            }

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            frm_principal principal = new frm_principal();
            principal.Show();
            this.Hide();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            modelo_datos obj_usuario = new modelo_datos();
            obj_usuario.codigo = txt_codigo.Text.ToString();
            
            // chamando clase para gravar os dados. 
            conexao_datos excluir_usuarios = new conexao_datos();
            excluir_usuarios.excluir_usuario(obj_usuario);

            // CAREGAR DATOS
           
            conexao_datos conectar_lista_user = new conexao_datos();
            dt_lista_usuarios.DataSource = conectar_lista_user.lista_usuarios();
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // chava funcao solonumeros da clase validar datos...
            v1.solonumeros(e);
        }
    }
}
