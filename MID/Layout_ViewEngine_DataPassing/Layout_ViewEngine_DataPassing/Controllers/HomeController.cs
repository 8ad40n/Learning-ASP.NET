using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Layout_ViewEngine_DataPassing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            
            ViewBag.Message = "Your contact page.";

            // Data pass:
            //TempData

            //METHOD 1 
            //Action -> another application
            //return Redirect("https://www.aiub.edu/");

            //METHOD 2
            //Redirect to own application's same controller action
            //return RedirectToAction("Index");

            //METHOD 3
            //Redirect to own application's different controller action
            //return RedirectToAction("Index", "Controller name");

            //METHOD 4
            TempData["msg"] = " Redirected from contact";
            return View();
        }


        //Data Passing from action to view:
        //    1. ViewBag -> Dynamic object
        //    2. ViewData -> Dictionary properties
        //    3. TempData -> Access till next req
        //    4. Model Binding
        public ActionResult MyPage()
        {
            ViewBag.Message = "Your page.";

            // Data pass:
            ViewBag.name = "Badhon Nath Joy";
            ViewData["ID"] = "21-45390-3";



            return View();
        }
    }
}