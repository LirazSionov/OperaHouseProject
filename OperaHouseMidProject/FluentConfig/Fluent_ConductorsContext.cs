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
    public class Fluent_ConductorsContext : IEntityTypeConfiguration<Fluent_conductors>
    {
        public void Configure(EntityTypeBuilder<Fluent_conductors> builder)
        {
            builder.HasKey(c => c.ArtistId);//PK
            builder.Property(c => c.FirstName).HasMaxLength(15).IsRequired();
            builder.Property(c => c.LastName).HasMaxLength(15).IsRequired();
                             
            builder.Property(c => c.City).HasMaxLength(10);
            builder.Property(c => c.Address).HasMaxLength(20);
            builder.Property(c => c.BirthDate).HasMaxLength(10);
            builder.Property(c => c.EmailAddress).HasMaxLength(25);
            builder.Property(c => c.PhoneNumber).HasMaxLength(15);
            builder.Property(c => c.Gender).HasMaxLength(2);

            builder.Property(c => c.SpecializationType);
        }
    }
}
