using mvc_superChores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_superChores.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ChoresVm cVm = new ChoresVm();
            cVm.KitchenChores = MockDb.GetKitchen();
            cVm.BathroomChores = MockDb.GetBathroom();
            return View(cVm);
        }

        public ActionResult Kitchen()
        {
            ChoresVm cVm = new ChoresVm();
            cVm.KitchenChores = MockDb.GetKitchen();
            return View(cVm);
        }

        public ActionResult First()
        {
            ChoresVm cVm = new ChoresVm();
            cVm.KitChore = (Kitchen)MockDb.GetKitchen().FirstOrDefault(k => k.id == 1);
            cVm.BatChore = (Bathroom)MockDb.GetBathroom().FirstOrDefault(b => b.id == 1);
            return View(cVm);
        }

        public ActionResult KitchenDetails(int id)
        {
            ChoresVm cVm = new ChoresVm();
            cVm.KitChore = (Kitchen)MockDb.GetKitchen().FirstOrDefault(k => k.id == id);
            return View(cVm);
        }

        public ActionResult BathroomDetails(int id)
        {
            ChoresVm cVm = new ChoresVm();
            cVm.BatChore = (Bathroom)MockDb.GetBathroom().FirstOrDefault(b => b.id == id);
            return View(cVm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}