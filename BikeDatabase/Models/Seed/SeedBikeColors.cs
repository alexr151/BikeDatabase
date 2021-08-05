using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDatabase.Models.Seed
{
    public class SeedBikeColors : IEntityTypeConfiguration<BikeColor>
    {

        public void Configure(EntityTypeBuilder<BikeColor> entity)
        {
            entity.HasData(
                new BikeColor { BikeColorId = "red", Color = "Red" },
                new BikeColor { BikeColorId = "blue", Color = "Blue" },
                new BikeColor { BikeColorId = "grn", Color = "Green" },
                new BikeColor { BikeColorId = "purp", Color = "Purple"},
                new BikeColor { BikeColorId = "pnk", Color = "Pink"},
                new BikeColor { BikeColorId = "ylw", Color = "Yellow" },
                new BikeColor { BikeColorId = "wht", Color = "White" },
                new BikeColor { BikeColorId = "blk", Color = "Black" },
                new BikeColor { BikeColorId = "gld", Color = "Gold"},
                new BikeColor { BikeColorId = "slv", Color = "Silver"},
                new BikeColor { BikeColorId = "brz", Color = "Bronze"},
                new BikeColor { BikeColorId = "org", Color = "Orange"}
                );
        }
    }
}
