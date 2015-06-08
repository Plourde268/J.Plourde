using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraigsList.Models
{
    public class Apartments : Ads
    {
        public string BedsBaths { get; set; }
        public int SquareFootage { get; set; }
        public bool Animals { get; set; }

    }
}