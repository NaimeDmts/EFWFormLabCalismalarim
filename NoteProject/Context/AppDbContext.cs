using Microsoft.EntityFrameworkCore;
using NoteProject.Entities.Concrete;
using NoteProject.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteProject.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Not> Nots { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();

            optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC14;Database=NotProjectDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasIndex(x => x.UserName).IsUnique();
            modelBuilder.Entity<User>().Property(x=>x.FirstName).HasMaxLength(50);
            modelBuilder.Entity<User>().Property(x=>x.LastName).HasMaxLength(50);

            modelBuilder.Entity<Not>().Property(x => x.Title).HasMaxLength(100);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Status =Status.Active,
                    FirstName = "Admin",
                    LastName = "Manager",
                    UserName = "Admin",
                    Password = "admin123",
                    IsActive = true,
                    userType = UseType.Admin
                });
        }
    }
}
