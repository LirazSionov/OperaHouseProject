using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer;
using Microsoft.EntityFrameworkCore;
using System.Text;
using OperaHouseMidProject.Model;
using System.Threading.Tasks;
using OperaHouseMidProject.FluentConfig;

namespace OperaHouseMidProject.DataAccess
{
    public class BlogDBContext:DbContext
    {
        public DbSet<Fluent_artists> Fluent_artists { get; set; }
        public DbSet<Fluent_concerts> Fluent_concerts { get; set; }
        public DbSet<Fluent_conductors> Fluent_conductors { get; set; }
        public DbSet<Fluent_guests> Fluent_guests { get; set; }
        public DbSet<Fluent_halls> Fluent_halls { get; set; }
        public DbSet<Fluent_InstanceType> Fluent_InstanceType { get; set; }
        public DbSet<Fluent_players> Fluent_players { get; set; }
        public DbSet<Fluent_users> Fluent_users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=MyOperaHouse;Trusted_Connection=True;MultipleActiveResultSets = true");
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Fluent_ArtistsContext());
            modelBuilder.ApplyConfiguration(new Fluent_ConcertsContext());
            modelBuilder.ApplyConfiguration(new Fluent_ConductorsContext());
            modelBuilder.ApplyConfiguration(new Fluent_ConductorsContext());
            modelBuilder.ApplyConfiguration(new Fluent_HallsContext());
            modelBuilder.ApplyConfiguration(new Fluent_InstanceTypeContext());
            modelBuilder.ApplyConfiguration(new Fluent_PlayersContext());
            modelBuilder.ApplyConfiguration(new Fluent_usersContext());

        }



    }
}
