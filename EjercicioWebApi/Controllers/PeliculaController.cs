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
    public class PeliculaController : Controller
    {
        private BibliotecaEntities db = new BibliotecaEntities();

        Biblioteca bib { get; set; }
        // GET: Pelicula
        public ActionResult Index()
        {
            var peliculas = db.PeliculaBiblioteca.Include(m => m.ObraDeVideoBiblioteca).Include(m => m.ObraDeVideoBiblioteca.ObraCulturalBiblioteca);
            return View(peliculas.ToList());
        }

        // GET: Pelicula/Details/5
        [ActionName("Details")]
        public ActionResult Details(long? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraCulturalBiblioteca obra = db.ObraCulturalBiblioteca.Find(id);
            PeliculaBiblioteca peliculas = obra.ObraDeVideoBiblioteca.FirstOrDefault().PeliculaBiblioteca.FirstOrDefault();
            if (peliculas == null)
            {
                return HttpNotFound();
            }
            return View(peliculas);
        }

        // GET: Pelicula/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pelicula/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PeliculaDTO peliculaDTO)
        {

            if (ModelState.IsValid)
            {
                bib = new Biblioteca();
                bool annadirOk = bib.annadirPeliculas(peliculaDTO);
                if (annadirOk == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        // GET: Pelicula/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bib = new Biblioteca();
            PeliculaDTO peliculaDTO = bib.mostrarPeliculas(id ?? 0);
            if(peliculaDTO == null)
            {
                return HttpNotFound();
            }
            return View(peliculaDTO);
        }

        // POST: Pelicula/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PeliculaDTO peliculaDTO)
        {

            if (ModelState.IsValid)
            {
                bib = new Biblioteca();
                bool modificarOk = bib.modificarPelicula(peliculaDTO);
                if(modificarOk == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(peliculaDTO);
        }

        // GET: Pelicula/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraCulturalBiblioteca obra = db.ObraCulturalBiblioteca.Find(id);
            PeliculaBiblioteca peliculas = obra.ObraDeVideoBiblioteca.FirstOrDefault().PeliculaBiblioteca.FirstOrDefault();
            if (peliculas == null)
            {
                return HttpNotFound();
            }
            return View(peliculas);
        }

        // POST: Pelicula/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {

            ObraCulturalBiblioteca obra = db.ObraCulturalBiblioteca.Find(id);
            PeliculaBiblioteca peliculas = obra.ObraDeVideoBiblioteca.FirstOrDefault().PeliculaBiblioteca.FirstOrDefault();
            db.PeliculaBiblioteca.Remove(obra.ObraDeVideoBiblioteca.First().PeliculaBiblioteca.First());
            db.ObraDeVideoBiblioteca.Remove(obra.ObraDeVideoBiblioteca.First());
            db.ObraCulturalBiblioteca.Remove(obra);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchByGenre(string Genre)
        {
            var peliculas = db.PeliculaBiblioteca.Where(x => x.ObraDeVideoBiblioteca.ObraCulturalBiblioteca.GeneroObra.ToLower().Contains(Genre.ToLower())).ToList();
            /*  if (peliculas.Count == 0)
              {
                  peliculas = db.PeliculaBiblioteca.Include(m => m.ObraDeVideoBiblioteca).Include(m => m.ObraDeVideoBiblioteca.ObraCulturalBiblioteca).ToList();
                  return View("Index", peliculas.ToList());
              }
              else
              {
                  return View("Index", peliculas.ToList());
              }*/
            return View("Index", peliculas.ToList());
           
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchByDirector(string Director)
        {
            var peliculas = db.PeliculaBiblioteca.Where(x => x.ObraDeVideoBiblioteca.DirectorObra.ToLower().Contains(Director.ToLower())).ToList();
            /*  if (peliculas.Count == 0)
              {
                  peliculas = db.PeliculaBiblioteca.Include(m => m.ObraDeVideoBiblioteca).Include(m => m.ObraDeVideoBiblioteca.ObraCulturalBiblioteca).ToList();
                  return View("Index", peliculas.ToList());
              }
              else
              {
                  return View("Index", peliculas.ToList());
              }*/
            return View("Index", peliculas.ToList());
            
                
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
