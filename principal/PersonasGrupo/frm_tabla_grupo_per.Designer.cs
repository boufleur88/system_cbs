﻿namespace sistema_cbs
{
    partial class frm_tabla_grupo_per
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
           this.label1 = new System.Windows.Forms.Label();
           this.btn_buscar = new System.Windows.Forms.Button();
           this.txt_buscar = new System.Windows.Forms.TextBox();
           this.label5 = new System.Windows.Forms.Label();
           this.btn_excluir = new System.Windows.Forms.Button();
           this.btn_alterar = new System.Windows.Forms.Button();
           this.btn_nuevo = new System.Windows.Forms.Button();
           this.dt_lista_grupo_per = new System.Windows.Forms.DataGridView();
           this.btn_salir = new System.Windows.Forms.Button();
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_grupo_per)).BeginInit();
           this.SuspendLayout();
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label1.Location = new System.Drawing.Point(29, 61);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(140, 20);
           this.label1.TabIndex = 65;
           this.label1.Text = "BUSCAR GRUPO";
           this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // btn_buscar
           // 
           this.btn_buscar.Location = new System.Drawing.Point(469, 60);
           this.btn_buscar.Name = "btn_buscar";
           this.btn_buscar.Size = new System.Drawing.Size(102, 24);
           this.btn_buscar.TabIndex = 64;
           this.btn_buscar.Text = "&BUSCAR";
           this.btn_buscar.UseVisualStyleBackColor = true;
           this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click_1);
           // 
           // txt_buscar
           // 
           this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_buscar.Location = new System.Drawing.Point(178, 61);
           this.txt_buscar.Margin = new System.Windows.Forms.Padding(0);
           this.txt_buscar.MaxLength = 40;
           this.txt_buscar.Name = "txt_buscar";
           this.txt_buscar.Size = new System.Drawing.Size(265, 22);
           this.txt_buscar.TabIndex = 63;
           this.txt_buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_buscar_KeyPress);
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label5.Location = new System.Drawing.Point(174, 19);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(277, 20);
           this.label5.TabIndex = 62;
           this.label5.Text = "REGISTRO DE GRUPO PERSONAS";
           this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // btn_excluir
           // 
           this.btn_excluir.Location = new System.Drawing.Point(175, 549);
           this.btn_excluir.Name = "btn_excluir";
           this.btn_excluir.Size = new System.Drawing.Size(65, 23);
           this.btn_excluir.TabIndex = 61;
           this.btn_excluir.Text = "&EXCLUIR";
           this.btn_excluir.UseVisualStyleBackColor = true;
           this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
           // 
           // btn_alterar
           // 
           this.btn_alterar.Location = new System.Drawing.Point(104, 549);
           this.btn_alterar.Name = "btn_alterar";
           this.btn_alterar.Size = new System.Drawing.Size(65, 23);
           this.btn_alterar.TabIndex = 60;
           this.btn_alterar.Text = "&ALTERAR";
           this.btn_alterar.UseVisualStyleBackColor = true;
           this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
           // 
           // btn_nuevo
           // 
           this.btn_nuevo.Location = new System.Drawing.Point(35, 549);
           this.btn_nuevo.Name = "btn_nuevo";
           this.btn_nuevo.Size = new System.Drawing.Size(65, 23);
           this.btn_nuevo.TabIndex = 59;
           this.btn_nuevo.Text = "&NUEVO";
           this.btn_nuevo.UseVisualStyleBackColor = true;
           this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
           // 
           // dt_lista_grupo_per
           // 
           this.dt_lista_grupo_per.AllowUserToDeleteRows = false;
           this.dt_lista_grupo_per.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
           this.dt_lista_grupo_per.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.dt_lista_grupo_per.Location = new System.Drawing.Point(32, 102);
           this.dt_lista_grupo_per.Name = "dt_lista_grupo_per";
           this.dt_lista_grupo_per.ReadOnly = true;
           this.dt_lista_grupo_per.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
           this.dt_lista_grupo_per.Size = new System.Drawing.Size(539, 441);
           this.dt_lista_grupo_per.TabIndex = 58;
           this.dt_lista_grupo_per.DoubleClick += new System.EventHandler(this.dt_lista_grupo_per_DoubleClick);
           // 
           // btn_salir
           // 
           this.btn_salir.Location = new System.Drawing.Point(506, 549);
           this.btn_salir.Name = "btn_salir";
           this.btn_salir.Size = new System.Drawing.Size(65, 23);
           this.btn_salir.TabIndex = 57;
           this.btn_salir.Text = "&SALIR";
           this.btn_salir.UseVisualStyleBackColor = true;
           this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
           // 
           // frm_tabla_grupo_per
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(613, 582);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.btn_buscar);
           this.Controls.Add(this.txt_buscar);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.btn_excluir);
           this.Controls.Add(this.btn_alterar);
           this.Controls.Add(this.btn_nuevo);
           this.Controls.Add(this.dt_lista_grupo_per);
           this.Controls.Add(this.btn_salir);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_tabla_grupo_per";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "frm_tabla_grupo_per";
           this.Load += new System.EventHandler(this.frm_tabla_grupo_per_Load);
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_grupo_per)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.DataGridView dt_lista_grupo_per;
        private System.Windows.Forms.Button btn_salir;
    }
}