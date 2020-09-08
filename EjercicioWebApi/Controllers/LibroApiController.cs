using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EjercicioWebApi.Datos;

namespace EjercicioWebApi.Controllers
{
    [Authorize]
    public class LibroApiController : ApiController
    {
        private BibliotecaEntities db = new BibliotecaEntities();

        // GET: api/LibroApi
        public IQueryable<LibroBiblioteca> GetLibroBiblioteca()
        {
            return db.LibroBiblioteca;
        }

        // GET: api/LibroApi/5
        [ResponseType(typeof(LibroBiblioteca))]
        public IHttpActionResult GetLibroBiblioteca(long id)
        {
            LibroBiblioteca libroBiblioteca = db.LibroBiblioteca.Find(id);
            if (libroBiblioteca == null)
            {
                return NotFound();
            }

            return Ok(libroBiblioteca);
        }

        // PUT: api/LibroApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLibroBiblioteca(long id, LibroBiblioteca libroBiblioteca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != libroBiblioteca.IdLibro)
            {
                return BadRequest();
            }

            db.Entry(libroBiblioteca).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibroBibliotecaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/LibroApi
        [ResponseType(typeof(LibroBiblioteca))]
        public IHttpActionResult PostLibroBiblioteca(LibroBiblioteca libroBiblioteca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LibroBiblioteca.Add(libroBiblioteca);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = libroBiblioteca.IdLibro }, libroBiblioteca);
        }

        // DELETE: api/LibroApi/5
        [ResponseType(typeof(LibroBiblioteca))]
        public IHttpActionResult DeleteLibroBiblioteca(long id)
        {
            LibroBiblioteca libroBiblioteca = db.LibroBiblioteca.Find(id);
            if (libroBiblioteca == null)
            {
                return NotFound();
            }

            db.LibroBiblioteca.Remove(libroBiblioteca);
            db.SaveChanges();

            return Ok(libroBiblioteca);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LibroBibliotecaExists(long id)
        {
            return db.LibroBiblioteca.Count(e => e.IdLibro == id) > 0;
        }
    }
}