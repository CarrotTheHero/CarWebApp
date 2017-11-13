using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Week_10_Project.Controllers
{
    public class CarController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
