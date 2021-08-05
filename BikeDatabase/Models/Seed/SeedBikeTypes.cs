using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDatabase.Models.Seed
{
    public class SeedBikeTypes : IEntityTypeConfiguration<BikeType>
    {

        public void Configure(EntityTypeBuilder<BikeType> entity)
        {
            entity.HasData(
                new BikeType { BikeTypeId = "rd", Type = "Road" },
                new BikeType { BikeTypeId = "mtn", Type = "Mountain" },
                new BikeType { BikeTypeId = "cc", Type = "CycloCross" },
                new BikeType { BikeTypeId = "com", Type = "Commuter" },
                new BikeType { BikeTypeId = "cmf", Type = "Comfort" },
                new BikeType { BikeTypeId = "cru", Type = "Cruiser" },
                new BikeType { BikeTypeId = "fit", Type = "Fitness" },
                new BikeType { BikeTypeId = "hyb", Type = "Hybrid" },
                new BikeType { BikeTypeId = "kid", Type = "Children's" },
                new BikeType { BikeTypeId = "bmx", Type = "BMX" },
                new BikeType { BikeTypeId = "elc", Type = "Electric" },
                new BikeType { BikeTypeId = "rec", Type = "Recumbant" }
         );
        }
    }
}