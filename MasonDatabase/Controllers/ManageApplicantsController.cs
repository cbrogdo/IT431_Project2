using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MasonDatabase.Models;

namespace MasonDatabase.Controllers
{
    public class ManageApplicantsController : Controller
    {
        private ApplicationsContext db = new ApplicationsContext();

        // GET: ManageApplicants
        public ActionResult Index(string search)
        {
            var applications = db.Applications.Include(a => a.Semester);
            if (!String.IsNullOrEmpty(search))
            {
                applications = applications.Where(p => p.SSN.Contains(search) || p.LastName.Contains(search));

            }
            return View(applications.ToList());
        }

        // GET: ManageApplicants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // GET: ManageApplicants/Create
        /* public ActionResult Create()
        {
            
            ViewBag.SemesterID = new SelectList(db.Semesters, "ID", "EnrollSem");
            return View();
        }

        // POST: ManageApplicants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       public ActionResult Create([Bind(Include = "ID,FirstName,MiddleName,LastName,SSN,EmailAddress,HomePhone,CellPhone,Street,City,State,ZipCode,DOB,Gender,SchoolName,SchoolCity,GradDate,GPA,SATMath,SATVerbal,MajorID,SemesterID,EnrollYear,EnrollDecision,SubmitDate")] Application application)
        {
            if (ModelState.IsValid)
            {
                db.Applications.Add(application);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            
            ViewBag.SemesterID = new SelectList(db.Semesters, "ID", "EnrollSem", application.SemesterID);
            return View(application);
        }*/

        // GET: ManageApplicants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            
            ViewBag.SemesterID = new SelectList(db.Semesters, "ID", "EnrollSem", application.SemesterID);
            return View(application);
        }

        // POST: ManageApplicants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID, FirstName, MiddleName, LastName, SSN, EmailAddress, HomePhone, CellPhone, Street, City, State, ZipCode, DOB, Gender, SchoolName, SchoolCity, GradDate, GPA, SATMath, SATVerbal, MajorID, SemesterID, EnrollYear, EnrollDecision, SubmitDate")] Application application)
        {
            if (ModelState.IsValid)
            {
                db.Entry(application).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            ViewBag.SemesterID = new SelectList(db.Semesters, "ID", "EnrollSem", application.SemesterID);
            return View(application);
        }

        // GET: ManageApplicants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Application application = db.Applications.Find(id);
            if (application == null)
            {
                return HttpNotFound();
            }
            return View(application);
        }

        // POST: ManageApplicants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Application application = db.Applications.Find(id);
            db.Applications.Remove(application);
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
