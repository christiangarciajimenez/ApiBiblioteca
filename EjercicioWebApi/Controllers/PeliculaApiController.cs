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
    public class PeliculaApiController : ApiController
    {
        private BibliotecaEntities db = new BibliotecaEntities();

        // GET: api/PeliculaApi
        public IQueryable<PeliculaBiblioteca> GetPeliculaBiblioteca()
        {
            return db.PeliculaBiblioteca;
        }

        // GET: api/PeliculaApi/5
        [ResponseType(typeof(PeliculaBiblioteca))]
        public IHttpActionResult GetPeliculaBiblioteca(long id)
        {
            PeliculaBiblioteca peliculaBiblioteca = db.PeliculaBiblioteca.Find(id);
            if (peliculaBiblioteca == null)
            {
                return NotFound();
            }

            return Ok(peliculaBiblioteca);
        }

        // PUT: api/PeliculaApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPeliculaBiblioteca(long id, PeliculaBiblioteca peliculaBiblioteca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != peliculaBiblioteca.IdPelicula)
            {
                return BadRequest();
            }

            db.Entry(peliculaBiblioteca).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeliculaBibliotecaExists(id))
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

        // POST: api/PeliculaApi
        [ResponseType(typeof(PeliculaBiblioteca))]
        public IHttpActionResult PostPeliculaBiblioteca(PeliculaBiblioteca peliculaBiblioteca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PeliculaBiblioteca.Add(peliculaBiblioteca);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = peliculaBiblioteca.IdPelicula }, peliculaBiblioteca);
        }

        // DELETE: api/PeliculaApi/5
        [ResponseType(typeof(PeliculaBiblioteca))]
        public IHttpActionResult DeletePeliculaBiblioteca(long id)
        {
            PeliculaBiblioteca peliculaBiblioteca = db.PeliculaBiblioteca.Find(id);
            if (peliculaBiblioteca == null)
            {
                return NotFound();
            }

            db.PeliculaBiblioteca.Remove(peliculaBiblioteca);
            db.SaveChanges();

            return Ok(peliculaBiblioteca);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PeliculaBibliotecaExists(long id)
        {
            return db.PeliculaBiblioteca.Count(e => e.IdPelicula == id) > 0;
        }
    }
}