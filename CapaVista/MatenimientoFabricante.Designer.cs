namespace CapaVista
{
    partial class MatenimientoFabricante
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatenimientoFabricante));
            this.BtnNuevoMFabri = new System.Windows.Forms.Button();
            this.BtnAtrasMFabri = new System.Windows.Forms.Button();
            this.dgvFabricante = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FabricanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevoMFabri
            // 
            this.BtnNuevoMFabri.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnNuevoMFabri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoMFabri.Location = new System.Drawing.Point(13, 474);
            this.BtnNuevoMFabri.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevoMFabri.Name = "BtnNuevoMFabri";
            this.BtnNuevoMFabri.Size = new System.Drawing.Size(156, 50);
            this.BtnNuevoMFabri.TabIndex = 12;
            this.BtnNuevoMFabri.Text = "Nuevo";
            this.BtnNuevoMFabri.UseVisualStyleBackColor = false;
            this.BtnNuevoMFabri.Click += new System.EventHandler(this.BtnNuevoMFabri_Click);
            // 
            // BtnAtrasMFabri
            // 
            this.BtnAtrasMFabri.BackColor = System.Drawing.Color.LightCoral;
            this.BtnAtrasMFabri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtrasMFabri.Location = new System.Drawing.Point(837, 474);
            this.BtnAtrasMFabri.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAtrasMFabri.Name = "BtnAtrasMFabri";
            this.BtnAtrasMFabri.Size = new System.Drawing.Size(156, 50);
            this.BtnAtrasMFabri.TabIndex = 11;
            this.BtnAtrasMFabri.Text = "Atras";
            this.BtnAtrasMFabri.UseVisualStyleBackColor = false;
            this.BtnAtrasMFabri.Click += new System.EventHandler(this.BtnAtrasMFabri_Click);
            // 
            // dgvFabricante
            // 
            this.dgvFabricante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabricante.Location = new System.Drawing.Point(13, 57);
            this.dgvFabricante.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFabricante.Name = "dgvFabricante";
            this.dgvFabricante.RowHeadersWidth = 51;
            this.dgvFabricante.Size = new System.Drawing.Size(980, 398);
            this.dgvFabricante.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(13, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(635, 117);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por Fabricante";
            // 
            // FabricanteBindingSource
            // 
            this.FabricanteBindingSource.DataSource = typeof(CapaEntidades.Fabricante);
            // 
            // MatenimientoFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 545);
            this.Controls.Add(this.BtnNuevoMFabri);
            this.Controls.Add(this.BtnAtrasMFabri);
            this.Controls.Add(this.dgvFabricante);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatenimientoFabricante";
            this.Text = "Vapesney | MatenimientoFabricante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FabricanteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevoMFabri;
        private System.Windows.Forms.Button BtnAtrasMFabri;
        private System.Windows.Forms.DataGridView dgvFabricante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource FabricanteBindingSource;
    }
}