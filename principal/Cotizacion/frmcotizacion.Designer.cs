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
            this.txtCompraUs = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompraRs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtVentaRs = new System.Windows.Forms.TextBox();
            this.txtVentaUs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCompraUs
            // 
            this.txtCompraUs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompraUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompraUs.Location = new System.Drawing.Point(116, 54);
            this.txtCompraUs.Margin = new System.Windows.Forms.Padding(0);
            this.txtCompraUs.MaxLength = 40;
            this.txtCompraUs.Name = "txtCompraUs";
            this.txtCompraUs.Size = new System.Drawing.Size(117, 22);
            this.txtCompraUs.TabIndex = 0;
            this.txtCompraUs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdolar_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "COMPRA U$";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "COMPRA R$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCompraRs
            // 
            this.txtCompraRs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompraRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompraRs.Location = new System.Drawing.Point(116, 87);
            this.txtCompraRs.Margin = new System.Windows.Forms.Padding(0);
            this.txtCompraRs.MaxLength = 40;
            this.txtCompraRs.Name = "txtCompraRs";
            this.txtCompraRs.Size = new System.Drawing.Size(117, 22);
            this.txtCompraRs.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "COTIZACION DEL DIA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(138, 132);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(102, 24);
            this.btn_guardar.TabIndex = 4;
            this.btn_guardar.Text = "&GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(269, 132);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(102, 24);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "&SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVentaRs
            // 
            this.txtVentaRs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVentaRs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaRs.Location = new System.Drawing.Point(354, 87);
            this.txtVentaRs.Margin = new System.Windows.Forms.Padding(0);
            this.txtVentaRs.MaxLength = 40;
            this.txtVentaRs.Name = "txtVentaRs";
            this.txtVentaRs.Size = new System.Drawing.Size(117, 22);
            this.txtVentaRs.TabIndex = 3;
            // 
            // txtVentaUs
            // 
            this.txtVentaUs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVentaUs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVentaUs.Location = new System.Drawing.Point(354, 54);
            this.txtVentaUs.Margin = new System.Windows.Forms.Padding(0);
            this.txtVentaUs.MaxLength = 40;
            this.txtVentaUs.Name = "txtVentaUs";
            this.txtVentaUs.Size = new System.Drawing.Size(117, 22);
            this.txtVentaUs.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "VENTA R$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(248, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 79;
            this.label4.Text = "VENTA U$";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmcotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 179);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVentaRs);
            this.Controls.Add(this.txtVentaUs);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCompraRs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCompraUs);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COTIZACION DE LAS MONEDAS";
            this.Load += new System.EventHandler(this.frmcotizacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtCompraUs;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtCompraRs;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btn_guardar;
      private System.Windows.Forms.Button btnsalir;
      private System.Windows.Forms.TextBox txtVentaRs;
      private System.Windows.Forms.TextBox txtVentaUs;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
   }
}