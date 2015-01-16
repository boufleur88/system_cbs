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
    public partial class frm_reg_grupo_persona : Form
    {
        public frm_reg_grupo_persona()
        {
            InitializeComponent();
        }

        // instanciar clase validar datos...
        validar_datos v1 = new validar_datos();

        // Variables
        String subgrupoper;
        public string grupo;
        public int codigo;

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           if (txt_cod_grupo.Text != "0")
           {
              // aqui o sistema edita o registro...
              if (txt_grupo.Text == "")
              {

                 txt_grupo.BackColor = Color.Aqua;
                 txt_grupo.Focus();
              }
              else
              {

                 codigo = Convert.ToInt32(txt_cod_grupo.Text);

                 txt_cod_grupo.BackColor = Color.White;

                 subgrupoper = txt_grupo.Text.ToString();
                 subgrupoper = subgrupoper.ToUpper();
                 subgrupoper = subgrupoper.Trim();

                 try
                 {
                    GrupoPersonaDal obj = new GrupoPersonaDal();
                    obj.id_grupo_per = codigo;
                    obj.nombre = subgrupoper;

                    // chamando clase para gravar os dados. 
                    GrupoPersonaDal editar = new GrupoPersonaDal();
                    editar.alterar(obj);

                    // MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");

                    // FECHA O FORMULARIO Y CARREGA NOVAMENTE.
                    this.Close();
                    frm_tabla_grupo_per fr = new frm_tabla_grupo_per();
                    fr.Show();
                 }
                 catch (Exception erro)
                 {
                    MessageBox.Show("ERROR AL GUARDAR EL GRUPO" + erro);
                 }
              }
           }
           else
           {
              // aqui o sistema cria um novo registro... 
              if (txt_grupo.Text == "")
              {

                 txt_grupo.BackColor = Color.Aqua;
                 txt_grupo.Focus();
              }
              else
              {
                 txt_cod_grupo.BackColor = Color.White;

                 subgrupoper = txt_grupo.Text.ToString();
                 subgrupoper = subgrupoper.ToUpper();
                 subgrupoper = subgrupoper.Trim();

                 try
                 {
                    GrupoPersonaDal obj = new GrupoPersonaDal();
                    obj.nombre = subgrupoper;

                    // chamando clase para gravar os dados. 
                    GrupoPersonaDal gravar_grupo = new GrupoPersonaDal();
                    gravar_grupo.gravar(obj);

                    // MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");

                    // FECHA O FORMULARIO Y CARREGA NOVAMENTE.
                    this.Close();
                    frm_tabla_grupo_per fr = new frm_tabla_grupo_per();
                    fr.Show();


                 }
                 catch (Exception erro)
                 {
                    MessageBox.Show("ERROR AL GUARDAR EL GRUPO" + erro);
                 }
              }
           }
        }

        public void limpar()
        {
            txt_cod_grupo.Text = "";
            txt_grupo.Text = "";
            txt_grupo.Focus();
        }


        private void btn_alterar_Click(object sender, EventArgs e)
        {
            frm_tabla_grupo_per fr = new frm_tabla_grupo_per();
            fr.Show();
            this.Hide();
        }

        private void txt_cod_grupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v1.solonumeros(e);
        }

        private void frm_reg_grupo_persona_Load(object sender, EventArgs e)
        {
           txt_cod_grupo.Text = codigo.ToString();
           txt_grupo.Text = grupo;
           
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
