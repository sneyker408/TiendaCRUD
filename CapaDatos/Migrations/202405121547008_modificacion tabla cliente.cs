namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificaciontablacliente : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "NumeroTelefono", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "NumeroTelefono", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
