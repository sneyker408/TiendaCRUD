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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoCategoria));
            this.BtnNuevoMCate = new System.Windows.Forms.Button();
            this.BtnAtrasMCate = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.categoriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.CategoriabindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbInactivos = new System.Windows.Forms.RadioButton();
            this.rdbActivos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriabindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNuevoMCate
            // 
            this.BtnNuevoMCate.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoMCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoMCate.Location = new System.Drawing.Point(25, 539);
            this.BtnNuevoMCate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNuevoMCate.Name = "BtnNuevoMCate";
            this.BtnNuevoMCate.Size = new System.Drawing.Size(156, 50);
            this.BtnNuevoMCate.TabIndex = 12;
            this.BtnNuevoMCate.Text = "Nuevo";
            this.BtnNuevoMCate.UseVisualStyleBackColor = false;
            this.BtnNuevoMCate.Click += new System.EventHandler(this.BtnNuevoMCate_Click);
            // 
            // BtnAtrasMCate
            // 
            this.BtnAtrasMCate.BackColor = System.Drawing.Color.Transparent;
            this.BtnAtrasMCate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtrasMCate.Location = new System.Drawing.Point(849, 539);
            this.BtnAtrasMCate.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAtrasMCate.Name = "BtnAtrasMCate";
            this.BtnAtrasMCate.Size = new System.Drawing.Size(156, 50);
            this.BtnAtrasMCate.TabIndex = 11;
            this.BtnAtrasMCate.Text = "Atras";
            this.BtnAtrasMCate.UseVisualStyleBackColor = false;
            this.BtnAtrasMCate.Click += new System.EventHandler(this.BtnAtrasMCate_Click);
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AllowUserToDeleteRows = false;
            this.dgvCategoria.AutoGenerateColumns = false;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoriaId,
            this.nombreCategoriaDataGridViewTextBoxColumn,
            this.estadoDataGridViewCheckBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dgvCategoria.DataSource = this.CategoriabindingSource;
            this.dgvCategoria.Location = new System.Drawing.Point(25, 105);
            this.dgvCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.ReadOnly = true;
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.Size = new System.Drawing.Size(980, 417);
            this.dgvCategoria.TabIndex = 10;
            this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategoria_CellClick);
            // 
            // categoriaId
            // 
            this.categoriaId.DataPropertyName = "CategoriaId";
            this.categoriaId.HeaderText = "Codigo";
            this.categoriaId.MinimumWidth = 6;
            this.categoriaId.Name = "categoriaId";
            this.categoriaId.ReadOnly = true;
            this.categoriaId.Width = 125;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "NombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreCategoriaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            this.nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn.Width = 125;
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
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::CapaVista.Properties.Resources.delete;
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.Width = 125;
            // 
            // CategoriabindingSource
            // 
            this.CategoriabindingSource.DataSource = typeof(CapaEntidades.Categoria);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(635, 70);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro por Categoria";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaVista.Properties.Resources.edit_v2;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::CapaVista.Properties.Resources.delete;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbInactivos);
            this.groupBox2.Controls.Add(this.rdbActivos);
            this.groupBox2.Location = new System.Drawing.Point(667, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por estado";
            // 
            // rdbInactivos
            // 
            this.rdbInactivos.AutoSize = true;
            this.rdbInactivos.Location = new System.Drawing.Point(105, 31);
            this.rdbInactivos.Name = "rdbInactivos";
            this.rdbInactivos.Size = new System.Drawing.Size(81, 20);
            this.rdbInactivos.TabIndex = 1;
            this.rdbInactivos.Text = "Inactivos";
            this.rdbInactivos.UseVisualStyleBackColor = true;
            this.rdbInactivos.UseWaitCursor = true;
            this.rdbInactivos.CheckedChanged += new System.EventHandler(this.rdbInactivos_CheckedChanged);
            // 
            // rdbActivos
            // 
            this.rdbActivos.AutoSize = true;
            this.rdbActivos.Checked = true;
            this.rdbActivos.Location = new System.Drawing.Point(18, 31);
            this.rdbActivos.Name = "rdbActivos";
            this.rdbActivos.Size = new System.Drawing.Size(72, 20);
            this.rdbActivos.TabIndex = 0;
            this.rdbActivos.TabStop = true;
            this.rdbActivos.Text = "Activos";
            this.rdbActivos.UseVisualStyleBackColor = true;
            this.rdbActivos.UseWaitCursor = true;
            this.rdbActivos.CheckedChanged += new System.EventHandler(this.rdbActivos_CheckedChanged);
            // 
            // MantenimientoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 602);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnNuevoMCate);
            this.Controls.Add(this.BtnAtrasMCate);
            this.Controls.Add(this.dgvCategoria);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MantenimientoCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | MantenimientoCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriabindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevoMCate;
        private System.Windows.Forms.Button BtnAtrasMCate;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource CategoriabindingSource;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbInactivos;
        private System.Windows.Forms.RadioButton rdbActivos;
    }
}