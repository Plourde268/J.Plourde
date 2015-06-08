using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CraigsList.Models
{
    public class MockDB
    {
        public static List<Ads> GetAll()
        {
            var ListOfAds = new List<Ads>()
            {
                new Apartments(){Id=1, Title="Loft", CreatedBy="John", CreatedOn= DateTime.Now.AddDays(-7), City="Miami", State="Florida", IsAvailible=true, Price=1200, BedsBaths="2bed/1.5bath", SquareFootage=1000, Animals=true},
                new Apartments(){Id=2, Title="Studio Downtown", CreatedBy="Sue", CreatedOn= DateTime.Now.AddDays(-3), City="Miami", State="Florida", IsAvailible=true, Price=700, BedsBaths="1bed/1bath", SquareFootage=800, Animals=false},
                new Apartments(){Id=3, Title="Spacious Abode", CreatedBy="Tommy", CreatedOn= DateTime.Now.AddDays(-9), City="Miami", State="Florida", IsAvailible=true, Price=1500, BedsBaths="2bed/2bath", SquareFootage=1500, Animals=true},
                new Automobiles(){Id=4, Title="All wheel drive Truck", CreatedBy="Henry", CreatedOn= DateTime.Now.AddDays(-17), City="Miami", State="Florida", IsAvailible=true, Price=10000, Color="White", Make="Toyota", Milage=100000, Year=2002},
                new Automobiles(){Id=5, Title="Convertable Porsche", CreatedBy="Tyler", CreatedOn= DateTime.Now.AddDays(-4), City="Miami", State="Florida", IsAvailible=true, Price=22000, Color="Black", Make="Porsche", Milage=30000, Year=2008},
                new Automobiles(){Id=6, Title="New Mustang", CreatedBy="Jake", CreatedOn= DateTime.Now.AddDays(-12), City="Miami", State="Florida", IsAvailible=true, Price=1700, Color="Red", Make="Ford", Milage=60000, Year=2010},
                new CasualEncounter(){Id=7, Title="Single mammita", CreatedBy="Maria", CreatedOn= DateTime.Now.AddDays(-1), City="Miami", State="Florida", IsAvailible=true, Price=0, Age=19, Gender="Female", Seeking="Male"},
                new CasualEncounter(){Id=8, Title="looking 4 Third Wheel", CreatedBy="Jane", CreatedOn= DateTime.Now.AddDays(-20), City="Miami", State="Florida", IsAvailible=true, Price=0, Age=30, Gender="Female & Male", Seeking="Female"},
                new CasualEncounter(){Id=9, Title="Descrete Chonga", CreatedBy="Stephenia", CreatedOn= DateTime.Now.AddDays(-2), City="Miami", State="Florida", IsAvailible=true, Price=300, Age=23, Gender="Female", Seeking="Male"},
                new Furniture(){Id=10, Title="Dinning room Table", CreatedBy="Sam", CreatedOn= DateTime.Now.AddDays(-37), City="Miami", State="Florida", IsAvailible=true, Price=600, Condition="Good", Type="Table"},
                new Furniture(){Id=11, Title="Couch", CreatedBy="Charlie", CreatedOn= DateTime.Now.AddDays(-13), City="Miami", State="Florida", IsAvailible=true, Price=50, Condition="Muddy", Type="Couch"},
                new Furniture(){Id=12, Title="Bed Frame", CreatedBy="Brian", CreatedOn= DateTime.Now.AddDays(-4), City="Miami", State="Florida", IsAvailible=true, Price=200, Condition="Fair", Type="Bed-Frame"}
            };
            return ListOfAds;
        }

        public static List<Apartments> GetApartments()
        {
            var ListOfAds = new List<Apartments>()
            {
                new Apartments(){Id=1, Title="Loft", CreatedBy="John", CreatedOn= DateTime.Now.AddDays(-7), City="Miami", State="Florida", IsAvailible=true, Price=1200, BedsBaths="2bed/1.5bath", SquareFootage=1000, Animals=true},
                new Apartments(){Id=2, Title="Studio Downtown", CreatedBy="Sue", CreatedOn= DateTime.Now.AddDays(-3), City="Miami", State="Florida", IsAvailible=true, Price=700, BedsBaths="1bed/1bath", SquareFootage=800, Animals=false},
                new Apartments(){Id=3, Title="Spacious Abode", CreatedBy="Tommy", CreatedOn= DateTime.Now.AddDays(-9), City="Miami", State="Florida", IsAvailible=true, Price=1500, BedsBaths="2bed/2bath", SquareFootage=1500, Animals=true}
            };
            return ListOfAds;
        }

        public static List<Automobiles> GetAutomobiles()
        {
            var ListOfAds = new List<Automobiles>()
            {
                new Automobiles(){Id=1, Title="All wheel drive Truck", CreatedBy="Henry", CreatedOn= DateTime.Now.AddDays(-17), City="Miami", State="Florida", IsAvailible=true, Price=10000, Color="White", Make="Toyota", Milage=100000, Year=2002},
                new Automobiles(){Id=2, Title="Convertable Porsche", CreatedBy="Tyler", CreatedOn= DateTime.Now.AddDays(-4), City="Miami", State="Florida", IsAvailible=true, Price=22000, Color="Black", Make="Porsche", Milage=30000, Year=2008},
                new Automobiles(){Id=3, Title="New Mustang", CreatedBy="Jake", CreatedOn= DateTime.Now.AddDays(-12), City="Miami", State="Florida", IsAvailible=true, Price=1700, Color="Red", Make="Ford", Milage=60000, Year=2010}
            };
            return ListOfAds;
        }

        public static List<CasualEncounter> GetCasual()
        {
            var ListOfAds = new List<CasualEncounter>()
            {
                new CasualEncounter(){Id=1, Title="Single mammita", CreatedBy="Maria", CreatedOn= DateTime.Now.AddDays(-1), City="Miami", State="Florida", IsAvailible=true, Price=0, Age=19, Gender="Female", Seeking="Male"},
                new CasualEncounter(){Id=2, Title="looking 4 Third Wheel", CreatedBy="Jane", CreatedOn= DateTime.Now.AddDays(-20), City="Miami", State="Florida", IsAvailible=true, Price=0, Age=30, Gender="Female & Male", Seeking="Female"},
                new CasualEncounter(){Id=3, Title="Descrete Chonga", CreatedBy="Stephenia", CreatedOn= DateTime.Now.AddDays(-2), City="Miami", State="Florida", IsAvailible=true, Price=300, Age=23, Gender="Female", Seeking="Male"}
            };
            return ListOfAds;
        }
        
        public static List<Furniture> GetFurniture()
        {
            var ListOfAds = new List<Furniture>()
            {
                new Furniture(){Id=1, Title="Dinning room Table", CreatedBy="Sam", CreatedOn= DateTime.Now.AddDays(-37), City="Miami", State="Florida", IsAvailible=true, Price=600, Condition="Good", Type="Table"},
                new Furniture(){Id=2, Title="Couch", CreatedBy="Charlie", CreatedOn= DateTime.Now.AddDays(-13), City="Miami", State="Florida", IsAvailible=true, Price=50, Condition="Muddy", Type="Couch"},
                new Furniture(){Id=3, Title="Bed Frame", CreatedBy="Brian", CreatedOn= DateTime.Now.AddDays(-4), City="Miami", State="Florida", IsAvailible=true, Price=200, Condition="Fair", Type="Bed-Frame"}
            };
            return ListOfAds;
        }
    


    }
}