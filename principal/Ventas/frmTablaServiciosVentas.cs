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
    public partial class frmTablaServiciosVentas : Form
    {
        public frmTablaServiciosVentas()
        {
            InitializeComponent();
        }

        private void frmTablaServiciosVentas_Load(object sender, EventArgs e)
        {
            ServiciosDal ls = new ServiciosDal();
            dt_lista.DataSource = ls.listar();

            formata_tabla();
        }

        private void formata_tabla()
        {
            dt_lista.Columns["id_servicio"].HeaderText = "CODIGO";
            dt_lista.Columns["descripcion"].HeaderText = "DESCRIPCION";
            dt_lista.Columns["costo"].Visible = false;
            dt_lista.Columns["precio_min"].HeaderText = "MINIMO";
            dt_lista.Columns["precio_min"].DefaultCellStyle.Format = "N0";
            dt_lista.Columns["precio_min"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dt_lista.Columns["precio"].HeaderText = "PRECIO";
            dt_lista.Columns["precio"].DefaultCellStyle.Format = "N0";
            dt_lista.Columns["precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dt_lista.Columns["sgrupo"].Visible = false;
            dt_lista.Columns["observacion"].HeaderText = "OBSERVACION";
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmAdicionar_Click(object sender, EventArgs e)
        {
            llamar_datos();
        }

        public void llamar_datos()
        {
            int idServicio;
            string descripcion, grupo;
            double costo, preciomin, precio;

            try
            {
                if (dt_lista.SelectedRows.Count == 1)
                {
                    idServicio = Convert.ToInt32(dt_lista.CurrentRow.Cells[0].Value);
                    descripcion = Convert.ToString(dt_lista.CurrentRow.Cells[1].Value);
                    costo = Convert.ToDouble(dt_lista.CurrentRow.Cells[2].Value);
                    preciomin = Convert.ToDouble(dt_lista.CurrentRow.Cells[3].Value);
                    precio = Convert.ToDouble(dt_lista.CurrentRow.Cells[4].Value);
                    grupo = Convert.ToString(dt_lista.CurrentRow.Cells[5].Value);

                    this.Close();

                    // MessageBox.Show("IdServicio " + idServicio + " | " + descripcion + " Costo: " + costo + " PrecioMin: " + preciomin + " Precio " + precio + " ");

                    frmRegistroVentas obj = new frmRegistroVentas();
                    obj.codigo = idServicio;
                    obj.descripcion = descripcion;
                    obj.precio = precio;
                    obj.Show();
                    
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERROR AL GUARDAR PERSONA" + erro);
            }
        }

    }
}
