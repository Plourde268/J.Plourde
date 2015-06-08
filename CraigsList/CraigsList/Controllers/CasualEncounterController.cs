using CraigsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CraigsList.Controllers
{
    public class CasualEncounterController : Controller
    {
        // GET: CasualEncounter
        public ActionResult Index()
        {
            AdsVm cVm = new AdsVm();
            cVm.CasualAds = MockDB.GetCasual();
            return View(cVm);
        }

        public ActionResult Details(int id)
        {
            AdsObjVm cVm = new AdsObjVm();
            cVm.Casual = MockDB.GetCasual().FirstOrDefault(i => i.Id == id);
            return View(cVm);
        }
    }
}