using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
        {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
            {
            builder.HasData(
                new IdentityUserRole<string>
                    {
                    RoleId = "0b8f8a9e-e015-2241-a14f-31f096ced1ef",
                    UserId = "6e7b01b5-71ae-41fd-98f5-d1c8c04a4b1d"
                    },
                new IdentityUserRole<string>
                    {
                    RoleId = "0b8f8a9e-e015-2241-a14d-31f098dse1ef",
                    UserId = "3decbeda-ebe7-4fbe-afd2-3095a32791bc"
                    }
                );
            }
        }
    }