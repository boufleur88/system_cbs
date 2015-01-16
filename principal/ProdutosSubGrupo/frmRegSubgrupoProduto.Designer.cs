namespace cbs_sistema
{
   partial class frmRegSubgrupoProduto
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
         this.txt_subgrupo = new System.Windows.Forms.TextBox();
         this.txt_cod_subgrupo = new System.Windows.Forms.TextBox();
         this.btn_guardar = new System.Windows.Forms.Button();
         this.btn_salir = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(142, 23);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(233, 20);
         this.label5.TabIndex = 48;
         this.label5.Text = "REGISTRO DE SUB GRUPOS";
         this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(61, 97);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(106, 20);
         this.label3.TabIndex = 47;
         this.label3.Text = "SUB GRUPO";
         this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(61, 68);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(74, 20);
         this.label4.TabIndex = 46;
         this.label4.Text = "CODIGO";
         this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // txt_subgrupo
         // 
         this.txt_subgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txt_subgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txt_subgrupo.Location = new System.Drawing.Point(166, 94);
         this.txt_subgrupo.Margin = new System.Windows.Forms.Padding(0);
         this.txt_subgrupo.MaxLength = 39;
         this.txt_subgrupo.Name = "txt_subgrupo";
         this.txt_subgrupo.Size = new System.Drawing.Size(265, 22);
         this.txt_subgrupo.TabIndex = 42;
         this.txt_subgrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_subgrupo_KeyPress);
         // 
         // txt_cod_subgrupo
         // 
         this.txt_cod_subgrupo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txt_cod_subgrupo.Enabled = false;
         this.txt_cod_subgrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txt_cod_subgrupo.Location = new System.Drawing.Point(166, 66);
         this.txt_cod_subgrupo.Margin = new System.Windows.Forms.Padding(0);
         this.txt_cod_subgrupo.MaxLength = 40;
         this.txt_cod_subgrupo.Name = "txt_cod_subgrupo";
         this.txt_cod_subgrupo.Size = new System.Drawing.Size(107, 22);
         this.txt_cod_subgrupo.TabIndex = 45;
         // 
         // btn_guardar
         // 
         this.btn_guardar.Location = new System.Drawing.Point(137, 139);
         this.btn_guardar.Name = "btn_guardar";
         this.btn_guardar.Size = new System.Drawing.Size(118, 23);
         this.btn_guardar.TabIndex = 43;
         this.btn_guardar.Text = "&GUARDAR";
         this.btn_guardar.UseVisualStyleBackColor = true;
         this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
         // 
         // btn_salir
         // 
         this.btn_salir.Location = new System.Drawing.Point(261, 139);
         this.btn_salir.Name = "btn_salir";
         this.btn_salir.Size = new System.Drawing.Size(118, 23);
         this.btn_salir.TabIndex = 44;
         this.btn_salir.Text = "&SALIR";
         this.btn_salir.UseVisualStyleBackColor = true;
         this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
         // 
         // frmRegSubgrupoProduto
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(500, 200);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.txt_subgrupo);
         this.Controls.Add(this.txt_cod_subgrupo);
         this.Controls.Add(this.btn_guardar);
         this.Controls.Add(this.btn_salir);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmRegSubgrupoProduto";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "REGISTRO DE SUBGRUPO";
         this.Load += new System.EventHandler(this.frmRegSubgrupoProduto_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.TextBox txt_subgrupo;
      private System.Windows.Forms.TextBox txt_cod_subgrupo;
      private System.Windows.Forms.Button btn_guardar;
      private System.Windows.Forms.Button btn_salir;
   }
}