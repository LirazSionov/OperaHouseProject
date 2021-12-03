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
    public class Fluent_ConcertsContext : IEntityTypeConfiguration<Fluent_concerts>
    {
        public void Configure(EntityTypeBuilder<Fluent_concerts> builder)
        {
            builder.HasKey(c => c.ConcertId);//PK
            builder.Property(c => c.ConductorName).HasMaxLength(15).IsRequired();
            builder.Property(c => c.InstanceName).IsRequired().HasMaxLength(15);
            builder.Property(c => c.HallName).HasMaxLength(10).IsRequired();
            builder.Property(c => c.HallNum).HasMaxLength(2).IsRequired();
            builder.Property(c => c.Date).HasMaxLength(10).IsRequired();
            builder.Property(c => c.Hour).HasMaxLength(5).IsRequired();
            builder.Property(c => c.Duration).HasMaxLength(5).IsRequired();
            builder.Property(c => c.Cost).HasMaxLength(3).IsRequired();

        }
    }
}
