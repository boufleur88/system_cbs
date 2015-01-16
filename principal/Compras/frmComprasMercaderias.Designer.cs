namespace cbs_sistema
{
   partial class frmComprasMercaderias
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
         this.btn_sair = new System.Windows.Forms.Button();
         this.btnAceptar = new System.Windows.Forms.Button();
         this.dt_lista_produto = new System.Windows.Forms.DataGridView();
         this.label1 = new System.Windows.Forms.Label();
         this.txt_buscar = new System.Windows.Forms.TextBox();
         this.btn_nuevo = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.dt_lista_produto)).BeginInit();
         this.SuspendLayout();
         // 
         // btn_sair
         // 
         this.btn_sair.Location = new System.Drawing.Point(930, 672);
         this.btn_sair.Name = "btn_sair";
         this.btn_sair.Size = new System.Drawing.Size(80, 30);
         this.btn_sair.TabIndex = 66;
         this.btn_sair.Text = "&SAIR";
         this.btn_sair.UseVisualStyleBackColor = true;
         this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
         // 
         // btnAceptar
         // 
         this.btnAceptar.Location = new System.Drawing.Point(17, 672);
         this.btnAceptar.Name = "btnAceptar";
         this.btnAceptar.Size = new System.Drawing.Size(80, 30);
         this.btnAceptar.TabIndex = 60;
         this.btnAceptar.Text = "&ACEPTAR";
         this.btnAceptar.UseVisualStyleBackColor = true;
         this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
         // 
         // dt_lista_produto
         // 
         this.dt_lista_produto.AllowUserToDeleteRows = false;
         this.dt_lista_produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
         this.dt_lista_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dt_lista_produto.Location = new System.Drawing.Point(6, 38);
         this.dt_lista_produto.Name = "dt_lista_produto";
         this.dt_lista_produto.ReadOnly = true;
         this.dt_lista_produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.dt_lista_produto.Size = new System.Drawing.Size(1012, 630);
         this.dt_lista_produto.TabIndex = 59;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(23, 15);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(120, 20);
         this.label1.TabIndex = 68;
         this.label1.Text = "DESCRIPCION";
         this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
         // 
         // txt_buscar
         // 
         this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
         this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txt_buscar.Location = new System.Drawing.Point(146, 13);
         this.txt_buscar.Margin = new System.Windows.Forms.Padding(0);
         this.txt_buscar.MaxLength = 40;
         this.txt_buscar.Name = "txt_buscar";
         this.txt_buscar.Size = new System.Drawing.Size(441, 22);
         this.txt_buscar.TabIndex = 0;
         this.txt_buscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_buscar_KeyUp);
         // 
         // btn_nuevo
         // 
         this.btn_nuevo.Location = new System.Drawing.Point(103, 672);
         this.btn_nuevo.Name = "btn_nuevo";
         this.btn_nuevo.Size = new System.Drawing.Size(80, 30);
         this.btn_nuevo.TabIndex = 69;
         this.btn_nuevo.Text = "&NUEVO";
         this.btn_nuevo.UseVisualStyleBackColor = true;
         this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
         // 
         // frmComprasMercaderias
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1024, 740);
         this.Controls.Add(this.btn_nuevo);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txt_buscar);
         this.Controls.Add(this.btn_sair);
         this.Controls.Add(this.btnAceptar);
         this.Controls.Add(this.dt_lista_produto);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Name = "frmComprasMercaderias";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "frmComprasMercaderias";
         this.Load += new System.EventHandler(this.frmComprasMercaderias_Load);
         ((System.ComponentModel.ISupportInitialize)(this.dt_lista_produto)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btn_sair;
      private System.Windows.Forms.Button btnAceptar;
      private System.Windows.Forms.DataGridView dt_lista_produto;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txt_buscar;
      private System.Windows.Forms.Button btn_nuevo;
   }
}