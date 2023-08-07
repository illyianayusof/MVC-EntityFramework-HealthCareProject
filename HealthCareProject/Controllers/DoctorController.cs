using HealthCareProject.Models;
using Korzh.EasyQuery.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace HealthCareProject.Controllers
{
    public class DoctorController : Controller
    {
        private HealthCareContext db = new HealthCareContext();
        public IActionResult Index()
        {
            ViewBag.doctor = db.Doctor.ToList();
            ViewBag.hospital = db.Hospital.ToList();
            ViewBag.HospitalId = new SelectList(db.Hospital, "HospitalId");
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Search(string docsearch)
        {
            ViewData["getdoctordetails"] = docsearch;
            var docquery = from x in db.Doctor select x;
            if (!String.IsNullOrEmpty(docsearch))
            {
                docquery = docquery.Where(x => x.FirstName.Contains(docsearch) || x.LastName.Contains(docsearch) ||
                x.Specialization.Contains(docsearch) || x.PracticingForm.Contains(docsearch));
            }
            return View(await docquery.AsNoTracking().ToListAsync());
        }

        public IActionResult Register()
        {
            List<Hospital> HospitalIdList = new List<Hospital>();

            HospitalIdList = (from Hospital in db.Hospital select Hospital).ToList();

            HospitalIdList.Insert(0, new Hospital { HospitalId = 0, HospitalName = "Select" });
            ViewBag.ListofHospitalId = HospitalIdList;
            return View();
        }

        [HttpPost]
        public IActionResult Register(Doctor doctor)
        {       
            db.Doctor.Add(doctor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            List<Hospital> HospitalIdList = new List<Hospital>();

            HospitalIdList = (from Hospital in db.Hospital select Hospital).ToList();

            HospitalIdList.Insert(0, new Hospital { HospitalId = 0, HospitalName = "Select" });
            ViewBag.ListofHospitalId = HospitalIdList;

            var model = db.Doctor.Find(id);
            return View(model);
        }

        public ActionResult Edit(Doctor doctor)
        {           
            db.Entry(doctor).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Doctor doctor = db.Doctor.Find(id);
            db.Doctor.Remove(doctor);
            db.SaveChanges();
            return RedirectToAction("Index", new { id = 0 });
        }
    }
}
