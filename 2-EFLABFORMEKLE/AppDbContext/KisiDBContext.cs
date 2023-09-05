using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using _2_EFLABFORMEKLE.Models;

namespace _2_EFLABFORMEKLE.AppDbContext
{
    public partial class KisiDBContext : DbContext
    {
        public KisiDBContext()
        {
        }

        public KisiDBContext(DbContextOptions<KisiDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblKisi> TblKisis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=KDK-403-YZ-PC14;Database=KisiDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblKisi>(entity =>
            {
                entity.HasKey(e => e.KisiId)
                    .HasName("PK__TblKisi__110EDC891E237832");

                entity.ToTable("TblKisi");

                entity.Property(e => e.KisiId).HasColumnName("KisiID");

                entity.Property(e => e.KisiAd).HasMaxLength(50);

                entity.Property(e => e.KisiAdres).HasMaxLength(50);

                entity.Property(e => e.KisiDogumTarihi).HasColumnType("datetime");

                entity.Property(e => e.KisiSehir).HasMaxLength(50);

                entity.Property(e => e.KisiSoyad).HasMaxLength(50);

                entity.Property(e => e.KisiTelefon).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
