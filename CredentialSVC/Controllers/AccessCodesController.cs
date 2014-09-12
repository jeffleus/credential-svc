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
using CredentialSVC.Models.Credentials;

namespace CredentialSVC.Controllers
{
    public class AccessCodesController : ApiController
    {
        private CredentialContext db = new CredentialContext();

        // GET: api/AccessCodes
        public IQueryable<AccessCode> GetAccessCodes()
        {
            return db.AccessCodes;
        }

        // GET: api/AccessCodes/5
        [ResponseType(typeof(AccessCode))]
        public IHttpActionResult GetAccessCode(string id)
        {
            AccessCode accessCode = db.AccessCodes.Find(id);
            if (accessCode == null)
            {
                return NotFound();
            }

            return Ok(accessCode);
        }

        // PUT: api/AccessCodes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAccessCode(string id, AccessCode accessCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != accessCode.Code)
            {
                return BadRequest();
            }

            db.Entry(accessCode).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccessCodeExists(id))
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

        // POST: api/AccessCodes
        [ResponseType(typeof(AccessCode))]
        public IHttpActionResult PostAccessCode(AccessCode accessCode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AccessCodes.Add(accessCode);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AccessCodeExists(accessCode.Code))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = accessCode.Code }, accessCode);
        }

        // DELETE: api/AccessCodes/5
        [ResponseType(typeof(AccessCode))]
        public IHttpActionResult DeleteAccessCode(string id)
        {
            AccessCode accessCode = db.AccessCodes.Find(id);
            if (accessCode == null)
            {
                return NotFound();
            }

            db.AccessCodes.Remove(accessCode);
            db.SaveChanges();

            return Ok(accessCode);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AccessCodeExists(string id)
        {
            return db.AccessCodes.Count(e => e.Code == id) > 0;
        }
    }
}