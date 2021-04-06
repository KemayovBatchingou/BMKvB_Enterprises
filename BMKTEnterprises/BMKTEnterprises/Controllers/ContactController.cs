
using BMKTEnterprises.Models;
using Microsoft.AspNetCore.Mvc;

namespace BMKTEnterprises.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Submit(ContactModel objSubmit)
        {
            ViewBag.Msg = "send message successfully.";
            return View();
        }
    }
}