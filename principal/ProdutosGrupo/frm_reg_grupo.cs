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
    public partial class frm_reg_grupo : Form
    {
        public frm_reg_grupo()
        {
            InitializeComponent();
        }

        // instanciar clase validar datos...
        validar_datos v1 = new validar_datos();

        // VARIABLE
       public int codigo; 
       public String grupo;

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
                    GrupoProduto obj = new GrupoProduto();
                    obj.Id = codigo;
                    obj.Grupo = grupo;

                    GrupoProdutoDal editar = new GrupoProdutoDal();
                    editar.alterar(obj);


                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");

                    this.Close();
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
                    GrupoProduto obj = new GrupoProduto();
                    obj.Grupo = grupo;

                    GrupoProdutoDal gravar = new GrupoProdutoDal();
                    gravar.gravar(obj);


                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");

                    this.Close();
                 }
                 catch (Exception erro)
                 {
                    MessageBox.Show("Error al guardar ciudad" + erro);
                    
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

        

        private void txt_cod_grupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v1.solonumeros(e);
        }

        private void frm_reg_grupo_Load(object sender, EventArgs e)
        {
           txt_cod_grupo.Text = Convert.ToString(codigo);
           txt_grupo.Text = Convert.ToString(grupo);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

       
    }
}
