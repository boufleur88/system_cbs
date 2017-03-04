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
    public partial class frmGiroTigoMov : Form
    {
        public frmGiroTigoMov()
        {
            InitializeComponent();
        }

        // Declaraciones de variables.
        validar_datos v1 = new validar_datos();

        public int empresa = 1; // automatico
        public int filial = 1; // automatico
        public string tipo; // tipo = C = COBRAR Y P = PAGAR
        public int numero; // numero do titulo
        public int codigo;
        public DateTime inclusion = DateTime.Now;
        public string nombre;
        public string obs;
        public double valor;
        public string situacion;


        private void frmGiroTigoMov_Load(object sender, EventArgs e)
        {
            txtInclusion.Text = inclusion.ToShortDateString();

        }

        public void limpiar()
        {
            txtCliente.Text = "";
            txtCodigo.Text = "";
            txtInclusion.Text = "";
            txtObs.Text = "";
            txtTelefono.Text = "";
            txtValor.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == "") || (txtCodigo.Text == "0"))
            {
                MessageBox.Show("Vazio ou Zero");
            }

            if (txtCliente.Text == "")
            {
                MessageBox.Show("Informar un nombre del cliente");
            }

            if ((txtValor.Text == "") || (txtValor.Text == "0"))
            {
                MessageBox.Show("Informar el valor de la Operación");
            }

            /*f_inclusión = Convert.ToDateTime(txtf_Inclusion.Text);
                codigo = Convert.ToInt32(txtCodigo.Text);
                nombre = Convert.ToString(txtCliente.Text);
                valor = Convert.ToDouble(txtValor.Text);
                obs = Convert.ToString(txtObs.Text);
             * */
            else
            {

                DataMov.Rows.Add(txtInclusion.Text, txtCodigo.Text, txtCliente.Text, txtValor.Text, txtObs.Text);


                codigo = Convert.ToInt32(txtCodigo.Text);
                inclusion = inclusion.Date;
                situacion = "AB";

                NpgsqlConnection conexion = Servidor.conectar();

                // executa a instrucao 
                NpgsqlCommand sql = new NpgsqlCommand("INSERT INTO MOVDCR (CODEMP, CODFIL, CODTIP, DATEMI, CODCLI, VLRORI, OBSDCR, SITDCR) VALUES (@1, @2, @3, @4, @5, @6, @7, @8);", conexion);
                sql.Parameters.AddWithValue("@1", empresa);
                sql.Parameters.AddWithValue("@2", filial);
                sql.Parameters.AddWithValue("@3", tipo);
                sql.Parameters.AddWithValue("@4", inclusion);
                sql.Parameters.AddWithValue("@5", codigo);
                sql.Parameters.AddWithValue("@6", valor);
                sql.Parameters.AddWithValue("@7", obs);
                sql.Parameters.AddWithValue("@8", situacion);
                sql.ExecuteNonQuery();

                NpgsqlDataReader leer = sql.ExecuteReader();

                if (leer.Read() == true)
                {
                    txtCodigo.Text = leer["id_per"].ToString();
                    txtCliente.Text = leer["per_nombre"].ToString();
                    txtTelefono.Text = leer["per_tel1"].ToString();
                }
                else
                {
                    MessageBox.Show("No hemos encontrado ningún producto con este codigo" + codigo);
                }
                MessageBox.Show("Registro guardado exitosamente");
                conexion.Close();

            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (txtValor.Text == "")
            {
                MessageBox.Show("No incluiste ningun valor");
            }
            else
            { 
            txtValor.Text = string.Format("{0:N0}", Convert.ToDouble(txtValor.Text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void buscar()
        {
            codigo = Convert.ToInt32(txtCodigo.Text);

            NpgsqlConnection conexion = Servidor.conectar();

            // executa a instrucao 
            NpgsqlCommand sql = new NpgsqlCommand("SELECT id_per, per_nombre, per_tel1 FROM persona WHERE id_per = " + codigo, conexion);

            NpgsqlDataReader leer = sql.ExecuteReader();

            if (leer.Read() == true)
            {
                txtCodigo.Text = leer["id_per"].ToString();
                txtCliente.Text = leer["per_nombre"].ToString();
                txtTelefono.Text = leer["per_tel1"].ToString();
            }
            else
            {
                MessageBox.Show("No hemos encontrado ningún producto con este codigo" + codigo);
            }
            conexion.Close();

        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            buscar();
        }


    }
}
