using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentingServices.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentingServices.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Property> Properties { get; set; }
        public DbSet<Lease> Leases { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
