using cSharp_MannyToManny.Adapters;
using cSharp_MannyToManny.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cSharp_MannyToManny.Controllers
{
    public class HomeController : Controller
    {
        IMovieAdapter _adapter;

        public HomeController()
        {
            _adapter = new MovieDataAdapter();

        }


        public ActionResult Index()
        {
            ActorsIndexVm myVm = new ActorsIndexVm();
            myVm.Greeting = "Eeellloooo Mate";
            myVm.Actors = _adapter.GetActors();
            return View(myVm);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ActorsCreateVm cVm)
        {
            _adapter.AddActor(cVm);
            return RedirectToAction("Index");
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