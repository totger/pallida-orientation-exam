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

        [Route("search")]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("search/police=1")]
        public IActionResult Police()
        {
            return View(carService.GetPoliceCars());
        }

        [Route("search/diplomat=1")]
        public IActionResult Diplomat()
        {
            return View(carService.GetDiplomatCars());
        }
    }
}
