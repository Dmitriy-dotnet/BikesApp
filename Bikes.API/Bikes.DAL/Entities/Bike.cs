using Bikes.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bikes.DAL.Entities
{
    public class Bike : BaseEntity
    {
        public string Name { get; set; }
        public BikeType BikeType { get; set; }
        public int Price { get; set; }
    }

}
