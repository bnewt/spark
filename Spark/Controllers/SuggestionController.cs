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
    public class SuggestionController : Controller
    {
        private SparkEntities db = new SparkEntities();

        //
        // GET: /Suggestion/

        public ActionResult Index()
        {
            return View(db.Suggestions.ToList());
        }

        //
        // GET: /Suggestion/Details/5

        public ActionResult Details(int id = 0)
        {
            Suggestion suggestion = db.Suggestions.Find(id);
            if (suggestion == null)
            {
                return HttpNotFound();
            }
            return View(suggestion);
        }

        //
        // GET: /Suggestion/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Suggestion/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Suggestion suggestion)
        {
            if (ModelState.IsValid)
            {
                db.Suggestions.Add(suggestion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(suggestion);
        }

        //
        // GET: /Suggestion/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Suggestion suggestion = db.Suggestions.Find(id);
            if (suggestion == null)
            {
                return HttpNotFound();
            }
            return View(suggestion);
        }

        //
        // POST: /Suggestion/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Suggestion suggestion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(suggestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(suggestion);
        }

        //
        // GET: /Suggestion/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Suggestion suggestion = db.Suggestions.Find(id);
            if (suggestion == null)
            {
                return HttpNotFound();
            }
            return View(suggestion);
        }

        //
        // POST: /Suggestion/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Suggestion suggestion = db.Suggestions.Find(id);
            db.Suggestions.Remove(suggestion);
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