namespace sistema_cbs
{
    partial class frm_compra
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dtLista = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venta1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venta2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdicionarProveedor = new System.Windows.Forms.Button();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnFactura = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtInclusion = new System.Windows.Forms.MaskedTextBox();
            this.txtVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIva10 = new System.Windows.Forms.TextBox();
            this.txtIva05 = new System.Windows.Forms.TextBox();
            this.txtIva00 = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.MaskedTextBox();
            this.txtTimbrado = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.OptContado = new System.Windows.Forms.RadioButton();
            this.OptCredito = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(906, 128);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(102, 24);
            this.btnSalir.TabIndex = 90;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(122, 128);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 24);
            this.btnGuardar.TabIndex = 87;
            this.btnGuardar.Text = "&GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dtLista
            // 
            this.dtLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtLista.Location = new System.Drawing.Point(12, 159);
            this.dtLista.Name = "dtLista";
            this.dtLista.Size = new System.Drawing.Size(996, 489);
            this.dtLista.TabIndex = 129;
            // 
            // codigo
            // 
            this.codigo.Frozen = true;
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.Width = 74;
            // 
            // description
            // 
            this.description.Frozen = true;
            this.description.HeaderText = "DESCRIPCION";
            this.description.Name = "description";
            this.description.Width = 105;
            // 
            // cant
            // 
            this.cant.Frozen = true;
            this.cant.HeaderText = "CANTIDAD";
            this.cant.Name = "cant";
            this.cant.Width = 87;
            // 
            // costo
            // 
            this.costo.Frozen = true;
            this.costo.HeaderText = "COSTO";
            this.costo.Name = "costo";
            this.costo.Width = 69;
            // 
            // venta1
            // 
            this.venta1.Frozen = true;
            this.venta1.HeaderText = "MAYORISTA";
            this.venta1.Name = "venta1";
            this.venta1.Width = 95;
            // 
            // venta2
            // 
            this.venta2.Frozen = true;
            this.venta2.HeaderText = "MAYORISTA";
            this.venta2.Name = "venta2";
            this.venta2.Width = 95;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 107;
            this.label8.Text = "Nº COMPRA";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCompra.Location = new System.Drawing.Point(122, 4);
            this.txtIdCompra.Margin = new System.Windows.Forms.Padding(0);
            this.txtIdCompra.MaxLength = 40;
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(99, 26);
            this.txtIdCompra.TabIndex = 3;
            // 
            // txtObservacion
            // 
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(151, 100);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(0);
            this.txtObservacion.MaxLength = 80;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(841, 26);
            this.txtObservacion.TabIndex = 105;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 104;
            this.label7.Text = "OBS";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRuc
            // 
            this.txtRuc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRuc.Enabled = false;
            this.txtRuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuc.Location = new System.Drawing.Point(858, 70);
            this.txtRuc.Margin = new System.Windows.Forms.Padding(0);
            this.txtRuc.MaxLength = 40;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(134, 26);
            this.txtRuc.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(814, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 102;
            this.label6.Text = "RUC";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(663, 70);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(0);
            this.txtTelefono.MaxLength = 40;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(146, 26);
            this.txtTelefono.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 99;
            this.label3.Text = "TELEFONO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtProveedor
            // 
            this.txtProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.Location = new System.Drawing.Point(203, 70);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.txtProveedor.MaxLength = 40;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(312, 26);
            this.txtProveedor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 93;
            this.label1.Text = "FECHA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "PROVEEDOR";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdicionarProveedor
            // 
            this.btnAdicionarProveedor.Location = new System.Drawing.Point(520, 71);
            this.btnAdicionarProveedor.Name = "btnAdicionarProveedor";
            this.btnAdicionarProveedor.Size = new System.Drawing.Size(39, 20);
            this.btnAdicionarProveedor.TabIndex = 6;
            this.btnAdicionarProveedor.Text = "ADD";
            this.btnAdicionarProveedor.UseVisualStyleBackColor = true;
            this.btnAdicionarProveedor.Click += new System.EventHandler(this.btnPersonas_Click);
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdProveedor.Enabled = false;
            this.txtIdProveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.Location = new System.Drawing.Point(153, 70);
            this.txtIdProveedor.Margin = new System.Windows.Forms.Padding(0);
            this.txtIdProveedor.MaxLength = 40;
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(45, 26);
            this.txtIdProveedor.TabIndex = 4;
            this.txtIdProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProveedor_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(189, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 111;
            this.label9.Text = "VENCIMIENTO";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(14, 128);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(102, 24);
            this.btnProductos.TabIndex = 112;
            this.btnProductos.Text = "MERCADERIAS";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnFactura
            // 
            this.btnFactura.Location = new System.Drawing.Point(230, 129);
            this.btnFactura.Name = "btnFactura";
            this.btnFactura.Size = new System.Drawing.Size(102, 24);
            this.btnFactura.TabIndex = 113;
            this.btnFactura.Text = "&FACTURAR";
            this.btnFactura.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(338, 129);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(102, 24);
            this.btnImprimir.TabIndex = 114;
            this.btnImprimir.Text = "&IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // txtInclusion
            // 
            this.txtInclusion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInclusion.Location = new System.Drawing.Point(94, 37);
            this.txtInclusion.Mask = "99/99/9999";
            this.txtInclusion.Name = "txtInclusion";
            this.txtInclusion.Size = new System.Drawing.Size(89, 26);
            this.txtInclusion.TabIndex = 0;
            this.txtInclusion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInclusion_KeyPress);
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVencimiento.Location = new System.Drawing.Point(291, 37);
            this.txtVencimiento.Mask = "99/99/9999";
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(89, 26);
            this.txtVencimiento.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(781, 725);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 118;
            this.label2.Text = "TOTAL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(865, 725);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(0);
            this.txtTotal.MaxLength = 40;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(134, 26);
            this.txtTotal.TabIndex = 117;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(396, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 119;
            this.label4.Text = "FACTURA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIva10
            // 
            this.txtIva10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIva10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva10.Location = new System.Drawing.Point(782, 681);
            this.txtIva10.Margin = new System.Windows.Forms.Padding(0);
            this.txtIva10.MaxLength = 40;
            this.txtIva10.Name = "txtIva10";
            this.txtIva10.Size = new System.Drawing.Size(101, 26);
            this.txtIva10.TabIndex = 120;
            // 
            // txtIva05
            // 
            this.txtIva05.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIva05.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva05.Location = new System.Drawing.Point(675, 681);
            this.txtIva05.Margin = new System.Windows.Forms.Padding(0);
            this.txtIva05.MaxLength = 40;
            this.txtIva05.Name = "txtIva05";
            this.txtIva05.Size = new System.Drawing.Size(101, 26);
            this.txtIva05.TabIndex = 121;
            // 
            // txtIva00
            // 
            this.txtIva00.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIva00.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva00.Location = new System.Drawing.Point(568, 681);
            this.txtIva00.Margin = new System.Windows.Forms.Padding(0);
            this.txtIva00.MaxLength = 40;
            this.txtIva00.Name = "txtIva00";
            this.txtIva00.Size = new System.Drawing.Size(101, 26);
            this.txtIva00.TabIndex = 122;
            // 
            // txtFactura
            // 
            this.txtFactura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(478, 37);
            this.txtFactura.Mask = "000-000-0000000";
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(134, 26);
            this.txtFactura.TabIndex = 123;
            // 
            // txtTimbrado
            // 
            this.txtTimbrado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimbrado.Location = new System.Drawing.Point(706, 37);
            this.txtTimbrado.Mask = "00000000";
            this.txtTimbrado.Name = "txtTimbrado";
            this.txtTimbrado.Size = new System.Drawing.Size(81, 26);
            this.txtTimbrado.TabIndex = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(624, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 16);
            this.label10.TabIndex = 124;
            this.label10.Text = "TIMBRADO";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(808, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 126;
            this.label11.Text = "CONDICION";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OptContado
            // 
            this.OptContado.AutoSize = true;
            this.OptContado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptContado.Location = new System.Drawing.Point(907, 27);
            this.OptContado.Name = "OptContado";
            this.OptContado.Size = new System.Drawing.Size(74, 20);
            this.OptContado.TabIndex = 127;
            this.OptContado.TabStop = true;
            this.OptContado.Text = "Contado";
            this.OptContado.UseVisualStyleBackColor = true;
            // 
            // OptCredito
            // 
            this.OptCredito.AutoSize = true;
            this.OptCredito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptCredito.Location = new System.Drawing.Point(907, 47);
            this.OptCredito.Name = "OptCredito";
            this.OptCredito.Size = new System.Drawing.Size(67, 20);
            this.OptCredito.TabIndex = 128;
            this.OptCredito.TabStop = true;
            this.OptCredito.Text = "Credito";
            this.OptCredito.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 24);
            this.button1.TabIndex = 130;
            this.button1.Text = "teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OptCredito);
            this.Controls.Add(this.OptContado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTimbrado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.txtIva00);
            this.Controls.Add(this.txtIva05);
            this.Controls.Add(this.txtIva10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtVencimiento);
            this.Controls.Add(this.txtInclusion);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnFactura);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.btnAdicionarProveedor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIdCompra);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRuc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPRAS CONTADO Y CREDITO";
            this.Load += new System.EventHandler(this.frm_compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dtLista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdicionarProveedor;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnFactura;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.MaskedTextBox txtInclusion;
        private System.Windows.Forms.MaskedTextBox txtVencimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIva10;
        private System.Windows.Forms.TextBox txtIva05;
        private System.Windows.Forms.TextBox txtIva00;
        private System.Windows.Forms.MaskedTextBox txtFactura;
        private System.Windows.Forms.MaskedTextBox txtTimbrado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton OptContado;
        private System.Windows.Forms.RadioButton OptCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn venta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn venta2;
        private System.Windows.Forms.Button button1;
    }
}