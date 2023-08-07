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

    public class AppointmentController : Controller
    {
        private HealthCareContext db = new HealthCareContext();
        public IActionResult Index()
        {
            ViewBag.clientreview = db.ClientReview.ToList();
            ViewBag.client = db.Client.ToList();
            ViewBag.doctor = db.Doctor.ToList();
            ViewBag.hospital = db.Hospital.ToList();
            ViewBag.appointment = db.Appointment.ToList();
            ViewBag.HospitalId = new SelectList(db.Hospital, "HospitalId");
            return View();
        }

        public IActionResult IndexClient()
        {
            ViewBag.clientreview = db.ClientReview.ToList();
            ViewBag.client = db.Client.ToList();
            ViewBag.doctor = db.Doctor.ToList();
            ViewBag.hospital = db.Hospital.ToList();
            ViewBag.appointment = db.Appointment.ToList();
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
        public IActionResult Register(Appointment appointment)
        {
            db.Appointment.Add(appointment);
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
        public IActionResult RegisterClient(Appointment appointment)
        {
            db.Appointment.Add(appointment);
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
            var model = db.Appointment.Find(id);

            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Appointment appointment)
        {
            db.Entry(appointment).State = EntityState.Modified;
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
            var model = db.Appointment.Find(id);

            return View(model);
        }

        [HttpPost]
        public IActionResult EditClient(Appointment appointment)
        {
            db.Entry(appointment).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("IndexClient");
        }

        public ActionResult Delete(int id)
        {
            Appointment appointment = db.Appointment.Find(id);
            db.Appointment.Remove(appointment);
            db.SaveChanges();
            return RedirectToAction("Index", new { id = 0 });
        }

        public ActionResult DeleteClient(int id)
        {
            Appointment appointment = db.Appointment.Find(id);
            db.Appointment.Remove(appointment);
            db.SaveChanges();
            return RedirectToAction("IndexClient", new { id = 0 });
        }
    }
}
