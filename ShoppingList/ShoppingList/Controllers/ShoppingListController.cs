using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        // GET: ShoppingList
        public ActionResult Index()
        {
            //repo used to be right hurr
            IList<Product> items = _repo.GetItems();
            ShoppingListViewModel vm = new ShoppingListViewModel();
            vm.FirstName = "Keigo";
            vm.LastName = "Ito";
            vm.Products = items;
            vm.Total = items.Sum(p => p.Price);
            return View(vm);
        }
        ShoppingListService _repo;
        public ShoppingListController()
        {
            _repo = new ShoppingListService();
        }
    }
}