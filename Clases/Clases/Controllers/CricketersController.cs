using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Clases.Controllers
{
    public class CricketersController : Controller
    {
        // GET: Cricketers
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cricketers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cricketers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cricketers/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cricketers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cricketers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cricketers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cricketers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
