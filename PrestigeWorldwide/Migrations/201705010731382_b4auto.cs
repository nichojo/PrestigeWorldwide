namespace PrestigeWorldwide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b4auto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Itineraries", "Distance", c => c.Int(nullable: false));
            AlterColumn("dbo.Itineraries", "From_Airport", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Itineraries", "To_Airport", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Itineraries", "To_Airport", c => c.String());
            AlterColumn("dbo.Itineraries", "From_Airport", c => c.String());
            DropColumn("dbo.Itineraries", "Distance");
        }
    }
}
