using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week_10_Project.Models
{
    public class Car
    {
        public string Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarBody { get; set; }
        public string Color { get; set; }
        public string FuelType { get; set; }
        public int BuildYear { get; set; }
        public int HorsePower { get; set; }
        public int Torque { get; set; }
        public int Seats { get; set; }
    }
}
