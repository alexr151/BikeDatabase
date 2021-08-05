using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDatabase.Models.Seed
{
    public class SeedBikes : IEntityTypeConfiguration<Bike>
    {

        public void Configure(EntityTypeBuilder<Bike> entity)
        {
            entity.HasData(
                new Bike { BikeId = 1, Make = "Masi", Model = "Inizio", BikeSizeId = "58",  GearNumberId = "2x7", BikeColorId = "blue", BikeTypeId = "rd", TireSizeId = "12x2"},
                new Bike { BikeId = 2, Make = "Trek", Model = "520", BikeSizeId = "60", GearNumberId = "2x11", BikeColorId = "grn", BikeTypeId = "com", TireSizeId = "12x2" },
                new Bike { BikeId = 3, Make = "Giant", Model = "Escape 3", BikeSizeId = "56", GearNumberId = "3x8", BikeColorId = "red", BikeTypeId = "hyb", TireSizeId = "12x2" },
                new Bike { BikeId = 4, Make = "Townie", Model = "Cruiser 2", BikeSizeId = "16", GearNumberId = "1x3", BikeColorId = "gld", BikeTypeId = "cru", TireSizeId = "12x2" }
                );
        }
    }
}