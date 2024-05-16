namespace CapaVista
{
    partial class MantenimientoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantenimientoProductos));
            this.gpbxFiltro = new System.Windows.Forms.GroupBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxFabricante = new System.Windows.Forms.ComboBox();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.cbxCategorias = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.ProductoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CategoriaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FabricanteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbInactivos = new System.Windows.Forms.RadioButton();
            this.rdbActivos = new System.Windows.Forms.RadioButton();
            this.gpbxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxFiltro
            // 
            this.gpbxFiltro.Controls.Add(this.txtCodigo);
            this.gpbxFiltro.Controls.Add(this.label2);
            this.gpbxFiltro.Controls.Add(this.cbxFabricante);
            this.gpbxFiltro.Controls.Add(this.btnReiniciar);
            this.gpbxFiltro.Controls.Add(this.cbxCategorias);
            this.gpbxFiltro.Controls.Add(this.label7);
            this.gpbxFiltro.Controls.Add(this.txtNombre);
            this.gpbxFiltro.Controls.Add(this.label1);
            this.gpbxFiltro.Controls.Add(this.label6);
            this.gpbxFiltro.Location = new System.Drawing.Point(13, 13);
            this.gpbxFiltro.Name = "gpbxFiltro";
            this.gpbxFiltro.Size = new System.Drawing.Size(955, 115);
            this.gpbxFiltro.TabIndex = 0;
            this.gpbxFiltro.TabStop = false;
            this.gpbxFiltro.Text = "Filtros por Producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "ProductoId", true));
            this.txtCodigo.Location = new System.Drawing.Point(110, 47);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 30);
            this.txtCodigo.TabIndex = 36;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "Codigo";
            // 
            // cbxFabricante
            // 
            this.cbxFabricante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxFabricante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxFabricante.DataSource = this.productoBindingSource;
            this.cbxFabricante.DisplayMember = "NombreFabricante";
            this.cbxFabricante.FormattingEnabled = true;
            this.cbxFabricante.Location = new System.Drawing.Point(701, 31);
            this.cbxFabricante.Name = "cbxFabricante";
            this.cbxFabricante.Size = new System.Drawing.Size(234, 32);
            this.cbxFabricante.TabIndex = 34;
            this.cbxFabricante.ValueMember = "idCategoria";
            this.cbxFabricante.SelectedIndexChanged += new System.EventHandler(this.cbxFabricante_SelectedIndexChanged);
            this.cbxFabricante.TextUpdate += new System.EventHandler(this.cbxFabricante_TextUpdate);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(CapaEntidades.Producto);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(756, 68);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(124, 33);
            this.btnReiniciar.TabIndex = 33;
            this.btnReiniciar.Text = "Limpiar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // cbxCategorias
            // 
            this.cbxCategorias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxCategorias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxCategorias.DataSource = this.productoBindingSource;
            this.cbxCategorias.DisplayMember = "NombreCategoria";
            this.cbxCategorias.FormattingEnabled = true;
            this.cbxCategorias.Location = new System.Drawing.Point(354, 69);
            this.cbxCategorias.Name = "cbxCategorias";
            this.cbxCategorias.Size = new System.Drawing.Size(234, 32);
            this.cbxCategorias.TabIndex = 32;
            this.cbxCategorias.ValueMember = "idCategoria";
            this.cbxCategorias.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            this.cbxCategorias.TextUpdate += new System.EventHandler(this.cbxCategoria_TextUpdate);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 72);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Categoria";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(354, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(234, 30);
            this.txtNombre.TabIndex = 30;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(607, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Fabricante";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductoId,
            this.Nombre,
            this.Descripcion,
            this.PrecioUnitario,
            this.Existencias,
            this.Estado,
            this.CategoriaId,
            this.Categoria,
            this.FabricanteId,
            this.Fabricante,
            this.Editar,
            this.Eliminar});
            this.dgvProductos.Location = new System.Drawing.Point(13, 134);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(1127, 462);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            this.dgvProductos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProductos_CellFormatting);
            // 
            // ProductoId
            // 
            this.ProductoId.DataPropertyName = "ProductoId";
            this.ProductoId.HeaderText = "Codigo";
            this.ProductoId.MinimumWidth = 6;
            this.ProductoId.Name = "ProductoId";
            this.ProductoId.ReadOnly = true;
            this.ProductoId.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.PrecioUnitario.HeaderText = "PrecioUnitario";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 125;
            // 
            // Existencias
            // 
            this.Existencias.DataPropertyName = "Existencias";
            this.Existencias.HeaderText = "Existencias";
            this.Existencias.MinimumWidth = 6;
            this.Existencias.Name = "Existencias";
            this.Existencias.ReadOnly = true;
            this.Existencias.Width = 125;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 125;
            // 
            // CategoriaId
            // 
            this.CategoriaId.DataPropertyName = "CategoriaId";
            this.CategoriaId.HeaderText = "Categoria";
            this.CategoriaId.MinimumWidth = 6;
            this.CategoriaId.Name = "CategoriaId";
            this.CategoriaId.ReadOnly = true;
            this.CategoriaId.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "NombreCategoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Visible = false;
            this.Categoria.Width = 125;
            // 
            // FabricanteId
            // 
            this.FabricanteId.DataPropertyName = "FabricanteId";
            this.FabricanteId.HeaderText = "Fabricante";
            this.FabricanteId.MinimumWidth = 6;
            this.FabricanteId.Name = "FabricanteId";
            this.FabricanteId.ReadOnly = true;
            this.FabricanteId.Width = 125;
            // 
            // Fabricante
            // 
            this.Fabricante.DataPropertyName = "NombreFabricante";
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.MinimumWidth = 6;
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.ReadOnly = true;
            this.Fabricante.Visible = false;
            this.Fabricante.Width = 125;
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
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 623);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 37);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(1065, 623);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 37);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Atras";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::CapaVista.Properties.Resources.edit_v2;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::CapaVista.Properties.Resources.delete;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbInactivos);
            this.groupBox2.Controls.Add(this.rdbActivos);
            this.groupBox2.Location = new System.Drawing.Point(974, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 115);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por estado";
            // 
            // rdbInactivos
            // 
            this.rdbInactivos.AutoSize = true;
            this.rdbInactivos.Location = new System.Drawing.Point(18, 65);
            this.rdbInactivos.Name = "rdbInactivos";
            this.rdbInactivos.Size = new System.Drawing.Size(96, 28);
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
            this.rdbActivos.Size = new System.Drawing.Size(84, 28);
            this.rdbActivos.TabIndex = 0;
            this.rdbActivos.TabStop = true;
            this.rdbActivos.Text = "Activos";
            this.rdbActivos.UseVisualStyleBackColor = true;
            this.rdbActivos.UseWaitCursor = true;
            this.rdbActivos.CheckedChanged += new System.EventHandler(this.rdbActivos_CheckedChanged);
            // 
            // MantenimientoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.gpbxFiltro);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "NombreCategoria", true));
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MantenimientoProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | Mantenimiento de Productos";
            this.gpbxFiltro.ResumeLayout(false);
            this.gpbxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbxFiltro;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.ComboBox cbxCategorias;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbInactivos;
        private System.Windows.Forms.RadioButton rdbActivos;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxFabricante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencias;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn FabricanteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}