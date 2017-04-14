namespace sistema_cbs
{
    partial class frm_PlanCta
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
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.dt_lista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dt_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(377, 12);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(80, 30);
            this.btn_buscar.TabIndex = 64;
            this.btn_buscar.Text = "&BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(9, 16);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(0);
            this.txt_buscar.MaxLength = 40;
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(356, 22);
            this.txt_buscar.TabIndex = 63;
            // 
            // dt_lista
            // 
            this.dt_lista.AllowUserToDeleteRows = false;
            this.dt_lista.AllowUserToOrderColumns = true;
            this.dt_lista.AllowUserToResizeColumns = false;
            this.dt_lista.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dt_lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dt_lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dt_lista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dt_lista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dt_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dt_lista.Location = new System.Drawing.Point(9, 47);
            this.dt_lista.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.dt_lista.MultiSelect = false;
            this.dt_lista.Name = "dt_lista";
            this.dt_lista.ReadOnly = true;
            this.dt_lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_lista.Size = new System.Drawing.Size(464, 630);
            this.dt_lista.TabIndex = 66;
            // 
            // frm_PlanCta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 686);
            this.Controls.Add(this.dt_lista);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_buscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_PlanCta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLAN DE CUENTAS";
            this.Load += new System.EventHandler(this.PlanDeCuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.DataGridView dt_lista;
    }
}