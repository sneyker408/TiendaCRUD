namespace CapaDatos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondcommit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fabricantes", "Estado", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fabricantes", "Estado");
        }
    }
}
