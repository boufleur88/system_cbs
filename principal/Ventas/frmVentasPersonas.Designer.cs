namespace cbs_sistema
{
   partial class frmVentasPersonas
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
         this.btn_nuevo = new System.Windows.Forms.Button();
         this.btnAceptar = new System.Windows.Forms.Button();
         this.btn_salir = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.txt_buscar = new System.Windows.Forms.TextBox();
         this.dt_lista_personas = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.dt_lista_personas)).BeginInit();
         this.SuspendLayout();
         // 
         // btn_nuevo
         // 
         this.btn_nuevo.Location = new System.Drawing.Point(99, 704);
         this.btn_nuevo.Name = "btn_nuevo";
         this.btn_nuevo.Size = new System.Drawing.Size(80, 30);
         this.btn_nuevo.TabIndex = 99;
         this.btn_nuevo.Text = "&NUEVO";
         this.btn_nuevo.UseVisualStyleBackColor = true;
         this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
         // 
         // btnAceptar
         // 
         this.btnAceptar.Location = new System.Drawing.Point(13, 704);
         this.btnAceptar.Name = "btnAceptar";
         this.btnAceptar.Size = new System.Drawing.Size(80, 30);
         this.btnAceptar.TabIndex = 98;
         this.btnAceptar.Text = "&ACEPTAR";
         this.btnAceptar.UseVisualStyleBackColor = true;
         this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
         // 
         // btn_salir
         // 
         this.btn_salir.Location = new System.Drawing.Point(933, 704);
         this.btn_salir.Name = "btn_salir";
         this.btn_salir.Size = new System.Drawing.Size(80, 30);
         this.btn_salir.TabIndex = 97;
         this.btn_salir.Text = "&SALIR";
         this.btn_salir.UseVisualStyleBackColor = true;
         this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(25, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(170, 20);
         this.label1.TabIndex = 96;
         this.label1.Text = "BUSCAR PERSONAS";
         this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // txt_buscar
         // 
         this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txt_buscar.Location = new System.Drawing.Point(208, 7);
         this.txt_buscar.Margin = new System.Windows.Forms.Padding(0);
         this.txt_buscar.MaxLength = 40;
         this.txt_buscar.Name = "txt_buscar";
         this.txt_buscar.Size = new System.Drawing.Size(356, 22);
         this.txt_buscar.TabIndex = 95;
         this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
         // 
         // dt_lista_personas
         // 
         this.dt_lista_personas.AllowUserToDeleteRows = false;
         this.dt_lista_personas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.dt_lista_personas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
         this.dt_lista_personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dt_lista_personas.Location = new System.Drawing.Point(6, 32);
         this.dt_lista_personas.Name = "dt_lista_personas";
         this.dt_lista_personas.ReadOnly = true;
         this.dt_lista_personas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dt_lista_personas.Size = new System.Drawing.Size(1012, 666);
         this.dt_lista_personas.TabIndex = 94;
         // 
         // frmVentasPersonas
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1024, 740);
         this.Controls.Add(this.btn_nuevo);
         this.Controls.Add(this.btnAceptar);
         this.Controls.Add(this.btn_salir);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txt_buscar);
         this.Controls.Add(this.dt_lista_personas);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmVentasPersonas";
         this.Text = "frmVentasPersonas";
         this.Load += new System.EventHandler(this.frmVentasPersonas_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dt_lista_personas)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btn_nuevo;
      private System.Windows.Forms.Button btnAceptar;
      private System.Windows.Forms.Button btn_salir;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txt_buscar;
      private System.Windows.Forms.DataGridView dt_lista_personas;
   }
}