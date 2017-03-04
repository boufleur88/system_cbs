namespace sistema_cbs
{
    partial class frmGiroTigoMov
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtInclusion = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DataMov = new System.Windows.Forms.DataGridView();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataMov)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOVIMIENTOS DEL GIRO TIGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLIENTE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "VALOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "OBSERVACION:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "FECHA:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(177, 86);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(54, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtCliente
            // 
            this.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(237, 86);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(283, 26);
            this.txtCliente.TabIndex = 2;
            // 
            // txtObs
            // 
            this.txtObs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(176, 150);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(541, 26);
            this.txtObs.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(177, 118);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(119, 26);
            this.txtValor.TabIndex = 4;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.Leave += new System.EventHandler(this.txtValor_Leave);
            // 
            // txtInclusion
            // 
            this.txtInclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInclusion.Location = new System.Drawing.Point(177, 54);
            this.txtInclusion.Mask = "99/99/9999";
            this.txtInclusion.Name = "txtInclusion";
            this.txtInclusion.Size = new System.Drawing.Size(90, 26);
            this.txtInclusion.TabIndex = 12;
            this.txtInclusion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(526, 86);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(124, 26);
            this.txtTelefono.TabIndex = 3;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(480, 194);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(642, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataMov
            // 
            this.DataMov.AllowUserToAddRows = false;
            this.DataMov.AllowUserToDeleteRows = false;
            this.DataMov.AllowUserToOrderColumns = true;
            this.DataMov.AllowUserToResizeColumns = false;
            this.DataMov.AllowUserToResizeRows = false;
            this.DataMov.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataMov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FECHA,
            this.C_Codigo,
            this.C_Cliente,
            this.C_Total,
            this.C_Obs});
            this.DataMov.Location = new System.Drawing.Point(12, 236);
            this.DataMov.MultiSelect = false;
            this.DataMov.Name = "DataMov";
            this.DataMov.ReadOnly = true;
            this.DataMov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataMov.Size = new System.Drawing.Size(873, 411);
            this.DataMov.TabIndex = 8;
            // 
            // FECHA
            // 
            this.FECHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.Width = 80;
            // 
            // C_Codigo
            // 
            this.C_Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.C_Codigo.HeaderText = "CODIGO";
            this.C_Codigo.Name = "C_Codigo";
            this.C_Codigo.ReadOnly = true;
            this.C_Codigo.Width = 50;
            // 
            // C_Cliente
            // 
            this.C_Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.C_Cliente.HeaderText = "CLIENTE";
            this.C_Cliente.Name = "C_Cliente";
            this.C_Cliente.ReadOnly = true;
            this.C_Cliente.Width = 300;
            // 
            // C_Total
            // 
            this.C_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.C_Total.HeaderText = "TOTAL";
            this.C_Total.Name = "C_Total";
            this.C_Total.ReadOnly = true;
            // 
            // C_Obs
            // 
            this.C_Obs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.C_Obs.HeaderText = "OBSERVACION";
            this.C_Obs.Name = "C_Obs";
            this.C_Obs.ReadOnly = true;
            this.C_Obs.Width = 300;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(656, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "BUSCAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 194);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "EDITAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmGiroTigoMov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 660);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.DataMov);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtInclusion);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGiroTigoMov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiroTigoMov";
            this.Load += new System.EventHandler(this.frmGiroTigoMov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.MaskedTextBox txtInclusion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DataMov;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Obs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}