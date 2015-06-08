using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouteExample.Controllers
{
    public class DocumentsController : Controller
    {
        // GET: Documents
        public ActionResult GetDocument(string path)
        {
            //var document = DocumentRepository.GetDocumentFromDatabase(path);
            return View();
        }
    }
}