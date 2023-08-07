using HealthCareProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareProject.Controllers
{
    public class HospitalController : Controller
    {    
        private HealthCareContext db = new HealthCareContext();

        public IActionResult Index()
        {
            ViewBag.hospital = db.Hospital.ToList();

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Search(string hospsearch)
        {
            ViewData["gethospdetails"] = hospsearch;
            var hospquery = from x in db.Hospital select x;
            if (!String.IsNullOrEmpty(hospsearch))
            {
                hospquery = hospquery.Where(x => x.StreetAddress.Contains(hospsearch) || x.HospitalName.Contains(hospsearch) ||
                x.City.Contains(hospsearch) || x.State.Contains(hospsearch) || x.City.Contains(hospsearch) || x.Country.Contains(hospsearch));
            }
            return View(await hospquery.AsNoTracking().ToListAsync());
        }
       
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Hospital hospital)
        {
            db.Hospital.Add(hospital);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Hospital hospital = db.Hospital.Find(id);
            db.Hospital.Remove(hospital);
            db.SaveChanges();
            return RedirectToAction("Index", new { id = 0 });
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Hospital.Find(id);
            return View(model);

        }

        public ActionResult Edit(Hospital hospital)
        {
            db.Entry(hospital).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
