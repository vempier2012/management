using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebDashboard.Models;

namespace WebDashboard.Controllers
{
    public class DonVisController : Controller
    {
        private SchoolModel db = new SchoolModel();

        // GET: DonVis
        public ActionResult Index()
        {
            return View(db.DonVis.ToList());
        }

        // GET: DonVis/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonVi donVi = db.DonVis.Find(id);
            if (donVi == null)
            {
                return HttpNotFound();
            }
            return View(donVi);
        }

        // GET: DonVis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonVis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "madonvi,tendonvi,email,nguoitao,ngaytao,nguoicapnhat,ngaycapnhat,solancapnhat,trangthai")] DonVi donVi)
        {
            if (ModelState.IsValid)
            {
                db.DonVis.Add(donVi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(donVi);
        }

        // GET: DonVis/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonVi donVi = db.DonVis.Find(id);
            if (donVi == null)
            {
                return HttpNotFound();
            }
            return View(donVi);
        }

        // POST: DonVis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "madonvi,tendonvi,email,nguoitao,ngaytao,nguoicapnhat,ngaycapnhat,solancapnhat,trangthai")] DonVi donVi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donVi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(donVi);
        }

        // GET: DonVis/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonVi donVi = db.DonVis.Find(id);
            if (donVi == null)
            {
                return HttpNotFound();
            }
            return View(donVi);
        }

        // POST: DonVis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            DonVi donVi = db.DonVis.Find(id);
            db.DonVis.Remove(donVi);
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
