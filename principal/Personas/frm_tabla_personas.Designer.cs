namespace sistema_cbs
{
    partial class frm_tabla_personas
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
           this.btn_nuevo = new System.Windows.Forms.Button();
           this.dt_lista_personas = new System.Windows.Forms.DataGridView();
           this.btn_salir = new System.Windows.Forms.Button();
           this.button1 = new System.Windows.Forms.Button();
           this.button2 = new System.Windows.Forms.Button();
           this.btn_historico = new System.Windows.Forms.Button();
           this.button3 = new System.Windows.Forms.Button();
           this.label1 = new System.Windows.Forms.Label();
           this.btn_buscar = new System.Windows.Forms.Button();
           this.txt_buscar = new System.Windows.Forms.TextBox();
           this.button5 = new System.Windows.Forms.Button();
           this.button6 = new System.Windows.Forms.Button();
           this.button7 = new System.Windows.Forms.Button();
           this.button4 = new System.Windows.Forms.Button();
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_personas)).BeginInit();
           this.SuspendLayout();
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label5.Location = new System.Drawing.Point(376, 9);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(217, 20);
           this.label5.TabIndex = 44;
           this.label5.Text = "CATALOGO DE PERSONAS";
           this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // btn_excluir
           // 
           this.btn_excluir.Location = new System.Drawing.Point(181, 704);
           this.btn_excluir.Name = "btn_excluir";
           this.btn_excluir.Size = new System.Drawing.Size(80, 30);
           this.btn_excluir.TabIndex = 3;
           this.btn_excluir.Text = "&EXCLUIR";
           this.btn_excluir.UseVisualStyleBackColor = true;
           this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
           // 
           // btn_alterar
           // 
           this.btn_alterar.Location = new System.Drawing.Point(97, 704);
           this.btn_alterar.Name = "btn_alterar";
           this.btn_alterar.Size = new System.Drawing.Size(80, 30);
           this.btn_alterar.TabIndex = 2;
           this.btn_alterar.Text = "&ALTERAR";
           this.btn_alterar.UseVisualStyleBackColor = true;
           this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
           // 
           // btn_nuevo
           // 
           this.btn_nuevo.Location = new System.Drawing.Point(14, 704);
           this.btn_nuevo.Name = "btn_nuevo";
           this.btn_nuevo.Size = new System.Drawing.Size(80, 30);
           this.btn_nuevo.TabIndex = 1;
           this.btn_nuevo.Text = "&NUEVO";
           this.btn_nuevo.UseVisualStyleBackColor = true;
           this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
           // 
           // dt_lista_personas
           // 
           this.dt_lista_personas.AllowUserToDeleteRows = false;
           this.dt_lista_personas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
           this.dt_lista_personas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
           this.dt_lista_personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.dt_lista_personas.Location = new System.Drawing.Point(6, 68);
           this.dt_lista_personas.Name = "dt_lista_personas";
           this.dt_lista_personas.ReadOnly = true;
           this.dt_lista_personas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
           this.dt_lista_personas.Size = new System.Drawing.Size(1012, 630);
           this.dt_lista_personas.TabIndex = 0;
           this.dt_lista_personas.DoubleClick += new System.EventHandler(this.dt_lista_personas_DoubleClick);
           // 
           // btn_salir
           // 
           this.btn_salir.Location = new System.Drawing.Point(930, 704);
           this.btn_salir.Name = "btn_salir";
           this.btn_salir.Size = new System.Drawing.Size(80, 30);
           this.btn_salir.TabIndex = 8;
           this.btn_salir.Text = "&SALIR";
           this.btn_salir.UseVisualStyleBackColor = true;
           this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
           // 
           // button1
           // 
           this.button1.Location = new System.Drawing.Point(430, 704);
           this.button1.Name = "button1";
           this.button1.Size = new System.Drawing.Size(80, 30);
           this.button1.TabIndex = 6;
           this.button1.UseVisualStyleBackColor = true;
           // 
           // button2
           // 
           this.button2.Location = new System.Drawing.Point(347, 704);
           this.button2.Name = "button2";
           this.button2.Size = new System.Drawing.Size(80, 30);
           this.button2.TabIndex = 5;
           this.button2.Text = "&CTA CTE";
           this.button2.UseVisualStyleBackColor = true;
           // 
           // btn_historico
           // 
           this.btn_historico.Location = new System.Drawing.Point(264, 704);
           this.btn_historico.Name = "btn_historico";
           this.btn_historico.Size = new System.Drawing.Size(80, 30);
           this.btn_historico.TabIndex = 4;
           this.btn_historico.Text = "&HISTORICO";
           this.btn_historico.UseVisualStyleBackColor = true;
           // 
           // button3
           // 
           this.button3.Location = new System.Drawing.Point(513, 704);
           this.button3.Name = "button3";
           this.button3.Size = new System.Drawing.Size(80, 30);
           this.button3.TabIndex = 7;
           this.button3.UseVisualStyleBackColor = true;
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label1.Location = new System.Drawing.Point(51, 43);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(170, 20);
           this.label1.TabIndex = 62;
           this.label1.Text = "BUSCAR PERSONAS";
           this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // btn_buscar
           // 
           this.btn_buscar.Location = new System.Drawing.Point(596, 34);
           this.btn_buscar.Name = "btn_buscar";
           this.btn_buscar.Size = new System.Drawing.Size(80, 30);
           this.btn_buscar.TabIndex = 61;
           this.btn_buscar.Text = "&BUSCAR";
           this.btn_buscar.UseVisualStyleBackColor = true;
           this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
           // 
           // txt_buscar
           // 
           this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_buscar.Location = new System.Drawing.Point(224, 42);
           this.txt_buscar.Margin = new System.Windows.Forms.Padding(0);
           this.txt_buscar.MaxLength = 40;
           this.txt_buscar.Name = "txt_buscar";
           this.txt_buscar.Size = new System.Drawing.Size(356, 22);
           this.txt_buscar.TabIndex = 60;
           this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
           // 
           // button5
           // 
           this.button5.Location = new System.Drawing.Point(762, 704);
           this.button5.Name = "button5";
           this.button5.Size = new System.Drawing.Size(80, 30);
           this.button5.TabIndex = 64;
           this.button5.UseVisualStyleBackColor = true;
           // 
           // button6
           // 
           this.button6.Location = new System.Drawing.Point(679, 704);
           this.button6.Name = "button6";
           this.button6.Size = new System.Drawing.Size(80, 30);
           this.button6.TabIndex = 65;
           this.button6.UseVisualStyleBackColor = true;
           // 
           // button7
           // 
           this.button7.Location = new System.Drawing.Point(596, 704);
           this.button7.Name = "button7";
           this.button7.Size = new System.Drawing.Size(80, 30);
           this.button7.TabIndex = 66;
           this.button7.UseVisualStyleBackColor = true;
           // 
           // button4
           // 
           this.button4.Location = new System.Drawing.Point(846, 704);
           this.button4.Name = "button4";
           this.button4.Size = new System.Drawing.Size(80, 30);
           this.button4.TabIndex = 67;
           this.button4.UseVisualStyleBackColor = true;
           // 
           // frm_tabla_personas
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(1024, 740);
           this.Controls.Add(this.button4);
           this.Controls.Add(this.button7);
           this.Controls.Add(this.button6);
           this.Controls.Add(this.button5);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.btn_buscar);
           this.Controls.Add(this.txt_buscar);
           this.Controls.Add(this.button3);
           this.Controls.Add(this.button1);
           this.Controls.Add(this.button2);
           this.Controls.Add(this.btn_historico);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.btn_excluir);
           this.Controls.Add(this.btn_alterar);
           this.Controls.Add(this.btn_nuevo);
           this.Controls.Add(this.dt_lista_personas);
           this.Controls.Add(this.btn_salir);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_tabla_personas";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "frm_tabla_personas";
           this.Load += new System.EventHandler(this.frm_tabla_personas_Load);
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_personas)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView dt_lista_personas;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_historico;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
    }
}