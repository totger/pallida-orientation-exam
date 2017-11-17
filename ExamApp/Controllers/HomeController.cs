using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamApp.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExamApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        readonly CarService carService;

        public HomeController(CarService carService)
        {
            this.carService = carService;
        }

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("search/")]
        public IActionResult GetByPlate([FromForm]string plate)
        {
            return View("Index", carService.GetByPlate(plate));
        }

        [HttpGet]
        [Route("search/{brand}")]
        public IActionResult FilterByBrand(string brand)
        {
            return View("Index", carService.FilterByBrand(brand));
        }

        [HttpGet]
        [Route("search/police=1")]
        public IActionResult GetPoliceCars()
        {
            return View("Index", carService.GetPoliceCars());
        }

        [HttpGet]
        [Route("search/diplomat=1")]
        public IActionResult Diplomat()
        {
            return View("Index", carService.GetDiplomatCars());
        }

        [HttpGet]
        [Route("/api/search/{brand}")]
        public IActionResult Json(string brand)
        {
            return Json(carService.FilterByBrand(brand));
        }
    }
}
