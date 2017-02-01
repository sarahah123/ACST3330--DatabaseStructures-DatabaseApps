using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamsAndAverages.Models;

/*
 * Course:          ACST 3330
 * Section:         01
 * Name:            Sarah Hanserry
 * Professor:       Nagappan
 * Assignment #:    Lab 3
 */

namespace ExamsAndAverages.Controllers
{
    public class HomeController : Controller
    {
        static List<String> nameList = new List<String>();
        static List<TestEntry> testEntryList = new List<TestEntry>();

        public ActionResult Index()
        {
            ViewBag.Message = "The Exams and Averages: ";

            ViewBag.NameItems = new SelectList(nameList, "SelectedItem");
            ViewBag.TestEntryItems = new SelectList(testEntryList, "SelectedItem");
            ViewBag.ListSize = 1;

            return View();
        }

        [HttpPost]
        public ActionResult Index(string button, string newName, string score, string NameItems)
        {
            ViewBag.Message = "The Exams and Averages: ";


            if(button == "Add Test" && newName != "")
            {
                nameList.Add(newName);
                testEntryList.Add(new TestEntry(newName));
            }
            if(button == "Add Score" && score != "")
            {
                for(int i =0; i<testEntryList.Count; i++)
                {
                    if (testEntryList[i].name == NameItems)
                    {
                        testEntryList[i].sum += Convert.ToDouble(score);
                        testEntryList[i].amount++;
                    }
                }
            }


            ViewBag.NameItems = new SelectList(nameList, "SelectedItem");
            ViewBag.TestEntryItems = new SelectList(testEntryList, "SelectedItem");
            ViewBag.ListSize = (nameList.Count == 0) ? 1 : nameList.Count;

            ModelState.Clear();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}