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
using VillafjordhoejWS;

namespace VillafjordhoejWS.Controllers
{
    public class app_m_behandlingController : ApiController
    {
        private VillaContext db = new VillaContext();

        // GET: api/app_m_behandling
        public IQueryable<app_m_behandling> Getapp_m_behandling()
        {
            return db.app_m_behandling;
        }

        // GET: api/app_m_behandling/5
        [ResponseType(typeof(app_m_behandling))]
        public IHttpActionResult Getapp_m_behandling(int id)
        {
            app_m_behandling app_m_behandling = db.app_m_behandling.Find(id);
            if (app_m_behandling == null)
            {
                return NotFound();
            }

            return Ok(app_m_behandling);
        }

        // PUT: api/app_m_behandling/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putapp_m_behandling(int id, app_m_behandling app_m_behandling)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != app_m_behandling.m_behandling_id)
            {
                return BadRequest();
            }

            db.Entry(app_m_behandling).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!app_m_behandlingExists(id))
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

        // POST: api/app_m_behandling
        [ResponseType(typeof(app_m_behandling))]
        public IHttpActionResult Postapp_m_behandling(app_m_behandling app_m_behandling)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.app_m_behandling.Add(app_m_behandling);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (app_m_behandlingExists(app_m_behandling.m_behandling_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = app_m_behandling.m_behandling_id }, app_m_behandling);
        }

        // DELETE: api/app_m_behandling/5
        [ResponseType(typeof(app_m_behandling))]
        public IHttpActionResult Deleteapp_m_behandling(int id)
        {
            app_m_behandling app_m_behandling = db.app_m_behandling.Find(id);
            if (app_m_behandling == null)
            {
                return NotFound();
            }

            db.app_m_behandling.Remove(app_m_behandling);
            db.SaveChanges();

            return Ok(app_m_behandling);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool app_m_behandlingExists(int id)
        {
            return db.app_m_behandling.Count(e => e.m_behandling_id == id) > 0;
        }
    }
}