using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Checking CheckAccount { get; set; }
        public Savings SaveAccount { get; set; }

        //Checking  = new Checking();
        //Savings y = new Savings();
        public Customer()
        {
            this.CheckAccount = new Checking();
            this.SaveAccount = new Savings();
        }
    }
}
