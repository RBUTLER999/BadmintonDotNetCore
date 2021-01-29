using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BaddersNetCore.Models;

namespace BaddersNetCore.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult BadmintonContact()
        {
            return View();
        }

        public IActionResult Fixtures()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult NoticesAndNews()
        {
            return View();
        }

        public IActionResult OurFriends()
        {
            return View();
        }

        public IActionResult UsefulLinks()
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
