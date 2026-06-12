using IDGS904ConBase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ConBase.Controllers
{
    public class MaestrosController : Controller
    {
        // GET: Maestros
        public ActionResult Index()
        {
            using (var dbMaestro = new AlumnoContext())
            {
                return View(dbMaestro.Maestros.ToList());
            }
        }

        // GET: Maestros/Details/5
        public ActionResult Details(int id)
        {
            using (var dbMaestro = new AlumnoContext())
            {
                var maestro = dbMaestro.Maestros.FirstOrDefault(x => x.Id == id);
                return View(maestro);
            }
        }

        // GET: Maestros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maestros/Create
        [HttpPost]
        public ActionResult Create(Maestro maes)
        {
            try
            {
                using (var dbMaestro = new AlumnoContext())
                {
                    dbMaestro.Maestros.Add(maes);
                    dbMaestro.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Maestros/Edit/5
        public ActionResult Edit(int id)
        {
            using (var dbMaestro = new AlumnoContext())
            {
                var maestro = dbMaestro.Maestros.FirstOrDefault(x => x.Id == id);
                return View(maestro);
            }
        }

        // POST: Maestros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Maestro maes)
        {
            try
            {
                using (var dbMaestro = new AlumnoContext())
                {
                    dbMaestro.Entry(maes).State = EntityState.Modified;
                    dbMaestro.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Maestros/Delete/5
        public ActionResult Delete(int id)
        {
            using (var dbMaestro = new AlumnoContext())
            {
                var maestro = dbMaestro.Maestros.FirstOrDefault(x => x.Id == id);
                return View(maestro);
            }
        }

        // POST: Maestros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Maestro maes)
        {
            try
            {
                using (var dbMaestro = new AlumnoContext())
                {
                    var maestro = dbMaestro.Maestros.FirstOrDefault(x => x.Id == id);

                    if (maestro != null)
                    {
                        dbMaestro.Maestros.Remove(maestro);
                        dbMaestro.SaveChanges();
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}