namespace CapaVista
{
    partial class MantenimientoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoPedido));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.BtnAtras = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por Pedido";
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(10, 43);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(735, 323);
            this.dgvProductos.TabIndex = 1;
            // 
            // BtnAtras
            // 
            this.BtnAtras.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtras.Location = new System.Drawing.Point(625, 389);
            this.BtnAtras.Name = "BtnAtras";
            this.BtnAtras.Size = new System.Drawing.Size(117, 41);
            this.BtnAtras.TabIndex = 3;
            this.BtnAtras.Text = "Atras";
            this.BtnAtras.UseVisualStyleBackColor = false;
            this.BtnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevo.Location = new System.Drawing.Point(12, 389);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(117, 41);
            this.BtnNuevo.TabIndex = 4;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = false;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // MantenimientoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 442);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.BtnAtras);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapes | Mantenimiento de Pedido";
            this.Load += new System.EventHandler(this.DetalleProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button BtnAtras;
        private System.Windows.Forms.Button BtnNuevo;
    }
}