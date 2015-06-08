using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Everything is Awesome!";
            string revMessage = message.Reverse();
            Console.WriteLine(revMessage);
            Console.ReadLine();

            message.Reverse().WriteColor(ConsoleColor.DarkCyan, ConsoleColor.DarkMagenta);

            Console.ReadLine();
        }
    
    }
   

    public static class StringExtensions
    {
        public static string Reverse(this string stringToExtend)
        {
            char[] textArray = stringToExtend.ToCharArray();      
            Array.Reverse(textArray);
            return new String(textArray);
        }

        public static void WriteColor(this string stringToExtend, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.WriteLine(stringToExtend);
        }
    }
}
