using Simple_Person.Data;
using Simple_Person.Data.Model;
using Simple_Person.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_Person.Adapters
{
    public class PersonDataAdapter : IPersonAdapter
    {
        public List<Person> GetAll()
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                
                List<Person> temp = new List<Person>();
                temp = db.People.ToList();
                return temp;
            }
        }
        public Person GetPerson(int id)
        {
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                var x = db.People.FirstOrDefault(p => p.PersonId == id);
                return x;
            }
        }
        public void UpdatePerson(UpdateVm uVm)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var x = db.People.FirstOrDefault(p => p.PersonId == uVm.Update.PersonId);
                x.FirstName = uVm.Update.FirstName;
                x.LastName = uVm.Update.LastName;
                x.Birthdate = uVm.Update.Birthdate;
                db.SaveChanges();
            }
        }
        public void CreatePerson(UpdateVm cVm)
        {
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                db.People.Add(cVm.Update);
                db.SaveChanges();
            }
        }
        public void DeletePerson(int id)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                var x = db.People.FirstOrDefault(p => p.PersonId == id);
                db.People.Remove(x);
                db.SaveChanges();
            }
        }
    }
}