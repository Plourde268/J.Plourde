using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouteExample.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult GetEntryByDate(DateTime entryDate)
        {
            return Content("You requested the blog entery for date" + entryDate.ToLongDateString());
        }

        public ActionResult GetEntryById(int entryId)
        {

            return Content("You requested the blog entry for id " + entryId.ToString());
        }
    }
}