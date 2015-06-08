using CraigsList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CraigsList.Controllers
{
    public class ApartmentsController : Controller
    {
        // GET: Apartments
        public ActionResult Index()
        {
            AdsVm cVm = new AdsVm();
            cVm.AptAds = MockDB.GetApartments();
            return View(cVm);
        }

        public ActionResult Details(int id)
        {
            AdsObjVm cVm = new AdsObjVm();
            cVm.Apt = MockDB.GetApartments().FirstOrDefault(i => i.Id == id);
            return View(cVm);
        }
    }
}