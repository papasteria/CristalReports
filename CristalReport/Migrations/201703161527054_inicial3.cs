namespace CristalReport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Productos", "sDepartamemto", c => c.Double(nullable: false));
            DropColumn("dbo.Productos", "sCalificacion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Productos", "sCalificacion", c => c.String(nullable: false, unicode: false));
            DropColumn("dbo.Productos", "sDepartamemto");
        }
    }
}
