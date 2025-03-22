using FormValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormValidation.Controllers
{
    public class MyController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Student());
        }
        [HttpPost]
        public ActionResult Index(Student s)
        {
            if (ModelState.IsValid)
            {
                return Content("Form Submitted Successfully");
            }
            return View(s);
        }
    }
}