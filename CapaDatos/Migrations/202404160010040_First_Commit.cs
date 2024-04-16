namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First_Commit : DbMigration
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
                        CorreoElectronico = c.String(nullable: false, maxLength: 100),
                        Direccion = c.String(maxLength: 255),
                        NumeroTelefono = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.DetallePedidoes",
                c => new
                    {
                        DetallePedidoID = c.Int(nullable: false, identity: true),
                        PedidoID = c.Int(nullable: false),
                        ProductoID = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        PrecioUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DetallePedido_DetallePedidoID = c.Int(),
                    })
                .PrimaryKey(t => t.DetallePedidoID)
                .ForeignKey("dbo.DetallePedidoes", t => t.DetallePedido_DetallePedidoID)
                .Index(t => t.DetallePedido_DetallePedidoID);
            
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
                .PrimaryKey(t => t.InventarioID);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        PedidoID = c.Int(nullable: false, identity: true),
                        ClienteID = c.Int(nullable: false),
                        FechaHoraPedido = c.DateTime(nullable: false),
                        EstadoPedido = c.String(nullable: false, maxLength: 50),
                        TotalPedido = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.PedidoID);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoID = c.Int(nullable: false, identity: true),
                        NombreProducto = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(maxLength: 255),
                        Precio = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StockDisponible = c.Int(nullable: false),
                        Fabricante = c.String(maxLength: 100),
                        CategoriaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoID);
            
            CreateTable(
                "dbo.Proveedors",
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
            DropForeignKey("dbo.DetallePedidoes", "DetallePedido_DetallePedidoID", "dbo.DetallePedidoes");
            DropIndex("dbo.DetallePedidoes", new[] { "DetallePedido_DetallePedidoID" });
            DropTable("dbo.Proveedors");
            DropTable("dbo.Productoes");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.Inventarios");
            DropTable("dbo.DetallePedidoes");
            DropTable("dbo.Clientes");
            DropTable("dbo.Categorias");
        }
    }
}
