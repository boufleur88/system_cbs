namespace sistema_cbs
{
    partial class frm_reg_productos
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_stcokmin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_medida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_obser = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_costoadmin = new System.Windows.Forms.TextBox();
            this.txt_costocont = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_ventamin = new System.Windows.Forms.TextBox();
            this.txt_ventamay = new System.Windows.Forms.TextBox();
            this.txt_moneda = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbmarca = new System.Windows.Forms.ComboBox();
            this.cmbgrupo = new System.Windows.Forms.ComboBox();
            this.cmbsubgrupo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnSubGrupo = new System.Windows.Forms.Button();
            this.btnGrupo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(248, 427);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(80, 30);
            this.btn_guardar.TabIndex = 18;
            this.btn_guardar.Text = "&GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(372, 427);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(80, 30);
            this.btn_salir.TabIndex = 19;
            this.btn_salir.Text = "&SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(588, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 20);
            this.label13.TabIndex = 63;
            this.label13.Text = "STOCK MIN";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_stcokmin
            // 
            this.txt_stcokmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_stcokmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stcokmin.Location = new System.Drawing.Point(686, 110);
            this.txt_stcokmin.Margin = new System.Windows.Forms.Padding(0);
            this.txt_stcokmin.Name = "txt_stcokmin";
            this.txt_stcokmin.Size = new System.Drawing.Size(45, 22);
            this.txt_stcokmin.TabIndex = 9;
            this.txt_stcokmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_stcokmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stcokmin_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(425, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "UN. MEDIDA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_medida
            // 
            this.txt_medida.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_medida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_medida.Location = new System.Drawing.Point(532, 109);
            this.txt_medida.Margin = new System.Windows.Forms.Padding(0);
            this.txt_medida.MaxLength = 2;
            this.txt_medida.Name = "txt_medida";
            this.txt_medida.Size = new System.Drawing.Size(33, 22);
            this.txt_medida.TabIndex = 8;
            this.txt_medida.Text = "UN";
            this.txt_medida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_medida_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "DESCRIPCION";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "SUB-GRUPO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "GRUPO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "MARCA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "CODIGO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(189, 79);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(0);
            this.txt_descripcion.MaxLength = 79;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(542, 22);
            this.txt_descripcion.TabIndex = 3;
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_KeyPress);
            this.txt_descripcion.Leave += new System.EventHandler(this.txt_descripcion_Leave);
            // 
            // txt_codigo
            // 
            this.txt_codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(189, 50);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(0);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(81, 22);
            this.txt_codigo.TabIndex = 100;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(273, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(248, 20);
            this.label15.TabIndex = 65;
            this.label15.Text = "INFORMACIONES GENERALES";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_obser
            // 
            this.txt_obser.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_obser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obser.Location = new System.Drawing.Point(39, 286);
            this.txt_obser.Margin = new System.Windows.Forms.Padding(0);
            this.txt_obser.MaxLength = 499;
            this.txt_obser.Multiline = true;
            this.txt_obser.Name = "txt_obser";
            this.txt_obser.Size = new System.Drawing.Size(692, 124);
            this.txt_obser.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(428, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.TabIndex = 76;
            this.label12.Text = "TIPO IVA";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_iva
            // 
            this.txt_iva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_iva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_iva.Location = new System.Drawing.Point(532, 170);
            this.txt_iva.Margin = new System.Windows.Forms.Padding(0);
            this.txt_iva.MaxLength = 2;
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(35, 22);
            this.txt_iva.TabIndex = 12;
            this.txt_iva.Text = "10";
            this.txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_iva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_iva_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(35, 236);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 20);
            this.label18.TabIndex = 69;
            this.label18.Text = "COSTO ADMIN.";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(35, 209);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(115, 20);
            this.label21.TabIndex = 68;
            this.label21.Text = "COSTO CONT.";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_costoadmin
            // 
            this.txt_costoadmin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_costoadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoadmin.Location = new System.Drawing.Point(189, 234);
            this.txt_costoadmin.Margin = new System.Windows.Forms.Padding(0);
            this.txt_costoadmin.MaxLength = 15;
            this.txt_costoadmin.Name = "txt_costoadmin";
            this.txt_costoadmin.Size = new System.Drawing.Size(139, 22);
            this.txt_costoadmin.TabIndex = 14;
            this.txt_costoadmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_costoadmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoadmin_KeyPress);
            this.txt_costoadmin.Leave += new System.EventHandler(this.txt_costoadmin_Leave);
            // 
            // txt_costocont
            // 
            this.txt_costocont.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_costocont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costocont.Location = new System.Drawing.Point(189, 206);
            this.txt_costocont.Margin = new System.Windows.Forms.Padding(0);
            this.txt_costocont.MaxLength = 15;
            this.txt_costocont.Name = "txt_costocont";
            this.txt_costocont.Size = new System.Drawing.Size(139, 22);
            this.txt_costocont.TabIndex = 13;
            this.txt_costocont.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_costocont.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costocont_KeyPress);
            this.txt_costocont.Leave += new System.EventHandler(this.txt_costocont_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(36, 266);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 20);
            this.label17.TabIndex = 78;
            this.label17.Text = "OBSERVACIONES";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(428, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 20);
            this.label10.TabIndex = 104;
            this.label10.Text = "VENTA MINORISTA";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(428, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(161, 20);
            this.label16.TabIndex = 103;
            this.label16.Text = "VENTA MAYORISTA";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_ventamin
            // 
            this.txt_ventamin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ventamin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ventamin.Location = new System.Drawing.Point(592, 236);
            this.txt_ventamin.Margin = new System.Windows.Forms.Padding(0);
            this.txt_ventamin.MaxLength = 15;
            this.txt_ventamin.Name = "txt_ventamin";
            this.txt_ventamin.Size = new System.Drawing.Size(139, 22);
            this.txt_ventamin.TabIndex = 16;
            this.txt_ventamin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ventamin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ventamin_KeyPress);
            this.txt_ventamin.Leave += new System.EventHandler(this.txt_ventamin_Leave);
            // 
            // txt_ventamay
            // 
            this.txt_ventamay.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ventamay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ventamay.Location = new System.Drawing.Point(592, 206);
            this.txt_ventamay.Margin = new System.Windows.Forms.Padding(0);
            this.txt_ventamay.MaxLength = 15;
            this.txt_ventamay.Name = "txt_ventamay";
            this.txt_ventamay.Size = new System.Drawing.Size(139, 22);
            this.txt_ventamay.TabIndex = 15;
            this.txt_ventamay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_ventamay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ventamay_KeyPress);
            this.txt_ventamay.Leave += new System.EventHandler(this.txt_ventamay_Leave);
            // 
            // txt_moneda
            // 
            this.txt_moneda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_moneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_moneda.Location = new System.Drawing.Point(532, 140);
            this.txt_moneda.Margin = new System.Windows.Forms.Padding(0);
            this.txt_moneda.MaxLength = 1;
            this.txt_moneda.Name = "txt_moneda";
            this.txt_moneda.Size = new System.Drawing.Size(33, 22);
            this.txt_moneda.TabIndex = 11;
            this.txt_moneda.Text = "1";
            this.txt_moneda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_moneda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_moneda_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(425, 140);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 20);
            this.label22.TabIndex = 67;
            this.label22.Text = "MONEDA";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbmarca
            // 
            this.cmbmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmarca.FormattingEnabled = true;
            this.cmbmarca.Location = new System.Drawing.Point(189, 112);
            this.cmbmarca.Name = "cmbmarca";
            this.cmbmarca.Size = new System.Drawing.Size(173, 21);
            this.cmbmarca.TabIndex = 105;
            this.cmbmarca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbmarca_KeyPress);
            // 
            // cmbgrupo
            // 
            this.cmbgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgrupo.FormattingEnabled = true;
            this.cmbgrupo.Location = new System.Drawing.Point(189, 142);
            this.cmbgrupo.Name = "cmbgrupo";
            this.cmbgrupo.Size = new System.Drawing.Size(173, 21);
            this.cmbgrupo.TabIndex = 106;
            this.cmbgrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbgrupo_KeyPress);
            // 
            // cmbsubgrupo
            // 
            this.cmbsubgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsubgrupo.FormattingEnabled = true;
            this.cmbsubgrupo.Location = new System.Drawing.Point(189, 172);
            this.cmbsubgrupo.Name = "cmbsubgrupo";
            this.cmbsubgrupo.Size = new System.Drawing.Size(173, 21);
            this.cmbsubgrupo.TabIndex = 107;
            this.cmbsubgrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbsubgrupo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(588, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 108;
            this.label11.Text = "0 = U$ ; 1 = G$";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(588, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 20);
            this.label14.TabIndex = 109;
            this.label14.Text = "0%; 05%; 10%";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMarca
            // 
            this.btnMarca.Location = new System.Drawing.Point(372, 109);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(40, 26);
            this.btnMarca.TabIndex = 110;
            this.btnMarca.Text = "ADD";
            this.btnMarca.UseVisualStyleBackColor = true;
            this.btnMarca.Click += new System.EventHandler(this.btnMarca_Click_1);
            this.btnMarca.Leave += new System.EventHandler(this.btnMarca_Leave);
            // 
            // btnSubGrupo
            // 
            this.btnSubGrupo.Location = new System.Drawing.Point(372, 170);
            this.btnSubGrupo.Name = "btnSubGrupo";
            this.btnSubGrupo.Size = new System.Drawing.Size(40, 26);
            this.btnSubGrupo.TabIndex = 111;
            this.btnSubGrupo.Text = "ADD";
            this.btnSubGrupo.UseVisualStyleBackColor = true;
            this.btnSubGrupo.Click += new System.EventHandler(this.btnSubGrupo_Click_1);
            this.btnSubGrupo.Leave += new System.EventHandler(this.btnSubGrupo_Leave);
            // 
            // btnGrupo
            // 
            this.btnGrupo.Location = new System.Drawing.Point(372, 138);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(40, 26);
            this.btnGrupo.TabIndex = 112;
            this.btnGrupo.Text = "ADD";
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click_1);
            this.btnGrupo.Leave += new System.EventHandler(this.btnGrupo_Leave);
            // 
            // frm_reg_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnGrupo);
            this.Controls.Add(this.btnSubGrupo);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbsubgrupo);
            this.Controls.Add(this.cmbgrupo);
            this.Controls.Add(this.cmbmarca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_ventamin);
            this.Controls.Add(this.txt_ventamay);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_iva);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txt_costoadmin);
            this.Controls.Add(this.txt_costocont);
            this.Controls.Add(this.txt_moneda);
            this.Controls.Add(this.txt_obser);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_stcokmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_medida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_reg_productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_reg_productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_reg_productos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_stcokmin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_medida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_obser;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_costoadmin;
        private System.Windows.Forms.TextBox txt_costocont;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_ventamin;
        private System.Windows.Forms.TextBox txt_ventamay;
        private System.Windows.Forms.TextBox txt_moneda;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbmarca;
        private System.Windows.Forms.ComboBox cmbgrupo;
        private System.Windows.Forms.ComboBox cmbsubgrupo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnSubGrupo;
        private System.Windows.Forms.Button btnGrupo;
    }
}