﻿namespace sistema_cbs
{
    partial class frm_tabla_compra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dtListCompra = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtListCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 72;
            this.label1.Text = "BUSCAR COMPRAS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(598, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 30);
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.Text = "&BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(226, 40);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.txtBuscar.MaxLength = 40;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(356, 22);
            this.txtBuscar.TabIndex = 70;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(766, 32);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(80, 30);
            this.btnAlterar.TabIndex = 65;
            this.btnAlterar.Text = "&ALTERAR";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(683, 32);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 30);
            this.btnNuevo.TabIndex = 64;
            this.btnNuevo.Text = "&NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dtListCompra
            // 
            this.dtListCompra.AllowUserToDeleteRows = false;
            this.dtListCompra.AllowUserToResizeColumns = false;
            this.dtListCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtListCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtListCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtListCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtListCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtListCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtListCompra.Location = new System.Drawing.Point(9, 68);
            this.dtListCompra.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.dtListCompra.MultiSelect = false;
            this.dtListCompra.Name = "dtListCompra";
            this.dtListCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtListCompra.Size = new System.Drawing.Size(987, 684);
            this.dtListCompra.TabIndex = 63;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(849, 33);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 30);
            this.btnSalir.TabIndex = 69;
            this.btnSalir.Text = "&SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "LISTADO DE COMPRAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_tabla_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtListCompra);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_tabla_compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_tabla_compra";
            ((System.ComponentModel.ISupportInitialize)(this.dtListCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dtListCompra;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
    }
}