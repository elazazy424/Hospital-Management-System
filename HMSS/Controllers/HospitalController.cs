using HMSS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;


namespace HMSS.Controllers
{
    public class HospitalController : Controller
    {
         HospitalManagmentSystemEntities db = new HospitalManagmentSystemEntities();
        // GET: Hospital
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult show()
        {
            return View(db.Doctors_infoes.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Doctors_info doc)
        {
            if (ModelState.IsValid)
            {
                db.Doctors_infoes.Add(doc);
                db.SaveChanges();
                return RedirectToAction("show");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            return View(db.Doctors_infoes.Find(id));

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Doctors_info d = db.Doctors_infoes.Find(id);
            db.Doctors_infoes.Remove(d);
            return View(d);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult ConfirmDelete(int id) 
        {
            Doctors_info dr = db.Doctors_infoes.Find(id);
            db.Doctors_infoes.Remove(dr);
            db.SaveChanges();
            return RedirectToAction("show");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Doctors_info dr = db.Doctors_infoes.Find(id);
            return View(dr);
        }
        [HttpPost]
        public ActionResult Edit(Doctors_info dr)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dr).State=System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("show");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Doctors_info dr)
        {
            var result = db.Doctors_infoes.Where(a=>a.Name==dr.Name && a.ID==dr.ID).FirstOrDefault();
            if (result != null)
            {
                return RedirectToAction("show");
            }
            else
            {
                ModelState.AddModelError("", "Invail Name or Gender");
            }
            return RedirectToAction("show");
        }





    }
}