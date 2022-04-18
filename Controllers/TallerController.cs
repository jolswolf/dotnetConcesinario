using ConcesionarioMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConcesionarioMVC.Controllers
{
    public class TallerController : Controller
    {
        Context db = new Context();
        // GET: Taller
        public ActionResult Index()
        {
            List<Taller> talleres = db.Taller.ToList();
            return View(talleres);
        }

        // GET: Taller/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Taller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Taller/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Taller/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Taller/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Taller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Taller/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
