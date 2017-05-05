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
    public class app_m_vaerelserController : ApiController
    {
        private VillaContext db = new VillaContext();

        // GET: api/app_m_vaerelser
        public IQueryable<app_m_vaerelser> Getapp_m_vaerelser()
        {
            return db.app_m_vaerelser;
        }

        // GET: api/app_m_vaerelser/5
        [ResponseType(typeof(app_m_vaerelser))]
        public IHttpActionResult Getapp_m_vaerelser(int id)
        {
            app_m_vaerelser app_m_vaerelser = db.app_m_vaerelser.Find(id);
            if (app_m_vaerelser == null)
            {
                return NotFound();
            }

            return Ok(app_m_vaerelser);
        }

        // PUT: api/app_m_vaerelser/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putapp_m_vaerelser(int id, app_m_vaerelser app_m_vaerelser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != app_m_vaerelser.m_vaerelser_id)
            {
                return BadRequest();
            }

            db.Entry(app_m_vaerelser).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!app_m_vaerelserExists(id))
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

        // POST: api/app_m_vaerelser
        [ResponseType(typeof(app_m_vaerelser))]
        public IHttpActionResult Postapp_m_vaerelser(app_m_vaerelser app_m_vaerelser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.app_m_vaerelser.Add(app_m_vaerelser);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (app_m_vaerelserExists(app_m_vaerelser.m_vaerelser_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = app_m_vaerelser.m_vaerelser_id }, app_m_vaerelser);
        }

        // DELETE: api/app_m_vaerelser/5
        [ResponseType(typeof(app_m_vaerelser))]
        public IHttpActionResult Deleteapp_m_vaerelser(int id)
        {
            app_m_vaerelser app_m_vaerelser = db.app_m_vaerelser.Find(id);
            if (app_m_vaerelser == null)
            {
                return NotFound();
            }

            db.app_m_vaerelser.Remove(app_m_vaerelser);
            db.SaveChanges();

            return Ok(app_m_vaerelser);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool app_m_vaerelserExists(int id)
        {
            return db.app_m_vaerelser.Count(e => e.m_vaerelser_id == id) > 0;
        }
    }
}