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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        

        private void rEGISTROPERSONASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_personas tabla = new frm_tabla_personas();
            tabla.Show();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            lblfecha.Enabled = false;
            tmrfecha.Start();
        }

        private void uSUARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_lista_usuarios lista_usuarios = new frm_lista_usuarios();
            lista_usuarios.Show();
            this.Hide();
        }

        private void rEGISTRODEMARCASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_marca tabla_marca = new frm_tabla_marca();
            tabla_marca.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rEGISTRODEGRUPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_grupo fr = new frm_tabla_grupo();
            fr.Show();
        }

        private void rEGISTRODESUBGRUPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_subgrupo tabla_subgrupo = new frm_tabla_subgrupo();
            tabla_subgrupo.Show();
        }

        
        private void rEGISTROGRUPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_grupo_per fr = new frm_tabla_grupo_per();
            fr.Show();
        }

        private void rEGISTROMERCADERIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_stock tabla = new frm_tabla_stock();
            tabla.Show();
        }

        private void bACKUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_backup fr = new frm_backup();
            fr.Show();
        }

        private void cONTADOCREDITOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_compra fr = new frm_tabla_compra();
            fr.Show();
        }

        private void cONTADOCREDITOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTablaVentas fr = new frmTablaVentas();
            fr.Show();
        }

        
        private void cOTIZACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmcotizacion fr = new frmcotizacion();
           fr.Show();
        }

        private void pRESUPUESTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmpresupuesto fr = new frmpresupuesto();
           fr.Show();
        }

        private void sALIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void fUNCIONARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmFuncionarios fr = new frmFuncionarios();
           fr.Show();
        }

        private void pROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmProveedor fr = new frmProveedor();
           fr.Show();
        }

        private void rEGISTRODESERVICIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sERVICIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_servicios fr = new frm_tabla_servicios();
            fr.Show();
        }

        private void gRUPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_grupo tabla_grupo = new frm_tabla_grupo();
            tabla_grupo.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            this.lblfecha.Text = fecha.ToString();
        }

        
    }
}
