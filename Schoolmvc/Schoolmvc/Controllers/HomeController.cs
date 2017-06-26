using Schoolmvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Schoolmvc.Controllers
{
    public class HomeController : Controller
    {
        SchoolDataEntities db = new SchoolDataEntities();

        public ActionResult Create()
        {
            ViewBag.States = db.states.Select(x => new SelectListItem()
            {
                Text = x.StateName,
                Value = x.Id.ToString()
            }).ToList();
            return View();
        }
        [HttpPost]
        public ActionResult Create(Request request)
        {
            db.Requests.Add(request);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            ViewBag.States = db.states.Select(x => new SelectListItem()
            {
                Text = x.StateName,
                Value = x.Id.ToString()
            }).ToList();

            var request = db.Requests.Find(id);
            if (request == null)
            {
                return RedirectToAction("Index");
            }
            return View(request);
        }

        [HttpPost]
        public ActionResult Edit(Request request)
        {
            //request.state = db.states.Find(request.StateId);
            db.Entry(request).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
          

        }

        //Home/Index
        public ActionResult Index()
        {
            var data = db.Requests.ToList();
            return View(data);
        }

        public ActionResult Details(int id)
        {
            var k = db.Requests.Find(id);
            if (k == null)
            {
                var data = db.Requests.ToList();
                return View("Index", data);
            }
            return View(k);
        }
    }
}