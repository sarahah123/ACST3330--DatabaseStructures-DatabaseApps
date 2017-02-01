using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using input.Models;

namespace input.Controllers
{
    public class HomeController : Controller
    {
        public static List<Entery> entries = new List<Entery>();
        public static int uniqueID = 1;

        public ActionResult List()
        {
            ViewBag.Message = "Here's the list of the entries:";
            return View(Entery);
        }

        public ActionResult Details(int id)
        {
            ViewBag.Message = "Details of this Entry:";
            Entery entry = null;
            foreach (Entery e in entries)
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
            return View();
        }

        [HttpPost]
        public ActionResult Create(Entery entry)
        {
            ViewBag.Message = "Fill in the details for this entry:";

            if (!ModelState.IsValid)
            {
                return View("Create", entry);
            }
            entry.ID = uniqueID++;
            entries.Add(entry);
            return RedirectToAction("List");
        }

        public ActionResult Edit(int ID)
        {
            Entery theEntry = null;

            ViewBag.Message = "Edit the following Entry�s Information:";
            foreach (Entery e in entries)
            {
                if (d.ID == ID)
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
        public ActionResult Edit(Entery entry)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "There was an editing error:";
                return View("Edit", entry);
            }
            foreach (Entery e in entries)
            {
                if (e.ID == entry.ID)
                {
                    e.Name = entry.Name;
                    e.Phone = entry.Phone;
                    e.Email = entry.Email;
                    break;
                }
            }
            return RedirectToAction("List");
        }


        public ActionResult Delete(int ID)
        {
            Entery theEntry = null;

            ViewBag.Message = "Delete the following Entry's Information:";
            foreach (Entery e in entries)
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
        public ActionResult Delete(Entery entry)
        {
            if (entry == null)
                return RedirectToAction("Error");

            foreach (Entery e in entries)
            {
                if (e.ID == entry.ID)
                {
                    entries.Remove(e);
                    break;
                }
            }
            return RedirectToAction("List");
        }

    }
}