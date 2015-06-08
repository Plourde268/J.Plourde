using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class ShoppingListService
    {
        private IList<Product> _products = new List<Product>();

       public IList<Product> GetItems()
        {
            _products.Add(new Product {Name="Laptop", Price= 300 });
            _products.Add(new Product { Name = "Book", Price = 20 });
            return _products;
        }
    }
}