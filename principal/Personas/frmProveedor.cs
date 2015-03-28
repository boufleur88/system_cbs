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
   public partial class frmProveedor : Form
   {
      public frmProveedor()
      {
         InitializeComponent();
      }

      // VARIABLES.
      string buscar;
     
     
      private void frmProveedor_Load(object sender, EventArgs e)
      {
         PersonaDal lista = new PersonaDal();
         dt_lista.DataSource = lista.lista_proveedor();

         formata_tabla();
      }

      private void formata_tabla()
      {
         // FORMATEA EL DATATABLE
         // id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_pais, per_nac
         dt_lista.Columns["id_per"].HeaderText = "CODIGO";
         dt_lista.Columns["per_nombre"].HeaderText = "NOMBRE";
         dt_lista.Columns["per_fant"].HeaderText = "FANTASIA";
         dt_lista.Columns["per_ruc"].HeaderText = "RUC";
         dt_lista.Columns["per_ci"].HeaderText = "CEDULA";
         dt_lista.Columns["per_tel1"].HeaderText = "TELEFONO";
         dt_lista.Columns["per_tel2"].HeaderText = "CELULAR";
         dt_lista.Columns["per_email"].HeaderText = "EMAIL";
         dt_lista.Columns["per_dir"].HeaderText = "DIRECCION";
         dt_lista.Columns["per_ciudad"].HeaderText = "CIUDAD";
         dt_lista.Columns["per_nac"].HeaderText = "F. NACIMIENTO";
         dt_lista.Columns["per_clt"].HeaderText = "CLIENTE";
         dt_lista.Columns["per_prov"].HeaderText = "PROVEEDOR";
         dt_lista.Columns["per_func"].HeaderText = "FUNCIONARIO";
         dt_lista.Columns["per_obs"].HeaderText = "OBSERVACION";
         dt_lista.Columns["per_obs"].Visible = false;

      }

      private void btn_salir_Click(object sender, EventArgs e)
      {
         this.Close();
      }


      // FUNCAO PARA ALTERAR DATOS...
      private void editar_datos()
      {
         int codigo;
         string nombre, fantasia, cedula, ruc, tel1, tel2, email, direccion, fnacimento, clt, prov, func, obs, ciudad;

         // per_clt, per_prov, per_func, per_obs
         try
         {
            if (dt_lista.SelectedRows.Count == 1)
            {
               codigo = Convert.ToInt32(dt_lista.CurrentRow.Cells[0].Value);
               nombre = Convert.ToString(dt_lista.CurrentRow.Cells[1].Value);
               fantasia = Convert.ToString(dt_lista.CurrentRow.Cells[2].Value);
               ruc = Convert.ToString(dt_lista.CurrentRow.Cells[3].Value);
               cedula = Convert.ToString(dt_lista.CurrentRow.Cells[4].Value);
               tel1 = Convert.ToString(dt_lista.CurrentRow.Cells[5].Value);
               tel2 = Convert.ToString(dt_lista.CurrentRow.Cells[6].Value);
               email = Convert.ToString(dt_lista.CurrentRow.Cells[7].Value);
               direccion = Convert.ToString(dt_lista.CurrentRow.Cells[8].Value);
               ciudad = Convert.ToString(dt_lista.CurrentRow.Cells[9].Value);
               fnacimento = Convert.ToString(dt_lista.CurrentRow.Cells[10].Value);
               clt = Convert.ToString(dt_lista.CurrentRow.Cells[11].Value);
               prov = Convert.ToString(dt_lista.CurrentRow.Cells[12].Value);
               func = Convert.ToString(dt_lista.CurrentRow.Cells[13].Value);
               obs = Convert.ToString(dt_lista.CurrentRow.Cells[14].Value);

               this.Close();

               frm_registro_personas obj = new frm_registro_personas();
               obj.codigo = codigo;
               obj.nombre = nombre;
               obj.fantasia = fantasia;
               obj.ruc = ruc;
               obj.cedula = cedula;
               obj.tel1 = tel1;
               obj.tel2 = tel2;
               obj.correo = email;
               obj.direccion = direccion;
               obj.ciudad = ciudad;
               obj.fnacimento = fnacimento;
               obj.clt = clt;
               obj.prov = prov;
               obj.func = func;
               obj.obs = obs;
               obj.Show();
            }
         }
         catch (Exception erro)
         {
            MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
         }
      }

      private void btn_excluir_Click(object sender, EventArgs e)
      {
         int codigo;

         try
         {
            if (dt_lista.SelectedRows.Count == 1)
            {

               codigo = Convert.ToInt32(dt_lista.CurrentRow.Cells[0].Value);

               MessageBox.Show("SEGURO QUE QUIERES ELIMINAR EL REGISTRO NUMERO " + codigo);

               PersonaDal obj = new PersonaDal();
               obj.id = codigo;

               PersonaDal excluir = new PersonaDal();
               excluir.excluir(obj);

               this.Close();

               frm_tabla_personas fr = new frm_tabla_personas();
               fr.Show();

            }
         }
         catch (Exception erro)
         {
            MessageBox.Show("ERROR AL ELIMINAR CIUDAD" + erro);
         }
      }

      private void btn_buscar_Click_1(object sender, EventArgs e)
      {
         buscar = txt_buscar.Text.ToString();
         buscar = buscar.Trim();

         PersonaDal lista = new PersonaDal();
         dt_lista.DataSource = lista.Buscar(buscar,buscar);
      }

      private void txt_buscar_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (e.KeyChar == Convert.ToChar(Keys.Enter))
         {
            btn_buscar.Focus();
         }
      }

      private void btn_alterar_Click(object sender, EventArgs e)
      {
         editar_datos();
      }

      private void btn_nuevo_Click(object sender, EventArgs e)
      {
         frm_registro_personas fr = new frm_registro_personas();
         fr.Show();
         this.Hide();
      }

      private void dt_lista_DoubleClick(object sender, EventArgs e)
      {
         buscar = txt_buscar.Text.ToString();
         buscar = buscar.Trim();

         PersonaDal lista = new PersonaDal();
         dt_lista.DataSource = lista.Buscar(buscar,buscar);
      }

      private void btn_salir_Click_1(object sender, EventArgs e)
      {
         Close();
      }

   }
}
