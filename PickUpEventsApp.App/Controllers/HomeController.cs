﻿using Microsoft.AspNetCore.Mvc;
using PickUpEventsApp.App.Models;
using System.Diagnostics;

namespace PickUpEventsApp.App.Controllers
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

        //Simple landing pages with one simulating a sign on screen
        public IActionResult LandingPage1()
        {
            return View();
        }

        //Second simple landing page
        public IActionResult LandingPage2()
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