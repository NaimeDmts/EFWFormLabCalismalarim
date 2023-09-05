using KisiRehberProject.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiRehberProject.DAL.Mapping
{
    public class AdresMapping : IEntityTypeConfiguration<Adres>
    {
        public void Configure(EntityTypeBuilder<Adres> builder)
        {
            builder.Property(a => a.Sehir).HasMaxLength(13);
            builder.Property(a => a.Ilce).HasMaxLength(20);

            builder.HasData(
                new Adres() { Id = 1, Sehir = "Kastamonu", Ilce = "Tosya", AdresDetay = "YeşilYurt", KisiId = 1 },
                new Adres() { Id = 2, Sehir = "Ankara", Ilce = "Gölbaşı", AdresDetay = "Karanfil", KisiId = 1 },
                new Adres() { Id = 3, Sehir = "Muğla", Ilce = "Fethiye", AdresDetay = "Taşyaka", KisiId = 2 }
                );

        }
    }
}
