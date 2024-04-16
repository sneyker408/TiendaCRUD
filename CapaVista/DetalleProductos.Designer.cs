namespace CapaVista
{
    partial class DetalleProductos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 39);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por Prodcuto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(578, 266);
            this.dataGridView1.TabIndex = 1;
            // 
            // BtnAtras
            // 
            this.BtnAtras.Location = new System.Drawing.Point(421, 348);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(117, 41);
            this.BtnAtras.TabIndex = 3;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = true;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(47, 348);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(117, 41);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            // 
            // DetalleProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 409);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DetalleProductos";
            this.Text = "DetalleProductos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnNuevo;
    }
}