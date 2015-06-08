using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraigsList.Models
{
    public class Furniture : Ads
    {
        public string Type { get; set; }
        public string Condition { get; set; }

    }
}