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
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtVentas = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodigoVenta = new System.Windows.Forms.TextBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarClientes = new System.Windows.Forms.Button();
            this.btnMercaderia = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTotalVenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnServicios = new System.Windows.Forms.Button();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtVentas)).BeginInit();
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
            // txtFecha
            // 
            this.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(116, 9);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(0);
            this.txtFecha.MaxLength = 40;
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(97, 22);
            this.txtFecha.TabIndex = 65;
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
            // dtVentas
            // 
            this.dtVentas.AllowUserToAddRows = false;
            this.dtVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRIPCION,
            this.CANTIDAD,
            this.PRECIO,
            this.TOTAL});
            this.dtVentas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dtVentas.Location = new System.Drawing.Point(5, 133);
            this.dtVentas.MultiSelect = false;
            this.dtVentas.Name = "dtVentas";
            this.dtVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtVentas.Size = new System.Drawing.Size(1012, 492);
            this.dtVentas.TabIndex = 63;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(175, 40);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(0);
            this.txtNombre.MaxLength = 40;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(292, 22);
            this.txtNombre.TabIndex = 69;
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(624, 41);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.txtTelefono.MaxLength = 40;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(168, 22);
            this.txtTelefono.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(520, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 74;
            this.label3.Text = "TELEFONO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRuc
            // 
            this.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuc.Location = new System.Drawing.Point(841, 41);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(0);
            this.txtRuc.MaxLength = 40;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(134, 22);
            this.txtRuc.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(795, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 77;
            this.label6.Text = "RUC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtObservacion
            // 
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(116, 71);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(0);
            this.txtObservacion.MaxLength = 40;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(859, 22);
            this.txtObservacion.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 71);
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
            // txtCodigoVenta
            // 
            this.txtCodigoVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVenta.Location = new System.Drawing.Point(841, 9);
            this.txtCodigoVenta.Margin = new System.Windows.Forms.Padding(0);
            this.txtCodigoVenta.MaxLength = 40;
            this.txtCodigoVenta.Name = "txtCodigoVenta";
            this.txtCodigoVenta.Size = new System.Drawing.Size(134, 22);
            this.txtCodigoVenta.TabIndex = 81;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.Location = new System.Drawing.Point(116, 40);
            this.txtCodCliente.Margin = new System.Windows.Forms.Padding(0);
            this.txtCodCliente.MaxLength = 40;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(48, 22);
            this.txtCodCliente.TabIndex = 86;
            // 
            // btnBuscarClientes
            // 
            this.btnBuscarClientes.Location = new System.Drawing.Point(475, 38);
            this.btnBuscarClientes.Name = "btnBuscarClientes";
            this.btnBuscarClientes.Size = new System.Drawing.Size(38, 24);
            this.btnBuscarClientes.TabIndex = 87;
            this.btnBuscarClientes.Text = "ADD";
            this.btnBuscarClientes.UseVisualStyleBackColor = true;
            this.btnBuscarClientes.Click += new System.EventHandler(this.btnBuscarClientes_Click);
            // 
            // btnMercaderia
            // 
            this.btnMercaderia.Location = new System.Drawing.Point(12, 101);
            this.btnMercaderia.Name = "btnMercaderia";
            this.btnMercaderia.Size = new System.Drawing.Size(106, 24);
            this.btnMercaderia.TabIndex = 91;
            this.btnMercaderia.Text = "MERCADERIA";
            this.btnMercaderia.UseVisualStyleBackColor = true;
            this.btnMercaderia.Click += new System.EventHandler(this.btnMercaderia_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(900, 101);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(102, 24);
            this.btn_salir.TabIndex = 95;
            this.btn_salir.Text = "&SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(792, 101);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(102, 24);
            this.btnFactura.TabIndex = 93;
            this.btnFactura.Text = "&FACTURA";
            this.btnFactura.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(684, 101);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 24);
            this.btnGuardar.TabIndex = 92;
            this.btnGuardar.Text = "&GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // txtTotalVenta
            // 
            this.txtTotalVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalVenta.Location = new System.Drawing.Point(857, 639);
            this.txtTotalVenta.Margin = new System.Windows.Forms.Padding(0);
            this.txtTotalVenta.MaxLength = 40;
            this.txtTotalVenta.Name = "txtTotalVenta";
            this.txtTotalVenta.Size = new System.Drawing.Size(145, 22);
            this.txtTotalVenta.TabIndex = 97;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(787, 639);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 96;
            this.label10.Text = "TOTAL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnServicios
            // 
            this.btnServicios.Location = new System.Drawing.Point(124, 101);
            this.btnServicios.Name = "btnServicios";
            this.btnServicios.Size = new System.Drawing.Size(106, 24);
            this.btnServicios.TabIndex = 98;
            this.btnServicios.Text = "&SERVICIOS";
            this.btnServicios.UseVisualStyleBackColor = true;
            this.btnServicios.Click += new System.EventHandler(this.btnServicios_Click);
            // 
            // CODIGO
            // 
            this.CODIGO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.Width = 80;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 450;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.Name = "CANTIDAD";
            // 
            // PRECIO
            // 
            this.PRECIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Width = 200;
            // 
            // TOTAL
            // 
            this.TOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TOTAL.FillWeight = 200F;
            this.TOTAL.HeaderText = "TOTAL";
            this.TOTAL.Name = "TOTAL";
            this.TOTAL.ReadOnly = true;
            // 
            // frm_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 740);
            this.Controls.Add(this.btnServicios);
            this.Controls.Add(this.txtTotalVenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnMercaderia);
            this.Controls.Add(this.btnBuscarClientes);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCodigoVenta);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTAS CONTADO Y CREDITO";
            this.Load += new System.EventHandler(this.frm_ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtVentas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodigoVenta;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Button btnBuscarClientes;
        private System.Windows.Forms.Button btnMercaderia;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTotalVenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL;
    }
}