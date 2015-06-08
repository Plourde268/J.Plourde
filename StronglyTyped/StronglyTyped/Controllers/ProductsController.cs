using StronglyTyped.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTyped.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Name="Milk", Price= 2.99m },
                new Product{Name="Eggs", Price= 2.49m },
                new Product{Name="Cheese", Price= 9.25m },

            };

            IndexViewModel vm = new IndexViewModel()
            {
                Products = products
            };

            return View(vm);
        }
    }
}