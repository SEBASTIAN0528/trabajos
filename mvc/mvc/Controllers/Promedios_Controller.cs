using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using mvc.Models;

namespace mvc.Controllers
{
    public class Promedios_Controller : Controller
    {
        private promedioDBcontext db = new promedioDBcontext();

        // GET: Promedios_
        public ActionResult Index()
        {
            return View(db.Promedios.ToList());
        }

        // GET: Promedios_/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promedio promedio = db.Promedios.Find(id);
            if (promedio == null)
            {
                return HttpNotFound();
            }
            return View(promedio);
        }

        // GET: Promedios_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Promedios_/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Nombre,Apellido,Nota,materia")] Promedio promedio)
        {
            if (ModelState.IsValid)
            {
                db.Promedios.Add(promedio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(promedio);
        }

        // GET: Promedios_/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promedio promedio = db.Promedios.Find(id);
            if (promedio == null)
            {
                return HttpNotFound();
            }
            return View(promedio);
        }

        // POST: Promedios_/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Nombre,Apellido,Nota,materia")] Promedio promedio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(promedio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(promedio);
        }

        // GET: Promedios_/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Promedio promedio = db.Promedios.Find(id);
            if (promedio == null)
            {
                return HttpNotFound();
            }
            return View(promedio);
        }

        // POST: Promedios_/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Promedio promedio = db.Promedios.Find(id);
            db.Promedios.Remove(promedio);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
