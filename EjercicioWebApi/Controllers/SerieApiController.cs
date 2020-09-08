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
    public class SerieApiController : ApiController
    {
        private BibliotecaEntities db = new BibliotecaEntities();

        // GET: api/SerieApi
        public IQueryable<SerieTVBiblioteca> GetSerieTVBiblioteca()
        {
            return db.SerieTVBiblioteca;
        }

        // GET: api/SerieApi/5
        [ResponseType(typeof(SerieTVBiblioteca))]
        public IHttpActionResult GetSerieTVBiblioteca(long id)
        {
            SerieTVBiblioteca serieTVBiblioteca = db.SerieTVBiblioteca.Find(id);
            if (serieTVBiblioteca == null)
            {
                return NotFound();
            }

            return Ok(serieTVBiblioteca);
        }

        // PUT: api/SerieApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSerieTVBiblioteca(long id, SerieTVBiblioteca serieTVBiblioteca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != serieTVBiblioteca.IdSerie)
            {
                return BadRequest();
            }

            db.Entry(serieTVBiblioteca).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SerieTVBibliotecaExists(id))
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

        // POST: api/SerieApi
        [ResponseType(typeof(SerieTVBiblioteca))]
        public IHttpActionResult PostSerieTVBiblioteca(SerieTVBiblioteca serieTVBiblioteca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SerieTVBiblioteca.Add(serieTVBiblioteca);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = serieTVBiblioteca.IdSerie }, serieTVBiblioteca);
        }

        // DELETE: api/SerieApi/5
        [ResponseType(typeof(SerieTVBiblioteca))]
        public IHttpActionResult DeleteSerieTVBiblioteca(long id)
        {
            SerieTVBiblioteca serieTVBiblioteca = db.SerieTVBiblioteca.Find(id);
            if (serieTVBiblioteca == null)
            {
                return NotFound();
            }

            db.SerieTVBiblioteca.Remove(serieTVBiblioteca);
            db.SaveChanges();

            return Ok(serieTVBiblioteca);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SerieTVBibliotecaExists(long id)
        {
            return db.SerieTVBiblioteca.Count(e => e.IdSerie == id) > 0;
        }
    }
}