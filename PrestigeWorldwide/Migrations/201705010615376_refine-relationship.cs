namespace PrestigeWorldwide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class refinerelationship : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Itineraries", "From_Airport_AirportId", "dbo.Airports");
            DropForeignKey("dbo.Itineraries", "To_Airport_AirportId", "dbo.Airports");
            DropIndex("dbo.Itineraries", new[] { "From_Airport_AirportId" });
            DropIndex("dbo.Itineraries", new[] { "To_Airport_AirportId" });
            AddColumn("dbo.Itineraries", "From_Airport", c => c.String());
            AddColumn("dbo.Itineraries", "To_Airport", c => c.String());
            DropColumn("dbo.Itineraries", "From_Airport_AirportId");
            DropColumn("dbo.Itineraries", "To_Airport_AirportId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Itineraries", "To_Airport_AirportId", c => c.Int());
            AddColumn("dbo.Itineraries", "From_Airport_AirportId", c => c.Int());
            DropColumn("dbo.Itineraries", "To_Airport");
            DropColumn("dbo.Itineraries", "From_Airport");
            CreateIndex("dbo.Itineraries", "To_Airport_AirportId");
            CreateIndex("dbo.Itineraries", "From_Airport_AirportId");
            AddForeignKey("dbo.Itineraries", "To_Airport_AirportId", "dbo.Airports", "AirportId");
            AddForeignKey("dbo.Itineraries", "From_Airport_AirportId", "dbo.Airports", "AirportId");
        }
    }
}
