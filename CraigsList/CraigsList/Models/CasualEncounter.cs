using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraigsList.Models
{
    public class CasualEncounter : Ads
    {
        public string Gender { get; set; }
        public string Seeking { get; set; }
        public int Age { get; set; }
    }
}