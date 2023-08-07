using HealthCareProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthCareProject.Controllers
{
    public class HospitalServiceController : Controller
    {

        HealthCareContext db = new HealthCareContext();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login([Bind] Ad_login ad)
        {
            int res = db.LoginCheck(ad);
            if (res == 1)
            {               
                return RedirectToAction("Index");
            }
            else
            {                
                return RedirectToAction("Error");
            }            
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
