using Npgsql;
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
    public partial class CajaChica : Form
    {
        public CajaChica()
        {
            InitializeComponent();
        }
        // VARIABLES DEL MODULO DE CAJA
        public String codcta, CtaDes, CtaObs;
        public String aMsg = "CBS INFORMATICA";
        public double vlrdeb, vlrhab;
        public DateTime datemi = DateTime.Now;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /* Cuando o campo esta vacio e bom usar OR 
            // Verifica si el campo Codigo esta Vacio, de esta manera es obligatorio registrar el gasto u ingreso en una cuenta contable
            if (txtDebe.Text == txtHaber.Text)
            {
                MessageBox.Show("El Movimiento no tiene Valor", aMsg);
                txtDebe.Focus();
                txtDebe.BackColor = Color.Aqua;
            }*/
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("No has elegido una Cuenta Contable", aMsg);
                txtCodigo.Focus();
                txtCodigo.BackColor = Color.Aqua;
            }
            else
            {
                codcta = "111101";
                vlrdeb = Convert.ToDouble(txtDebe.Text);
                vlrhab = Convert.ToDouble(txtHaber.Text);
                CtaObs = txtObservacion.Text;

                try
                {
                    NpgsqlConnection conexion = Servidor.conectar();

                    NpgsqlCommand sql = new NpgsqlCommand("INSERT INTO MOVCAJ (datemi, codcta, vlrdeb, vlrhab, movobs, id_usuario, id_moneda, id_sucursal) " +
                                                                      "VALUES ('" + datemi + "', '" + codcta + "', " + vlrdeb + ", " + vlrhab + ", '" + CtaObs + "', 1, 1, 1);", conexion);
                    sql.ExecuteNonQuery();
                    conexion.Close();
                }
                catch (Exception erro)
                {
                    throw erro;
                }
                MessageBox.Show("Registro Gravado con Éxito", aMsg);
                this.Close();

            }
        }

        private void CajaChica_Load(object sender, EventArgs e)
        {
            txtInclusion.Text = datemi.ToShortDateString();
            txtDebe.Focus();
            txtHaber.TabIndex = 1;
            txtObservacion.TabIndex = 2;
            txtCuenta.TabIndex = 3;
            btnGuardar.TabIndex = 4;
            txtDebe.Text = "0";
            txtHaber.Text = "0";
        }

        private void txtDebe_Leave(object sender, EventArgs e)
        {
            if (txtDebe.Text == "")
            {
                txtDebe.Text = "0";
            }
            txtDebe.Text = string.Format("{0:N0}", Convert.ToDouble(txtDebe.Text));
        }

        private void txtHaber_Leave(object sender, EventArgs e)
        {
            if (txtHaber.Text == "")
            {
                txtHaber.Text = "0";
            }
            txtHaber.Text = string.Format("{0:N0}", Convert.ToDouble(txtHaber.Text));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.F2))
            {
                frm_PlanCta fr = new frm_PlanCta();
                fr.Show();
            }
            
        }

    }
}
