using Microsoft.EntityFrameworkCore;
using PARCIAL.Api.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARCIAL.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {


        }

        public DbSet<Vote> Votes { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Vote>().HasIndex(p => p.OptionId).IsUnique();
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();

        }

    }
}
