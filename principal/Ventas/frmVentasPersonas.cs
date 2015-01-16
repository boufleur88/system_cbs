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
   public partial class frmVentasPersonas : Form
   {
      public frmVentasPersonas()
      {
         InitializeComponent();
      }

      // VARIABLES.
      DataSet resultado = new DataSet();
      DataView mifiltro;

      // Delegado. Proveedor donde paso los parametros nombre, dir, tel y ruc para un evento pasar.
      public delegate void proveedor(string nombre, string direccion, string telefono, string ruc);
      public event proveedor pasar;

      private void frmVentasPersonas_Load(object sender, EventArgs e)
      {
         txt_buscar.Focus();
         txt_buscar.TabIndex = 0;
         btnAceptar.TabIndex = 1;
         btn_salir.TabIndex = 2;

         formata_tabla();
      }


      private void formata_tabla()
      {
         PersonaDal listar = new PersonaDal();
         listar.Buscar_datos("select id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_pais, per_nac, per_clt, per_obs from persona where per_clt = 'S' order by id_per", ref resultado, "persona");

         this.mifiltro = ((DataTable)resultado.Tables["persona"]).DefaultView;

         this.dt_lista_personas.DataSource = mifiltro;

         // FORMATEA EL DATATABLE
         dt_lista_personas.Columns["id_per"].HeaderText = "CODIGO";
         dt_lista_personas.Columns["per_nombre"].HeaderText = "NOMBRE";
         dt_lista_personas.Columns["per_fant"].HeaderText = "FANTASIA";
         dt_lista_personas.Columns["per_ruc"].HeaderText = "RUC";
         dt_lista_personas.Columns["per_ci"].HeaderText = "CEDULA";
         dt_lista_personas.Columns["per_tel1"].HeaderText = "TELEFONO";
         dt_lista_personas.Columns["per_tel2"].HeaderText = "CELULAR";
         dt_lista_personas.Columns["per_email"].HeaderText = "EMAIL";
         dt_lista_personas.Columns["per_dir"].HeaderText = "DIRECCION";
         dt_lista_personas.Columns["per_ciudad"].HeaderText = "CIUDAD";
         dt_lista_personas.Columns["per_pais"].HeaderText = "PAIS";
         dt_lista_personas.Columns["per_nac"].HeaderText = "F. NACIMIENTO";
         dt_lista_personas.Columns["per_clt"].HeaderText = "CLIENTE";
         dt_lista_personas.Columns["per_obs"].HeaderText = "OBSERVACION";
      }

      private void txt_buscar_KeyUp(object sender, KeyEventArgs e)
      {
         string salida_datos = ""; // muestra el resultado final.

         string[] palabras_busqueda = this.txt_buscar.Text.Split(' '); // posibles palabras que el usuario digitara...

         foreach (string palabra in palabras_busqueda)
         {
            // SIMPRE LOS CAMPOS DEL DATA GRID CARGADO CON LA CONSULTA SELECT *. 
            if (salida_datos.Length == 0)
            {
               salida_datos = "(per_nombre LIKE '%" + palabra + "%' OR per_fant LIKE '%" + palabra + "%')";
            }
            else
            {
               salida_datos += " AND (per_nombre LIKE '%" + palabra + "%' OR per_fant LIKE '%" + palabra + "%')";
            }
            this.mifiltro.RowFilter = salida_datos;
         }
      }


      private void Obtener_cliente()
      {
         int codigo;
         string nombre, direccion, tel1, ruc;

         try
         {
            if (dt_lista_personas.SelectedRows.Count == 1)
            {
               codigo = Convert.ToInt32(dt_lista_personas.CurrentRow.Cells[0].Value);
               nombre = Convert.ToString(dt_lista_personas.CurrentRow.Cells[1].Value);
               ruc = Convert.ToString(dt_lista_personas.CurrentRow.Cells[3].Value);
               tel1 = Convert.ToString(dt_lista_personas.CurrentRow.Cells[5].Value);
               direccion = Convert.ToString(dt_lista_personas.CurrentRow.Cells[8].Value);

               this.Close();

               pasar(nombre, direccion, tel1, ruc);

            }
         }
         catch (Exception erro)
         {
            MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
         }
      }

      private void btn_nuevo_Click(object sender, EventArgs e)
      {
         this.Close();

         frm_reg_productos fr = new frm_reg_productos();
         fr.ShowDialog();
      }

      private void btnAceptar_Click(object sender, EventArgs e)
      {
         Obtener_cliente(); 
      }

      private void btn_salir_Click(object sender, EventArgs e)
      {
         Close();
      }

     



   }
}
