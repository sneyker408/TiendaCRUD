
namespace CapaVista
{
    partial class MantenimientoInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoInventario));
            this.BtnNuevoInventario = new System.Windows.Forms.Button();
            this.BtnAtrasInventario = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevoInventario
            // 
            this.BtnNuevoInventario.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnNuevoInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoInventario.Location = new System.Drawing.Point(47, 484);
            this.BtnNuevoInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevoInventario.Name = "BtnNuevoInventario";
            this.BtnNuevoInventario.Size = new System.Drawing.Size(156, 50);
            this.BtnNuevoInventario.TabIndex = 8;
            this.BtnNuevoInventario.Text = "Nuevo";
            this.BtnNuevoInventario.UseVisualStyleBackColor = false;
            this.BtnNuevoInventario.Click += new System.EventHandler(this.BtnNuevoInventario_Click);
            // 
            // BtnAtrasInventario
            // 
            this.BtnAtrasInventario.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAtrasInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtrasInventario.Location = new System.Drawing.Point(864, 484);
            this.BtnAtrasInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAtrasInventario.Name = "BtnAtrasInventario";
            this.BtnAtrasInventario.Size = new System.Drawing.Size(156, 50);
            this.BtnAtrasInventario.TabIndex = 7;
            this.BtnAtrasInventario.Text = "Atras";
            this.BtnAtrasInventario.UseVisualStyleBackColor = false;
            this.BtnAtrasInventario.Click += new System.EventHandler(this.BtnAtrasInventario_Click);
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(44, 58);
            this.dgvInventario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.Size = new System.Drawing.Size(980, 398);
            this.dgvInventario.TabIndex = 6;
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
            this.groupBox1.Text = "Filtro por Inventario";
            // 
            // MantenimientoInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnNuevoInventario);
            this.Controls.Add(this.BtnAtrasInventario);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenimientoInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | MantenimientoInventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevoInventario;
        private System.Windows.Forms.Button BtnAtrasInventario;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}