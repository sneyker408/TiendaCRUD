namespace CapaVista
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MnProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnDInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.MnDProducto_Click = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MnPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnCategoria,
            this.MnProductos,
            this.MnClientes,
            this.MnProveedores,
            this.MnPedido});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnCategoria
            // 
            this.MnCategoria.Name = "MnCategoria";
            this.MnCategoria.Size = new System.Drawing.Size(94, 24);
            this.MnCategoria.Text = "Categorias";
            this.MnCategoria.Click += new System.EventHandler(this.MnCategoria_Click);
            // 
            // MnProductos
            // 
            this.MnProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnDInventario,
            this.MnDProducto_Click,
            this.productosToolStripMenuItem});
            this.MnProductos.Name = "MnProductos";
            this.MnProductos.Size = new System.Drawing.Size(60, 24);
            this.MnProductos.Text = "Areas";
            // 
            // MnDInventario
            // 
            this.MnDInventario.Name = "MnDInventario";
            this.MnDInventario.Size = new System.Drawing.Size(270, 26);
            this.MnDInventario.Text = "Inventario";
            this.MnDInventario.Click += new System.EventHandler(this.MnDInventario_Click);
            // 
            // MnDProducto_Click
            // 
            this.MnDProducto_Click.Name = "MnDProducto_Click";
            this.MnDProducto_Click.Size = new System.Drawing.Size(270, 26);
            this.MnDProducto_Click.Text = "Mantenimiento de Pedidos";
            this.MnDProducto_Click.Click += new System.EventHandler(this.MnDProducto_Click_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // MnClientes
            // 
            this.MnClientes.Name = "MnClientes";
            this.MnClientes.Size = new System.Drawing.Size(75, 24);
            this.MnClientes.Text = "Clientes";
            this.MnClientes.Click += new System.EventHandler(this.MnClientes_Click);
            // 
            // MnProveedores
            // 
            this.MnProveedores.Name = "MnProveedores";
            this.MnProveedores.Size = new System.Drawing.Size(105, 24);
            this.MnProveedores.Text = "Proveedores";
            this.MnProveedores.Click += new System.EventHandler(this.MnProveedores_Click);
            // 
            // MnPedido
            // 
            this.MnPedido.Name = "MnPedido";
            this.MnPedido.Size = new System.Drawing.Size(75, 24);
            this.MnPedido.Text = "Pedidos";
            this.MnPedido.Click += new System.EventHandler(this.MnPedido_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vapesney | Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnProductos;
        private System.Windows.Forms.ToolStripMenuItem MnCategoria;
        private System.Windows.Forms.ToolStripMenuItem MnClientes;
        private System.Windows.Forms.ToolStripMenuItem MnProveedores;
        private System.Windows.Forms.ToolStripMenuItem MnPedido;
        private System.Windows.Forms.ToolStripMenuItem MnDInventario;
        private System.Windows.Forms.ToolStripMenuItem MnDProducto_Click;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}

