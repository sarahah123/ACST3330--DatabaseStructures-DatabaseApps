using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*
 * Course:          ACST 3540
 * Section:         01
 * Name:            Sarah Hansberry
 * Professor:       Shaw
 * Assignment #:    Lab3
 */

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
        public ActionResult Index(String username, FormCollection form)
        {
            // Add code to make the program say hello to username

            ViewBag.Message = "Hello " + username;
            ViewBag.Message += "<br />You are " + form[1] + " years old";
            ViewBag.Message += "<br />About you: " + form[2];

            Session["About me"] = form[2];

            return View();
        }
         
        public ActionResult About(String username, FormCollection form)
        {
            ViewBag.Message = "About me: Hi, my name is Sarah.";
            ViewBag.Message += "<font color=\"red\">";
            ViewBag.Message += "<br />About you: " + Session["About me"];
            ViewBag.Message += "</font>";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}