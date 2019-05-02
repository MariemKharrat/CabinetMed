using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CabinetMed.Models;

namespace CabinetMed.Controllers
{
    public class FamilleMedsController : Controller
    {
        private CabinetMedContext db = new CabinetMedContext();

        // GET: FamilleMeds
        public ActionResult Index()
        {
            return View(db.FamilleMeds.ToList());
        }

        // GET: FamilleMeds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilleMed familleMed = db.FamilleMeds.Find(id);
            if (familleMed == null)
            {
                return HttpNotFound();
            }
            return View(familleMed);
        }

        // GET: FamilleMeds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FamilleMeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Designation")] FamilleMed familleMed)
        {
            if (ModelState.IsValid)
            {
                db.FamilleMeds.Add(familleMed);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(familleMed);
        }

        // GET: FamilleMeds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilleMed familleMed = db.FamilleMeds.Find(id);
            if (familleMed == null)
            {
                return HttpNotFound();
            }
            return View(familleMed);
        }

        // POST: FamilleMeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Designation")] FamilleMed familleMed)
        {
            if (ModelState.IsValid)
            {
                db.Entry(familleMed).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(familleMed);
        }

        // GET: FamilleMeds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FamilleMed familleMed = db.FamilleMeds.Find(id);
            if (familleMed == null)
            {
                return HttpNotFound();
            }
            return View(familleMed);
        }

        // POST: FamilleMeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FamilleMed familleMed = db.FamilleMeds.Find(id);
            db.FamilleMeds.Remove(familleMed);
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
