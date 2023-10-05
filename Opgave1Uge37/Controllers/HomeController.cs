using Microsoft.AspNetCore.Mvc;
using Opgave1Uge37.Models;
using System;
using System.Diagnostics;

namespace Opgave1Uge37.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IDummy _dummy;

        public HomeController(ILogger<HomeController> logger, IDummy dummy)
        {
            _logger = logger;
            _dummy = dummy;
        }
            
        public IActionResult Index()
        {
            var serverTime = _dummy.Now;
            if (serverTime.Hour < 12)
            {
                ViewData["Message"] = "It's morning here - Good Morning!";
            }
            else if (serverTime.Hour < 17)
            {
                ViewData["Message"] = "It's afternoon here - Good Afternoon!";
            }
            else
            {
                ViewData["Message"] = "It's evening here - Good Evening!";
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}