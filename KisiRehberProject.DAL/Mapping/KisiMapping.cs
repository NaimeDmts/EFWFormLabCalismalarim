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
    public class KisiMapping : IEntityTypeConfiguration<Kisi>
    {
        public void Configure(EntityTypeBuilder<Kisi> builder)
        {
          

            builder.Property(a => a.Ad).HasMaxLength(50);
            //builder.Property(a => a.CreateDate).HasDefaultValue(DateTime.Now);

            builder.HasData(
                new Kisi() { Id = 1, Ad = "Sefa", Soyad = "Attila", Telefon = "552 828 1903" },
                new Kisi() { Id = 2, Ad = "Ahmet", Soyad = "Yılmaz", Telefon = "552 828 1903" }
                );
        }
    }
}
