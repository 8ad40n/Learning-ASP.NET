using IntroEF.EF;
using IntroEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroEF.Controllers
{
    public class MyController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student s)
        {

            UMSEntities db = new UMSEntities();
            var userDetail = new UserDetail
            {
                id = s.id,
                name = s.name,
                dob = s.dob,
                email = s.email
            };
            db.UserDetails.Add(userDetail);
            if (db.SaveChanges() > 0)
            {
                TempData["Msg"] = "User Added";
                return RedirectToAction("Index");
            }
            TempData["Msg"] = "User Not Added";
            return View();
        }
    }
}