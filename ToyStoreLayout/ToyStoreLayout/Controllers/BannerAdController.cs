using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToyStoreLayout.Controllers
{
    public class BannerAdController : Controller
    {
        // GET: BannerAd
        [ChildActionOnly]
        public ActionResult GetAd()
        {
            var adText = "Drink a Vanilla Latte!";

            if (DateTime.Now.Hour > 12)
            {
                adText = "Drink a cup of Assam Tea!";
            }

            return PartialView("_BannerAd", adText);
        }

        
    }
}