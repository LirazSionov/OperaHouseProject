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
    public class Fluent_InstanceTypeContext : IEntityTypeConfiguration<Fluent_InstanceType>
    {
        public void Configure(EntityTypeBuilder<Fluent_InstanceType> builder)
        {
           builder.HasKey(i => i.InstanceID);//PK
           builder.Property(i => i.Name).IsRequired().HasMaxLength(15);
           builder.Property(i => i.Composer).IsRequired().HasMaxLength(15);
           builder.Property(i => i.Writer).HasMaxLength(15);
           builder.Property(i => i.DateWriting).HasMaxLength(10);
                   
        }
    }
}
