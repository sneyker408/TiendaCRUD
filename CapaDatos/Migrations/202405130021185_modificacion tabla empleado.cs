namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificaciontablaempleado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Empleadoes", "CorreoElectronico", c => c.String(nullable: false));
            DropColumn("dbo.Empleadoes", "Correo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Empleadoes", "Correo", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Empleadoes", "CorreoElectronico");
        }
    }
}
