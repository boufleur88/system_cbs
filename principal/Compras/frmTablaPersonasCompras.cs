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

        // CREAR NUESTRO DELEGADO.
        public delegate void pasar(int codigo, string nombre, string telefono, string ruc); // tipo del metodo y parametros que llevara el metodol

        // CREAR NUESTRO EVENTO.
        public event pasar pasado;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTablaPersonasCompras_Load(object sender, EventArgs e)
        {
            PersonaDal ls = new PersonaDal();
            dt_lista.DataSource = ls.listaProveedorCompra();

            formata_tabla();
        }

        private void formata_tabla()
        {

            // FORMATEA EL DATATABLE
            dt_lista.Columns["id_per"].HeaderText = "CODIGO";
            dt_lista.Columns["per_nombre"].HeaderText = "NOMBRE";
            dt_lista.Columns["per_ruc"].HeaderText = "RUC";
            dt_lista.Columns["per_tel1"].HeaderText = "TELEFONO";
            dt_lista.Visible = true;
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
                if (dt_lista.SelectedRows.Count == 1)
                {
                    idCliente = Convert.ToInt32(dt_lista.CurrentRow.Cells[0].Value);
                    cliente = Convert.ToString(dt_lista.CurrentRow.Cells[1].Value);
                    ruc = Convert.ToString(dt_lista.CurrentRow.Cells[2].Value);
                    telefono = Convert.ToString(dt_lista.CurrentRow.Cells[3].Value);
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
