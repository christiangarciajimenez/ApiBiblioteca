using Servicios;
using Servicios.ClasesBiblioteca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using EjercicioWebApi.Datos;

namespace EjercicioEvaluableWeb.Controllers
{
    public class LibroController : Controller
    {
        private BibliotecaEntities db = new BibliotecaEntities();

        Biblioteca bib { get; set; }
        // GET: Biblioteca
        public ActionResult Index()
        {
             bib = new Biblioteca();
           List<LibroDTO>  libros =bib.DevolverTodosLosLibros();
            return View(libros.ToList());
        }

        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bib = new Biblioteca();
            LibroDTO libroDTO = bib.mostrarLibros(id ?? 0);
            if (libroDTO == null)
            {
                return HttpNotFound();
            }
            return View(libroDTO);
        }

       

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LibroDTO libroDTO)
        {
            if (ModelState.IsValid)
            {
                bib = new Biblioteca();
                bool annadirOk = bib.annadirLibros(libroDTO);
                if (annadirOk == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bib = new Biblioteca();
            LibroDTO libroDTO = bib.mostrarLibros(id ?? 0);
            if (libroDTO == null)
            {
                return HttpNotFound();
            }
            return View(libroDTO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LibroDTO libroDTO)
        {
            if (ModelState.IsValid)
            {
                bib = new Biblioteca();
                bool modificarOk = bib.modificarLibro(libroDTO);
                if (modificarOk == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(libroDTO);
        }

        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            bib = new Biblioteca();
            LibroDTO librosdto = bib.mostrarLibros(id ?? 0);
            if (librosdto == null)
            {
                return HttpNotFound();
            }
            return View(librosdto);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            bib = new Biblioteca();
            bool borrarOk = bib.borrarLibro(id);
            if (borrarOk == true)
            {
                return RedirectToAction("Index");
            }
            return View(id);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SearchByAuthor(string Author)
        {
            bib = new Biblioteca();
            List<LibroDTO> libros = bib.DevolverLibrosPorAutor(Author);
            return View("Index", libros.ToList());
        }
    }
}