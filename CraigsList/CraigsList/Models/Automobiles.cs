using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraigsList.Models
{
    public class Automobiles : Ads
    {
        public int Milage { get; set; }
        public string Make { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
    }
}