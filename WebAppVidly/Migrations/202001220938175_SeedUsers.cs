namespace WebAppVidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'62cb3812-483a-4b4e-910c-f6ac817a0a70', N'guest@3dscanners.co.uk', 0, N'ALBxxkmPa3/pgLKgBuYApq5128zHM09HaJMTbdiDJTkFyUyHKDVgwbFAXZloTS/k9g==', N'85c8f2e9-7f14-48cf-8894-c23de7d523bf', NULL, 0, 0, NULL, 1, 0, N'guest@3dscanners.co.uk')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0ed1cfc0-ea84-41b8-951a-0ae4f1904fee', N'benko.peter@gmail.com', 0, N'ACo9k+2gCxTG+/r4GaTDMte+Rndz82d53SjrIQvNq07ARij/cBjzNVfMmZCs34Sxeg==', N'9a183f92-682b-4fe2-9dde-cb77d3448971', NULL, 0, 0, NULL, 1, 0, N'benko.peter@gmail.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'981b95d6-54c7-4cc9-be1e-786bc2d616b9', N'admin@webvidly.com', 0, N'AGdxGo4bZjhca7+CQgg/EuqFPLAhOyXB0XfO2sXgy56bRoh2V1toLEPZsRSbh93NZA==', N'd0fd9bcd-ad40-4ca8-bd6e-7d101738a7ee', NULL, 0, 0, NULL, 1, 0, N'admin@webvidly.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c9b839b1-e54a-4194-90f3-90126de5de94', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'981b95d6-54c7-4cc9-be1e-786bc2d616b9', N'c9b839b1-e54a-4194-90f3-90126de5de94')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
