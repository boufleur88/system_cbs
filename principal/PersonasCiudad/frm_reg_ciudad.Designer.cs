namespace sistema_cbs
{
    partial class frm_reg_ciudad
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
           this.txt_ciudad = new System.Windows.Forms.TextBox();
           this.txt_cod_ciudad = new System.Windows.Forms.TextBox();
           this.btn_guardar = new System.Windows.Forms.Button();
           this.btn_alterar = new System.Windows.Forms.Button();
           this.SuspendLayout();
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label5.Location = new System.Drawing.Point(116, 32);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(188, 20);
           this.label5.TabIndex = 41;
           this.label5.Text = "REGISTRO DE CIUDAD";
           this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label3.Location = new System.Drawing.Point(35, 106);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(72, 20);
           this.label3.TabIndex = 40;
           this.label3.Text = "CIUDAD";
           this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label4.Location = new System.Drawing.Point(35, 77);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(74, 20);
           this.label4.TabIndex = 39;
           this.label4.Text = "CODIGO";
           this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txt_ciudad
           // 
           this.txt_ciudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_ciudad.Location = new System.Drawing.Point(140, 103);
           this.txt_ciudad.Margin = new System.Windows.Forms.Padding(0);
           this.txt_ciudad.MaxLength = 39;
           this.txt_ciudad.Name = "txt_ciudad";
           this.txt_ciudad.Size = new System.Drawing.Size(265, 22);
           this.txt_ciudad.TabIndex = 1;
           this.txt_ciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ciudad_KeyPress);
           // 
           // txt_cod_ciudad
           // 
           this.txt_cod_ciudad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_cod_ciudad.Enabled = false;
           this.txt_cod_ciudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_cod_ciudad.Location = new System.Drawing.Point(140, 75);
           this.txt_cod_ciudad.Margin = new System.Windows.Forms.Padding(0);
           this.txt_cod_ciudad.MaxLength = 40;
           this.txt_cod_ciudad.Name = "txt_cod_ciudad";
           this.txt_cod_ciudad.Size = new System.Drawing.Size(265, 22);
           this.txt_cod_ciudad.TabIndex = 38;
           // 
           // btn_guardar
           // 
           this.btn_guardar.Location = new System.Drawing.Point(111, 148);
           this.btn_guardar.Name = "btn_guardar";
           this.btn_guardar.Size = new System.Drawing.Size(118, 23);
           this.btn_guardar.TabIndex = 36;
           this.btn_guardar.Text = "&GUARDAR";
           this.btn_guardar.UseVisualStyleBackColor = true;
           this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
           // 
           // btn_alterar
           // 
           this.btn_alterar.Location = new System.Drawing.Point(235, 148);
           this.btn_alterar.Name = "btn_alterar";
           this.btn_alterar.Size = new System.Drawing.Size(118, 23);
           this.btn_alterar.TabIndex = 37;
           this.btn_alterar.Text = "&SALIR";
           this.btn_alterar.UseVisualStyleBackColor = true;
           this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
           // 
           // frm_reg_ciudad
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(500, 200);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.txt_ciudad);
           this.Controls.Add(this.txt_cod_ciudad);
           this.Controls.Add(this.btn_guardar);
           this.Controls.Add(this.btn_alterar);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_reg_ciudad";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "frm_reg_ciudad";
           this.Load += new System.EventHandler(this.frm_reg_ciudad_Load);
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.TextBox txt_cod_ciudad;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_alterar;
    }
}