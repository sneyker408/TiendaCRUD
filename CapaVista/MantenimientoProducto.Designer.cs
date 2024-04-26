
namespace CapaVista
{
    partial class MantenimientoProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoProducto));
            this.BtnNuevoProduc = new System.Windows.Forms.Button();
            this.BtnAtrasProduc = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevoProduc
            // 
            this.BtnNuevoProduc.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnNuevoProduc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoProduc.Location = new System.Drawing.Point(47, 484);
            this.BtnNuevoProduc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevoProduc.Name = "BtnNuevoProduc";
            this.BtnNuevoProduc.Size = new System.Drawing.Size(156, 50);
            this.BtnNuevoProduc.TabIndex = 8;
            this.BtnNuevoProduc.Text = "Nuevo";
            this.BtnNuevoProduc.UseVisualStyleBackColor = false;
            this.BtnNuevoProduc.Click += new System.EventHandler(this.BtnNuevoProduc_Click);
            // 
            // BtnAtrasProduc
            // 
            this.BtnAtrasProduc.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAtrasProduc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtrasProduc.Location = new System.Drawing.Point(864, 484);
            this.BtnAtrasProduc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAtrasProduc.Name = "BtnAtrasProduc";
            this.BtnAtrasProduc.Size = new System.Drawing.Size(156, 50);
            this.BtnAtrasProduc.TabIndex = 7;
            this.BtnAtrasProduc.Text = "Atras";
            this.BtnAtrasProduc.UseVisualStyleBackColor = false;
            this.BtnAtrasProduc.Click += new System.EventHandler(this.BtnAtrasProduc_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(44, 58);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.Size = new System.Drawing.Size(980, 398);
            this.dgvProducto.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(47, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(635, 117);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por Producto";
            // 
            // MantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnNuevoProduc);
            this.Controls.Add(this.BtnAtrasProduc);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenimientoProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | MantenimientoProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevoProduc;
        private System.Windows.Forms.Button BtnAtrasProduc;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}