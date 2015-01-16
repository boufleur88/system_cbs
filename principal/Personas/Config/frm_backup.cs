using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // biblioteca input ouput

namespace sistema_cbs
{
    public partial class frm_backup : Form
    {
        public frm_backup()
        {
            InitializeComponent();
        }

        private void btn_dir_Click(object sender, EventArgs e)
        {
            DirectoryInfo diretorio = new DirectoryInfo(@"c:\cbssistema");

            try 
            {
                if (diretorio.Exists)
                    MessageBox.Show("BACKUP REALIZADO CORRECTAMENTE");
                else
                { 
                    MessageBox.Show("BACKUP NO EXISTE PERO SERA CREADO");
                    diretorio.Create();
                }
            }

            catch (IOException erro)
            {
                MessageBox.Show("error al manipular directorio"+ erro);
            }


            // criar arquivo de backup.
            FileInfo arquivo = new FileInfo(@"c:\cbssistema\backup.txt");
            FileStream fs = arquivo.Create();

            /*
             DATA E HORA    = arquivo.CreationTime
             ATRIBUTOS      = arquivo.Attributes.ToString()
             FULL NAME      = arquivo.FullName
             */
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
