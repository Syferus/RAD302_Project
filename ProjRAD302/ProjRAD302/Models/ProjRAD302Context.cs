using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjRAD302.Models
{
    public class ProjRAD302Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProjRAD302Context() : base("name=ProjRAD302Context")
        {
        }

        public class ArtistsDbInitialiser : DropCreateDatabaseAlways<ProjRAD302Context>
        {
            protected override void Seed(ProjRAD302Context context)
            {
                List<Artist> artists = new List<Artist>()
            {
                new Artist() {ArtistName = "Adele"},
                new Artist() {ArtistName = "Michael Jackson"},
                new Artist() {ArtistName = "Sam Smith"},
                new Artist() {ArtistName = "U2"}
            };

                artists.ForEach(u => context.Artists.Add(u));

                base.Seed(context);
            }
        }

        public System.Data.Entity.DbSet<ProjRAD302.Models.Artist> Artists { get; set; }
    }
}
