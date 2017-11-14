using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week_10_Project.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int BuildYear { get; set; }
        public int HorsePower { get; set; }
        public int TopSpeed { get; set; }
        public double Acceleration { get; set; }
        public int Weight { get; set; }
        public string ImageLink { get; set; }
    }
}
