using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BikeDatabase.Models
{
    public class Bike
    {
        public int BikeId {get;set;}

        public string Make { get; set; }
        public string Model { get; set; }

        public string BikeSizeId { get; set; }
        public BikeSize BikeSize { get; set; }

        public string GearNumberId { get; set; }
        public GearNumber GearNumber { get; set; }

        public string BikeColorId { get; set; }
        public BikeColor BikeColor { get; set; }


        public string BikeTypeId { get; set; }
        public BikeType BikeType { get; set; }

        public string TireSizeId { get; set; }
        public TireSize TireSize { get; set; }


    }
}
