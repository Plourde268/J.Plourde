using CraigsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CraigsList.Controllers
{
    public class AutomobilesController : Controller
    {
        // GET: Automobiles
        public ActionResult Index()
        {
            AdsVm cVm = new AdsVm();
            cVm.AutoAds = MockDB.GetAutomobiles();
            return View(cVm);
        }

        public ActionResult Details(int id)
        {
            AdsObjVm cVm = new AdsObjVm();
            cVm.Auto = MockDB.GetAutomobiles().FirstOrDefault(i => i.Id == id);
            return View(cVm);
        }
    }
}