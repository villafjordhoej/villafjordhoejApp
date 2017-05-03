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
    public class app_bookingController : ApiController
    {
        private VillaContext db = new VillaContext();

        // GET: api/app_booking
        public IQueryable<app_booking> Getapp_booking()
        {
            return db.app_booking;
        }

        // GET: api/app_booking/5
        [ResponseType(typeof(app_booking))]
        public IHttpActionResult Getapp_booking(int id)
        {
            app_booking app_booking = db.app_booking.Find(id);
            if (app_booking == null)
            {
                return NotFound();
            }

            return Ok(app_booking);
        }

        // PUT: api/app_booking/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putapp_booking(int id, app_booking app_booking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != app_booking.booking_id)
            {
                return BadRequest();
            }

            db.Entry(app_booking).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!app_bookingExists(id))
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

        // POST: api/app_booking
        [ResponseType(typeof(app_booking))]
        public IHttpActionResult Postapp_booking(app_booking app_booking)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.app_booking.Add(app_booking);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (app_bookingExists(app_booking.booking_id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = app_booking.booking_id }, app_booking);
        }

        // DELETE: api/app_booking/5
        [ResponseType(typeof(app_booking))]
        public IHttpActionResult Deleteapp_booking(int id)
        {
            app_booking app_booking = db.app_booking.Find(id);
            if (app_booking == null)
            {
                return NotFound();
            }

            db.app_booking.Remove(app_booking);
            db.SaveChanges();

            return Ok(app_booking);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool app_bookingExists(int id)
        {
            return db.app_booking.Count(e => e.booking_id == id) > 0;
        }
    }
}