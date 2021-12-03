using Microsoft.EntityFrameworkCore;
using System;
using OperaHouseMidProject.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OperaHouseMidProject.FluentConfig
{
    public class Fluent_ArtistsContext : IEntityTypeConfiguration<Fluent_artists>
    {
        public void Configure(EntityTypeBuilder<Fluent_artists> builder)
        {
            builder.HasKey(a => a.ArtistId);//PK
            builder.Property(a => a.FirstName).HasMaxLength(15).IsRequired();
            builder.Property(a => a.LastName).HasMaxLength(15).IsRequired();
          
            builder.Property(a => a.City).HasMaxLength(10);
            builder.Property(a => a.Address).HasMaxLength(20);
            builder.Property(a => a.BirthDate).HasMaxLength(10);
            builder.Property(a => a.EmailAddress).HasMaxLength(25);
            builder.Property(a => a.PhoneNumber).HasMaxLength(15);
            builder.Property(a => a.Gender).HasMaxLength(2);


        }

    }
}
