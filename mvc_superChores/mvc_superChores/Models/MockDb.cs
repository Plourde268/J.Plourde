using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_superChores.Models
{
    public class MockDb
    {
        public static List<Kitchen> GetKitchen()
        {
            var ListOfChores = new List<Kitchen>()
            {
                new Kitchen(){ id= 1, Task= "Wash Dishes", Person= "Julio", DateCreated= DateTime.Now.AddDays(-5), IsCompleted= false},
                new Kitchen(){ id= 2, Task= "Clean Oven", Person= "John", DateCreated= DateTime.Now.AddDays(-2), IsCompleted= false},
                new Kitchen(){ id= 3, Task= "Mop Floor", Person= "Julia", DateCreated= DateTime.Now.AddDays(-7), IsCompleted= true},
                new Kitchen(){ id= 4, Task= "Dry Dishes", Person= "Jesse", DateCreated= DateTime.Now.AddDays(-1), IsCompleted= false},
                new Kitchen(){ id= 5, Task= "Organize Spoons", Person= "Justin", DateCreated= DateTime.Now.AddDays(-5), IsCompleted= true}
            };
            return ListOfChores;
        }
        public static List<Bathroom> GetBathroom()
        {
            var ListOfChores = new List<Bathroom>()
            {
                new Bathroom(){ id= 1, Task= "Clean", Type= "Sink", Person= "Julio", DateCreated= DateTime.Now.AddDays(-5), IsCompleted= false},
                new Bathroom(){ id= 2, Task= "Clean", Type= "Mirror", Person= "John", DateCreated= DateTime.Now.AddDays(-2), IsCompleted= false},
                new Bathroom(){ id= 3, Task= "Mop", Type= "Floor", Person= "Julia", DateCreated= DateTime.Now.AddDays(-7), IsCompleted= true},
                new Bathroom(){ id= 4, Task= "Clean", Type= "Toilet", Person= "Jesse", DateCreated= DateTime.Now.AddDays(-1), IsCompleted= false},
                new Bathroom(){ id= 5, Task= "Organize", Type= "Cabinet", Person= "Justin", DateCreated= DateTime.Now.AddDays(-5), IsCompleted= true}
            };
            return ListOfChores;
        }
    }
}