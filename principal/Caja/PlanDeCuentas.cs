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
    public partial class frm_PlanCta : Form
    {
        public frm_PlanCta()
        {
            InitializeComponent();
        }

        private void PlanDeCuentas_Load(object sender, EventArgs e)
        {
            CuentaDal ls = new CuentaDal();
            dt_lista.DataSource = ls.listar();

            formatarTabla();
        }

        private void formatarTabla()
        {
            dt_lista.Columns["codcta"].HeaderText = "CODIGO";
            dt_lista.Columns["c_descr"].HeaderText = "CUENTA CONTABLE";
        }

    }
}
