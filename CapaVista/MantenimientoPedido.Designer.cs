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
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.BtnAtrasPedido = new System.Windows.Forms.Button();
            this.BtnNuevoPedido = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(635, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por Pedido";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(13, 53);
            this.dgvPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.RowHeadersWidth = 51;
            this.dgvPedido.Size = new System.Drawing.Size(980, 398);
            this.dgvPedido.TabIndex = 1;
            // 
            // BtnAtrasPedido
            // 
            this.BtnAtrasPedido.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAtrasPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtrasPedido.Location = new System.Drawing.Point(833, 479);
            this.BtnAtrasPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAtrasPedido.Name = "BtnAtrasPedido";
            this.BtnAtrasPedido.Size = new System.Drawing.Size(156, 50);
            this.BtnAtrasPedido.TabIndex = 3;
            this.BtnAtrasPedido.Text = "Atras";
            this.BtnAtrasPedido.UseVisualStyleBackColor = false;
            this.BtnAtrasPedido.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // BtnNuevoPedido
            // 
            this.BtnNuevoPedido.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnNuevoPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoPedido.Location = new System.Drawing.Point(16, 479);
            this.BtnNuevoPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevoPedido.Name = "BtnNuevoPedido";
            this.BtnNuevoPedido.Size = new System.Drawing.Size(156, 50);
            this.BtnNuevoPedido.TabIndex = 4;
            this.BtnNuevoPedido.Text = "Nuevo";
            this.BtnNuevoPedido.UseVisualStyleBackColor = false;
            this.BtnNuevoPedido.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // MantenimientoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 544);
            this.Controls.Add(this.BtnNuevoPedido);
            this.Controls.Add(this.BtnAtrasPedido);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenimientoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapes | Mantenimiento de Pedido";
            this.Load += new System.EventHandler(this.DetalleProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button BtnAtrasPedido;
        private System.Windows.Forms.Button BtnNuevoPedido;
    }
}