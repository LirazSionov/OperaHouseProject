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
    public class Fluent_usersContext : IEntityTypeConfiguration<Fluent_users>
    {
        public void Configure(EntityTypeBuilder<Fluent_users> builder)
        {
            builder.HasKey(u => u.UserId);//Makes UserId as PK
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(15);
            builder.Property(u => u.UserType).HasMaxLength(10);
        }
    }
}
