using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraigsList.Models
{
    public class Ads
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool IsAvailible { get; set; }
        public int Price { get; set; }
    }
}