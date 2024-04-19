namespace CapaVista
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.MnProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MnDtProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MnInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.MnClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MnPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.MnPedido,
            this.ventasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnCategoria
            // 
            this.MnCategoria.Name = "MnCategoria";
            this.MnCategoria.Size = new System.Drawing.Size(94, 24);
            this.MnCategoria.Text = "Categorias";
            // 
            // MnProductos
            // 
            this.MnProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnDtProducto,
            this.MnInventario,
            this.mantenimientoDeProductosToolStripMenuItem});
            this.MnProductos.Name = "MnProductos";
            this.MnProductos.Size = new System.Drawing.Size(89, 24);
            this.MnProductos.Text = "Productos";
            // 
            // MnDtProducto
            // 
            this.MnDtProducto.Name = "MnDtProducto";
            this.MnDtProducto.Size = new System.Drawing.Size(284, 26);
            this.MnDtProducto.Text = "Detalle de  Productos";
            this.MnDtProducto.Click += new System.EventHandler(this.MnDtProducto_Click);
            // 
            // MnInventario
            // 
            this.MnInventario.Name = "MnInventario";
            this.MnInventario.Size = new System.Drawing.Size(284, 26);
            this.MnInventario.Text = "Inventario";
            // 
            // MnClientes
            // 
            this.MnClientes.Name = "MnClientes";
            this.MnClientes.Size = new System.Drawing.Size(75, 24);
            this.MnClientes.Text = "Clientes";
            // 
            // MnProveedores
            // 
            this.MnProveedores.Name = "MnProveedores";
            this.MnProveedores.Size = new System.Drawing.Size(105, 24);
            this.MnProveedores.Text = "Proveedores";
            // 
            // MnPedido
            // 
            this.MnPedido.Name = "MnPedido";
            this.MnPedido.Size = new System.Drawing.Size(75, 24);
            this.MnPedido.Text = "Pedidos";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeVentasToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // mantenimientoDeProductosToolStripMenuItem
            // 
            this.mantenimientoDeProductosToolStripMenuItem.Name = "mantenimientoDeProductosToolStripMenuItem";
            this.mantenimientoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(284, 26);
            this.mantenimientoDeProductosToolStripMenuItem.Text = "Mantenimiento de Productos";
            // 
            // registroDeVentasToolStripMenuItem
            // 
            this.registroDeVentasToolStripMenuItem.Name = "registroDeVentasToolStripMenuItem";
            this.registroDeVentasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registroDeVentasToolStripMenuItem.Text = "Registro de Ventas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem MnDtProducto;
        private System.Windows.Forms.ToolStripMenuItem MnInventario;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeVentasToolStripMenuItem;
    }
}

