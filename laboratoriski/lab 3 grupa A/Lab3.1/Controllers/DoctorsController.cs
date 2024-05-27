using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab3._1.Models;

namespace Lab3._1.Controllers
{
    public class DoctorsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Doctors
        public ActionResult Index()
        {
            return View(db.Doctors.ToList());
        }

        // GET: Doctors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // GET: Doctors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Doctors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Doctors.Add(doctor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctor);
        }

        // GET: Doctors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: Doctors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctor);
        }

        // GET: Doctors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: Doctors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doctor doctor = db.Doctors.Find(id);
            db.Doctors.Remove(doctor);
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
        public ActionResult NewPatient(int id)
        {
            PatientToDoctor model = new PatientToDoctor();
            model.DoctorId = id;
            model.Doctor = db.Doctors.Find(id) as Doctor;
            model.Patients = db.Patients.ToList();
            db.SaveChanges();
            return View(model);
        }
        [HttpPost]
        public ActionResult InsertNewPatient(PatientToDoctor model) {
            Doctor doctor = db.Doctors.Find(model.DoctorId);
            Patient patient = db.Patients.Find(model.SelectedPatientId);
            doctor.Patients.Add(patient);
            db.SaveChanges();
            return RedirectToAction("Details", new {id = model.DoctorId});
        }

        public ActionResult InsertHospital(int id)
        {
            HospitalToDoctor model = new HospitalToDoctor();
            model.DoctorId = id;
            model.Doctor = db.Doctors.Find(id) as Doctor;
            model.Hospitals = db.Hospitals.ToList();
            db.SaveChanges();
            return View(model);
        }
        [HttpPost]
        public ActionResult InsertNewHospital(HospitalToDoctor model)
        {
            Doctor doctor = db.Doctors.Find(model.DoctorId);
            Hospital hospital = db.Hospitals.Find(model.SelectedHospitalId);
            doctor.Hospital = hospital;
            db.SaveChanges();
            //return View("Index", "Doctors");
            return RedirectToAction("Details", new { id = model.DoctorId });
        }
    }
}
