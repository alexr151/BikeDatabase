using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDatabase.Models.Seed
{
    public class SeedGearNumbers : IEntityTypeConfiguration<GearNumber>
    {

        public void Configure(EntityTypeBuilder<GearNumber> entity)
        {
            entity.HasData(
                new GearNumber { GearNumberId = "1x1", Gear = "Single Speed"},
                new GearNumber { GearNumberId = "1x3", Gear = "1x3" },
                new GearNumber { GearNumberId = "1x4", Gear = "1x4" },
                new GearNumber { GearNumberId = "1x6", Gear = "1x6"},
                new GearNumber { GearNumberId = "1x7", Gear = "1x7" },
                new GearNumber { GearNumberId = "1x8", Gear = "1x8" },
                new GearNumber { GearNumberId = "1x9", Gear = "1x9" },
                new GearNumber { GearNumberId = "1x10", Gear = "1x10" },
                new GearNumber { GearNumberId = "1x11", Gear = "1x11" },
                new GearNumber { GearNumberId = "1x12", Gear = "1x12" },
                new GearNumber { GearNumberId = "2x6", Gear = "2 X 6"},
                new GearNumber { GearNumberId = "2x7", Gear = "2 X 7" },
                new GearNumber { GearNumberId = "2x8", Gear = "2 X 8" },
                new GearNumber { GearNumberId = "2x9", Gear = "2 X 9" },
                new GearNumber { GearNumberId = "2x10", Gear = "2 X 10" },
                new GearNumber { GearNumberId = "2x11", Gear = "2 X 11" },
                new GearNumber { GearNumberId = "2x12", Gear = "2 X 12" },
                new GearNumber { GearNumberId = "3x6", Gear = "3 X 6" },
                new GearNumber { GearNumberId = "3x7", Gear = "3 X 7" },
                new GearNumber { GearNumberId = "3x8", Gear = "3 X 8" },
                new GearNumber { GearNumberId = "3x9", Gear = "3 X 9" },
                new GearNumber { GearNumberId = "3x10", Gear = "3 X 10" },
                new GearNumber { GearNumberId = "3x11", Gear = "3 X 11" },
                new GearNumber { GearNumberId = "3x12", Gear = "3 X 12" }
                );
        }
    }
}