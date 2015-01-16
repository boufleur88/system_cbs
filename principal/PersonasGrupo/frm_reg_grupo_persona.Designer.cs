namespace cbs_sistema
{
    partial class frm_reg_grupo_persona
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
           this.txt_grupo = new System.Windows.Forms.TextBox();
           this.txt_cod_grupo = new System.Windows.Forms.TextBox();
           this.btn_guardar = new System.Windows.Forms.Button();
           this.btn_alterar = new System.Windows.Forms.Button();
           this.SuspendLayout();
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label5.Location = new System.Drawing.Point(106, 9);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(304, 20);
           this.label5.TabIndex = 48;
           this.label5.Text = "REGISTRO DE GRUPO DE PERSONAS";
           this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label3.Location = new System.Drawing.Point(34, 82);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(68, 20);
           this.label3.TabIndex = 47;
           this.label3.Text = "GRUPO";
           this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label4.Location = new System.Drawing.Point(34, 53);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(74, 20);
           this.label4.TabIndex = 46;
           this.label4.Text = "CODIGO";
           this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txt_grupo
           // 
           this.txt_grupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_grupo.Location = new System.Drawing.Point(139, 79);
           this.txt_grupo.Margin = new System.Windows.Forms.Padding(0);
           this.txt_grupo.MaxLength = 39;
           this.txt_grupo.Name = "txt_grupo";
           this.txt_grupo.Size = new System.Drawing.Size(265, 22);
           this.txt_grupo.TabIndex = 0;
           this.txt_grupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_grupo_KeyPress);
           // 
           // txt_cod_grupo
           // 
           this.txt_cod_grupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_cod_grupo.Enabled = false;
           this.txt_cod_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_cod_grupo.Location = new System.Drawing.Point(139, 51);
           this.txt_cod_grupo.Margin = new System.Windows.Forms.Padding(0);
           this.txt_cod_grupo.MaxLength = 40;
           this.txt_cod_grupo.Name = "txt_cod_grupo";
           this.txt_cod_grupo.Size = new System.Drawing.Size(265, 22);
           this.txt_cod_grupo.TabIndex = 45;
           this.txt_cod_grupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cod_grupo_KeyPress);
           // 
           // btn_guardar
           // 
           this.btn_guardar.Location = new System.Drawing.Point(110, 124);
           this.btn_guardar.Name = "btn_guardar";
           this.btn_guardar.Size = new System.Drawing.Size(118, 23);
           this.btn_guardar.TabIndex = 1;
           this.btn_guardar.Text = "&GUARDAR";
           this.btn_guardar.UseVisualStyleBackColor = true;
           this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
           // 
           // btn_alterar
           // 
           this.btn_alterar.Location = new System.Drawing.Point(234, 124);
           this.btn_alterar.Name = "btn_alterar";
           this.btn_alterar.Size = new System.Drawing.Size(118, 23);
           this.btn_alterar.TabIndex = 2;
           this.btn_alterar.Text = "&SALIR";
           this.btn_alterar.UseVisualStyleBackColor = true;
           this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
           // 
           // frm_reg_grupo_persona
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(500, 200);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.txt_grupo);
           this.Controls.Add(this.txt_cod_grupo);
           this.Controls.Add(this.btn_guardar);
           this.Controls.Add(this.btn_alterar);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_reg_grupo_persona";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "frm_reg_grupo_persona";
           this.Load += new System.EventHandler(this.frm_reg_grupo_persona_Load);
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_grupo;
        private System.Windows.Forms.TextBox txt_cod_grupo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_alterar;
    }
}