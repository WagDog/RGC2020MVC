namespace RGC2020MVC.WebUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdminUser : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [Name]) VALUES (N'29da6b18-9665-43f1-be6c-6b3105a24ffb', N'admin@cardsandtoys.co.uk', 0, N'AKpXJkfSSXXR/IcEWa0AlolWxIlgGFLnBTY1LpaUL76A0bRBOgO6vDcP6zv7JsRo1g==', N'323ac5b1-2eb2-4426-9625-4465d5e212c8', NULL, 0, 0, NULL, 1, 0, N'admin@cardsandtoys.co.uk', N'Mr Admin')");
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'71284be3-090f-4dd4-ade6-eed1cc1fb082', N'Admin')");
            Sql(@"INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'29da6b18-9665-43f1-be6c-6b3105a24ffb', N'71284be3-090f-4dd4-ade6-eed1cc1fb082')");
        }
        
        public override void Down()
        {
        }
    }
}
