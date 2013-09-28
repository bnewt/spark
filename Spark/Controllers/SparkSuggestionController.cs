using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Spark.Models;

namespace Spark.Controllers
{
    public class SparkSuggestionController : Controller
    {
        private SparkEntities db = new SparkEntities();

        //
        // GET: /SparkSuggestion/

        public ActionResult Index()
        {
            return View(db.SparkSuggestions.ToList());
        }

        //
        // GET: /SparkSuggestion/Details/5

        public ActionResult Details(int id = 0)
        {
            SparkSuggestion sparksuggestion = db.SparkSuggestions.Find(id);
            if (sparksuggestion == null)
            {
                return HttpNotFound();
            }
            return View(sparksuggestion);
        }

        //
        // GET: /SparkSuggestion/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SparkSuggestion/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SparkSuggestion sparksuggestion)
        {
            if (ModelState.IsValid)
            {
                db.SparkSuggestions.Add(sparksuggestion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sparksuggestion);
        }

        //
        // GET: /SparkSuggestion/Edit/5

        public ActionResult Edit(int id = 0)
        {
            SparkSuggestion sparksuggestion = db.SparkSuggestions.Find(id);
            if (sparksuggestion == null)
            {
                return HttpNotFound();
            }
            return View(sparksuggestion);
        }

        //
        // POST: /SparkSuggestion/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SparkSuggestion sparksuggestion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sparksuggestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sparksuggestion);
        }

        //
        // GET: /SparkSuggestion/Delete/5

        public ActionResult Delete(int id = 0)
        {
            SparkSuggestion sparksuggestion = db.SparkSuggestions.Find(id);
            if (sparksuggestion == null)
            {
                return HttpNotFound();
            }
            return View(sparksuggestion);
        }

        //
        // POST: /SparkSuggestion/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SparkSuggestion sparksuggestion = db.SparkSuggestions.Find(id);
            db.SparkSuggestions.Remove(sparksuggestion);
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