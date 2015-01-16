namespace cbs_sistema
{
   partial class frmRegGrupoProduto
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
         this.btn_salir = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(136, 24);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(195, 20);
         this.label5.TabIndex = 41;
         this.label5.Text = "REGISTRO DE GRUPOS";
         this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(55, 98);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(68, 20);
         this.label3.TabIndex = 40;
         this.label3.Text = "GRUPO";
         this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(55, 69);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(74, 20);
         this.label4.TabIndex = 39;
         this.label4.Text = "CODIGO";
         this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // txt_grupo
         // 
         this.txt_grupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txt_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txt_grupo.Location = new System.Drawing.Point(160, 95);
         this.txt_grupo.Margin = new System.Windows.Forms.Padding(0);
         this.txt_grupo.MaxLength = 39;
         this.txt_grupo.Name = "txt_grupo";
         this.txt_grupo.Size = new System.Drawing.Size(265, 22);
         this.txt_grupo.TabIndex = 35;
         this.txt_grupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_grupo_KeyPress);
         // 
         // txt_cod_grupo
         // 
         this.txt_cod_grupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txt_cod_grupo.Enabled = false;
         this.txt_cod_grupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txt_cod_grupo.Location = new System.Drawing.Point(160, 67);
         this.txt_cod_grupo.Margin = new System.Windows.Forms.Padding(0);
         this.txt_cod_grupo.MaxLength = 40;
         this.txt_cod_grupo.Name = "txt_cod_grupo";
         this.txt_cod_grupo.Size = new System.Drawing.Size(107, 22);
         this.txt_cod_grupo.TabIndex = 38;
         // 
         // btn_guardar
         // 
         this.btn_guardar.Location = new System.Drawing.Point(131, 140);
         this.btn_guardar.Name = "btn_guardar";
         this.btn_guardar.Size = new System.Drawing.Size(118, 23);
         this.btn_guardar.TabIndex = 36;
         this.btn_guardar.Text = "&GUARDAR";
         this.btn_guardar.UseVisualStyleBackColor = true;
         this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
         // 
         // btn_salir
         // 
         this.btn_salir.Location = new System.Drawing.Point(255, 140);
         this.btn_salir.Name = "btn_salir";
         this.btn_salir.Size = new System.Drawing.Size(118, 23);
         this.btn_salir.TabIndex = 37;
         this.btn_salir.Text = "SALIR";
         this.btn_salir.UseVisualStyleBackColor = true;
         this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
         // 
         // frmRegGrupoProduto
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
         this.Controls.Add(this.btn_salir);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmRegGrupoProduto";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "frmRegGrupoProduto";
         this.Load += new System.EventHandler(this.frmRegGrupoProduto_Load);
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
      private System.Windows.Forms.Button btn_salir;
   }
}