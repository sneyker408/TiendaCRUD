namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Empleadoes", "Telefono", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Empleadoes", "Telefono", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
