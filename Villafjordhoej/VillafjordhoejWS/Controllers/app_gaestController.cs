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
    public class app_gaestController : ApiController
    {
        private VillaContext db = new VillaContext();

        // GET: api/app_gaest
        public IQueryable<app_gaest> Getapp_gaest()
        {
            return db.app_gaest;
        }

        // GET: api/app_gaest/5
        [ResponseType(typeof(app_gaest))]
        public IHttpActionResult Getapp_gaest(int id)
        {
            app_gaest app_gaest = db.app_gaest.Find(id);
            if (app_gaest == null)
            {
                return NotFound();
            }

            return Ok(app_gaest);
        }

        // PUT: api/app_gaest/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putapp_gaest(int id, app_gaest app_gaest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != app_gaest.gaest_id)
            {
                return BadRequest();
            }

            db.Entry(app_gaest).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!app_gaestExists(id))
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

        // POST: api/app_gaest
        [ResponseType(typeof(app_gaest))]
        public IHttpActionResult Postapp_gaest(app_gaest app_gaest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.app_gaest.Add(app_gaest);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (app_gaestExists(app_gaest.gaest_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = app_gaest.gaest_id }, app_gaest);
        }

        // DELETE: api/app_gaest/5
        [ResponseType(typeof(app_gaest))]
        public IHttpActionResult Deleteapp_gaest(int id)
        {
            app_gaest app_gaest = db.app_gaest.Find(id);
            if (app_gaest == null)
            {
                return NotFound();
            }

            db.app_gaest.Remove(app_gaest);
            db.SaveChanges();

            return Ok(app_gaest);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool app_gaestExists(int id)
        {
            return db.app_gaest.Count(e => e.gaest_id == id) > 0;
        }
    }
}