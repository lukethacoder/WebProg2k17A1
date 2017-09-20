using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cnbr_food_a1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Restaurants()
        {
            ViewData["Message"] = "Restaurants page. Provide information about local Canberra restaurants";

            return View();
        }

        public IActionResult Cuisine()
        {
            ViewData["Message"] = "Cuisine page.";

            return View();
        }

        public IActionResult Dishes()
        {
            ViewData["Message"] = "Dishes page.";

            return View();
        }

        public IActionResult Price()
        {
            ViewData["Message"] = "Dishes page.";

            return View();
        }

        public IActionResult Location()
        {
            ViewData["Message"] = "Location page.";

            return View();
        }

        public IActionResult Reviews()
        {
            ViewData["Message"] = "Reviews page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
