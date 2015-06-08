using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace externalMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an external class that does functionality for us
            //then our main class is going to call second class to preform 
            //types of action
            SecondClass exMeth = new SecondClass();
            exMeth.whoAmI("David");


            Console.WriteLine(exMeth.addMe(3, 8));
            Console.WriteLine(exMeth.addMe(3, 8, 4));

            Console.WriteLine(MyMethods.addMe(1, 2));
            Console.WriteLine(MyMethods.addMe(1, 2, 3));

            Console.WriteLine(MyMethods.addMe(1, 2, 3) / MyMethods.addMe(1, 2));

            Console.WriteLine(MyMethods.addName("David"));
            Console.WriteLine(MyMethods.addName("curren$y", "TradeMark"));


            Console.ReadLine();
        }
    }
}
