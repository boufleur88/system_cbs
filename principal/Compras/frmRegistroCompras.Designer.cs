namespace sistema_cbs
{
    partial class frmRegistroCompras
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCosto1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecio2 = new System.Windows.Forms.TextBox();
            this.lblMaximo = new System.Windows.Forms.Label();
            this.lblMinimo = new System.Windows.Forms.Label();
            this.txtPrecio1 = new System.Windows.Forms.TextBox();
            this.txtPreMin = new System.Windows.Forms.TextBox();
            this.txtPreMax = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 20);
            this.label5.TabIndex = 150;
            this.label5.Text = "AGREGAR ITEMS EN LA COMPRA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(324, 246);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 30);
            this.btnSalir.TabIndex = 149;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 148;
            this.label4.Text = "CANTIDAD";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(161, 116);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(0);
            this.txtCantidad.MaxLength = 15;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(81, 22);
            this.txtCantidad.TabIndex = 147;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 146;
            this.label2.Text = "COSTO CONT";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCosto1
            // 
            this.txtCosto1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCosto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto1.Location = new System.Drawing.Point(163, 146);
            this.txtCosto1.Margin = new System.Windows.Forms.Padding(0);
            this.txtCosto1.MaxLength = 15;
            this.txtCosto1.Name = "txtCosto1";
            this.txtCosto1.Size = new System.Drawing.Size(172, 22);
            this.txtCosto1.TabIndex = 141;
            this.txtCosto1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCosto1_KeyPress);
            this.txtCosto1.Leave += new System.EventHandler(this.txtCostoCont_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 144;
            this.label3.Text = "DESCRIPCION";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 143;
            this.label1.Text = "CODIGO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(161, 85);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescripcion.MaxLength = 79;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(514, 22);
            this.txtDescripcion.TabIndex = 140;
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(161, 56);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(0);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(81, 22);
            this.txtCodigo.TabIndex = 145;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(238, 246);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnGuardar.TabIndex = 142;
            this.btnGuardar.Text = "&GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 152;
            this.label6.Text = "PRECIO MINIMO";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 154;
            this.label7.Text = "PRECIO NORMAL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPrecio2
            // 
            this.txtPrecio2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio2.Location = new System.Drawing.Point(161, 212);
            this.txtPrecio2.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrecio2.MaxLength = 15;
            this.txtPrecio2.Name = "txtPrecio2";
            this.txtPrecio2.Size = new System.Drawing.Size(172, 22);
            this.txtPrecio2.TabIndex = 153;
            this.txtPrecio2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCont_KeyPress);
            this.txtPrecio2.Leave += new System.EventHandler(this.txtPrecioCont_Leave);
            // 
            // lblMaximo
            // 
            this.lblMaximo.AutoSize = true;
            this.lblMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximo.Location = new System.Drawing.Point(396, 212);
            this.lblMaximo.Name = "lblMaximo";
            this.lblMaximo.Size = new System.Drawing.Size(23, 20);
            this.lblMaximo.TabIndex = 157;
            this.lblMaximo.Text = "%";
            this.lblMaximo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMinimo
            // 
            this.lblMinimo.AutoSize = true;
            this.lblMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimo.Location = new System.Drawing.Point(396, 179);
            this.lblMinimo.Name = "lblMinimo";
            this.lblMinimo.Size = new System.Drawing.Size(23, 20);
            this.lblMinimo.TabIndex = 158;
            this.lblMinimo.Text = "%";
            this.lblMinimo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPrecio1
            // 
            this.txtPrecio1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrecio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio1.Location = new System.Drawing.Point(161, 179);
            this.txtPrecio1.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrecio1.MaxLength = 15;
            this.txtPrecio1.Name = "txtPrecio1";
            this.txtPrecio1.Size = new System.Drawing.Size(172, 22);
            this.txtPrecio1.TabIndex = 151;
            this.txtPrecio1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioMin_KeyPress);
            this.txtPrecio1.Leave += new System.EventHandler(this.txtPrecioMin_Leave);
            // 
            // txtPreMin
            // 
            this.txtPreMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPreMin.Enabled = false;
            this.txtPreMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreMin.Location = new System.Drawing.Point(344, 179);
            this.txtPreMin.Margin = new System.Windows.Forms.Padding(0);
            this.txtPreMin.MaxLength = 15;
            this.txtPreMin.Name = "txtPreMin";
            this.txtPreMin.Size = new System.Drawing.Size(52, 22);
            this.txtPreMin.TabIndex = 159;
            // 
            // txtPreMax
            // 
            this.txtPreMax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPreMax.Enabled = false;
            this.txtPreMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreMax.Location = new System.Drawing.Point(344, 212);
            this.txtPreMax.Margin = new System.Windows.Forms.Padding(0);
            this.txtPreMax.MaxLength = 15;
            this.txtPreMax.Name = "txtPreMax";
            this.txtPreMax.Size = new System.Drawing.Size(49, 22);
            this.txtPreMax.TabIndex = 160;
            // 
            // frmRegistroCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 296);
            this.Controls.Add(this.txtPreMax);
            this.Controls.Add(this.txtPreMin);
            this.Controls.Add(this.lblMinimo);
            this.Controls.Add(this.lblMaximo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecio2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrecio1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCosto1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistroCompras";
            this.Load += new System.EventHandler(this.frmRegistroCompras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCosto1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio2;
        private System.Windows.Forms.Label lblMaximo;
        private System.Windows.Forms.Label lblMinimo;
        private System.Windows.Forms.TextBox txtPrecio1;
        private System.Windows.Forms.TextBox txtPreMin;
        private System.Windows.Forms.TextBox txtPreMax;
    }
}