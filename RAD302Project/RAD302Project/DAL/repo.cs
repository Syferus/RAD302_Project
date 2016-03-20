using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RAD302Project.Models;

namespace RAD302Project.DAL
{
    public interface IRepository<T> : IDisposable
    {

        List<T> GetItems();

        //   Task<T> GetItemById(int id);

        /*       void InsertItem(T newItem);
               void DeleteItem(int id);

               void Save(); */
    }

    public class ArtistRepository : IRepository<Artist>
    {
        private RAD302ProjectContext db ;

        public ArtistRepository(RAD302ProjectContext db)
        {
            this.db = db;
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public List<Artist> GetItems()
        {
            return db.Artists.ToList();
        }
    }
}
