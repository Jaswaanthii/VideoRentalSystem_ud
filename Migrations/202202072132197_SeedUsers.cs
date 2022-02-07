namespace VideoRentalSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'021db94b-9c43-4048-a322-fe092fe9e8d1', N'admin@group3.com', 0, N'AI0qkTZKr0nJxC9Btst8EBIXx+EFX+qptmFPFbPIQnXjT14GybKx7ay8S0he3OFwwQ==', N'bb4845f6-4135-4f7e-b1d2-3a0b63fbd81c', NULL, 0, 0, NULL, 1, 0, N'admin@group3.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f61927f-fb89-4259-8112-9b9e628b8ba2', N'faboroa@uni.coventry.ac.uk', 0, N'AKOPAJ2srRWxJ4NI5x8d+0JcNK6NJ16vD2vZzrJ5nKeG4bK6N7/c2rnCT8To0cAA8w==', N'1eb9aca5-563b-4129-ad13-81cfa02f2e6e', NULL, 0, 0, NULL, 1, 0, N'faboroa@uni.coventry.ac.uk')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b9e1c71d-7d75-4799-88fe-d337fa1bb407', N'padmanabhj@uni.coventry.ac.uk', 0, N'AJW94hglXoqsJYFo+K7nPNRm+Pr0qV1WseUeEpy1KZw9neZ3L55Pjepn0ILGBY/ilA==', N'24da80fa-7c22-4b87-a8da-07b981b2ca3f', NULL, 0, 0, NULL, 1, 0, N'padmanabhj@uni.coventry.ac.uk')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ba20ecd6-05f3-42da-8478-bbd61d4dabe2', N'jadavjik@cucollege.coventry.ac.uk', 0, N'APqNfMAY3+jG1ruJhMwXbDI/TLxZ6uquo0a9T/v+R3NbaDJdCoMi44HBRloazSGU+w==', N'4e3425b0-b90e-47da-9add-f717b6acc0b8', NULL, 0, 0, NULL, 1, 0, N'jadavjik@cucollege.coventry.ac.uk')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'bacfb995-91d2-411e-a9ad-a819f7ff4298', N'drammeha@uni.coventry.ac.uk', 0, N'AI14sbpA+ngieT6gDPbjw60IEXrYf3fZLWh83fgc62K5dwzKdP7y9prSXxgfTr558Q==', N'9f195a98-5c53-491c-aa32-504b752ef462', NULL, 0, 0, NULL, 1, 0, N'drammeha@uni.coventry.ac.uk')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cc4634f5-894a-47fd-8cf7-c3fc57635516', N'nazimr@uni.coventry.ac.uk', 0, N'AKpBtY1tggeAXm83c4OIr8U+2aE2SznHjw1/CkZfwb+fK97Wi3pkfnpV5zx0NuEXAA==', N'd280f403-59d3-4c85-ac60-0f016fbf0320', NULL, 0, 0, NULL, 1, 0, N'nazimr@uni.coventry.ac.uk')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd67ed976-15ea-47e1-956f-ab513bbbf9f2', N'guest@group3.com', 0, N'AKqIm0JXQ6MZ8pPk5wzOz2yryvBMK26K+q8C0Onr8gHtUj9I0z+QFPJ/7sVaZHA6hA==', N'687fd3b6-3967-4b48-8885-a900ed3d9bf2', NULL, 0, 0, NULL, 1, 0, N'guest@group3.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f6abdf44-2675-494d-863e-e31e41936822', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'021db94b-9c43-4048-a322-fe092fe9e8d1', N'f6abdf44-2675-494d-863e-e31e41936822')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7f61927f-fb89-4259-8112-9b9e628b8ba2', N'f6abdf44-2675-494d-863e-e31e41936822')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b9e1c71d-7d75-4799-88fe-d337fa1bb407', N'f6abdf44-2675-494d-863e-e31e41936822')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ba20ecd6-05f3-42da-8478-bbd61d4dabe2', N'f6abdf44-2675-494d-863e-e31e41936822')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'bacfb995-91d2-411e-a9ad-a819f7ff4298', N'f6abdf44-2675-494d-863e-e31e41936822')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cc4634f5-894a-47fd-8cf7-c3fc57635516', N'f6abdf44-2675-494d-863e-e31e41936822')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
