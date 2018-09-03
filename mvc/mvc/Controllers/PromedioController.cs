using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.service;
using mvc.Models;
using System.Data.Entity;

namespace mvc.Controllers
{
    public class PromedioController : Controller
    {
        private Promedio db = new Promedio();
        // GET: Promedio
        public ActionResult Index()
        {
            return View();
        }

        // GET: Promedio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Promedio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Promedio/Create
        [HttpPost]
        public ActionResult Create(Promedio promedio)
        {
            try
            {


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Promedio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Promedio/Edit/5
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

        // GET: Promedio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Promedio/Delete/5
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
