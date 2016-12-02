using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VMS.DAL.DataContext;
using VMS.DAL.Repositories;

using VMS.Model;

namespace VMS.Controllers
{
    public class VolunteersController : Controller
    {
        private VMSDataContext db = new VMSDataContext();

        // GET: Volunteers
        public ActionResult Index()
        {
            VolunteerRepository vr = new VolunteerRepository(new VMSDataContext());
            return View(vr.GetAll());
        }

        // GET: Volunteers/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Volunteer volunteer = db.Volunteers.Find(id);
            if (volunteer == null)
            {
                return HttpNotFound();
            }
            return View(volunteer);
        }

        // GET: Volunteers/Create
        public ActionResult Create()
        {
            ViewBag.RegionID = new SelectList(db.Regions, "RegionID", "Name");
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "Name");
            return View();
        }

        // POST: Volunteers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "VolunteerID,FirstName,LastName,DateOfBirth,MobileNo,PhoneNo,Email,Password,ImagePath,DateRegister,RegionID,StatusID,DateInsert,DateUpdate")] Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                db.Volunteers.Add(volunteer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RegionID = new SelectList(db.Regions, "RegionID", "Name", volunteer.RegionID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "Name", volunteer.StatusID);
            return View(volunteer);
        }

        // GET: Volunteers/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Volunteer volunteer = db.Volunteers.Find(id);
            if (volunteer == null)
            {
                return HttpNotFound();
            }
            ViewBag.RegionID = new SelectList(db.Regions, "RegionID", "Name", volunteer.RegionID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "Name", volunteer.StatusID);
            return View(volunteer);
        }

        // POST: Volunteers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "VolunteerID,FirstName,LastName,DateOfBirth,MobileNo,PhoneNo,Email,Password,ImagePath,DateRegister,RegionID,StatusID,DateInsert,DateUpdate")] Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(volunteer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RegionID = new SelectList(db.Regions, "RegionID", "Name", volunteer.RegionID);
            ViewBag.StatusID = new SelectList(db.Status, "StatusID", "Name", volunteer.StatusID);
            return View(volunteer);
        }

        // GET: Volunteers/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Volunteer volunteer = db.Volunteers.Find(id);
            if (volunteer == null)
            {
                return HttpNotFound();
            }
            return View(volunteer);
        }

        // POST: Volunteers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Volunteer volunteer = db.Volunteers.Find(id);
            db.Volunteers.Remove(volunteer);
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
