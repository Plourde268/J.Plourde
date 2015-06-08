using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestsCrazyTaxes
{
    class Program
    {



        static void Main(string[] args)
        {
        }

    }
        public class Person
        {
            //public string  FirstName { get; set; }
            private string _firstName;
            #region Properties
            public string FirstName
            {
                get { return _firstName; }
                set 
                {

                    _firstName =  CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); 
                }
            }


            private string _lastName;

            public string LastName
            {
                get { return _lastName; }
                set { _lastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value); }
            }
            
            public int Age { get; set; }
            #endregion
        }

        public class Tax
        {
            public decimal Calculate(Person person, decimal amountToTax)
            {
                decimal taxAmount = 0;
                //Age <5 = 0
                if (person.Age < 5)
                {
                    return 0;
                };
                //base tax 8%
                taxAmount = amountToTax * .08m;
                //thursday Double
                if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                {
                    taxAmount = taxAmount * 2;
                }
                //fName
                if (person.FirstName.StartsWith("J"))
                {
                    taxAmount = taxAmount * 2;
                }
                //lName
                if (person.LastName.StartsWith("W"))
                {
                    taxAmount = taxAmount - 1;
                }

                //cant be negetive
                return amountToTax;
            }
        }
}
