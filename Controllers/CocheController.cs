using ConcesionarioMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConcesionarioMVC.Controllers
{
    public class CocheController : Controller
    {
        Context db = new Context();
        public class CocheTotal{
            public int ID { get; set; }
            public string matricula { get; set; }
            public string modelo { get; set; }
            public string titular { get; set; }
        }
        // GET: Coche
        public ActionResult Index()
        {
            var lista = db.Coches.Include("Marca").ToList();
            return View(lista);
        }

        // GET: Coche/ListadoPorTaller
        public ActionResult ListadoPorTaller(int tallerID = 2)
        {
            ViewBag.tallerID = new SelectList(db.Taller, "ID", "ID");
            var lista = db.Database.SqlQuery<CocheTotal>("getCochesPorTaller @TallerSel", 
                new SqlParameter("@TallerSel", tallerID)).Where(c => c.ID == tallerID).ToList();
            return View(lista);
        }

        // GET: Coche/ListadoTalleresEnlazado
        public ActionResult ListadoTalleresEnlazado(int id = 1)
        {
            ViewBag.modeloPieza = db.Piezas.ToList();
            ViewBag.piezasCoche = db.piezasCoches.ToList();
            ViewBag.nombreMarca = db.Marca.ToList();
            var taller = db.Taller.Include("Coche").Single(x => x.ID == id);
            return View(taller);
        }

        // GET: Coche/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Coche/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coche/Create
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

        // GET: Coche/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Coche/Edit/5
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

        // GET: Coche/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Coche/Delete/5
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
