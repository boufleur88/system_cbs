namespace sistema_cbs
{
    partial class frm_ventas
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
           this.label1 = new System.Windows.Forms.Label();
           this.txt_buscar = new System.Windows.Forms.TextBox();
           this.label5 = new System.Windows.Forms.Label();
           this.dt_lista_personas = new System.Windows.Forms.DataGridView();
           this.btn_guardar = new System.Windows.Forms.Button();
           this.textBox1 = new System.Windows.Forms.TextBox();
           this.textBox2 = new System.Windows.Forms.TextBox();
           this.label2 = new System.Windows.Forms.Label();
           this.textBox3 = new System.Windows.Forms.TextBox();
           this.label3 = new System.Windows.Forms.Label();
           this.textBox4 = new System.Windows.Forms.TextBox();
           this.label4 = new System.Windows.Forms.Label();
           this.textBox6 = new System.Windows.Forms.TextBox();
           this.label6 = new System.Windows.Forms.Label();
           this.textBox7 = new System.Windows.Forms.TextBox();
           this.label7 = new System.Windows.Forms.Label();
           this.label8 = new System.Windows.Forms.Label();
           this.textBox8 = new System.Windows.Forms.TextBox();
           this.btn_factura = new System.Windows.Forms.Button();
           this.btn_ticket = new System.Windows.Forms.Button();
           this.btn_salir = new System.Windows.Forms.Button();
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_personas)).BeginInit();
           this.SuspendLayout();
           // 
           // label1
           // 
           this.label1.AutoSize = true;
           this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label1.Location = new System.Drawing.Point(12, 11);
           this.label1.Name = "label1";
           this.label1.Size = new System.Drawing.Size(64, 20);
           this.label1.TabIndex = 67;
           this.label1.Text = "FECHA";
           this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txt_buscar
           // 
           this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txt_buscar.Location = new System.Drawing.Point(116, 9);
           this.txt_buscar.Margin = new System.Windows.Forms.Padding(0);
           this.txt_buscar.MaxLength = 40;
           this.txt_buscar.Name = "txt_buscar";
           this.txt_buscar.Size = new System.Drawing.Size(134, 22);
           this.txt_buscar.TabIndex = 65;
           // 
           // label5
           // 
           this.label5.AutoSize = true;
           this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label5.Location = new System.Drawing.Point(12, 40);
           this.label5.Name = "label5";
           this.label5.Size = new System.Drawing.Size(76, 20);
           this.label5.TabIndex = 64;
           this.label5.Text = "CLIENTE";
           this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // dt_lista_personas
           // 
           this.dt_lista_personas.AllowUserToAddRows = false;
           this.dt_lista_personas.AllowUserToDeleteRows = false;
           this.dt_lista_personas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
           this.dt_lista_personas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
           this.dt_lista_personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.dt_lista_personas.Location = new System.Drawing.Point(6, 138);
           this.dt_lista_personas.Name = "dt_lista_personas";
           this.dt_lista_personas.ReadOnly = true;
           this.dt_lista_personas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
           this.dt_lista_personas.Size = new System.Drawing.Size(1012, 560);
           this.dt_lista_personas.TabIndex = 63;
           // 
           // btn_guardar
           // 
           this.btn_guardar.Location = new System.Drawing.Point(3, 704);
           this.btn_guardar.Name = "btn_guardar";
           this.btn_guardar.Size = new System.Drawing.Size(102, 24);
           this.btn_guardar.TabIndex = 68;
           this.btn_guardar.Text = "&GUARDAR";
           this.btn_guardar.UseVisualStyleBackColor = true;
           // 
           // textBox1
           // 
           this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.textBox1.Location = new System.Drawing.Point(116, 40);
           this.textBox1.Margin = new System.Windows.Forms.Padding(0);
           this.textBox1.MaxLength = 40;
           this.textBox1.Name = "textBox1";
           this.textBox1.Size = new System.Drawing.Size(351, 22);
           this.textBox1.TabIndex = 69;
           // 
           // textBox2
           // 
           this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.textBox2.Location = new System.Drawing.Point(624, 38);
           this.textBox2.Margin = new System.Windows.Forms.Padding(0);
           this.textBox2.MaxLength = 40;
           this.textBox2.Name = "textBox2";
           this.textBox2.Size = new System.Drawing.Size(351, 22);
           this.textBox2.TabIndex = 71;
           // 
           // label2
           // 
           this.label2.AutoSize = true;
           this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label2.Location = new System.Drawing.Point(520, 38);
           this.label2.Name = "label2";
           this.label2.Size = new System.Drawing.Size(88, 20);
           this.label2.TabIndex = 70;
           this.label2.Text = "FANTASIA";
           this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // textBox3
           // 
           this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.textBox3.Location = new System.Drawing.Point(624, 70);
           this.textBox3.Margin = new System.Windows.Forms.Padding(0);
           this.textBox3.MaxLength = 40;
           this.textBox3.Name = "textBox3";
           this.textBox3.Size = new System.Drawing.Size(168, 22);
           this.textBox3.TabIndex = 75;
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label3.Location = new System.Drawing.Point(520, 70);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(94, 20);
           this.label3.TabIndex = 74;
           this.label3.Text = "TELEFONO";
           this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // textBox4
           // 
           this.textBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.textBox4.Location = new System.Drawing.Point(116, 72);
           this.textBox4.Margin = new System.Windows.Forms.Padding(0);
           this.textBox4.MaxLength = 40;
           this.textBox4.Name = "textBox4";
           this.textBox4.Size = new System.Drawing.Size(351, 22);
           this.textBox4.TabIndex = 73;
           // 
           // label4
           // 
           this.label4.AutoSize = true;
           this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label4.Location = new System.Drawing.Point(12, 72);
           this.label4.Name = "label4";
           this.label4.Size = new System.Drawing.Size(99, 20);
           this.label4.TabIndex = 72;
           this.label4.Text = "DIRECCION";
           this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // textBox6
           // 
           this.textBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.textBox6.Location = new System.Drawing.Point(841, 70);
           this.textBox6.Margin = new System.Windows.Forms.Padding(0);
           this.textBox6.MaxLength = 40;
           this.textBox6.Name = "textBox6";
           this.textBox6.Size = new System.Drawing.Size(134, 22);
           this.textBox6.TabIndex = 78;
           // 
           // label6
           // 
           this.label6.AutoSize = true;
           this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label6.Location = new System.Drawing.Point(795, 70);
           this.label6.Name = "label6";
           this.label6.Size = new System.Drawing.Size(44, 20);
           this.label6.TabIndex = 77;
           this.label6.Text = "RUC";
           this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // textBox7
           // 
           this.textBox7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.textBox7.Location = new System.Drawing.Point(116, 103);
           this.textBox7.Margin = new System.Windows.Forms.Padding(0);
           this.textBox7.MaxLength = 40;
           this.textBox7.Name = "textBox7";
           this.textBox7.Size = new System.Drawing.Size(859, 22);
           this.textBox7.TabIndex = 80;
           // 
           // label7
           // 
           this.label7.AutoSize = true;
           this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label7.Location = new System.Drawing.Point(12, 103);
           this.label7.Name = "label7";
           this.label7.Size = new System.Drawing.Size(43, 20);
           this.label7.TabIndex = 79;
           this.label7.Text = "OBS";
           this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // label8
           // 
           this.label8.AutoSize = true;
           this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label8.Location = new System.Drawing.Point(755, 9);
           this.label8.Name = "label8";
           this.label8.Size = new System.Drawing.Size(83, 20);
           this.label8.TabIndex = 82;
           this.label8.Text = "Nº VENTA";
           this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // textBox8
           // 
           this.textBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.textBox8.Location = new System.Drawing.Point(841, 9);
           this.textBox8.Margin = new System.Windows.Forms.Padding(0);
           this.textBox8.MaxLength = 40;
           this.textBox8.Name = "textBox8";
           this.textBox8.Size = new System.Drawing.Size(134, 22);
           this.textBox8.TabIndex = 81;
           // 
           // btn_factura
           // 
           this.btn_factura.Location = new System.Drawing.Point(111, 704);
           this.btn_factura.Name = "btn_factura";
           this.btn_factura.Size = new System.Drawing.Size(102, 24);
           this.btn_factura.TabIndex = 83;
           this.btn_factura.Text = "&FACTURA";
           this.btn_factura.UseVisualStyleBackColor = true;
           // 
           // btn_ticket
           // 
           this.btn_ticket.Location = new System.Drawing.Point(219, 704);
           this.btn_ticket.Name = "btn_ticket";
           this.btn_ticket.Size = new System.Drawing.Size(102, 24);
           this.btn_ticket.TabIndex = 84;
           this.btn_ticket.Text = "&TICKET";
           this.btn_ticket.UseVisualStyleBackColor = true;
           // 
           // btn_salir
           // 
           this.btn_salir.Location = new System.Drawing.Point(916, 704);
           this.btn_salir.Name = "btn_salir";
           this.btn_salir.Size = new System.Drawing.Size(102, 24);
           this.btn_salir.TabIndex = 85;
           this.btn_salir.Text = "&SALIR";
           this.btn_salir.UseVisualStyleBackColor = true;
           this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
           // 
           // frm_ventas
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(1024, 740);
           this.Controls.Add(this.btn_salir);
           this.Controls.Add(this.btn_ticket);
           this.Controls.Add(this.btn_factura);
           this.Controls.Add(this.label8);
           this.Controls.Add(this.textBox8);
           this.Controls.Add(this.textBox7);
           this.Controls.Add(this.label7);
           this.Controls.Add(this.textBox6);
           this.Controls.Add(this.label6);
           this.Controls.Add(this.textBox3);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.textBox4);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.textBox2);
           this.Controls.Add(this.label2);
           this.Controls.Add(this.textBox1);
           this.Controls.Add(this.btn_guardar);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.txt_buscar);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.dt_lista_personas);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_ventas";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "VENTAS CONTADO Y CREDITO";
           this.Load += new System.EventHandler(this.frm_ventas_Load);
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista_personas)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dt_lista_personas;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.Button btn_ticket;
        private System.Windows.Forms.Button btn_salir;
    }
}