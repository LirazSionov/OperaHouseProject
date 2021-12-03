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
    public class Fluent_HallsContext : IEntityTypeConfiguration<Fluent_halls>
    {
        public void Configure(EntityTypeBuilder<Fluent_halls> builder)
        {
            builder.HasKey(h => h.HallId);//PK
            builder.Property(h => h.HallName).IsRequired().HasMaxLength(10);
            builder.Property(h => h.SeatsNum).HasMaxLength(3);

        }
    }
}
