using Microsoft.EntityFrameworkCore;
using Student_information.Models;
using System.Collections.Generic;

namespace Student_information.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : base(options)
        {
        }

        public DbSet<Friend> Friends { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
