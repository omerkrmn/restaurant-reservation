using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RR.Repositories.EFCore.Configs
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = "685af3ae-f760-401f-a303-2946728314dd",
                    ConcurrencyStamp = "8ba33fac-e542-4859-8663-416101f4fb0a"

                },
                new IdentityRole
                {
                    Name = "Owner",
                    NormalizedName = "OWNER",
                    Id = "9d5b9cb2-86d3-4db8-a427-e961acf15965",
                    ConcurrencyStamp = "c3fad4fb-a14f-43e6-9b7f-c4d0539d5079"
                },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    Id = "a330656d-3a4e-4022-8ca7-65fa628505f4",
                    ConcurrencyStamp = "aa66e72f-bcdb-4b01-9600-965c1a940a07"
                }
            );
        }
    }
}
