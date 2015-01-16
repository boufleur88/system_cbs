namespace cbs_sistema
{
    partial class frm_lista_usuarios
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
           this.label4 = new System.Windows.Forms.Label();
           this.txt_pesquisa = new System.Windows.Forms.TextBox();
           this.btn_buscar = new System.Windows.Forms.Button();
           this.btn_alterar = new System.Windows.Forms.Button();
           this.dt_lista_usuarios = new System.Windows.Forms.DataGridView();
           this.btn_nuevo = new System.Windows.Forms.Button();
           this.button1 = new System.Windows.Forms.Button();
           this.btn_excluir = new System.Windows.Forms.Button();
           this.txt_codigo = new System.Windows.Forms.TextBox();
           this.label1 = new System.Windows.Forms.Label();
           this.label2 = new System.Windows.Forms.Label();
           this.textBox1 = new System.Windows.Forms.TextBox();
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_usuarios)).BeginInit();
           this.SuspendLayout();
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label4.Location = new System.Drawing.Point(66, 25);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(92, 20);
           this.label4.TabIndex = 23;
           this.label4.Text = "PESQUISA";
           this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txt_pesquisa
           // 
           this.txt_pesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_pesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_pesquisa.Location = new System.Drawing.Point(174, 23);
           this.txt_pesquisa.Margin = new System.Windows.Forms.Padding(0);
           this.txt_pesquisa.MaxLength = 40;
           this.txt_pesquisa.Name = "txt_pesquisa";
           this.txt_pesquisa.Size = new System.Drawing.Size(384, 22);
           this.txt_pesquisa.TabIndex = 19;
           // 
           // btn_buscar
           // 
           this.btn_buscar.Location = new System.Drawing.Point(586, 22);
           this.btn_buscar.Name = "btn_buscar";
           this.btn_buscar.Size = new System.Drawing.Size(118, 23);
           this.btn_buscar.TabIndex = 21;
           this.btn_buscar.Text = "BUSCAR";
           this.btn_buscar.UseVisualStyleBackColor = true;
           // 
           // btn_alterar
           // 
           this.btn_alterar.Location = new System.Drawing.Point(870, 665);
           this.btn_alterar.Name = "btn_alterar";
           this.btn_alterar.Size = new System.Drawing.Size(118, 23);
           this.btn_alterar.TabIndex = 22;
           this.btn_alterar.Text = "SALIR";
           this.btn_alterar.UseVisualStyleBackColor = true;
           this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
           // 
           // dt_lista_usuarios
           // 
           this.dt_lista_usuarios.AllowUserToDeleteRows = false;
           this.dt_lista_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
           this.dt_lista_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.dt_lista_usuarios.Location = new System.Drawing.Point(28, 140);
           this.dt_lista_usuarios.Name = "dt_lista_usuarios";
           this.dt_lista_usuarios.ReadOnly = true;
           this.dt_lista_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
           this.dt_lista_usuarios.Size = new System.Drawing.Size(960, 519);
           this.dt_lista_usuarios.TabIndex = 24;
           // 
           // btn_nuevo
           // 
           this.btn_nuevo.Location = new System.Drawing.Point(29, 665);
           this.btn_nuevo.Name = "btn_nuevo";
           this.btn_nuevo.Size = new System.Drawing.Size(118, 23);
           this.btn_nuevo.TabIndex = 25;
           this.btn_nuevo.Text = "&NUEVO";
           this.btn_nuevo.UseVisualStyleBackColor = true;
           this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
           // 
           // button1
           // 
           this.button1.Location = new System.Drawing.Point(153, 665);
           this.button1.Name = "button1";
           this.button1.Size = new System.Drawing.Size(118, 23);
           this.button1.TabIndex = 26;
           this.button1.Text = "&ALTERAR";
           this.button1.UseVisualStyleBackColor = true;
           // 
           // btn_excluir
           // 
           this.btn_excluir.Location = new System.Drawing.Point(277, 665);
           this.btn_excluir.Name = "btn_excluir";
           this.btn_excluir.Size = new System.Drawing.Size(118, 23);
           this.btn_excluir.TabIndex = 27;
           this.btn_excluir.Text = "&EXCLUIR";
           this.btn_excluir.UseVisualStyleBackColor = true;
           this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
           // 
           // txt_codigo
           // 
           this.txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_codigo.Location = new System.Drawing.Point(174, 69);
           this.txt_codigo.Margin = new System.Windows.Forms.Padding(0);
           this.txt_codigo.MaxLength = 4;
           this.txt_codigo.Name = "txt_codigo";
           this.txt_codigo.Size = new System.Drawing.Size(52, 22);
           this.txt_codigo.TabIndex = 28;
           this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label1.Location = new System.Drawing.Point(62, 70);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(74, 20);
           this.label1.TabIndex = 29;
           this.label1.Text = "CODIGO";
           this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label2.Location = new System.Drawing.Point(66, 102);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(79, 20);
           this.label2.TabIndex = 31;
           this.label2.Text = "NOMBRE";
           this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // textBox1
           // 
           this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.textBox1.Location = new System.Drawing.Point(175, 101);
           this.textBox1.Margin = new System.Windows.Forms.Padding(0);
           this.textBox1.MaxLength = 40;
           this.textBox1.Name = "textBox1";
           this.textBox1.Size = new System.Drawing.Size(383, 22);
           this.textBox1.TabIndex = 30;
           // 
           // frm_lista_usuarios
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(1000, 700);
           this.Controls.Add(this.label2);
           this.Controls.Add(this.textBox1);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.txt_codigo);
           this.Controls.Add(this.btn_excluir);
           this.Controls.Add(this.button1);
           this.Controls.Add(this.btn_nuevo);
           this.Controls.Add(this.dt_lista_usuarios);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.txt_pesquisa);
           this.Controls.Add(this.btn_buscar);
           this.Controls.Add(this.btn_alterar);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_lista_usuarios";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "LISTADO DE USUARIOS DEL SISTEMA";
           this.Load += new System.EventHandler(this.frm_lista_usuarios_Load);
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_usuarios)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.DataGridView dt_lista_usuarios;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}