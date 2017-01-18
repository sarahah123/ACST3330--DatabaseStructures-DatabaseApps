using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloThereMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello There";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username)
        {
            // Add code to make the program say hello to username

            ViewBag.Message = "Hello " + username;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About HelloThereMVC.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}