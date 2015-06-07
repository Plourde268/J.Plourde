using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_superChores.Models
{
    public class ChoresVm
    {
        public List<Kitchen> KitchenChores { get; set; }
        public Kitchen KitChore { get; set; }
        public List<Bathroom> BathroomChores { get; set; }
        public Bathroom BatChore { get; set; }
    }
}