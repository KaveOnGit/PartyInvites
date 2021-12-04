using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        //public string Index()
        //{
        //    return "Hello World";
        //}

        public ViewResult Index()
        {
            
            int hour = DateTime.Now.Hour;
            if (hour > 0 && hour <= 4) ViewBag.Greeting = "Good Night";
            else if (hour >4 && hour <= 12) ViewBag.Greeting = "Good Мorning";
            else if (hour > 12 && hour <= 17) ViewBag.Greeting = "Good Day";
            else  ViewBag.Greeting = "Good Evening";
            int i = 22;
            //return this.View("MyView");******************
            return this.View("Index");
        }

        public ViewResult RsvpForm()
        {
            return View("RsvpForm");
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
