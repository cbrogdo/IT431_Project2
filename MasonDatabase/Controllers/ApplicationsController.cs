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
    public class ApplicationsController : Controller
    {
        private ApplicationsContext db = new ApplicationsContext();

        // GET: Applications
        [Authorize]
        public ActionResult Index(string application, string search)
        {
            var applications = db.Applications.Include(a => a.Major);
            //var applications = db.Applications.Include(a => a.Semester);
            applications = applications.Include(c => c.Semester);
            if(!String.IsNullOrEmpty(search))
            {
                applications = applications.Where(p => p.SSN.Contains(search) || p.LastName.Contains(search));

            }
           


            return View(applications.ToList());
        }

        // GET: Applications/Details/5
        [Authorize]
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

        // GET: Applications/Create
        public ActionResult Create()
        {
            ViewBag.MajorID = new SelectList(db.Majors, "ID", "MajorOption");
            ViewBag.SemesterID = new SelectList(db.Semesters, "ID", "EnrollSem");
            return View();
        }

        // POST: Applications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,MiddleName,LastName,SSN,EmailAddress,HomePhone,CellPhone,Street,City,State,ZipCode,DOB,Gender,SchoolName,SchoolCity,GradDate,GPA,SATMath,SATVerbal,MajorID,SemesterID,EnrollYear,SubmitDat,ConcatSAT")] Application application)
        {

            ViewBag.MajorID = new SelectList(db.Majors, "ID", "MajorOption", application.MajorID);
            ViewBag.SemesterID = new SelectList(db.Semesters, "ID", "EnrollSem", application.SemesterID);

            if (ModelState.IsValid)
            {
                
                Application matchingSSN = db.Applications.Where(cm => string.Compare(cm.SSN, application.SSN, true) == 0).FirstOrDefault();

                if (application == null) 
                {
                    return HttpNotFound();
                }

                if (matchingSSN != null)
                {
                    ModelState.AddModelError("SSN", "Social Security Number must be unique.");
                    return View(application);
                }

                if (DateTime.Now.AddYears(-15) < DateTime.Parse(application.DOB.ToString("MM-dd-yyyy"))) 
                {
                    ModelState.AddModelError("DOB", "Date of Birth must be more than 15 years ago.");
                    return View(application);
                }

                if (application.ConcatSAT <= 1000)
                {
                    return RedirectToAction("Rejected", "Home");
                }

                if (application.GPA < 3)
                {
                    return RedirectToAction("Rejected", "Home");
                }

                application.SubmitDate = DateTime.Now;
                
                db.Applications.Add(application);
                db.SaveChanges();
                return RedirectToAction("ApplicationReceived", "Home");
            }

            

            return View(application);
        }

        // GET: Applications/Edit/5
        [Authorize]
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
            ViewBag.MajorID = new SelectList(db.Majors, "ID", "MajorOption", application.MajorID);
            ViewBag.SemesterID = new SelectList(db.Semesters, "ID", "EnrollSem", application.SemesterID);
            return View(application);
        }

        // POST: Applications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "ID,FirstName,MiddleName,LastName,SSN,EmailAddress,HomePhone,CellPhone,Street,City,State,ZipCode,DOB,Gender,SchoolName,SchoolCity,GradDate,GPA,SATMath,SATVerbal,MajorID,SemesterID,EnrollYear, EnrollDecision,SubmitDate")] Application application)
        {

            ViewBag.MajorID = new SelectList(db.Majors, "ID", "MajorOption", application.MajorID);
            ViewBag.SemesterID = new SelectList(db.Semesters, "ID", "EnrollSem", application.SemesterID);

            if (ModelState.IsValid)
            {
                /*
                Application matchingSSN = db.Applications.Where(cm => string.Compare(cm.SSN, application.SSN, true) == 0).FirstOrDefault();

                if (application == null)
                {
                    return HttpNotFound();
                }

                if (matchingSSN != null)
                {
                    ModelState.AddModelError("SSN", "Social Security Number must be unique.");
                    return View(application);
                }
                */
                if (application.ConcatSAT <= 1000)
                {
                    return RedirectToAction("Rejected", "Home");
                }

                if (application.GPA < 3)
                {
                    return RedirectToAction("Rejected", "Home");
                }

                db.Entry(application).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            
            return View(application);
        }

        // GET: Applications/Delete/5
        [Authorize]
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

        // POST: Applications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
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
