using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RAD302Project.Models
{
    public class RAD302ProjectContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public RAD302ProjectContext() : base("name=RAD302ProjectContext")
        {
        }

        public System.Data.Entity.DbSet<RAD302Project.Models.Artist> Artists { get; set; }
    }

    public class ArtistsDbInitialiser : DropCreateDatabaseAlways<RAD302ProjectContext>
    {
        protected override void Seed(RAD302ProjectContext context)
        {
            List<Artist> artists = new List<Artist>()
            {
                new Artist() {ArtistName = "Adele", ActiveFrom = DateTime.Parse("01/05/2006"), Nationality = Nationality.English},
                new Artist() {ArtistName = "Michael Jackson", ActiveFrom = DateTime.Parse("13/01/1964"), Nationality = Nationality.American},
                new Artist() {ArtistName = "Sam Smith", ActiveFrom = DateTime.Parse("02/07/2007"), Nationality = Nationality.English},
                new Artist() {ArtistName = "U2", ActiveFrom = DateTime.Parse("11/09/1976"), Nationality = Nationality.Irish}
            };

            artists.ForEach(u => context.Artists.Add(u));

            base.Seed(context);
        }
    }
}
