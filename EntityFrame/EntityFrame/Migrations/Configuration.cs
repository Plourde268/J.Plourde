namespace EntityFrame.Migrations
{
    using EntityFrame.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EntityFrame.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "EntityFrame.Models.MovieDBContext";
        }

        protected override void Seed(EntityFrame.Models.MovieDBContext context)
        {
            Movie[] movies = new Movie[]
            {
                new Movie {Title = "Star Wars", Director = "Lucas"},
                new Movie {Title = "Momento", Director= "Nolan"},
                new Movie{ Title="King Kong", Director="Jackson"}
            };

            context.Movies.AddOrUpdate(m => m.Title, movies);

            //movies.ForEach(m => context.Movies.Add(m));


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
