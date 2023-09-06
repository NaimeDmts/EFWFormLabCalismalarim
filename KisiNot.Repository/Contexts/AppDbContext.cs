using KisiNot.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiNot.Repository.Contexts
{
    public class AppDbContext :DbContext
    {
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Not> Nots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC14;Database=KisiNotDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().HasIndex(x => x.kullaniciAdi).IsUnique();
            modelBuilder.Entity<Kullanici>().HasMany(x => x.Nots).WithOne(x => x.Kullanici).HasForeignKey(x => x.KullaniciId);
        }
    }
}
