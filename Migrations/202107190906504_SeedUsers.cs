namespace Veenca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1f7f56da-041e-4ce3-b80e-3f71b90ed0bd', N'veencaspc@gmail.com', 0, N'AD2YrlLkyFJbfhd5SROR7285XxgbwMVHRfg4gA1RtflkOXN8ay/cpCmAxLNRejmEiA==', N'7d3c33e5-b54f-4243-a088-100d7468a0d8', NULL, 0, 0, NULL, 1, 0, N'veencaspc@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'57c6962c-9187-4fdd-800b-3caee1ff5278', N'admin2@veenca.com', 0, N'ADgFLjye5t9hlWnArSAg+LkOKS/pt9GD9tx63ukLHxcn1Y0pxobDbvRpk1Orbn8z3A==', N'0121e05b-21af-4b60-98f5-0eb8cf523f07', NULL, 0, 0, NULL, 1, 0, N'admin2@veenca.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'90f99eff-f6e0-43e5-9716-eb8929800b9c', N'guest@veenca.com', 0, N'ALyn8CVv+jCjtTpQRznzikA7j3gGQiizBKCfPa1KTxForRd8iWRM652YOe9c1rmkOg==', N'4c795712-1f88-49af-8154-686756a52275', NULL, 0, 0, NULL, 1, 0, N'guest@veenca.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9994b40b-6833-4cab-9a9e-ca6aedbda859', N'admin@veenca.com', 0, N'AIIGnAn/ajtk73FQ1QIWDqkhb3po1pzxVFbscafbtcV4EMso7xYrBu0F/xZkve2JSw==', N'cb7e5b8a-9617-40fb-a07d-09aea33cd5be', NULL, 0, 0, NULL, 1, 0, N'admin@veenca.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'79962f48-3bd2-42ec-a0b6-1e41f844b3b8', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'57c6962c-9187-4fdd-800b-3caee1ff5278', N'79962f48-3bd2-42ec-a0b6-1e41f844b3b8')

");
        }
        
        public override void Down()
        {
        }
    }
}
