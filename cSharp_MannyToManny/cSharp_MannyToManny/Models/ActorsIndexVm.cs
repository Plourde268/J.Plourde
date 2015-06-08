using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using cSharp_MannyToManny.Data.Models;

namespace cSharp_MannyToManny.Models
{
    public class ActorsIndexVm
    {
        public string Greeting { get; set; }
        public List<Actor> Actors { get; set; }
    }
}