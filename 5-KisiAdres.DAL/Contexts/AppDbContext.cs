using _5_KisiAdres.DATA.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_KisiAdres.DAL.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<Kisi> Kisis { get; set; }
        public DbSet<Adres> Adreses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC14;Database=KisiRehberDB;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("Server=DESKTOP-EI4I1FN\\MSSQLSERVER2019;User Id=sa;Password=1702;Database=KisiRehberDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adres>().HasOne(x => x.Kisi).WithMany(x => x.Adresler).HasForeignKey(x => x.KisiId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
