namespace RGC2020MVC.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedSuperUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name]) VALUES (N'35659fae-3fa7-4df5-8852-2b87966e9fda', N'paulwagstaff66@gmail.com', 0, N'AFC5PfSXwLLOW5DBUj1iwRea2I7LMdHKLtX9YTSKy22hSYnsskwUHEErYKZMfFxaKg==', N'66c2c376-20d5-4d6b-996a-38dded0b6a6f', NULL, 0, 0, NULL, 1, 0, N'paulwagstaff66@gmail.com', N'Paul Wagstaff')");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'060b7e22-2f6f-4ba3-b6e6-a06d66cddb2e', N'SuperUser')");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'35659fae-3fa7-4df5-8852-2b87966e9fda', N'060b7e22-2f6f-4ba3-b6e6-a06d66cddb2e')");
        }
        
        public override void Down()
        {
        }
    }
}
