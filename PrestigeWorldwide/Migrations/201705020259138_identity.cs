namespace PrestigeWorldwide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class identity : DbMigration
    {
        public override void Up()
        {
            
            CreateTable(
                "dbo.Itineraries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        User = c.String(maxLength: 50),
                        From_Airport = c.String(nullable: false, maxLength: 50),
                        To_Airport = c.String(nullable: false, maxLength: 50),
                        Description = c.String(maxLength: 50),
                        Name = c.String(nullable: false, maxLength: 50),
                        Distance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Itineraries");

        }
    }
}
