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

        public ActionResult Index()
        {
            ViewBag.Message = "The Exams and Averages: ";
            
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

        //New Code, sample code 2

        static List<TestEntry> testEntryList = new List<TestEntry>();
        public static int uniqueID = 1;

        public ActionResult List()
        {
            ViewBag.Message = "Here's the list of the Exams:";
            return View(testEntryList);
        }

        public ActionResult Details(int id)
        {
            ViewBag.Message = "Details of this Exam:";
            TestEntry entry = null;
            foreach (TestEntry e in testEntryList)
            {
                if (id == e.ID)
                {
                    entry = e;
                    break;
                }
            }
            return View(entry);
        }

        public ActionResult Create()
        {
            ViewBag.Message = "Fill in the name of the Exam:";

            return View();
        }

        [HttpPost]
        public ActionResult Create(TestEntry entry)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", entry);
            }
            entry.ID = uniqueID++;
            testEntryList.Add(new Models.TestEntry(entry.name, uniqueID++));
            return RedirectToAction("List");
        }

        public ActionResult Edit(int ID)
        {
            TestEntry theEntry = null;
            
            foreach (TestEntry e in testEntryList)
            {
                if (e.ID == ID)
                {
                    theEntry = new TestEntry(e.name, ID);
                    break;
                }
            }

            

            if (theEntry == null)
                return RedirectToAction("Error");
            else
            {
                ViewBag.Message = "Add Score to " + theEntry.name;
                return View(theEntry);
            }
        }

        [HttpPost]
        public ActionResult Edit(TestEntry entry)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "There was an editing error:";
                return View("Edit", entry);
            }
            foreach (TestEntry e in testEntryList)
            {
                if (e.ID == entry.ID)
                {
                    e.sum += entry.sum;
                    e.amount++;
                    break;
                }
            }
            return RedirectToAction("List");
        }


        public ActionResult Delete(int ID)
        {
            TestEntry theEntry = null;

            ViewBag.Message = "Delete the following Exam:";
            foreach (TestEntry e in testEntryList)
            {
                if (e.ID == ID)
                {
                    theEntry = e;
                    break;
                }
            }
            if (theEntry == null)
                return RedirectToAction("Error");
            else
                return View(theEntry);
        }

        [HttpPost]
        public ActionResult Delete(TestEntry entry)
        {
            if (entry == null)
                return RedirectToAction("Error");

            foreach (TestEntry e in testEntryList)
            {
                if (e.ID == entry.ID)
                {
                    testEntryList.Remove(e);
                    break;
                }
            }
            return RedirectToAction("List");
        }
    }
}