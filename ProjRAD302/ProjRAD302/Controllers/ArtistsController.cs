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
using ProjRAD302.DAL;
using ProjRAD302.Models;

namespace ProjRAD302.Controllers
{
    public class ArtistsController : ApiController
    {
        private ProjRAD302Context db = new ProjRAD302Context();

        private IRepository<Artist> repo;

        public ArtistsController()
        {
            repo = new ArtistRepository(new ProjRAD302Context());
        }
        // GET: api/Artists
        public List<Artist> GetArtists()
        {
            return repo.GetItems();
        }

        // GET: api/Artists/5
        [ResponseType(typeof(Artist))]
        public IHttpActionResult GetArtist(int id)
        {
            Artist artist = db.Artists.Find(id);
            if (artist == null)
            {
                return NotFound();
            }

            return Ok(artist);
        }

        // POST: api/Artists
        [ResponseType(typeof(Artist))]
        public IHttpActionResult PostArtist(Artist artist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            repo.Insert(artist);
            repo.Save();

            return CreatedAtRoute("DefaultApi", new { id = artist.ArtistId }, artist);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public bool ArtistExists(string artistName)
        {
            return repo.ItemExists(artistName);
        }
    }
}