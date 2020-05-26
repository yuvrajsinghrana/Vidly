namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'21dd1ffd-26ac-45ed-a6af-9239f56f8074', N'guest@vidly.com', 0, N'AI/w7L/w3PwIJH5Fc1vlgWzdiAkWXJ4kSVK27cNHE9fuSQrPuoU9HCAloXM75tpuvA==', N'd1df7239-d895-4fcc-8834-eba51a8b1082', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'558f2967-861b-4c08-8131-a7dbaa4d85ff', N'admin@vidly.com', 0, N'AMFMwTfP8b4tQ4qNkhzJ7O+zrvYvhb5S0nm47ggHxU8Ru5UjR0/4MC7Q4RN8WWpiRA==', N'3e9bc478-c92f-4cde-b88e-d7754f1d3bec', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5df139ca-6f3b-45ec-98f6-80d5c5bc6359', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'558f2967-861b-4c08-8131-a7dbaa4d85ff', N'5df139ca-6f3b-45ec-98f6-80d5c5bc6359')

");
        }
        
        public override void Down()
        {
        }
    }
}
