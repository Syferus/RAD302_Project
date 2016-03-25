using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using ProjectRAD302.Models;

namespace ProjectRAD302.DAL
{
    public interface IRepository<T> : IDisposable // generic repository to abstract model from controller
    {

        List<T> GetItems();
        T GetItemById(int id);
        void Insert(T entity);

        bool ItemExists(string name);
        
        void Save();
    }

    public class ArtistRepository : IRepository<Artist> //ArtistRepository inherhits generic repo's attributes. Passing it the Artist class
    {
        private ProjectRAD302Context db;

        public ArtistRepository(ProjectRAD302Context db)
        {
            this.db = db;
        }
        public List<Artist> GetItems()
        {
            return db.Artists.ToList();
        }

        public Artist GetItemById(int id)
        {
            return db.Artists.Find(id);
        }
        public void Insert(Artist newArtist)
        {
            db.Artists.Add(newArtist);
        }

        public bool ItemExists(string artistName)
        {
            return db.Artists.Any(e => e.ArtistName == artistName);
        }
         
        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }


    }
}