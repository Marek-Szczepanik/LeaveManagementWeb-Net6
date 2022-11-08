using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                    {
                    Id = "0b8f8a9e-e015-2241-a14f-31f096ced1ef",
                    Name = Roles.Administrator,
                    NormalizedName = Roles.Administrator.ToUpper()
                    },
                new IdentityRole
                    {
                    Id = "0b8f8a9e-e015-2241-a14d-31f098dse1ef",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                    }
                ) ;
        }
    }
}