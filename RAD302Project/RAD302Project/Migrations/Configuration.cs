using System.Collections.Generic;
using RAD302Project.Models;

namespace RAD302Project.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RAD302Project.Models.RAD302ProjectContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(RAD302Project.Models.RAD302ProjectContext context)
        {
            //List<Artist> artists = new List<Artist>()
            //{
            //    new Artist() {ArtistName = "Adele", ActiveFrom = DateTime.Parse("01/05/2006"), Nationality = Nationality.English},
            //    new Artist() {ArtistName = "Michael Jackson", ActiveFrom = DateTime.Parse("13/01/1964"), Nationality = Nationality.American},
            //    new Artist() {ArtistName = "Sam Smith", ActiveFrom = DateTime.Parse("02/07/2007"), Nationality = Nationality.English},
            //    new Artist() {ArtistName = "U2", ActiveFrom = DateTime.Parse("11/09/1976"), Nationality = Nationality.Irish}
            //};

            //artists.ForEach(u => context.Artists.Add(u));
        }
    }
}
