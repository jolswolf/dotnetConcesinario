using ConcesionarioMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConcesionarioMVC.Controllers
{
    public class PiezaController : Controller
    {
        Context db = new Context();
        // GET: Pieza
        public ActionResult Index()
        {
            return View();
        }

        // GET: Pieza/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Pieza/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pieza/Create
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

        // GET: Pieza/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Pieza/Edit/5
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

        // GET: Pieza/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Pieza/Delete/5
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
