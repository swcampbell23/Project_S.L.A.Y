﻿using Microsoft.AspNetCore.Mvc;

namespace Project_SLAY.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

