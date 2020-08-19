using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Servicios;
using Servicios.ClasesBiblioteca;
using System.Data;
using System.Data.Entity;
using System.Net;
using EjercicioWebApi.Datos;

namespace EjercicioEvaluableWeb.Controllers
{
    public class SerieController : Controller
    {
        private BibliotecaEntities db = new BibliotecaEntities();

        Biblioteca bib { get; set; }
        // GET: Serie
        public ActionResult Index()
        {
            var series = db.SerieTVBiblioteca.Include(m => m.ObraDeVideoBiblioteca).Include(m => m.ObraDeVideoBiblioteca.ObraCulturalBiblioteca);
            return View(series.ToList());
        }

        // GET: Serie/Details/5
        [ActionName("Details")]
        public ActionResult Details(long? id)
        {

            if(id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraCulturalBiblioteca obra = db.ObraCulturalBiblioteca.Find(id);
            SerieTVBiblioteca series = obra.ObraDeVideoBiblioteca.FirstOrDefault().SerieTVBiblioteca.FirstOrDefault();
            if (series == null)
            {
                return HttpNotFound();
            }
            return View(series);
        }

        // GET: Serie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Serie/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SerieTVDTO serieTVDTO)
        {

            if (ModelState.IsValid)
            {
                bib = new Biblioteca();
                bool annadirOk = bib.annadirSeries(serieTVDTO);
                if (annadirOk == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        // GET: Serie/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bib = new Biblioteca();
            SerieTVDTO serieTVDTO = bib.mostrarSeries(id ?? 0);
            if (serieTVDTO == null)
            {
                return HttpNotFound();
            }
            return View(serieTVDTO);
        }

        // POST: Serie/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SerieTVDTO serieTVDTO)
        {

            if (ModelState.IsValid)
            {
                bib = new Biblioteca();
                bool modificarOk = bib.modificarSerie(serieTVDTO);
                if (modificarOk == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(serieTVDTO);
        }

        // GET: Serie/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraCulturalBiblioteca obra = db.ObraCulturalBiblioteca.Find(id);
            SerieTVBiblioteca series = obra.ObraDeVideoBiblioteca.FirstOrDefault().SerieTVBiblioteca.FirstOrDefault();
            if (series == null)
            {
                return HttpNotFound();
            }
            return View(series);
        }

        // POST: Serie/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {

            ObraCulturalBiblioteca obra = db.ObraCulturalBiblioteca.Find(id);
            SerieTVBiblioteca series = obra.ObraDeVideoBiblioteca.FirstOrDefault().SerieTVBiblioteca.FirstOrDefault();
            db.SerieTVBiblioteca.Remove(obra.ObraDeVideoBiblioteca.First().SerieTVBiblioteca.First());
            db.ObraDeVideoBiblioteca.Remove(obra.ObraDeVideoBiblioteca.First());
            db.ObraCulturalBiblioteca.Remove(obra);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchByGenre(string Genre)
        {          
            var series = db.SerieTVBiblioteca.Where(x => x.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra.ToLower().Contains(Genre.ToLower())).ToList();
            /* if (series.Count()==0)
             {
                  series = db.SerieTVBiblioteca.Include(m => m.ObraDeVideoBiblioteca).Include(m => m.ObraDeVideoBiblioteca.ObraCulturalBiblioteca).ToList();
                 return View("Index", series.ToList());
             }
             else
             {
                 return View("Index", series.ToList());
             }*/
            return View("Index", series.ToList());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
