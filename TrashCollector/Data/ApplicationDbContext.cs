using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Models;

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
            //builder.Entity<IdentityRole>()
            //.HasData(
            // new IdentityRole
            // {
            //     //Id = "36ed2b64-e030-4d28-8c42-3e971ae100f3",
            //     Name = "Employee",
            //     NormalizedName = "EMPLOYEE"
            // },
            //  new IdentityRole
            //  {
            //      //Id = "dbe1796b-1f88-4aa5-b5c8-76ba6866bf75",
            //      Name = "Customer",
            //      NormalizedName = "CUSTOMER"
            //  }
            //);
        }
        public DbSet<TrashCollector.Models.Customer> Customer { get; set; }
        public DbSet<TrashCollector.Models.Employee> Employee { get; set; }
    }
}
