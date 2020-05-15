

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;
using System;

namespace MyBlog.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult AboutUs()
        {
            ViewBag.CompanyName = "Yoga Blog";
            ViewBag.CurrentDate = DateTime.Now.ToString();
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
