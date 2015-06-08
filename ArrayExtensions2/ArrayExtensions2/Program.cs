using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtensions2
{
    class Program
    {
        static void Main()
        {
            
            string[] headlines = new string[]{
                "Martians Attack!",
                "Seahawks lose Superbowl!",
                "Mets suck"
            };


            Console.WriteLine(headlines.GetRandom());
            Console.ReadLine();
            Main();
        }
    }

        public static class StringExtensions
        {
            public static string GetRandom(this Array arrayToExtend)
            {
                Random rnd = new Random();
                //string result = arrayToExtend[rnd.Next(0, arrayToExtend.Length)];     //works with only string[]
                //return result;

                int index = rnd.Next(arrayToExtend.Length);
                return arrayToExtend.GetValue(index).ToString();
            }
        }

    



}
