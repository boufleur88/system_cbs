namespace cbs_sistema
{
    partial class frm_tabla_grupo
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
           this.label5 = new System.Windows.Forms.Label();
           this.btn_excluir = new System.Windows.Forms.Button();
           this.btnAlterar = new System.Windows.Forms.Button();
           this.btn_nuevo = new System.Windows.Forms.Button();
           this.dt_lista_grupo = new System.Windows.Forms.DataGridView();
           this.btn_alterar = new System.Windows.Forms.Button();
           this.label1 = new System.Windows.Forms.Label();
           this.txt_buscar = new System.Windows.Forms.TextBox();
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_grupo)).BeginInit();
           this.SuspendLayout();
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label5.Location = new System.Drawing.Point(189, 9);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(184, 20);
           this.label5.TabIndex = 44;
           this.label5.Text = "REGISTRO DE GRUPO";
           this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // btn_excluir
           // 
           this.btn_excluir.Location = new System.Drawing.Point(148, 565);
           this.btn_excluir.Name = "btn_excluir";
           this.btn_excluir.Size = new System.Drawing.Size(65, 23);
           this.btn_excluir.TabIndex = 43;
           this.btn_excluir.Text = "&EXCLUIR";
           this.btn_excluir.UseVisualStyleBackColor = true;
           this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
           this.btn_excluir.Leave += new System.EventHandler(this.btn_excluir_Leave);
           // 
           // btnAlterar
           // 
           this.btnAlterar.Location = new System.Drawing.Point(77, 565);
           this.btnAlterar.Name = "btnAlterar";
           this.btnAlterar.Size = new System.Drawing.Size(65, 23);
           this.btnAlterar.TabIndex = 42;
           this.btnAlterar.Text = "&ALTERAR";
           this.btnAlterar.UseVisualStyleBackColor = true;
           this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
           this.btnAlterar.Leave += new System.EventHandler(this.btnAlterar_Leave);
           // 
           // btn_nuevo
           // 
           this.btn_nuevo.Location = new System.Drawing.Point(8, 565);
           this.btn_nuevo.Name = "btn_nuevo";
           this.btn_nuevo.Size = new System.Drawing.Size(65, 23);
           this.btn_nuevo.TabIndex = 41;
           this.btn_nuevo.Text = "&NUEVO";
           this.btn_nuevo.UseVisualStyleBackColor = true;
           this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
           this.btn_nuevo.Leave += new System.EventHandler(this.btn_nuevo_Leave);
           // 
           // dt_lista_grupo
           // 
           this.dt_lista_grupo.AllowUserToDeleteRows = false;
           this.dt_lista_grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.dt_lista_grupo.Location = new System.Drawing.Point(23, 60);
           this.dt_lista_grupo.Name = "dt_lista_grupo";
           this.dt_lista_grupo.ReadOnly = true;
           this.dt_lista_grupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
           this.dt_lista_grupo.Size = new System.Drawing.Size(500, 500);
           this.dt_lista_grupo.TabIndex = 40;
           this.dt_lista_grupo.DoubleClick += new System.EventHandler(this.dt_lista_grupo_DoubleClick);
           // 
           // btn_alterar
           // 
           this.btn_alterar.Location = new System.Drawing.Point(458, 565);
           this.btn_alterar.Name = "btn_alterar";
           this.btn_alterar.Size = new System.Drawing.Size(65, 23);
           this.btn_alterar.TabIndex = 39;
           this.btn_alterar.Text = "SALIR";
           this.btn_alterar.UseVisualStyleBackColor = true;
           this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label1.Location = new System.Drawing.Point(19, 34);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(140, 20);
           this.label1.TabIndex = 56;
           this.label1.Text = "BUSCAR GRUPO";
           this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txt_buscar
           // 
           this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_buscar.Location = new System.Drawing.Point(173, 34);
           this.txt_buscar.Margin = new System.Windows.Forms.Padding(0);
           this.txt_buscar.MaxLength = 40;
           this.txt_buscar.Name = "txt_buscar";
           this.txt_buscar.Size = new System.Drawing.Size(350, 22);
           this.txt_buscar.TabIndex = 54;
           this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
           // 
           // frm_tabla_grupo
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(550, 600);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.txt_buscar);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.btn_excluir);
           this.Controls.Add(this.btnAlterar);
           this.Controls.Add(this.btn_nuevo);
           this.Controls.Add(this.dt_lista_grupo);
           this.Controls.Add(this.btn_alterar);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_tabla_grupo";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "LISTADO DE GRUPOS";
           this.Load += new System.EventHandler(this.frm_tabla_grupo_Load);
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_grupo)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView dt_lista_grupo;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}