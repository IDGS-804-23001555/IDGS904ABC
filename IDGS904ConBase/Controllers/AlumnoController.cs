using IDGS904ConBase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ConBase.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumnos
        public ActionResult Index()
        {
            using (var dbAlumno = new AlumnoContext())
            {
                return View(dbAlumno.Alumnos.ToList());
            }
        }

        // GET: Alumnos/Details/5
        public ActionResult Details(int id)
        {
            using (var dbAlumno = new AlumnoContext())
            {
                var alumno = dbAlumno.Alumnos.FirstOrDefault(x => x.Id == id);
                return View(alumno);
            }
        }

        // GET: Alumnos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alumnos/Create
        [HttpPost]
        public ActionResult Create(Alumno alum)
        {
            try
            {
                using (var dbAlumno = new AlumnoContext())
                {
                    dbAlumno.Alumnos.Add(alum);
                    dbAlumno.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Edit/5
        public ActionResult Edit(int id)
        {
            using (var dbAlumno = new AlumnoContext())
            {
                var alumno = dbAlumno.Alumnos.FirstOrDefault(x => x.Id == id);
                return View(alumno);
            }
        }

        // POST: Alumnos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Alumno alum)
        {
            try
            {
                using (var dbAlumno = new AlumnoContext())
                {
                    dbAlumno.Entry(alum).State = EntityState.Modified;
                    dbAlumno.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumnos/Delete/5
        public ActionResult Delete(int id)
        {
            using (var dbAlumno = new AlumnoContext())
            {
                var alumno = dbAlumno.Alumnos.FirstOrDefault(x => x.Id == id);
                return View(alumno);
            }
        }

        // POST: Alumnos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Alumno alum)
        {
            try
            {
                using (var dbAlumno = new AlumnoContext())
                {
                    var alumno = dbAlumno.Alumnos.FirstOrDefault(x => x.Id == id);
                    if (alumno != null)
                    {
                        dbAlumno.Alumnos.Remove(alumno);
                        dbAlumno.SaveChanges();
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