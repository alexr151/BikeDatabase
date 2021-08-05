using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDatabase.Models.Seed
{
    public class SeedUsers : IEntityTypeConfiguration<User>
    {
        public void Configure (EntityTypeBuilder<User> entity)
        {
            entity.HasData(
                new User { UserId = 1, FirstName = "Alex", LastName = "Ryberg", DOB = new DateTime(1997, 7, 12), Email = "alex@ryberg.com" },
                new User { UserId = 2, FirstName = "Ashley", LastName = "Green", DOB = new DateTime(1997, 7, 15), Email = "ashley@green.com" },
                new User { UserId = 3, FirstName = "Olive", LastName = "Green", DOB = new DateTime (2016, 7, 23), Email = "olive@green.com"},
                new User { UserId = 4, FirstName = "Nick", LastName = "Gunther", DOB = new DateTime(1997, 5, 19), Email = "nick@gunther.com"}
                );
        }
    }
}
