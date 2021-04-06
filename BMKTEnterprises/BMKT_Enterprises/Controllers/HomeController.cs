using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BMKT_Enterprises.Models;
using System.Net.Mail;
using System.Net;

namespace BMKT_Enterprises.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult submit(ContactModel contactModel, string button)
        {

            try
            {
                if (contactModel.Name == null)
                {

                }
                if (contactModel.Email == null)
                {

                }
                if (contactModel.Message == null)
                {

                }
                if (button == "submit")
                {
                    if (ModelState.IsValid)
                    {
                        var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                        var message = new MailMessage();
                        message.To.Add(new MailAddress("tkemayo@gmail.com"));
                        message.From = new MailAddress(contactModel.Email);
                        message.Subject = contactModel.Subject;
                        message.Body = String.Format(body, contactModel.Name, contactModel.Email, contactModel.Message);
                        message.IsBodyHtml = true;
                        using (var smtp = new SmtpClient())
                        {
                            var credential = new NetworkCredential
                            {
                                UserName = "tkemayo@gmail.com",
                                Password = "piTou1990"
                            };
                            smtp.Credentials = credential;
                            smtp.Host = "smtp.gmail.com";
                            smtp.Port = 587;
                            smtp.EnableSsl = true;

                            smtp.SendMailAsync(message);
                        }
                        TempData["submitval"] = "Your message was sent successfully.";
                    }
                    else
                    {
                        TempData["submitval"] = "Your message was not sent";
                    }
                    
                }
                else
                {
                    TempData["submitval"] = "";
                }

            }
            catch (Exception e)
            {

            }


            return RedirectToAction("Contact", contactModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
