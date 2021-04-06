using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BMKTEnterprises.Controllers
{
    public class KemayoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}