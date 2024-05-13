namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificaciontablaempleadonombreDireccion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleadoes", "Direccion", c => c.String(nullable: false, maxLength: 200));
            DropColumn("dbo.Empleadoes", "Dicreecion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empleadoes", "Dicreecion", c => c.String(nullable: false, maxLength: 200));
            DropColumn("dbo.Empleadoes", "Direccion");
        }
    }
}
