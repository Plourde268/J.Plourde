using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyStoreLayout.Controllers
{
    public class QuoteController : Controller
    {

        private static List<string> _quote = new List<string>();

        public QuoteController()
        {
            if (_quote.Count == 0)
            {
                _quote.Add("In matters of truth and justice, there is no difference between large and small problems, for issues concerning the treatment of people are all the same.");
                _quote.Add("The only source of knowledge is experience.");
                _quote.Add("The world is a dangerous place to live; not because of the people who are evil, but because of the people who don't do anything about it.");
                _quote.Add("Any man who reads too much and uses his own brain too little falls into lazy habits of thinking.");
            }
        }

        // GET: Quote
        [ChildActionOnly]
        public ActionResult GetQuote()
        {
            Random rnd = new Random();
            int index = rnd.Next(_quote.Count);
            return PartialView("_QuotePartial", _quote[index]);
        }  
    }
}