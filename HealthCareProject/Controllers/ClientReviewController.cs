using HealthCareProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareProject.Controllers
{
    public class ClientReviewController : Controller
    {
        private HealthCareContext db = new HealthCareContext();
        public IActionResult Index()
        {
            ViewBag.clientreview = db.ClientReview.ToList();
            ViewBag.client = db.Client.ToList();
            ViewBag.doctor = db.Doctor.ToList();
            ViewBag.hospital = db.Hospital.ToList();
            ViewBag.HospitalId = new SelectList(db.Hospital, "HospitalId");
            return View();
        }
        public IActionResult IndexClient()
        {
            ViewBag.clientreview = db.ClientReview.ToList();
            ViewBag.client = db.Client.ToList();
            ViewBag.doctor = db.Doctor.ToList();
            ViewBag.hospital = db.Hospital.ToList();
            ViewBag.HospitalId = new SelectList(db.Hospital, "HospitalId");
            return View();
        }

        public IActionResult Register()
        {
            List<Hospital> HospitalIdList = new List<Hospital>();
            HospitalIdList = (from Hospital in db.Hospital select Hospital).ToList();
            HospitalIdList.Insert(0, new Hospital { HospitalId = 0, HospitalName = "Select" });
            ViewBag.ListofHospitalId = HospitalIdList;

            List<Client> ClientIdList = new List<Client>();
            ClientIdList = (from Client in db.Client select Client).ToList();
            ClientIdList.Insert(0, new Client { ClientId = 0, FirstName = "Select" });
            ViewBag.ListofClientId = ClientIdList;

            List<Doctor> DoctorIdList = new List<Doctor>();
            DoctorIdList = (from Doctor in db.Doctor select Doctor).ToList();
            DoctorIdList.Insert(0, new Doctor { DoctorId = 0, FirstName = "Select" });
            ViewBag.ListofDoctorId = DoctorIdList;

            return View();
        }

        [HttpPost]
        public IActionResult Register(ClientReview clientreview)
        {
            db.ClientReview.Add(clientreview);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult RegisterClient()
        {
            List<Hospital> HospitalIdList = new List<Hospital>();
            HospitalIdList = (from Hospital in db.Hospital select Hospital).ToList();
            HospitalIdList.Insert(0, new Hospital { HospitalId = 0, HospitalName = "Select" });
            ViewBag.ListofHospitalId = HospitalIdList;

            List<Client> ClientIdList = new List<Client>();
            ClientIdList = (from Client in db.Client select Client).ToList();
            ClientIdList.Insert(0, new Client { ClientId = 0, FirstName = "Select" });
            ViewBag.ListofClientId = ClientIdList;

            List<Doctor> DoctorIdList = new List<Doctor>();
            DoctorIdList = (from Doctor in db.Doctor select Doctor).ToList();
            DoctorIdList.Insert(0, new Doctor { DoctorId = 0, FirstName = "Select" });
            ViewBag.ListofDoctorId = DoctorIdList;

            return View();
        }

        [HttpPost]
        public IActionResult RegisterClient(ClientReview clientreview)
        {
            db.ClientReview.Add(clientreview);
            db.SaveChanges();
            return RedirectToAction("IndexClient");
        }


        public IActionResult Edit(int id)
        {
            List<Client> ClientIdList = new List<Client>();
            ClientIdList = (from Client in db.Client select Client).ToList();
            ClientIdList.Insert(0, new Client { ClientId = 0, FirstName = "Select" });
            ViewBag.ListofClientId = ClientIdList;

            List<Doctor> DoctorIdList = new List<Doctor>();
            DoctorIdList = (from Doctor in db.Doctor select Doctor).ToList();
            DoctorIdList.Insert(0, new Doctor { DoctorId = 0, FirstName = "Select" });
            ViewBag.ListofDoctorId = DoctorIdList;

            var model = db.ClientReview.Find(id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(ClientReview clientreview)
        {
            db.Entry(clientreview).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult EditClient(int id)
        {
            List<Client> ClientIdList = new List<Client>();
            ClientIdList = (from Client in db.Client select Client).ToList();
            ClientIdList.Insert(0, new Client { ClientId = 0, FirstName = "Select" });
            ViewBag.ListofClientId = ClientIdList;

            List<Doctor> DoctorIdList = new List<Doctor>();
            DoctorIdList = (from Doctor in db.Doctor select Doctor).ToList();
            DoctorIdList.Insert(0, new Doctor { DoctorId = 0, FirstName = "Select" });
            ViewBag.ListofDoctorId = DoctorIdList;

            var model = db.ClientReview.Find(id);

            return View(model);
        }

        [HttpPost]
        public IActionResult EditClient(ClientReview clientreview)
        {
            db.Entry(clientreview).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("IndexClient");
        }

        public ActionResult Delete(int id)
        {
            ClientReview clientreview = db.ClientReview.Find(id);
            db.ClientReview.Remove(clientreview);
            db.SaveChanges();
            return RedirectToAction("Index", new { id = 0 });
        }

        public ActionResult DeleteClient(int id)
        {
            ClientReview clientreview = db.ClientReview.Find(id);
            db.ClientReview.Remove(clientreview);
            db.SaveChanges();
            return RedirectToAction("IndexClient", new { id = 0 });
        }
    }
}
