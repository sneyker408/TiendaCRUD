
namespace CapaVista
{
    partial class MantenimientoProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoProveedor));
            this.BtnNuevoProve = new System.Windows.Forms.Button();
            this.BtnAtrasProve = new System.Windows.Forms.Button();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevoProve
            // 
            this.BtnNuevoProve.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnNuevoProve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoProve.Location = new System.Drawing.Point(44, 484);
            this.BtnNuevoProve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevoProve.Name = "BtnNuevoProve";
            this.BtnNuevoProve.Size = new System.Drawing.Size(156, 50);
            this.BtnNuevoProve.TabIndex = 8;
            this.BtnNuevoProve.Text = "Nuevo";
            this.BtnNuevoProve.UseVisualStyleBackColor = false;
            this.BtnNuevoProve.Click += new System.EventHandler(this.BtnNuevoProve_Click);
            // 
            // BtnAtrasProve
            // 
            this.BtnAtrasProve.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAtrasProve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtrasProve.Location = new System.Drawing.Point(868, 484);
            this.BtnAtrasProve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAtrasProve.Name = "BtnAtrasProve";
            this.BtnAtrasProve.Size = new System.Drawing.Size(156, 50);
            this.BtnAtrasProve.TabIndex = 7;
            this.BtnAtrasProve.Text = "Atras";
            this.BtnAtrasProve.UseVisualStyleBackColor = false;
            this.BtnAtrasProve.Click += new System.EventHandler(this.BtnAtrasProve_Click);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(44, 58);
            this.dgvProveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.Size = new System.Drawing.Size(980, 398);
            this.dgvProveedor.TabIndex = 6;
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
            this.groupBox1.Text = "Filtro por Proveedor";
            // 
            // MantenimientoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnNuevoProve);
            this.Controls.Add(this.BtnAtrasProve);
            this.Controls.Add(this.dgvProveedor);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenimientoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | MantenimientoProveedore";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevoProve;
        private System.Windows.Forms.Button BtnAtrasProve;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}