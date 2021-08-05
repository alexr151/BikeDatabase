using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDatabase.Models.Seed
{
    public class SeedTireSizes : IEntityTypeConfiguration<TireSize>
    {

        public void Configure(EntityTypeBuilder<TireSize> entity)
        {
            entity.HasData(
            new TireSize { TireSizeId = "12x1.75", Tire = "12 x 1.75"  },
            new TireSize { TireSizeId = "12x1.9", Tire = "12 x 1.90"  },
            new TireSize { TireSizeId = "12.5x1.75", Tire = "12 1/2 x 1.75" },
            new TireSize { TireSizeId = "12.5x1.9", Tire = "12 1/2 x 1.90" },
            new TireSize { TireSizeId = "12x2", Tire = "12 x 2.00" },
            new TireSize { TireSizeId = "12x1.95", Tire = "12 x 1.95" },
            new TireSize { TireSizeId = "12.5x2.25", Tire = "12 1/2 x 2 1/4" }
            );
        }
    }
}