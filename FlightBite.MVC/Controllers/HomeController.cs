﻿using Microsoft.AspNetCore.Mvc;

namespace FlightBite.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
