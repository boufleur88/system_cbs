namespace cbs_sistema
{
    partial class frm_backup
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
           this.btn_dir = new System.Windows.Forms.Button();
           this.btn_alterar = new System.Windows.Forms.Button();
           this.SuspendLayout();
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label4.Location = new System.Drawing.Point(55, 19);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(351, 20);
           this.label4.TabIndex = 45;
           this.label4.Text = "REALIZAR COPIA DE SEGURIDAD - BACKUP";
           this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // btn_dir
           // 
           this.btn_dir.Location = new System.Drawing.Point(124, 58);
           this.btn_dir.Name = "btn_dir";
           this.btn_dir.Size = new System.Drawing.Size(227, 23);
           this.btn_dir.TabIndex = 42;
           this.btn_dir.Text = "GERAR BACKUP";
           this.btn_dir.UseVisualStyleBackColor = true;
           this.btn_dir.Click += new System.EventHandler(this.btn_dir_Click);
           // 
           // btn_alterar
           // 
           this.btn_alterar.Location = new System.Drawing.Point(288, 103);
           this.btn_alterar.Name = "btn_alterar";
           this.btn_alterar.Size = new System.Drawing.Size(118, 23);
           this.btn_alterar.TabIndex = 46;
           this.btn_alterar.Text = "&SALIR";
           this.btn_alterar.UseVisualStyleBackColor = true;
           this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
           // 
           // frm_backup
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(438, 142);
           this.Controls.Add(this.btn_alterar);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.btn_dir);
           this.Name = "frm_backup";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "BACKUP DEL SISTEMA - COPIA DE SEGURIDAD";
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_dir;
        private System.Windows.Forms.Button btn_alterar;
    }
}