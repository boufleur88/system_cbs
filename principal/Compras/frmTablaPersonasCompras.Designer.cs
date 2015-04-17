namespace sistema_cbs
{
    partial class frmTablaPersonasCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btmAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_lista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btmAdicionar
            // 
            this.btmAdicionar.Location = new System.Drawing.Point(539, 49);
            this.btmAdicionar.Name = "btmAdicionar";
            this.btmAdicionar.Size = new System.Drawing.Size(76, 30);
            this.btmAdicionar.TabIndex = 81;
            this.btmAdicionar.Text = "&ADICIONAR";
            this.btmAdicionar.UseVisualStyleBackColor = true;
            this.btmAdicionar.Click += new System.EventHandler(this.btmAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 80;
            this.label1.Text = "PROVEEDOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(457, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 30);
            this.btnBuscar.TabIndex = 79;
            this.btnBuscar.Text = "&BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(122, 53);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.txtBuscar.MaxLength = 40;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(332, 22);
            this.txtBuscar.TabIndex = 78;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(618, 49);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(76, 30);
            this.btnSalir.TabIndex = 76;
            this.btnSalir.Text = "&SAIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "CATALOGO DE PROVEEDORES";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dt_lista
            // 
            this.dt_lista.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dt_lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dt_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_lista.Location = new System.Drawing.Point(7, 86);
            this.dt_lista.Margin = new System.Windows.Forms.Padding(2);
            this.dt_lista.Name = "dt_lista";
            this.dt_lista.ReadOnly = true;
            this.dt_lista.RowHeadersWidth = 50;
            this.dt_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_lista.Size = new System.Drawing.Size(681, 391);
            this.dt_lista.TabIndex = 75;
            // 
            // frmTablaPersonasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btmAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTablaPersonasCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTablaPersonasCompras";
            this.Load += new System.EventHandler(this.frmTablaPersonasCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dt_lista;
    }
}