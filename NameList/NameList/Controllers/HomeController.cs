using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

/*
 * Course:          ACST 3330
 * Section:         01
 * Name:            Sarah Hansberry
 * Professor:       Nagappan
 * Assignment #:    Lab 2
 */

namespace NameList.Controllers
{
    public class HomeController : Controller
    {

        static List<String> nameList = new List<String>();

        public ActionResult Index()
        {
            ViewBag.Message = "The NameList App";
            ViewBag.ListSize = 1;

            ViewBag.NameItems = new SelectList(nameList, "SelectedItem");

            return View();
        }

        [HttpPost]
        public ActionResult Index(string button, string name)
        {
            ViewBag.Message = "The NameList App";


            if (button == "Add" && name != "")
            {
                nameList.Add(name);
            }
            else if (button == "Remove")
            {
                nameList.Remove(name);
            }

            ViewBag.ListSize = (nameList.Count == 0) ? 1 : nameList.Count;

            ViewBag.NameItems = new SelectList(nameList, "SelectedItem");


            ModelState.Clear();
            return View();
            }

        public ActionResult About()
        {
            ViewBag.Message = "About NameList.";
            ViewBag.Message2 = "Written by Sarah.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}