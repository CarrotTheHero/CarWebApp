using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Week_10_Project.Repositories;

namespace Week_10_Project.Controllers
{
    public class CarController : Controller
    {
        CarRepository CarRepository;

        public CarController(CarRepository carRepository)
        {
            CarRepository = carRepository;
        }

        [Route("/")]
        [HttpGet]
        public IActionResult List()
        {
            return View(CarRepository.GetAll());
        }

        [Route("/{id}/carinfo")]
        [HttpGet]
        public IActionResult Info()
        {
            return View();
        }

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string brand)
        {
            CarRepository.AddCar(brand);
            return RedirectToAction("List");
        }
    }
}
