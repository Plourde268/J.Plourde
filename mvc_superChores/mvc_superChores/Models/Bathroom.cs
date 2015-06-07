using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_superChores.Models
{
    public class Bathroom
    {
        public int id { get; set; }
        public string Task { get; set; }
        public string Type { get; set; }
        public string Person { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsCompleted { get; set; }
    }
}