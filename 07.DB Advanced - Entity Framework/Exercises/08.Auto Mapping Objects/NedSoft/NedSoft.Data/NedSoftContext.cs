using System;
using Microsoft.EntityFrameworkCore;
using NedSoft.Models;

namespace NedSoft.Data
{
    public class NedSoftContext : DbContext
    {
        protected NedSoftContext()
        {
        }
        public NedSoftContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
