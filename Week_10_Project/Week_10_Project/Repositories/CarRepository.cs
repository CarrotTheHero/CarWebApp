using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week_10_Project.Entities;
using Week_10_Project.Models;

namespace Week_10_Project.Repositories
{
    public class CarRepository
    {
        CarContext CarContext;

        public CarRepository(CarContext carContext)
        {
            CarContext = carContext;
        }

        public List<Car> GetAll()
        {
            return CarContext.Cars.ToList();
        }
    }
}
