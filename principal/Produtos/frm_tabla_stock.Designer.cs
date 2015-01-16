namespace sistema_cbs
{
    partial class frm_tabla_stock
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
           this.btn_alterar = new System.Windows.Forms.Button();
           this.btn_1 = new System.Windows.Forms.Button();
           this.dt_lista_produto = new System.Windows.Forms.DataGridView();
           this.btn_salir = new System.Windows.Forms.Button();
           this.btn_nuevo = new System.Windows.Forms.Button();
           this.btn_historico = new System.Windows.Forms.Button();
           this.button2 = new System.Windows.Forms.Button();
           this.button3 = new System.Windows.Forms.Button();
           this.btn_sair = new System.Windows.Forms.Button();
           this.txt_buscar = new System.Windows.Forms.TextBox();
           this.btn_buscar = new System.Windows.Forms.Button();
           this.label1 = new System.Windows.Forms.Label();
           this.button1 = new System.Windows.Forms.Button();
           this.button4 = new System.Windows.Forms.Button();
           this.button5 = new System.Windows.Forms.Button();
           this.button6 = new System.Windows.Forms.Button();
           this.button7 = new System.Windows.Forms.Button();
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_produto)).BeginInit();
           this.SuspendLayout();
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label5.Location = new System.Drawing.Point(380, 9);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(248, 20);
           this.label5.TabIndex = 50;
           this.label5.Text = "CATALOGO DE MERCADERIAS";
           this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // btn_excluir
           // 
           this.btn_excluir.Location = new System.Drawing.Point(431, 703);
           this.btn_excluir.Name = "btn_excluir";
           this.btn_excluir.Size = new System.Drawing.Size(80, 30);
           this.btn_excluir.TabIndex = 6;
           this.btn_excluir.UseVisualStyleBackColor = true;
           this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
           // 
           // btn_alterar
           // 
           this.btn_alterar.Location = new System.Drawing.Point(99, 703);
           this.btn_alterar.Name = "btn_alterar";
           this.btn_alterar.Size = new System.Drawing.Size(80, 30);
           this.btn_alterar.TabIndex = 2;
           this.btn_alterar.Text = "&ALTERAR";
           this.btn_alterar.UseVisualStyleBackColor = true;
           this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
           // 
           // btn_1
           // 
           this.btn_1.Location = new System.Drawing.Point(-120, 530);
           this.btn_1.Name = "btn_1";
           this.btn_1.Size = new System.Drawing.Size(65, 23);
           this.btn_1.TabIndex = 47;
           this.btn_1.Text = "&NUEVO";
           this.btn_1.UseVisualStyleBackColor = true;
           // 
           // dt_lista_produto
           // 
           this.dt_lista_produto.AllowUserToDeleteRows = false;
           this.dt_lista_produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
           this.dt_lista_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.dt_lista_produto.Location = new System.Drawing.Point(5, 69);
           this.dt_lista_produto.Name = "dt_lista_produto";
           this.dt_lista_produto.ReadOnly = true;
           this.dt_lista_produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
           this.dt_lista_produto.Size = new System.Drawing.Size(1012, 630);
           this.dt_lista_produto.TabIndex = 0;
           this.dt_lista_produto.DoubleClick += new System.EventHandler(this.dt_lista_produto_DoubleClick);
           // 
           // btn_salir
           // 
           this.btn_salir.Location = new System.Drawing.Point(1283, 706);
           this.btn_salir.Name = "btn_salir";
           this.btn_salir.Size = new System.Drawing.Size(90, 24);
           this.btn_salir.TabIndex = 8;
           this.btn_salir.Text = "SALIR";
           this.btn_salir.UseVisualStyleBackColor = true;
           this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
           // 
           // btn_nuevo
           // 
           this.btn_nuevo.Location = new System.Drawing.Point(16, 703);
           this.btn_nuevo.Name = "btn_nuevo";
           this.btn_nuevo.Size = new System.Drawing.Size(80, 30);
           this.btn_nuevo.TabIndex = 1;
           this.btn_nuevo.Text = "&NUEVO";
           this.btn_nuevo.UseVisualStyleBackColor = true;
           this.btn_nuevo.Click += new System.EventHandler(this.button1_Click);
           // 
           // btn_historico
           // 
           this.btn_historico.Location = new System.Drawing.Point(265, 703);
           this.btn_historico.Name = "btn_historico";
           this.btn_historico.Size = new System.Drawing.Size(80, 30);
           this.btn_historico.TabIndex = 4;
           this.btn_historico.Text = "&HISTORICO";
           this.btn_historico.UseVisualStyleBackColor = true;
           this.btn_historico.Click += new System.EventHandler(this.btn_historico_Click);
           // 
           // button2
           // 
           this.button2.Location = new System.Drawing.Point(182, 703);
           this.button2.Name = "button2";
           this.button2.Size = new System.Drawing.Size(80, 30);
           this.button2.TabIndex = 3;
           this.button2.Text = "&EXCLUIR";
           this.button2.UseVisualStyleBackColor = true;
           this.button2.Click += new System.EventHandler(this.button2_Click);
           // 
           // button3
           // 
           this.button3.Location = new System.Drawing.Point(348, 703);
           this.button3.Name = "button3";
           this.button3.Size = new System.Drawing.Size(80, 30);
           this.button3.TabIndex = 5;
           this.button3.UseVisualStyleBackColor = true;
           this.button3.Click += new System.EventHandler(this.button3_Click);
           // 
           // btn_sair
           // 
           this.btn_sair.Location = new System.Drawing.Point(929, 703);
           this.btn_sair.Name = "btn_sair";
           this.btn_sair.Size = new System.Drawing.Size(80, 30);
           this.btn_sair.TabIndex = 7;
           this.btn_sair.Text = "&SAIR";
           this.btn_sair.UseVisualStyleBackColor = true;
           this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
           // 
           // txt_buscar
           // 
           this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_buscar.Location = new System.Drawing.Point(135, 36);
           this.txt_buscar.Margin = new System.Windows.Forms.Padding(0);
           this.txt_buscar.MaxLength = 40;
           this.txt_buscar.Name = "txt_buscar";
           this.txt_buscar.Size = new System.Drawing.Size(441, 22);
           this.txt_buscar.TabIndex = 51;
           // 
           // btn_buscar
           // 
           this.btn_buscar.Location = new System.Drawing.Point(597, 34);
           this.btn_buscar.Name = "btn_buscar";
           this.btn_buscar.Size = new System.Drawing.Size(80, 30);
           this.btn_buscar.TabIndex = 52;
           this.btn_buscar.Text = "&BUSCAR";
           this.btn_buscar.UseVisualStyleBackColor = true;
           this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label1.Location = new System.Drawing.Point(12, 38);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(120, 20);
           this.label1.TabIndex = 53;
           this.label1.Text = "DESCRIPCION";
           this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // button1
           // 
           this.button1.Location = new System.Drawing.Point(514, 704);
           this.button1.Name = "button1";
           this.button1.Size = new System.Drawing.Size(80, 30);
           this.button1.TabIndex = 54;
           this.button1.UseVisualStyleBackColor = true;
           // 
           // button4
           // 
           this.button4.Location = new System.Drawing.Point(597, 704);
           this.button4.Name = "button4";
           this.button4.Size = new System.Drawing.Size(80, 30);
           this.button4.TabIndex = 55;
           this.button4.UseVisualStyleBackColor = true;
           // 
           // button5
           // 
           this.button5.Location = new System.Drawing.Point(680, 704);
           this.button5.Name = "button5";
           this.button5.Size = new System.Drawing.Size(80, 30);
           this.button5.TabIndex = 56;
           this.button5.UseVisualStyleBackColor = true;
           // 
           // button6
           // 
           this.button6.Location = new System.Drawing.Point(763, 703);
           this.button6.Name = "button6";
           this.button6.Size = new System.Drawing.Size(80, 30);
           this.button6.TabIndex = 57;
           this.button6.UseVisualStyleBackColor = true;
           // 
           // button7
           // 
           this.button7.Location = new System.Drawing.Point(846, 703);
           this.button7.Name = "button7";
           this.button7.Size = new System.Drawing.Size(80, 30);
           this.button7.TabIndex = 58;
           this.button7.UseVisualStyleBackColor = true;
           // 
           // frm_tabla_stock
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(1024, 740);
           this.Controls.Add(this.button6);
           this.Controls.Add(this.button7);
           this.Controls.Add(this.button1);
           this.Controls.Add(this.button4);
           this.Controls.Add(this.button5);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.btn_buscar);
           this.Controls.Add(this.txt_buscar);
           this.Controls.Add(this.btn_sair);
           this.Controls.Add(this.btn_historico);
           this.Controls.Add(this.button2);
           this.Controls.Add(this.button3);
           this.Controls.Add(this.btn_nuevo);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.btn_excluir);
           this.Controls.Add(this.btn_alterar);
           this.Controls.Add(this.btn_1);
           this.Controls.Add(this.dt_lista_produto);
           this.Controls.Add(this.btn_salir);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_tabla_stock";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "frm_tabla_stock";
           this.Load += new System.EventHandler(this.frm_tabla_stock_Load);
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_produto)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.DataGridView dt_lista_produto;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_historico;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}