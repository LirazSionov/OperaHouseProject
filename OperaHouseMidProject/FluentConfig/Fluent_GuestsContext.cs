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
    class Fluent_GuestsContext : IEntityTypeConfiguration<Fluent_guests>
    {
        public void Configure(EntityTypeBuilder<Fluent_guests> builder)
        {
            builder.HasKey(g => g.GuestId);//PK
            builder.Property(g => g.GuestName).IsRequired().HasMaxLength(15);
            builder.Property(g => g.ConcertName).IsRequired().HasMaxLength(15);
            builder.Property(g => g.DateConcert).HasMaxLength(10);
            builder.Property(g => g.HallName).IsRequired().HasMaxLength(10);
            builder.Property(g => g.Hour).HasMaxLength(5);
            builder.Property(g => g.PhoneNumber).HasMaxLength(15);


        }
    }
}
