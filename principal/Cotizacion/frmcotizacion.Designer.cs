namespace sistema_cbs
{
   partial class frmcotizacion
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
         this.txtdolar = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.txtreal = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.btn_guardar = new System.Windows.Forms.Button();
         this.btnsalir = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // txtdolar
         // 
         this.txtdolar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtdolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtdolar.Location = new System.Drawing.Point(160, 46);
         this.txtdolar.Margin = new System.Windows.Forms.Padding(0);
         this.txtdolar.MaxLength = 40;
         this.txtdolar.Name = "txtdolar";
         this.txtdolar.Size = new System.Drawing.Size(117, 22);
         this.txtdolar.TabIndex = 71;
         this.txtdolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdolar_KeyPress);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(56, 46);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(90, 20);
         this.label5.TabIndex = 70;
         this.label5.Text = "DOLAR U$";
         this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(56, 81);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(84, 20);
         this.label1.TabIndex = 72;
         this.label1.Text = "REAIS R$";
         this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // txtreal
         // 
         this.txtreal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txtreal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtreal.Location = new System.Drawing.Point(160, 79);
         this.txtreal.Margin = new System.Windows.Forms.Padding(0);
         this.txtreal.MaxLength = 40;
         this.txtreal.Name = "txtreal";
         this.txtreal.Size = new System.Drawing.Size(117, 22);
         this.txtreal.TabIndex = 73;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(74, 9);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(174, 20);
         this.label2.TabIndex = 74;
         this.label2.Text = "COTIZACION DEL DIA";
         this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // btn_guardar
         // 
         this.btn_guardar.Location = new System.Drawing.Point(44, 125);
         this.btn_guardar.Name = "btn_guardar";
         this.btn_guardar.Size = new System.Drawing.Size(102, 24);
         this.btn_guardar.TabIndex = 75;
         this.btn_guardar.Text = "&GUARDAR";
         this.btn_guardar.UseVisualStyleBackColor = true;
         // 
         // btnsalir
         // 
         this.btnsalir.Location = new System.Drawing.Point(175, 125);
         this.btnsalir.Name = "btnsalir";
         this.btnsalir.Size = new System.Drawing.Size(102, 24);
         this.btnsalir.TabIndex = 76;
         this.btnsalir.Text = "&SALIR";
         this.btnsalir.UseVisualStyleBackColor = true;
         this.btnsalir.Click += new System.EventHandler(this.button1_Click);
         // 
         // frmcotizacion
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(341, 181);
         this.Controls.Add(this.btnsalir);
         this.Controls.Add(this.btn_guardar);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtreal);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtdolar);
         this.Controls.Add(this.label5);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmcotizacion";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "COTIZACION DE LAS MONEDAS";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtdolar;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtreal;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btn_guardar;
      private System.Windows.Forms.Button btnsalir;
   }
}