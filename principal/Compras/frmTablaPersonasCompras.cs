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
    public partial class frmTablaPersonasCompras : Form
    {
        public frmTablaPersonasCompras()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTablaPersonasCompras_Load(object sender, EventArgs e)
        {
            PersonaDal ls = new PersonaDal();
            dt_lista.DataSource = ls.lista_algunos();

            formata_tabla();
        }

        private void formata_tabla()
        {

            // FORMATEA EL DATATABLE
            // id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_pais, per_nac
            dt_lista.Columns["id_per"].HeaderText = "CODIGO";
            dt_lista.Columns["per_nombre"].HeaderText = "NOMBRE";
            dt_lista.Columns["per_fant"].HeaderText = "FANTASIA";
            dt_lista.Columns["per_fant"].Visible = false;
            dt_lista.Columns["per_ruc"].HeaderText = "RUC";
            dt_lista.Columns["per_ci"].HeaderText = "CEDULA";
            dt_lista.Columns["per_ci"].Visible = false;
            dt_lista.Columns["per_tel1"].HeaderText = "TELEFONO";
            dt_lista.Columns["per_tel2"].HeaderText = "CELULAR";
            dt_lista.Columns["per_tel2"].Visible = false;
            dt_lista.Columns["per_email"].HeaderText = "EMAIL";
            dt_lista.Columns["per_email"].Visible = false;
            dt_lista.Columns["per_ciudad"].HeaderText = "CIUDAD";
            dt_lista.Columns["per_ciudad"].Visible = false;
            dt_lista.Columns["per_dir"].HeaderText = "DIRECCION";
            dt_lista.Columns["per_dir"].Visible = false;
            dt_lista.Columns["per_nac"].HeaderText = "F. NACIMIENTO";
            dt_lista.Columns["per_nac"].Visible = false;
            dt_lista.Columns["per_clt"].HeaderText = "CLIENTE";
            dt_lista.Columns["per_clt"].Visible = false;
            dt_lista.Columns["per_prov"].HeaderText = "PROVEEDOR";
            dt_lista.Columns["per_prov"].Visible = false;
            dt_lista.Columns["per_func"].HeaderText = "FUNCIONARIO";
            dt_lista.Columns["per_func"].Visible = false;
            dt_lista.Columns["per_obs"].HeaderText = "OBSERVACION";
            dt_lista.Columns["per_obs"].Visible = false;

            dt_lista.Visible = true;
        }


        

    }
}
