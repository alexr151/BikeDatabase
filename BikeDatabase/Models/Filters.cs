using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDatabase.Models
{
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all-all-all-all";
            string[] filters = FilterString.Split('-');
            BikeSizeId = filters[0];
            GearNumberId = filters[1];
            BikeColorId = filters[2];
            BikeTypeId = filters[3];
            TireSizeId = filters[4];
        }

        public string FilterString { get; }
        public string BikeSizeId { get; }
        public string GearNumberId { get; }
        public string BikeColorId { get; }
        public string BikeTypeId { get; }
        public string TireSizeId { get; }


        public bool HasBikeSize => BikeSizeId.ToLower() != "all";
        public bool HasGearNumber => GearNumberId.ToLower() != "all";
        public bool HasBikeColor => BikeColorId.ToLower() != "all";
        public bool HasBikeType => BikeTypeId.ToLower() != "all";
        public bool HasTireSize => TireSizeId.ToLower() != "all";


    }
}
