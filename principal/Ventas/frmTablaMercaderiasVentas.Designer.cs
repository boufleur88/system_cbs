namespace sistema_cbs
{
    partial class frmTablaMercaderiasVentas
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dt_lista_produto = new System.Windows.Forms.DataGridView();
            this.btmAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lista_produto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 59;
            this.label1.Text = "DESCRIPCION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(458, 34);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(76, 30);
            this.btn_buscar.TabIndex = 58;
            this.btn_buscar.Text = "&BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(123, 38);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.txt_buscar.MaxLength = 40;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(332, 22);
            this.txt_buscar.TabIndex = 57;
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(619, 34);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(76, 30);
            this.btn_sair.TabIndex = 55;
            this.btn_sair.Text = "&SAIR";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 20);
            this.label5.TabIndex = 56;
            this.label5.Text = "CATALOGO DE MERCADERIAS";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dt_lista_produto
            // 
            this.dt_lista_produto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dt_lista_produto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dt_lista_produto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dt_lista_produto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_lista_produto.Location = new System.Drawing.Point(8, 71);
            this.dt_lista_produto.Margin = new System.Windows.Forms.Padding(2);
            this.dt_lista_produto.Name = "dt_lista_produto";
            this.dt_lista_produto.ReadOnly = true;
            this.dt_lista_produto.RowHeadersWidth = 50;
            this.dt_lista_produto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_lista_produto.Size = new System.Drawing.Size(681, 391);
            this.dt_lista_produto.TabIndex = 54;
            // 
            // btmAdicionar
            // 
            this.btmAdicionar.Location = new System.Drawing.Point(540, 34);
            this.btmAdicionar.Name = "btmAdicionar";
            this.btmAdicionar.Size = new System.Drawing.Size(76, 30);
            this.btmAdicionar.TabIndex = 60;
            this.btmAdicionar.Text = "&ADICIONAR";
            this.btmAdicionar.UseVisualStyleBackColor = true;
            this.btmAdicionar.Click += new System.EventHandler(this.btmAdicionar_Click);
            // 
            // frmTablaMercaderiasVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btmAdicionar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt_lista_produto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTablaMercaderiasVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTablaMercaderiasVentas";
            this.Load += new System.EventHandler(this.frmTablaMercaderiasVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_lista_produto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dt_lista_produto;
        private System.Windows.Forms.Button btmAdicionar;
    }
}