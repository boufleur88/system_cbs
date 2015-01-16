namespace cbs_sistema
{
    partial class frm_registro_usuario
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
           this.label10 = new System.Windows.Forms.Label();
           this.label8 = new System.Windows.Forms.Label();
           this.label9 = new System.Windows.Forms.Label();
           this.label3 = new System.Windows.Forms.Label();
           this.label1 = new System.Windows.Forms.Label();
           this.txt_correo = new System.Windows.Forms.TextBox();
           this.txt_tel1 = new System.Windows.Forms.TextBox();
           this.txt_cedula = new System.Windows.Forms.TextBox();
           this.txt_nombre = new System.Windows.Forms.TextBox();
           this.txt_codigo = new System.Windows.Forms.TextBox();
           this.label2 = new System.Windows.Forms.Label();
           this.label4 = new System.Windows.Forms.Label();
           this.txt_clave1 = new System.Windows.Forms.TextBox();
           this.txt_clave2 = new System.Windows.Forms.TextBox();
           this.btn_alterar = new System.Windows.Forms.Button();
           this.btn_guardar = new System.Windows.Forms.Button();
           this.label5 = new System.Windows.Forms.Label();
           this.txt_usuario = new System.Windows.Forms.TextBox();
           this.SuspendLayout();
           // 
           // label10
           // 
           this.label10.AutoSize = true;
           this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label10.Location = new System.Drawing.Point(12, 208);
           this.label10.Name = "label10";
           this.label10.Size = new System.Drawing.Size(79, 20);
           this.label10.TabIndex = 31;
           this.label10.Text = "CORREO";
           this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label8
           // 
           this.label8.AutoSize = true;
           this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label8.Location = new System.Drawing.Point(12, 176);
           this.label8.Name = "label8";
           this.label8.Size = new System.Drawing.Size(94, 20);
           this.label8.TabIndex = 30;
           this.label8.Text = "TELEFONO";
           this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label9
           // 
           this.label9.AutoSize = true;
           this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label9.Location = new System.Drawing.Point(12, 147);
           this.label9.Name = "label9";
           this.label9.Size = new System.Drawing.Size(75, 20);
           this.label9.TabIndex = 29;
           this.label9.Text = "CEDULA";
           this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label3.Location = new System.Drawing.Point(12, 83);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(79, 20);
           this.label3.TabIndex = 28;
           this.label3.Text = "NOMBRE";
           this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label1.Location = new System.Drawing.Point(12, 52);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(74, 20);
           this.label1.TabIndex = 27;
           this.label1.Text = "CODIGO";
           this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txt_correo
           // 
           this.txt_correo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_correo.Location = new System.Drawing.Point(117, 206);
           this.txt_correo.Margin = new System.Windows.Forms.Padding(0);
           this.txt_correo.MaxLength = 40;
           this.txt_correo.Name = "txt_correo";
           this.txt_correo.Size = new System.Drawing.Size(361, 22);
           this.txt_correo.TabIndex = 5;
           this.txt_correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_correo_KeyPress);
           // 
           // txt_tel1
           // 
           this.txt_tel1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_tel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_tel1.Location = new System.Drawing.Point(117, 176);
           this.txt_tel1.Margin = new System.Windows.Forms.Padding(0);
           this.txt_tel1.MaxLength = 20;
           this.txt_tel1.Name = "txt_tel1";
           this.txt_tel1.Size = new System.Drawing.Size(174, 22);
           this.txt_tel1.TabIndex = 4;
           this.txt_tel1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel1_KeyPress);
           // 
           // txt_cedula
           // 
           this.txt_cedula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_cedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_cedula.Location = new System.Drawing.Point(117, 142);
           this.txt_cedula.Margin = new System.Windows.Forms.Padding(0);
           this.txt_cedula.MaxLength = 10;
           this.txt_cedula.Name = "txt_cedula";
           this.txt_cedula.Size = new System.Drawing.Size(174, 22);
           this.txt_cedula.TabIndex = 2;
           this.txt_cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cedula_KeyPress);
           // 
           // txt_nombre
           // 
           this.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_nombre.Location = new System.Drawing.Point(117, 79);
           this.txt_nombre.Margin = new System.Windows.Forms.Padding(0);
           this.txt_nombre.MaxLength = 40;
           this.txt_nombre.Name = "txt_nombre";
           this.txt_nombre.Size = new System.Drawing.Size(361, 22);
           this.txt_nombre.TabIndex = 0;
           this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
           // 
           // txt_codigo
           // 
           this.txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_codigo.Enabled = false;
           this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_codigo.Location = new System.Drawing.Point(117, 50);
           this.txt_codigo.Margin = new System.Windows.Forms.Padding(0);
           this.txt_codigo.MaxLength = 4;
           this.txt_codigo.Name = "txt_codigo";
           this.txt_codigo.Size = new System.Drawing.Size(104, 22);
           this.txt_codigo.TabIndex = 26;
           this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label2.Location = new System.Drawing.Point(165, 12);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(211, 20);
           this.label2.TabIndex = 37;
           this.label2.Text = "REGISTRO DE USUARIOS";
           this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label4.Location = new System.Drawing.Point(12, 241);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(62, 20);
           this.label4.TabIndex = 39;
           this.label4.Text = "CLAVE";
           this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txt_clave1
           // 
           this.txt_clave1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_clave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_clave1.Location = new System.Drawing.Point(117, 239);
           this.txt_clave1.Margin = new System.Windows.Forms.Padding(0);
           this.txt_clave1.MaxLength = 10;
           this.txt_clave1.Name = "txt_clave1";
           this.txt_clave1.Size = new System.Drawing.Size(174, 22);
           this.txt_clave1.TabIndex = 6;
           this.txt_clave1.UseSystemPasswordChar = true;
           this.txt_clave1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave1_KeyPress);
           // 
           // txt_clave2
           // 
           this.txt_clave2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_clave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_clave2.Location = new System.Drawing.Point(304, 239);
           this.txt_clave2.Margin = new System.Windows.Forms.Padding(0);
           this.txt_clave2.MaxLength = 10;
           this.txt_clave2.Name = "txt_clave2";
           this.txt_clave2.Size = new System.Drawing.Size(174, 22);
           this.txt_clave2.TabIndex = 7;
           this.txt_clave2.UseSystemPasswordChar = true;
           this.txt_clave2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_clave2_KeyPress);
           // 
           // btn_alterar
           // 
           this.btn_alterar.Location = new System.Drawing.Point(289, 282);
           this.btn_alterar.Name = "btn_alterar";
           this.btn_alterar.Size = new System.Drawing.Size(118, 23);
           this.btn_alterar.TabIndex = 43;
           this.btn_alterar.Text = "&CANCELAR";
           this.btn_alterar.UseVisualStyleBackColor = true;
           this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
           // 
           // btn_guardar
           // 
           this.btn_guardar.Location = new System.Drawing.Point(165, 282);
           this.btn_guardar.Name = "btn_guardar";
           this.btn_guardar.Size = new System.Drawing.Size(118, 23);
           this.btn_guardar.TabIndex = 8;
           this.btn_guardar.Text = "&GUARDAR";
           this.btn_guardar.UseVisualStyleBackColor = true;
           this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
           this.btn_guardar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_guardar_KeyPress);
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label5.Location = new System.Drawing.Point(12, 114);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(84, 20);
           this.label5.TabIndex = 44;
           this.label5.Text = "USUARIO";
           this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txt_usuario
           // 
           this.txt_usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_usuario.Location = new System.Drawing.Point(117, 110);
           this.txt_usuario.Margin = new System.Windows.Forms.Padding(0);
           this.txt_usuario.MaxLength = 15;
           this.txt_usuario.Name = "txt_usuario";
           this.txt_usuario.Size = new System.Drawing.Size(174, 22);
           this.txt_usuario.TabIndex = 1;
           this.txt_usuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_usuario_KeyPress);
           // 
           // frm_registro_usuario
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.BackColor = System.Drawing.SystemColors.ControlLight;
           this.ClientSize = new System.Drawing.Size(550, 332);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.txt_usuario);
           this.Controls.Add(this.btn_alterar);
           this.Controls.Add(this.btn_guardar);
           this.Controls.Add(this.txt_clave2);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.txt_clave1);
           this.Controls.Add(this.label2);
           this.Controls.Add(this.label10);
           this.Controls.Add(this.label8);
           this.Controls.Add(this.label9);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.txt_correo);
           this.Controls.Add(this.txt_tel1);
           this.Controls.Add(this.txt_cedula);
           this.Controls.Add(this.txt_nombre);
           this.Controls.Add(this.txt_codigo);
           this.ForeColor = System.Drawing.Color.Black;
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_registro_usuario";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "frm_registro_usuario";
           this.Load += new System.EventHandler(this.frm_registro_usuario_Load);
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_tel1;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_clave1;
        private System.Windows.Forms.TextBox txt_clave2;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_usuario;
    }
}