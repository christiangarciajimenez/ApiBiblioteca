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
    public class ComicApiController : ApiController
    {
        private BibliotecaEntities db = new BibliotecaEntities();

        // GET: api/ComicApi
        public IQueryable<ComicBiblioteca> GetComicBiblioteca()
        {
            return db.ComicBiblioteca;
        }

        // GET: api/ComicApi/5
        [ResponseType(typeof(ComicBiblioteca))]
        public IHttpActionResult GetComicBiblioteca(long id)
        {
            ComicBiblioteca comicBiblioteca = db.ComicBiblioteca.Find(id);
            if (comicBiblioteca == null)
            {
                return NotFound();
            }

            return Ok(comicBiblioteca);
        }

        // PUT: api/ComicApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutComicBiblioteca(long id, ComicBiblioteca comicBiblioteca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != comicBiblioteca.Id)
            {
                return BadRequest();
            }

            db.Entry(comicBiblioteca).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComicBibliotecaExists(id))
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

        // POST: api/ComicApi
        [ResponseType(typeof(ComicBiblioteca))]
        public IHttpActionResult PostComicBiblioteca(ComicBiblioteca comicBiblioteca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ComicBiblioteca.Add(comicBiblioteca);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = comicBiblioteca.Id }, comicBiblioteca);
        }

        // DELETE: api/ComicApi/5
        [ResponseType(typeof(ComicBiblioteca))]
        public IHttpActionResult DeleteComicBiblioteca(long id)
        {
            ComicBiblioteca comicBiblioteca = db.ComicBiblioteca.Find(id);
            if (comicBiblioteca == null)
            {
                return NotFound();
            }

            db.ComicBiblioteca.Remove(comicBiblioteca);
            db.SaveChanges();

            return Ok(comicBiblioteca);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ComicBibliotecaExists(long id)
        {
            return db.ComicBiblioteca.Count(e => e.Id == id) > 0;
        }
    }
}