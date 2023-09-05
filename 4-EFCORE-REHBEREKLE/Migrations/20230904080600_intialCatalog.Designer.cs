﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _4_EFCORE_REHBEREKLE.Contexts;

#nullable disable

namespace _4_EFCORE_REHBEREKLE.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230904080600_intialCatalog")]
    partial class intialCatalog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_4_EFCORE_REHBEREKLE.Models.Kisi", b =>
                {
                    b.Property<int>("KisiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KisiId"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("KisiId");

                    b.HasIndex("Telefon")
                        .IsUnique();

                    b.ToTable("Kisis");
                });
#pragma warning restore 612, 618
        }
    }
}
