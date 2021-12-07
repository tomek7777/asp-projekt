using Lab_5_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_5_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult PowerForm()
        {
            return View();
        }

        public string About()
        {
            return "Info o programie w ASP.NET Core";
        }

        /*
         * Napisz metodę akcji Power, która podnosi do kwadratu parametr num
         */
        public string Power(decimal? num)
        {
            return num == null ? "Brak parametru potrzebnego do obliczeń!" : $"Kwadrat liczby {num}: { num * num}";
        }

        public string Hello(string name, int? age)
        {
            if (age == null)
            {
                return $"Cześć {name}, nie podałeś wieku!!!";
            }
            return $"Cześć {name} {age}";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
