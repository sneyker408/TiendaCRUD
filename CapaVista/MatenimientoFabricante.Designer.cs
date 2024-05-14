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
            this.FabricanteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreFabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.FabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbInactivos = new System.Windows.Forms.RadioButton();
            this.rdbActivos = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.cbxNombreFabri = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FabricanteBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnNuevoMFabri
            // 
            this.BtnNuevoMFabri.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuevoMFabri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuevoMFabri.Location = new System.Drawing.Point(13, 512);
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
            this.BtnAtrasMFabri.Location = new System.Drawing.Point(837, 512);
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
            this.dgvFabricante.Location = new System.Drawing.Point(13, 106);
            this.dgvFabricante.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFabricante.Name = "dgvFabricante";
            this.dgvFabricante.ReadOnly = true;
            this.dgvFabricante.RowHeadersWidth = 51;
            this.dgvFabricante.Size = new System.Drawing.Size(980, 398);
            this.dgvFabricante.TabIndex = 10;
            this.dgvFabricante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFabricante_CellClick);
            this.dgvFabricante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // FabricanteId
            // 
            this.FabricanteId.DataPropertyName = "FabricanteId";
            this.FabricanteId.HeaderText = "Codigo";
            this.FabricanteId.MinimumWidth = 6;
            this.FabricanteId.Name = "FabricanteId";
            this.FabricanteId.ReadOnly = true;
            this.FabricanteId.Width = 125;
            // 
            // nombreFabricanteDataGridViewTextBoxColumn
            // 
            this.nombreFabricanteDataGridViewTextBoxColumn.DataPropertyName = "NombreFabricante";
            this.nombreFabricanteDataGridViewTextBoxColumn.HeaderText = "Nombre";
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
            // FabricanteBindingSource
            // 
            this.FabricanteBindingSource.DataSource = typeof(CapaEntidades.Fabricante);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbInactivos);
            this.groupBox2.Controls.Add(this.rdbActivos);
            this.groupBox2.Location = new System.Drawing.Point(670, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 76);
            this.groupBox2.TabIndex = 7;
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
            // groupBox
            // 
            this.groupBox.Controls.Add(this.cbxNombreFabri);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.txtCodigo);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(13, 10);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox.Size = new System.Drawing.Size(635, 76);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Filtro por Fabricante";
            // 
            // cbxNombreFabri
            // 
            this.cbxNombreFabri.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxNombreFabri.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxNombreFabri.DataSource = this.FabricanteBindingSource;
            this.cbxNombreFabri.DisplayMember = "NombreFabricante";
            this.cbxNombreFabri.FormattingEnabled = true;
            this.cbxNombreFabri.Location = new System.Drawing.Point(378, 31);
            this.cbxNombreFabri.Name = "cbxNombreFabri";
            this.cbxNombreFabri.Size = new System.Drawing.Size(250, 24);
            this.cbxNombreFabri.TabIndex = 36;
            this.cbxNombreFabri.ValueMember = "ProductoId";
            this.cbxNombreFabri.SelectedIndexChanged += new System.EventHandler(this.cbxNombreFabri_SelectedIndexChanged);
            this.cbxNombreFabri.TextUpdate += new System.EventHandler(this.cbxNombreFabri_TextUpdate);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.FabricanteBindingSource, "FabricanteId", true));
            this.txtCodigo.Location = new System.Drawing.Point(76, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(201, 22);
            this.txtCodigo.TabIndex = 34;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Codigo";
            // 
            // MatenimientoFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.BtnNuevoMFabri);
            this.Controls.Add(this.BtnAtrasMFabri);
            this.Controls.Add(this.dgvFabricante);
            this.Controls.Add(this.groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MatenimientoFabricante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | Matenimiento Fabricante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFabricante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FabricanteBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnNuevoMFabri;
        private System.Windows.Forms.Button BtnAtrasMFabri;
        private System.Windows.Forms.DataGridView dgvFabricante;
        private System.Windows.Forms.BindingSource FabricanteBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbInactivos;
        private System.Windows.Forms.RadioButton rdbActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FabricanteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreFabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox cbxNombreFabri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
    }
}