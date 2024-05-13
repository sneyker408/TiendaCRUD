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
            this.FabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FabricanteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreFabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FabricanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnNuevoMFabri
            // 
            this.BtnNuevoMFabri.BackColor = System.Drawing.Color.Transparent;
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
            this.BtnAtrasMFabri.BackColor = System.Drawing.Color.Transparent;
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
            this.dgvFabricante.AllowUserToAddRows = false;
            this.dgvFabricante.AllowUserToDeleteRows = false;
            this.dgvFabricante.AutoGenerateColumns = false;
            this.dgvFabricante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFabricante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FabricanteId,
            this.nombreFabricanteDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dgvFabricante.DataSource = this.FabricanteBindingSource;
            this.dgvFabricante.Location = new System.Drawing.Point(13, 57);
            this.dgvFabricante.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFabricante.Name = "dgvFabricante";
            this.dgvFabricante.ReadOnly = true;
            this.dgvFabricante.RowHeadersWidth = 51;
            this.dgvFabricante.Size = new System.Drawing.Size(980, 398);
            this.dgvFabricante.TabIndex = 10;
            this.dgvFabricante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFabricante_CellClick);
            // 
            // FabricanteBindingSource
            // 
            this.FabricanteBindingSource.DataSource = typeof(CapaEntidades.Fabricante);
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
            // FabricanteId
            // 
            this.FabricanteId.DataPropertyName = "FabricanteId";
            this.FabricanteId.HeaderText = "FabricanteId";
            this.FabricanteId.MinimumWidth = 6;
            this.FabricanteId.Name = "FabricanteId";
            this.FabricanteId.ReadOnly = true;
            this.FabricanteId.Width = 125;
            // 
            // nombreFabricanteDataGridViewTextBoxColumn
            // 
            this.nombreFabricanteDataGridViewTextBoxColumn.DataPropertyName = "NombreFabricante";
            this.nombreFabricanteDataGridViewTextBoxColumn.HeaderText = "NombreFabricante";
            this.nombreFabricanteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreFabricanteDataGridViewTextBoxColumn.Name = "nombreFabricanteDataGridViewTextBoxColumn";
            this.nombreFabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreFabricanteDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewCheckBoxColumn
            // 
            this.estadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewCheckBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewCheckBoxColumn.Name = "estadoDataGridViewCheckBoxColumn";
            this.estadoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.estadoDataGridViewCheckBoxColumn.Visible = false;
            this.estadoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::CapaVista.Properties.Resources.edit_v2;
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::CapaVista.Properties.Resources.delete;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 125;
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn FabricanteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreFabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}