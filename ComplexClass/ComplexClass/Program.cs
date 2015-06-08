using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer alice = new Customer();
            
            alice.CheckAccount.Amount = 100.00m;
            
            alice.SaveAccount.Amount = 0.00m;

            Console.WriteLine("Alice has {0} in her checking account and {1} in her savings account.", alice.CheckAccount.Amount, alice.SaveAccount.Amount);
            Console.ReadLine();
        }
    }
}
