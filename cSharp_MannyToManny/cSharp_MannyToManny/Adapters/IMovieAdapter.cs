using cSharp_MannyToManny.Data.Models;
using cSharp_MannyToManny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_MannyToManny.Adapters
{
    interface IMovieAdapter
    {
        List<Actor> GetActors();//Get all Actors

        void AddActor(ActorsCreateVm newActor);
    }
}
