namespace RGC2020MVC.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                        EntryDateTime = c.DateTime(nullable: false),
                        AmountCredited = c.Decimal(precision: 18, scale: 2),
                        AmountDebited = c.Decimal(precision: 18, scale: 2),
                        Description = c.String(maxLength: 50),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.CompetitionId);
            
            CreateTable(
                "dbo.Competitions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Accounts", "UserId", "dbo.Users");
            DropForeignKey("dbo.Accounts", "CompetitionId", "dbo.Competitions");
            DropIndex("dbo.Accounts", new[] { "CompetitionId" });
            DropIndex("dbo.Accounts", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Competitions");
            DropTable("dbo.Accounts");
        }
    }
}
