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
    public partial class frmTablaPersonasVentas : Form
    {
        public frmTablaPersonasVentas()
        {
            InitializeComponent();
        }

        // CREAR NUESTRO DELEGADO.
        public delegate void pasar(int codigo, string nombre, string telefono, string ruc); // tipo del metodo y parametros que llevara el metodol
        
        // CREAR NUESTRO EVENTO.
        public event pasar pasado;


        // VARIABLES.
        // public string cliente, telefono;

        private void frmTablaPersonasVentas_Load(object sender, EventArgs e)
        {
            PersonaDal ls = new PersonaDal();
            dt_lista_cliente.DataSource = ls.lista_algunos();

            formata_tabla();
        }

        private void formata_tabla()
        {

            // FORMATEA EL DATATABLE
            // id_per, per_nombre, per_fant, per_ruc, per_ci, per_tel1, per_tel2, per_email, per_dir, per_ciudad, per_pais, per_nac
            dt_lista_cliente.Columns["id_per"].HeaderText = "CODIGO";
            dt_lista_cliente.Columns["per_nombre"].HeaderText = "NOMBRE";
            dt_lista_cliente.Columns["per_fant"].HeaderText = "FANTASIA";
            dt_lista_cliente.Columns["per_fant"].Visible = false;
            dt_lista_cliente.Columns["per_ruc"].HeaderText = "RUC";
            dt_lista_cliente.Columns["per_ci"].HeaderText = "CEDULA";
            dt_lista_cliente.Columns["per_ci"].Visible = false;
            dt_lista_cliente.Columns["per_tel1"].HeaderText = "TELEFONO";
            dt_lista_cliente.Columns["per_tel2"].HeaderText = "CELULAR";
            dt_lista_cliente.Columns["per_tel2"].Visible = false;
            dt_lista_cliente.Columns["per_email"].HeaderText = "EMAIL";
            dt_lista_cliente.Columns["per_email"].Visible = false;
            dt_lista_cliente.Columns["per_ciudad"].HeaderText = "CIUDAD";
            dt_lista_cliente.Columns["per_ciudad"].Visible = false;
            dt_lista_cliente.Columns["per_dir"].HeaderText = "DIRECCION";
            dt_lista_cliente.Columns["per_dir"].Visible = false;
            dt_lista_cliente.Columns["per_nac"].HeaderText = "F. NACIMIENTO";
            dt_lista_cliente.Columns["per_nac"].Visible = false;
            dt_lista_cliente.Columns["per_clt"].HeaderText = "CLIENTE";
            dt_lista_cliente.Columns["per_clt"].Visible = false;
            dt_lista_cliente.Columns["per_prov"].HeaderText = "PROVEEDOR";
            dt_lista_cliente.Columns["per_prov"].Visible = false;
            dt_lista_cliente.Columns["per_func"].HeaderText = "FUNCIONARIO";
            dt_lista_cliente.Columns["per_func"].Visible = false;
            dt_lista_cliente.Columns["per_obs"].HeaderText = "OBSERVACION";
            dt_lista_cliente.Columns["per_obs"].Visible = false;

            dt_lista_cliente.Visible = true;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btmAdicionar_Click(object sender, EventArgs e)
        {
            llamar_datos();            
        }

        public void llamar_datos()
        {
            int idCliente;
            string cliente, telefono, ruc;

            try
            {
                if (dt_lista_cliente.SelectedRows.Count == 1)
                {
                    idCliente = Convert.ToInt32(dt_lista_cliente.CurrentRow.Cells[0].Value);
                    cliente = Convert.ToString(dt_lista_cliente.CurrentRow.Cells[1].Value);
                    telefono = Convert.ToString(dt_lista_cliente.CurrentRow.Cells[5].Value);
                    ruc = Convert.ToString(dt_lista_cliente.CurrentRow.Cells[3].Value);
                    cliente.Trim();
                    telefono.Trim();
                    ruc.Trim();

                    this.Close();

                    pasado(idCliente, cliente, telefono, ruc);
                    this.Dispose();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERROR AL MOSTRAR EL CLIENTE EN LA VENTA","CBS INFORMATICA" + erro);
            }
        }
    }
}
