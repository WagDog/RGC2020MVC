namespace RGC2020MVC.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompetitionTypes : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[CompetitionTypes] ([Description], [CreatedAt], [UpdatedAt]) VALUES ('Medal', '2016-12-01 00:00:00', '2016-12-01 00:00:0')");
            Sql(@"INSERT INTO [dbo].[CompetitionTypes] ([Description], [CreatedAt], [UpdatedAt]) VALUES ('Stableford', '2016-12-01 00:00:00', '2016-12-01 00:00:0')");
            Sql(@"INSERT INTO [dbo].[CompetitionTypes] ([Description], [CreatedAt], [UpdatedAt]) VALUES ('Bogey', '2016-12-01 00:00:00', '2016-12-01 00:00:0')");
        }
        
        public override void Down()
        {
        }
    }
}
