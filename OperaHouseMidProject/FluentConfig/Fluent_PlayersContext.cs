using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OperaHouseMidProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperaHouseMidProject.FluentConfig
{
    public class Fluent_PlayersContext : IEntityTypeConfiguration<Fluent_players>
    {

        public void Configure(EntityTypeBuilder<Fluent_players> builder)
        {
            builder.HasKey(p => p.ArtistId);//PK
            builder.Property(p => p.FirstName).HasMaxLength(15).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(15).IsRequired();
                                  
            builder.Property(p => p.City).HasMaxLength(10);
            builder.Property(p => p.Address).HasMaxLength(20);
            builder.Property(p => p.BirthDate).HasMaxLength(10);
            builder.Property(p => p.EmailAddress).HasMaxLength(25);
            builder.Property(p => p.PhoneNumber).HasMaxLength(15);
            builder.Property(p => p.Gender).HasMaxLength(2);

            builder.Property(p => p.MusicalInstrument);
        }
    }
}
