using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Week_10_Project.Repositories;
using Week_10_Project.Models;

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
            return View(new Car());
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(Car car)
        {
            CarRepository.AddCar();
            return RedirectToAction("List");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            CarRepository.DeleteCar(id);
            return RedirectToAction("List");
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Update(int id)
        {
            var car = CarRepository.Updating(id);
            return View(car);
        }

        [Route("/{id}/edit")]
        [HttpPost]
        public IActionResult Edit(Car car)
        {
            CarRepository.UpdateTodo(car);
            return RedirectToAction("List");
        }

        [Route("/{id}/singleinfo")]
        [HttpGet]
        public IActionResult SingleInfo(int id)
        {
            var todo = CarRepository.Updating(id);
            return View(todo);
        }
    }
}
