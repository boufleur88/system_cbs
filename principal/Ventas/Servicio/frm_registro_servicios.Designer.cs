namespace sistema_cbs
{
    partial class frm_registro_servicios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGrupo = new System.Windows.Forms.Button();
            this.cmbgrupo = new System.Windows.Forms.ComboBox();
            this.txtVenta = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecioMinimo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGrupo
            // 
            this.btnGrupo.Location = new System.Drawing.Point(374, 106);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(40, 26);
            this.btnGrupo.TabIndex = 125;
            this.btnGrupo.Text = "ADD";
            this.btnGrupo.UseVisualStyleBackColor = true;
            // 
            // cmbgrupo
            // 
            this.cmbgrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgrupo.FormattingEnabled = true;
            this.cmbgrupo.Location = new System.Drawing.Point(191, 110);
            this.cmbgrupo.Name = "cmbgrupo";
            this.cmbgrupo.Size = new System.Drawing.Size(173, 21);
            this.cmbgrupo.TabIndex = 124;
            this.cmbgrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbgrupo_KeyPress);
            // 
            // txtVenta
            // 
            this.txtVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenta.Location = new System.Drawing.Point(192, 212);
            this.txtVenta.Margin = new System.Windows.Forms.Padding(0);
            this.txtVenta.MaxLength = 15;
            this.txtVenta.Name = "txtVenta";
            this.txtVenta.Size = new System.Drawing.Size(172, 22);
            this.txtVenta.TabIndex = 114;
            this.txtVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_venta_KeyPress);
            this.txtVenta.Leave += new System.EventHandler(this.txt_venta_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(38, 246);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 20);
            this.label17.TabIndex = 122;
            this.label17.Text = "OBSERVACIONES";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtObservacion
            // 
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(41, 266);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(0);
            this.txtObservacion.MaxLength = 499;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(692, 124);
            this.txtObservacion.TabIndex = 115;
            this.txtObservacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_obser_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(244, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(248, 20);
            this.label15.TabIndex = 121;
            this.label15.Text = "INFORMACIONES GENERALES";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 119;
            this.label3.Text = "DESCRIPCION";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 120;
            this.label5.Text = "GRUPO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 118;
            this.label1.Text = "CODIGO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(188, 78);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescripcion.MaxLength = 79;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(542, 22);
            this.txtDescripcion.TabIndex = 113;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descripcion_KeyPress);
            this.txtDescripcion.Leave += new System.EventHandler(this.txtDescripcion_Leave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(188, 49);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(81, 22);
            this.txtCodigo.TabIndex = 123;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(250, 407);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(80, 30);
            this.btn_guardar.TabIndex = 116;
            this.btn_guardar.Text = "&GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(374, 407);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(80, 30);
            this.btn_salir.TabIndex = 117;
            this.btn_salir.Text = "&SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 126;
            this.label2.Text = "PRECIO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 128;
            this.label4.Text = "COSTO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCosto
            // 
            this.txtCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.Location = new System.Drawing.Point(192, 145);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(0);
            this.txtCosto.MaxLength = 15;
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(172, 22);
            this.txtCosto.TabIndex = 127;
            this.txtCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto_KeyPress);
            this.txtCosto.Leave += new System.EventHandler(this.txtCosto_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 130;
            this.label6.Text = "PRECIO MINIMO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPrecioMinimo
            // 
            this.txtPrecioMinimo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecioMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioMinimo.Location = new System.Drawing.Point(192, 179);
            this.txtPrecioMinimo.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrecioMinimo.MaxLength = 15;
            this.txtPrecioMinimo.Name = "txtPrecioMinimo";
            this.txtPrecioMinimo.Size = new System.Drawing.Size(172, 22);
            this.txtPrecioMinimo.TabIndex = 129;
            this.txtPrecioMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioMinimo_KeyPress);
            this.txtPrecioMinimo.Leave += new System.EventHandler(this.txtPrecioMinimo_Leave);
            // 
            // frm_registro_servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(776, 483);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecioMinimo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGrupo);
            this.Controls.Add(this.cmbgrupo);
            this.Controls.Add(this.txtVenta);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_registro_servicios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE SERVICIOS - CBS";
            this.Load += new System.EventHandler(this.frm_registro_servicios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGrupo;
        private System.Windows.Forms.ComboBox cmbgrupo;
        private System.Windows.Forms.TextBox txtVenta;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecioMinimo;
    }
}