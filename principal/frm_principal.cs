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
        public string IdUsuario = "";
        public string Nombre = "";



        public frm_principal()
        {
            InitializeComponent();
        }

        

        private void rEGISTROPERSONASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_personas tabla = new frm_tabla_personas();
            tabla.MdiParent = this;
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
            lista_usuarios.MdiParent = this;
            lista_usuarios.Show();
            
        }

        private void rEGISTRODEMARCASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_marca tabla_marca = new frm_tabla_marca();
            tabla_marca.MdiParent = this;
            tabla_marca.Show();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rEGISTRODEGRUPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_grupo fr = new frm_tabla_grupo();
            fr.MdiParent = this;
            fr.Show();
        }

        private void rEGISTRODESUBGRUPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_subgrupo tabla_subgrupo = new frm_tabla_subgrupo();
            tabla_subgrupo.MdiParent = this;
            tabla_subgrupo.Show();
        }

        
        private void rEGISTROGRUPOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_grupo_per fr = new frm_tabla_grupo_per();
            fr.MdiParent = this;
            fr.Show();
        }

        private void rEGISTROMERCADERIASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_stock tabla = new frm_tabla_stock();
            tabla.MdiParent = this;
            tabla.Show();
        }

        private void bACKUPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_backup fr = new frm_backup();
            fr.MdiParent = this;
            fr.Show();
        }

        private void cONTADOCREDITOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_compra fr = new frm_tabla_compra();
            fr.MdiParent = this;
            fr.Show();
        }

        private void cONTADOCREDITOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTablaVentas fr = new frmTablaVentas();
            fr.MdiParent = this;
            fr.Show();
        }

        
        private void cOTIZACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmcotizacion fr = new frmcotizacion();
           fr.MdiParent = this;
           fr.Show();
        }

        private void pRESUPUESTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmpresupuesto fr = new frmpresupuesto();
           fr.MdiParent = this;
           fr.Show();
        }

        private void sALIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void fUNCIONARIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmFuncionarios fr = new frmFuncionarios();
           fr.MdiParent = this;
           fr.Show();
        }

        private void pROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmProveedor fr = new frmProveedor();
           fr.MdiParent = this;
           fr.Show();
        }

        private void sERVICIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_servicios fr = new frm_tabla_servicios();
            fr.MdiParent = this;
            fr.Show();
        }

        private void gRUPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tabla_grupo tabla_grupo = new frm_tabla_grupo();
            tabla_grupo.MdiParent = this;
            tabla_grupo.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            this.lblfecha.Text = fecha.ToString();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
