using Simple_Person.Data.Model;
using Simple_Person.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Person.Adapters
{
    public interface IPersonAdapter
    {
        List<Person> GetAll();
        
        Person GetPerson(int id);
        
        void UpdatePerson(UpdateVm uVm);

        void CreatePerson(UpdateVm cVm);

        void DeletePerson(int id);
    }
}

