using System;
using System.Collections;

namespace FirstApp
{

    class Program
    {
        public static string ReverseString(string yourSentence)
        {
            string[] deeznuts = yourSentence.Split(' ');
            Array.Reverse(deeznuts);
            return string.Join(" ", deeznuts);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter your favorite sentence:");
            var yourSentence = Console.ReadLine();
            Console.WriteLine(ReverseString(yourSentence));
            Console.ReadLine();
        }
    }
}