using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PathToJannah.Models;

namespace PathToJannah.Views
{
    public class Allah_nameController : Controller
    {
        private PTJEntities db = new PTJEntities();

        // GET: Allah_name
        public ActionResult Index()
        {
            var allah_name = db.Allah_name.Include(a => a.User);
            return View(allah_name.ToList());
        }

        // GET: Allah_name/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allah_name allah_name = db.Allah_name.Find(id);
            if (allah_name == null)
            {
                return HttpNotFound();
            }
            return View(allah_name);
        }

        // GET: Allah_name/Create
        public ActionResult Create()
        {
            ViewBag.A_ID = new SelectList(db.Users, "U_ID", "Name");
            return View();
        }

        // POST: Allah_name/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "A_ID,Name,Meaning")] Allah_name allah_name)
        {
            if (ModelState.IsValid)
            {
                db.Allah_name.Add(allah_name);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.A_ID = new SelectList(db.Users, "U_ID", "Name", allah_name.A_ID);
            return View(allah_name);
        }

        // GET: Allah_name/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allah_name allah_name = db.Allah_name.Find(id);
            if (allah_name == null)
            {
                return HttpNotFound();
            }
            ViewBag.A_ID = new SelectList(db.Users, "U_ID", "Name", allah_name.A_ID);
            return View(allah_name);
        }

        // POST: Allah_name/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "A_ID,Name,Meaning")] Allah_name allah_name)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allah_name).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.A_ID = new SelectList(db.Users, "U_ID", "Name", allah_name.A_ID);
            return View(allah_name);
        }

        // GET: Allah_name/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allah_name allah_name = db.Allah_name.Find(id);
            if (allah_name == null)
            {
                return HttpNotFound();
            }
            return View(allah_name);
        }

        // POST: Allah_name/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Allah_name allah_name = db.Allah_name.Find(id);
            db.Allah_name.Remove(allah_name);
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
