namespace sistema_cbs
{
    partial class frm_reg_marca
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
           this.label3 = new System.Windows.Forms.Label();
           this.label4 = new System.Windows.Forms.Label();
           this.txt_marca = new System.Windows.Forms.TextBox();
           this.txt_cod_marca = new System.Windows.Forms.TextBox();
           this.btn_guardar = new System.Windows.Forms.Button();
           this.btn_alterar = new System.Windows.Forms.Button();
           this.SuspendLayout();
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label5.Location = new System.Drawing.Point(128, 22);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(194, 20);
           this.label5.TabIndex = 27;
           this.label5.Text = "REGISTRO DE MARCAS";
           this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label3.Location = new System.Drawing.Point(47, 96);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(67, 20);
           this.label3.TabIndex = 26;
           this.label3.Text = "MARCA";
           this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label4.Location = new System.Drawing.Point(47, 67);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(74, 20);
           this.label4.TabIndex = 25;
           this.label4.Text = "CODIGO";
           this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txt_marca
           // 
           this.txt_marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_marca.Location = new System.Drawing.Point(152, 93);
           this.txt_marca.Margin = new System.Windows.Forms.Padding(0);
           this.txt_marca.MaxLength = 40;
           this.txt_marca.Name = "txt_marca";
           this.txt_marca.Size = new System.Drawing.Size(265, 22);
           this.txt_marca.TabIndex = 0;
           this.txt_marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_marca_KeyPress);
           // 
           // txt_cod_marca
           // 
           this.txt_cod_marca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_cod_marca.Enabled = false;
           this.txt_cod_marca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_cod_marca.Location = new System.Drawing.Point(152, 65);
           this.txt_cod_marca.Margin = new System.Windows.Forms.Padding(0);
           this.txt_cod_marca.MaxLength = 40;
           this.txt_cod_marca.Name = "txt_cod_marca";
           this.txt_cod_marca.Size = new System.Drawing.Size(107, 22);
           this.txt_cod_marca.TabIndex = 21;
           this.txt_cod_marca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cod_marca_KeyPress);
           // 
           // btn_guardar
           // 
           this.btn_guardar.Location = new System.Drawing.Point(123, 138);
           this.btn_guardar.Name = "btn_guardar";
           this.btn_guardar.Size = new System.Drawing.Size(118, 23);
           this.btn_guardar.TabIndex = 1;
           this.btn_guardar.Text = "&GUARDAR";
           this.btn_guardar.UseVisualStyleBackColor = true;
           this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
           this.btn_guardar.Leave += new System.EventHandler(this.btn_guardar_Leave);
           // 
           // btn_alterar
           // 
           this.btn_alterar.Location = new System.Drawing.Point(247, 138);
           this.btn_alterar.Name = "btn_alterar";
           this.btn_alterar.Size = new System.Drawing.Size(118, 23);
           this.btn_alterar.TabIndex = 2;
           this.btn_alterar.Text = "SALIR";
           this.btn_alterar.UseVisualStyleBackColor = true;
           this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
           // 
           // frm_reg_marca
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(500, 200);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.txt_marca);
           this.Controls.Add(this.txt_cod_marca);
           this.Controls.Add(this.btn_guardar);
           this.Controls.Add(this.btn_alterar);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_reg_marca";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "REGISTRO DE MARCAS";
           this.Load += new System.EventHandler(this.frm_reg_marca_Load);
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.TextBox txt_cod_marca;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_alterar;
    }
}