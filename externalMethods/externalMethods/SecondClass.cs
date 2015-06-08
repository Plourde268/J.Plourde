using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace externalMethods
{
    class SecondClass
    {
        public void whoAmI(string name)
        {
            Console.WriteLine("Hello " + name + ", How you doin?");
        }
        public int addMe(int a, int b)
        {
           // int totalValue;
            int totalValue = (a + b);
            return totalValue;
        }
        public int addMe(int a, int b, int c)
        {
            int totalValue = (a + b + c);
            return totalValue;
            
        }
        
    }
}
