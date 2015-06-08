using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cSharp_MannyToManny.Data;
using cSharp_MannyToManny.Data.Models;

namespace cSharp_MannyToManny.Adapters
{
    public class MovieDataAdapter : IMovieAdapter
    {

        public List<Data.Models.Actor> GetActors()
        {
            using (MoviesDbContext db = new MoviesDbContext())
            {
                return db.Actors.ToList();

            }
        }


        public void AddActor(Models.ActorsCreateVm newActor)
        {
            using (MoviesDbContext db = new MoviesDbContext())
            {
                Actor tempActor = new Actor();
                tempActor.City = newActor.City;
                tempActor.FirstName = newActor.FirstName;
                tempActor.LastName = newActor.LastName;
                db.Actors.Add(tempActor);
                db.SaveChanges();

            }
        }
    }
}