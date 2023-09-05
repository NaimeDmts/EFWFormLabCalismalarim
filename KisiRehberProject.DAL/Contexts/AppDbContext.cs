using KisiRehberProject.DAL.Mapping;
using KisiRehberProject.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiRehberProject.DAL.Contexts
{
    public class AppDbContext :DbContext
    {
        public DbSet<Kisi> Kisis { get; set; }
        public DbSet<Adres> Adreses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC14;Database=KisiRehberDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KisiMapping());
            modelBuilder.ApplyConfiguration(new AdresMapping());
        }
    }
}
