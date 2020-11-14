using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            {
                Id = "baf3cd45-1b23-47e2-98e1-e6bb6c716ba4",
                ConcurrencyStamp = "fbcb5316-94c9-492f-b776-0c751ee79c52",
                Name = "Admin",
                NormalizedName = "ADMIN"
            },
             new IdentityRole
             {
                 Id = "33e47045-2f50-4a16-8773-f252425b7225",
                 ConcurrencyStamp = "1af9df8b-e691-437d-ac53-ee5dfa1dbd66",
                 Name = "Employee",
                 NormalizedName = "EMPLOYEE"
             },
              new IdentityRole
              {
                  Id = "5daab92e-175e-448d-8ba1-a883a33891f2",
                  ConcurrencyStamp = "c6f45621-bf12-450a-a96f-b095abec6f87",
                  Name = "Customer",
                  NormalizedName = "CUSTOMER"
              }
            );
        }
    }
}
