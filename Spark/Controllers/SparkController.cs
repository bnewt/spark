using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Spark.Models;
using SparkModel = Spark.Models.Spark;

namespace Spark.Controllers
{
    public class SparkController : Controller
    {
        private SparkEntities db = new SparkEntities();

        //
        // GET: /Spark/

        public ActionResult Index()
        {
            return View(db.Sparks.ToList());
        }

        //
        // GET: /Spark/Details/5

        public ActionResult Details(int id = 0)
        {
            SparkModel spark = db.Sparks.Find(id);
            if (spark == null)
            {
                return HttpNotFound();
            }
            return View(spark);
        }

        //
        // GET: /Spark/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Spark/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SparkModel spark)
        {
            if (ModelState.IsValid)
            {
                db.Sparks.Add(spark);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(spark);
        }

        //
        // GET: /Spark/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SparkModel spark = db.Sparks.Find(id);
            if (spark == null)
            {
                return HttpNotFound();
            }
            return View(spark);
        }

        //
        // POST: /Spark/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SparkModel spark)
        {
            if (ModelState.IsValid)
            {
                db.Entry(spark).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(spark);
        }

        //
        // GET: /Spark/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SparkModel spark = db.Sparks.Find(id);
            if (spark == null)
            {
                return HttpNotFound();
            }
            return View(spark);
        }

        //
        // POST: /Spark/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SparkModel spark = db.Sparks.Find(id);
            db.Sparks.Remove(spark);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}