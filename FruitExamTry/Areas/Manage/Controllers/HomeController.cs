﻿using Microsoft.AspNetCore.Mvc;

namespace FruitExamTry.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
