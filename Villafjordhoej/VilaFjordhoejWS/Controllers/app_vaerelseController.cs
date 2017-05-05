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
    public class app_vaerelseController : ApiController
    {
        private VillaContext db = new VillaContext();

        // GET: api/app_vaerelse
        public IQueryable<app_vaerelse> Getapp_vaerelse()
        {
            return db.app_vaerelse;
        }

        // GET: api/app_vaerelse/5
        [ResponseType(typeof(app_vaerelse))]
        public IHttpActionResult Getapp_vaerelse(int id)
        {
            app_vaerelse app_vaerelse = db.app_vaerelse.Find(id);
            if (app_vaerelse == null)
            {
                return NotFound();
            }

            return Ok(app_vaerelse);
        }

        // PUT: api/app_vaerelse/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putapp_vaerelse(int id, app_vaerelse app_vaerelse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != app_vaerelse.vaerelse_id)
            {
                return BadRequest();
            }

            db.Entry(app_vaerelse).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!app_vaerelseExists(id))
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

        // POST: api/app_vaerelse
        [ResponseType(typeof(app_vaerelse))]
        public IHttpActionResult Postapp_vaerelse(app_vaerelse app_vaerelse)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.app_vaerelse.Add(app_vaerelse);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (app_vaerelseExists(app_vaerelse.vaerelse_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = app_vaerelse.vaerelse_id }, app_vaerelse);
        }

        // DELETE: api/app_vaerelse/5
        [ResponseType(typeof(app_vaerelse))]
        public IHttpActionResult Deleteapp_vaerelse(int id)
        {
            app_vaerelse app_vaerelse = db.app_vaerelse.Find(id);
            if (app_vaerelse == null)
            {
                return NotFound();
            }

            db.app_vaerelse.Remove(app_vaerelse);
            db.SaveChanges();

            return Ok(app_vaerelse);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool app_vaerelseExists(int id)
        {
            return db.app_vaerelse.Count(e => e.vaerelse_id == id) > 0;
        }
    }
}