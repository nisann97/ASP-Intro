﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace HW_intro.Controllers
{
    public class AboutController : Controller
    {
       public IActionResult Index()
        {
            return View();
        }
	}
}

