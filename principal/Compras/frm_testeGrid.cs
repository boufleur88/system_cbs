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
    public partial class frm_testeGrid : Form
    {
        public frm_testeGrid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable ss = new DataTable();
            ss.Columns.Add("1");
            ss.Columns.Add("2");
            ss.Columns.Add("3");
            ss.Columns.Add("4");
            ss.Columns.Add("5");
            string[] row = { "001", "teste", "12", "1000", "12000" };                     
            ss.Rows.Add(row);         

            foreach (DataRow drow in ss.Rows)
            {
                int num = datagrid.Rows.Add();
                datagrid.Rows[num].Cells[0].Value = drow["1"].ToString();
                datagrid.Rows[num].Cells[1].Value = drow["2"].ToString();
                datagrid.Rows[num].Cells[2].Value = drow["3"].ToString();
                datagrid.Rows[num].Cells[3].Value = drow["4"].ToString();
                datagrid.Rows[num].Cells[4].Value = drow["5"].ToString();
            }
        }

        private void frm_testeGrid_Load(object sender, EventArgs e)
        {
            datagrid.ColumnCount = 5;
            datagrid.ColumnHeadersVisible = true;
            datagrid.Columns[0].Name = ("Codigo");
            datagrid.Columns[1].Name = ("Descricao");
            datagrid.Columns[2].Name = ("Qtde");
            datagrid.Columns[3].Name = ("Costo");
            datagrid.Columns[4].Name = ("Total");
        }
    }
}
