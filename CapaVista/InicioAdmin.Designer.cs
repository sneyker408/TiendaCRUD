namespace CapaVista
{
    partial class InicioAdmin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnRegistroVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnMttmProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fabricanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoFabricanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoFabricanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.fabricanteToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1063, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnRegistroVentas});
            this.ventasToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // MnRegistroVentas
            // 
            this.MnRegistroVentas.BackColor = System.Drawing.Color.White;
            this.MnRegistroVentas.ForeColor = System.Drawing.Color.Black;
            this.MnRegistroVentas.Name = "MnRegistroVentas";
            this.MnRegistroVentas.Size = new System.Drawing.Size(241, 28);
            this.MnRegistroVentas.Text = "Registro de Ventas";
            this.MnRegistroVentas.Click += new System.EventHandler(this.MnRegistroVentas_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnMttmProductos,
            this.nuevoProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(104, 28);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // MnMttmProductos
            // 
            this.MnMttmProductos.Name = "MnMttmProductos";
            this.MnMttmProductos.Size = new System.Drawing.Size(316, 28);
            this.MnMttmProductos.Text = "Mantenimiento de Productos";
            this.MnMttmProductos.Click += new System.EventHandler(this.MnMttmProductos_Click);
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(316, 28);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo Producto";
            this.nuevoProductoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProductoToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoCategoriaToolStripMenuItem,
            this.nuevaCategoriaToolStripMenuItem});
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(107, 28);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // mantenimientoCategoriaToolStripMenuItem
            // 
            this.mantenimientoCategoriaToolStripMenuItem.Name = "mantenimientoCategoriaToolStripMenuItem";
            this.mantenimientoCategoriaToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.mantenimientoCategoriaToolStripMenuItem.Text = "Mantenimiento Categoria";
            this.mantenimientoCategoriaToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoCategoriaToolStripMenuItem_Click);
            // 
            // nuevaCategoriaToolStripMenuItem
            // 
            this.nuevaCategoriaToolStripMenuItem.Name = "nuevaCategoriaToolStripMenuItem";
            this.nuevaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(286, 28);
            this.nuevaCategoriaToolStripMenuItem.Text = "Nueva Categoria";
            this.nuevaCategoriaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCategoriaToolStripMenuItem_Click);
            // 
            // fabricanteToolStripMenuItem
            // 
            this.fabricanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoFabricanteToolStripMenuItem,
            this.nuevoFabricanteToolStripMenuItem});
            this.fabricanteToolStripMenuItem.Name = "fabricanteToolStripMenuItem";
            this.fabricanteToolStripMenuItem.Size = new System.Drawing.Size(105, 28);
            this.fabricanteToolStripMenuItem.Text = "Fabricante";
            this.fabricanteToolStripMenuItem.Click += new System.EventHandler(this.fabricanteToolStripMenuItem_Click);
            // 
            // mantenimientoFabricanteToolStripMenuItem
            // 
            this.mantenimientoFabricanteToolStripMenuItem.Name = "mantenimientoFabricanteToolStripMenuItem";
            this.mantenimientoFabricanteToolStripMenuItem.Size = new System.Drawing.Size(293, 28);
            this.mantenimientoFabricanteToolStripMenuItem.Text = "Mantenimiento Fabricante";
            this.mantenimientoFabricanteToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoFabricanteToolStripMenuItem_Click);
            // 
            // nuevoFabricanteToolStripMenuItem
            // 
            this.nuevoFabricanteToolStripMenuItem.Name = "nuevoFabricanteToolStripMenuItem";
            this.nuevoFabricanteToolStripMenuItem.Size = new System.Drawing.Size(293, 28);
            this.nuevoFabricanteToolStripMenuItem.Text = "Nuevo Fabricante";
            this.nuevoFabricanteToolStripMenuItem.Click += new System.EventHandler(this.nuevoFabricanteToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoClienteToolStripMenuItem,
            this.nuevoClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(86, 28);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // mantenimientoClienteToolStripMenuItem
            // 
            this.mantenimientoClienteToolStripMenuItem.Name = "mantenimientoClienteToolStripMenuItem";
            this.mantenimientoClienteToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
            this.mantenimientoClienteToolStripMenuItem.Text = "Mantenimiento Cliente";
            this.mantenimientoClienteToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoClienteToolStripMenuItem_Click);
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(265, 28);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoEmpleadosToolStripMenuItem,
            this.agregarEmpleadoToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(101, 28);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // mantenimientoEmpleadosToolStripMenuItem
            // 
            this.mantenimientoEmpleadosToolStripMenuItem.Name = "mantenimientoEmpleadosToolStripMenuItem";
            this.mantenimientoEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(298, 28);
            this.mantenimientoEmpleadosToolStripMenuItem.Text = "Mantenimiento Empleados";
            this.mantenimientoEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoEmpleadosToolStripMenuItem_Click);
            // 
            // agregarEmpleadoToolStripMenuItem
            // 
            this.agregarEmpleadoToolStripMenuItem.Name = "agregarEmpleadoToolStripMenuItem";
            this.agregarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(298, 28);
            this.agregarEmpleadoToolStripMenuItem.Text = "Agregar Empleado";
            this.agregarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.agregarEmpleadoToolStripMenuItem_Click);
            // 
            // InicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVista.Properties.Resources.logo3;
            this.ClientSize = new System.Drawing.Size(1063, 673);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "InicioAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnRegistroVentas;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnMttmProductos;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fabricanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoFabricanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoFabricanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarEmpleadoToolStripMenuItem;
    }
}

