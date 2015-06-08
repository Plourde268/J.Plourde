using CraigsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CraigsList.Controllers
{
    public class FurnitureController : Controller
    {
        // GET: Furniture
        public ActionResult Index()
        {
            AdsVm cVm = new AdsVm();
            cVm.FurnitureAds = MockDB.GetFurniture();
            return View(cVm);
        }
        public ActionResult Details(int id)
        {
            AdsObjVm cVm = new AdsObjVm();
            cVm.Furn = MockDB.GetFurniture().FirstOrDefault(i => i.Id == id);
            return View(cVm);
        }
    }
}