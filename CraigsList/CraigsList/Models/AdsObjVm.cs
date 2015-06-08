using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraigsList.Models
{
    public class AdsObjVm
    {
        public Automobiles Auto { get; set; }
        public Apartments Apt { get; set; }
        public CasualEncounter Casual { get; set; }
        public Furniture Furn { get; set; }
    }
}