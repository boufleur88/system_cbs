namespace sistema_cbs
{
    partial class CajaChica
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtDebe = new System.Windows.Forms.TextBox();
            this.txtHaber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtInclusion = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(207, 241);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(125, 32);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(353, 241);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 32);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacion.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(14, 155);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtObservacion.MaxLength = 200;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(787, 26);
            this.txtObservacion.TabIndex = 2;
            // 
            // txtCuenta
            // 
            this.txtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCuenta.Enabled = false;
            this.txtCuenta.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuenta.Location = new System.Drawing.Point(307, 192);
            this.txtCuenta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCuenta.MaxLength = 50;
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(494, 26);
            this.txtCuenta.TabIndex = 4;
            // 
            // txtDebe
            // 
            this.txtDebe.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebe.Location = new System.Drawing.Point(301, 87);
            this.txtDebe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDebe.MaxLength = 15;
            this.txtDebe.Name = "txtDebe";
            this.txtDebe.Size = new System.Drawing.Size(264, 26);
            this.txtDebe.TabIndex = 1;
            this.txtDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDebe.Leave += new System.EventHandler(this.txtDebe_Leave);
            // 
            // txtHaber
            // 
            this.txtHaber.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHaber.Location = new System.Drawing.Point(14, 87);
            this.txtHaber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtHaber.MaxLength = 15;
            this.txtHaber.Name = "txtHaber";
            this.txtHaber.Size = new System.Drawing.Size(264, 26);
            this.txtHaber.TabIndex = 0;
            this.txtHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHaber.Leave += new System.EventHandler(this.txtHaber_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "CUENTA CONTABLE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "VALOR ENTRADA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "VALOR SAIDA";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(182, 192);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCodigo.MaxLength = 10;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 26);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyDown);
            // 
            // txtInclusion
            // 
            this.txtInclusion.Enabled = false;
            this.txtInclusion.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInclusion.Location = new System.Drawing.Point(14, 13);
            this.txtInclusion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtInclusion.Mask = "99/99/9999";
            this.txtInclusion.Name = "txtInclusion";
            this.txtInclusion.Size = new System.Drawing.Size(106, 26);
            this.txtInclusion.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "OBSERVACION DEL MOVIMIENTO";
            // 
            // CajaChica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(827, 290);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInclusion);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHaber);
            this.Controls.Add(this.txtDebe);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "CajaChica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MOVIMIENTO DEL CAJA";
            this.Load += new System.EventHandler(this.CajaChica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtDebe;
        private System.Windows.Forms.TextBox txtHaber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox txtInclusion;
        private System.Windows.Forms.Label label3;
    }
}