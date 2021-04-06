using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMKT_Enterprises.Models;
using Microsoft.AspNetCore.Mvc;

namespace BMKT_Enterprises.Controllers
{
    public class NavigationController : Controller
    {
        public IActionResult TopNav()
        {
            var nav = new Navbar();
            return PartialView("_topNav", nav.NavbarTop());
            return View();
        }
    }
}