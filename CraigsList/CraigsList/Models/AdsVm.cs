using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraigsList.Models
{
    public class AdsVm
    {
        public List<Ads> AllAds { get; set; }
        public List<Automobiles> AutoAds { get; set; }
        public List<Apartments> AptAds { get; set; }
        public List<CasualEncounter> CasualAds { get; set; }
        public List<Furniture> FurnitureAds { get; set; }
    }
}