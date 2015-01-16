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
    public partial class frm_reg_subgrupo : Form
    {
        public frm_reg_subgrupo()
        {
            InitializeComponent();
        }

        // instanciar clase validar datos...
        validar_datos v1 = new validar_datos();

        // variables.
        public int codigo;
        public String subgrupo;

        private void btn_guardar_Click(object sender, EventArgs e)
        {
           if (txt_cod_subgrupo.Text != "0")
           { 
               // editar
              if (txt_subgrupo.Text == "")
              {

                 txt_subgrupo.BackColor = Color.Aqua;
                 txt_subgrupo.Focus();
              }
              else
              {
                 txt_subgrupo.BackColor = Color.White;

                 subgrupo = txt_subgrupo.Text.ToString();
                 subgrupo = subgrupo.ToUpper();
                 subgrupo = subgrupo.Trim();

                 try
                 {
                    ProdutoSubGrupo obj = new ProdutoSubGrupo();
                    obj.Id = codigo;
                    obj.Subgrupo = subgrupo;

                    // chamando clase para gravar os dados. 
                    ProdutoSubGrupoDal editar = new ProdutoSubGrupoDal();
                    editar.alterar(obj);

                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");

                    this.Close();

                 }
                 catch (Exception erro)
                 {
                    MessageBox.Show("Error al guardar el subgrupo" + erro);
                 }
              }
           }
          
           else
           {
               // guardar

              if (txt_subgrupo.Text == "")
              {

                 txt_subgrupo.BackColor = Color.Aqua;
                 txt_subgrupo.Focus();
              }
              else
              {
                 txt_subgrupo.BackColor = Color.White;

                 subgrupo = txt_subgrupo.Text.ToString();
                 subgrupo = subgrupo.ToUpper();
                 subgrupo = subgrupo.Trim();

                 try
                 {
                    ProdutoSubGrupo obj = new ProdutoSubGrupo();
                    obj.Subgrupo = subgrupo;

                    // chamando clase para gravar os dados. 
                    ProdutoSubGrupoDal gravar = new ProdutoSubGrupoDal();
                    gravar.gravar(obj);

                    MessageBox.Show("OPERACION REALIZADA EXITOSAMENTE");

                    this.Close();
                 }
                 catch (Exception erro)
                 {
                    MessageBox.Show("Error al guardar el subgrupo" + erro);
                 }
              }

           }
        }

        public void limpar()
        {
            txt_cod_subgrupo.Text = "";
            txt_subgrupo.Text = "";
            txt_subgrupo.Focus();
        }
       

        private void txt_cod_subgrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            v1.solonumeros(e);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void frm_reg_subgrupo_Load(object sender, EventArgs e)
        {
           txt_cod_subgrupo.Text = Convert.ToString(codigo);
           txt_subgrupo.Text = Convert.ToString(subgrupo);
        }

        private void txt_subgrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (e.KeyChar == Convert.ToChar(Keys.Enter))
           {
              btn_guardar.Focus();
           }
        }
    }
}
