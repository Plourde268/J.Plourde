using Simple_Person.Adapters;
using Simple_Person.Data;
using Simple_Person.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_Person.Controllers
{
    public class HomeController : Controller
    {
        IPersonAdapter _adapter;

        public HomeController()
        {
            _adapter = new PersonDataAdapter();
        }
        public ActionResult Index()
        {
          
           
                //crete a VM
                PersonIndexVm pVm = new PersonIndexVm();
                //populateVm
                pVm.MyPeople = _adapter.GetAll();
                //send Vm to view
                return View(pVm);
          
        }
        public ActionResult GetDetails(int id)
        {
            UpdateVm dVm = new UpdateVm();
            dVm.Update = _adapter.GetPerson(id);
            return View(dVm);
        }

        [HttpGet]
        public ActionResult EditPerson(int id)
        {
            UpdateVm eVm = new UpdateVm();
            eVm.Update = _adapter.GetPerson(id);
            return View(eVm);
        }
        [HttpPost]
        public ActionResult EditPerson(UpdateVm eVm)
        {
            _adapter.UpdatePerson(eVm);
            return RedirectToAction("Index");

        }
        
        public ActionResult CreatePerson()
        {
            UpdateVm cVm = new UpdateVm();
            return View(cVm);
        }
        [HttpPost]
        public ActionResult CreatePerson(UpdateVm tVm) // it could be called penis
        {
            _adapter.CreatePerson(tVm);
            return RedirectToAction("Index");
        }
        
        public ActionResult KillPerson(int id)
        {
            _adapter.DeletePerson(id);
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