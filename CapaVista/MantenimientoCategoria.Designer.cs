
namespace CapaVista
{
    partial class MantenimientoCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCategoria));
            this.BtnNuevoMCate = new System.Windows.Forms.Button();
            this.BtnAtrasMCate = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevoMCate
            // 
            this.BtnNuevoMCate.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnNuevoMCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoMCate.Location = new System.Drawing.Point(47, 484);
            this.BtnNuevoMCate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevoMCate.Name = "BtnNuevoMCate";
            this.BtnNuevoMCate.Size = new System.Drawing.Size(156, 50);
            this.BtnNuevoMCate.TabIndex = 8;
            this.BtnNuevoMCate.Text = "Nuevo";
            this.BtnNuevoMCate.UseVisualStyleBackColor = false;
            this.BtnNuevoMCate.Click += new System.EventHandler(this.BtnNuevoMCate_Click);
            // 
            // BtnAtrasMCate
            // 
            this.BtnAtrasMCate.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAtrasMCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtrasMCate.Location = new System.Drawing.Point(871, 484);
            this.BtnAtrasMCate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAtrasMCate.Name = "BtnAtrasMCate";
            this.BtnAtrasMCate.Size = new System.Drawing.Size(156, 50);
            this.BtnAtrasMCate.TabIndex = 7;
            this.BtnAtrasMCate.Text = "Atras";
            this.BtnAtrasMCate.UseVisualStyleBackColor = false;
            this.BtnAtrasMCate.Click += new System.EventHandler(this.BtnAtrasMCate_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(47, 67);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.Size = new System.Drawing.Size(980, 398);
            this.dgvCategoria.TabIndex = 6;
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
            this.groupBox1.Text = "Filtro por Categoria";
            // 
            // MantenimientoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BtnNuevoMCate);
            this.Controls.Add(this.BtnAtrasMCate);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MantenimientoCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | MantenimientoCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevoMCate;
        private System.Windows.Forms.Button BtnAtrasMCate;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}