﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    public class HomeController
    {
        public IActionResult Index()
        {
            return new ContentResult { Content = "Hello ASP.NET Core MVC" };
            //return "Hello ASP.NET Core MVC";
        }
    }
}