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
    public class app_medarbejderController : ApiController
    {
        private VillaContext db = new VillaContext();

        // GET: api/app_medarbejder
        public IQueryable<app_medarbejder> Getapp_medarbejder()
        {
            return db.app_medarbejder;
        }

        // GET: api/app_medarbejder/5
        [ResponseType(typeof(app_medarbejder))]
        public IHttpActionResult Getapp_medarbejder(int id)
        {
            app_medarbejder app_medarbejder = db.app_medarbejder.Find(id);
            if (app_medarbejder == null)
            {
                return NotFound();
            }

            return Ok(app_medarbejder);
        }

        // PUT: api/app_medarbejder/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putapp_medarbejder(int id, app_medarbejder app_medarbejder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != app_medarbejder.medarbejder_id)
            {
                return BadRequest();
            }

            db.Entry(app_medarbejder).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!app_medarbejderExists(id))
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

        // POST: api/app_medarbejder
        [ResponseType(typeof(app_medarbejder))]
        public IHttpActionResult Postapp_medarbejder(app_medarbejder app_medarbejder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.app_medarbejder.Add(app_medarbejder);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (app_medarbejderExists(app_medarbejder.medarbejder_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = app_medarbejder.medarbejder_id }, app_medarbejder);
        }

        // DELETE: api/app_medarbejder/5
        [ResponseType(typeof(app_medarbejder))]
        public IHttpActionResult Deleteapp_medarbejder(int id)
        {
            app_medarbejder app_medarbejder = db.app_medarbejder.Find(id);
            if (app_medarbejder == null)
            {
                return NotFound();
            }

            db.app_medarbejder.Remove(app_medarbejder);
            db.SaveChanges();

            return Ok(app_medarbejder);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool app_medarbejderExists(int id)
        {
            return db.app_medarbejder.Count(e => e.medarbejder_id == id) > 0;
        }
    }
}