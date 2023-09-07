using KisiNot.DATA.Entities;
using KisiNot.DATA.Enums;
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
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC14;Database=KisiNotDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kullanici>().HasIndex(x => x.kullaniciAdi).IsUnique();
            modelBuilder.Entity<Kullanici>().HasMany(x => x.Nots).WithOne(x => x.Kullanici).HasForeignKey(x => x.KullaniciId);

            modelBuilder.Entity<Kullanici>().HasData(
                new Kullanici
                {
                    Id= 1,
                    Ad = "Naime",
                    Soyad = "Damataşı",
                    kullaniciAdi = "ndmts",
                    Sifre = "1*Naime",
                    Statu = Statu.Active,
                    Tip = Tip.admin
                });
        }
    }
}
