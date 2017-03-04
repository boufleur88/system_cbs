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
    public partial class frmPuntoDeEquilibrio : Form
    {
        public frmPuntoDeEquilibrio()
        {
            InitializeComponent();
        }

        // Declaracion de las variables...
        public double precio;
        public double costoTotalFijo;
        public double costoUnitarioVariable;
        public double totalUnidades;
        public double totalValores;

        public int codigo;
        public string desc;

        // Declaraciones de variables.
        validar_datos v1 = new validar_datos();
        
        public void Limpiar()
        {
            txtCFT.Text = "";
            txtCUV.Text = "";
            txtPrecio.Text = "";
            txtTotalUnidades.Text = "";
            txtTotalValorMonetario.Text = "";
            txtCodigo.Text = "";
            txtDesc.Text = "";

            txtCFT.Text = "0";
            txtCUV.Text = "0";
            txtPrecio.Text = "0";
            txtTotalUnidades.Text = "0";
            txtTotalValorMonetario.Text = "0";
        }

        private void frmPuntoDeEquilibrio_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == "") || (txtCodigo.Text == "0"))
            {
                MessageBox.Show("CODIGO ESTA Vazio ou Zero");
            }

            if ((txtCUV.Text == "") || (txtCUV.Text == "0"))
            {
                MessageBox.Show("CUSTO UNITARIO ESTA Vazio ou Zero");
            }
            
                codigo = Convert.ToInt32(txtCodigo.Text);

                NpgsqlConnection conexion = Servidor.conectar();

                // executa a instrucao 
                NpgsqlCommand sql = new NpgsqlCommand("SELECT id_produto, pro_descr, pro_costoadm, pro_ventamay FROM produto WHERE id_produto =" + codigo, conexion);

                NpgsqlDataReader leer = sql.ExecuteReader();

                if (leer.Read() == true)
                {
                    txtDesc.Text = leer["pro_descr"].ToString();
                    txtCUV.Text = leer["pro_costoadm"].ToString();
                    txtPrecio.Text = leer["pro_ventamay"].ToString();
                }
                else
                {
                    MessageBox.Show("No hemos encontrado ningún producto con este codigo" + codigo);
                }
                conexion.Close();

                precio = Convert.ToDouble(txtPrecio.Text);
                costoTotalFijo = Convert.ToDouble(txtCFT.Text);
                costoUnitarioVariable = Convert.ToDouble(txtCUV.Text);
            
                totalUnidades = ((costoTotalFijo) / (precio - costoUnitarioVariable));
                totalValores = ((costoTotalFijo) / ((1-(costoUnitarioVariable / precio))));

                if (totalUnidades > 100)
                {
                    txtTotalUnidades.BackColor = Color.Red;
                    txtTotalValorMonetario.BackColor = Color.Red;

                    txtTotalUnidades.Text = Convert.ToString(totalUnidades);
                    txtTotalValorMonetario.Text = Convert.ToString(totalValores);
                }
                else
                {
                    txtTotalUnidades.BackColor = Color.White;
                    txtTotalValorMonetario.BackColor = Color.White;
                    txtTotalUnidades.Text = Convert.ToString(totalUnidades);
                    txtTotalValorMonetario.Text = Convert.ToString(totalValores);
                }

                formatar();
        }

        private void formatar()
        {
            txtCUV.Text = string.Format("{0:N0}", Convert.ToDouble(txtCUV.Text));
            txtPrecio.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio.Text));
            txtTotalUnidades.Text = string.Format("{0:N0}", Convert.ToDouble(txtTotalUnidades.Text));
            txtTotalValorMonetario.Text = string.Format("{0:N0}", Convert.ToDouble(txtTotalValorMonetario.Text));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCFT_Leave(object sender, EventArgs e)
        {
            txtCFT.Text = string.Format("{0:N0}", Convert.ToDouble(txtCFT.Text));
        }

        private void txtCUV_Leave(object sender, EventArgs e)
        {
            txtCUV.Text = string.Format("{0:N0}", Convert.ToDouble(txtCUV.Text));
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            txtPrecio.Text = string.Format("{0:N0}", Convert.ToDouble(txtPrecio.Text));
        }

     
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            codigo = Convert.ToInt32(txtCodigo.Text);

            codigo = codigo - 1;

            txtCodigo.Text = Convert.ToString(codigo);

            btnCalcular.PerformClick();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
                codigo = Convert.ToInt32(txtCodigo.Text);

                codigo = codigo + 1;

                // MessageBox.Show("Codigo = "+codigo);

                txtCodigo.Text = Convert.ToString(codigo);

                btnCalcular.PerformClick();
        }

             
    }
}
