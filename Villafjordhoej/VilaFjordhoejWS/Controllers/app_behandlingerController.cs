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
using VilaFjordhoejWS;

namespace VilaFjordhoejWS.Controllers
{
    public class app_behandlingerController : ApiController
    {
        private VillaContext db = new VillaContext();

        // GET: api/app_behandlinger
        public IQueryable<app_behandlinger> Getapp_behandlinger()
        {
            return db.app_behandlinger;
        }

        // GET: api/app_behandlinger/5
        [ResponseType(typeof(app_behandlinger))]
        public IHttpActionResult Getapp_behandlinger(int id)
        {
            app_behandlinger app_behandlinger = db.app_behandlinger.Find(id);
            if (app_behandlinger == null)
            {
                return NotFound();
            }

            return Ok(app_behandlinger);
        }

        // PUT: api/app_behandlinger/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putapp_behandlinger(int id, app_behandlinger app_behandlinger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != app_behandlinger.behandlinger_id)
            {
                return BadRequest();
            }

            db.Entry(app_behandlinger).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!app_behandlingerExists(id))
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

        // POST: api/app_behandlinger
        [ResponseType(typeof(app_behandlinger))]
        public IHttpActionResult Postapp_behandlinger(app_behandlinger app_behandlinger)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.app_behandlinger.Add(app_behandlinger);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (app_behandlingerExists(app_behandlinger.behandlinger_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = app_behandlinger.behandlinger_id }, app_behandlinger);
        }

        // DELETE: api/app_behandlinger/5
        [ResponseType(typeof(app_behandlinger))]
        public IHttpActionResult Deleteapp_behandlinger(int id)
        {
            app_behandlinger app_behandlinger = db.app_behandlinger.Find(id);
            if (app_behandlinger == null)
            {
                return NotFound();
            }

            db.app_behandlinger.Remove(app_behandlinger);
            db.SaveChanges();

            return Ok(app_behandlinger);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool app_behandlingerExists(int id)
        {
            return db.app_behandlinger.Count(e => e.behandlinger_id == id) > 0;
        }
    }
}