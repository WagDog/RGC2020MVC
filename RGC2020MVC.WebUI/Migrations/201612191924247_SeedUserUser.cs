namespace RGC2020MVC.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUserUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name]) VALUES (N'f02bc608-ddd8-48f4-8631-c634ef2a7771', N'user@cardsandtoys.co.uk', 0, N'AJxQWEWfhbJTg3/feb3XQkgrhbbRcMZS2AJk5TGl/r3W6Or1Y62PYtA4gKraX9XDKQ==', N'9b16d967-d9b0-4a2f-a1cc-37d272f7b1f3', NULL, 0, 0, NULL, 1, 0, N'user@cardsandtoys.co.uk', N'A User')");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'95a614f9-aa3b-4829-9ed5-d4d37fa804bd', N'User')");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f02bc608-ddd8-48f4-8631-c634ef2a7771', N'95a614f9-aa3b-4829-9ed5-d4d37fa804bd')");
        }
        
        public override void Down()
        {
        }
    }
}
