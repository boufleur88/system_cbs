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
    public partial class frm_tabla_servicios : Form
    {
        public frm_tabla_servicios()
        {
            InitializeComponent();
        }

        // Declaración de las variables.
        public DataGridViewContentAlignment Alignment { get; set; }
        String buscar;

        private void frm_tabla_servicios_Load(object sender, EventArgs e)
        {
            txt_buscar.Focus();
            txt_buscar.TabIndex = 0;
            btn_buscar.TabIndex = 1;
            btn_nuevo.TabIndex = 2;
            btn_alterar.TabIndex = 3;
            btn_sair.TabIndex = 4;

            ServiciosDal ls = new ServiciosDal();
            dt_lista.DataSource = ls.listar();

            formata_tabla();
        }

        private void formata_tabla()
        {
            dt_lista.Columns["id_servicio"].HeaderText = "CODIGO";
            dt_lista.Columns["descripcion"].HeaderText = "DESCRIPCION";
            dt_lista.Columns["costo"].HeaderText = "COSTO";
            dt_lista.Columns["costo"].DefaultCellStyle.Format = "N0";
            dt_lista.Columns["costo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dt_lista.Columns["precio_min"].HeaderText = "MINIMO";
            dt_lista.Columns["precio_min"].DefaultCellStyle.Format = "N0";
            dt_lista.Columns["precio_min"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dt_lista.Columns["precio"].HeaderText = "PRECIO";
            dt_lista.Columns["precio"].DefaultCellStyle.Format = "N0";
            dt_lista.Columns["precio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dt_lista.Columns["sgrupo"].HeaderText = "GRUPO";
            dt_lista.Columns["observacion"].HeaderText = "OBSERVACION";
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_registro_servicios fr = new frm_registro_servicios();
            fr.Show();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            editar_datos();
        }

        // FUNCAO PARA ALTERAR DATOS...
        private void editar_datos()
        {
            int cServicio;
            string grupo, descripcion, observacion;
            Double costo, minimo, venta;

            try
            {
                if (dt_lista.SelectedRows.Count == 1)
                {

                    cServicio = Convert.ToInt32(dt_lista.CurrentRow.Cells[0].Value);
                    descripcion = Convert.ToString(dt_lista.CurrentRow.Cells[1].Value);
                    costo = Convert.ToDouble(dt_lista.CurrentRow.Cells[2].Value);
                    minimo = Convert.ToDouble(dt_lista.CurrentRow.Cells[3].Value);
                    venta = Convert.ToDouble(dt_lista.CurrentRow.Cells[4].Value);
                    grupo = Convert.ToString(dt_lista.CurrentRow.Cells[5].Value);
                    observacion = Convert.ToString(dt_lista.CurrentRow.Cells[6].Value);                    

                    this.Close();

                    frm_registro_servicios obj = new frm_registro_servicios();
                    obj.codigo = cServicio;
                    obj.descripcion = descripcion;
                    obj.costo = costo;
                    obj.preciomin = minimo;
                    obj.precio = venta;
                    obj.grupo = grupo;
                    obj.observacion = observacion;

                    obj.Show();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERROR AL REGISTRA EL SERVICIO" + erro);
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            buscar = txt_buscar.Text.ToString();
            buscar = buscar.Trim();

            if (txt_buscar.Text == "")
            {
                ServiciosDal lista = new ServiciosDal();
                dt_lista.DataSource = lista.listar();

                formata_tabla();
            }
            else
            {
                ServiciosDal lista = new ServiciosDal();
                dt_lista.DataSource = lista.Buscar(buscar);

                formata_tabla();
            }
        }
    }
}
