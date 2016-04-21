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
    public partial class frm_control_usuario : Form
    {
        public frm_control_usuario()
        {
            InitializeComponent();
        }

        private void frm_control_usuario_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
           Application.Exit(); 
           // Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            bool ativo = false;
            

            // crear conexao con o banco. nombre banco = cbs_master
            String conexao_banco = "Server=localhost; Port=5432; User id=postgres; Password=kikiu159; Database=cbs_master";
            NpgsqlConnection conexao = null;
            // funcao para conectar con o banco de datos.
            
                try
                {
                    int x = 0;
                    conexao = new NpgsqlConnection(conexao_banco);
                    conexao.Open();
                    NpgsqlCommand validar_usuarios = new NpgsqlCommand("SELECT * FROM usuarios WHERE user_usuario='" + txt_usuario.Text + "'AND user_clave='" + txt_clave.Text + "'", conexao);

                    NpgsqlDataReader leer_datos = validar_usuarios.ExecuteReader();
                    if (leer_datos.Read())
                    {
                        ativo = true;
                        frm_principal principal = new frm_principal();
                        
                        principal.Show();
                        this.Hide();
                        x++;
                    }
                    else
                    {
                        if (x > 2)
                        {
                            if (ativo == false)
                                MessageBox.Show("Este usuario no existe, por favor volver a intentar!!!" + x);
                            x++;
                        }
                    }
                }
        

                catch (Exception error)
                {
                    throw error;
                }
                finally
                {
                    conexao.Close();
                }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
           // verificar si el usuario preciono la tecla enter.
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              txt_clave.Focus();
           }
        }

        private void txt_clave_KeyPress(object sender, KeyPressEventArgs e)
        {
           // verificar si el usuario preciono la tecla enter.
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              btn_guardar.Focus();
           }
        }
    }
}
