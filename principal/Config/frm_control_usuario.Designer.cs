namespace cbs_sistema
{
    partial class frm_control_usuario
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
           this.txt_clave = new System.Windows.Forms.TextBox();
           this.txt_usuario = new System.Windows.Forms.TextBox();
           this.btn_guardar = new System.Windows.Forms.Button();
           this.btn_alterar = new System.Windows.Forms.Button();
           this.SuspendLayout();
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label5.Location = new System.Drawing.Point(108, 19);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(237, 20);
           this.label5.TabIndex = 20;
           this.label5.Text = "CONTROL DE USUARIO - CBS";
           this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label3.Location = new System.Drawing.Point(27, 93);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(62, 20);
           this.label3.TabIndex = 18;
           this.label3.Text = "CLAVE";
           this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label4.Location = new System.Drawing.Point(27, 64);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(79, 20);
           this.label4.TabIndex = 17;
           this.label4.Text = "NOMBRE";
           this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txt_clave
           // 
           this.txt_clave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_clave.Location = new System.Drawing.Point(132, 90);
           this.txt_clave.Margin = new System.Windows.Forms.Padding(0);
           this.txt_clave.MaxLength = 10;
           this.txt_clave.Name = "txt_clave";
           this.txt_clave.Size = new System.Drawing.Size(265, 22);
           this.txt_clave.TabIndex = 1;
           this.txt_clave.UseSystemPasswordChar = true;
           this.txt_clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave_KeyPress);
           // 
           // txt_usuario
           // 
           this.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_usuario.Location = new System.Drawing.Point(132, 62);
           this.txt_usuario.Margin = new System.Windows.Forms.Padding(0);
           this.txt_usuario.MaxLength = 40;
           this.txt_usuario.Name = "txt_usuario";
           this.txt_usuario.Size = new System.Drawing.Size(265, 22);
           this.txt_usuario.TabIndex = 0;
           this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
           // 
           // btn_guardar
           // 
           this.btn_guardar.Location = new System.Drawing.Point(103, 135);
           this.btn_guardar.Name = "btn_guardar";
           this.btn_guardar.Size = new System.Drawing.Size(118, 23);
           this.btn_guardar.TabIndex = 2;
           this.btn_guardar.Text = "ENTRAR";
           this.btn_guardar.UseVisualStyleBackColor = true;
           this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
           // 
           // btn_alterar
           // 
           this.btn_alterar.Location = new System.Drawing.Point(227, 135);
           this.btn_alterar.Name = "btn_alterar";
           this.btn_alterar.Size = new System.Drawing.Size(118, 23);
           this.btn_alterar.TabIndex = 3;
           this.btn_alterar.Text = "&SALIR";
           this.btn_alterar.UseVisualStyleBackColor = true;
           this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
           // 
           // frm_control_usuario
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.BackColor = System.Drawing.SystemColors.ActiveBorder;
           this.ClientSize = new System.Drawing.Size(500, 200);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.txt_clave);
           this.Controls.Add(this.txt_usuario);
           this.Controls.Add(this.btn_guardar);
           this.Controls.Add(this.btn_alterar);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_control_usuario";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "CBS SISTEMA";
           this.Load += new System.EventHandler(this.frm_control_usuario_Load);
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_clave;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_alterar;
    }
}