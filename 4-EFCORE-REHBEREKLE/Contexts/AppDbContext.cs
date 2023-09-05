using _4_EFCORE_REHBEREKLE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EFCORE_REHBEREKLE.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Kisi> Kisis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC14;Database=TelefonRehberi;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kisi>().Property(x => x.Ad).HasMaxLength(50);
            modelBuilder.Entity<Kisi>().HasIndex(x => x.Telefon).IsUnique();
        }
    }
}
