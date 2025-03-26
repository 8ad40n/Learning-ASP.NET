using PMS_Task.EF;
using PMS_Task.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS_Task.Controllers
{
    public class ProductController : Controller
    {
        PMSEntities db = new PMSEntities();
        // GET: Product
        public ActionResult Index()
        {
            var data = db.Products.ToList();
            return View(data);
        }
        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Categories = new SelectList(db.Categories, "Id", "Name");
            return View();

        }
        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                var p = new Product
                {
                    Name = product.Name,
                    Price = product.Price,
                    Qty = product.Qty,
                    Cid = product.Cid
                };
                db.Products.Add(p);
                db.SaveChanges();

                return RedirectToAction("Index");
            }

            ViewBag.Categories = new SelectList(db.Categories, "Id", "Name", product.Cid);
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = db.Products.Find(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(ProductModel s)
        {
            var exobj = db.Products.Find(s.Id);
            //db.Entry(exobj).CurrentValues.SetValues(s);
            exobj.Name = s.Name;
            exobj.Price = s.Price;
            exobj.Qty = s.Qty;
            db.SaveChanges();
            TempData["Msg"] = "Product Updated";
            return RedirectToAction("Index");

            //db.Students.Remove(s);
            //db.SaveChanges();
            //Take consent from user to delete
            //then delete


        }


        [HttpGet]
        public ActionResult Delete(int id)
        {
            var data = db.Products.Find(id);
            return View(data);
        }
        [HttpPost]
        public ActionResult Delete(ProductModel s)
        {
            var exobj = db.Products.Find(s.Id);
            db.Products.Remove(exobj);
            db.SaveChanges();
            TempData["Msg"] = "Product Deleted";
            return RedirectToAction("Index");

        }
    }
}