using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BMKT_Enterprises.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Podcasts()
        {
            return View();
        }
        public IActionResult Consulting()
        {
            return View();
        }
        public IActionResult Others()
        {
            return View();
        }

        public IActionResult Products()
        {
            return View();
        }

        public IActionResult FinanceApp()
        {
            return View();
        }

        public IActionResult SportApp()
        {
            return View();
        }
    }
}