using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthCareProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Web;
using System.Reflection;

namespace HealthCareProject.Controllers
{
    public class ClientController : Controller
    {       
        private HealthCareContext db = new HealthCareContext();

        public IActionResult Index()
        {
            ViewBag.client = db.Client.ToList();
            return View();
        }

        public IActionResult IndexClient()
        {
            ViewBag.client = db.Client.ToList();
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Client client)
        {
            db.Client.Add(client);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult RegisterClient()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterClient(Client client)
        {
            db.Client.Add(client);
            db.SaveChanges();
            return RedirectToAction(nameof(IndexClient));
        }

        public ActionResult Delete(int id)
        {
            Client client = db.Client.Find(id);
            db.Client.Remove(client);
            db.SaveChanges();
            return RedirectToAction("Index", new { id = 0 });
        }

        public ActionResult DeleteClient(int id)
        {
            Client client = db.Client.Find(id);
            db.Client.Remove(client);
            db.SaveChanges();
            return RedirectToAction("IndexClient", new { id = 0 });
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Client.Find(id);
            return View(model);
        }
        public ActionResult Edit(Client client)
        {
            db.Entry(client).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult EditClient(int id)
        {
            var model = db.Client.Find(id);
            return View(model);
        }
        public ActionResult EditClient(Client client)
        {
            db.Entry(client).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("IndexClient");
        }

    }



}

