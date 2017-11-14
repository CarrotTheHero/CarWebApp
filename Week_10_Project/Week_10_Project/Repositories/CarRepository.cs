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

        public void AddCar(string model, int buildyear, double acceleration, int horsepower, int topspeed, int weight, string imagelink)
        {
            var car = new Car()
            {
                Model = model,
                BuildYear = buildyear,
                Acceleration = acceleration,
                HorsePower = horsepower,
                TopSpeed = topspeed,
                Weight = weight,
                ImageLink = imagelink,
            };
            CarContext.Cars.Add(car);
            CarContext.SaveChanges();
        }

        public void DeleteCar(int id)
        {
            Car deletedCar = CarContext.Cars.FirstOrDefault(x => x.Id == id);
            CarContext.Cars.Remove(deletedCar);
            CarContext.SaveChanges();
        }

        public Car Updating(int id)
        {
            return CarContext.Cars.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateTodo(Car car)
        {
            CarContext.Cars.Update(car);
            CarContext.SaveChanges();

        }

    }
}
