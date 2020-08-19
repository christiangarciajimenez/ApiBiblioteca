using Servicios;
using Servicios.ClasesBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EjercicioWebApi.Datos;

namespace EjercicioEvaluableWeb.Controllers
{
    public class ComicController : Controller
    {
        private BibliotecaEntities db = new BibliotecaEntities();

        Biblioteca bib { get; set; }
        // GET: Comic
        public ActionResult Index()
        {
            var comics = db.ComicBiblioteca.Include(m => m.ObraLiterariaBiblioteca).Include(m=> m.ObraLiterariaBiblioteca.ObraCulturalBiblioteca);
            return View(comics.ToList());
        }

        //GET: Comic/Details/5
        [ActionName("Details")]
        public ActionResult Details(long? id)
        {

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraCulturalBiblioteca obra = db.ObraCulturalBiblioteca.Find(id);
            ComicBiblioteca comics = obra.ObraLiterariaBiblioteca.FirstOrDefault().ComicBiblioteca.FirstOrDefault();
            if (comics == null)
            {
                return HttpNotFound();
            }
            return View(comics);
        }

        // GET: Comic/Create
        public ActionResult Create()
        {
            //ViewBag.IdObra = new SelectList(db.ObraCulturalBiblioteca, "IdObra", "TituloObra");
            return View();
        }

        // POST: Comic/Create
      /*  [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdObra,EditoraObra,NumeroVolumenesObra,CapitulosObra")] ComicBiblioteca comics)
        {
            if (ModelState.IsValid)
            {
                db.ComicBiblioteca.Add(comics);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdObra = new SelectList(db.ObraCulturalBiblioteca, "IdObra", "TituloObra", comics.IdObra);
            return View(comics);
        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ComicDTO comicDTO)
        {
            if (ModelState.IsValid)
            {
                bib = new Biblioteca();
                bool annadirOk = bib.annadirComics(comicDTO);
                if (annadirOk == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        // GET: Comic/Edit/5
    /*    public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraCulturalBiblioteca obra = db.ObraCulturalBiblioteca.Find(id);
            ComicBiblioteca comics = obra.ObraLiterariaBiblioteca.FirstOrDefault().ComicBiblioteca.FirstOrDefault();
            if (comics == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdObra= new SelectList(db.ObraCulturalBiblioteca, "IdObra", "TituloObra", comics.IdObra);
            return View(comics);
        }*/

        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bib = new Biblioteca();
            ComicDTO comicDTO = bib.mostrarComics(id ?? 0);
            if (comicDTO==null)
            {
                return HttpNotFound();
            }
            return View(comicDTO);
        }

        // POST: Comic/Edit/5
    /*    [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdObra,EditoraObra,NumeroVolumenesObra,CapitulosObra")] ComicBiblioteca comics)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comics).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdObra = new SelectList(db.ObraCulturalBiblioteca, "IdObra", "TituloObra", comics.IdObra);
            return View(comics);
        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ComicDTO comicDTO)
        {
            if (ModelState.IsValid)
            {
                bib = new Biblioteca();
                bool modificarOk = bib.modificarComic(comicDTO);
                if (modificarOk == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(comicDTO);
        }

        // GET: Comic/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObraCulturalBiblioteca obra = db.ObraCulturalBiblioteca.Find(id);
            ComicBiblioteca comics = obra.ObraLiterariaBiblioteca.FirstOrDefault().ComicBiblioteca.FirstOrDefault();
            if (comics == null)
            {
                return HttpNotFound();
            }
            return View(comics);
        }

        // POST: Comic/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ObraCulturalBiblioteca obra = db.ObraCulturalBiblioteca.Find(id);
            ComicBiblioteca comics = obra.ObraLiterariaBiblioteca.FirstOrDefault().ComicBiblioteca.FirstOrDefault();
            db.ComicBiblioteca.Remove(obra.ObraLiterariaBiblioteca.First().ComicBiblioteca.First());
            db.ObraLiterariaBiblioteca.Remove(obra.ObraLiterariaBiblioteca.First());
            db.ObraCulturalBiblioteca.Remove(obra);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchByYear(long? Year)
        {
            /*  bib = new Biblioteca();

              List<ComicDTO> comics = bib.DevolverComicsPorAnyo(Year);
              return View("Index", comics.ToList());*/

            var comics = db.ComicBiblioteca.Where(x => x.ObraLiterariaBiblioteca.ObraCulturalBiblioteca.AnyoObra.ToString().Contains(Year.ToString())).ToList();
            /*  if (comics.Count == 0)
              {
                  comics = db.ComicBiblioteca.Include(m => m.ObraLiterariaBiblioteca).Include(m => m.ObraLiterariaBiblioteca.ObraCulturalBiblioteca).ToList();
                  return View("Index", comics.ToList());
              }
              else
              {
                  return View("Index", comics.ToList());
              }*/
            return View("Index", comics.ToList());
           

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchByPublisher(string Publisher)
        {
            var comics = db.ComicBiblioteca.Where(x => x.EditoraObra.ToLower().Contains(Publisher.ToLower())).ToList();
            /*   if (comics.Count == 0)
               {
                    comics = db.ComicBiblioteca.Include(m => m.ObraLiterariaBiblioteca).Include(m => m.ObraLiterariaBiblioteca.ObraCulturalBiblioteca).ToList();
                   return View("Index", comics.ToList());
               }
               else{
                   return View("Index", comics.ToList());
               }*/
            return View("Index", comics.ToList());
            
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
