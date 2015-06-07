using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desicions
{
    class Program
    {
        static void Main()
        {
            /*
            Console.WriteLine("Please type something and press the enter key.");
            string userValue;
            userValue = Console.ReadLine();
            Console.WriteLine("You typed: " + userValue);
            */

            Console.WriteLine("Would you like whats behind door number 1 or 2?");
            string userValue = Console.ReadLine();

            /*
            string message = "";

            if (userValue == "1")
               message = "You have just won a brand new car!";
            else if(userValue == "2")
                message = "You just got a paid vacation for two at the top of Mongoloid Mountain";
            else if(userValue == "3")
                message = "You won new underwear!";
            else
                message = "You are a loser!";

            Console.WriteLine(message);
             */

            string message = (userValue =="1") ? "Boat" : "Strand of lint";
            Console.WriteLine("You won a new {0}", message);
            Console.ReadLine();
            Main();
        }
    }
}
