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
    public class FlagSController : Controller
    {
        private SparkEntities db = new SparkEntities();

        //
        // GET: /FlagS/

        public ActionResult Index()
        {
            return View(db.Flags.ToList());
        }

        //
        // GET: /FlagS/Details/5

        public ActionResult Details(int id = 0)
        {
            Flag flag = db.Flags.Find(id);
            if (flag == null)
            {
                return HttpNotFound();
            }
            return View(flag);
        }

        //
        // GET: /FlagS/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /FlagS/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Flag flag)
        {
            if (ModelState.IsValid)
            {
                db.Flags.Add(flag);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(flag);
        }

        //
        // GET: /FlagS/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Flag flag = db.Flags.Find(id);
            if (flag == null)
            {
                return HttpNotFound();
            }
            return View(flag);
        }

        //
        // POST: /FlagS/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Flag flag)
        {
            if (ModelState.IsValid)
            {
                db.Entry(flag).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(flag);
        }

        //
        // GET: /FlagS/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Flag flag = db.Flags.Find(id);
            if (flag == null)
            {
                return HttpNotFound();
            }
            return View(flag);
        }

        //
        // POST: /FlagS/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Flag flag = db.Flags.Find(id);
            db.Flags.Remove(flag);
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