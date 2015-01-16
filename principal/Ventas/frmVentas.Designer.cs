namespace cbs_sistema
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
           this.label5 = new System.Windows.Forms.Label();
           this.dt_lista = new System.Windows.Forms.DataGridView();
           this.btn_guardar = new System.Windows.Forms.Button();
           this.txtcliente = new System.Windows.Forms.TextBox();
           this.txttelefono = new System.Windows.Forms.TextBox();
           this.label3 = new System.Windows.Forms.Label();
           this.txtdireccion = new System.Windows.Forms.TextBox();
           this.label4 = new System.Windows.Forms.Label();
           this.txtruc = new System.Windows.Forms.TextBox();
           this.label6 = new System.Windows.Forms.Label();
           this.txtobservacion = new System.Windows.Forms.TextBox();
           this.label7 = new System.Windows.Forms.Label();
           this.label8 = new System.Windows.Forms.Label();
           this.txtcodigo = new System.Windows.Forms.TextBox();
           this.btn_factura = new System.Windows.Forms.Button();
           this.btn_ticket = new System.Windows.Forms.Button();
           this.btn_salir = new System.Windows.Forms.Button();
           this.btnAddMercaderia = new System.Windows.Forms.Button();
           this.btnAddProveedor = new System.Windows.Forms.Button();
           this.txtFecha = new System.Windows.Forms.MaskedTextBox();
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista)).BeginInit();
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
           // dt_lista
           // 
           this.dt_lista.AllowUserToAddRows = false;
           this.dt_lista.AllowUserToDeleteRows = false;
           this.dt_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
           this.dt_lista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
           this.dt_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
           this.dt_lista.Location = new System.Drawing.Point(6, 157);
           this.dt_lista.Name = "dt_lista";
           this.dt_lista.ReadOnly = true;
           this.dt_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
           this.dt_lista.Size = new System.Drawing.Size(1012, 541);
           this.dt_lista.TabIndex = 63;
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
           // txtcliente
           // 
           this.txtcliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txtcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txtcliente.Location = new System.Drawing.Point(116, 40);
           this.txtcliente.Margin = new System.Windows.Forms.Padding(0);
           this.txtcliente.MaxLength = 40;
           this.txtcliente.Name = "txtcliente";
           this.txtcliente.Size = new System.Drawing.Size(351, 22);
           this.txtcliente.TabIndex = 69;
           // 
           // txttelefono
           // 
           this.txttelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txttelefono.Location = new System.Drawing.Point(630, 40);
           this.txttelefono.Margin = new System.Windows.Forms.Padding(0);
           this.txttelefono.MaxLength = 40;
           this.txttelefono.Name = "txttelefono";
           this.txttelefono.Size = new System.Drawing.Size(168, 22);
           this.txttelefono.TabIndex = 75;
           // 
           // label3
           // 
           this.label3.AutoSize = true;
           this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label3.Location = new System.Drawing.Point(533, 40);
           this.label3.Name = "label3";
           this.label3.Size = new System.Drawing.Size(94, 20);
           this.label3.TabIndex = 74;
           this.label3.Text = "TELEFONO";
           this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txtdireccion
           // 
           this.txtdireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txtdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txtdireccion.Location = new System.Drawing.Point(116, 72);
           this.txtdireccion.Margin = new System.Windows.Forms.Padding(0);
           this.txtdireccion.MaxLength = 40;
           this.txtdireccion.Name = "txtdireccion";
           this.txtdireccion.Size = new System.Drawing.Size(351, 22);
           this.txtdireccion.TabIndex = 73;
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
           // txtruc
           // 
           this.txtruc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txtruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txtruc.Location = new System.Drawing.Point(863, 40);
           this.txtruc.Margin = new System.Windows.Forms.Padding(0);
           this.txtruc.MaxLength = 40;
           this.txtruc.Name = "txtruc";
           this.txtruc.Size = new System.Drawing.Size(134, 22);
           this.txtruc.TabIndex = 78;
           // 
           // label6
           // 
           this.label6.AutoSize = true;
           this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.label6.Location = new System.Drawing.Point(816, 40);
           this.label6.Name = "label6";
           this.label6.Size = new System.Drawing.Size(44, 20);
           this.label6.TabIndex = 77;
           this.label6.Text = "RUC";
           this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txtobservacion
           // 
           this.txtobservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txtobservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txtobservacion.Location = new System.Drawing.Point(116, 103);
           this.txtobservacion.Margin = new System.Windows.Forms.Padding(0);
           this.txtobservacion.MaxLength = 40;
           this.txtobservacion.Name = "txtobservacion";
           this.txtobservacion.Size = new System.Drawing.Size(881, 22);
           this.txtobservacion.TabIndex = 80;
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
           this.label8.Location = new System.Drawing.Point(777, 9);
           this.label8.Name = "label8";
           this.label8.Size = new System.Drawing.Size(83, 20);
           this.label8.TabIndex = 82;
           this.label8.Text = "Nº VENTA";
           this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
           // 
           // txtcodigo
           // 
           this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
           this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txtcodigo.Location = new System.Drawing.Point(863, 9);
           this.txtcodigo.Margin = new System.Windows.Forms.Padding(0);
           this.txtcodigo.MaxLength = 40;
           this.txtcodigo.Name = "txtcodigo";
           this.txtcodigo.Size = new System.Drawing.Size(134, 22);
           this.txtcodigo.TabIndex = 81;
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
           // btnAddMercaderia
           // 
           this.btnAddMercaderia.Location = new System.Drawing.Point(845, 128);
           this.btnAddMercaderia.Name = "btnAddMercaderia";
           this.btnAddMercaderia.Size = new System.Drawing.Size(167, 27);
           this.btnAddMercaderia.TabIndex = 86;
           this.btnAddMercaderia.Text = "ADICIONAR MERCADERIAS";
           this.btnAddMercaderia.UseVisualStyleBackColor = true;
           this.btnAddMercaderia.Click += new System.EventHandler(this.btnAddMercaderia_Click);
           // 
           // btnAddProveedor
           // 
           this.btnAddProveedor.Location = new System.Drawing.Point(470, 38);
           this.btnAddProveedor.Name = "btnAddProveedor";
           this.btnAddProveedor.Size = new System.Drawing.Size(51, 27);
           this.btnAddProveedor.TabIndex = 87;
           this.btnAddProveedor.Text = "ADD";
           this.btnAddProveedor.UseVisualStyleBackColor = true;
           this.btnAddProveedor.Click += new System.EventHandler(this.btnAddProveedor_Click);
           // 
           // txtFecha
           // 
           this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           this.txtFecha.Location = new System.Drawing.Point(116, 11);
           this.txtFecha.Mask = "00/00/0000";
           this.txtFecha.Name = "txtFecha";
           this.txtFecha.Size = new System.Drawing.Size(87, 22);
           this.txtFecha.TabIndex = 88;
           this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
           // 
           // frm_ventas
           // 
           this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
           this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
           this.ClientSize = new System.Drawing.Size(1024, 740);
           this.Controls.Add(this.txtFecha);
           this.Controls.Add(this.btnAddProveedor);
           this.Controls.Add(this.btnAddMercaderia);
           this.Controls.Add(this.btn_salir);
           this.Controls.Add(this.btn_ticket);
           this.Controls.Add(this.btn_factura);
           this.Controls.Add(this.label8);
           this.Controls.Add(this.txtcodigo);
           this.Controls.Add(this.txtobservacion);
           this.Controls.Add(this.label7);
           this.Controls.Add(this.txtruc);
           this.Controls.Add(this.label6);
           this.Controls.Add(this.txttelefono);
           this.Controls.Add(this.label3);
           this.Controls.Add(this.txtdireccion);
           this.Controls.Add(this.label4);
           this.Controls.Add(this.txtcliente);
           this.Controls.Add(this.btn_guardar);
           this.Controls.Add(this.label1);
           this.Controls.Add(this.label5);
           this.Controls.Add(this.dt_lista);
           this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           this.Name = "frm_ventas";
           this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
           this.Text = "VENTAS CONTADO Y CREDITO";
           this.Load += new System.EventHandler(this.frm_ventas_Load);
           ((System.ComponentModel.ISupportInitialize)(this.dt_lista)).EndInit();
           this.ResumeLayout(false);
           this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dt_lista;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtruc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.Button btn_ticket;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btnAddMercaderia;
        private System.Windows.Forms.Button btnAddProveedor;
        private System.Windows.Forms.MaskedTextBox txtFecha;
    }
}