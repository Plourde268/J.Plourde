using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNewsWithArray
{
    class Program
    {

        

        

        static void Main()
        {
            
            var headLines = new string[]{
                "Patriots win the Superbowl", "Angular 2.0 is Out", "The end is near"
            };
            Random rnd = new Random();

            Console.WriteLine(headLines[rnd.Next(0, headLines.Length)]);
            Console.ReadLine();
            
            Main();
            
        }
    }
}
