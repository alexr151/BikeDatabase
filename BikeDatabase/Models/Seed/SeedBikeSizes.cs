using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDatabase.Models.Seed
{
    public class SeedBikeSizes : IEntityTypeConfiguration<BikeSize>
    {
        public void Configure(EntityTypeBuilder<BikeSize> entity)
        {
            entity.HasData(
                new BikeSize { BikeSizeId = "47", Size = "47cm"   },
                new BikeSize { BikeSizeId = "48", Size = "48cm"   },
                new BikeSize { BikeSizeId = "49", Size = "49cm"   },
                new BikeSize { BikeSizeId = "50", Size = "50cm"   },
                new BikeSize { BikeSizeId = "51", Size = "51cm"   },
                new BikeSize { BikeSizeId = "52", Size = "52cm"   },
                new BikeSize { BikeSizeId = "53", Size = "53cm"   },
                new BikeSize { BikeSizeId = "54", Size = "54cm"   },
                new BikeSize { BikeSizeId = "55", Size = "55cm"   },
                new BikeSize { BikeSizeId = "56", Size = "56cm"   },
                new BikeSize { BikeSizeId = "57", Size = "57cm"   },
                new BikeSize { BikeSizeId = "58", Size = "58cm"   },
                new BikeSize { BikeSizeId = "59", Size = "59cm"   },
                new BikeSize { BikeSizeId = "60", Size = "60cm"   },
                new BikeSize { BikeSizeId = "61", Size = "61cm"   },
                new BikeSize { BikeSizeId = "62", Size = "62cm"   },
                new BikeSize { BikeSizeId = "63", Size = "63cm"   },
                new BikeSize { BikeSizeId = "13", Size = "13in"   },
                new BikeSize { BikeSizeId = "14", Size = "14in"   },
                new BikeSize { BikeSizeId = "15", Size = "15in"   },
                new BikeSize { BikeSizeId = "16", Size = "16in"   },
                new BikeSize { BikeSizeId = "17", Size = "17in"   },
                new BikeSize { BikeSizeId = "18", Size = "18in"   },
                new BikeSize { BikeSizeId = "19", Size = "19in"   },
                new BikeSize { BikeSizeId = "20", Size = "20in"   },
                new BikeSize { BikeSizeId = "21", Size = "21in"   },
                new BikeSize { BikeSizeId = "22", Size = "22in"   },
                new BikeSize { BikeSizeId = "23", Size = "23in"   },
                new BikeSize { BikeSizeId = "24", Size = "24in"   }
                );        
        }
    }
}
