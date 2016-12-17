namespace RGC2020MVC.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBulkInsertCompetitionCompetitionTypesScoreUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompetitionTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BulkInserts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompetitionId = c.Int(nullable: false),
                        CsvInput = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .Index(t => t.CompetitionId);
            
            CreateTable(
                "dbo.Scores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CompetitionId = c.Int(nullable: false),
                        Position = c.Int(nullable: false),
                        AmountWon = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Result = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitions", t => t.CompetitionId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.CompetitionId);
            
            AddColumn("dbo.Competitions", "Name", c => c.String(maxLength: 30));
            AddColumn("dbo.Competitions", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Competitions", "CompetitionTypeId", c => c.Int(nullable: false));
            AddColumn("dbo.Competitions", "TotalMoney", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Competitions", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Competitions", "UpdatedAt", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Competitions", "CompetitionTypeId");
            AddForeignKey("dbo.Competitions", "CompetitionTypeId", "dbo.CompetitionTypes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Scores", "UserId", "dbo.Users");
            DropForeignKey("dbo.Scores", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.BulkInserts", "CompetitionId", "dbo.Competitions");
            DropForeignKey("dbo.Competitions", "CompetitionTypeId", "dbo.CompetitionTypes");
            DropIndex("dbo.Scores", new[] { "CompetitionId" });
            DropIndex("dbo.Scores", new[] { "UserId" });
            DropIndex("dbo.BulkInserts", new[] { "CompetitionId" });
            DropIndex("dbo.Competitions", new[] { "CompetitionTypeId" });
            DropColumn("dbo.Competitions", "UpdatedAt");
            DropColumn("dbo.Competitions", "CreatedAt");
            DropColumn("dbo.Competitions", "TotalMoney");
            DropColumn("dbo.Competitions", "CompetitionTypeId");
            DropColumn("dbo.Competitions", "Date");
            DropColumn("dbo.Competitions", "Name");
            DropTable("dbo.Scores");
            DropTable("dbo.BulkInserts");
            DropTable("dbo.CompetitionTypes");
        }
    }
}
