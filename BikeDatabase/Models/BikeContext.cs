using BikeDatabase.Models.Seed;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDatabase.Models
{
    public class BikeContext : DbContext
    {
        public BikeContext(DbContextOptions<BikeContext> options) : base(options) { }

        public DbSet<Bike> Bikes { get; set; }
        public DbSet<BikeSize> BikeSizes { get; set; }
        public DbSet<BikeColor> BikeColors { get; set; }
        public DbSet<BikeType> BikeTypes { get; set; }
        public DbSet<GearNumber> GearNumbers { get; set; }
        public DbSet<TireSize> TireSizes { get; set; }


        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new SeedBikeColors());
            modelBuilder.ApplyConfiguration(new SeedBikes());
            modelBuilder.ApplyConfiguration(new SeedBikeSizes());
            modelBuilder.ApplyConfiguration(new SeedBikeTypes());
            modelBuilder.ApplyConfiguration(new SeedGearNumbers());
            modelBuilder.ApplyConfiguration(new SeedTireSizes());
            modelBuilder.ApplyConfiguration(new SeedUsers());

        }
    }
}
