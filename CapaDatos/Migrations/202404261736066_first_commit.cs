namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first_commit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaID = c.Int(nullable: false, identity: true),
                        NombreCategoria = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.CategoriaID);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Apellido = c.String(nullable: false, maxLength: 100),
                        CorreoElectronico = c.String(nullable: false),
                        Direccion = c.String(nullable: false, maxLength: 255),
                        NumeroTelefono = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.DetallePedidos",
                c => new
                    {
                        DetallePedidoID = c.Int(nullable: false, identity: true),
                        PedidoID = c.Int(nullable: false),
                        ProductoID = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.DetallePedidoID)
                .ForeignKey("dbo.Pedidos", t => t.PedidoID, cascadeDelete: true)
                .ForeignKey("dbo.Productos", t => t.ProductoID, cascadeDelete: true)
                .Index(t => t.PedidoID)
                .Index(t => t.ProductoID);
            
            CreateTable(
                "dbo.Pedidos",
                c => new
                    {
                        PedidoID = c.Int(nullable: false, identity: true),
                        ClienteID = c.Int(nullable: false),
                        FechaHoraPedido = c.DateTime(nullable: false),
                        EstadoPedido = c.String(nullable: false, maxLength: 50),
                        TotalPedido = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PedidoID)
                .ForeignKey("dbo.Clientes", t => t.ClienteID, cascadeDelete: true)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        ProductoID = c.Int(nullable: false, identity: true),
                        NombreProducto = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockDisponible = c.Int(nullable: false),
                        Fabricante = c.String(),
                        EstadoPedido = c.String(),
                        CategoriaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoID)
                .ForeignKey("dbo.Categorias", t => t.CategoriaID, cascadeDelete: true)
                .Index(t => t.CategoriaID);
            
            CreateTable(
                "dbo.Inventarios",
                c => new
                    {
                        InventarioID = c.Int(nullable: false, identity: true),
                        ProductoID = c.Int(nullable: false),
                        CantidadStock = c.Int(nullable: false),
                        FechaUltimaReposicion = c.DateTime(nullable: false),
                        ProveedorID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.InventarioID)
                .ForeignKey("dbo.Productos", t => t.ProductoID, cascadeDelete: true)
                .ForeignKey("dbo.Proveedores", t => t.ProveedorID, cascadeDelete: true)
                .Index(t => t.ProductoID)
                .Index(t => t.ProveedorID);
            
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        ProveedorID = c.Int(nullable: false, identity: true),
                        NombreProveedor = c.String(nullable: false, maxLength: 100),
                        Direccion = c.String(maxLength: 255),
                        CorreoElectronico = c.String(maxLength: 100),
                        NumeroTelefono = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ProveedorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventarios", "ProveedorID", "dbo.Proveedores");
            DropForeignKey("dbo.Inventarios", "ProductoID", "dbo.Productos");
            DropForeignKey("dbo.DetallePedidos", "ProductoID", "dbo.Productos");
            DropForeignKey("dbo.Productos", "CategoriaID", "dbo.Categorias");
            DropForeignKey("dbo.DetallePedidos", "PedidoID", "dbo.Pedidos");
            DropForeignKey("dbo.Pedidos", "ClienteID", "dbo.Clientes");
            DropIndex("dbo.Inventarios", new[] { "ProveedorID" });
            DropIndex("dbo.Inventarios", new[] { "ProductoID" });
            DropIndex("dbo.Productos", new[] { "CategoriaID" });
            DropIndex("dbo.Pedidos", new[] { "ClienteID" });
            DropIndex("dbo.DetallePedidos", new[] { "ProductoID" });
            DropIndex("dbo.DetallePedidos", new[] { "PedidoID" });
            DropTable("dbo.Proveedores");
            DropTable("dbo.Inventarios");
            DropTable("dbo.Productos");
            DropTable("dbo.Pedidos");
            DropTable("dbo.DetallePedidos");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
        }
    }
}
