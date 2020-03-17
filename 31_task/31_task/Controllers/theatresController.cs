using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _31_task;

namespace _31_task.Controllers
{
    public class theatresController : Controller
    {
        private cakeEntities db = new cakeEntities();

        // GET: theatres
        public ActionResult Index()
        {
            var theatres = db.theatres.Include(t => t.movie);
            return View(theatres.ToList());
        }

        // GET: theatres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            theatre theatre = db.theatres.Find(id);
            if (theatre == null)
            {
                return HttpNotFound();
            }
            return View(theatre);
        }

        // GET: theatres/Create
        public ActionResult Create()
        {
            ViewBag.movieMv_Id = new SelectList(db.movies, "Mv_Id", "Mv_Name");
            return View();
        }

        // POST: theatres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Th_Id,Th_name,Th_loc,dist,movieMv_Id")] theatre theatre)
        {
            if (ModelState.IsValid)
            {
                db.theatres.Add(theatre);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.movieMv_Id = new SelectList(db.movies, "Mv_Id", "Mv_Name", theatre.movieMv_Id);
            return View(theatre);
        }

        // GET: theatres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            theatre theatre = db.theatres.Find(id);
            if (theatre == null)
            {
                return HttpNotFound();
            }
            ViewBag.movieMv_Id = new SelectList(db.movies, "Mv_Id", "Mv_Name", theatre.movieMv_Id);
            return View(theatre);
        }

        // POST: theatres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Th_Id,Th_name,Th_loc,dist,movieMv_Id")] theatre theatre)
        {
            if (ModelState.IsValid)
            {
                db.Entry(theatre).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.movieMv_Id = new SelectList(db.movies, "Mv_Id", "Mv_Name", theatre.movieMv_Id);
            return View(theatre);
        }

        // GET: theatres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            theatre theatre = db.theatres.Find(id);
            if (theatre == null)
            {
                return HttpNotFound();
            }
            return View(theatre);
        }

        // POST: theatres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            theatre theatre = db.theatres.Find(id);
            db.theatres.Remove(theatre);
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
