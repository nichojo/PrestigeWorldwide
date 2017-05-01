namespace PrestigeWorldwide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class starthere : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Airports",
                c => new
                    {
                        AirportId = c.Int(nullable: false, identity: true),
                        Ident = c.String(),
                        Type = c.String(),
                        Name = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        Continent = c.String(),
                        ISOCountry = c.String(),
                        ISORegion = c.String(),
                        GPSCode = c.String(),
                        Municipality = c.String(),
                        Serviced = c.String(),
                        IATACode = c.String(),
                        LocalCode = c.String(),
                    })
                .PrimaryKey(t => t.AirportId);
            
            CreateTable(
                "dbo.Itineraries",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        User = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        From_Airport_AirportId = c.Int(),
                        To_Airport_AirportId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Airports", t => t.From_Airport_AirportId)
                .ForeignKey("dbo.Airports", t => t.To_Airport_AirportId)
                .Index(t => t.From_Airport_AirportId)
                .Index(t => t.To_Airport_AirportId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Itineraries", "To_Airport_AirportId", "dbo.Airports");
            DropForeignKey("dbo.Itineraries", "From_Airport_AirportId", "dbo.Airports");
            DropIndex("dbo.Itineraries", new[] { "To_Airport_AirportId" });
            DropIndex("dbo.Itineraries", new[] { "From_Airport_AirportId" });
            DropTable("dbo.Itineraries");
            DropTable("dbo.Airports");
        }
    }
}
