﻿using Microsoft.AspNetCore.Mvc;

namespace FlightBite.MVC.Areas.SuperAdmin.Controllers
{
    [Area("SuperAdmin")]
    public class ClientController : Controller
    {
        public ClientController()
        {
            
        }
        public IActionResult Index()
        {
            return View();
        }
		public IActionResult CreateNewClient()
		{
			return View();
		}
	}
}
